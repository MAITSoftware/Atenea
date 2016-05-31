Public Class frmNewLogin

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblBienvenido.Click

    End Sub

    Private Sub lblContrasenia_Click(sender As Object, e As EventArgs) Handles lblContrasenia.Click, lblNuevoUsuario.Click

    End Sub

    Private Sub rbtnUsuario_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnUsuario.CheckedChanged
    
    End Sub

    Private Sub rbtnFuncionario_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFuncionario.CheckedChanged
        If rbtnFuncionario.Checked Then
            lblContrasenia.Visible = True
            txtContrasenia.Visible = True
            btnEntrar.Visible = True
            lblNuevoUsuario.Visible = True
        Else
            lblContrasenia.Visible = False
            txtContrasenia.Visible = False
            btnEntrar.Visible = False
            lblNuevoUsuario.Visible = False
        End If
    End Sub

    Private Sub txtICI_TextChanged(sender As Object, e As EventArgs) Handles txtICI.TextChanged

    End Sub

    Private Sub txtContrasenia_TextChanged(sender As Object, e As EventArgs) Handles txtContrasenia.TextChanged

    End Sub

    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
