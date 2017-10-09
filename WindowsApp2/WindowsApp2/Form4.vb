Public Class Form4

    Public valores
    Public valoresA
    Public nombre_tabla1
    Public Nombre_tabla2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        nombre_tabla1 = p.Text
        Nombre_tabla2 = p1.Text
        Dim aridadT1, aridadT2 As Integer
        Dim existe1, existe2, existe1T, existe2T As Boolean
        Dim nombreResultado, nombre_tabla1Aux, nombre_tabla2Aux As String
        Dim TipoAtributoComparacion As Boolean
        Dim aridadAux As Integer
        TipoAtributoComparacion = False

        aridadT1 = AridadTabla(nombre_tabla1)
        aridadT2 = AridadTabla(Nombre_tabla2)
        aridadAux = 0

        nombreResultado = NmbreResultadoT.Text
        Dim tiposAtributosT1, tiposAtributosT2 As String()

        existe1 = consultarExistencia(nombre_tabla1)
        existe2 = consultarExistencia(Nombre_tabla2)
        existe1T = consultarExistenciaTemporal(nombre_tabla1)
        existe2T = consultarExistenciaTemporal(Nombre_tabla2)


        nombre_tabla1Aux = nombre_tabla1
        nombre_tabla2Aux = Nombre_tabla2

        If (existe1T) Then
            nombre_tabla1Aux = "#" + nombre_tabla1Aux
            tiposAtributosT1 = listaAtributosTemporal(nombre_tabla1)
            aridadT1 = AridadTablaTemporal(nombre_tabla1)
        End If
        If (existe2T) Then
            nombre_tabla2Aux = "#" + nombre_tabla2Aux
            tiposAtributosT2 = listaAtributosTemporal(Nombre_tabla2)
            aridadT2 = AridadTablaTemporal(Nombre_tabla2)
        End If
        If (existe1) Then
            tiposAtributosT1 = listaAtributos(nombre_tabla1)
            aridadT1 = AridadTabla(nombre_tabla1)
        End If

        If (existe2) Then
            tiposAtributosT2 = listaAtributos(Nombre_tabla2)
            aridadT2 = AridadTabla(Nombre_tabla2)
        End If


        aridadT1 = aridadT1 - 1
        Debug.Write(aridadT1)
        Debug.Write(TipoAtributoComparacion)

        While (TipoAtributoComparacion = False And aridadAux < aridadT1)
            TipoAtributoComparacion = comparacionAtributos(tiposAtributosT1(aridadAux), tiposAtributosT2(aridadAux))

            Debug.WriteLine(aridadAux.ToString)
            Debug.WriteLine(tiposAtributosT1(aridadAux))
            Debug.WriteLine(tiposAtributosT2(aridadAux))
            Debug.WriteLine(TipoAtributoComparacion.ToString)
            aridadAux = aridadAux + 1


        End While



        valores = "select * from " + nombre_tabla1Aux + " intersect " + "select * from " + nombre_tabla2Aux
        valoresA = nombre_tabla1 + " ∩ " + Nombre_tabla2
        SQL_Label.Text = valores
        Algebra_label.Text = valoresA


        If ((aridadT1 = aridadT2) And (existe1 Or existe1T) And (existe2 Or existe2T) And TipoAtributoComparacion) Then
            llenarDatagridviewUnion(DataGridView2, valores)

        Else

            If (aridadT1 = aridadT2) Then
                MessageBox.Show("La aridad de las tablas son diferentes, La tabla " + nombre_tabla1 + " tiene aridad: " + aridadT1.ToString + ", la tabla " + Nombre_tabla2 + " tiene aridad " + aridadT2.ToString)
            End If

            If (existe2 = False) Then
                MessageBox.Show("No existe la tabla: " + Nombre_tabla2)
            End If

            If (existe1 = False) Then
                MessageBox.Show("No existe la tabla: " + nombre_tabla1)
            End If

            If (TipoAtributoComparacion = True) Then
                MessageBox.Show("Tipos de atributos diferentes")
            End If
        End If
        If (nombreResultado = "") Then

            MessageBox.Show("no se guarda la tabla")
        End If
        If (nombreResultado <> "") Then
            Dim comandoNewTable As String
            comandoNewTable = "select * into #" + nombreResultado + " from " + nombre_tabla1Aux + " intersect " + "select * from " + nombre_tabla2Aux
            MessageBox.Show(comandoNewTable)

            crearTablaTemporal(comandoNewTable)
            MessageBox.Show("Nueva tabla guardada")

        End If



    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class