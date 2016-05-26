Imports MySql.Data.MySqlClient
Public Class frmLogin
    Friend tipoUsuario As String
    Dim registrando As Boolean

    Private Sub btnTipo_Click(sender As Object, e As EventArgs) Handles btnFuncionario.Click, btnUsuario.Click
        tipoUsuario = "usuario"

        If sender Is btnFuncionario Then
            tipoUsuario = "funcionario"
        End If

        pedirDatosRegistro()
    End Sub

    Private Sub preguntarTipoCuenta(sender As Object, e As EventArgs) Handles btnRegistro.Click
        registrando = True
        Atenea.Text = "Registro · Atenea"
        lblBienvenido.Text = "Registro de"

        btnUsuario.Visible = True
        btnFuncionario.Visible = True
        btnRegistro.Visible = False
        btnEntrar.Visible = False
        btnCancelar.Visible = True

        txtCedula.Visible = False
        lblCedula.Visible = False
        txtContra.Visible = False
        lblContra.Visible = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        registrando = False
        reestablecerVentana()
    End Sub

    Public Sub pedirDatosRegistro()
        lblBienvenido.Text = "Nuevo " & tipoUsuario
        Atenea.Text = "Nuevo " & tipoUsuario & " · Atenea"

        lblCedula.Location = New Point(39, 167)
        lblContra.Location = New Point(214, 167)
        txtCedula.Location = New Point(43, 190)
        txtContra.Location = New Point(217, 190)

        btnEntrar.Text = "Crear cuenta"
        btnEntrar.Visible = True

        txtApellido.Visible = True
        lblApellido.Visible = True
        txtNombre.Visible = True
        lblNombre.Visible = True

        txtCedula.Visible = True
        lblCedula.Visible = True
        txtContra.Visible = True
        lblContra.Visible = True

        txtCedula.Text = Nothing
        txtContra.Text = Nothing

        btnRegistro.Visible = False
        btnCancelar.Visible = True

        btnUsuario.Visible = False
        btnFuncionario.Visible = False
    End Sub

    Private Sub reestablecerVentana()
        btnEntrar.Visible = False
        btnCancelar.Visible = False
        btnFuncionario.Visible = False
        btnUsuario.Visible = False

        btnEntrar.Visible = True
        btnRegistro.Visible = True

        txtApellido.Visible = False
        lblApellido.Visible = False

        txtNombre.Visible = False
        lblNombre.Visible = False

        lblCedula.Visible = True
        txtCedula.Visible = True
        lblContra.Visible = True
        txtContra.Visible = True

        txtCedula.Text = Nothing
        txtContra.Text = Nothing

        btnEntrar.Text = "Entrar"

        lblBienvenido.Text = "Bienvenido a" & ControlChars.NewLine & "Atenea"
        Atenea.Text = "Ingreso · Atenea"

        lblCedula.Location = New Point(130, 105)
        lblContra.Location = New Point(130, 163)
        txtCedula.Location = New Point(134, 128)
        txtContra.Location = New Point(134, 183)
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If Not registrando Then
            If Not checkLogin() Then
                lblInfo.Text = "-- Datos incorrectos --"
                lblInfo.Visible = True
                Return
            End If
        Else
            If Not agregarUsuario() Then
                lblInfo.Text = "-- Datos incorrectos --"
                lblInfo.Visible = True
                Return
            End If
        End If

        Me.Dispose()
        Atenea.agregarAtenea()
    End Sub

    Function checkLogin() As Boolean
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT * FROM `usuarios` WHERE CI='{0}' AND Contraseña='{1}';", txtCedula.Text, txtContra.Text), Atenea.conexion)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Dim correcto As Boolean = False

        While reader.Read()
            reader.Read()
            reader.GetString(0)
            correcto = True
        End While

        reader.Close()

        Return correcto
    End Function

    Function agregarUsuario() As Boolean
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO `usuarios` VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');", txtCedula.Text, txtNombre.Text, txtApellido.Text, txtContra.Text, tipoUsuario), Atenea.conexion)
        Dim registro = True
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Console.Write(ex.ToString())
            lblInfo.Text = "-- El usuario ya existe --"
            registro = False
        End Try

        Return registro
    End Function

    Private Sub checkEscrito(sender As Object, e As EventArgs) Handles txtCedula.TextChanged, txtContra.TextChanged, txtNombre.TextChanged, txtApellido.TextChanged
        btnEntrar.Enabled = Not (String.IsNullOrWhiteSpace(txtCedula.Text) Or String.IsNullOrWhiteSpace(txtContra.Text) Or String.IsNullOrWhiteSpace(txtNombre.Text) Or String.IsNullOrEmpty(txtApellido.Text))
        If Not registrando Then
            btnEntrar.Enabled = Not (String.IsNullOrWhiteSpace(txtCedula.Text) Or String.IsNullOrEmpty(txtContra.Text))
        End If

        lblInfo.Visible = False
    End Sub

    Private Sub accionClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCedula.KeyDown, txtContra.KeyDown, txtNombre.KeyDown, txtApellido.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            If btnEntrar.Enabled Then
                btnEntrar.PerformClick()
            End If
        End If
    End Sub

End Class
