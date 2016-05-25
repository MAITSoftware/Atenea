Public Class Atenea

    Dim tipoUsuario As String
    Dim registrando As Boolean = False
    Dim atenea As frmMain

    Private Sub btnTipo_Click(sender As Object, e As EventArgs) Handles btnFuncionario.Click, btnUsuario.Click

        tipoUsuario = "usuario"
        If sender Is btnFuncionario Then
            tipoUsuario = "funcionario"
        End If
        lblBienvenido.Text = "Acceso de " & tipoUsuario
        btnRegistro.Text = "Registrar " & ControlChars.NewLine & tipoUsuario
        mostrarLogin()
    End Sub


    Private Sub mostrarLogin()
        btnFuncionario.Visible = False
        btnUsuario.Visible = False

        lblCedula.Visible = True
        lblContra.Visible = True
        txtCedula.Visible = True
        txtContra.Visible = True
        btnCancelar.Visible = True
        btnRegistro.Visible = True
        btnEntrar.Visible = True

        btnEntrar.Text = "Entrar"

    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        lblBienvenido.Text = "Nuevo " & tipoUsuario
        lblCedula.Location = New Point(30, 167)
        lblContra.Location = New Point(204, 167)
        txtCedula.Location = New Point(34, 190)
        txtContra.Location = New Point(204, 190)

        btnEntrar.Text = "Crear cuenta"

        txtApellido.Visible = True
        txtNombre.Visible = True
        lblApellido.Visible = True
        lblNombre.Visible = True

        btnRegistro.Visible = False
        btnCancelar.Visible = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        volverAInicio()
    End Sub

    Private Sub VolverAInicio()
        registrando = False
        btnEntrar.Visible = False
        btnRegistro.Visible = False
        txtApellido.Visible = False
        txtNombre.Visible = False

        lblApellido.Visible = False
        lblNombre.Visible = False
        lblCedula.Visible = False
        lblContra.Visible = False
        txtCedula.Visible = False
        txtContra.Visible = False

        btnCancelar.Visible = False

        btnFuncionario.Visible = True
        btnUsuario.Visible = True
        btnEntrar.Visible = False

        lblBienvenido.Text = "Bienvenido a" & ControlChars.NewLine & "Atenea"

        lblCedula.Location = New Point(121, 101)
        lblContra.Location = New Point(121, 159)
        txtCedula.Location = New Point(125, 124)
        txtContra.Location = New Point(125, 179)
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        agregarAtenea()
    End Sub

    Private Sub agregarAtenea()
        Me.Controls.Clear()
        Me.Text = "Atenea"

        atenea = New frmMain()

        Me.Width = 1280
        Me.Height = 700
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - atenea.Width) / 2
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - atenea.Height) / 2
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Controls.Add(atenea)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub

End Class