<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewLogin
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.txtICI = New System.Windows.Forms.TextBox()
        Me.lblContrasenia = New System.Windows.Forms.Label()
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.lblNuevoUsuario = New System.Windows.Forms.Label()
        Me.btnRegistrarse = New System.Windows.Forms.Button()
        Me.rbtnFuncionario = New System.Windows.Forms.RadioButton()
        Me.rbtnUsuario = New System.Windows.Forms.RadioButton()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lblBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenido.ForeColor = System.Drawing.Color.White
        Me.lblBienvenido.Location = New System.Drawing.Point(155, 23)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(282, 33)
        Me.lblBienvenido.TabIndex = 0
        Me.lblBienvenido.Text = "Bienvenido a Atenea"
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCI.ForeColor = System.Drawing.Color.White
        Me.lblCI.Location = New System.Drawing.Point(391, 149)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(120, 24)
        Me.lblCI.TabIndex = 1
        Me.lblCI.Text = "Ingrese su CI"
        '
        'txtICI
        '
        Me.txtICI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtICI.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtICI.Location = New System.Drawing.Point(372, 176)
        Me.txtICI.Name = "txtICI"
        Me.txtICI.Size = New System.Drawing.Size(158, 24)
        Me.txtICI.TabIndex = 2
        '
        'lblContrasenia
        '
        Me.lblContrasenia.AutoSize = True
        Me.lblContrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasenia.ForeColor = System.Drawing.Color.White
        Me.lblContrasenia.Location = New System.Drawing.Point(353, 201)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(196, 24)
        Me.lblContrasenia.TabIndex = 1
        Me.lblContrasenia.Text = "Ingrese su contraseña"
        Me.lblContrasenia.Visible = False
        '
        'txtContrasenia
        '
        Me.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasenia.Location = New System.Drawing.Point(372, 228)
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.Size = New System.Drawing.Size(158, 24)
        Me.txtContrasenia.TabIndex = 2
        Me.txtContrasenia.Visible = False
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEntrar.FlatAppearance.BorderSize = 2
        Me.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.ForeColor = System.Drawing.Color.White
        Me.btnEntrar.Location = New System.Drawing.Point(393, 232)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(116, 32)
        Me.btnEntrar.TabIndex = 7
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'lblNuevoUsuario
        '
        Me.lblNuevoUsuario.AutoSize = True
        Me.lblNuevoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblNuevoUsuario.ForeColor = System.Drawing.Color.White
        Me.lblNuevoUsuario.Location = New System.Drawing.Point(322, 335)
        Me.lblNuevoUsuario.Name = "lblNuevoUsuario"
        Me.lblNuevoUsuario.Size = New System.Drawing.Size(128, 20)
        Me.lblNuevoUsuario.TabIndex = 1
        Me.lblNuevoUsuario.Text = "¿Nuevo usuario?"
        Me.lblNuevoUsuario.Visible = False
        '
        'btnRegistrarse
        '
        Me.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRegistrarse.FlatAppearance.BorderSize = 2
        Me.btnRegistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrarse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnRegistrarse.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarse.Location = New System.Drawing.Point(456, 329)
        Me.btnRegistrarse.Name = "btnRegistrarse"
        Me.btnRegistrarse.Size = New System.Drawing.Size(116, 32)
        Me.btnRegistrarse.TabIndex = 7
        Me.btnRegistrarse.Text = "Registrarse"
        Me.btnRegistrarse.UseVisualStyleBackColor = False
        Me.btnRegistrarse.Visible = False
        '
        'rbtnFuncionario
        '
        Me.rbtnFuncionario.AutoSize = True
        Me.rbtnFuncionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnFuncionario.ForeColor = System.Drawing.Color.White
        Me.rbtnFuncionario.Location = New System.Drawing.Point(443, 84)
        Me.rbtnFuncionario.Name = "rbtnFuncionario"
        Me.rbtnFuncionario.Size = New System.Drawing.Size(129, 28)
        Me.rbtnFuncionario.TabIndex = 8
        Me.rbtnFuncionario.Text = "Funcionario"
        Me.rbtnFuncionario.UseVisualStyleBackColor = True
        '
        'rbtnUsuario
        '
        Me.rbtnUsuario.AutoSize = True
        Me.rbtnUsuario.Checked = True
        Me.rbtnUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnUsuario.ForeColor = System.Drawing.Color.White
        Me.rbtnUsuario.Location = New System.Drawing.Point(326, 84)
        Me.rbtnUsuario.Name = "rbtnUsuario"
        Me.rbtnUsuario.Size = New System.Drawing.Size(92, 28)
        Me.rbtnUsuario.TabIndex = 8
        Me.rbtnUsuario.TabStop = True
        Me.rbtnUsuario.Text = "Usuario"
        Me.rbtnUsuario.UseVisualStyleBackColor = True
        '
        'imgLogo
        '
        Me.imgLogo.Image = Global.Atenea.My.Resources.Resources.Logo
        Me.imgLogo.Location = New System.Drawing.Point(32, 84)
        Me.imgLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(250, 250)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgLogo.TabIndex = 3
        Me.imgLogo.TabStop = False
        '
        'frmNewLogin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.rbtnUsuario)
        Me.Controls.Add(Me.rbtnFuncionario)
        Me.Controls.Add(Me.btnRegistrarse)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.imgLogo)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.txtICI)
        Me.Controls.Add(Me.lblNuevoUsuario)
        Me.Controls.Add(Me.lblContrasenia)
        Me.Controls.Add(Me.lblCI)
        Me.Controls.Add(Me.lblBienvenido)
        Me.Name = "frmNewLogin"
        Me.Size = New System.Drawing.Size(600, 380)
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBienvenido As System.Windows.Forms.Label
    Friend WithEvents lblCI As System.Windows.Forms.Label
    Friend WithEvents txtICI As System.Windows.Forms.TextBox
    Friend WithEvents lblContrasenia As System.Windows.Forms.Label
    Friend WithEvents txtContrasenia As System.Windows.Forms.TextBox
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents lblNuevoUsuario As System.Windows.Forms.Label
    Friend WithEvents btnRegistrarse As System.Windows.Forms.Button
    Friend WithEvents rbtnFuncionario As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnUsuario As System.Windows.Forms.RadioButton

End Class
