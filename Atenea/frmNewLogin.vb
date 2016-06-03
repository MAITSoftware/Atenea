Imports MySql.Data.MySqlClient
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
            txtICI.Text = ""
            lblContrasenia.Visible = False
            txtContrasenia.Visible = False
            lblNuevoUsuario.Visible = False
            btnRegistrarse.Visible = False

            lblCI.Location = New Point(391, 149)
            txtICI.Location = New Point(372, 176)
            btnEntrar.Location = New Point(393, 232)

        End If
    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        Atenea.agregarRegistro()
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim precisaNick As Boolean = True
        Dim datosCorrectos As Boolean = False
        Dim sentencia As String
        Try
            Atenea.reader.Close()
        Catch ex As Exception
        End Try


        If rbtnFuncionario.Checked Then
            sentencia = String.Format("SELECT * FROM `usuario` WHERE CI='{0}' AND Contrasenia='{1}' AND Tipo='Funcionario';", txtICI.Text, txtContrasenia.Text)
            Dim cmd As MySqlCommand = New MySqlCommand(sentencia, Atenea.conexion)
            Atenea.reader = cmd.ExecuteReader()

            While Atenea.reader.Read()
                Atenea.reader.Read()
                Atenea.reader.GetString(0)
                datosCorrectos = True
            End While

            If Not datosCorrectos Then
                lblInfo.Visible = True
                Return
            End If

            Atenea.reader.Close()
            Atenea.agregarAtenea(txtICI.Text, False, True)

        Else
            sentencia = String.Format("SELECT `Nombre`, `Tipo` FROM `usuario` WHERE CI='{0}';", txtICI.Text)
            Dim cmd As MySqlCommand = New MySqlCommand(sentencia, Atenea.conexion)
            Atenea.reader = cmd.ExecuteReader()

            While Atenea.reader.Read()
                Atenea.reader.Read()
                Atenea.reader.GetString(0)
                If Atenea.reader.GetString(1) = "Funcionario" Then
                    rbtnFuncionario.Checked = True

                    Atenea.reader.Close()
                    Return
                End If

                precisaNick = False
            End While

            Atenea.reader.Close()
            Atenea.agregarAtenea(txtICI.Text, precisaNick)
        End If

    End Sub

    Private Sub checkEscrito(sender As Object, e As EventArgs) Handles txtICI.TextChanged, txtContrasenia.TextChanged
        btnEntrar.Enabled = Not (String.IsNullOrWhiteSpace(txtICI.Text))
        If rbtnFuncionario.Checked Then
            btnEntrar.Enabled = Not (String.IsNullOrWhiteSpace(txtICI.Text) Or String.IsNullOrEmpty(txtContrasenia.Text))
        End If

        lblInfo.Visible = False
    End Sub
End Class
