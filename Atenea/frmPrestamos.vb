Public Class frmPrestamos

    Private Sub frmPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        planilla.View = View.Details

        planilla.Columns.Add("Usuario", 70)
        planilla.Columns.Add("Funcionario", 90)
        planilla.Columns.Add("Nombre del libro", 120)
        planilla.Columns.Add("ID del libro", 80)
        planilla.Columns.Add("Fecha de préstamo", 130)
        planilla.Columns.Add("Fecha de entrega", 130)

        For value As Integer = 0 To 50
            Dim miItem As New ListViewItem
            miItem = planilla.Items.Add("Ignacio", 0)
            miItem.SubItems.Add("Agustina")
            miItem.SubItems.Add("Peppa pig")
            miItem.SubItems.Add("peppa")
            miItem.SubItems.Add("25/5/2016")
            miItem.SubItems.Add("31/5/2016")
            If value Mod 4 = 0 Then
                miItem.BackColor = Color.DarkRed
            Else
                miItem.ForeColor = Color.White
                miItem.BackColor = ColorTranslator.FromHtml("#232323")
            End If
        Next

    End Sub
End Class