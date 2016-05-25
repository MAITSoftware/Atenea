Public Class Libro

    Dim estaDisponible As Boolean
    Dim llaveLibro As String
    Dim tooltip As New ToolTip()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 
        ' Redimensiona la portada.
        Dim bmpPortada As New Bitmap(Atenea.My.Resources.Resources.tymon())
        If estaDisponible Then
            bmpPortada = New Bitmap(Atenea.My.Resources.Resources.ignacio())
            imgNoDisponible.BackgroundImage = Nothing
            imgBorde.Cursor = Cursors.Hand
        End If

        imgPortada.BackgroundImage = bmpPortada
        imgPortada.Parent = imgBorde
        imgNoDisponible.Parent = imgPortada

        tooltip.SetToolTip(imgNoDisponible, "Título: Pepe" & ControlChars.NewLine &
                                            "Autor: Peposo" & ControlChars.NewLine &
                                            "Categoría: Novela" & ControlChars.NewLine &
                                            "ID: 2837asd")
    End Sub


    Public Sub New(ByVal llaveLibro As String, ByVal disponible As Boolean)
        InitializeComponent()
        estaDisponible = disponible
        Me.llaveLibro = llaveLibro
    End Sub

    Private Sub imgBordeTooltip_Mostrar(ByVal sender As Object, ByVal e As EventArgs) Handles imgBorde.MouseHover
        tooltip.Show("the message", Me)
    End Sub

    Private Sub imgBordeTooltip_Ocultar(ByVal sender As Object, ByVal e As EventArgs) Handles imgBorde.MouseLeave
        tooltip.Hide(Me)
    End Sub


End Class
