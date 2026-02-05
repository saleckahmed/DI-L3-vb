Public Class login




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id, pwd As String
        id = TextBox1.Text
        pwd = TextBox2.Text

        If id = "iscae" And pwd = "iscae" Then
            Dim m As New Menu
            m.Show()
            Me.Hide()
        Else
            MessageBox.Show("error", "Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
    End Sub
End Class