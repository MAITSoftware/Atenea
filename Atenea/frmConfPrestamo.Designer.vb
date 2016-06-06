<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfPrestamo
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfPrestamo))
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblFechaEntrega = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.calendario = New System.Windows.Forms.MonthCalendar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblCondicion = New System.Windows.Forms.Label()
        Me.comboUsuario = New System.Windows.Forms.ComboBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.btnPrestar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(292, 53)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(151, 24)
        Me.lblUsuario.TabIndex = 36
        Me.lblUsuario.Text = "Usuario a prestar"
        '
        'lblFechaEntrega
        '
        Me.lblFechaEntrega.AutoSize = True
        Me.lblFechaEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaEntrega.ForeColor = System.Drawing.Color.White
        Me.lblFechaEntrega.Location = New System.Drawing.Point(292, 197)
        Me.lblFechaEntrega.Name = "lblFechaEntrega"
        Me.lblFechaEntrega.Size = New System.Drawing.Size(160, 24)
        Me.lblFechaEntrega.TabIndex = 35
        Me.lblFechaEntrega.Text = "Fecha de entrega"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.Red
        Me.lblInfo.Location = New System.Drawing.Point(417, 77)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(340, 24)
        Me.lblInfo.TabIndex = 34
        Me.lblInfo.Text = "El usuario tiene un préstamo pendiente"
        Me.lblInfo.Visible = False
        '
        'calendario
        '
        Me.calendario.Location = New System.Drawing.Point(474, 136)
        Me.calendario.MaxSelectionCount = 1
        Me.calendario.Name = "calendario"
        Me.calendario.ShowTodayCircle = False
        Me.calendario.TabIndex = 37
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblCondicion)
        Me.Panel1.Controls.Add(Me.lblID)
        Me.Panel1.Controls.Add(Me.lblGenero)
        Me.Panel1.Controls.Add(Me.lblAutor)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 380)
        Me.Panel1.TabIndex = 40
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutor.ForeColor = System.Drawing.Color.White
        Me.lblAutor.Location = New System.Drawing.Point(58, 223)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(56, 20)
        Me.lblAutor.TabIndex = 0
        Me.lblAutor.Text = "Autor: "
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenero.ForeColor = System.Drawing.Color.White
        Me.lblGenero.Location = New System.Drawing.Point(58, 248)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(67, 20)
        Me.lblGenero.TabIndex = 1
        Me.lblGenero.Text = "Género:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(58, 273)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(30, 20)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "ID:"
        '
        'lblCondicion
        '
        Me.lblCondicion.AutoSize = True
        Me.lblCondicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCondicion.ForeColor = System.Drawing.Color.White
        Me.lblCondicion.Location = New System.Drawing.Point(58, 298)
        Me.lblCondicion.Name = "lblCondicion"
        Me.lblCondicion.Size = New System.Drawing.Size(83, 20)
        Me.lblCondicion.TabIndex = 3
        Me.lblCondicion.Text = "Condición:"
        '
        'comboUsuario
        '
        Me.comboUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.comboUsuario.FormattingEnabled = True
        Me.comboUsuario.Location = New System.Drawing.Point(475, 53)
        Me.comboUsuario.Name = "comboUsuario"
        Me.comboUsuario.Size = New System.Drawing.Size(227, 26)
        Me.comboUsuario.TabIndex = 41
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(292, 229)
        Me.lblFecha.MinimumSize = New System.Drawing.Size(160, 24)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(160, 24)
        Me.lblFecha.TabIndex = 42
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrestar
        '
        Me.btnPrestar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnPrestar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrestar.Enabled = False
        Me.btnPrestar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPrestar.FlatAppearance.BorderSize = 2
        Me.btnPrestar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnPrestar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPrestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnPrestar.ForeColor = System.Drawing.Color.White
        Me.btnPrestar.Location = New System.Drawing.Point(489, 321)
        Me.btnPrestar.Name = "btnPrestar"
        Me.btnPrestar.Size = New System.Drawing.Size(116, 32)
        Me.btnPrestar.TabIndex = 43
        Me.btnPrestar.Text = "Prestar"
        Me.btnPrestar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCancelar.FlatAppearance.BorderSize = 2
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(631, 321)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(116, 32)
        Me.btnCancelar.TabIndex = 44
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'frmConfPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(767, 372)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnPrestar)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.comboUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.calendario)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblFechaEntrega)
        Me.Controls.Add(Me.lblInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfPrestamo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Préstamo de libro · Atenea"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblFechaEntrega As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents lblAutor As System.Windows.Forms.Label
    Friend WithEvents lblCondicion As System.Windows.Forms.Label
    Friend WithEvents comboUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnPrestar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
