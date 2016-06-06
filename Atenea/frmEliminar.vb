Imports MySql.Data.MySqlClient
Public Class frmEliminar
    Dim llaveLibro As String 'Define llaveLibro como String
    Private Sub frmEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim libro As Libro 'Define libro como Libro
        libro = New Libro(llaveLibro, False, True)
        libro.Parent = Me
        libro.imgNoDisponible.Cursor = Cursors.Default
        libro.Location = New Point(25, 60) 'Fija la posición de libro 
        libro.actualizarDatos()
        lblAutor.Text = "Autor: " + libro.Autor 'Define lblAutor como "Autor: " y el autor del libro
        lblGenero.Text = "Genero: " + libro.Genero 'Define lblGenero como "Género: " y el género del libro
        lblID.Text = "ID: " + libro.ID 'Define lblID como "ID: " y el ID del libro
        lblCondicion.Text = "Condición: " + libro.Condicion 'Define lblCondicion.Text 

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