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

        'Select * from  EMPLEADOS join CLIENTES on( EMPLEADOS.id_canton = CLIENTES.id_canton)
        valores = " Select *from " + tab1 + " join " + tab2 + " on " + tab1 + "." + pred + " = " + tab2 + "." + pred
        LabelSQL.Text = " Select *from " + tab1 + " join " + tab2 + " on " + tab1 + "." + pred + " = " + tab2 + "." + pred
        LabelA.Text = " π " + pred + "(" + tab1 + ")" + " U " + " π " + pred + "(" + tab2 + ")"
        'MessageBox.Show(valoresU)
        'SqlCommand Command() = New SqlCommand("select count(*) from" + x, cn)
        llenarDatagridviewConcatenacion(DataGridView2, valores)





    End Sub
End Class