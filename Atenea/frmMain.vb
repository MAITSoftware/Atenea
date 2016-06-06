Imports MySql.Data.MySqlClient 'Importa MySql.Data.MySqlClient
Public Class frmMain

    Dim pedirNick As Boolean 'Define pedirNick como Boolean
    Dim interfazFuncionario As Boolean 'Define interfazFuncionario como Boolean
    Friend CI As String 'Define CI como String
    Dim buscando As Boolean 'Define buscando como Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Al cargar frmMain
        cargarLibros() 'Ejecuta el método cargarLibros()
        Me.Cursor = System.Windows.Forms.Cursors.Arrow 'Define el cursor como una flecha
        cboxGenero.SelectedIndex = 0
        If pedirNick Then 'Si pedirNick es true
            Dim ventanaNick As frmNickUsuario = New frmNickUsuario(CI) 'Define ventanaNick como 
            ventanaNick.ShowDialog(Me) 'Muestra 
        End If

        If Not interfazFuncionario Then 'Si interfazFuncionario es false
            btnAgregarLibro.Visible = False 'No muestra btnAgregarLibro
            btnAgregar_temporal.Visible = False 'No muestra btnAgregar_temporal
        End If

    End Sub

    Public Sub cargarLibros()
        Dim sentencia As String = "SELECT `ID` FROM `libro`;" 'Define sentencia como String
            If buscando Then 'Si buscando es verdadero
                If radioNombre.Checked Then 'Si radioNombre está seleccionado
                    sentencia = String.Format("SELECT `ID` FROM `libro` WHERE Titulo LIKE '{0}%'", txtBusqueda.Text) 'Buscará el libro por nombre
                ElseIf radioAutor.Checked Then 'Si radioAutor está seleccionado
                    sentencia = String.Format("SELECT `ID` FROM `libro` WHERE Autor LIKE '{0}%'", txtBusqueda.Text) 'Buscará el libro por autor
                ElseIf radioID.Checked Then 'Si radioID está seleccionado
                    sentencia = String.Format("SELECT `ID` FROM `libro` WHERE ID LIKE '{0}%'", txtBusqueda.Text) 'Buscará el libro por ID
                End If

                If chkGenero.Checked Then 'Si chkGenero está marcada
                    sentencia += String.Format(" AND Genero='{0}';", cboxGenero.Text) 'sentencia estará compuesta por " AND Genero='{0}';" y el texto en cboxGenero
                Else
                    sentencia += ";" 'Agrega punto y coma a sentencia
                End If
            End If
        panelLibros.Controls.Clear()
            lblNoDisponibles.Text = "No hay libros disponibles" 'Fija el texto de lblNoDisponibles a "No hay libros disponibles"
        panelLibros.Controls.Add(lblNoDisponibles)
        panelLibros.Controls.Add(btnAgregar_temporal)

        Try
            Atenea.reader.Close()
        Catch ex As Exception
        End Try

            Dim cmd As MySqlCommand = New MySqlCommand(sentencia, Atenea.conexion) 'Define cmd como MySqlCommand con los parámetros sentencia y Atenea.conexion
        Atenea.reader = cmd.ExecuteReader()

        While Atenea.reader.Read()
            panelLibros.Controls.Remove(lblNoDisponibles)
            panelLibros.Controls.Remove(btnAgregar_temporal)
            Dim x As New Libro(Atenea.reader.GetString(0), False)
            panelLibros.Controls.Add(x)
        End While

        For Each Libro In panelLibros.Controls
            Try
                Libro.actualizarDatos()
            Catch ex As Exception
            End Try
        Next

        Atenea.reader.Close()

    End Sub
    
    Private Sub x(sender As Object, e As EventArgs) Handles chkGenero.CheckedChanged
        cboxGenero.Enabled = chkGenero.Checked
        cargarLibros()
    End Sub

    Private Sub y(sender As Object, e As EventArgs) Handles radioNombre.CheckedChanged, radioID.CheckedChanged, radioAutor.CheckedChanged
        cargarLibros()
    End Sub

    Private Sub btnAgregar_temporal_Click(sender As Object, e As EventArgs) Handles btnAgregar_temporal.Click
        btnAgregarLibro.PerformClick()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Atenea.agregarLogin()
    End Sub

    Private Sub btnAgregarLibro_Click(sender As Object, e As EventArgs) Handles btnAgregarLibro.Click
        Dim frm As New frmAgregarLibro()
        frm.ShowDialog(Me)
    End Sub

    Private Sub btnPrestamos_Click(sender As Object, e As EventArgs) Handles btnPrestamos.Click
        Dim frm As New frmPrestamos()
        frm.ShowDialog(Me)
    End Sub

    Public Sub New(ByVal ci_ As String, Optional ByVal primeraVez As Boolean = False, Optional ByVal funcionario As Boolean = False)
        InitializeComponent()
        pedirNick = primeraVez
        interfazFuncionario = funcionario
        CI = ci_
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        buscando = True
        If (String.IsNullOrWhiteSpace(txtBusqueda.Text) And Not chkGenero.Checked) Then
            buscando = False
        End If

        cargarLibros()
    End Sub

    Private Sub cboxGenero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxGenero.SelectedIndexChanged
        buscando = True 'Define buscando como true
        cargarLibros() 'Ejecuta el método cargarLibros ()
    End Sub

 
End Class
