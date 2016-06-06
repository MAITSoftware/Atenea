Imports MySql.Data.MySqlClient
Public Class frmEliminar
    Dim llaveLibro As String
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

    End Sub

    Public Sub New(ByVal llave As String)
        InitializeComponent()
        llaveLibro = llave
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        Using cmd As New MySqlCommand()
            With cmd
                .Connection = Atenea.conexion
                .CommandText = "DELETE FROM `libro` WHERE ID=@id;"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@id", llaveLibro)
            End With
            Try
                cmd.ExecuteNonQuery()
                Atenea.atenea.cargarLibros()
                Me.Dispose()
            Catch ex As Exception
            End Try
        End Using

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub
End Class