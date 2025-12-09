Public Class eqdeg2


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click


    End Sub

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

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim m As New Menu
        m.Show()
        Me.Close()
    End Sub
End Class