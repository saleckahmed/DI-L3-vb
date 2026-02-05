Public Class Exam2025Exo2

    Dim somP As Integer = 0
    Dim somN As Integer = 0
    Dim cP As Integer = 0
    Dim cN As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim moyN, moyP As Double
        n = TextBox1.Text
        If n > 0 Then
            somP = somP + n
            cP = cP + 1
        ElseIf n < 0 Then
            somN = somN + n
            cN = cN + 1
        Else
            TextBox2.Text = somP.ToString()
            TextBox3.Text = somN.ToString()
            TextBox4.Text = cP.ToString()
            TextBox5.Text = cN.ToString()
            If cP > 0 Then
                moyP = somP / cP
            Else
                moyP = 0
            End If
            If cN > 0 Then
                moyN = somN / cN
            Else
                moyN = 0
            End If
            TextBox6.Text = moyP.ToString()
            TextBox7.Text = moyN.ToString()
        End If
    End Sub
End Class