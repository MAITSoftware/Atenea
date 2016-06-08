Imports MySql.Data.MySqlClient ' Importa el módulo de MySQL
Public Class frmConfPrestamo

    ' frmConfPrestamo: permite asignar / modificar los préstamos

    Dim llaveLibro, ciUsuario, fechaActual, fechaPrestamo As String
    Dim interfazEdicion As Boolean

    Public Sub New(ByVal llave As String, Optional ByVal editar As Boolean = False, Optional ByVal usuario As String = Nothing, Optional ByVal fechaEntrega As String = Nothing, Optional ByVal fechaPrestado As String = Nothing)
        ' Al generar un nuevo frmConfPrestamo pedir valores opcionales/obligatorios y setear los de
        ' variables locales a los valores especificados en la creación
        InitializeComponent()
        llaveLibro = llave
        interfazEdicion = editar
        ciUsuario = usuario
        fechaActual = fechaEntrega
        fechaPrestamo = fechaPrestado
    End Sub

    Private Sub frmConfPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Al cargar, si se está editando muestra/setea valores adicionales del Libro -- Interfaz

        Dim libro As Libro
        libro = New Libro(llaveLibro, True)
        libro.Location = New Point(58, 50)
        libro.Parent = pnlPreview
        libro.actualizarDatos()

        lblAutor.Text = "Autor: " + libro.Autor
        lblGenero.Text = "Género: " + libro.Genero
        lblID.Text = "ID: " + libro.ID
        lblCondicion.Text = "Condición: " + libro.Condicion

        If interfazEdicion Then
            calPrestamo.MinDate = Convert.ToDateTime(fechaPrestamo)
            calPrestamo.MaxDate = calPrestamo.MinDate.AddDays(21)
            calPrestamo.BoldedDates = New System.DateTime() {calPrestamo.MinDate, DateTime.Parse(Convert.ToDateTime(fechaActual).ToString("yyyy-MM-dd"))}
            calPrestamo.SetDate(Convert.ToDateTime(fechaActual))

            Me.Text = "Actualizar datos de préstamo · Atenea"
            cboxUsuario.Enabled = False
            btnPrestar.Enabled = True
            btnPrestar.Text = "Cambiar"
        Else
            calPrestamo.MinDate = System.DateTime.Now().AddDays(1)
            calPrestamo.MaxDate = System.DateTime.Now().AddDays(21)
            calPrestamo.BoldedDates = New System.DateTime() {System.DateTime.Now(), calPrestamo.MaxDate}
            calPrestamo.SetDate(calPrestamo.MaxDate)
        End If

        cargarUsuarios()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ' Al clickear cancelar, destruir Ventana
        Me.Dispose()
    End Sub

    Private Sub btnPrestar_Click(sender As Object, e As EventArgs) Handles btnPrestar.Click
        ' Al clickear el botón prestar/cambiar se actualizan, insertan, los datos del prestamo en la base de datos.
        Dim conexion As New DB()

        Dim sentencia As String 
        sentencia = "INSERT INTO `prestamo` VALUES (@id, @ciUsuario, @ciFuncionario, @fechaPrestamo, @fechaEntrega);"
        If interfazEdicion Then
            sentencia = "UPDATE `prestamo` SET `Fecha entrega`=@fechaEntrega WHERE `ID`=@id;"
        End If

        Dim cmd As New MySqlCommand(sentencia, conexion.Conn)

        If interfazEdicion Then
            cmd.Parameters.AddWithValue("@id", llaveLibro) 
            cmd.Parameters.AddWithValue("@fechaEntrega", calPrestamo.SelectionRange.Start.ToString("yyyy-MM-dd"))
        Else
            cmd.Parameters.AddWithValue("@id", llaveLibro) 
            cmd.Parameters.AddWithValue("@ciUsuario", ciUsuario)
            cmd.Parameters.AddWithValue("@ciFuncionario", Atenea.CI) 
            cmd.Parameters.AddWithValue("@fechaPrestamo", DateTime.Now.ToString("yyyy-MM-dd")) 
            cmd.Parameters.AddWithValue("@fechaEntrega", calPrestamo.SelectionRange.Start.ToString("yyyy-MM-dd"))
        End If

        cmd.ExecuteNonQuery()
        Atenea.cargarLibros()

        conexion.Close()
        Me.Dispose()
    End Sub

    Private Sub comboUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxUsuario.SelectedIndexChanged
        ' al cambiar la selecion del comboUsuario, checkear si este no tiene un préstamo activo

        If interfazEdicion Then ' Si está editando, obviamente, tiene un préstamo activo.
            Return ' así que no hacer nada
        End If

        Dim conexion As New DB()
        Dim user As String = cboxUsuario.SelectedItem.ToString()
        ciUsuario = user.Substring(0, user.IndexOf(" -- ")) ' Busca la posición de " -- " (el separador) y obtiene el texto anterior a éste
        Dim cmd As MySqlCommand = New MySqlCommand("select * from prestamo where `CI_Usuario`=@id;", conexion.Conn) 
        cmd.Parameters.AddWithValue("@id", ciUsuario) 

        Dim reader As MySqlDataReader = cmd.ExecuteReader() 

        lblInfo.Visible = False 
        btnPrestar.Enabled = True 

        While reader.Read()
            lblInfo.Visible = True 
            btnPrestar.Enabled = False 
        End While

        reader.close() 
        conexion.Close() 
    End Sub

    Private Sub cargarUsuarios()
        ' Carga los usuarios desde la DB a cboxUsuario

        Dim conexion As DB = New DB() 

        Using cmd As New MySqlCommand()
            With cmd
                .Connection = conexion.Conn
                .CommandText = "select * from usuario where tipo='usuario' order by CI;"
                .CommandType = CommandType.Text
            End With

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

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
                    cboxUsuario.Text = String.Format("{0} -- {1}", ID, Nombre)
                Else ' En caso de que no sea edición agrega el usuario a la lista
                    cboxUsuario.Items.Add(String.Format("{0} -- {1}", ID, Nombre))
                End If
            End While

            reader.Close() 
            conexion.Close() 
        End Using
    End Sub

    Private Sub calendario_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calPrestamo.DateChanged
        ' Cuando cambia la fecha turnarla en negrita
        If interfazEdicion Then ' En caso de edición pone en negrita la fecha mínima y la seleccionada
            calPrestamo.BoldedDates = New System.DateTime() {calPrestamo.MinDate, calPrestamo.SelectionRange.Start}
        Else ' En caso de préstamo, pone en negrita la fecha de hoy, y la seleccionada
            calPrestamo.BoldedDates = New System.DateTime() {System.DateTime.Now(), calPrestamo.SelectionRange.Start}
        End If
        ' Cambia el texto de lblFecha a la fecha seleccionada
        lblFecha.Text = FormatDateTime(calPrestamo.SelectionRange.Start, DateFormat.ShortDate)
    End Sub

End Class