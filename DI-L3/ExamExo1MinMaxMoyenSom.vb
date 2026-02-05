Public Class ExamExo1MinMaxMoyenSom




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x1, X2 As Double
        x1 = TextBox1.Text
        X2 = TextBox2.Text
        If RadioButton1.Checked Then
            TextBox3.Text = (x1 + X2)
        End If

        If RadioButton3.Checked Then
            If x1 > X2 Then
                TextBox3.Text = x1
            Else
                TextBox3.Text = X2
            End If

        End If

        If RadioButton2.Checked Then
            If x1 < X2 Then
                TextBox3.Text = x1
            Else
                TextBox3.Text = X2
            End If
        End If


        If RadioButton4.Checked Then
            TextBox3.Text = (x1 + X2) / 2
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class