Public Class ExamExo2QuesBFonctionXn
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim X, y As Double
        Dim n As Integer
        X = TextBox1.Text
        n = TextBox2.Text
        y = X ^ n
        TextBox3.Text = y
    End Sub
End Class