Imports MySql.Data.MySqlClient
Public Class Libro

    Dim estaDisponible As Boolean = True
    Dim llaveLibro As String
    Dim tooltip As New ToolTip()
    Dim preview As Boolean = False
    Dim pathPortada As String
    Dim fc As OpenFileDialog = New OpenFileDialog()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fc.Title = "Seleccionar portada"
        fc.Filter = "Archivos de mapa de bits (*.bmp, *.dib)|*.BMP;*.DIB;*.RLE|JPEG (*.jpg, *.jpeg, *.jpeg, *.jfif)|*.JPG;*.JPEG;*.JPE;*.JFIF|GIF (*.gif)|*.GIF|TIFF (*.tif, *.tiff)|*.TIF;*.TIFF|PNG (*.png)|*.PNG|Todos los archivos|*.*|Todos los archivos de imagen|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG"
        fc.FilterIndex = 7
        fc.RestoreDirectory = True

        imgNoDisponible.BackgroundImage = Nothing
        imgBorde.Cursor = Cursors.Hand
        imgPortada.Parent = imgBorde
        imgNoDisponible.Parent = imgPortada
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
            lblTitulo.Text = Atenea.reader.GetString(0)
            tooltip.SetToolTip(imgNoDisponible, "Título: " & Atenea.reader.GetString(0) & ControlChars.NewLine &
                                                "Autor: " & Atenea.reader.GetString(1) & ControlChars.NewLine &
                                                "Género: " & Atenea.reader.GetString(3) & ControlChars.NewLine &
                                                "Condición: " & Atenea.reader.GetString(4) & ControlChars.NewLine &
                                                "ID: " & Atenea.reader.GetString(5))

            Dim byteImage() As Byte = Atenea.reader("Portada")
            Dim foto As New System.IO.MemoryStream(byteImage)
            imgPortada.BackgroundImage = Image.FromStream(foto)
        End While

        Atenea.reader.Close()

        sentencia = String.Format("SELECT ID FROM Prestamo WHERE ID='{0}';", llaveLibro)
        cmd = New MySqlCommand(sentencia, Atenea.conexion)
        Atenea.reader = cmd.ExecuteReader()

        While Atenea.reader.Read()
            imgNoDisponible.BackgroundImage = My.Resources.sombra_nodisponible()
        End While

        Atenea.reader.Close()

    End Sub

    Public Sub New(ByVal llaveLibro As String, ByVal preview_ As Boolean)
        InitializeComponent()
        preview = preview_
        Me.llaveLibro = llaveLibro
    End Sub

    Public Sub imgNoDisponible_Click(sender As Object, e As EventArgs) Handles imgNoDisponible.Click
        If Not preview Then
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
        imgBorde.BackgroundImage = My.Resources.borde_hover()
    End Sub
End Class
