Public Class Menu
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f1 As New Form1
        f1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim eq As New eqdeg2
        eq.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim p As New problem1
        p.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim d As New days
        d.Show()
        Me.Hide()
    End Sub


End Class