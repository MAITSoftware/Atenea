Public Class frmLogin
    Friend tipoUsuario As String

    Private Sub btnTipo_Click(sender As Object, e As EventArgs) Handles btnFuncionario.Click, btnUsuario.Click
        tipoUsuario = "usuario"

        If sender Is btnFuncionario Then
            tipoUsuario = "funcionario"
        End If

        pedirDatosRegistro()
    End Sub


    Private Sub preguntarTipoCuenta(sender As Object, e As EventArgs) Handles btnRegistro.Click
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

End Class
