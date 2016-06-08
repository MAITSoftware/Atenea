Imports MySql.Data.MySqlClient ' Importa el módulo de MySQL
Public Class frmAccionLibro

    ' frmAccionLibro: form que permite alternar entre eliminar / devolver libro.

    Dim llaveLibro, CIUsuario As String
    Dim interfazDevolver As Boolean

    Public Sub New(ByVal llave As String, Optional ByVal devolver As Boolean = False, Optional ByVal CI As String = Nothing)
        ' Al crear el form, setear los valores.
        InitializeComponent()
        llaveLibro = llave
        interfazDevolver = devolver
        CIUsuario = CI
    End Sub
 
    Private Sub frmAccionLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Al cargar el form, un preview del libro (llaveLibro) es creado, luego se ubica y se actalizan los datos
        Dim libro As Libro

        libro = New Libro(llaveLibro, True)
        libro.Parent = Me
        libro.imgNoDisponible.Cursor = Cursors.Default
        libro.Location = New Point(25, 60)
        libro.actualizarDatos()

        lblAutor.Text = "Autor: " + libro.Autor
        lblGenero.Text = "Género: " + libro.Genero
        lblID.Text = "ID: " + libro.ID
        lblCondicion.Text = "Condición: " + libro.Condicion

        If interfazDevolver Then
            Me.Text = "Devolución de libro · Atenea"
            lblAccion.Text = "¿Seguro que quiere devolver este libro?"
            btnEliminar.Text = "Devolver"
            lblPrestado.Text = "Prestado a (CI): " + CIUsuario
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Al clickear el boton eliminar: elimina o actualiza dependiendo de la función del form.
        Dim conexion As DB = New DB()

        Using cmd As New MySqlCommand()
            With cmd
                .Connection = conexion.Conn
                .CommandText = "DELETE FROM `libro` WHERE ID=@id;"
                If interfazDevolver Then
                    .CommandText = "DELETE FROM `prestamo` WHERE ID=@id;" 
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
        ' Destruye la ventana
        Me.Dispose()
    End Sub
End Class