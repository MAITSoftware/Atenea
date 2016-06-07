Imports MySql.Data.MySqlClient
Public Class frmAccionLibro
    Dim llaveLibro As String
    Dim devolucion As Boolean
    Dim CIUsuario As String
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

        If devolucion Then
            Me.Text = "Devolución de libro · Atenea"
            lblAccion.Text = "¿Seguro que quiere devolver este libro?"
            BtnEliminar.Text = "Devolver"
            lblPrestado.Text = "Prestado a (CI): " + CIUsuario
        End If

    End Sub

    Public Sub New(ByVal llave As String, Optional ByVal devolver As Boolean = False, Optional ByVal CI As String = Nothing)
        InitializeComponent()
        llaveLibro = llave
        devolucion = devolver
        CIUsuario = CI
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Atenea.reader.Close()
        Catch ex As Exception
        End Try
        Using cmd As New MySqlCommand()
            With cmd
                .Connection = Atenea.conexion
                .CommandText = "DELETE FROM `libro` WHERE ID=@id;"
                If devolucion Then
                    .CommandText = "DELETE FROM `prestamo` WHERE ID=@id;"
                End If
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