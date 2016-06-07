Imports MySql.Data.MySqlClient
Public Class frmPrestamo
    Dim llaveLibro As String

    Public Sub New(ByVal llave As String)
        InitializeComponent()
        llaveLibro = llave
    End Sub

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
            Atenea.DB.Reader.Close()
        Catch ex As Exception
        End Try
        Using cmd As New MySqlCommand()
            With cmd
                .Connection = Atenea.DB.Conn
                .CommandText = "select `Fecha entrega` from prestamo where ID=@id;"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@id", llaveLibro)
            End With
            Atenea.DB.Reader = cmd.ExecuteReader()
            While Atenea.DB.Reader.Read()
                lblDevolver.Text += " " & DateTime.Parse(Atenea.DB.Reader.GetString(0)).ToShortDateString()
            End While
            Atenea.DB.Reader.Close()
        End Using
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub
End Class