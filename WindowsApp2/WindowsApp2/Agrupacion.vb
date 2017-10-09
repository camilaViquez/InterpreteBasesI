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
        Dim existeT, existe As Boolean
        Dim nomt1, OperacionRealizar As String
        nomt1 = nombre_tabla1
        existeT = consultarExistenciaTemporal(nombre_tabla1)
        existe = consultarExistencia(nombre_tabla1)
        OperacionRealizar = Operacion.Text

        If existeT Then
            nomt1 = "#" + nomt1
        End If

        valores = "select  " + operacionR + " from " + nombre_tabla1 + " group by " + atributo
        'valoresA = " π " + "(" + nombre_tabla + ")"
        SQL_Label.Text = valores

        If (existeT Or existe) Then
            llenarDatagridviewAgrupacion(DataGridView2, valores)
        End If

        If ((existeT Or existe) = False) Then
            MessageBox.Show("Error la tabla no existe " + nombre_tabla1)
        End If

        If (nuevo_nombre = "") Then

        End If

        If (nuevo_nombre <> "") Then
            Dim comandoCreacion, aux As String
            Dim operacionRenombrar As String()
            Dim c As Integer = 0

            operacionRenombrar = listaNuevosAtributosConcatenacion(operacionR)
            Dim cc As Integer = operacionRenombrar.Length
            MessageBox.Show(cc)
            MessageBox.Show(operacionRenombrar(0))
            While (c < cc)
                MessageBox.Show((c < cc).ToString)
                MessageBox.Show("SS" + c.ToString)
                If (c = operacionRenombrar.Length - 1) Then
                    MessageBox.Show("lllllllllllllllllllllllllllllllllllll")
                    aux = operacionRenombrar(c) + " as " + "Atributo" + c.ToString

                End If

                If (c <> operacionRenombrar.Length - 1) Then
                    aux = aux + " as " + "Atributo" + c.ToString + ","

                End If
                MessageBox.Show("SSfghjklkjhgfdsdfghjkhgfghjk" + c.ToString)
                c = c + 1
                MessageBox.Show((c < cc).ToString)
            End While


            comandoCreacion = "select  " + aux + " into #" + nuevo_nombre + " from " + nomt1 + " group by " + atributo
            crearTablaTemporalAgregacion(comandoCreacion)


        End If




    End Sub
End Class