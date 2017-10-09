Public Class Concatenacion__join_
    Public tab1
    Public tab2
    Public pred
    Public valores
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles predicado.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tab1 = tabla1.Text
        tab2 = tabla2.Text
        pred = predicado.Text
        Dim NewTable As String
        Dim ConsultaExisteT1, ConsultaExisteT2, ConsultaExisteTemp1, ConsultaExisteTemp2 As Boolean
        NewTable = tablaR.Text

        ConsultaExisteT1 = consultarExistencia(tab1)
        ConsultaExisteT2 = consultarExistencia(tab2)
        ConsultaExisteTemp1 = consultarExistenciaTemporal(tab1)
        ConsultaExisteTemp2 = consultarExistenciaTemporal(tab2)
        Dim listaNombreAtributos1, listaNombreAtributos2 As String()
        Dim nomt1, nomt2 As String
        Dim aridadT1, aridadT2 As Integer
        nomt1 = tab1
        nomt2 = tab2

        If ConsultaExisteTemp1 Then
            nomt1 = "#" + nomt1
            listaNombreAtributos1 = listaAtributosTemporalNombres(tab1)
            aridadT1 = AridadTablaTemporal(tab1)
        End If

        If ConsultaExisteTemp2 Then
            nomt2 = "#" + nomt2
            listaNombreAtributos2 = listaAtributosTemporalNombres(tab2)
            aridadT2 = AridadTablaTemporal(tab2)
        End If

        If ConsultaExisteT1 Then
            aridadT1 = AridadTabla(tab1)
            listaNombreAtributos1 = listaAtributosNombre(tab1)
        End If

        If ConsultaExisteT2 Then
            aridadT2 = AridadTabla(tab2)
            listaNombreAtributos2 = listaAtributosNombre(tab2)
        End If

        valores = " Select * from " + tab1 + " join " + tab2 + " on " + nomt1 + "." + pred + " = " + nomt2 + "." + pred
        SQL_Label.Text = " Select * from " + tab1 + " join " + tab2 + " on " + tab1 + "." + pred + " = " + tab2 + "." + pred
        Algebra_label.Text = " π " + pred + "(" + tab1 + ")" + " U " + " π " + pred + "(" + tab2 + ")"

        Dim cont As Integer = 0
        Dim cont1 As Integer = 0
        Dim atributoIgual As String
        Dim v As Boolean
        Dim atributos As String
        While cont < aridadT1
            cont1 = 0
            While cont1 < aridadT2
                Debug.WriteLine(aridadT2)
                Debug.WriteLine(cont1)
                v = comparacionAtributos(listaNombreAtributos1(cont), listaNombreAtributos2(cont1))
                If v Then
                    atributoIgual = listaNombreAtributos2(cont1)
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
                    atributos = atributos + nomt1 + "." + atributoIgual + ","
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
        atributos = atributos + ","
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

        If ((ConsultaExisteT1 Or ConsultaExisteTemp1) And (ConsultaExisteT2 Or ConsultaExisteTemp2)) Then


            llenarDatagridview(DataGridView2, valores)
        Else
            If ((ConsultaExisteTemp1 Or ConsultaExisteT1) = False) Then
                MessageBox.Show("Error la tabla: " + tab1 + " no existe")
            End If

            If ((ConsultaExisteT2 Or ConsultaExisteTemp2) = False) Then
                MessageBox.Show("Error la tabla: " + tab2 + " no existe")
            End If
        End If

        If (NewTable = "") Then

        End If

        If (NewTable <> "") Then
            Dim comandoTemporal As String
            comandoTemporal = " Select " + atributos + " into " + " #" + NewTable + " from " + tab1 + " join " + tab2 + " on " + nomt1 + "." + pred + " = " + nomt2 + "." + pred
            crearTablaTemporal(comandoTemporal)
        End If


    End Sub
End Class