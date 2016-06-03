Imports MySql.Data.MySqlClient
Public Class Atenea

    Friend atenea As frmMain
    Dim login As frmNewLogin
    Dim registro As frmNewRegistro
    Friend funcionario As Boolean = False

    Friend conexion As New MySqlConnection("server=localhost;uid=root;password=ignacio;database=Atenea")
    Friend reader As MySqlDataReader

    Private Sub Atenea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.Open()
        Catch ex As Exception
            System.Console.WriteLine(ex)
            MsgBox("Error al establecer la conexión con el servidor", MsgBoxStyle.Critical)
            Environment.Exit(0)
        End Try

        agregarLogin()
    End Sub

    Public Sub agregarLogin()
        Me.Controls.Clear()
        Me.Text = "Ingreso · Atenea"
        Me.Width = 610
        Me.Height = 420
        Centrar()

        login = New frmNewLogin()
        Me.Controls.Add(login)
    End Sub

    Public Sub agregarRegistro()
        Me.Controls.Clear()
        Me.Text = "Registro de funcionario · Atenea"
        Me.Width = 610
        Me.Height = 420

        Centrar()
        registro = New frmNewRegistro()
        Me.Controls.Add(registro)
    End Sub

    Public Sub agregarAtenea(ByVal CI As String, Optional ByVal primeraVez As Boolean = False, Optional ByVal f As Boolean = False)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Controls.Clear()
        Me.Text = "Atenea"
        Me.Width = 1280
        Me.Height = 700
        Centrar()

        funcionario = f

        atenea = New frmMain(CI, primeraVez, funcionario)

        Me.Controls.Add(atenea)

        Me.Cursor = System.Windows.Forms.Cursors.Arrow

    End Sub

    Private Sub Centrar()
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
    End Sub
End Class