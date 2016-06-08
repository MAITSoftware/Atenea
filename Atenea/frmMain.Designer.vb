<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.UserControl

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.btnAgregarLibro = New System.Windows.Forms.Button()
        Me.panelLibros = New System.Windows.Forms.FlowLayoutPanel()
        Me.lvwLibros = New System.Windows.Forms.ListView()
        Me.lblNoDisponibles = New System.Windows.Forms.Label()
        Me.btnAgregarLibro_temporal = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.rbtnNombre = New System.Windows.Forms.RadioButton()
        Me.rbtnAutor = New System.Windows.Forms.RadioButton()
        Me.rbtnID = New System.Windows.Forms.RadioButton()
        Me.btnPrestamos = New System.Windows.Forms.Button()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblBuscarPor = New System.Windows.Forms.Label()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.cboxGenero = New System.Windows.Forms.ComboBox()
        Me.chkGenero = New System.Windows.Forms.CheckBox()
        Me.cboxDisponibles = New System.Windows.Forms.CheckBox()
        Me.panelInfo = New System.Windows.Forms.Panel()
        Me.lblEntregarLibro = New System.Windows.Forms.Label()
        Me.chkSoloDisponibles = New System.Windows.Forms.CheckBox()
        Me.panelLibros.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregarLibro
        '
        Me.btnAgregarLibro.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAgregarLibro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarLibro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAgregarLibro.FlatAppearance.BorderSize = 2
        Me.btnAgregarLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnAgregarLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAgregarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarLibro.ForeColor = System.Drawing.Color.White
        Me.btnAgregarLibro.Location = New System.Drawing.Point(356, 12)
        Me.btnAgregarLibro.Name = "btnAgregarLibro"
        Me.btnAgregarLibro.Size = New System.Drawing.Size(116, 32)
        Me.btnAgregarLibro.TabIndex = 10
        Me.btnAgregarLibro.Text = "Agregar libro"
        Me.btnAgregarLibro.UseVisualStyleBackColor = False
        '
        'panelLibros
        '
        Me.panelLibros.AutoScroll = True
        Me.panelLibros.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.panelLibros.Controls.Add(Me.lvwLibros)
        Me.panelLibros.Controls.Add(Me.lblNoDisponibles)
        Me.panelLibros.Controls.Add(Me.btnAgregarLibro_temporal)
        Me.panelLibros.Location = New System.Drawing.Point(211, 75)
        Me.panelLibros.Margin = New System.Windows.Forms.Padding(0)
        Me.panelLibros.Name = "panelLibros"
        Me.panelLibros.Size = New System.Drawing.Size(1054, 586)
        Me.panelLibros.TabIndex = 0
        '
        'lvwLibros
        '
        Me.lvwLibros.Location = New System.Drawing.Point(3, 3)
        Me.lvwLibros.Name = "lvwLibros"
        Me.lvwLibros.Size = New System.Drawing.Size(1038, 580)
        Me.lvwLibros.TabIndex = 24
        Me.lvwLibros.UseCompatibleStateImageBehavior = False
        Me.lvwLibros.Visible = False
        '
        'lblNoDisponibles
        '
        Me.lblNoDisponibles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoDisponibles.AutoSize = True
        Me.lblNoDisponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoDisponibles.ForeColor = System.Drawing.Color.White
        Me.lblNoDisponibles.Location = New System.Drawing.Point(3, 586)
        Me.lblNoDisponibles.MinimumSize = New System.Drawing.Size(1048, 270)
        Me.lblNoDisponibles.Name = "lblNoDisponibles"
        Me.lblNoDisponibles.Size = New System.Drawing.Size(1048, 270)
        Me.lblNoDisponibles.TabIndex = 0
        Me.lblNoDisponibles.Text = "No hay libros disponibles"
        Me.lblNoDisponibles.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnAgregarLibro_temporal
        '
        Me.btnAgregarLibro_temporal.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAgregarLibro_temporal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarLibro_temporal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAgregarLibro_temporal.FlatAppearance.BorderSize = 2
        Me.btnAgregarLibro_temporal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnAgregarLibro_temporal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAgregarLibro_temporal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarLibro_temporal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarLibro_temporal.ForeColor = System.Drawing.Color.White
        Me.btnAgregarLibro_temporal.Location = New System.Drawing.Point(464, 881)
        Me.btnAgregarLibro_temporal.Margin = New System.Windows.Forms.Padding(464, 25, 0, 0)
        Me.btnAgregarLibro_temporal.Name = "btnAgregarLibro_temporal"
        Me.btnAgregarLibro_temporal.Size = New System.Drawing.Size(120, 40)
        Me.btnAgregarLibro_temporal.TabIndex = 23
        Me.btnAgregarLibro_temporal.Text = "Agregar libro"
        Me.btnAgregarLibro_temporal.UseVisualStyleBackColor = False
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(15, 94)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(176, 24)
        Me.txtBusqueda.TabIndex = 0
        '
        'rbtnNombre
        '
        Me.rbtnNombre.AutoSize = True
        Me.rbtnNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.rbtnNombre.Checked = True
        Me.rbtnNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnNombre.ForeColor = System.Drawing.Color.White
        Me.rbtnNombre.Location = New System.Drawing.Point(15, 148)
        Me.rbtnNombre.Name = "rbtnNombre"
        Me.rbtnNombre.Size = New System.Drawing.Size(75, 20)
        Me.rbtnNombre.TabIndex = 2
        Me.rbtnNombre.TabStop = True
        Me.rbtnNombre.Text = "Nombre"
        Me.rbtnNombre.UseVisualStyleBackColor = False
        '
        'rbtnAutor
        '
        Me.rbtnAutor.AutoSize = True
        Me.rbtnAutor.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.rbtnAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAutor.ForeColor = System.Drawing.Color.White
        Me.rbtnAutor.Location = New System.Drawing.Point(15, 174)
        Me.rbtnAutor.Name = "rbtnAutor"
        Me.rbtnAutor.Size = New System.Drawing.Size(57, 20)
        Me.rbtnAutor.TabIndex = 3
        Me.rbtnAutor.TabStop = True
        Me.rbtnAutor.Text = "Autor"
        Me.rbtnAutor.UseVisualStyleBackColor = False
        '
        'rbtnID
        '
        Me.rbtnID.AutoSize = True
        Me.rbtnID.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.rbtnID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnID.ForeColor = System.Drawing.Color.White
        Me.rbtnID.Location = New System.Drawing.Point(15, 200)
        Me.rbtnID.Name = "rbtnID"
        Me.rbtnID.Size = New System.Drawing.Size(39, 20)
        Me.rbtnID.TabIndex = 4
        Me.rbtnID.TabStop = True
        Me.rbtnID.Text = "ID"
        Me.rbtnID.UseVisualStyleBackColor = False
        '
        'btnPrestamos
        '
        Me.btnPrestamos.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnPrestamos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrestamos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPrestamos.FlatAppearance.BorderSize = 2
        Me.btnPrestamos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrestamos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrestamos.ForeColor = System.Drawing.Color.White
        Me.btnPrestamos.Location = New System.Drawing.Point(211, 12)
        Me.btnPrestamos.Name = "btnPrestamos"
        Me.btnPrestamos.Size = New System.Drawing.Size(139, 32)
        Me.btnPrestamos.TabIndex = 9
        Me.btnPrestamos.Text = "Préstamos en curso"
        Me.btnPrestamos.UseVisualStyleBackColor = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.White
        Me.lblBuscar.Location = New System.Drawing.Point(12, 75)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(50, 16)
        Me.lblBuscar.TabIndex = 19
        Me.lblBuscar.Text = "Buscar"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSalir.FlatAppearance.BorderSize = 2
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(1176, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(76, 32)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lblBuscarPor
        '
        Me.lblBuscarPor.AutoSize = True
        Me.lblBuscarPor.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lblBuscarPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarPor.ForeColor = System.Drawing.Color.White
        Me.lblBuscarPor.Location = New System.Drawing.Point(13, 124)
        Me.lblBuscarPor.Name = "lblBuscarPor"
        Me.lblBuscarPor.Size = New System.Drawing.Size(29, 16)
        Me.lblBuscarPor.TabIndex = 1
        Me.lblBuscarPor.Text = "Por"
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.BackColor = System.Drawing.Color.Transparent
        Me.lblBienvenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblBienvenida.ForeColor = System.Drawing.Color.White
        Me.lblBienvenida.Location = New System.Drawing.Point(16, 17)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(100, 20)
        Me.lblBienvenida.TabIndex = 22
        Me.lblBienvenida.Text = "Bienvenido/a"
        Me.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgLogo
        '
        Me.imgLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.imgLogo.BackgroundImage = Global.Atenea.My.Resources.Resources.Logo
        Me.imgLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgLogo.Location = New System.Drawing.Point(17, 474)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(175, 175)
        Me.imgLogo.TabIndex = 17
        Me.imgLogo.TabStop = False
        '
        'cboxGenero
        '
        Me.cboxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxGenero.DropDownWidth = 140
        Me.cboxGenero.Enabled = False
        Me.cboxGenero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboxGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cboxGenero.FormattingEnabled = True
        Me.cboxGenero.Items.AddRange(New Object() {"Biografía", "Científico", "Comedia", "Drama", "Estética", "Guías / Manuales", "Histórico", "Horror", "Literatura nacional", "Revista", "Romance", "Thriller"})
        Me.cboxGenero.Location = New System.Drawing.Point(14, 252)
        Me.cboxGenero.Name = "cboxGenero"
        Me.cboxGenero.Size = New System.Drawing.Size(162, 24)
        Me.cboxGenero.Sorted = True
        Me.cboxGenero.TabIndex = 6
        '
        'chkGenero
        '
        Me.chkGenero.AutoSize = True
        Me.chkGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.chkGenero.ForeColor = System.Drawing.Color.White
        Me.chkGenero.Location = New System.Drawing.Point(16, 226)
        Me.chkGenero.Name = "chkGenero"
        Me.chkGenero.Size = New System.Drawing.Size(72, 20)
        Me.chkGenero.TabIndex = 5
        Me.chkGenero.Text = "Género"
        Me.chkGenero.UseVisualStyleBackColor = True
        '
        'cboxDisponibles
        '
        Me.cboxDisponibles.AutoSize = True
        Me.cboxDisponibles.Checked = True
        Me.cboxDisponibles.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cboxDisponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxDisponibles.ForeColor = System.Drawing.Color.White
        Me.cboxDisponibles.Location = New System.Drawing.Point(16, 307)
        Me.cboxDisponibles.Name = "cboxDisponibles"
        Me.cboxDisponibles.Size = New System.Drawing.Size(148, 20)
        Me.cboxDisponibles.TabIndex = 8
        Me.cboxDisponibles.Text = "Disponibles primero"
        Me.cboxDisponibles.UseVisualStyleBackColor = True
        '
        'panelInfo
        '
        Me.panelInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.panelInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.panelInfo.Controls.Add(Me.lblEntregarLibro)
        Me.panelInfo.Location = New System.Drawing.Point(841, 9)
        Me.panelInfo.Name = "panelInfo"
        Me.panelInfo.Size = New System.Drawing.Size(255, 55)
        Me.panelInfo.TabIndex = 26
        Me.panelInfo.Visible = False
        '
        'lblEntregarLibro
        '
        Me.lblEntregarLibro.AutoSize = True
        Me.lblEntregarLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntregarLibro.ForeColor = System.Drawing.Color.White
        Me.lblEntregarLibro.Location = New System.Drawing.Point(12, 5)
        Me.lblEntregarLibro.Name = "lblEntregarLibro"
        Me.lblEntregarLibro.Size = New System.Drawing.Size(235, 24)
        Me.lblEntregarLibro.TabIndex = 0
        Me.lblEntregarLibro.Text = "Entregue su libro antes del"
        Me.lblEntregarLibro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEntregarLibro.Visible = False
        '
        'chkSoloDisponibles
        '
        Me.chkSoloDisponibles.AutoSize = True
        Me.chkSoloDisponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSoloDisponibles.ForeColor = System.Drawing.Color.White
        Me.chkSoloDisponibles.Location = New System.Drawing.Point(16, 282)
        Me.chkSoloDisponibles.Name = "chkSoloDisponibles"
        Me.chkSoloDisponibles.Size = New System.Drawing.Size(128, 20)
        Me.chkSoloDisponibles.TabIndex = 7
        Me.chkSoloDisponibles.Text = "Sólo disponibles"
        Me.chkSoloDisponibles.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Controls.Add(Me.chkSoloDisponibles)
        Me.Controls.Add(Me.panelInfo)
        Me.Controls.Add(Me.cboxDisponibles)
        Me.Controls.Add(Me.chkGenero)
        Me.Controls.Add(Me.cboxGenero)
        Me.Controls.Add(Me.lblBienvenida)
        Me.Controls.Add(Me.lblBuscarPor)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.btnPrestamos)
        Me.Controls.Add(Me.imgLogo)
        Me.Controls.Add(Me.rbtnID)
        Me.Controls.Add(Me.rbtnAutor)
        Me.Controls.Add(Me.rbtnNombre)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.btnAgregarLibro)
        Me.Controls.Add(Me.panelLibros)
        Me.DoubleBuffered = True
        Me.Name = "frmMain"
        Me.Size = New System.Drawing.Size(1264, 661)
        Me.panelLibros.ResumeLayout(False)
        Me.panelLibros.PerformLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelInfo.ResumeLayout(False)
        Me.panelInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelLibros As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAgregarLibro As System.Windows.Forms.Button
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents rbtnNombre As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnAutor As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnID As System.Windows.Forms.RadioButton
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents btnPrestamos As System.Windows.Forms.Button
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lblBuscarPor As System.Windows.Forms.Label
    Friend WithEvents lblBienvenida As System.Windows.Forms.Label
    Friend WithEvents lblNoDisponibles As System.Windows.Forms.Label
    Friend WithEvents btnAgregarLibro_temporal As System.Windows.Forms.Button
    Friend WithEvents cboxGenero As System.Windows.Forms.ComboBox
    Friend WithEvents chkGenero As System.Windows.Forms.CheckBox
    Friend WithEvents lvwLibros As System.Windows.Forms.ListView
    Friend WithEvents cboxDisponibles As System.Windows.Forms.CheckBox
    Friend WithEvents panelInfo As System.Windows.Forms.Panel
    Friend WithEvents lblEntregarLibro As System.Windows.Forms.Label
    Friend WithEvents chkSoloDisponibles As System.Windows.Forms.CheckBox

End Class
