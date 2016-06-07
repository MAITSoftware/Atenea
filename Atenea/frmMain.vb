Imports MySql.Data.MySqlClient 'Importa MySql.Data.MySqlClient
Public Class frmMain

    Dim interfazFuncionario, buscando, pedirNick As Boolean 'Define interfazFuncionario como Boolean
    Friend CI As String 'Define CI como String
 
    Public Sub New(ByVal ID As String, Optional ByVal firstLogin As Boolean = False, Optional ByVal esFuncionario As Boolean = False)
        InitializeComponent()
        pedirNick = firstLogin
        interfazFuncionario = esFuncionario
        CI = ID
    End Sub
 
    Private Sub mainLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLibros()
        cboxGenero.SelectedIndex = 0
 
        If pedirNick Then 
            Dim ventanaNick As frmNickUsuario = New frmNickUsuario(CI) 
            ventanaNick.ShowDialog(Me)
        Else
            cargarNick()
        End If

        If Not interfazFuncionario Then 
            btnAgregarLibro.Visible = False 
            btnAgregar_temporal.Visible = False 
            btnPrestamos.Text = "Préstamo en curso"
            CheckPrestamo()
        End If


        Me.Cursor = System.Windows.Forms.Cursors.Arrow
    End Sub
 
    Public Sub cargarNick()
        Dim Nombre As String
        Dim Apellido As String = ""
        Dim conexion As New DB()
        Dim cmd As MySqlCommand = New MySqlCommand("select Nombre,Apellido from usuario where CI=@id;", conexion.Conn) 'Define cmd como MySqlCommand con los parámetros sentencia y Atenea.DB.Conn
        cmd.Parameters.AddWithValue("@id", CI)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        reader.Read()
        Nombre = reader("Nombre")
        Try
            Apellido = reader("Apellido")
        Catch ex As Exception
        End Try
        reader.Close()
        conexion.Conn.Close()

        lblBienvenida.Text = "Bienvenido/a " & ControlChars.NewLine & Nombre & " " & Apellido
    End Sub

    Public Sub cargarLibros()
        Dim sentencia As String = "SELECT `ID` FROM `libro`"
 
        If cboxDisponibles.Checked Then
            sentencia += " order by (ID in (select ID from prestamo));"
        Else
            sentencia += " order by (ID in (select ID from prestamo)) DESC;"
        End If

        If buscando Then
            If radioNombre.Checked Then
                sentencia = String.Format("SELECT `ID` FROM `libro` WHERE Titulo LIKE '{0}%'", txtBusqueda.Text)
            ElseIf radioAutor.Checked Then
                sentencia = String.Format("SELECT `ID` FROM `libro` WHERE Autor LIKE '{0}%'", txtBusqueda.Text)
            ElseIf radioID.Checked Then
                sentencia = String.Format("SELECT `ID` FROM `libro` WHERE ID LIKE '{0}%'", txtBusqueda.Text)
            End If

            If chkGenero.Checked Then
                sentencia += String.Format(" AND Genero='{0}'", cboxGenero.Text)
            End If

            If cboxDisponibles.Checked Then
                sentencia += " order by (ID in (select ID from prestamo));"
            Else
                sentencia += " order by (ID in (select ID from prestamo)) DESC;"
            End If

        End If
 
        panelLibros.Controls.Clear()
        lblNoDisponibles.Text = "No hay libros disponibles"
        panelLibros.Controls.Add(lblNoDisponibles)
        If interfazFuncionario Then
            panelLibros.Controls.Add(btnAgregar_temporal)
        End If

        Dim conexion As DB = New DB()
        Dim cmd As MySqlCommand = New MySqlCommand(sentencia, conexion.Conn) 'Define cmd como MySqlCommand con los parámetros sentencia y Atenea.DB.Conn
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            panelLibros.Controls.Remove(lblNoDisponibles)
            panelLibros.Controls.Remove(btnAgregar_temporal)
            Dim x As New Libro(reader.GetString(0), False)
            panelLibros.Controls.Add(x)
        End While

        Dim visibles As Integer
        For Each l As Libro In panelLibros.Controls
            Try
                l.actualizarDatos()
                visibles += 1
                If chkSoloDisponibles.Checked Then
                    If Not l.estaDisponible Then
                        l.Visible = False
                        visibles -= 1
                    End If
                End If
            Catch ex As Exception
            End Try
        Next

        If visibles <= 0 Then
            panelLibros.Controls.Clear()
            lblNoDisponibles.Text = "No hay libros disponibles"
            panelLibros.Controls.Add(lblNoDisponibles)
            If interfazFuncionario Then
                panelLibros.Controls.Add(btnAgregar_temporal)
            End If
        End If

        reader.Close()
        conexion.Conn.Close()
    End Sub

    Private Sub CheckPrestamo()
        Dim conexion As DB = New DB()
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("select * from prestamo where `CI_Usuario`='{0}';", CI), conexion.Conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            panelInfo.Visible = True
            lblEntregarLibro.Visible = True
            lblEntregarLibro.Text = "Entregue su libro antes del" & ControlChars.NewLine & DateTime.Parse(reader.GetString(4)).ToShortDateString()
        End While
        reader.Close()
        conexion.Conn.Close()
    End Sub

    Private Sub btnPrestamos_Click(sender As Object, e As EventArgs) Handles btnPrestamos.Click
        If interfazFuncionario Then
            Dim frm As New frmPrestamos()
            frm.ShowDialog(Me)
        Else

            Dim conexion As DB = New DB()
            Dim cmd As MySqlCommand = New MySqlCommand(String.Format("select * from prestamo where `CI_Usuario`='{0}';", CI), conexion.Conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim frm As New frmPrestamo(reader("ID"))
                frm.ShowDialog(Me)
                Return
            End While

            reader.Close()
            conexion.Conn.Close()

            MsgBox("Aún no has rentado ningún libro")
        End If
    End Sub


    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        buscando = True
        If (String.IsNullOrWhiteSpace(txtBusqueda.Text) And Not chkGenero.Checked) Then
            buscando = False
        End If

        cargarLibros()
    End Sub

    Private Sub cboxGenero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxGenero.SelectedIndexChanged
        buscando = True 'Define buscando como true
        cargarLibros() 'Ejecuta el método cargarLibros ()
    End Sub

    Private Sub cboxDisponibles_CheckedChanged(sender As Object, e As EventArgs) Handles cboxDisponibles.CheckedChanged
        cargarLibros()
    End Sub

    Private Sub paramsBusqueda(sender As Object, e As EventArgs) Handles radioNombre.CheckedChanged, radioID.CheckedChanged, radioAutor.CheckedChanged, chkGenero.CheckedChanged, chkSoloDisponibles.CheckedChanged
        cboxGenero.Enabled = chkGenero.Checked
        cargarLibros()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Atenea.agregarLogin()
    End Sub

    Private Sub btnAgregarLibro_Click(sender As Object, e As EventArgs) Handles btnAgregarLibro.Click, btnAgregar_temporal.Click
        Dim frm As New frmAgregarLibro()
        frm.ShowDialog(Me)
    End Sub
End Class
