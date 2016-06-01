Public Class Libro

    Dim estaDisponible As Boolean = True
    Dim llaveLibro As String
    Dim tooltip As New ToolTip()
    Dim preview As Boolean = False
    Dim pathPortada As String
    Dim fc As OpenFileDialog = New OpenFileDialog()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizarDatos()
        fc.Title = "Seleccionar portada"
        fc.Filter = "Archivos de mapa de bits (*.bmp, *.dib)|*.BMP;*.DIB;*.RLE|JPEG (*.jpg, *.jpeg, *.jpeg, *.jfif)|*.JPG;*.JPEG;*.JPE;*.JFIF|GIF (*.gif)|*.GIF|TIFF (*.tif, *.tiff)|*.TIF;*.TIFF|PNG (*.png)|*.PNG|Todos los archivos|*.*|Todos los archivos de imagen|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG"
        fc.FilterIndex = 7
        fc.RestoreDirectory = True
    End Sub

    Public Sub actualizarDatos()
        Dim bmpPortada As New Bitmap(My.Resources.Resources.Logo())
        If estaDisponible Then
            imgNoDisponible.BackgroundImage = Nothing
            imgBorde.Cursor = Cursors.Hand
        End If

        Dim string_disponible As String = "Disponible"
        If Not estaDisponible Then
            string_disponible = "No disponible"
        End If

        imgPortada.BackgroundImage = bmpPortada
        imgPortada.Parent = imgBorde
        imgNoDisponible.Parent = imgPortada

        tooltip.SetToolTip(imgNoDisponible, "Título: Pepe" & ControlChars.NewLine &
                                            "Autor: Peposo" & ControlChars.NewLine &
                                            "Categoría: Novela" & ControlChars.NewLine &
                                            "ID: 2837asd" & ControlChars.NewLine & string_disponible)

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
End Class
