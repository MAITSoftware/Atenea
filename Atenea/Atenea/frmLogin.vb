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
        Me.Dispose()

        Atenea.agregarAtenea()
    End Sub

    Function checkLogin() As Boolean

        Return False
    End Function

    Private Sub checkEscrito(sender As Object, e As EventArgs) Handles txtCedula.TextChanged, txtContra.TextChanged, txtNombre.TextChanged, txtApellido.TextChanged
        btnEntrar.Enabled = Not (String.IsNullOrWhiteSpace(txtCedula.Text) Or String.IsNullOrWhiteSpace(txtContra.Text) Or String.IsNullOrWhiteSpace(txtNombre.Text) Or String.IsNullOrEmpty(txtApellido.Text))
        If Not registrando Then
            btnEntrar.Enabled = Not (String.IsNullOrWhiteSpace(txtCedula.Text) Or String.IsNullOrEmpty(txtContra.Text))
        End If
    End Sub


End Class
