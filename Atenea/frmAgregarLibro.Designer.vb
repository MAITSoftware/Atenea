<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarLibro
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
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cboxCategoria = New System.Windows.Forms.ComboBox()
        Me.lblNombreLibro = New System.Windows.Forms.Label()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnCambiarPortada = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtAutor
        '
        Me.txtAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAutor.Location = New System.Drawing.Point(734, 138)
        Me.txtAutor.Multiline = True
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(261, 34)
        Me.txtAutor.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(734, 73)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(261, 34)
        Me.txtNombre.TabIndex = 0
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(734, 276)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(261, 34)
        Me.txtID.TabIndex = 0
        '
        'cboxCategoria
        '
        Me.cboxCategoria.DropDownWidth = 140
        Me.cboxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboxCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxCategoria.FormattingEnabled = True
        Me.cboxCategoria.Location = New System.Drawing.Point(734, 209)
        Me.cboxCategoria.Name = "cboxCategoria"
        Me.cboxCategoria.Size = New System.Drawing.Size(261, 28)
        Me.cboxCategoria.TabIndex = 1
        '
        'lblNombreLibro
        '
        Me.lblNombreLibro.AutoSize = True
        Me.lblNombreLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lblNombreLibro.Location = New System.Drawing.Point(513, 73)
        Me.lblNombreLibro.Name = "lblNombreLibro"
        Me.lblNombreLibro.Size = New System.Drawing.Size(169, 25)
        Me.lblNombreLibro.TabIndex = 2
        Me.lblNombreLibro.Text = "Nombre del libro"
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lblAutor.Location = New System.Drawing.Point(513, 138)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(63, 25)
        Me.lblAutor.TabIndex = 2
        Me.lblAutor.Text = "Autor"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.lblCategoria.Location = New System.Drawing.Point(513, 208)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(105, 25)
        Me.lblCategoria.TabIndex = 2
        Me.lblCategoria.Text = "Categoría"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(513, 285)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(114, 25)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "ID del libro"
        '
        'btnCambiarPortada
        '
        Me.btnCambiarPortada.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarPortada.Location = New System.Drawing.Point(150, 348)
        Me.btnCambiarPortada.Name = "btnCambiarPortada"
        Me.btnCambiarPortada.Size = New System.Drawing.Size(129, 62)
        Me.btnCambiarPortada.TabIndex = 3
        Me.btnCambiarPortada.Text = "Cambiar portada"
        Me.btnCambiarPortada.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.btnAgregar.Location = New System.Drawing.Point(597, 395)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(129, 52)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.btnCancelar.Location = New System.Drawing.Point(802, 395)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(129, 52)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(82, 92)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(261, 231)
        Me.TextBox4.TabIndex = 0
        '
        'frmAgregarLibro
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1084, 485)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnCambiarPortada)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.lblAutor)
        Me.Controls.Add(Me.lblNombreLibro)
        Me.Controls.Add(Me.cboxCategoria)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtAutor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAgregarLibro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Libro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAutor As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents cboxCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents lblNombreLibro As System.Windows.Forms.Label
    Friend WithEvents lblAutor As System.Windows.Forms.Label
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnCambiarPortada As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
End Class
