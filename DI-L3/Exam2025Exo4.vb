Public Class Exam2025Exo4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim s, p, n As Integer
        n = TextBox1.Text
        If RadioButton1.Checked Then
            s = 2700
        ElseIf RadioButton2.Checked Then
            s = 2400
        ElseIf RadioButton3.Checked Then
            s = 2100
        ElseIf RadioButton4.Checked Then
            s = 1750
        ElseIf RadioButton5.Checked Then
            s = 1500
        ElseIf RadioButton6.Checked Then
            s = 1350
        End If



        If n >= 1 And n < 6 Then
            p = n * 50
            s = s + p
        ElseIf n >= 6 And n < 11 Then
            p = 50 * 5 + (n - 5) * 35
            s = s + p
        Else
            p = 50 * 5 + 35 * 5
            s = s + p
        End If

        TextBox2.Text = s.ToString()
    End Sub


End Class