Public Class Exam2025Exo1
    Private Sub Exam2025Exo1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.Columns.Add("i", 20)
        ListView1.Columns.Add("carres", 40)
        ListView1.Columns.Add("Cubes", 60)
        ListView1.Columns.Add("Factorielle")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j, f, n As Integer
        n = TextBox1.Text
        For i = 0 To n
            If i Mod 2 = 0 Then
                Dim lvi As New ListViewItem
                lvi.Text = i.ToString
                lvi.SubItems.Add((i * i).ToString)
                lvi.SubItems.Add((i * i * i).ToString)
                For j = 1 To i
                    f = f * j
                Next
                lvi.SubItems.Add(f.ToString)
                ListView1.Items.Add(lvi)

            End If

        Next

    End Sub


End Class