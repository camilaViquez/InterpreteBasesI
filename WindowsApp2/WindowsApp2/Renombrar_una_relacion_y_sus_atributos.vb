Public Class Renombrar_una_relacion_y_sus_atributos

    Public valores
    Public valoresA
    Public nombre_tabla
    Public atributos

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nombre_tabla = t1.Text
        atributos = NewNameAtributos.Text
        Dim aridadT1 As Integer
        Dim existe1 As Boolean
        Dim AtributosAux As String = ""
        Dim listaNuevosAtributos As String()

        Dim TipoAtributoComparacion As Boolean
        Dim c As Integer
        existe1 = consultarExistencia(nombre_tabla)
        Dim cantidadIguales As String = 0
        TipoAtributoComparacion = True
        c = 0
        aridadT1 = AridadTabla(nombre_tabla)


        listaNuevosAtributos = listaNuevosAtributosConcatenacion(atributos)


        If listaNuevosAtributos.Length = aridadT1 Then

            If (existe1) Then

                AtributosAux = NuevosAtributosRenombramientos(nombre_tabla, listaNuevosAtributos)
                valores = "SELECT " + AtributosAux + " FROM " + nombre_tabla


                llenarDatagridview(DataGridView2, valores)

            Else

                MessageBox.Show("No existe la tabla: " + nombre_tabla)

            End If


        Else
            MessageBox.Show("Error no se está brindando la cantidad de atributos necesarios")

        End If




        SQL_Label.Text = valores
        Algebra_label.Text = " ρ " + atributos + " ( " + nombre_tabla + " ) "



    End Sub
End Class