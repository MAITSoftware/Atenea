Imports MySql.Data.MySqlClient
Public Class frmNickUsuario
    Dim CI As String
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO `usuario` (`CI`, `Nombre`, `Tipo`) VALUES ('{0}', '{1}', 'Usuario');", CI, TextBox1.Text), Atenea.conexion)
        cmd.ExecuteNonQuery()
        Me.Dispose()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        Atenea.agregarLogin()
    End Sub
    Public Sub New(ByVal ci_ As String)
        InitializeComponent()
        CI = ci_
    End Sub
End Class