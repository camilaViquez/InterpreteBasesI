Public Class Agregacion

    Public nombre_tabla1
    Public atributo
    Public operacionR
    Public nuevo_nombre
    Public valores
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nombre_tabla1 = Nombre_Tabla.Text

        operacionR = operaciones.Text
        nuevo_nombre = resultado.Text


        valores = "select  " + operacionR + " from " + nombre_tabla1
        'valoresA = " π " + "(" + nombre_tabla + ")"
        SQL_Label.Text = valores
        If (True) Then

        End If
        llenarDatagridviewAgregacion(DataGridView2, valores)
    End Sub
End Class