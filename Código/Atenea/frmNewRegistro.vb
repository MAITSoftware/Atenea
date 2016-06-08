Imports MySql.Data.MySqlClient  ' Importa el módulo de MySQL
Public Class frmNewRegistro

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click 'Al hacer click en btnCancelar
        Atenea.agregarLogin()
    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click 'Al hacer click en btnRegistrarse
        Dim conexion As New DB()
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO `usuario` VALUES ('{0}', '{1}', '{2}', '{3}', 'Funcionario');", txtCI.Text, txtNombre.Text, txtApellido.Text, txtContrasenia.Text), conexion.Conn)

        Try
            cmd.ExecuteNonQuery()
            conexion.Close()
            Atenea.agregarAtenea(txtCI.Text, False, True)
        Catch ex As Exception
            Console.Write(ex.ToString())
            lblInfo.Visible = True 'Muestra lblInfo
        End Try

    End Sub

    Private Sub checkEscrito(sender As Object, e As EventArgs) Handles txtNombre.TextChanged, txtApellido.TextChanged, txtCI.TextChanged, txtContrasenia.TextChanged
        btnRegistrarse.Enabled = Not (String.IsNullOrWhiteSpace(txtNombre.Text) Or String.IsNullOrWhiteSpace(txtApellido.Text) Or String.IsNullOrWhiteSpace(txtCI.Text) Or String.IsNullOrEmpty(txtContrasenia.Text))
        'btnRegistrarse se activará si los campos txtCI, txtNombre, txtApellido y txtContrasenia han sido llenados
        lblInfo.Visible = False 'Oculta lblInfo
    End Sub

    Private Sub txtCI_TextChanged(t As Object, e As KeyPressEventArgs) Handles txtCI.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        End If
    End Sub

    Private Sub EnterClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCI.KeyDown, txtNombre.KeyDown, txtApellido.KeyDown, txtContrasenia.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            btnRegistrarse.PerformClick()
        End If
    End Sub
End Class
