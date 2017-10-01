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

    Sub abrirConexion()
        Try
            cn = New SqlConnection("Data Source=LEO;Initial Catalog=Ventas;Integrated Security=True")
            cn.Open()

            MessageBox.Show("Se realizo la coneccion con exito")

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
            MessageBox.Show("No se lleno el datagridView debido a: " + ex.ToString)

        End Try
    End Sub

    Sub llenarDatagridviewProyeccion(ByVal dgv As DataGridView, ByVal parametros As String)

        Try


            adaptador = New SqlDataAdapter(parametros, cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt



        Catch ex As Exception
            MessageBox.Show("No se lleno el datagridView debido a: " + ex.ToString)

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
            End If
            dr.Close()



        Catch ex As Exception

            MessageBox.Show("ERROR AL COMPROBAR LA EXISTENCIA DE LA TABLA")

        End Try

        Return aux

    End Function




End Module
