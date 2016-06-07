Imports MySql.Data.MySqlClient
Public Class Atenea

    Friend atenea As frmMain
    Dim login As frmNewLogin
    Dim registro As frmNewRegistro
    Friend funcionario As Boolean = False

    Private Sub Atenea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Public Sub agregarAtenea(ByVal CI As String, Optional ByVal firstLogin As Boolean = False, Optional ByVal esFuncionario As Boolean = False)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Controls.Clear()
        Me.Text = "Atenea"
        Me.Width = 1280
        Me.Height = 700
        Centrar()

        funcionario = esFuncionario

        atenea = New frmMain(CI, firstLogin, esFuncionario)

        Me.Controls.Add(atenea)

        Me.Cursor = System.Windows.Forms.Cursors.Arrow

    End Sub

    Private Sub Centrar()
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
    End Sub
End Class