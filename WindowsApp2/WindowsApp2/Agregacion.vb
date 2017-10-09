Public Class Agregacion

    Public nombre_tabla1
    Public atributo
    Public operacionR
    Public nuevo_nombre
    Public valores
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nombre_tabla1 = Nombre_Tabla.Text
        Dim existe, existeT As Boolean
        operacionR = operaciones.Text
        nuevo_nombre = resultado.Text
        Dim nomAux As String
        existe = consultarExistencia(nombre_tabla1)
        existeT = consultarExistenciaTemporal(nombre_tabla1)
        nomAux = nombre_tabla1

        If (existeT) Then
            nomAux = "#" + nomAux
        End If
        valores = "select  " + operacionR + " from " + nomAux
        'valoresA = " π " + "(" + nombre_tabla + ")"
        SQL_Label.Text = valores

        If (existeT Or existe) Then
            llenarDatagridviewAgregacion(DataGridView2, valores)
        End If

        If ((existeT Or existe) = False) Then
            MessageBox.Show("Error la tabla no existe " + nombre_tabla1)
        End If

        If (nuevo_nombre = "") Then

        End If

        If (nuevo_nombre <> "") Then
            Dim comandoCreacion As String
            comandoCreacion = "select  " + operacionR + " into #" + nuevo_nombre + " from " + nomAux

            crearTablaTemporalAgregacion(comandoCreacion)
        End If
    End Sub
End Class