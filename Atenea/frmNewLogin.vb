﻿Imports MySql.Data.MySqlClient 'Importa MySql.Data.MySqlClient
Public Class frmNewLogin

    Private Sub rbtnFuncionario_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFuncionario.CheckedChanged

        If rbtnFuncionario.Checked Then 'Si rbtn fue seleccionado
            lblContrasenia.Visible = True 'Muestra lblContrasenia
            txtContrasenia.Visible = True 'Muestra txtContrasenia
            lblNuevoUsuario.Visible = True 'Muestra lblNuevoUsuario
            btnRegistrarse.Visible = True 'Muestra btnRegistrarse

            lblCI.Location = New Point(391, 128) 'Cambia la posición de lblCI
            txtICI.Location = New Point(372, 155) 'Cambia la posición de txtICI
            btnEntrar.Location = New Point(393, 284) 'Cambia la posición de btnEntrar
        Else 'Sino
            txtICI.Text = ""
            lblContrasenia.Visible = False 'Oculta lblContrasenia
            txtContrasenia.Visible = False 'Oculta txtContrasenia
            lblNuevoUsuario.Visible = False 'Oculta lblNuevoUsuario
            btnRegistrarse.Visible = False 'Oculta btnRegistrarse

            lblCI.Location = New Point(391, 149) 'Cambia la posición de lblCI
            txtICI.Location = New Point(372, 176) 'Cambia la posición de txtICI
            btnEntrar.Location = New Point(393, 232) 'Cambia la posición de btnEntrar

        End If
    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click 'Al hacer click en btnRegistrarse
        Atenea.agregarRegistro()
    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click 'Al hacer click en btnEntrar
        Dim precisaNick As Boolean = True 'Define precisaNick como Boolean
        Dim datosCorrectos As Boolean = False 'Define datosCorrectos como Boolean
        Dim sentencia As String 'Define sentencia como String
        Try
            Atenea.DB.Reader.Close()
        Catch ex As Exception
        End Try


        If rbtnFuncionario.Checked Then 'Si rbtnFuncionario es seleccionado
            sentencia = String.Format("SELECT * FROM `usuario` WHERE CI='{0}' AND Contrasenia='{1}' AND Tipo='Funcionario';", txtICI.Text, txtContrasenia.Text)
            Dim cmd As MySqlCommand = New MySqlCommand(sentencia, Atenea.DB.Conn) 'Define cmd como MySqlCommand con los parámetros sentencia y Atenea.DB.Conn
            Atenea.DB.Reader = cmd.ExecuteReader()

            While Atenea.DB.Reader.Read()
                Atenea.DB.Reader.Read()
                Atenea.DB.Reader.GetString(0)
                datosCorrectos = True 'Define datosCorrectos como true
            End While

            If Not datosCorrectos Then 'Si datosCorrectos es false
                lblInfo.Visible = True 'Muestra lblInfo
                Return
            End If

            Atenea.DB.Reader.Close()
            Atenea.agregarAtenea(txtICI.Text, False, True)

        Else 'Si rbtnFuncionario no es seleccionado
            sentencia = String.Format("SELECT `Nombre`, `Tipo` FROM `usuario` WHERE CI='{0}';", txtICI.Text)
            Dim cmd As MySqlCommand = New MySqlCommand(sentencia, Atenea.DB.Conn) 'Define cmd como MySqlCommand con los parámetros sentencia y Atenea.DB.Conn
            Atenea.DB.Reader = cmd.ExecuteReader()

            While Atenea.DB.Reader.Read()
                Atenea.DB.Reader.Read()
                Atenea.DB.Reader.GetString(0)
                If Atenea.DB.Reader.GetString(1) = "Funcionario" Then
                    rbtnFuncionario.Checked = True

                    Atenea.DB.Reader.Close()
                    Return
                End If

                precisaNick = False 'Define precisaNick como false
            End While

            Atenea.DB.Reader.Close()
            Atenea.agregarAtenea(txtICI.Text, precisaNick)
        End If

    End Sub

    Private Sub checkEscrito(sender As Object, e As EventArgs) Handles txtICI.TextChanged, txtContrasenia.TextChanged
        btnEntrar.Enabled = Not (String.IsNullOrWhiteSpace(txtICI.Text)) 'btnEntrar se activará si txtICI no está vacío
        If rbtnFuncionario.Checked Then 'Si rbtn fue seleccionado
            btnEntrar.Enabled = Not (String.IsNullOrWhiteSpace(txtICI.Text) Or String.IsNullOrEmpty(txtContrasenia.Text)) 'btnEntrar se activará si txtICI o txtContrasenia no están vacíos
        End If

        lblInfo.Visible = False 'Oculta lblInfo
    End Sub


End Class
