Public Class frmMain

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rng As New Random()
        For y As Integer = 0 To 5
            panelLibros.Controls.Remove(lblNoDisponibles)
            panelLibros.Controls.Remove(btnAgregar_temporal)
            Dim randomBool As Boolean = rng.Next(0, 2) > 0
            Dim x As New Libro("El que tenías ahí", randomBool)
            panelLibros.Controls.Add(x)
            comboGenero.Items.Add(y)
        Next

        Me.Cursor = System.Windows.Forms.Cursors.Arrow
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

End Class
