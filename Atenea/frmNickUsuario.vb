Imports MySql.Data.MySqlClient 'Importa MySql.Data.MySqlClient
Public Class frmNickUsuario
    Dim CI As String 'Define CI como String

    Public Sub New(ByVal ci_ As String)
        InitializeComponent()
        CI = ci_
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click 'Al hacer click en aceptar
        Dim conexion As New DB() 'Establece conexión con la DB
        'Guarda los datos del usuario en la DB
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO `usuario` (`CI`, `Nombre`, `Tipo`) VALUES ('{0}', '{1}', 'Usuario');", CI, txtNick.Text), conexion.Conn)
        cmd.ExecuteNonQuery()
        Atenea.atenea.cargarNick()
        conexion.Close() 'Cierra la conexión
        Me.Dispose()
    End Sub

    Private Sub EnterClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNick.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            btnAceptar.PerformClick()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click 'Al presionar Cancelar
        Atenea.atenea.Dispose()
        Me.Dispose()
        Atenea.agregarLogin() 'Vuelve al login
    End Sub

    Private Sub txtNick_TextChanged(sender As Object, e As EventArgs) Handles txtNick.TextChanged
        btnAceptar.Enabled = Not (String.IsNullOrWhiteSpace(txtNick.Text)) 'Si no hay texto en el txtNick, el botón aceptar no puede ser clickeado
    End Sub

End Class