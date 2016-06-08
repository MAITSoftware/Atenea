Imports MySql.Data.MySqlClient ' Importa el módulo de MySQL
Public Class Atenea

    ' atenea, funcionario y CI son variables globales
    ' Funcionario indica si el usuario en el sistema es funcionario
    ' Atenea es la instancia de frmMain, la cual continene las funciones para actualizar la vista de libros
    ' CI es la cédula del usuario actual
    
    Friend atenea As frmMain
    Friend funcionario As Boolean = False
    Friend CI as String
    Dim login As frmNewLogin
    Dim registro As frmNewRegistro

    Private Sub Atenea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Al cargar, agregarLogin por defecto.
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
        ' Agrega el registro de funcionario a la ventana principal.
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
        ' Parámetros: Obligatorio CI del Usuario, adicionales: firstLogin -- primer login, y esFuncionario.

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Controls.Clear()
        Me.Text = "Atenea"
        Me.Width = 1280
        Me.Height = 700
        Centrar()

        funcionario = esFuncionario
        Me.CI = CI

        atenea = New frmMain(CI, firstLogin, esFuncionario)

        Me.Controls.Add(atenea)

        Me.Cursor = System.Windows.Forms.Cursors.Arrow

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