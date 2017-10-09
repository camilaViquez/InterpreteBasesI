Public Class producto_cartesiano
    Public valores
    Public valoresA
    Public nombre_tabla1
    Public Nombre_tabla2
    Public nombre_nuevo
    Public existe, existe2 As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nameNewT, atributoIgual As String
        Dim existe1Aux, existe2Aux As Boolean
        DataGridView2.DataSource = "null"
        nombre_tabla1 = p.Text
        Nombre_tabla2 = p1.Text
        nombre_nuevo = resultado.Text
        Dim listaNombreAtributos1, listaNombreAtributos2 As String()

        valores = "select * from " + nombre_tabla1 + "," + Nombre_tabla2
        valoresA = nombre_tabla1 + " X " + Nombre_tabla2
        SQL_Label.Text = valores
        Algebra_label.Text = valoresA
        existe = consultarExistencia(nombre_tabla1)
        existe2 = consultarExistencia(Nombre_tabla2)
        existe1Aux = consultarExistenciaTemporal(nombre_tabla1)
        existe2Aux = consultarExistenciaTemporal(Nombre_tabla2)

        Dim nomt1, nomt2, atributos As String
        Dim aridadT1, aridadT2 As String
        nomt1 = nombre_tabla1
        nomt2 = Nombre_tabla2
        Dim cont As Integer = 0

        If existe2Aux Then
            nomt2 = "#" + nomt2
            listaNombreAtributos1 = listaAtributosTemporalNombres(Nombre_tabla2)
            aridadT2 = AridadTablaTemporal(Nombre_tabla2)
        End If

        If existe1Aux Then
            nomt1 = "#" + nomt1
            aridadT2 = AridadTablaTemporal(nombre_tabla1)
            listaNombreAtributos2 = listaAtributosTemporalNombres(nombre_tabla1)
        End If

        If existe Then
            listaNombreAtributos1 = listaAtributosNombre(nombre_tabla1)
            aridadT1 = AridadTabla(nombre_tabla1)
        End If

        If existe2 Then
            listaNombreAtributos2 = listaAtributosNombre(Nombre_tabla2)
            aridadT2 = AridadTabla(Nombre_tabla2)
        End If


        Dim cont1 As Integer = 0
        Dim v As Boolean
        While cont < aridadT1
            cont1 = 0
            While cont1 < aridadT2
                Debug.WriteLine(aridadT2)
                Debug.WriteLine(cont1)
                v = comparacionAtributos(listaNombreAtributos1(cont), listaNombreAtributos2(cont1))
                If v Then
                    atributoIgual = listaNombreAtributos2(cont1)
                    '  atributos = atributos + nomt1 + "." + listaNombreAtributos2(cont) + ","
                End If

                cont1 = cont1 + 1
            End While

            cont = cont + 1

        End While
        cont = 0

        While cont < aridadT1
            If listaNombreAtributos1(cont) = atributoIgual Then
                If (cont = aridadT1 - 1) Then
                    atributos = atributos + nomt1 + "." + atributoIgual
                End If

                If (cont <> aridadT1 - 1) Then
                    atributos = atributos + atributoIgual + ","
                End If
                cont = cont + 1
            End If
            If listaNombreAtributos1(cont) <> atributoIgual Then
                If (cont = aridadT1 - 1) Then
                    atributos = atributos + listaNombreAtributos1(cont)
                End If

                If (cont <> aridadT1 - 1) Then
                    atributos = atributos + listaNombreAtributos1(cont) + ","
                End If

                cont = cont + 1

            End If


        End While
        cont = 0

        While cont < aridadT2
            If listaNombreAtributos2(cont) = atributoIgual Then

                cont = cont + 1
            End If
            If listaNombreAtributos2(cont) <> atributoIgual Then
                If (cont = aridadT2 - 1) Then
                    atributos = atributos + listaNombreAtributos2(cont)
                End If

                If (cont <> aridadT2 - 1) Then
                    atributos = atributos + listaNombreAtributos2(cont) + ","
                End If

                cont = cont + 1

            End If
        End While

        MessageBox.Show(atributos)

        valores = "select * from " + nomt1 + "," + nomt2
        Debug.WriteLine(valores)
        If existe = False And existe1Aux = False Then
            MessageBox.Show("No existe la tabla " + nombre_tabla1)
        End If

        If existe2 = False And existe2Aux = False Then
            MessageBox.Show("No existe la tabla " + Nombre_tabla2)
        End If

        Debug.WriteLine((existe Or existe2).ToString)
        Debug.WriteLine((existe1Aux Or existe2Aux).ToString)

        If ((existe Or existe1Aux) And (existe2 Or existe2Aux)) Then
            llenarDatagridviewCartesiano(DataGridView2, valores)

        End If

        If (nombre_nuevo = "") Then
            MessageBox.Show("No se guarda la consulta debido a que no ingreso nombre")

        End If




        If (nombre_nuevo <> "") Then
            Dim comandoTablaT As String
            comandoTablaT = "select " + atributos + " into #" + nombre_nuevo + " from " + nomt1 + "," + nomt2
            crearTablaTemporal(comandoTablaT)

        End If



    End Sub
End Class