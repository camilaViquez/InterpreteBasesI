Public Class proyeccion
    Public valores
    Public valoresA
    Public nombre_tabla
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub proyeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nombre_tabla = p.Text
        valores = "Select * from " + nombre_tabla
        valoresA = " π " + "(" + nombre_tabla + ")"
        SQL_Label.Text = valores
        llenarDatagridviewProyeccion(DataGridView2, valores)


    End Sub
End Class