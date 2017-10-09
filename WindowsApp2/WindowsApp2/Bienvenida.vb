Public Class Bienvenida

    Private Sub Agregacio_Click(sender As Object, e As EventArgs) Handles Agregacio.Click
        Agregacion.Show()





    End Sub

    Private Sub Seleccion_Click(sender As Object, e As EventArgs) Handles Seleccion.Click
        seleccionVentana.Show()

    End Sub

    Private Sub Proyección_Click(sender As Object, e As EventArgs) Handles Proyección_btn.Click
        proyeccion.Show()

    End Sub

    Private Sub Unión_Click(sender As Object, e As EventArgs) Handles Unión.Click
        union.Show()

    End Sub

    Private Sub Division_Click(sender As Object, e As EventArgs) Handles DivisionBtn.Click
        Division.Show()


    End Sub

    Private Sub Diferencia_de_Conjuntos_Click(sender As Object, e As EventArgs) Handles Diferencia_de_Conjuntos_btn.Click
        Diferencia_de_conjuntos.Show()
    End Sub

    Private Sub Producto_Cartesiano_Click(sender As Object, e As EventArgs) Handles Producto_Cartesiano_btn.Click
        producto_cartesiano.Show()


    End Sub

    Private Sub Concatenacion_natural_Click(sender As Object, e As EventArgs) Handles Concatenacion_natural.Click
        concatenacion_natural__natural_join_.Show()



    End Sub

    Private Sub Concatenacion_Click(sender As Object, e As EventArgs) Handles Concatenacion.Click
        Concatenacion__join_.Show()

    End Sub

    Private Sub Interseccion_Click(sender As Object, e As EventArgs) Handles Interseccion.Click
        Form4.Show()


    End Sub

    Private Sub Agrupación_Click(sender As Object, e As EventArgs) Handles Agrupación.Click
        Agrupacion.Show()


    End Sub

    Private Sub Renombrar_Click(sender As Object, e As EventArgs) Handles Renombrar.Click
        Renombrar_una_relacion_y_sus_atributos.Show()




    End Sub

    Private Sub Conectar_Click(sender As Object, e As EventArgs) Handles Conectar.Click
        abrirConexion()
    End Sub

    Private Sub tablasPermanentes_Click(sender As Object, e As EventArgs) Handles tablasPermanentes.Click

    End Sub
End Class