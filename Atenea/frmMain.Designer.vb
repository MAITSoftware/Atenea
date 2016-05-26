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
        Me.radioIconos = New System.Windows.Forms.RadioButton()
        Me.radioLista = New System.Windows.Forms.RadioButton()
        Me.groupVista = New System.Windows.Forms.GroupBox()
        Me.panelLibros = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblNoDisponibles = New System.Windows.Forms.Label()
        Me.btnAgregar_temporal = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.radioNombre = New System.Windows.Forms.RadioButton()
        Me.radioAutor = New System.Windows.Forms.RadioButton()
        Me.radioGenero = New System.Windows.Forms.RadioButton()
        Me.radioID = New System.Windows.Forms.RadioButton()
        Me.comboGenero = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPrestamos = New System.Windows.Forms.Button()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.groupVista.SuspendLayout()
        Me.panelLibros.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnAgregarLibro.TabIndex = 6
        Me.btnAgregarLibro.Text = "Agregar libro"
        Me.btnAgregarLibro.UseVisualStyleBackColor = False
        '
        'radioIconos
        '
        Me.radioIconos.AutoSize = True
        Me.radioIconos.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.radioIconos.Checked = True
        Me.radioIconos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioIconos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.radioIconos.Location = New System.Drawing.Point(21, 13)
        Me.radioIconos.Name = "radioIconos"
        Me.radioIconos.Size = New System.Drawing.Size(66, 20)
        Me.radioIconos.TabIndex = 8
        Me.radioIconos.TabStop = True
        Me.radioIconos.Text = "Iconos"
        Me.radioIconos.UseVisualStyleBackColor = False
        '
        'radioLista
        '
        Me.radioLista.AutoSize = True
        Me.radioLista.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.radioLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioLista.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.radioLista.Location = New System.Drawing.Point(93, 13)
        Me.radioLista.Name = "radioLista"
        Me.radioLista.Size = New System.Drawing.Size(54, 20)
        Me.radioLista.TabIndex = 9
        Me.radioLista.TabStop = True
        Me.radioLista.Text = "Lista"
        Me.radioLista.UseVisualStyleBackColor = False
        '
        'groupVista
        '
        Me.groupVista.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.groupVista.Controls.Add(Me.radioLista)
        Me.groupVista.Controls.Add(Me.radioIconos)
        Me.groupVista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupVista.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.groupVista.Location = New System.Drawing.Point(16, 346)
        Me.groupVista.Name = "groupVista"
        Me.groupVista.Size = New System.Drawing.Size(160, 43)
        Me.groupVista.TabIndex = 10
        Me.groupVista.TabStop = False
        Me.groupVista.Text = "Vista de"
        '
        'panelLibros
        '
        Me.panelLibros.AutoScroll = True
        Me.panelLibros.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.panelLibros.Controls.Add(Me.lblNoDisponibles)
        Me.panelLibros.Controls.Add(Me.btnAgregar_temporal)
        Me.panelLibros.Location = New System.Drawing.Point(211, 75)
        Me.panelLibros.Margin = New System.Windows.Forms.Padding(0)
        Me.panelLibros.Name = "panelLibros"
        Me.panelLibros.Size = New System.Drawing.Size(1054, 586)
        Me.panelLibros.TabIndex = 0
        '
        'lblNoDisponibles
        '
        Me.lblNoDisponibles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoDisponibles.AutoSize = True
        Me.lblNoDisponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoDisponibles.ForeColor = System.Drawing.Color.White
        Me.lblNoDisponibles.Location = New System.Drawing.Point(3, 0)
        Me.lblNoDisponibles.MinimumSize = New System.Drawing.Size(1048, 270)
        Me.lblNoDisponibles.Name = "lblNoDisponibles"
        Me.lblNoDisponibles.Size = New System.Drawing.Size(1048, 270)
        Me.lblNoDisponibles.TabIndex = 0
        Me.lblNoDisponibles.Text = "No hay libros disponibles"
        Me.lblNoDisponibles.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnAgregar_temporal
        '
        Me.btnAgregar_temporal.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnAgregar_temporal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar_temporal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAgregar_temporal.FlatAppearance.BorderSize = 2
        Me.btnAgregar_temporal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnAgregar_temporal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAgregar_temporal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar_temporal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar_temporal.ForeColor = System.Drawing.Color.White
        Me.btnAgregar_temporal.Location = New System.Drawing.Point(464, 295)
        Me.btnAgregar_temporal.Margin = New System.Windows.Forms.Padding(464, 25, 0, 0)
        Me.btnAgregar_temporal.Name = "btnAgregar_temporal"
        Me.btnAgregar_temporal.Size = New System.Drawing.Size(120, 40)
        Me.btnAgregar_temporal.TabIndex = 23
        Me.btnAgregar_temporal.Text = "Agregar libro"
        Me.btnAgregar_temporal.UseVisualStyleBackColor = False
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(15, 94)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(176, 24)
        Me.txtBusqueda.TabIndex = 11
        '
        'radioNombre
        '
        Me.radioNombre.AutoSize = True
        Me.radioNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.radioNombre.Checked = True
        Me.radioNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioNombre.ForeColor = System.Drawing.Color.White
        Me.radioNombre.Location = New System.Drawing.Point(15, 148)
        Me.radioNombre.Name = "radioNombre"
        Me.radioNombre.Size = New System.Drawing.Size(75, 20)
        Me.radioNombre.TabIndex = 12
        Me.radioNombre.TabStop = True
        Me.radioNombre.Text = "Nombre"
        Me.radioNombre.UseVisualStyleBackColor = False
        '
        'radioAutor
        '
        Me.radioAutor.AutoSize = True
        Me.radioAutor.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.radioAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioAutor.ForeColor = System.Drawing.Color.White
        Me.radioAutor.Location = New System.Drawing.Point(15, 174)
        Me.radioAutor.Name = "radioAutor"
        Me.radioAutor.Size = New System.Drawing.Size(57, 20)
        Me.radioAutor.TabIndex = 13
        Me.radioAutor.TabStop = True
        Me.radioAutor.Text = "Autor"
        Me.radioAutor.UseVisualStyleBackColor = False
        '
        'radioGenero
        '
        Me.radioGenero.AutoSize = True
        Me.radioGenero.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.radioGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioGenero.ForeColor = System.Drawing.Color.White
        Me.radioGenero.Location = New System.Drawing.Point(15, 226)
        Me.radioGenero.Name = "radioGenero"
        Me.radioGenero.Size = New System.Drawing.Size(71, 20)
        Me.radioGenero.TabIndex = 14
        Me.radioGenero.TabStop = True
        Me.radioGenero.Text = "Género"
        Me.radioGenero.UseVisualStyleBackColor = False
        '
        'radioID
        '
        Me.radioID.AutoSize = True
        Me.radioID.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.radioID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioID.ForeColor = System.Drawing.Color.White
        Me.radioID.Location = New System.Drawing.Point(15, 200)
        Me.radioID.Name = "radioID"
        Me.radioID.Size = New System.Drawing.Size(39, 20)
        Me.radioID.TabIndex = 15
        Me.radioID.TabStop = True
        Me.radioID.Text = "ID"
        Me.radioID.UseVisualStyleBackColor = False
        '
        'comboGenero
        '
        Me.comboGenero.Enabled = False
        Me.comboGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboGenero.FormattingEnabled = True
        Me.comboGenero.Location = New System.Drawing.Point(15, 252)
        Me.comboGenero.Name = "comboGenero"
        Me.comboGenero.Size = New System.Drawing.Size(161, 24)
        Me.comboGenero.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.Atenea.My.Resources.Resources.logoVectorizado_blanco
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(17, 474)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 175)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
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
        Me.btnPrestamos.TabIndex = 18
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
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Por"
        '
        'lblBienvenida
        '
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.BackColor = System.Drawing.Color.Transparent
        Me.lblBienvenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblBienvenida.ForeColor = System.Drawing.Color.White
        Me.lblBienvenida.Location = New System.Drawing.Point(16, 17)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(147, 20)
        Me.lblBienvenida.TabIndex = 22
        Me.lblBienvenida.Text = "Bienvenido, usuario"
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Controls.Add(Me.lblBienvenida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.btnPrestamos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.comboGenero)
        Me.Controls.Add(Me.radioID)
        Me.Controls.Add(Me.radioGenero)
        Me.Controls.Add(Me.radioAutor)
        Me.Controls.Add(Me.radioNombre)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.btnAgregarLibro)
        Me.Controls.Add(Me.panelLibros)
        Me.Controls.Add(Me.groupVista)
        Me.DoubleBuffered = True
        Me.Name = "frmMain"
        Me.Size = New System.Drawing.Size(1264, 661)
        Me.groupVista.ResumeLayout(False)
        Me.groupVista.PerformLayout()
        Me.panelLibros.ResumeLayout(False)
        Me.panelLibros.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelLibros As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnAgregarLibro As System.Windows.Forms.Button
    Friend WithEvents radioIconos As System.Windows.Forms.RadioButton
    Friend WithEvents radioLista As System.Windows.Forms.RadioButton
    Friend WithEvents groupVista As System.Windows.Forms.GroupBox
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents radioNombre As System.Windows.Forms.RadioButton
    Friend WithEvents radioAutor As System.Windows.Forms.RadioButton
    Friend WithEvents radioGenero As System.Windows.Forms.RadioButton
    Friend WithEvents radioID As System.Windows.Forms.RadioButton
    Friend WithEvents comboGenero As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnPrestamos As System.Windows.Forms.Button
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBienvenida As System.Windows.Forms.Label
    Friend WithEvents lblNoDisponibles As System.Windows.Forms.Label
    Friend WithEvents btnAgregar_temporal As System.Windows.Forms.Button

End Class
