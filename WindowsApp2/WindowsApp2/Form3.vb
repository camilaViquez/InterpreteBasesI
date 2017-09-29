Public Class Form3

    Public valores
    Public valoresA
    Public nombre_tabla1
    Public Nombre_tabla2

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nombre_tabla1 = p.Text
        Nombre_tabla2 = p1.Text


        valores = "select * from " + nombre_tabla1 + " union " + "select * from " + Nombre_tabla2
        'valoresA = " π " + "(" + nombre_tabla + ")"
        SQL_Label.Text = valores

        llenarDatagridviewUnion(DataGridView2, valores)
    End Sub
End Class