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
 
    Private Sub frmEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim libro As Libro

        libro = New Libro(llaveLibro, False, True)
        libro.Parent = Me
        libro.imgNoDisponible.Cursor = Cursors.Default
        libro.Location = New Point(25, 60)
        libro.actualizarDatos()

        lblAutor.Text = "Autor: " + libro.Autor
        lblGenero.Text = "Genero: " + libro.Genero
        lblID.Text = "ID: " + libro.ID
        lblCondicion.Text = "Condición: " + libro.Condicion

        If interfazDevolver Then
            Me.Text = "Devolución de libro · Atenea"
            lblAccion.Text = "¿Seguro que quiere devolver este libro?"
            BtnEliminar.Text = "Devolver"
            lblPrestado.Text = "Prestado a (CI): " + CIUsuario
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
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
            conexion.Close()

            Me.Dispose()
        End Using
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub
End Class