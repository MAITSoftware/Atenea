Imports MySql.Data.MySqlClient ' Importa el módulo de MySQL
Public Class frmNewLogin

    ' Ventana de logueo

    Private Sub rbtnFuncionario_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFuncionario.CheckedChanged
        If rbtnFuncionario.Checked Then 'Si rbtn fue seleccionado (funcionario seleccionado)
            txtContrasenia.Text = ""
            lblContrasenia.Visible = True 'Muestra lblContrasenia
            txtContrasenia.Visible = True 'Muestra txtContrasenia
            lblNuevoUsuario.Visible = True 'Muestra lblNuevoUsuario
            btnRegistrarse.Visible = True 'Muestra btnRegistrarse

            lblCI.Location = New Point(391, 128) 'Cambia la posición de lblCI
            txtICI.Location = New Point(372, 155) 'Cambia la posición de txtICI
            btnEntrar.Location = New Point(393, 284) 'Cambia la posición de btnEntrar

        Else 'Sino
            txtICI.Text = ""
            lblContrasenia.Visible = False 'Oculta lblContrasenia
            txtContrasenia.Visible = False 'Oculta txtContrasenia
            lblNuevoUsuario.Visible = False 'Oculta lblNuevoUsuario
            btnRegistrarse.Visible = False 'Oculta btnRegistrarse

            lblCI.Location = New Point(391, 149) 'Cambia la posición de lblCI
            txtICI.Location = New Point(372, 176) 'Cambia la posición de txtICI
            btnEntrar.Location = New Point(393, 232) 'Cambia la posición de btnEntrar

        End If
    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        ' Al hacer click en btnRegistrarse, agregar Registro
        Atenea.agregarRegistro()
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        'Al hacer click en btnEntrar
        Dim precisaNick As Boolean = True 'Define precisaNick como Boolean
        Dim datosCorrectos As Boolean = False 'Define datosCorrectos como Boolean

        Dim conexion As DB = New DB()

        If rbtnFuncionario.Checked Then 'Si rbtnFuncionario es seleccionado
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM `usuario` WHERE CI='@ID' AND Contrasenia='@Contra' AND Tipo='Funcionario';", conexion.Conn) 'Define cmd como MySqlCommand con los parámetros sentencia y Atenea.DB.Conn
            cmd.Parameters.AddWithValue("@ID", txtICI.Text)
            cmd.Parameters.AddWithValue("@Contra", txtContrasenia.Text)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                reader.Read()
                reader.GetString(0)
                datosCorrectos = True 'Define datosCorrectos como true
            End While

            If Not datosCorrectos Then 'Si datosCorrectos es false
                lblInfo.Visible = True 'Muestra lblInfo
                Return
            End If

            reader.Close()
            Atenea.agregarAtenea(txtICI.Text, False, True)
            conexion.Conn.Close()

        Else 'Si rbtnFuncionario no es seleccionado
            sentencia = String.Format("SELECT `Nombre`, `Tipo` FROM `usuario` WHERE CI='{0}';", txtICI.Text)
            Dim cmd As MySqlCommand = New MySqlCommand(sentencia, conexion.Conn) 'Define cmd como MySqlCommand con los parámetros sentencia y Atenea.DB.Conn
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                reader.Read()
                reader.GetString(0)
                If reader.GetString(1) = "Funcionario" Then
                    rbtnFuncionario.Checked = True
                    reader.Close()
                    Return
                End If

                precisaNick = False 'Define precisaNick como false
            End While

            reader.Close()
            conexion.Conn.Close()
            Atenea.agregarAtenea(txtICI.Text, precisaNick)
        End If

    End Sub

    Private Sub checkEscrito(sender As Object, e As EventArgs) Handles txtICI.TextChanged, txtContrasenia.TextChanged
        ' Comprueba que haya algo realmente escrito en los campos'
        btnEntrar.Enabled = Not (String.IsNullOrWhiteSpace(txtICI.Text)) 'btnEntrar se activará si txtICI no está vacío
        If rbtnFuncionario.Checked Then 'Si rbtn fue seleccionado
            btnEntrar.Enabled = Not (String.IsNullOrWhiteSpace(txtICI.Text) Or String.IsNullOrEmpty(txtContrasenia.Text)) 'btnEntrar se activará si txtICI o txtContrasenia no están vacíos
        End If

        lblInfo.Visible = False 'Oculta lblInfo
    End Sub

    Private Sub txtCI_TextChanged(t As Object, e As KeyPressEventArgs) Handles txtICI.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        End If
    End Sub


    Private Sub EnterClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtICI.KeyDown, txtContrasenia.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            btnEntrar.PerformClick()
        End If
    End Sub
End Class
