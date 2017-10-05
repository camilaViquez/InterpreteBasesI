Imports System.Data.SqlClient
Imports System.Data.Sql






Module Module1
    Public cn As SqlConnection
    Public adaptador As SqlDataAdapter
    Public dt As DataTable
    Public x
    Public parametrosAux
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public cmd1 As SqlCommand
    Public dr1 As SqlDataReader

    Sub abrirConexion()
        Try
            cn = New SqlConnection("Data Source=LEO;Initial Catalog=Ventas;Integrated Security=True")
            cn.Open()

            MessageBox.Show("Se realizó la conección con exito")

        Catch ex As Exception
            MessageBox.Show(" No se pudo conectar" + ex.ToString)


        End Try
    End Sub


    Sub llenarDatagridviewSeleccion(ByVal dgv As DataGridView, ByVal parametros As String)

        Try


            adaptador = New SqlDataAdapter(parametros, cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt



        Catch ex As Exception
            MessageBox.Show("Se presentó un error a la hora de realizar la consulta. ")

        End Try
    End Sub

    Sub llenarDatagridviewProyeccion(ByVal dgv As DataGridView, ByVal parametros As String)

        Try

            adaptador = New SqlDataAdapter(parametros, cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Se presentó un error a la hora de realizar la consulta. ")

        End Try
    End Sub

    Public Sub llenarDatagridviewConcatenacion(ByVal dgv As DataGridView, ByVal parametrosU As String)
        Try
            adaptador = New SqlDataAdapter(parametrosU, cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

        Catch ex As Exception

        End Try

    End Sub


    Public Sub llenarDatagridviewUnion(ByVal dgv As DataGridView, ByVal parametrosU As String)
        Try
            adaptador = New SqlDataAdapter(parametrosU, cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

        Catch ex As Exception

        End Try

    End Sub

    Public Sub llenarDatagridviewCartesiano(ByVal dgv As DataGridView, ByVal parametrosU As String)
        Try
            adaptador = New SqlDataAdapter(parametrosU, cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

        Catch ex As Exception

        End Try

    End Sub


    Public Sub llenarDatagridviewAgrupacion(ByVal dgv As DataGridView, ByVal parametrosU As String)
        Try
            adaptador = New SqlDataAdapter(parametrosU, cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

        Catch ex As Exception

        End Try

    End Sub


    Public Sub llenarDatagridviewAgregacion(ByVal dgv As DataGridView, ByVal parametrosU As String)
        Try
            adaptador = New SqlDataAdapter(parametrosU, cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt

        Catch ex As Exception

        End Try

    End Sub

    Public Function consultarExistencia(ByVal parametros As String) As Boolean
        Dim aux As Boolean = False
        Try
            cmd = New SqlCommand(" Select * From INFORMATION_SCHEMA.TABLES Where TABLE_NAME Like '" + parametros + "'", cn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                aux = True
                dr.Close()
            End If
            cmd.Dispose()


        Catch ex As Exception

            MessageBox.Show("ERROR AL COMPROBAR LA EXISTENCIA DE LA TABLA")

        End Try
        dr.Close()
        cmd.Dispose()


        Return aux

    End Function

    Function cantidadTablasEnBD() As Integer
        Dim valor As Integer
        Try
            cmd = New SqlCommand("SELECT COUNT(TABLE_NAME) FROM INFORMATION_SCHEMA.TABLES", cn)
            dr = cmd.ExecuteReader
            dr.Read()
            valor = Convert.ToInt32(dr(0).ToString)
            dr.Close()
        Catch ex As Exception
            dr.Close()
        End Try

        Return valor
    End Function

    Function AridadTabla(ByVal tabla1 As String) As String
        Dim resultado As String
        Try
            cmd = New SqlCommand("SELECT COUNT(*) FROM information_schema.columns WHERE table_name = '" + tabla1 + "'", cn)
            dr = cmd.ExecuteReader
            dr.Read()
            resultado = dr(0).ToString
            dr.Close()
        Catch ex As Exception
            dr.Close()

        End Try
        dr.Close()
        Return resultado
    End Function

    Function obtenerArregloTablasEnBase() As String()
        Dim cantTablas As Integer = cantidadTablasEnBD()
        Dim arregloTablas(cantTablas) As String
        Dim posicion As Integer = 0

        Try
            cmd = New SqlCommand("SELECT * FROM information_schema.tables", cn)
            dr = cmd.ExecuteReader

            While dr.Read()
                arregloTablas(posicion) = dr(2).ToString
                Debug.WriteLine(dr(2).ToString)
                posicion = posicion + 1
            End While
            dr.Close()
        Catch ex As Exception
            dr.Close()

        End Try
        Return arregloTablas

    End Function


    Function listaAtributos(ByVal nombreTabla As String) As String()
        Dim aridad As Integer = AridadTabla(nombreTabla)
        Dim arregloAtributos(aridad) As String
        Dim posicion As Integer = 0

        Try
            cmd = New SqlCommand("SELECT * FROM information_schema.columns WHERE table_name = '" + nombreTabla + "'", cn)
            dr = cmd.ExecuteReader

            While dr.Read()
                arregloAtributos(posicion) = dr(7).ToString
                posicion = posicion + 1
                'Debug.WriteLine(dr(7).ToString)
            End While
            dr.Close()

        Catch ex As Exception
            dr.Close()

        End Try
        Return arregloAtributos

    End Function

    Function comparacionAtributos(ByVal atributo1 As String, ByVal atributo2 As String) As Boolean
        If (atributo1 = atributo2) Then

            Return True
        Else
            Return False

        End If
    End Function


End Module
