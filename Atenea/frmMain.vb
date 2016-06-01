Public Class frmMain

    Dim pedirNick As Boolean
    Dim interfazFuncionario As Boolean
    Dim CI As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelLibros.Controls.Remove(lblNoDisponibles)
        panelLibros.Controls.Remove(btnAgregar_temporal)
        Dim x As New Libro("book123", False)
        panelLibros.Controls.Add(x)

        Me.Cursor = System.Windows.Forms.Cursors.Arrow

        If pedirNick Then
            Dim ventanaNick As frmNickUsuario = New frmNickUsuario(CI)
            ventanaNick.ShowDialog(Me)
        End If

    End Sub

    Private Sub x(sender As Object, e As EventArgs) Handles radioGenero.CheckedChanged
        txtBusqueda.Text = "..."
        txtBusqueda.Enabled = Not radioGenero.Checked
        comboGenero.Enabled = radioGenero.Checked
    End Sub

    Private Sub btnAgregar_temporal_Click(sender As Object, e As EventArgs) Handles btnAgregar_temporal.Click
        btnAgregarLibro.PerformClick()
        Dim frm As New frmAgregarLibro()
        frm.ShowDialog(Me)

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
