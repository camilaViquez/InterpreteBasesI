Public Class Agrupacion


    Public nombre_tabla1
    Public atributo
    Public operacionR
    Public nuevo_nombre
    Public valores

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nombre_tabla1 = Nombre_Tabla.Text
        atributo = Atributos.Text
        operacionR = Operacion.Text 
        nuevo_nombre =  Nueva_tabla.Text

        valores = "select  " + operacionR + " from " + nombre_tabla1 + " group by " + atributo

        'valoresA = " π " + "(" + nombre_tabla + ")"
        SQL_Label.Text = valores

        llenarDatagridviewAgrupacion(DataGridView2, valores)
    End Sub
End Class