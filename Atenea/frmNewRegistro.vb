Public Class frmNewRegistro

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Atenea.agregarLogin()
    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Atenea.agregarAtenea()
    End Sub
End Class
