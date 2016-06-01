Imports MySql.Data.MySqlClient
Public Class frmMain

    Dim pedirNick As Boolean
    Dim interfazFuncionario As Boolean
    Dim CI As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarLibros()

        Me.Cursor = System.Windows.Forms.Cursors.Arrow

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

        panelLibros.Controls.Clear()
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

    Private Sub x(sender As Object, e As EventArgs) Handles radioGenero.CheckedChanged
        txtBusqueda.Text = "..."
        txtBusqueda.Enabled = Not radioGenero.Checked
        comboGenero.Enabled = radioGenero.Checked
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
End Class
