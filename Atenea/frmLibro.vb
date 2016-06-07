Imports MySql.Data.MySqlClient
Public Class Libro

    Dim estaDisponible As Boolean = True
    Dim llaveLibro As String
    Dim previewEditable As Boolean = False
    Dim preview As Boolean = False
    Dim fc As OpenFileDialog = New OpenFileDialog()
    Friend Titulo, Genero, Autor, ID, Condicion, pathPortada As String


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fc.Title = "Seleccionar portada"
        fc.Filter = "Archivos de mapa de bits (*.bmp, *.dib)|*.BMP;*.DIB;*.RLE|JPEG (*.jpg, *.jpeg, *.jpeg, *.jfif)|*.JPG;*.JPEG;*.JPE;*.JFIF|GIF (*.gif)|*.GIF|TIFF (*.tif, *.tiff)|*.TIF;*.TIFF|PNG (*.png)|*.PNG|Todos los archivos|*.*|Todos los archivos de imagen|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG"
        fc.FilterIndex = 7
        fc.RestoreDirectory = True

        imgNoDisponible.BackgroundImage = Nothing
        imgBorde.Cursor = Cursors.Hand
        imgPortada.Parent = imgBorde
        imgNoDisponible.Parent = imgPortada
        btnEditar.Parent = imgNoDisponible
        btnEliminar.Parent = imgNoDisponible

        Call New ToolTip().SetToolTip(btnEditar, "Editar libro")
        Call New ToolTip().SetToolTip(btnEliminar, "Eliminar libro")

        If Not Atenea.funcionario Or preview Or previewEditable Then
            btnEditar.Visible = False
            btnEliminar.Visible = False
        End If
    End Sub

    Public Sub actualizarDatos()
        Dim sentencia As String = String.Format("SELECT * FROM `libro` WHERE ID='{0}';", llaveLibro)
        Try
            Atenea.reader.Close()
        Catch ex As Exception
        End Try

        Dim cmd As MySqlCommand = New MySqlCommand(sentencia, Atenea.conexion)
        Atenea.reader = cmd.ExecuteReader()

        While Atenea.reader.Read()
            Me.Titulo = Atenea.reader("Titulo")
            Me.Genero = Atenea.reader("Genero")
            Me.Autor = Atenea.reader("Autor")
            Me.ID = Atenea.reader("ID")
            Me.Condicion = Atenea.reader("Condicion")

            lblTitulo.Text = Me.Titulo

            If Not (preview Or previewEditable) Then
                Call New ToolTip().SetToolTip(imgNoDisponible, "Título: " & Me.Titulo & ControlChars.NewLine &
                                                    "Autor: " & Me.Autor & ControlChars.NewLine &
                                                    "Género: " & Me.Genero & ControlChars.NewLine &
                                                    "Condición: " & Me.Condicion & ControlChars.NewLine &
                                                    "ID: " & Me.ID)
            End If
            Dim byteImage() As Byte = Atenea.reader("Portada")
            Dim foto As New System.IO.MemoryStream(byteImage)
            imgPortada.BackgroundImage = Image.FromStream(foto)
        End While

        Atenea.reader.Close()

        sentencia = String.Format("SELECT ID FROM prestamo WHERE ID='{0}';", llaveLibro)
        cmd = New MySqlCommand(sentencia, Atenea.conexion)
        Atenea.reader = cmd.ExecuteReader()

        If Atenea.funcionario And Not (preview Or previewEditable) Then
            btnEditar.Visible = True
            btnEliminar.Visible = True
        End If

        btnEditar.Location = New Point(100, 0)
        btnEliminar.Location = New Point(125, 0)

        imgNoDisponible.BackgroundImage = Nothing
        imgNoDisponible.Cursor = Cursors.Hand

        While Atenea.reader.Read()
            imgNoDisponible.BackgroundImage = My.Resources.sombra_nodisponible()
            If Not (preview Or previewEditable) Then
                imgNoDisponible.Cursor = Cursors.No
            End If
            btnEliminar.Visible = False
            btnEditar.Location = New Point(125, 0)
        End While

        Atenea.reader.Close()

    End Sub

    Public Sub New(ByVal llaveLibro As String, ByVal previewE As Boolean, Optional ByVal prev As Boolean = False)
        InitializeComponent()
        previewEditable = previewE
        preview = prev
        Me.llaveLibro = llaveLibro
    End Sub

    Public Sub imgNoDisponible_Click(sender As Object, e As EventArgs) Handles imgNoDisponible.Click

        If Atenea.funcionario And Not (preview Or previewEditable) And Not (imgNoDisponible.Cursor Is Cursors.No) Then
            Dim frm As New frmConfPrestamo(llaveLibro)
            frm.ShowDialog(Me.ParentForm)
        End If

        If Not previewEditable Then
            Return
        End If
        If fc.ShowDialog(Me.ParentForm) = DialogResult.OK Then
            pathPortada = fc.FileName

    Dim portada As Bitmap = New Bitmap(pathPortada)
            imgPortada.BackgroundImage = portada
        End If
    End Sub

    Private Sub imgBorde_Enter(sender As Object, e As EventArgs) Handles imgNoDisponible.MouseLeave
        imgBorde.BackgroundImage = My.Resources.borde()
    End Sub

    Private Sub imgBorde_Leave(sender As Object, e As EventArgs) Handles imgNoDisponible.MouseEnter
        If preview Or previewEditable Then
            Return
        End If
        imgBorde.BackgroundImage = My.Resources.borde_hover()
    End Sub

    Private Sub btnEditar_Leave(sender As Object, e As EventArgs) Handles btnEditar.MouseLeave
        btnEditar.BackgroundImage = My.Resources.editarLibro()
    End Sub

    Private Sub btnEditar_Enter(sender As Object, e As EventArgs) Handles btnEditar.MouseEnter
        btnEditar.BackgroundImage = My.Resources.editarLibro_()
    End Sub
    Private Sub btnEliminar_Leave(sender As Object, e As EventArgs) Handles btnEliminar.MouseLeave
        btnEliminar.BackgroundImage = My.Resources.eliminarLibro()
    End Sub

    Private Sub btnEliminar_Enter(sender As Object, e As EventArgs) Handles btnEliminar.MouseEnter
        btnEliminar.BackgroundImage = My.Resources.eliminarLibro_()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim editar As frmAgregarLibro
        editar = New frmAgregarLibro(True, Me.llaveLibro)
        editar.ShowDialog(Me)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim eliminar As frmEliminar
        eliminar = New frmEliminar(Me.llaveLibro)
        eliminar.ShowDialog(Me)
    End Sub
End Class
