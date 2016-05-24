<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libro
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
        Me.imgNoDisponible = New System.Windows.Forms.PictureBox()
        Me.imgPortada = New System.Windows.Forms.PictureBox()
        Me.imgBorde = New System.Windows.Forms.PictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        CType(Me.imgNoDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPortada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBorde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgNoDisponible
        '
        Me.imgNoDisponible.BackgroundImage = Global.Atenea.My.Resources.Resources.sombra_nodisponible
        Me.imgNoDisponible.Location = New System.Drawing.Point(0, 0)
        Me.imgNoDisponible.Margin = New System.Windows.Forms.Padding(0)
        Me.imgNoDisponible.Name = "imgNoDisponible"
        Me.imgNoDisponible.Size = New System.Drawing.Size(150, 150)
        Me.imgNoDisponible.TabIndex = 3
        Me.imgNoDisponible.TabStop = False
        '
        'imgPortada
        '
        Me.imgPortada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgPortada.Location = New System.Drawing.Point(3, 2)
        Me.imgPortada.Margin = New System.Windows.Forms.Padding(0)
        Me.imgPortada.Name = "imgPortada"
        Me.imgPortada.Size = New System.Drawing.Size(145, 145)
        Me.imgPortada.TabIndex = 2
        Me.imgPortada.TabStop = False
        '
        'imgBorde
        '
        Me.imgBorde.BackgroundImage = Global.Atenea.My.Resources.Resources.borde
        Me.imgBorde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgBorde.Location = New System.Drawing.Point(0, 20)
        Me.imgBorde.Margin = New System.Windows.Forms.Padding(0)
        Me.imgBorde.Name = "imgBorde"
        Me.imgBorde.Size = New System.Drawing.Size(150, 150)
        Me.imgBorde.TabIndex = 1
        Me.imgBorde.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(150, 20)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Título"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Libro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.imgNoDisponible)
        Me.Controls.Add(Me.imgPortada)
        Me.Controls.Add(Me.imgBorde)
        Me.Margin = New System.Windows.Forms.Padding(10)
        Me.Name = "Libro"
        Me.Size = New System.Drawing.Size(150, 170)
        CType(Me.imgNoDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPortada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBorde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgBorde As System.Windows.Forms.PictureBox
    Private WithEvents imgPortada As System.Windows.Forms.PictureBox
    Friend WithEvents imgNoDisponible As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label

End Class
