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
        Me.Cursor = System.Windows.Forms.Cursors.Arrow 
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
    End Sub
 
    Public Sub cargarNick()
        Dim Nombre As String
        Dim Apellido As String = ""
        Try
            Atenea.DB.Reader.Close()
        Catch ex As Exception
        End Try
        Dim cmd As MySqlCommand = New MySqlCommand("select Nombre,Apellido from usuario where CI=@id;", Atenea.DB.Conn) 'Define cmd como MySqlCommand con los parámetros sentencia y Atenea.DB.Conn
        cmd.Parameters.AddWithValue("@id", CI)

        Atenea.DB.Reader = cmd.ExecuteReader()
        Atenea.DB.Reader.Read()
        Nombre = Atenea.DB.Reader("Nombre")
        Try
            Apellido = Atenea.DB.Reader("Apellido")
        Catch ex As Exception
        End Try
        Atenea.DB.Reader.Close()

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

        Try
            Atenea.DB.Reader.Close()
        Catch ex As Exception
        End Try

        Dim cmd As MySqlCommand = New MySqlCommand(sentencia, Atenea.DB.Conn) 'Define cmd como MySqlCommand con los parámetros sentencia y Atenea.DB.Conn
        Atenea.DB.Reader = cmd.ExecuteReader()

        While Atenea.DB.Reader.Read()
            panelLibros.Controls.Remove(lblNoDisponibles)
            panelLibros.Controls.Remove(btnAgregar_temporal)
            Dim x As New Libro(Atenea.DB.Reader.GetString(0), False)
            panelLibros.Controls.Add(x)
        End While

        For Each Libro In panelLibros.Controls
            Try
                Libro.actualizarDatos()
            Catch ex As Exception
            End Try
        Next

        Atenea.DB.Reader.Close()
    End Sub

    Private Sub CheckPrestamo()
        Try
            Atenea.DB.Reader.Close()
        Catch ex As Exception
        End Try
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("select * from prestamo where `CI_Usuario`='{0}';", CI), Atenea.DB.Conn)
        Atenea.DB.Reader = cmd.ExecuteReader()
        While Atenea.DB.Reader.Read()
            panelInfo.Visible = True
            lblEntregarLibro.Visible = True
            lblEntregarLibro.Text = "Entregue su libro antes del" & ControlChars.NewLine & DateTime.Parse(Atenea.DB.Reader.GetString(4)).ToShortDateString()
        End While
        Atenea.DB.Reader.Close()
    End Sub

    Private Sub btnPrestamos_Click(sender As Object, e As EventArgs) Handles btnPrestamos.Click
        If interfazFuncionario Then
            Dim frm As New frmPrestamos()
            frm.ShowDialog(Me)
        Else
            Try
                Atenea.DB.Reader.Close()
            Catch ex As Exception
            End Try

            Dim cmd As MySqlCommand = New MySqlCommand(String.Format("select * from prestamo where `CI_Usuario`='{0}';", CI), Atenea.DB.Conn)
            Atenea.DB.Reader = cmd.ExecuteReader()
            While Atenea.DB.Reader.Read()
                Dim frm As New frmPrestamo(Atenea.DB.Reader("ID"))
                frm.ShowDialog(Me)
                Return
            End While

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

    Private Sub paramsBusqueda(sender As Object, e As EventArgs) Handles radioNombre.CheckedChanged, radioID.CheckedChanged, radioAutor.CheckedChanged, chkGenero.CheckedChanged
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
