Imports MySql.Data.MySqlClient
Public Class frmMain

    Dim pedirNick As Boolean
    Dim interfazFuncionario As Boolean
    Dim CI As String
    Dim buscando As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLibros()

        Me.Cursor = System.Windows.Forms.Cursors.Arrow

        cboxGenero.SelectedIndex = 0

        If pedirNick Then
            Dim ventanaNick As frmNickUsuario = New frmNickUsuario(CI)
            ventanaNick.ShowDialog(Me)
        End If

        If Not interfazFuncionario Then
            btnAgregarLibro.Visible = False
            btnAgregar_temporal.Visible = False
        End If

    End Sub

    Public Sub cargarLibros()
        Dim sentencia As String = "SELECT `ID` FROM `libro`;"
        If buscando Then
            If radioNombre.Checked Then
                sentencia = String.Format("SELECT `ID` FROM `libro` WHERE Titulo LIKE '{0}%'", txtBusqueda.Text)
            ElseIf radioAutor.Checked Then
                sentencia = String.Format("SELECT `ID` FROM `libro` WHERE Autor LIKE '{0}%'", txtBusqueda.Text)
            ElseIf radioID.Checked Then
                sentencia = String.Format("SELECT `ID` FROM `libro` WHERE ID LIKE '{0}%'", txtBusqueda.Text)
            End If

            If chkGenero.Checked Then
                sentencia += String.Format(" AND Genero='{0}';", cboxGenero.Text)
            Else
                sentencia += ";"
            End If

        End If
        panelLibros.Controls.Clear()
        lblNoDisponibles.Text = "No hay libros disponibles"
        panelLibros.Controls.Add(lblNoDisponibles)
        panelLibros.Controls.Add(btnAgregar_temporal)

        Try
            Atenea.reader.Close()
        Catch ex As Exception
        End Try

        Dim cmd As MySqlCommand = New MySqlCommand(sentencia, Atenea.conexion)
        Atenea.reader = cmd.ExecuteReader()

        While Atenea.reader.Read()
            panelLibros.Controls.Remove(lblNoDisponibles)
            panelLibros.Controls.Remove(btnAgregar_temporal)
            Dim x As New Libro(Atenea.reader.GetString(0), False)
            panelLibros.Controls.Add(x)
        End While

        For Each Libro In panelLibros.Controls
            Try
                Libro.actualizarDatos()
            Catch ex As Exception
            End Try
        Next

        Atenea.reader.Close()

    End Sub

    Private Sub x(sender As Object, e As EventArgs) Handles chkGenero.CheckedChanged
        cboxGenero.Enabled = chkGenero.Checked
        cargarLibros()
    End Sub

    Private Sub y(sender As Object, e As EventArgs) Handles radioNombre.CheckedChanged, radioID.CheckedChanged, radioAutor.CheckedChanged
        cargarLibros()
    End Sub

    Private Sub btnAgregar_temporal_Click(sender As Object, e As EventArgs) Handles btnAgregar_temporal.Click
        btnAgregarLibro.PerformClick()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Atenea.agregarLogin()
    End Sub

    Private Sub btnAgregarLibro_Click(sender As Object, e As EventArgs) Handles btnAgregarLibro.Click
        Dim frm As New frmAgregarLibro()
        frm.ShowDialog(Me)
    End Sub

    Private Sub btnPrestamos_Click(sender As Object, e As EventArgs) Handles btnPrestamos.Click
        Dim frm As New frmPrestamos()
        frm.ShowDialog(Me)
    End Sub

    Public Sub New(ByVal ci_ As String, Optional ByVal primeraVez As Boolean = False, Optional ByVal funcionario As Boolean = False)
        InitializeComponent()
        pedirNick = primeraVez
        interfazFuncionario = funcionario
        CI = ci_
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        buscando = True
        If (String.IsNullOrWhiteSpace(txtBusqueda.Text) And Not chkGenero.Checked) Then
            buscando = False
        End If

        cargarLibros()
    End Sub

    Private Sub cboxGenero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxGenero.SelectedIndexChanged
        buscando = True
        cargarLibros()
    End Sub
End Class
