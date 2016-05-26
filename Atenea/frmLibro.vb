Public Class Libro

    Dim estaDisponible As Boolean
    Dim llaveLibro As String
    Dim tooltip As New ToolTip()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 
        ' Redimensiona la portada.
        Dim bmpPortada As New Bitmap(My.Resources.Resources.Pintando())
        If estaDisponible Then
            bmpPortada = New Bitmap(My.Resources.Resources.ignacio())
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


    Public Sub New(ByVal llaveLibro As String, ByVal disponible As Boolean)
        InitializeComponent()
        estaDisponible = disponible
        Me.llaveLibro = llaveLibro
    End Sub


End Class
