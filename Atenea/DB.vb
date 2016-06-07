Imports MySql.Data.MySqlClient
Public Class DB
    Friend Conn As New MySqlConnection("server=localhost;uid=atenea;password=atenea;database=atenea")
    Friend Reader As MySqlDataReader

    Public Sub New()
        Try
            Conn.Open()
        Catch ex As Exception
            System.Console.WriteLine(ex)
            MsgBox("Error al establecer la conexión con el servidor", MsgBoxStyle.Critical)
            Environment.Exit(0)
        End Try
    End Sub
End Class
