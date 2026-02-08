Public Class Exo4MultiplicateurProfondeur
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pro, mult, i As Integer
        pro = TextBox2.Text
        mult = TextBox1.Text

        For i = 1 To pro
             Dim lvi As New ListViewItem
        
             lvi.Text = i.ToString()
             lvi.SubItems.Add(mult.ToString())
             lvi.SubItems.Add((i * mult).ToString())
        
             ListView1.Items.Add(lvi)
         Next

    End Sub



    Private Sub Exo4MultiplicateurProfondeur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.Columns.Add("id", 80)
        ListView1.Columns.Add("Multiplicateur", 100)
        ListView1.Columns.Add("Profondeur", 100)

    End Sub
End Class
