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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.PictureBox()
        Me.btnEditar = New System.Windows.Forms.PictureBox()
        Me.imgNoDisponible = New System.Windows.Forms.PictureBox()
        Me.imgPortada = New System.Windows.Forms.PictureBox()
        Me.imgBorde = New System.Windows.Forms.PictureBox()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgNoDisponible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgPortada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBorde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(150, 20)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Preview"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEliminar
        '
        Me.btnEliminar.BackgroundImage = Global.Atenea.My.Resources.Resources.eliminarLibro
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Location = New System.Drawing.Point(125, 0)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(20, 20)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.TabStop = False
        '
        'btnEditar
        '
        Me.btnEditar.BackgroundImage = Global.Atenea.My.Resources.Resources.editarLibro
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Location = New System.Drawing.Point(100, 0)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(20, 20)
        Me.btnEditar.TabIndex = 5
        Me.btnEditar.TabStop = False
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
        Me.imgPortada.BackgroundImage = Global.Atenea.My.Resources.Resources.Logo
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
        Me.imgBorde.Cursor = System.Windows.Forms.Cursors.Help
        Me.imgBorde.Location = New System.Drawing.Point(0, 20)
        Me.imgBorde.Margin = New System.Windows.Forms.Padding(0)
        Me.imgBorde.Name = "imgBorde"
        Me.imgBorde.Size = New System.Drawing.Size(150, 150)
        Me.imgBorde.TabIndex = 1
        Me.imgBorde.TabStop = False
        '
        'Libro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.imgNoDisponible)
        Me.Controls.Add(Me.imgPortada)
        Me.Controls.Add(Me.imgBorde)
        Me.Margin = New System.Windows.Forms.Padding(10)
        Me.Name = "Libro"
        Me.Size = New System.Drawing.Size(150, 170)
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgNoDisponible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgPortada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBorde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgBorde As System.Windows.Forms.PictureBox
    Friend WithEvents imgNoDisponible As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents imgPortada As System.Windows.Forms.PictureBox
    Friend WithEvents btnEditar As System.Windows.Forms.PictureBox
    Friend WithEvents btnEliminar As System.Windows.Forms.PictureBox

End Class
