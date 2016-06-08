Imports MySql.Data.MySqlClient  ' Importa el módulo de MySQL
Public Class frmMain

    ' Define las variables:
    ' interfazFuncionario: ¿mostrar interfaz de funcionario?
    ' buscando: ¿Se está haciendo una busqueda?
    ' ¿pedirNick al usuario?

    Dim interfazFuncionario, buscando, pedirNick As Boolean 'Define interfazFuncionario como Boolean
    Dim CI As String
 
    Public Sub New(ByVal ID As String, Optional ByVal firstLogin As Boolean = False, Optional ByVal esFuncionario As Boolean = False)
        ' Al generar un nuevo frmMain pedir como valores:
        ' ID (obligatorio) -- String: el ID del usuario
        ' firstLogin (opcional) -- primer login del usuario
        ' esFuncionario (opcional) -- ¿el usuario es Funcionario?
        InitializeComponent()

        ' Setea los valores de las variables locales a los valores especificados en la creación
        pedirNick = firstLogin
        interfazFuncionario = esFuncionario
        CI = ID
    End Sub
 
    Private Sub mainLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Al cargar el form, cargar los libros '
        cargarLibros()
        ' Setear la selección de cboxGenero a la principal'
        cboxGenero.SelectedIndex = 0
 
        If pedirNick Then 
            ' En caso de solicitarNick, llamar a la ventana NickUsuario
            Dim ventanaNick As frmNickUsuario = New frmNickUsuario(CI) 
            ventanaNick.ShowDialog(Me)
        Else
            ' Cargar el nick
            cargarNick()
        End If

        If Not interfazFuncionario Then 
            ' Si no es funcionario
            btnAgregarLibro.Visible = False  ' ocultar botón de agregarLibro
            btnAgregar_temporal.Visible = False  ' ocultar botón de agregarLibro temporal'
            btnPrestamos.Text = "Préstamo en curso" ' cambiar el modo de la palabra
            CheckPrestamo() ' comprueba si hay un préstamo activo
        End If
    End Sub
 
    Public Sub cargarNick()
        ' Carga el nick desde la DB
        ' Define nombre, apellido, y la conexión'
        Dim Nombre As String
        Dim Apellido As String = ""
        Dim conexion As New DB()

        ' Crea un comando con la sentencia para obtener el nombre e apellido
        Dim cmd As MySqlCommand = New MySqlCommand("select Nombre,Apellido from usuario where CI=@id;", conexion.Conn)
        cmd.Parameters.AddWithValue("@id", CI) ' agrega el valor 

        Dim reader As MySqlDataReader = cmd.ExecuteReader() ' obtiene el reader
        reader.Read() ' y lee el primer valor
        Nombre = reader("Nombre") ' obtiene el nombre
        Try
            ' Intenta obtener apellido (intenta, porque los usuarios no tienen apellido)
            Apellido = reader("Apellido")
        Catch ex As Exception
        End Try

        reader.Close() ' cierra el reader
        conexion.Close() ' cierra la conexión

        ' actualiza el lblBienvenida a los datos nuevos
        lblBienvenida.Text = "Bienvenido/a " & ControlChars.NewLine & Nombre & " " & Apellido
    End Sub

    Public Sub cargarLibros()
        ' Carga los libros desde la DB

        ' cambia el cursor a un cursor pensando xD
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        ' Define la sentencia principal'
        Dim sentencia As String = "SELECT `ID` FROM `libro`"
 
        If cboxDisponibles.Checked Then ' si cboxDisponibles está checkeado
            sentencia += " order by (ID in (select ID from prestamo));"  ' el orden queda ascendente
        Else
            sentencia += " order by (ID in (select ID from prestamo)) DESC;" ' el orden queda descendente
        End If

        ' Si estamos buscando
        If buscando Then
            ' Se agregan las preferencias de busqueda
            If radioNombre.Checked Then
                sentencia = String.Format("SELECT `ID` FROM `libro` WHERE Titulo LIKE '{0}%'", txtBusqueda.Text)
            ElseIf radioAutor.Checked Then
                sentencia = String.Format("SELECT `ID` FROM `libro` WHERE Autor LIKE '{0}%'", txtBusqueda.Text)
            ElseIf radioID.Checked Then
                sentencia = String.Format("SELECT `ID` FROM `libro` WHERE ID LIKE '{0}%'", txtBusqueda.Text)
            End If

            If chkGenero.Checked Then
                sentencia += String.Format(" AND Genero='{0}'", cboxGenero.Text)
            End If

            If cboxDisponibles.Checked Then
                sentencia += " order by (ID in (select ID from prestamo));"
            Else
                sentencia += " order by (ID in (select ID from prestamo)) DESC;"
            End If
        End If

        ' limpia el panel de libros 
        panelLibros.Controls.Clear()
        lblNoDisponibles.Text = "No hay libros disponibles" ' setea el label de noDisponibles
        panelLibros.Controls.Add(lblNoDisponibles) ' agrega el label noDisponibles

        If interfazFuncionario Then
            ' Si es funcionario agrega el botón para agregar libros
            panelLibros.Controls.Add(btnAgregar_temporal)
        End If

        Dim conexion As DB = New DB() ' establece la conexión'
        ' define el comando
        Dim cmd As MySqlCommand = New MySqlCommand(sentencia, conexion.Conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader() ' Ejecuta el comando y obtiene los valores devueltos

        ' Mostrar lblNoDisponibles
        lblNoDisponibles.Visible = True

        ' Mientras haya algun valor para leer
        While reader.Read()
            ' Si hay algún valor: elimna el lblNoDisponibles + btnAgregarTemporal
            panelLibros.Controls.Remove(lblNoDisponibles)
            panelLibros.Controls.Remove(btnAgregar_temporal)
            lblNoDisponibles.Visible = False

            ' Crea un nuevo libro con la llave obtenida y lo agrega
            Dim x As New Libro(reader.GetString(0))
            panelLibros.Controls.Add(x)
        End While

        ' Si el lblNoDisponibles está visible
        If lblNoDisponibles.Visible Then
            reader.Close() ' cerrar reader
            conexion.Close() ' cerrar conexión
            ' El cursor vuelve a ser una flecha
            Me.Cursor = System.Windows.Forms.Cursors.Arrow
            Return ' volver
        End If

        ' Si no está visible:'

        ' Definir un entero con la cantidad de libros visibles'
        Dim visibles As Integer
        ' por cada libro en la lista
        For Each l As Libro In panelLibros.Controls
            ' Intentar'
            Try
                ' actualizar datos
                l.actualizarDatos()
                visibles += 1 ' sumar 1 a la lista de libros visibles'
                If chkSoloDisponibles.Checked Then ' si el check de solo mostrar Disponibles está checkeado'
                    If Not l.estaDisponible Then ' y el libro no está disponible'
                        l.Visible = False ' ocultar el libro'
                        visibles -= 1 ' restar 1 a la lista de libros visibles'
                    End If
                End If
            Catch ex As Exception
            End Try
        Next

        ' Si hay <= 0 libros visibles'
        If visibles <= 0 Then
            ' Eliminar todos los libros, y mostrar lblNoDisponibles
            panelLibros.Controls.Clear()
            lblNoDisponibles.Visible = True
            lblNoDisponibles.Text = "No hay libros disponibles"
            panelLibros.Controls.Add(lblNoDisponibles)

            If interfazFuncionario Then
                ' Si es funcionario, agrega el botón para agregar libro
                panelLibros.Controls.Add(btnAgregar_temporal)
            End If
        End If

        ' El cursor vuelve a ser una flecha
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        reader.Close() ' cierra el reader
        conexion.Close() ' cierra la conexión
    End Sub

    Private Sub CheckPrestamo()
        ' Comprueba si el usuario tiene un préstamo activo 
        Dim conexion As DB = New DB() ' establece la conexión
        Dim cmd As MySqlCommand = New MySqlCommand("select * from prestamo where `CI_Usuario`=@id;", conexion.Conn) ' crea un comando
        cmd.Parameters.AddWithValue("@id", CI) ' agrega los parámetros
        Dim reader As MySqlDataReader = cmd.ExecuteReader() ' Ejecuta el comando y obtiene los valores devueltos

        ' Oculta la info de préstamo'
        panelInfo.Visible = False
        lblEntregarLibro.Visible = False

        ' Mientras haya algun valor para leer
        While reader.Read()
            ' Muestra la info de préstamo
            panelInfo.Visible = True
            lblEntregarLibro.Visible = True
            ' Setea el lbl de info con la fecha de entrega
            lblEntregarLibro.Text = "Entregue su libro antes del" & ControlChars.NewLine & DateTime.Parse(reader.GetString(4)).ToShortDateString()
        End While

        reader.Close() ' cierra el reader
        conexion.Close() ' cierra la conexión
    End Sub

    Private Sub btnPrestamos_Click(sender As Object, e As EventArgs) Handles btnPrestamos.Click
        ' Al clickear el botón de Prestamo/s ...

        If interfazFuncionario Then
            ' Si es funcionario  mostrar la ventana de préstamos'
            Dim frm As New frmPrestamos()
            frm.ShowDialog(Me)
        Else
            Dim conexion As DB = New DB() ' Establece la coneción'
            Dim cmd As MySqlCommand = New MySqlCommand("select * from prestamo where `CI_Usuario`=@ID;", conexion.Conn) ' crea un comando
            cmd.Parameters.AddWithValue("@ID", CI) ' agrega los parámetros
            Dim reader As MySqlDataReader = cmd.ExecuteReader() ' Ejecuta el comando y obtiene los valores devueltos

            ' Mientras haya algun valor para leer
            While reader.Read()
                ' Mostrar el diálogo de préstamo, pasandole como parámetro el ID del libro
                Dim frm As New frmPrestamo(reader("ID"))
                frm.ShowDialog(Me)
                reader.Close() ' cerrar reader
                conexion.Close() ' cerrar conexión
                Return ' volver
            End While

            ' En caso de que no haya == no hay préstamo activo

            reader.Close() ' cerrar reader
            conexion.Close() ' cerrar conexión

            MsgBox("Aún no has rentado ningún libro") ' muestra un msgbox notificando que no hay un préstamo activo
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        ' Al cambiar el texto de txtBusqueda, y que éste tenga realmente texto, se activa la busqueda
        buscando = True
        If (String.IsNullOrWhiteSpace(txtBusqueda.Text) And Not chkGenero.Checked) Then
            buscando = False
        End If

        ' Y se actualizan los libros en base a la busqueda
        cargarLibros()
    End Sub

    Private Sub cboxGenero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxGenero.SelectedIndexChanged
        ' Al cambiar de género, activar busqueda
        buscando = True ' Define buscando como true
        cargarLibros() ' Actualizar libros en base a busqueda
    End Sub

    Private Sub cboxDisponibles_CheckedChanged(sender As Object, e As EventArgs) Handles cboxDisponibles.CheckedChanged
        ' Al cambiar la opción de libros Disponibles
        cargarLibros() ' Actualizar libros en base a busqueda
    End Sub

    Private Sub paramsBusqueda(sender As Object, e As EventArgs) Handles radioNombre.CheckedChanged, radioID.CheckedChanged, radioAutor.CheckedChanged, chkGenero.CheckedChanged, chkSoloDisponibles.CheckedChanged
        ' Al cambiar los parámetros de busqueda
        buscando = True
        cboxGenero.Enabled = chkGenero.Checked ' activar cboxgenero si chkGenero está chckeado
        cargarLibros() ' actualizar libros en base a busqueda
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ' Al clickear salir 
        Me.Dispose() ' Destruir esta ventana
        Atenea.agregarLogin() ' Y agregar login nuevamente
    End Sub

    Private Sub btnAgregarLibro_Click(sender As Object, e As EventArgs) Handles btnAgregarLibro.Click, btnAgregar_temporal.Click
        ' Al clickear en agregar libro, llamar al form para AgregarLibro
        Dim frm As New frmAgregarLibro()
        frm.ShowDialog(Me)
    End Sub
End Class
