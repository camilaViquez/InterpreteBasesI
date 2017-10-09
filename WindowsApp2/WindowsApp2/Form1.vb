Public Class seleccionVentana
    Public x
    Public y
    Public valores
    Public valoresA
    Public prueba, prueba1 As Boolean
    Public datatable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        DataGridView2.DataSource = "null"
        x = ntabla.Text
        y = nAtributos.Text
        valoresA = " σ " + y + "  ( " + x + " ) "
        valores = "Select " + y + " from " + x
        SQL_Label.Text = valores
        Algebra_label.Text = valoresA
        prueba = consultarExistencia(x)

        Try
            If prueba Then
                llenarDatagridviewSeleccion(DataGridView2, valores)

            Else
                MessageBox.Show("Error la tabla no existe")
            End If
        Catch ex As Exception
            MessageBox.Show("Se presentó un error.")
        End Try


    End Sub
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub


    Public Sub p_TextChanged(sender As Object, e As EventArgs) Handles ntabla.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub



    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Algebra_Relacional_Enter(sender As Object, e As EventArgs) Handles Algebra_Relacional.Enter

    End Sub
End Class
