Imports MySql.Data.MySqlClient 'Importa MySql.Data.MySqlClient
Public Class frmNickUsuario
    ' frmNickUsuario: form para pedirle nick a los usuarios nuevos
    
    Dim CI As String 

    Public Sub New(ByVal ci_ As String)
        InitializeComponent()
        CI = ci_
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ' Al clickear aceptar, guardar nick del usuario en la DB
        Dim conexion As New DB()
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO `usuario` (`CI`, `Nombre`, `Tipo`) VALUES ('{0}', '{1}', 'Usuario');", CI, txtNick.Text), conexion.Conn)
        cmd.ExecuteNonQuery()
        Atenea.atenea.cargarNick()
        conexion.Close()
        Me.Dispose()
    End Sub

    Private Sub EnterClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNick.KeyDown
        ' Al presionar enter clickear el botón aceptar
        If e.KeyCode.Equals(Keys.Enter) Then
            btnAceptar.PerformClick()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ' Al presionar Cancelar vuelve al login
        Atenea.atenea.Dispose()
        Me.Dispose()
        Atenea.agregarLogin()
    End Sub

    Private Sub txtNick_TextChanged(sender As Object, e As EventArgs) Handles txtNick.TextChanged
        ' Al cambiar el nick, comprueba si hay texto en el txtNick, de no ser así, el botón aceptar no puede ser clickeado
        btnAceptar.Enabled = Not (String.IsNullOrWhiteSpace(txtNick.Text)) 
    End Sub

End Class