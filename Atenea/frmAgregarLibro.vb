Public Class frmAgregarLibro

    Private Sub frmAgregarLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim previewLibro As New Libro("Preview", True)
        previewLibro.Location = New Point(28, 36)
        Me.Controls.Add(previewLibro)
    End Sub
End Class