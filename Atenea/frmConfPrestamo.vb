Imports MySql.Data.MySqlClient ' Importa el módulo de MySQL
Public Class frmConfPrestamo

    ' Define las variables:
    ' llaveLibro: ID del libro en la base de datos
    ' ciUsuario: ID del usuario en la base de datos
    ' fechaActual: fecha de entrega actual
    ' fechaPrestamo: fecha en la que se realizó el prestamo
    ' interfazEdicion: indica si se debe utilizar la ventana en modo de edición de préstamo
    ' fechaActual, fechaPrestamo, ciUsuario, van de la mano con interfazEdicion

    Dim llaveLibro, ciUsuario, fechaActual, fechaPrestamo As String
    Dim interfazEdicion As Boolean

    Public Sub New(ByVal llave As String, Optional ByVal editar As Boolean = False, Optional ByVal usuario As String = Nothing, Optional ByVal fechaEntrega As String = Nothing, Optional ByVal fechaPrestado As String = Nothing)
        ' Al generar un nuevo frmConfPrestamo pedir como valores:
        ' llave (obligatorio) -- String: el ID del libro en la base de datos
        ' editar (opcional) -- Boolean: ¿activar interfaz de edición? 
        '  --> fechaEntrega (opcional) -- String: fecha de entrega supuesta antes de editar
        '  --> fechaPrestamo (opcional) -- String: fecha en la cual se realizó el préstamo

        InitializeComponent()

        ' Setea los valores de las variables locales a los valores especificados en la creación
        llaveLibro = llave
        interfazEdicion = editar
        ciUsuario = usuario
        fechaActual = fechaEntrega
        fechaPrestamo = fechaPrestado
    End Sub

    Private Sub frmConfPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Al cargar, si se está editando muestra/setea valores adicionales del Libro -- Interfaz

        ' Define un libro
        Dim libro As Libro
        ' Construye el libro a partir de la llaveLibro, el booleano True indica que es un preview intocable
        libro = New Libro(llaveLibro, True)
        libro.Location = New Point(58, 50) ' Lo ubica
        libro.Parent = Panel1 ' Setea el padre
        libro.actualizarDatos() ' actualiza los datos del libro

        ' Setea los valores de los labels locales a los datos del libro
        lblAutor.Text = "Autor: " + libro.Autor
        lblGenero.Text = "Genero: " + libro.Genero
        lblID.Text = "ID: " + libro.ID
        lblCondicion.Text = "Condición: " + libro.Condicion

        ' En caso de que se esté editando
        If interfazEdicion Then
            ' Setear la fecha mínima a la fecha en la que se realizó el préstamo
            ' Setear la fecha máxima a: fechaMínima en la que se realizó el préstamo + 21 días'
            ' Oscurece el día de hoy, y la fecha de préstamo actual
            ' Setea la fecha del calendario a la fecha de préstamo actual
            calendario.MinDate = Convert.ToDateTime(fechaPrestamo)
            calendario.MaxDate = calendario.MinDate.AddDays(21)
            calendario.BoldedDates = New System.DateTime() {calendario.MinDate, DateTime.Parse(Convert.ToDateTime(fechaActual).ToString("yyyy-MM-dd"))}
            calendario.SetDate(Convert.ToDateTime(fechaActual))


            Me.Text = "Actualizar datos de préstamo · Atenea" ' Cambia el nombre de la ventana'
            comboUsuario.Enabled = False ' Desactiva la selecion de usuario
            btnPrestar.Enabled = True ' Activa el botón de prestamo/cambiar que por defecto está desactivado'
            btnPrestar.Text = "Cambiar" ' Setea el texto del botón a Cambiar.
        Else
            ' Setear la fecha mínima a la fecha de hoy
            ' Setear la fecha máxima a: fecha de hoy + 21 días'
            ' Oscurece el día de hoy, y la fecha máxima (hoy + 21 días)
            ' Setea la fecha del calendario a la fecha máxima (hoy + 21 días)
            calendario.MinDate = System.DateTime.Now().AddDays(1)
            calendario.MaxDate = System.DateTime.Now().AddDays(21)
            calendario.BoldedDates = New System.DateTime() {System.DateTime.Now(), calendario.MaxDate}
            calendario.SetDate(calendario.MaxDate)
        End If

        ' Agrega los usuarios al combobox
        cargarUsuarios()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ' Al clickear cancelar
        Me.Dispose() ' Destruir ventana
    End Sub

    Private Sub btnPrestar_Click(sender As Object, e As EventArgs) Handles btnPrestar.Click
        ' Al clickear el botón prestar/cambiar
        Dim conexion As New DB() ' Define la conexión a la DB

        Dim sentencia As String ' Define la sentencia
        sentencia = "INSERT INTO `prestamo` VALUES (@id, @ciUsuario, @ciFuncionario, @fechaPrestamo, @fechaEntrega);" ' Toma un valor por defecto
        If interfazEdicion Then
            ' El valor cambia en caso de que se esté editando un préstamo
            sentencia = "UPDATE `prestamo` SET `Fecha entrega`=@fechaEntrega WHERE `ID`=@id;"
        End If
    
        Dim cmd As New MySqlCommand(sentencia, conexion.Conn) ' Define un comando sql

        If interfazEdicion Then
            ' En caso de edición, agregar solo estos dos valores
            cmd.Parameters.AddWithValue("@id", llaveLibro) ' llave del libro
            cmd.Parameters.AddWithValue("@fechaEntrega", calendario.SelectionRange.Start.ToString("yyyy-MM-dd")) ' fecha seleccionada en el calendario
        Else
            cmd.Parameters.AddWithValue("@id", llaveLibro) ' llave del libro
            cmd.Parameters.AddWithValue("@ciUsuario", ciUsuario) ' ci del usuario
            cmd.Parameters.AddWithValue("@ciFuncionario", Atenea.CI) ' ci del funcionario'
            cmd.Parameters.AddWithValue("@fechaPrestamo", DateTime.Now.ToString("yyyy-MM-dd")) ' fecha actual
            cmd.Parameters.AddWithValue("@fechaEntrega", calendario.SelectionRange.Start.ToString("yyyy-MM-dd")) ' fecha seleccionada en el calendario
        End If

        ' Ejecuta la secuencia
        cmd.ExecuteNonQuery()
        Atenea.cargarLibros() ' vuelve a cargar los libros

        conexion.Close() ' cierra la conexión
        Me.Dispose() ' Destruye la ventana
    End Sub

    Private Sub comboUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboUsuario.SelectedIndexChanged
        ' al cambiar la selecion del comboUsuario, checkear si este no tiene un préstamo activo

        If interfazEdicion Then ' Si está editando, obviamente, tiene un préstamo activo.
            Return ' así que no hacer nada
        End If
 
        Dim conexion As New DB() ' Define la conexión a la DB
        Dim user As String = comboUsuario.SelectedItem.ToString() ' Convierte la selecciónn a String
        ciUsuario = user.Substring(0, user.IndexOf(" -- ")) ' Busca la posición de " -- " (el separador) y obtiene el texto anterior a éste
        Dim cmd As MySqlCommand = New MySqlCommand("select * from prestamo where `CI_Usuario`=@id;", conexion.Conn) ' crea el comando
        cmd.Parameters.AddWithValue("@id", ciUsuario) ' agregar la ci del usuario a la sentencia

        Dim reader As MySqlDataReader = cmd.ExecuteReader() ' Ejecuta el comando y obtiene los valores devueltos

        lblInfo.Visible = False ' Oculta el lblInfo
        btnPrestar.Enabled = True ' Y activa el btn de Prestar

        ' Mientras haya algun valor para leer
        While reader.Read()
            lblInfo.Visible = True ' En caso de que haya un valor en la tabla, muestra el lblInfo
            btnPrestar.Enabled = False ' Desactiva el btn de prestar
        End While

        reader.close() ' cierra el reader
        conexion.Close() ' cierra la conexión
    End Sub

    Private Sub cargarUsuarios()
        ' Carga los usuarios desde la DB a un comboBox

        Dim conexion As DB = New DB() ' Establece la conexión

       ' Crea un nuevo comando (mysqlCommand) y lo pone en uso
        Using cmd As New MySqlCommand()
            With cmd
                ' Establece los valores necesarios para la sentencia / comando.
                .Connection = conexion.Conn
                .CommandText = "select * from usuario where tipo='usuario' order by CI;"
                .CommandType = CommandType.Text
            End With

            Dim reader As MySqlDataReader = cmd.ExecuteReader() ' Ejecuta el comando y obtiene los valores devueltos

            ' Mientras haya algun valor para leer
            While reader.Read()
                Dim Nombre, ID ' Defino el nombre, y la ID'
                ID = reader("CI") ' obtengo el ID (CI) desde la base de datos y lo guardo
                Nombre = reader("Nombre") ' obtengo el Nombre (nombre) desde la base de datos y lo guardo
                If interfazEdicion Then
                    ' Si está editando y el usuario obtenido de la DB no coincide con el usuario del préstamo'
                    If Not Convert.ToInt32(ciUsuario).Equals(ID) Then
                        Continue While ' Seguir buscando
                    End If
                End If

                If interfazEdicion Then ' En caso de edición setea el valor del combobox
                    comboUsuario.Text = String.Format("{0} -- {1}", ID, Nombre)
                Else ' En caso de que no sea edición agrega el usuario a la lista
                    comboUsuario.Items.Add(String.Format("{0} -- {1}", ID, Nombre))
                End If
            End While

            reader.Close() ' cierra el reader
            conexion.Close() ' cierra la conexión
        End Using
    End Sub

    Private Sub calendario_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calendario.DateChanged
        ' Cuando cambia la fecha turnarla en negrita
        if interfazEdicion ' En caso de edición pone en negrita la fecha mínima y la seleccionada
            calendario.BoldedDates = New System.DateTime() {calendario.MinDate, calendario.SelectionRange.Start}
        Else ' En caso de préstamo, pone en negrita la fecha de hoy, y la seleccionada
            calendario.BoldedDates = New System.DateTime() {System.DateTime.Now(), calendario.SelectionRange.Start}
        End If
        ' Cambia el texto de lblFecha a la fecha seleccionada
        lblFecha.Text = FormatDateTime(calendario.SelectionRange.Start, DateFormat.ShortDate)
    End Sub

End Class