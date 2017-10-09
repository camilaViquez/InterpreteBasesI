Imports System.Data.SqlClient
Imports System.Data.Sql



Module Module1
    Public cn As SqlConnection
    Public adaptador As SqlDataAdapter
    Public dt As DataTable
    Public x

    Sub abrirConexion()
        Try
            cn = New SqlConnection("Data Source=MATILDA;Initial Catalog=Ventas;Integrated Security=True")
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


End Module
