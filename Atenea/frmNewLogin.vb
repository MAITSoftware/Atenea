Public Class frmNewLogin

    Private Sub rbtnFuncionario_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFuncionario.CheckedChanged
        If rbtnFuncionario.Checked Then
            lblContrasenia.Visible = True
            txtContrasenia.Visible = True
            lblNuevoUsuario.Visible = True
            btnRegistrarse.Visible = True

            lblCI.Location = New Point(391, 128)
            txtICI.Location = New Point(372, 155)
            btnEntrar.Location = New Point(393, 284)
        Else
            lblContrasenia.Visible = False
            txtContrasenia.Visible = False
            lblNuevoUsuario.Visible = False
            btnRegistrarse.Visible = False

            lblCI.Location = New Point(391, 149)
            txtICI.Location = New Point(372, 176)
            btnEntrar.Location = New Point(393, 232)

        End If
    End Sub

End Class
