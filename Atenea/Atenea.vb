Imports MySql.Data.MySqlClient ' Importa el módulo de MySQL
Public Class Atenea

    ' Clase principal del programa
    
    Friend atenea As frmMain
    Friend funcionario As Boolean = False
    Friend CI as String
    Dim login As frmNewLogin
    Dim registro As frmNewRegistro

    Private Sub Atenea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Al cargar, agregarLogin por defecto
        agregarLogin()
    End Sub

    Public Sub agregarLogin()
        ' Agrega el login de usuario/funcionario a la ventana principal
        Me.Controls.Clear()
        Me.Text = "Ingreso · Atenea"
        Me.Width = 610
        Me.Height = 420
        Centrar()

        login = New frmNewLogin()
        Me.Controls.Add(login)
    End Sub

    Public Sub agregarRegistro()
        ' Agrega el registro de funcionario a la ventana principal
        Me.Controls.Clear()
        Me.Text = "Registro de funcionario · Atenea"
        Me.Width = 610
        Me.Height = 420

        Centrar()
        registro = New frmNewRegistro()
        Me.Controls.Add(registro)
    End Sub

    Public Sub agregarAtenea(ByVal CI As String, Optional ByVal firstLogin As Boolean = False, Optional ByVal esFuncionario As Boolean = False)
        ' Agrega el userControlForm de Atenea a la ventana principal.

        Me.Controls.Clear()
        Me.Text = "Atenea"
        Me.Width = 1280
        Me.Height = 700
        Centrar()

        funcionario = esFuncionario
        Me.CI = CI

        atenea = New frmMain(CI, firstLogin, esFuncionario)

        Me.Controls.Add(atenea)
    End Sub

    Public Sub cargarLibros()
        ' Llama a la función cargarLibros de atenea
        atenea.cargarLibros()
    End Sub

    Private Sub Centrar()
        ' Centra la ventana
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
    End Sub

End Class