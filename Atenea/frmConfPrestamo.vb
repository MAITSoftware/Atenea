Imports MySql.Data.MySqlClient
Public Class frmConfPrestamo
    Dim llaveLibro As String
    Dim ciUsuario As String
    Private Sub frmConfPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim libro As Libro
        libro = New Libro(llaveLibro, False, True)
        libro.Location = New Point(58, 50)
        libro.Parent = Panel1
        libro.actualizarDatos()
        lblAutor.Text = "Autor: " + libro.Autor
        lblGenero.Text = "Genero: " + libro.Genero
        lblID.Text = "ID: " + libro.ID
        lblCondicion.Text = "Condición: " + libro.Condicion

        calendario.MinDate = System.DateTime.Now().AddDays(1)
        calendario.MaxDate = System.DateTime.Now().AddDays(14)
        calendario.BoldedDates = New System.DateTime() {System.DateTime.Now(), calendario.MaxDate}
        calendario.SetDate(calendario.MaxDate)

        Try
            Atenea.reader.Close()
        Catch ex As Exception
        End Try

        Dim cmd As MySqlCommand = New MySqlCommand("select * from usuario where tipo='usuario';", Atenea.conexion)
        Atenea.reader = cmd.ExecuteReader()

        While Atenea.reader.Read()
            Dim Nombre, ID
            ID = Atenea.reader("CI")
            Nombre = Atenea.reader("Nombre")
            comboUsuario.Items.Add(String.Format("{0} -- {1}", ID, Nombre))
        End While
        Atenea.reader.Close()

    End Sub

    Public Sub New(ByVal llave As String)
        InitializeComponent()
        llaveLibro = llave
    End Sub

    Private Sub comboUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboUsuario.SelectedIndexChanged
        Try
            Atenea.reader.Close()
        Catch ex As Exception
        End Try

        Dim user As String = comboUsuario.SelectedItem.ToString()
        ciUsuario = user.Substring(0, user.IndexOf(" -- "))
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("select * from prestamo where `CI usuario`='{0}';", ciUsuario), Atenea.conexion)
        Atenea.reader = cmd.ExecuteReader()
        lblInfo.Visible = False
        btnPrestar.Enabled = True
        While Atenea.reader.Read()
            lblInfo.Visible = True
            btnPrestar.Enabled = False
        End While
        Atenea.reader.Close()

    End Sub

    Private Sub calendario_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendario.DateChanged
        calendario.BoldedDates = New System.DateTime() {System.DateTime.Now(), calendario.SelectionRange.Start}
        lblFecha.Text = FormatDateTime(calendario.SelectionRange.Start, DateFormat.ShortDate)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnPrestar_Click(sender As Object, e As EventArgs) Handles btnPrestar.Click
        Try
            Atenea.reader.Close()
        Catch ex As Exception
        End Try

        Dim sentencia As String = "INSERT INTO `prestamo` VALUES (@id, @ciUsuario, @ciFuncionario, @fechaPrestamo, @fechaEntrega);"
        Dim cmd As New MySqlCommand(sentencia, Atenea.conexion)
        Dim hoy As DateTime = Now

        cmd.Parameters.AddWithValue("@id", llaveLibro)
        cmd.Parameters.AddWithValue("@ciUsuario", ciUsuario)
        cmd.Parameters.AddWithValue("@ciFuncionario", Atenea.atenea.CI)
        cmd.Parameters.AddWithValue("@fechaPrestamo", hoy.ToString("yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@fechaEntrega", calendario.SelectionRange.Start.ToString("yyyy-MM-dd"))

        Try
            cmd.ExecuteNonQuery()
            Atenea.reader.Close()
            Atenea.atenea.cargarLibros()
            Me.Dispose()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Atenea.reader.Close()
        End Try

    End Sub
End Class