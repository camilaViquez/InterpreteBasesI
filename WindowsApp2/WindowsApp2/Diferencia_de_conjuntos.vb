Public Class Diferencia_de_conjuntos

    Public valores
    Public valoresA
    Public nombre_tabla1
    Public Nombre_tabla2

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        nombre_tabla1 = p.Text
        Nombre_tabla2 = p1.Text
        Dim aridadT1, aridadT2 As Integer
        Dim existe1, existe2, existe1Aux, existe2Aux As Boolean
        Dim nombreResultado, nomt1, nomt2, nuevoNom As String
        Dim TipoAtributoComparacion As Boolean
        Dim aridadAux As Integer
        TipoAtributoComparacion = True
        Dim listaNombreAtributos1, listaNombreAtributos2 As String()
        aridadT1 = AridadTabla(nombre_tabla1)
        aridadT2 = AridadTabla(Nombre_tabla2)
        aridadAux = 0
        nuevoNom = NmbreResultadoT.Text
        nomt1 = nombre_tabla1
        nomt2 = Nombre_tabla2
        nombreResultado = NmbreResultadoT.Text
        Dim tiposAtributosT1(aridadT1), tiposAtributosT2(aridadT2), atributos, atributoIgual As String

        existe1 = consultarExistencia(nombre_tabla1)
        existe2 = consultarExistencia(Nombre_tabla2)
        existe1Aux = consultarExistenciaTemporal(nombre_tabla1)
        existe2Aux = consultarExistenciaTemporal(Nombre_tabla2)

        If existe2Aux Then
            nomt2 = "#" + nomt2
            tiposAtributosT1 = listaAtributosTemporal(nombre_tabla1)
            listaNombreAtributos2 = listaAtributosTemporalNombres(Nombre_tabla2)
            aridadT2 = AridadTablaTemporal(Nombre_tabla2)
            MessageBox.Show(aridadT2)
        End If

        If existe1Aux Then
            nomt1 = "#" + nomt1
            tiposAtributosT2 = listaAtributosTemporal(Nombre_tabla2)
            aridadT1 = AridadTablaTemporal(nombre_tabla1)
            MessageBox.Show(aridadT1)
            listaNombreAtributos1 = listaAtributosTemporalNombres(nombre_tabla1)
        End If

        If existe1 Then
            tiposAtributosT1 = listaAtributos(nombre_tabla1)
            listaNombreAtributos1 = listaAtributosNombre(nombre_tabla1)
            aridadT1 = AridadTabla(nombre_tabla1)
        End If

        If existe2 Then
            tiposAtributosT2 = listaAtributos(Nombre_tabla2)
            listaNombreAtributos2 = listaAtributosNombre(Nombre_tabla2)
            aridadT2 = AridadTabla(Nombre_tabla2)
        End If

        Debug.Write(aridadT1)
        Debug.Write(TipoAtributoComparacion)

        While (aridadAux < aridadT1)
            TipoAtributoComparacion = comparacionAtributos(tiposAtributosT1(aridadAux), tiposAtributosT2(aridadAux))
            Debug.WriteLine(aridadAux.ToString)
            Debug.WriteLine(tiposAtributosT1(aridadAux))
            Debug.WriteLine(tiposAtributosT2(aridadAux))
            Debug.WriteLine(TipoAtributoComparacion.ToString)
            aridadAux = aridadAux + 1


        End While



        valores = "select * from " + nombre_tabla1 + " except " + "select * from " + Nombre_tabla2
        valoresA = nombre_tabla1 + " - " + Nombre_tabla2
        SQL_Label.Text = valores
        Algebra_label.Text = valoresA
        valores = "select * from " + nomt1 + " except " + "select * from " + nomt2
        aridadT1 = aridadT1 - 1






        Debug.WriteLine((aridadT1 = aridadT2).ToString + aridadT1.ToString + aridadT2.ToString)
        Debug.WriteLine((existe1 Or existe1Aux).ToString + (existe2 Or existe2Aux).ToString)
        If ((aridadT1 = aridadT2) And (existe1 Or existe1Aux) And (existe2 Or existe2Aux)) Then
            llenarDatagridviewAgregacion(DataGridView2, valores)

        Else

            If (aridadT1 = aridadT2) Then
                MessageBox.Show("La aridad de las tablas son diferentes, La tabla " + nombre_tabla1 + " tiene aridad: " + aridadT1.ToString + ", la tabla " + Nombre_tabla2 + " tiene aridad " + aridadT2.ToString)
            End If

            If ((existe2 Or existe2Aux) = False) Then
                MessageBox.Show("No existe la tabla: " + Nombre_tabla2)
            End If

            If ((existe1 Or existe1Aux) = False) Then
                MessageBox.Show("No existe la tabla: " + nombre_tabla1)
            End If


        End If
        If (nombreResultado = "") Then

            MessageBox.Show("no se guarda la tabla")
        End If
        If (nombreResultado <> "") Then
            Dim comandoNuevaTabla As String = "select * " + "into #" + nuevoNom + " from " + nomt1 + " except " + "select * from " + nomt2
            crearTablaTemporal(comandoNuevaTabla)
            MessageBox.Show("Nueva tabla guardada")

        End If

    End Sub
End Class