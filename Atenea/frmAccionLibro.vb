Imports MySql.Data.MySqlClient ' Importa el módulo de MySQL
Public Class frmAccionLibro
    Dim llaveLibro, CIUsuario As String
    Dim interfazDevolver As Boolean

    Public Sub New(ByVal llave As String, Optional ByVal devolver As Boolean = False, Optional ByVal CI As String = Nothing)
        InitializeComponent()
        llaveLibro = llave
        interfazDevolver = devolver
        CIUsuario = CI
    End Sub
 
    Private Sub frmAccionLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Al cargar el form, un preview del libro (llaveLibro) es creado, luego se ubica y se actalizan los datos
        Dim libro As Libro

        libro = New Libro(llaveLibro, False, True)
        libro.Parent = Me
        libro.imgNoDisponible.Cursor = Cursors.Default
        libro.Location = New Point(25, 60)
        libro.actualizarDatos()

        'Muestra la info del libro que se va a borrar/devolver
        lblAutor.Text = "Autor: " + libro.Autor
        lblGenero.Text = "Genero: " + libro.Genero
        lblID.Text = "ID: " + libro.ID
        lblCondicion.Text = "Condición: " + libro.Condicion

        'Si es una devolución del libro... idk
        If interfazDevolver Then
            Me.Text = "Devolución de libro · Atenea"
            lblAccion.Text = "¿Seguro que quiere devolver este libro?"
            btnEliminar.Text = "Devolver"
            lblPrestado.Text = "Prestado a (CI): " + CIUsuario
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click 'Al clickear el boton eliminar...
        Dim conexion As DB = New DB() 'Se conecta con la base de datos

        Using cmd As New MySqlCommand()
            With cmd
                .Connection = conexion.Conn
                .CommandText = "DELETE FROM `libro` WHERE ID=@id;" 'Si el libro va a ser borrado, lo borra de la tabla libro según su ID
                If interfazDevolver Then
                    .CommandText = "DELETE FROM `prestamo` WHERE ID=@id;" 'Si el libro va a ser devuelto lo borra de la tabla préstamo según su ID
                End If
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@id", llaveLibro)
            End With
            cmd.ExecuteNonQuery()

            Atenea.atenea.cargarLibros()
            conexion.Close() 'Cierra la conexión

            Me.Dispose()
        End Using
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub
End Class