Public Class calculeTVA
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c1, c2, c3, c4 As Double
        c1 = TextBox1.Text
        c2 = TextBox2.Text
        c3 = c1 * (c2 * 0.01)
        c4 = c3 + c1
        TextBox3.Text = c4
        TextBox4.Text = c3



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class