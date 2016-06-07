Imports MySql.Data.MySqlClient
Public Class frmConfPrestamo
    Dim llaveLibro As String
    Dim ciUsuario As String
    Dim editar As Boolean
    Dim ciUser_Edit As String
    Dim fechaActual As String
    Dim fechaPrestamo As String

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


        If editar Then
            calendario.MinDate = Convert.ToDateTime(fechaPrestamo)
            calendario.MaxDate = calendario.MinDate.AddDays(14)
            calendario.BoldedDates = New System.DateTime() {System.DateTime.Now(), DateTime.Parse(Convert.ToDateTime(fechaActual).ToString("yyyy-MM-dd"))}
            calendario.SetDate(Convert.ToDateTime(fechaActual))
        Else
            calendario.MinDate = System.DateTime.Now().AddDays(1)
            calendario.MaxDate = System.DateTime.Now().AddDays(14)
            calendario.BoldedDates = New System.DateTime() {System.DateTime.Now(), calendario.MaxDate}
            calendario.SetDate(calendario.MaxDate)
        End If

        If editar Then
            Me.Text = "Actualizar datos de préstamo · Atenea"
            comboUsuario.Enabled = False
            btnPrestar.Enabled = True
            btnPrestar.Text = "Cambiar"
        End If

        Try
            Atenea.DB.Reader.Close()
        Catch ex As Exception

        End Try

        Using cmd As New MySqlCommand()
            With cmd
                .Connection = Atenea.DB.Conn
                .CommandText = "select * from usuario where tipo='usuario' order by CI;"
                .CommandType = CommandType.Text
            End With
            Atenea.DB.Reader = cmd.ExecuteReader()

            While Atenea.DB.Reader.Read()
                Dim Nombre, ID
                ID = Atenea.DB.Reader("CI")
                Nombre = Atenea.DB.Reader("Nombre")
                If editar Then
                    Console.WriteLine(ID)
                    Console.WriteLine(ciUser_Edit)
                    Console.WriteLine("-------")
                    If Not Convert.ToInt32(ciUser_Edit).Equals(ID) Then
                        Continue While
                    End If
                End If

                comboUsuario.Items.Add(String.Format("{0} -- {1}", ID, Nombre))
                If editar Then
                    comboUsuario.Text = String.Format("{0} -- {1}", ID, Nombre)
                End If
            End While

            Atenea.DB.Reader.Close()

        End Using

    End Sub

    Public Sub New(ByVal llave As String, Optional ByVal editando As Boolean = False, Optional ByVal usuario As String = Nothing, Optional ByVal fechalibro As String = Nothing, Optional ByVal fechalibro2 As String = Nothing)
        InitializeComponent()
        llaveLibro = llave
        editar = editando
        ciUser_Edit = usuario
        fechaActual = fechalibro
        fechaPrestamo = fechalibro2
    End Sub

    Private Sub comboUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboUsuario.SelectedIndexChanged
        If editar Then
            Return
        End If
        Try
            Atenea.DB.Reader.Close()
        Catch ex As Exception
        End Try
        Dim user As String = comboUsuario.SelectedItem.ToString()
        ciUsuario = user.Substring(0, user.IndexOf(" -- "))
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("select * from prestamo where `CI_Usuario`='{0}';", ciUsuario), Atenea.DB.Conn)
        Atenea.DB.Reader = cmd.ExecuteReader()
        lblInfo.Visible = False
        btnPrestar.Enabled = True
        While Atenea.DB.Reader.Read()
            lblInfo.Visible = True
            btnPrestar.Enabled = False
        End While

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
            Atenea.DB.Reader.Close()
        Catch ex As Exception
        End Try

        Dim sentencia As String = "INSERT INTO `prestamo` VALUES (@id, @ciUsuario, @ciFuncionario, @fechaPrestamo, @fechaEntrega);"
        If editar Then
            sentencia = "UPDATE `prestamo` SET `Fecha entrega`=@fechaEntrega WHERE `ID`=@id;"
        End If
        Dim cmd As New MySqlCommand(sentencia, Atenea.DB.Conn)
        Dim hoy As DateTime = Now
        If editar Then
            cmd.Parameters.AddWithValue("@id", llaveLibro)
            cmd.Parameters.AddWithValue("@fechaEntrega", calendario.SelectionRange.Start.ToString("yyyy-MM-dd"))
        Else
            cmd.Parameters.AddWithValue("@id", llaveLibro)
            cmd.Parameters.AddWithValue("@ciUsuario", ciUsuario)
            cmd.Parameters.AddWithValue("@ciFuncionario", Atenea.atenea.CI)
            cmd.Parameters.AddWithValue("@fechaPrestamo", hoy.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@fechaEntrega", calendario.SelectionRange.Start.ToString("yyyy-MM-dd"))
        End If

        Try
            cmd.ExecuteNonQuery()
            Atenea.atenea.cargarLibros()
            Atenea.DB.Reader.Close()
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
            Atenea.DB.Reader.Close()
        End Try


        Me.Dispose()

    End Sub

  
End Class