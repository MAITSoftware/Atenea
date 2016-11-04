﻿Imports MySql.Data.MySqlClient ' Importa el módulo de MySQL
Public Class DB
    ' Define la conexión como variable pública
    Friend Conn as MySqlConnection

    Public Sub New()
        ' Al crear la clase, generar la conexión, y abrirla
        Try
            Conn = New MySqlConnection("server=localhost;uid=atenea;password=atenea;database=atenea")
            Conn.Open()
        Catch ex As Exception
        ' En caso de error mostrar un mensaje y salir
            System.Console.WriteLine(ex)
            MsgBox("Error al establecer la conexión con el servidor", MsgBoxStyle.Critical)
            Environment.Exit(0)
        End Try
    End Sub

    Public Sub Close()
        ' Cierra la conexión
        Conn.Close()
    End Sub
End Class