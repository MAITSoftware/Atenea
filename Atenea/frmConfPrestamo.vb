Public Class frmConfPrestamo

    Private Sub frmConfPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim libro As Libro
        libro = New Libro("peppa", False, True)
        libro.Location = New Point(58, 105)
        libro.Parent = Panel1
        libro.actualizarDatos()
    End Sub
End Class