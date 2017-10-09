Public Class concatenacion_natural__natural_join_

    Public valores
    Public valoresA
    Public nombre_tabla1
    Public Nombre_tabla2


    Private Sub Algebra_Relacional_Enter(sender As Object, e As EventArgs) Handles Algebra_Relacional.Enter


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        nombre_tabla1 = T1.Text
        Nombre_tabla2 = T2.Text
        Dim aridadT1, aridadT2 As Integer
        Dim existe1, existe2, comparacionAux, existe1T, existe2T As Boolean
        Dim nombreResultado As String
        Dim TipoAtributoComparacion As Boolean
        Dim aridadAux, cont, c, contAux As Integer
        Dim pred As String
        Dim cantidadIguales As String = 0
        TipoAtributoComparacion = True
        comparacionAux = False
        cont = 0
        c = 0
        contAux = 0
        aridadT1 = AridadTabla(nombre_tabla1)
        aridadT2 = AridadTabla(Nombre_tabla2)
        aridadAux = 0
        pred = ""

        nombreResultado = nuevaTabla.Text
        Dim tiposAtributosT1(aridadT1), tiposAtributosT2(aridadT2), r1(aridadT2) As String
        existe1 = consultarExistencia(nombre_tabla1)
        existe2 = consultarExistencia(Nombre_tabla2)
        existe1T = consultarExistenciaTemporal(nombre_tabla1)
        existe2T = consultarExistenciaTemporal(Nombre_tabla2)
        Dim nomt1, nomt2 As String
        nomt1 = nombre_tabla1
        nomt2 = Nombre_tabla2
        If existe1 Then
            tiposAtributosT1 = listaAtributosNombre(nombre_tabla1)
            aridadT1 = AridadTabla(nombre_tabla1)
        End If

        If existe2 Then
            tiposAtributosT2 = listaAtributosNombre(Nombre_tabla2)
            aridadT2 = AridadTabla(Nombre_tabla2)
        End If

        If existe1T Then
            tiposAtributosT1 = listaAtributosTemporalNombres(nombre_tabla1)
            aridadT1 = AridadTablaTemporal(nombre_tabla1)
            nomt1 = "#" + nomt1
        End If

        If existe2T Then
            tiposAtributosT2 = listaAtributosTemporalNombres(Nombre_tabla2)
            aridadT2 = AridadTablaTemporal(Nombre_tabla2)
            nomt2 = "#" + nomt2
        End If


        Debug.Write(aridadT1)
        Debug.Write(TipoAtributoComparacion.ToString)

        While (aridadAux < aridadT1)
            c = 0

            While (aridadT2 > c And comparacionAux <> True)
                TipoAtributoComparacion = False
                TipoAtributoComparacion = comparacionAtributos(tiposAtributosT1(aridadAux), tiposAtributosT2(c))

                Debug.WriteLine(TipoAtributoComparacion.ToString)
                If (TipoAtributoComparacion = True) Then
                    r1(cont) = tiposAtributosT1(aridadAux)
                    cont = cont + 1
                    c = c + 1
                    cantidadIguales = cantidadIguales + 1
                    Debug.WriteLine(aridadAux.ToString)
                    Debug.WriteLine(tiposAtributosT1(aridadAux))
                    Debug.WriteLine(tiposAtributosT2(c))
                    Debug.WriteLine(TipoAtributoComparacion.ToString)
                Else
                    c = c + 1
                End If
            End While
            aridadAux = aridadAux + 1

        End While

        While (cantidadIguales >= contAux)
            Debug.WriteLine(pred)
            '  Debug.WriteLine(r1(contAux).ToString + " cont " + contAux.ToString)
            If (r1(contAux) <> "" And contAux = 0) Then
                pred = pred + nombre_tabla1 + "." + r1(contAux) + " = " + Nombre_tabla2 + "." + r1(contAux)
            End If
            If (r1(contAux) <> "" And contAux <> 0) Then
                pred = pred + " = "
                pred = pred + nombre_tabla1 + "." + r1(contAux) + " = " + Nombre_tabla2 + "." + r1(contAux)

            End If

            contAux = contAux + 1
        End While




        valores = " Select *from " + nombre_tabla1 + " join " + Nombre_tabla2 + " on " + pred
        SQL_Label.Text = " Select * from " + nombre_tabla1 + " join " + Nombre_tabla2 + " on " + pred
        Algebra_label.Text = " π " + " * " + nombre_tabla1 + " ⋈  " + Nombre_tabla2


        cont = 0
        Dim cont1 As Integer = 0
        Dim atributoIgual As String
        Dim v As Boolean
        Dim atributos As String
        While cont < aridadT1
            cont1 = 0
            While cont1 < aridadT2
                Debug.WriteLine(aridadT2)
                Debug.WriteLine(cont1)
                v = comparacionAtributos(tiposAtributosT1(cont), tiposAtributosT2(cont1))
                If v Then
                    atributoIgual = tiposAtributosT2(cont1)
                End If

                cont1 = cont1 + 1
            End While

            cont = cont + 1

        End While
        cont = 0

        While cont < aridadT1
            MessageBox.Show((aridadT1 - 1).ToString + " = " + cont.ToString + atributos)

            If tiposAtributosT1(cont) = atributoIgual Then
                If (cont = (aridadT1 - 1)) Then
                    MessageBox.Show("s____________________________________________s")
                    atributos = atributos + nomt1 + "." + atributoIgual
                End If

                If (cont <> (aridadT1 - 1)) Then
                    MessageBox.Show("ssssssssssssssssssssssssssssssssssssssssss")
                    atributos = atributos + nomt1 + "." + atributoIgual + ","
                End If
                cont = cont + 1
            Else
                If tiposAtributosT1(cont) <> atributoIgual Then
                    If (cont = aridadT1 - 1) Then
                        atributos = atributos + tiposAtributosT1(cont)
                    End If

                    If (cont <> aridadT1 - 1) Then
                        MessageBox.Show("222222222222222222222222222222222222222")
                        atributos = atributos + tiposAtributosT1(cont) + ","
                    End If

                    cont = cont + 1

                End If
            End If

        End While
        cont = 0
        atributos = atributos + ","

        While cont < aridadT2
            MessageBox.Show(atributos)
            If tiposAtributosT2(cont) = atributoIgual Then

                cont = cont + 1
            End If
            If tiposAtributosT2(cont) <> atributoIgual Then

                If (cont = aridadT2 - 1) Then
                    atributos = atributos + tiposAtributosT2(cont)
                End If

                If (cont <> aridadT2 - 1) Then
                    atributos = atributos + tiposAtributosT2(cont) + ","
                End If
                cont = cont + 1

            End If
        End While




        If ((existe1 Or existe1T) And (existe2 Or existe2T)) Then
            llenarDatagridviewUnion(DataGridView2, valores)

        Else

            If ((existe2T Or existe2) = False) Then
                MessageBox.Show("No existe la tabla: " + Nombre_tabla2)
            End If

            If ((existe1T Or existe1) = False) Then
                MessageBox.Show("No existe la tabla: " + nombre_tabla1)
            End If

        End If


        If (nombreResultado = "") Then

            MessageBox.Show("no se guarda la consulta realizada")



        End If
        If nombreResultado <> "" Then

            Dim comandoTemporal As String

            comandoTemporal = " Select " + atributos + " into " + " #" + nombreResultado + " from " + nombre_tabla1 + " join " + Nombre_tabla2 + " on " + pred
            MessageBox.Show(comandoTemporal)
            crearTablaTemporal(comandoTemporal)

        End If


    End Sub



End Class