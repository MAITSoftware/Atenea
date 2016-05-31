<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrestamos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrestamos))
        Me.btnCambiarFecha = New System.Windows.Forms.Button()
        Me.btnLibroDevuelto = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.clmnUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmnFuncionario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmnNombreLibro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmnFechaPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmnFechaDevolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCambiarFecha
        '
        Me.btnCambiarFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnCambiarFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCambiarFecha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCambiarFecha.FlatAppearance.BorderSize = 2
        Me.btnCambiarFecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnCambiarFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCambiarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarFecha.ForeColor = System.Drawing.Color.White
        Me.btnCambiarFecha.Location = New System.Drawing.Point(21, 304)
        Me.btnCambiarFecha.Name = "btnCambiarFecha"
        Me.btnCambiarFecha.Size = New System.Drawing.Size(230, 44)
        Me.btnCambiarFecha.TabIndex = 5
        Me.btnCambiarFecha.Text = "Cambiar fecha de entrega"
        Me.btnCambiarFecha.UseVisualStyleBackColor = False
        '
        'btnLibroDevuelto
        '
        Me.btnLibroDevuelto.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnLibroDevuelto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLibroDevuelto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnLibroDevuelto.FlatAppearance.BorderSize = 2
        Me.btnLibroDevuelto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnLibroDevuelto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnLibroDevuelto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLibroDevuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLibroDevuelto.ForeColor = System.Drawing.Color.White
        Me.btnLibroDevuelto.Location = New System.Drawing.Point(21, 241)
        Me.btnLibroDevuelto.Name = "btnLibroDevuelto"
        Me.btnLibroDevuelto.Size = New System.Drawing.Size(230, 44)
        Me.btnLibroDevuelto.TabIndex = 6
        Me.btnLibroDevuelto.Text = "Marcar libro como devuelto"
        Me.btnLibroDevuelto.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnImprimir.FlatAppearance.BorderSize = 2
        Me.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(21, 363)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(230, 45)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "Imprimir detalles de préstamo"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmnUsuario, Me.clmnFuncionario, Me.clmnNombreLibro, Me.clmnID, Me.clmnFechaPrestamo, Me.clmnFechaDevolucion})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(277, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.DataGridView1.Size = New System.Drawing.Size(629, 412)
        Me.DataGridView1.TabIndex = 8
        '
        'clmnUsuario
        '
        Me.clmnUsuario.HeaderText = "Usuario"
        Me.clmnUsuario.Name = "clmnUsuario"
        Me.clmnUsuario.ReadOnly = True
        Me.clmnUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmnFuncionario
        '
        Me.clmnFuncionario.HeaderText = "Funcionario"
        Me.clmnFuncionario.Name = "clmnFuncionario"
        Me.clmnFuncionario.ReadOnly = True
        '
        'clmnNombreLibro
        '
        Me.clmnNombreLibro.HeaderText = "Nombre del Libro"
        Me.clmnNombreLibro.Name = "clmnNombreLibro"
        Me.clmnNombreLibro.ReadOnly = True
        '
        'clmnID
        '
        Me.clmnID.HeaderText = "ID del Libro"
        Me.clmnID.Name = "clmnID"
        Me.clmnID.ReadOnly = True
        '
        'clmnFechaPrestamo
        '
        Me.clmnFechaPrestamo.HeaderText = "Fecha de Préstamo"
        Me.clmnFechaPrestamo.Name = "clmnFechaPrestamo"
        Me.clmnFechaPrestamo.ReadOnly = True
        Me.clmnFechaPrestamo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'clmnFechaDevolucion
        '
        Me.clmnFechaDevolucion.DividerWidth = 10
        Me.clmnFechaDevolucion.HeaderText = "Fecha de Devolución"
        Me.clmnFechaDevolucion.Name = "clmnFechaDevolucion"
        Me.clmnFechaDevolucion.ReadOnly = True
        Me.clmnFechaDevolucion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'frmPrestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(918, 436)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnLibroDevuelto)
        Me.Controls.Add(Me.btnCambiarFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrestamos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Préstamos en curso · Atenea"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCambiarFecha As System.Windows.Forms.Button
    Friend WithEvents btnLibroDevuelto As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents clmnUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmnFuncionario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmnNombreLibro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmnID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmnFechaPrestamo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clmnFechaDevolucion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
