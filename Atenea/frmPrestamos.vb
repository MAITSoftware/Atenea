Public Class frmPrestamos

    Private Sub frmPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Al cargar frmPrestamos
        planilla.View = View.Details 'Muestra planilla en vista detallada

        planilla.Columns.Add("Usuario", 70) 'Agrega columna "Usuario" a planilla
        planilla.Columns.Add("Funcionario", 90) 'Agrega columna "Funcionario" a planilla
        planilla.Columns.Add("Nombre del libro", 120) 'Agrega columna "Nombre del libro" a planilla
        planilla.Columns.Add("ID del libro", 80) 'Agrega columna "ID del libro" a planilla
        planilla.Columns.Add("Fecha de préstamo", 130) 'Agrega columna "Fecha de préstamo" a planilla
        planilla.Columns.Add("Fecha de entrega", 130) 'Agrega columna "Fecha de entrega" a planilla

        For value As Integer = 0 To 50
            Dim miItem As New ListViewItem 'Define miItem como ListViewItem
            miItem = planilla.Items.Add("Ignacio", 0)
            miItem.SubItems.Add("Agustina")
            miItem.SubItems.Add("Peppa pig")
            miItem.SubItems.Add("peppa")
            miItem.SubItems.Add("25/5/2016")
            miItem.SubItems.Add("31/5/2016")
            If value Mod 4 = 0 Then
                miItem.BackColor = Color.DarkRed 'Muestra la fila con fondo rojo oscuro
            Else
                miItem.ForeColor = Color.White
                miItem.BackColor = ColorTranslator.FromHtml("#232323")
            End If
        Next

    End Sub

    Private Sub btnLibroDevuelto_Click(sender As Object, e As EventArgs) Handles btnLibroDevuelto.Click
        Dim frm As New frmConfPrestamo("peppa")
        frm.ShowDialog(Me)
    End Sub


    Private Sub planilla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles planilla.SelectedIndexChanged

    End Sub
End Class