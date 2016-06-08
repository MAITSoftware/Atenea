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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrestamos))
        Me.planilla = New System.Windows.Forms.ListView()
        Me.Usuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Funcionario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NombreLibro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IDLibro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fechaPrestamo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fechaEntrega = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnLibroDevuelto = New System.Windows.Forms.Button()
        Me.btnCambiarFecha = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.impresora = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'planilla
        '
        Me.planilla.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.planilla.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.planilla.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Usuario, Me.Funcionario, Me.NombreLibro, Me.IDLibro, Me.fechaPrestamo, Me.fechaEntrega})
        Me.planilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.planilla.ForeColor = System.Drawing.Color.White
        Me.planilla.FullRowSelect = True
        Me.planilla.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.planilla.Location = New System.Drawing.Point(263, 12)
        Me.planilla.Margin = New System.Windows.Forms.Padding(0)
        Me.planilla.MultiSelect = False
        Me.planilla.Name = "planilla"
        Me.planilla.Size = New System.Drawing.Size(643, 412)
        Me.planilla.TabIndex = 9
        Me.planilla.UseCompatibleStateImageBehavior = False
        '
        'Usuario
        '
        Me.Usuario.Text = "CI Usuario"
        Me.Usuario.Width = 80
        '
        'Funcionario
        '
        Me.Funcionario.Text = "CI Funcionario"
        Me.Funcionario.Width = 100
        '
        'NombreLibro
        '
        Me.NombreLibro.Text = "Nombre del libro"
        Me.NombreLibro.Width = 120
        '
        'IDLibro
        '
        Me.IDLibro.Text = "ID del libro"
        Me.IDLibro.Width = 80
        '
        'fechaPrestamo
        '
        Me.fechaPrestamo.Text = "Fecha de préstamo"
        Me.fechaPrestamo.Width = 130
        '
        'fechaEntrega
        '
        Me.fechaEntrega.Text = "Fecha de entrega"
        Me.fechaEntrega.Width = 120
        '
        'btnLibroDevuelto
        '
        Me.btnLibroDevuelto.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnLibroDevuelto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLibroDevuelto.Enabled = False
        Me.btnLibroDevuelto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnLibroDevuelto.FlatAppearance.BorderSize = 2
        Me.btnLibroDevuelto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnLibroDevuelto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnLibroDevuelto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLibroDevuelto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnLibroDevuelto.ForeColor = System.Drawing.Color.White
        Me.btnLibroDevuelto.Location = New System.Drawing.Point(16, 266)
        Me.btnLibroDevuelto.Name = "btnLibroDevuelto"
        Me.btnLibroDevuelto.Size = New System.Drawing.Size(230, 32)
        Me.btnLibroDevuelto.TabIndex = 0
        Me.btnLibroDevuelto.Text = "Marcar libro como devuelto"
        Me.btnLibroDevuelto.UseVisualStyleBackColor = False
        '
        'btnCambiarFecha
        '
        Me.btnCambiarFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnCambiarFecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCambiarFecha.Enabled = False
        Me.btnCambiarFecha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCambiarFecha.FlatAppearance.BorderSize = 2
        Me.btnCambiarFecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnCambiarFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCambiarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnCambiarFecha.ForeColor = System.Drawing.Color.White
        Me.btnCambiarFecha.Location = New System.Drawing.Point(16, 312)
        Me.btnCambiarFecha.Name = "btnCambiarFecha"
        Me.btnCambiarFecha.Size = New System.Drawing.Size(230, 32)
        Me.btnCambiarFecha.TabIndex = 1
        Me.btnCambiarFecha.Text = "Editar fecha de entrega"
        Me.btnCambiarFecha.UseVisualStyleBackColor = False
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
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(16, 358)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(230, 32)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Imprimir detalles de préstamos"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'impresora
        '
        '
        'frmPrestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(918, 436)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnCambiarFecha)
        Me.Controls.Add(Me.btnLibroDevuelto)
        Me.Controls.Add(Me.planilla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrestamos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Préstamos en curso · Atenea"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents planilla As System.Windows.Forms.ListView
    Friend WithEvents Usuario As System.Windows.Forms.ColumnHeader
    Friend WithEvents Funcionario As System.Windows.Forms.ColumnHeader
    Friend WithEvents NombreLibro As System.Windows.Forms.ColumnHeader
    Friend WithEvents IDLibro As System.Windows.Forms.ColumnHeader
    Friend WithEvents fechaPrestamo As System.Windows.Forms.ColumnHeader
    Friend WithEvents fechaEntrega As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnLibroDevuelto As System.Windows.Forms.Button
    Friend WithEvents btnCambiarFecha As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents impresora As System.Drawing.Printing.PrintDocument
End Class
