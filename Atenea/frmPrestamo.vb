Imports MySql.Data.MySqlClient
Public Class frmPrestamo
    ' frmPrestamo: form para Usuario, donde muestra el préstamo activo
    Dim llaveLibro As String

    Public Sub New(ByVal llave As String)
        ' Al crear el form, setear los valores.
        InitializeComponent()
        llaveLibro = llave
    End Sub

    Private Sub frmPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Al cargar la ventana, crear una preview del libro y acomodarlo
        Dim libro As Libro
        libro = New Libro(llaveLibro, True)
        libro.Location = New Point(12, 40)
        libro.Parent = Me
        libro.actualizarDatos() 
        lblAutor.Text = "Autor: " & libro.Autor
        lblCondicion.Text = "Condición: " & libro.Condicion 
        lblGenero.Text = "Género: " & libro.Genero
        lblID.Text = "ID: " & libro.ID 

        Dim conexion As New DB() 

        Using cmd As New MySqlCommand()
            With cmd
                .Connection = conexion.Conn
                .CommandText = "select `Fecha entrega` from prestamo where ID=@id;"
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@id", llaveLibro)
            End With
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                lblDevolver.Text += " " & DateTime.Parse(reader.GetString(0)).ToShortDateString()
            End While

            reader.Close()
            conexion.Close() 'Cierra la conexión con la DB

        End Using
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ' Al clickear aceptar, destruir ventana
        Me.Dispose()
    End Sub
End Class