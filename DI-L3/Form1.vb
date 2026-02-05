Public Class Form1








    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        a = TextBox1.Text
        b = TextBox2.Text
        TextBox3.Text = a + b

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Dim a As Integer
            Dim b As Integer
            a = TextBox1.Text
            b = TextBox2.Text
            TextBox3.Text = a + b

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Dim a As Integer
            Dim b As Integer
            a = TextBox1.Text
            b = TextBox2.Text
            TextBox3.Text = a - b

        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            Dim a As Integer
            Dim b As Integer
            a = TextBox1.Text
            b = TextBox2.Text
            TextBox3.Text = a * b

        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            Dim a As Integer
            Dim b As Integer
            a = TextBox1.Text
            b = TextBox2.Text
            TextBox3.Text = a / b

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim m As New Menu
        m.Show()
        Me.Close()
    End Sub
End Class
