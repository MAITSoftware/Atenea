Imports MySql.Data.MySqlClient
Public Class frmPrestamo

    Dim llaveLibro As String
    Private Sub frmPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim libro As Libro
        libro = New Libro(llaveLibro, False, True)
        libro.Location = New Point(12, 40)
        libro.Parent = Me
        libro.actualizarDatos()
        lblAutor.Text = "Autor: " & libro.Autor
        lblCondicion.Text = "Condición: " & libro.Condicion
        lblGenero.Text = "Género: " & libro.Genero
        lblID.Text = "ID: " & libro.ID

        Try
            Atenea.reader.Close()
        Catch ex As Exception
        End Try
        Using cmd As New MySqlCommand()
            With cmd
                .Connection = Atenea.conexion
                .CommandText = "select `Fecha entrega` from prestamo where ID=@id;"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@id", llaveLibro)
            End With
            Atenea.reader = cmd.ExecuteReader()
            While Atenea.reader.Read()
                lblDevolver.Text += " " & DateTime.Parse(Atenea.reader.GetString(0)).ToShortDateString()
            End While
            Atenea.reader.Close()
        End Using

    End Sub

    Public Sub New(ByVal llave As String)
        InitializeComponent()
        llaveLibro = llave
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub
End Class