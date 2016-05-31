Public Class frmAgregarLibro

    Dim previewLibro As New Libro("Preview", True)
    Private Sub frmAgregarLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        previewLibro.Location = New Point(35, 60)
        Me.Controls.Add(previewLibro)
    End Sub

    Private Sub chkHabilitado_CheckedChanged(sender As Object, e As EventArgs) Handles chkHabilitado.CheckedChanged
        If chkHabilitado.Checked Then
            previewLibro.imgNoDisponible.BackgroundImage = Nothing
        Else
            previewLibro.imgNoDisponible.BackgroundImage = My.Resources.sombra_nodisponible()
        End If
    End Sub

    Private Sub btnCambiarPortada_Click(sender As Object, e As EventArgs) Handles btnCambiarPortada.Click
        previewLibro.imgNoDisponible_Click(previewLibro.imgNoDisponible, Nothing)
    End Sub

End Class