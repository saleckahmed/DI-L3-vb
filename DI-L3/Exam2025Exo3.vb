Public Class Exam2025Exo3

    Dim cE As Integer = 0
    Dim cB As Integer = 0
    Dim cAdul As Integer = 0
    Dim cAdol As Integer = 0
    Private Sub Exam2025Exo3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
        TextBox4.ReadOnly = True
        TextBox6.ReadOnly = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        n = TextBox5.Text
        If n < 1 Then
            cB = cB + 1
        ElseIf n >= 1 And n < 12 Then
            cE = cE + 1
        ElseIf n >= 12 And n < 18 Then
            cAdol = cAdol + 1
        Else
            cAdul = cAdul + 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = cB
        TextBox2.Text = cE
        TextBox3.Text = cAdol
        TextBox4.Text = cAdul
        If cB > cE And cB > cAdul And cB > cAdol Then
            TextBox6.Text = "Bebe"
        ElseIf cE > cB And cE > cAdul And cE > cAdol Then
            TextBox6.Text = "Enfant"
        ElseIf cAdul > cB And cAdul > cE And cAdul > cAdol Then
            TextBox6.Text = "Adulte"
        Else
            TextBox6.Text = "Adolesence"
        End If
    End Sub
End Class