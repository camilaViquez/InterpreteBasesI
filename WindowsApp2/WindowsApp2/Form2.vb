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
        DataGridView2.DataSource = "null"
        nombre_tabla = p.Text
        valores = "Select * from " + nombre_tabla
        valoresA = " π " + "(" + nombre_tabla + ")"
        SQL_Label.Text = valores
        Algebra_label.Text = valoresA
        prueba = consultarExistencia(nombre_tabla)

        If prueba Then
            llenarDatagridviewProyeccion(DataGridView2, valores)
        Else
            MessageBox.Show("Error la tabla no existe")

        End If



    End Sub

    Private Sub SQL_Label_Click(sender As Object, e As EventArgs) Handles SQL_Label.Click

    End Sub
End Class