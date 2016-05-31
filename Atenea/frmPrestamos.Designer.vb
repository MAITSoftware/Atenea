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
        Me.btnCambiarFecha = New System.Windows.Forms.Button()
        Me.btnLibroDevuelto = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.planilla = New System.Windows.Forms.ListView()
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
        'planilla
        '
        Me.planilla.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.planilla.BorderStyle = System.Windows.Forms.BorderStyle.None
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
        'frmPrestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(918, 436)
        Me.Controls.Add(Me.planilla)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnLibroDevuelto)
        Me.Controls.Add(Me.btnCambiarFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrestamos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Préstamos en curso · Atenea"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCambiarFecha As System.Windows.Forms.Button
    Friend WithEvents btnLibroDevuelto As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents planilla As System.Windows.Forms.ListView
End Class
