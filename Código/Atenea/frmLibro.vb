Imports MySql.Data.MySqlClient ' Importa el módulo de MySQL
Public Class Libro

    ' Define las variables:
    ' estaDisponible: ¿está el libro disponible para prestar?
    ' llaveLibro: ID del libro en la base de datos
    ' elegirFoto: en caso de True, el usuario puede elegir la foto
    ' preview: en caso de True, el usuario solo puede ver el libro, y nada más
    ' fc: Crea un nuevo fileDialog, para elegir la foto
    ' Titulo, Genero, Autor, ID, Condicion: Datos del libro públicos

    Friend estaDisponible As Boolean = True
    Dim llaveLibro As String
    Dim elegirFoto As Boolean
    Dim preview As Boolean = False
    Dim fc As OpenFileDialog = New OpenFileDialog()
    Friend Titulo, Genero, Autor, ID, Condicion As String


    Public Sub New(ByVal llave As String, Optional ByVal prev As Boolean = False, Optional ByVal eligeFoto As Boolean = False)
        ' Al generar un nuevo libro pedir como valores:
        ' llave (obligatorio) -- String: el ID del libro en la base de datos
        ' prev (opcional) -- solo preview
        ' eligeFoto (opcional) -- permite al usuario elegir la foto
        InitializeComponent()

        ' Setea los valores de las variables locales a los valores especificados en la creación
        Me.elegirFoto = eligeFoto
        preview = prev
        llaveLibro = llave
    End Sub

    Private Sub libro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Cuando carga el libro
        ' Setear el fileChooser, con los filtros de imágen'
        fc.Title = "Seleccionar portada"
        fc.Filter = "Archivos de mapa de bits (*.bmp, *.dib)|*.BMP;*.DIB;*.RLE|JPEG (*.jpg, *.jpeg, *.jpeg, *.jfif)|*.JPG;*.JPEG;*.JPE;*.JFIF|GIF (*.gif)|*.GIF|TIFF (*.tif, *.tiff)|*.TIF;*.TIFF|PNG (*.png)|*.PNG|Todos los archivos|*.*|Todos los archivos de imagen|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG"
        fc.FilterIndex = 7
        fc.RestoreDirectory = True

        imgNoDisponible.BackgroundImage = Nothing ' Oculta la sombra de imgNoDisponible
        imgBorde.Cursor = Cursors.Hand ' Cambia el cursor a una mano
        imgPortada.Parent = imgBorde ' Establece el padre de imgPortada
        imgNoDisponible.Parent = imgPortada ' Establece el padre de imgNoDisponible
        btnEditar.Parent = imgNoDisponible ' Establece el padre de btnEditar
        btnEliminar.Parent = imgNoDisponible ' Establece el padre de btnEliminar

        ' Agrega tooltips a los botones editar, eliminar
        Call New ToolTip().SetToolTip(btnEditar, "Editar libro")
        Call New ToolTip().SetToolTip(btnEliminar, "Eliminar libro")

        ' En caso de que no sea funcionario o sea un preview / elegirFoto
        If Not Atenea.funcionario Or preview Or elegirFoto Then
            ' Ocultar los botones de edición
            btnEditar.Visible = False
            btnEliminar.Visible = False
        End If
    End Sub

    Public Sub actualizarDatos()
        ' Obtiene los datos de la DB y actualiza el libro

        Dim conexion As DB = New DB() ' Establece la conexión a la DB

        ' Crea un comando con la sentencia para obtener los libros
        Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM `libro` WHERE ID=@id;", conexion.Conn)
        cmd.Parameters.AddWithValue("@id", llaveLibro) ' y setea los parámetros necesarios

        Dim reader As MySqlDataReader = cmd.ExecuteReader() ' Ejecuta el comando y obtiene los valores devueltos

        ' Mientras haya algun valor para leer
        While reader.Read()
            ' Actualizar los datos del libro
            Me.Titulo = reader("Titulo")
            Me.Genero = reader("Genero")
            Me.Autor = reader("Autor")
            Me.ID = reader("ID")
            Me.Condicion = reader("Condicion")

            lblTitulo.Text = Me.Titulo ' Incluído el label del título

            If Not (preview Or elegirFoto) Then
                ' Y crea un tooltip en caso de que éste libro no esté de preview
                Call New ToolTip().SetToolTip(imgNoDisponible, "Título: " & Me.Titulo & ControlChars.NewLine &
                                                    "Autor: " & Me.Autor & ControlChars.NewLine &
                                                    "Género: " & Me.Genero & ControlChars.NewLine &
                                                    "Condición: " & Me.Condicion & ControlChars.NewLine &
                                                    "ID: " & Me.ID)
            End If

            ' Obtiene la foto desde la DB
            Dim byteImage() As Byte = reader("Portada")
            Dim foto As New System.IO.MemoryStream(byteImage)
            imgPortada.BackgroundImage = Image.FromStream(foto)
        End While

        reader.Close() ' cierra el reader

        ' Checkea que el libro no se encuentre prestado
        cmd =  New MySqlCommand("SELECT ID FROM prestamo WHERE ID=@id;", conexion.Conn)
        cmd.Parameters.AddWithValue("@id", llaveLibro) '
        reader = cmd.ExecuteReader()

        If Atenea.funcionario And Not (preview Or elegirFoto) Then
            ' Muestra los botones de editar, eliminar en caso de que sea funcionario y no sea preview
            btnEditar.Visible = True
            btnEliminar.Visible = True
        End If

        ' Acomoda los botones a su posición original
        btnEditar.Location = New Point(100, 0)
        btnEliminar.Location = New Point(125, 0)

        ' Elimina la sombra de noDisponible, y cambia el cursor a una man'
        imgNoDisponible.BackgroundImage = Nothing
        imgNoDisponible.Cursor = Cursors.Hand

        If Not (preview Or elegirFoto) Then
            ' cambia el borde a un borde verde, que indica que el libro está disponible
            imgBorde.BackgroundImage = My.Resources.borde_Disponible()
        End If

        estaDisponible = True ' cambia el valor de está disponible

        ' Mientras haya algun valor para leer
        While reader.Read()
            ' En caso de que haya un valor, el libro no está disponible'
            If Not (preview Or elegirFoto) Then
                ' Si no es preview, setea la sombra de indisponibilidad
                imgNoDisponible.BackgroundImage = My.Resources.sombra_nodisponible()
                estaDisponible = False ' cambiar el valor de está disponible 
                ' cambia el borde a un borde rojo, que indica que el libro NO está disponible
                imgBorde.BackgroundImage = My.Resources.borde_NoDisponible() 
                ' cambia el cursor a "No"
                imgNoDisponible.Cursor = Cursors.No 
            End If
            ' Como el libro está prestado no se puede eliminar
            btnEliminar.Visible = False
            ' Solo editar, por lo tanto muevo el libro editar a la posición del boton eliminar'
            btnEditar.Location = New Point(125, 0)
        End While

        reader.Close() ' Cierra el reader
        conexion.Close() ' Cierra la conexión'
    End Sub

    Public Sub imgNoDisponible_Click(sender As Object, e As EventArgs) Handles imgNoDisponible.Click
        ' Cuando se clickea el libro

        If Atenea.funcionario And Not (preview Or elegirFoto) And Not (imgNoDisponible.Cursor Is Cursors.No) Then
            ' Si soy funcionario, no es preview, y está disponible
            ' Llama a la form configuración préstamo'
            Dim frm As New frmConfPrestamo(llaveLibro)
            frm.ShowDialog(Me.ParentForm)
        End If

        ' Si no está para elegir foto
        If Not Me.elegirFoto Then
            Return ' Volver atrás
        End If

        ' Abre el filedialog, en caso de que se seleccione una imagen
        If fc.ShowDialog(Me.ParentForm) = DialogResult.OK Then
            ' Crea un nuevo bitMap en base a la selección
            Dim portada As Bitmap = New Bitmap(fc.FileName)
            ' Y cambia la foto de portada
            imgPortada.BackgroundImage = portada
        End If
    End Sub

    Private Sub btnEditar_Leave(sender As Object, e As EventArgs) Handles btnEditar.MouseLeave
        ' Efecto: cambiar la imagen de btnEditar al salir de el
        btnEditar.BackgroundImage = My.Resources.editarLibro()
    End Sub

    Private Sub btnEditar_Enter(sender As Object, e As EventArgs) Handles btnEditar.MouseEnter
        ' Efecto: cambiar la imagen de btnEditar al entrar de el
        btnEditar.BackgroundImage = My.Resources.editarLibro_()
    End Sub

    Private Sub btnEliminar_Leave(sender As Object, e As EventArgs) Handles btnEliminar.MouseLeave
        ' Efecto: cambiar la imagen de btnEditar al salir de el
        btnEliminar.BackgroundImage = My.Resources.eliminarLibro()
    End Sub

    Private Sub btnEliminar_Enter(sender As Object, e As EventArgs) Handles btnEliminar.MouseEnter
        ' Efecto: cambiar la imagen de btnEditar al entrar a el
        btnEliminar.BackgroundImage = My.Resources.eliminarLibro_()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        ' Al clickear editar, llamar a la ventana frmagregarLibro
        ' especificando que se quiere editar, más la llavel del libro
        Dim editar As frmAgregarLibro
        editar = New frmAgregarLibro(True, Me.llaveLibro)
        editar.ShowDialog(Me)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Al clickear eliminar, llamar a la ventana frmAccionLibro
        ' especificando la llave del libro
        Dim eliminar As frmAccionLibro
        eliminar = New frmAccionLibro(Me.llaveLibro)
        eliminar.ShowDialog(Me)
    End Sub
End Class
