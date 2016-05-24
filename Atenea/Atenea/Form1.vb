Public Class frmAtenea

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim B As Integer = 50
        Dim xx As Integer = 0

        Dim rng As New Random()
        For y As Integer = 1 To 20
            Dim randomBool As Boolean = rng.Next(0, 2) > 0
            Dim x As New Libro("El que tenías ahí", randomBool)
            panelLibros.Controls.Add(x)
        Next
    End Sub

    Private Sub imgFondo_Click(sender As Object, e As EventArgs) Handles imgFondo.Click

    End Sub
End Class
