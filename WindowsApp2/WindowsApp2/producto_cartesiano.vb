Public Class producto_cartesiano
    Public valores
    Public valoresA
    Public nombre_tabla1
    Public Nombre_tabla2
    Public nombre_nuevo
    Public existe, existe2 As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView2.DataSource = "null"
        nombre_tabla1 = p.Text
        Nombre_tabla2 = p1.Text
        nombre_nuevo = p2.Text
        If nombre_nuevo = "" Then
            nombre_nuevo = "a"

        End If

        valores = "select * from " + nombre_tabla1 + "," + Nombre_tabla2 + " as " + nombre_nuevo
        valoresA = nombre_tabla1 + " X " + Nombre_tabla2
        SQL_Label.Text = valores
        Algebra_label.Text = valoresA
        existe = consultarExistencia(nombre_tabla1)
        existe2 = consultarExistencia(Nombre_tabla2)

        If existe = False Then
            MessageBox.Show("No existe la tabla " + nombre_tabla1)
        End If

        If existe2 = False Then
            MessageBox.Show("No existe la tabla " + Nombre_tabla2)
        End If

        If existe And existe2 Then
            llenarDatagridviewCartesiano(DataGridView2, valores)
        Else


        End If

    End Sub
End Class