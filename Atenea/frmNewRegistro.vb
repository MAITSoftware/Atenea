﻿Imports MySql.Data.MySqlClient 'Importa MySql.Data.MySqlClient
Public Class frmNewRegistro

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click 'Al hacer click en btnCancelar
        Atenea.agregarLogin()
    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click 'Al hacer click en btnRegistrarse
        Try
            Atenea.DB.Reader.Close()
        Catch ex As Exception
        End Try

        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("INSERT INTO `usuario` VALUES ('{0}', '{1}', '{2}', '{3}', 'Funcionario');", txtCI.Text, txtNombre.Text, txtApellido.Text, txtContrasenia.Text), Atenea.DB.Conn)

        Try
            cmd.ExecuteNonQuery()
            Atenea.agregarAtenea(txtCI.Text, False, True)
        Catch ex As Exception
            Console.Write(ex.ToString())
            lblInfo.Visible = True 'Muestra lblInfo
        End Try
    End Sub

    Private Sub checkEscrito(sender As Object, e As EventArgs) Handles txtNombre.TextChanged, txtApellido.TextChanged, txtCI.TextChanged, txtContrasenia.TextChanged
        btnRegistrarse.Enabled = Not (String.IsNullOrWhiteSpace(txtNombre.Text) Or String.IsNullOrWhiteSpace(txtApellido.Text) Or String.IsNullOrWhiteSpace(txtCI.Text) Or String.IsNullOrEmpty(txtContrasenia.Text))
        'btnRegistrarse se activará si los campos txtCI, txtNombre, txtApellido y txtContrasenia han sido llenados
        lblInfo.Visible = False 'Oculta lblInfo
    End Sub
End Class
