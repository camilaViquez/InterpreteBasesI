Public Class Form1
    Public x
    Public y
    Public valores
    Public valoresA
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x = p.Text
        y = p1.Text
        valores = "Select " + y + " from " + x
        valoresA = " σ " + y + "(" + x + ")"
        SQL_Label.Text = valores
        Algebra_label.Text = valoresA
        llenarDatagridviewSeleccion(DataGridView2, valores)

    End Sub
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub


    Public Sub p_TextChanged(sender As Object, e As EventArgs) Handles p.TextChanged

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
