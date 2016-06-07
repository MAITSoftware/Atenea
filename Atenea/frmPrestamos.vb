Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Public Class frmPrestamos

    Dim sentencia As String
    Dim libro As Libro

    Friend ID As String
    Dim archivoImprimir As StreamReader
    Dim fuente As Font = New System.Drawing.Font("Arial", 10)

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
        Dim conexion As New DB()
        Dim cmd As MySqlCommand = New MySqlCommand(sentencia, conexion.Conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim miItem As New ListViewItem
            Dim fechaPrestamo, fechaEntrega
            miItem = planilla.Items.Add(reader("CI_Usuario"), 0)
            miItem.SubItems.Add(reader("CI_Funcionario"))
            miItem.SubItems.Add(reader("Titulo"))
            miItem.SubItems.Add(reader("ID"))
            fechaPrestamo = reader("Fecha prestamo")
            fechaEntrega = reader("Fecha entrega")
            miItem.SubItems.Add(fechaPrestamo)
            miItem.SubItems.Add(fechaEntrega)
            Dim faltanDias As Integer = DateDiff(DateInterval.Day, fechaPrestamo, fechaEntrega)
            If faltanDias <= 5 Then
                miItem.BackColor = Color.OrangeRed
            End If
            btnImprimir.Enabled = True
        End While
        reader.Close()
        conexion.Conn.Close()
    End Sub
    Private Sub planilla_SelectedIndexChanged(sender As Object, e As EventArgs) Handles planilla.SelectedIndexChanged
        Try
            ID = planilla.SelectedItems.Item(0).SubItems(3).Text
            btnLibroDevuelto.Enabled = True
            btnCambiarFecha.Enabled = True
        Catch ex As Exception
            ID = Nothing
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
        btnLibroDevuelto.Enabled = False
        btnCambiarFecha.Enabled = False
        updateLibro()
        actualizarDatos()
    End Sub

    Private Sub btnCambiarFecha_Click(sender As Object, e As EventArgs) Handles btnCambiarFecha.Click
        Dim frmEditar As frmConfPrestamo
        frmEditar = New frmConfPrestamo(ID, True, planilla.SelectedItems.Item(0).SubItems(0).Text, planilla.SelectedItems.Item(0).SubItems(5).Text, planilla.SelectedItems.Item(0).SubItems(4).Text)
        frmEditar.ShowDialog(Me)
        btnLibroDevuelto.Enabled = False
        btnCambiarFecha.Enabled = False
        ID = Nothing
        updateLibro()
        actualizarDatos()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim archivo As String = "Préstamos" & vbCrLf &
"----------------------------------------------------------------------------------------------------------------------------------" & vbCrLf

        sentencia = "SELECT prestamo.*, libro.Titulo FROM prestamo, libro where libro.ID=prestamo.ID;"
        Dim conexion As New DB()
        Dim cmd As MySqlCommand = New MySqlCommand(sentencia, conexion.Conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            archivo += "Préstamo de libro: " & reader("Titulo") & vbCrLf &
                       "Usuario (CI): " & reader("CI_Usuario") & vbCrLf &
                       "Funcionario (CI): " & reader("CI_Funcionario") & vbCrLf &
                       "ID: " & reader("ID") & vbCrLf &
                       "Fecha préstamo: " & reader("Fecha prestamo") & vbCrLf &
                       "Fecha entrega: " & reader("Fecha entrega") & vbCrLf &
                       "----------------------------------------------------------------------------------------------------------------------------------" & vbCrLf
        End While
        reader.Close()
        conexion.Conn.Close()

        Dim path As String = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt"
        Using sw As StreamWriter = File.CreateText(path)
            sw.WriteLine(archivo)
            sw.Close()
        End Using

        archivoImprimir = New System.IO.StreamReader(path)
        Try
            impresora.Print()
            archivoImprimir.Close()
        Catch ex As Exception
            MsgBox("Error al imprimir")
        End Try

    End Sub

    Private Sub impresora_PrintPage(sender As Object, e As  _
       System.Drawing.Printing.PrintPageEventArgs) Handles _
       impresora.PrintPage

        Dim linesPerPage As Single = 0
        Dim yPos As Single = 0
        Dim count As Integer = 0
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim line As String = Nothing
        linesPerPage = e.MarginBounds.Height / fuente.GetHeight(e.Graphics)
        While count < linesPerPage
            line = archivoImprimir.ReadLine()
            If line Is Nothing Then
                Exit While
            End If
            yPos = topMargin + count * fuente.GetHeight(e.Graphics)
            e.Graphics.DrawString(line, fuente, Brushes.Black, leftMargin, _
               yPos, New StringFormat())
            count += 1
        End While
        If Not (line Is Nothing) Then
            e.HasMorePages = True
        End If
    End Sub

End Class