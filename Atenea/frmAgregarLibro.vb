Imports MySql.Data.MySqlClient ' Importa el módulo de MySQL
Public Class frmAgregarLibro

    Dim previewLibro As Libro ' Define el preview del libro como tipo Libro (preview)
    Dim interfazEdicion As Boolean = False ' Define interfazEdicion, referido a si se va a editar un libro
    Dim keyEditar As String ' ID del libro a editar (en caso de que sea necesario)

    Public Sub New(Optional ByVal editar As Boolean = False, Optional ByVal key As String = Nothing)
        ' Al generar un nuevo frmAgregarLibro pedir como valores opcionales:
        ' editar (bool) que activa la interfaz de edición
        ' key (string) que se refiere al libro a editar
        ' editar y key, van de la mano
        InitializeComponent()

        ' Setea los valores de las variables locales a los valores especificados en la creación
        interfazEdicion = editar
        keyEditar = key
    End Sub

    Private Sub frmAgregarLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Al cargar, si se está editando muestra/setea valores adicionales del Libro
        If interfazEdicion Then
            Me.Text = "Editar libro · Atenea"

            ' Genera un libro (preview) a partir de la llave de edición
            previewLibro = New Libro(keyEditar, True, True)
            previewLibro.actualizarDatos()

            txtNombre.Text = previewLibro.Titulo
            txtAutor.Text = previewLibro.Autor
            txtID.Text = previewLibro.ID
            txtID.Enabled = False

            cboxGenero.Text = previewLibro.Genero
            cboxEstado.Text = previewLibro.Condicion
            btnAgregar.Text = "Guardar"
        Else
            ' Genera un nuevo libro (preview) sin nada
            previewLibro = New Libro(Nothing, True, True)
        End If

        ' Ubica al libro, y lo agrega al form
        previewLibro.Location = New Point(35, 60)
        Me.Controls.Add(previewLibro)
        ' Por defecto seleccionar los primeros items de los comboBox
        cboxEstado.SelectedIndex = 0
        cboxGenero.SelectedIndex = 0
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim sentencia As String ' Define la sentencia
        sentencia = "INSERT INTO `libro` VALUES (@titulo, @autor, @portada, @genero, @condicion, @id);" ' Toma un valor por defecto
        If interfazEdicion Then
            ' El valor cambia en caso de que se esté editando un libro
            sentencia = "UPDATE `libro` SET Titulo=@titulo, Autor=@autor, Portada=@portada, Genero=@genero, Condicion=@condicion WHERE ID=@id;"
        End If

        Dim mstream As New System.IO.MemoryStream() ' Crea un stream de Memoria para poder guardar la imagen
        previewLibro.imgPortada.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Png) ' Guarda la imagen en la memoria
        Dim arrImage() As Byte = mstream.GetBuffer() ' Obtiene el buffer tipo Byte del stream
        mstream.Close() ' Cierra el stream

        Dim conexion As DB = New DB() ' Establece la conexión a la DB

        ' Crea un nuevo comando (mysqlCommand) y lo pone en uso
        Using cmd As New MySqlCommand()
            With cmd
                ' Establece los valores necesarios para la sentencia / comando.
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
                ' Intenta ejecutar la sentencia
                cmd.ExecuteNonQuery()
                Atenea.cargarLibros() ' Vuelve a cargar los libros
                conexion.Close() ' Cierra la conexión
                Me.Dispose() ' Destruye la ventana
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

    Private Sub checkEscrito(sender As Object, e As EventArgs) Handles txtID.TextChanged, txtAutor.TextChanged, txtNombre.TextChanged
        ' Comprueba (cada vez que se escribeen los txt*) que los datos escritos no sean nulos o puros espacios
        btnAgregar.Enabled = Not (String.IsNullOrWhiteSpace(txtNombre.Text) Or String.IsNullOrWhiteSpace(txtAutor.Text) Or String.IsNullOrWhiteSpace(txtID.Text))

        lblInfo.Visible = False ' Oculta el label de error
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then ' En caso de que el label sea nulo o puro espacios
            previewLibro.lblTitulo.Text = "Preview" ' El título del libro de preview se auto-setea
        Else
            previewLibro.lblTitulo.Text = txtNombre.Text ' El título del libro de preview se setea al valor del txtNombre'
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ' Al presionar Cancelar
        Me.Dispose() ' Destruir ventana
    End Sub


    Private Sub EnterClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyDown, txtNombre.KeyDown, txtAutor.KeyDown
        ' Acciona el btnAgregar cuando se presiona Enter en alguno de los campos.
        If e.KeyCode.Equals(Keys.Enter) Then
            btnAgregar.PerformClick()
        End If
    End Sub
End Class