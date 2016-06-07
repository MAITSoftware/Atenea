Imports MySql.Data.MySqlClient 'Importa MySql.Data.MySqlClient
Public Class frmNickUsuario
    Dim CI As String 'Define CI como String
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click 'Al hacer click en aceptar
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO `usuario` (`CI`, `Nombre`, `Tipo`) VALUES ('{0}', '{1}', 'Usuario');", CI, TextBox1.Text), Atenea.conexion)
        cmd.ExecuteNonQuery()
        Atenea.atenea.cargarNick()
        Me.Dispose()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Atenea.atenea.Dispose()
        Me.Dispose()
        Atenea.agregarLogin()
    End Sub
    Public Sub New(ByVal ci_ As String)
        InitializeComponent()
        CI = ci_
    End Sub


    Private Sub frmNickUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class