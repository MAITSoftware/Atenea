Public Class Libro

    Dim estaDisponible As Boolean
    Dim llaveLibro As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 
        ' Redimensiona la portada.
        Dim bmpPortada As New Bitmap(Atenea.My.Resources.Resources.tymon())
        If estaDisponible Then
            bmpPortada = New Bitmap(Atenea.My.Resources.Resources.ignacio())
            imgNoDisponible.Dispose()
        End If

        imgPortada.BackgroundImage = bmpPortada
        imgPortada.Parent = imgBorde
        imgNoDisponible.Parent = imgPortada
    End Sub


    Public Sub New(ByVal llaveLibro As String, ByVal disponible As Boolean)
        InitializeComponent()
        estaDisponible = disponible
        Me.llaveLibro = llaveLibro

    End Sub

End Class
