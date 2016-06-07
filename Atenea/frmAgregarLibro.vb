Imports MySql.Data.MySqlClient
Public Class frmAgregarLibro

    Dim previewLibro As Libro
    Dim interfazEdicion As Boolean = False
    Dim keyEditar As String

    Public Sub New(Optional ByVal editar As Boolean = False, Optional ByVal key As String = Nothing)
        InitializeComponent()
        interfazEdicion = editar
        keyEditar = key
    End Sub

    Private Sub frmAgregarLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If interfazEdicion Then
            Me.Text = "Editar libro · Atenea"
            previewLibro = New Libro(keyEditar, True, True)
            previewLibro.actualizarDatos()
            txtNombre.Text = previewLibro.Titulo
            txtAutor.Text = previewLibro.Autor
            txtID.Text = previewLibro.ID
            txtID.Enabled = False
            cboxGenero.Text = previewLibro.Genero
            cboxEstado.Text = previewLibro.Condicion
        Else
            previewLibro = New Libro(Nothing, True)
        End If

        previewLibro.Location = New Point(35, 60)
        Me.Controls.Add(previewLibro)
        cboxEstado.SelectedIndex = 0
        cboxGenero.SelectedIndex = 0
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim sentencia As String
        sentencia = "INSERT INTO `libro` VALUES (@titulo, @autor, @portada, @genero, @condicion, @id);"
        If interfazEdicion Then
            sentencia = "UPDATE `libro` SET Titulo=@titulo, Autor=@autor, Portada=@portada, Genero=@genero, Condicion=@condicion WHERE ID=@id;"
        End If

        Dim mstream As New System.IO.MemoryStream()
        previewLibro.imgPortada.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
        Dim arrImage() As Byte = mstream.GetBuffer()
        mstream.Close()

        Dim conexion As DB = New DB()

        Using cmd As New MySqlCommand()
            With cmd
                .Connection = conexion.Conn
                .CommandText = sentencia
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@titulo", txtNombre.Text)
                .Parameters.AddWithValue("@autor", txtAutor.Text)
                .Parameters.AddWithValue("@portada", arrImage)
                .Parameters.AddWithValue("@genero", cboxGenero.Text)
                .Parameters.AddWithValue("@condicion", cboxEstado.Text)
                .Parameters.AddWithValue("@id", txtID.Text)
            End With
            Try
                cmd.ExecuteNonQuery()
                Atenea.atenea.cargarLibros()
                Me.Dispose()
            Catch ex As Exception
                If ex.ToString().Contains("max_allowed_packet") Then
                    MsgBox("Imagen muy pesada.", MsgBoxStyle.Exclamation)
                ElseIf ex.ToString().Contains("Duplicate") Then
                    lblInfo.Visible = True
                End If
            End Try
        End Using
    End Sub

    Private Sub btnCambiarPortada_Click(sender As Object, e As EventArgs) Handles btnCambiarPortada.Click
        previewLibro.imgNoDisponible_Click(previewLibro.imgNoDisponible, Nothing)
    End Sub

    Private Sub checkEscrito(sender As Object, e As EventArgs) Handles txtID.TextChanged, txtAutor.TextChanged, txtNombre.TextChanged
        btnAgregar.Enabled = Not (String.IsNullOrWhiteSpace(txtNombre.Text) Or String.IsNullOrWhiteSpace(txtAutor.Text) Or String.IsNullOrWhiteSpace(txtID.Text))
        lblInfo.Visible = False
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            previewLibro.lblTitulo.Text = "Preview"
        Else
            previewLibro.lblTitulo.Text = txtNombre.Text
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Atenea.atenea.cargarLibros()
        Me.Dispose()
    End Sub


    Private Sub EnterClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyDown, txtNombre.KeyDown, txtAutor.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            btnAgregar.PerformClick()
        End If
    End Sub
End Class