﻿Imports MySql.Data.MySqlClient
Public Class Atenea

    Dim atenea As frmMain
    Dim login As frmNewLogin
    Dim registro As frmNewRegistro

    Friend conexion As New MySqlConnection("server=kuckuck.treehouse.su;uid=agustina;password=agustina;database=Atenea")

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

    Public Sub agregarAtenea()

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Controls.Clear()
        Me.Text = "Atenea"
        Me.Width = 1280
        Me.Height = 700
        Centrar()

        atenea = New frmMain()
        Me.Controls.Add(atenea)

        Me.Cursor = System.Windows.Forms.Cursors.Arrow

    End Sub

    Private Sub Centrar()
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
    End Sub
End Class