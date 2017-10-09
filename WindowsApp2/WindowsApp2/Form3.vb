Public Class union

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

        Dim nombre_tabla1Aux, nombreTabla2Aux, atributosIguales As String
        Dim aridadT1, aridadT2 As Integer
        Dim existe1, existe2, existeResultado, existe1Aux, existe2Aux As Boolean
        Dim nombreResultado, comandoCreacionTemporal, nombreTem As String
        Dim TipoAtributoComparacion As Boolean
        Dim aridadAux As Integer
        TipoAtributoComparacion = False


        aridadAux = 0
        nombreTem = NmbreResultadoT.Text
        nombreTabla2Aux = Nombre_tabla2
        nombre_tabla1Aux = nombre_tabla1

        nombreResultado = NmbreResultadoT.Text
        Dim tiposAtributosT1, tiposAtributosT2, NombreAtributosT1, nombreAtributosT2 As String()

        existe1 = consultarExistencia(nombre_tabla1)
        existe2 = consultarExistencia(Nombre_tabla2)
        existe1Aux = consultarExistenciaTemporal(nombre_tabla1)
        existe2Aux = consultarExistenciaTemporal(Nombre_tabla2)




        Debug.Write(aridadT1)
        Debug.Write(TipoAtributoComparacion)

        If (existe1 Or existe2 Or existe1Aux Or existe2Aux) Then
            existeResultado = True
        Else
            existeResultado = False
        End If


        If (existe1) Then
            tiposAtributosT1 = listaAtributos(nombre_tabla1)
            aridadT1 = AridadTabla(nombre_tabla1)
        End If
        If (existe1Aux) Then
            tiposAtributosT1 = listaAtributosTemporal(nombre_tabla1)

            nombre_tabla1Aux = "#" + nombre_tabla1
            Debug.WriteLine("Temporal 1")
            aridadT1 = AridadTablaTemporal(nombre_tabla1)
            MessageBox.Show(aridadT1.ToString)
            NombreAtributosT1 = listaAtributosTemporalNombres(nombre_tabla1)

        End If



        If (existe2) Then

            aridadT2 = AridadTabla(Nombre_tabla2)
            tiposAtributosT2 = listaAtributos(Nombre_tabla2)

        End If

        If (existe2Aux) Then
            Debug.WriteLine("99999999999999999999999999999999999999999999")
            tiposAtributosT2 = listaAtributosTemporal(Nombre_tabla2)
            Debug.WriteLine("Temporal 2")
            aridadT2 = AridadTablaTemporal(Nombre_tabla2)
            MessageBox.Show(aridadT2.ToString)
            nombreTabla2Aux = "#" + Nombre_tabla2
            nombreAtributosT2 = listaAtributosTemporalNombres(Nombre_tabla2)
        End If



        While (TipoAtributoComparacion = False And aridadAux < aridadT1)
            Debug.WriteLine("WHILE COMPARACION")
            TipoAtributoComparacion = comparacionAtributos(tiposAtributosT1(aridadAux), tiposAtributosT2(aridadAux))
            If TipoAtributoComparacion Then

                If (aridadAux = (aridadT1 - 1)) Then
                    atributosIguales = atributosIguales + NombreAtributosT1(aridadAux) + ","
                Else
                    atributosIguales = atributosIguales + nombreAtributosT2(aridadAux)
                    Debug.WriteLine(nombreAtributosT2(aridadAux))
                End If


            End If
            Debug.WriteLine(aridadAux.ToString)
            Debug.WriteLine(tiposAtributosT1(aridadAux))
            Debug.WriteLine(tiposAtributosT2(aridadAux))
            Debug.WriteLine(TipoAtributoComparacion.ToString)
            aridadAux = aridadAux + 1


        End While



        valores = "select " + atributosIguales + " from " + nombre_tabla1Aux + " union " + "select " + atributosIguales + " from " + nombreTabla2Aux

        valoresA = nombre_tabla1 + " U " + Nombre_tabla2
        SQL_Label.Text = valores  ' "select * from " + nombre_tabla1 + " union " + "select * from " + Nombre_tabla2
        Algebra_label.Text = valoresA
        aridadT1 = aridadT1 - 1
        MessageBox.Show(aridadT1.ToString + "==================" + aridadT2.ToString)

        If ((aridadT1 = aridadT2) And (existe1 Or existe1Aux) And (existe2 Or existe2Aux)) Then
            MessageBox.Show("entro llenar")
            llenarDatagridviewUnion(DataGridView2, valores)
            MessageBox.Show("entro llenar")
        Else

            If (aridadT1 <> aridadT2) Then
                MessageBox.Show("La aridad de las tablas son diferentes, La tabla " + nombre_tabla1 + " tiene aridad: " + aridadT1.ToString + ", la tabla " + Nombre_tabla2 + " tiene aridad " + aridadT2.ToString)
            End If

            If ((existe2 Or existe2Aux) = False) Then
                MessageBox.Show("No existe la tabla: " + Nombre_tabla2)
            End If

            If ((existe1Aux Or existe1) = False) Then
                MessageBox.Show("No existe la tabla: " + nombre_tabla1)
            End If

            If (TipoAtributoComparacion = False) Then
                MessageBox.Show("Tipos de atributos diferentes")
            End If
        End If
        If (nombreResultado = "") Then

                MessageBox.Show("no se guarda la consulta, ya que no se esta ingresando un valor ")
            End If
        If (nombreResultado <> "") Then


            comandoCreacionTemporal = "SELECT " + atributosIguales + " into #" + nombreResultado + " from " + nombre_tabla1Aux + " union " + "SELECT " + atributosIguales + " from " + nombreTabla2Aux

            crearTablaTemporal(comandoCreacionTemporal)


        End If


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles NmbreResultadoT.TextChanged

    End Sub
End Class