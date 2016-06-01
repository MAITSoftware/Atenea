Imports MySql.Data.MySqlClient
Public Class frmAgregarLibro

    Dim previewLibro As New Libro("Preview", True)
    Private Sub frmAgregarLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        previewLibro.Location = New Point(35, 60)
        Me.Controls.Add(previewLibro)
        ComboBox1.SelectedIndex = 0
        cboxGenero.SelectedIndex = 0
    End Sub

    Private Sub btnCambiarPortada_Click(sender As Object, e As EventArgs) Handles btnCambiarPortada.Click
        previewLibro.imgNoDisponible_Click(previewLibro.imgNoDisponible, Nothing)
    End Sub

    Private Sub checkEscrito(sender As Object, e As EventArgs) Handles txtID.TextChanged, txtAutor.TextChanged, txtNombre.TextChanged
        btnAgregar.Enabled = Not (String.IsNullOrWhiteSpace(txtNombre.Text) Or String.IsNullOrWhiteSpace(txtAutor.Text) Or String.IsNullOrWhiteSpace(txtID.Text))
        lblInfo.Visible = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim sentencia As String
        sentencia = "INSERT INTO `libro` VALUES (@titulo, @autor, @portada, @genero, @estado, @id);"
        Dim cmd As New MySqlCommand(sentencia, Atenea.conexion)
        cmd.Parameters.AddWithValue("@titulo", txtNombre.Text)
        cmd.Parameters.AddWithValue("@autor", txtAutor.Text)
        cmd.Parameters.AddWithValue("@genero", cboxGenero.Text)
        cmd.Parameters.AddWithValue("@estado", ComboBox1.Text)

        Dim mstream As New System.IO.MemoryStream()
        previewLibro.imgPortada.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        mstream.Close()

        cmd.Parameters.AddWithValue("@portada", arrImage)
        cmd.Parameters.AddWithValue("@id", txtID.Text)
        Try
            cmd.ExecuteNonQuery()
            Me.Dispose()
        Catch ex As Exception
            lblInfo.Visible = True
        End Try
    End Sub
End Class