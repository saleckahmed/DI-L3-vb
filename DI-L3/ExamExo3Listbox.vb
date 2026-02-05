Public Class ExamExo3Listbox


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 1 To 100
            ListBox1.Items.Add(i.ToString())
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ListBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x As Integer
        x = TextBox1.Text
        ListBox1.Items.Remove(x.ToString())
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Insert(TextBox3.Text, TextBox4.Text)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox6.Text = ListBox1.FindString(TextBox1.Text)
    End Sub


    Private Sub Butxton2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As Integer
        x = TextBox2.Text
        ListBox1.Items.RemoveAt(x)
    End Sub


End Class