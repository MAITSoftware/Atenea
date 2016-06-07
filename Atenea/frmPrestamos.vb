Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Public Class frmPrestamos

    Dim sentencia As String
    Dim libro As Libro

    Friend ID As String = Nothing
    Dim archivo As String

    Private Sub frmPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Al cargar frmPrestamos
        planilla.View = View.Details 'Muestra planilla en vista detallada

        actualizarDatos()

        libro = New Libro(Nothing, False, True)
        libro.Parent = Me
        libro.Location = New Point(56, 56)

    End Sub
    Public Sub actualizarDatos()
        planilla.Items.Clear()
        btnImprimir.Enabled = False

        sentencia = "SELECT prestamo.*, libro.Titulo FROM prestamo, libro where libro.ID=prestamo.ID;"
        Dim cmd As MySqlCommand = New MySqlCommand(sentencia, Atenea.conexion)
        Atenea.reader = cmd.ExecuteReader()

        While Atenea.reader.Read()
            Dim miItem As New ListViewItem
            Dim fechaPrestamo, fechaEntrega
            miItem = planilla.Items.Add(Atenea.reader("CI_Usuario"), 0)
            miItem.SubItems.Add(Atenea.reader("CI_Funcionario"))
            miItem.SubItems.Add(Atenea.reader("Titulo"))
            miItem.SubItems.Add(Atenea.reader("ID"))
            fechaPrestamo = Atenea.reader("Fecha prestamo")
            fechaEntrega = Atenea.reader("Fecha entrega")
            miItem.SubItems.Add(fechaPrestamo)
            miItem.SubItems.Add(fechaEntrega)
            Dim faltanDias As Integer = DateDiff(DateInterval.Day, fechaPrestamo, fechaEntrega)
            If faltanDias <= 5 Then
                miItem.BackColor = Color.OrangeRed
            End If
            btnImprimir.Enabled = True
        End While
        Atenea.reader.Close()
    End Sub
    Private Sub planilla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles planilla.SelectedIndexChanged
        Try
            ID = planilla.SelectedItems.Item(0).SubItems(3).Text
            btnLibroDevuelto.Enabled = True
            btnCambiarFecha.Enabled = True
        Catch ex As Exception
            btnLibroDevuelto.Enabled = False
            btnCambiarFecha.Enabled = False
        End Try

        updateLibro()
    End Sub

    Public Sub updateLibro()
        libro.Dispose()
        Me.Controls.Remove(libro)
        libro = New Libro(ID, False, True)
        libro.Parent = Me
        libro.Location = New Point(56, 56)
        libro.actualizarDatos()

        Me.Controls.Add(libro)
    End Sub


    Private Sub btnLibroDevuelto_Click(sender As Object, e As EventArgs) Handles btnLibroDevuelto.Click
        Dim frmDevolver As frmAccionLibro
        frmDevolver = New frmAccionLibro(ID, True, planilla.SelectedItems.Item(0).SubItems(0).Text)
        frmDevolver.ShowDialog(Me)
        ID = Nothing
        updateLibro()
        actualizarDatos()
    End Sub

    Private Sub btnCambiarFecha_Click(sender As Object, e As EventArgs) Handles btnCambiarFecha.Click
        Dim frmEditar As frmConfPrestamo
        frmEditar = New frmConfPrestamo(ID, True, planilla.SelectedItems.Item(0).SubItems(0).Text, planilla.SelectedItems.Item(0).SubItems(5).Text, planilla.SelectedItems.Item(0).SubItems(4).Text)
        frmEditar.ShowDialog(Me)
        btnLibroDevuelto.Enabled = False
        btnCambiarFecha.Enabled = False
        updateLibro()
        actualizarDatos()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        archivo = "CI Usuario | CI Funcionario | Nombre del libro | ID del libro | Fecha de préstamo | Fecha de entrega" & vbCrLf

        sentencia = "SELECT prestamo.*, libro.Titulo FROM prestamo, libro where libro.ID=prestamo.ID;"
        Dim cmd As MySqlCommand = New MySqlCommand(sentencia, Atenea.conexion)
        Atenea.reader = cmd.ExecuteReader()

        While Atenea.reader.Read()
            archivo += Atenea.reader("CI_Usuario") & " | " & Atenea.reader("CI_Funcionario") & " | " & Atenea.reader("Titulo") & " | " & Atenea.reader("ID") & " | " & Atenea.reader("Fecha prestamo") & " | " & Atenea.reader("Fecha entrega") & vbCrLf
        End While
        Atenea.reader.Close()

        Dim path As String = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt"
        Using sw As StreamWriter = File.CreateText(path)
            sw.WriteLine(archivo)
            sw.Close()
        End Using

        PrintDocument1.DocumentName = "Prestamos"
        Dim stream As New FileStream(path, FileMode.Open)
        Try
            Dim reader As New StreamReader(stream)
            Try
                archivo = reader.ReadToEnd()
            Finally
                reader.Dispose()
            End Try
        Finally
            stream.Dispose()
        End Try

        Try
            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox("Error al imprimir.")
        End Try

    End Sub

    Private Sub printDocument1_PrintPage(ByVal sender As Object, _
        ByVal e As PrintPageEventArgs)

        Dim charactersOnPage As Integer = 0
        Dim linesPerPage As Integer = 0

        e.Graphics.MeasureString(archivo, Me.Font, e.MarginBounds.Size, _
            StringFormat.GenericTypographic, charactersOnPage, linesPerPage)

        e.Graphics.DrawString(archivo, Me.Font, Brushes.Black, _
            e.MarginBounds, StringFormat.GenericTypographic)

        archivo = archivo.Substring(charactersOnPage)

        e.HasMorePages = archivo.Length > 0

    End Sub

End Class