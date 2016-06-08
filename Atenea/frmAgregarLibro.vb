Imports MySql.Data.MySqlClient ' Importa el módulo de MySQL
Public Class frmAgregarLibro

    ' frmAgregarLibro sirve para Agregar/Editar libros.
    ' Los datos se cargan y se guardan a la db.

    Dim previewLibro As Libro 
    Dim interfazEdicion As Boolean = False 
    Dim keyEditar As String 

    Public Sub New(Optional ByVal editar As Boolean = False, Optional ByVal key As String = Nothing)
        ' Al generar un nuevo frmAgregarLibro pedir valores opcionales y setear los de
        ' variables locales a los valores especificados en la creación
        InitializeComponent()

        interfazEdicion = editar
        keyEditar = key
    End Sub

    Private Sub frmAgregarLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Al cargar, si se está editando muestra/setea valores adicionales del Libro
        If interfazEdicion Then
            Me.Text = "Editar libro · Atenea"

            previewLibro = New Libro(keyEditar, True, True)
            previewLibro.actualizarDatos()

            txtNombreLibro.Text = previewLibro.Titulo
            txtAutor.Text = previewLibro.Autor
            txtID.Text = previewLibro.ID
            txtID.Enabled = False

            cboxGenero.Text = previewLibro.Genero
            cboxEstado.Text = previewLibro.Condicion
            btnAgregar.Text = "Guardar"
        Else
            previewLibro = New Libro(Nothing, True, True)
        End If

        previewLibro.Location = New Point(35, 60)
        Me.Controls.Add(previewLibro)
        cboxEstado.SelectedIndex = 0
        cboxGenero.SelectedIndex = 0
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        ' Al clickear agregar/editar se actualizan, insertan, los datos del libro en la base de datos.
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
                .Parameters.AddWithValue("@titulo", txtNombreLibro.Text)
                .Parameters.AddWithValue("@autor", txtAutor.Text)
                .Parameters.AddWithValue("@portada", arrImage)
                .Parameters.AddWithValue("@genero", cboxGenero.Text)
                .Parameters.AddWithValue("@condicion", cboxEstado.Text)
                .Parameters.AddWithValue("@id", txtID.Text)
            End With

            Try
                cmd.ExecuteNonQuery()
                Atenea.cargarLibros()
                conexion.Close()
                Me.Dispose()
            Catch ex As Exception
                ' En caso de error, hay 2 opciones cubiertas
                If ex.ToString().Contains("max_allowed_packet") Then ' El archivo de imágen es muy grande
                    MsgBox("Imagen muy pesada.", MsgBoxStyle.Exclamation) ' Muestra un msgbox con el error
                ElseIf ex.ToString().Contains("Duplicate") Then ' Ya hay un libro con ese ID
                    lblInfo.Visible = True ' Muestra el lbl con la info de error
                End If
            End Try
        End Using

    End Sub

    Private Sub btnCambiarPortada_Click(sender As Object, e As EventArgs) Handles btnCambiarPortada.Click
        ' Al clickear el botón de cambiar portada
        previewLibro.imgNoDisponible_Click(previewLibro.imgNoDisponible, Nothing) ' Acciona el evento de click de imgNoDisponible
    End Sub

    Private Sub checkEscrito(sender As Object, e As EventArgs) Handles txtID.TextChanged, txtAutor.TextChanged, txtNombreLibro.TextChanged
        ' Comprueba (cada vez que se escribeen los txt*) que los datos escritos no sean nulos o puros espacios
        btnAgregar.Enabled = Not (String.IsNullOrWhiteSpace(txtNombreLibro.Text) Or String.IsNullOrWhiteSpace(txtAutor.Text) Or String.IsNullOrWhiteSpace(txtID.Text))

        lblInfo.Visible = False 
        If String.IsNullOrWhiteSpace(txtNombreLibro.Text) Then
            previewLibro.lblTitulo.Text = "Preview"
        Else
            previewLibro.lblTitulo.Text = txtNombreLibro.Text
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ' Al presionar Cancelar, destruir ventana
        Me.Dispose()
    End Sub

    Private Sub EnterClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyDown, txtNombreLibro.KeyDown, txtAutor.KeyDown
        ' Acciona el btnAgregar cuando se presiona Enter en alguno de los campos.
        If e.KeyCode.Equals(Keys.Enter) Then
            btnAgregar.PerformClick()
        End If
    End Sub
End Class