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
        Dim ConsultaExisteT1, ConsultaExisteT2 As Boolean

        ConsultaExisteT1 = consultarExistencia(tab1)
        ConsultaExisteT2 = consultarExistencia(tab2)


        valores = " Select *from " + tab1 + " join " + tab2 + " on " + tab1 + "." + pred + " = " + tab2 + "." + pred
        SQL_Label.Text = " Select * from " + tab1 + " join " + tab2 + " on " + tab1 + "." + pred + " = " + tab2 + "." + pred
        Algebra_label.Text = " π " + pred + "(" + tab1 + ")" + " U " + " π " + pred + "(" + tab2 + ")"

        If (ConsultaExisteT1 And ConsultaExisteT2) Then


            llenarDatagridview(DataGridView2, valores)
        Else
            If (ConsultaExisteT1 = False) Then
                MessageBox.Show("Error la tabla: " + tab1 + " no existe")
            End If

            If (ConsultaExisteT2 = False) Then
                MessageBox.Show("Error la tabla: " + tab2 + " no existe")
            End If
        End If


    End Sub
End Class