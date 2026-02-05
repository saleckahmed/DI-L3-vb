Public Class eqdeg2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double

        Dim b As Double

        Dim c As Double

        a = TextBox1.Text
        b = TextBox2.Text

        If a = 0 Then
            c = 0
        ElseIf b = 0 Then
            c = 0
        Else
            c = -b / a
        End If



        TextBox3.Text = c
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub





    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim m As New Menu
        m.Show()
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class