Public Class ExamExo2QuesASerieHarmonique
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Som As Double
        Dim N As Integer
        N = TextBox1.Text
        Som = 0
        For i = 1 To N
            Som = Som + 1 / i
        Next
        TextBox2.Text = Som
    End Sub
End Class