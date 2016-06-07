Imports MySql.Data.MySqlClient
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
        Try
            Atenea.DB.Reader.Close()
        Catch ex As Exception
        End Try

        Using cmd As New MySqlCommand()
            With cmd
                .Connection = Atenea.DB.Conn
                .CommandText = "DELETE FROM `libro` WHERE ID=@id;"
                If interfazDevolver Then
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