Public Class problem1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amount, livration As Double
        livration = TextBox1.Text * 0.06
        amount = TextBox1.Text + livration
        TextBox2.Text = livration
        TextBox3.Text = amount
        TextBox1.Clear()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        TextBox2.ReadOnly = True

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox3.ReadOnly = True
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim m As New Menu
        m.Show()
        Me.Close()
    End Sub


End Class