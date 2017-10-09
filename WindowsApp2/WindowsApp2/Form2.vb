Public Class proyeccion
    Public valores
    Public valoresA
    Public nombre_tabla
    Public prueba As Boolean
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub proyeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pruebaT As Boolean
        Dim nombreAux As String
        DataGridView2.DataSource = "null"
        nombre_tabla = p.Text
        valores = "Select * from " + nombre_tabla
        valoresA = " π " + "(" + nombre_tabla + ")"
        SQL_Label.Text = valores
        Algebra_label.Text = valoresA
        prueba = consultarExistencia(nombre_tabla)
        pruebaT = consultarExistenciaTemporal(nombre_tabla)
        Dim NewTable As String = resultadoNT.Text

        nombreAux = nombre_tabla

        If pruebaT Then
            nombreAux = "#" + nombre_tabla
            valores = "Select * from " + "#" + nombre_tabla
        End If

        If prueba Or pruebaT Then
            llenarDatagridviewProyeccion(DataGridView2, valores)
        Else
            MessageBox.Show("Error la tabla no existe")

        End If


        If (NewTable = "") Then
            MessageBox.Show("La consulta no se guarda ya que no se brindó un nombre para la nueva tabla")

        End If

        If (NewTable <> "" And (prueba Or pruebaT)) Then
            Dim comandoNewT As String = "select * into #" + NewTable + " from " + nombreAux

            crearTablaTemporal(comandoNewT)

        End If


    End Sub

    Private Sub SQL_Label_Click(sender As Object, e As EventArgs) Handles SQL_Label.Click

    End Sub
End Class