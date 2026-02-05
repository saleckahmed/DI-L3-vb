<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculeTVA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Panel2 = New Panel()
        Label4 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(102, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(318, 115)
        Panel1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(180, 74)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(107, 23)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(180, 37)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(107, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(18, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 15)
        Label3.TabIndex = 3
        Label3.Text = "Taux de TVA (en %)        "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(18, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 15)
        Label2.TabIndex = 2
        Label2.Text = "Montant hors taxes(HT)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 1
        Label1.Text = "Entrees"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(179, 133)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 28)
        Button1.TabIndex = 1
        Button1.Text = "CALCULER"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(TextBox4)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(102, 167)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(318, 115)
        Panel2.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(18, 77)
        Label4.Name = "Label4"
        Label4.Size = New Size(121, 15)
        Label4.TabIndex = 5
        Label4.Text = "Montant TTC (euros)"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(180, 74)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(107, 23)
        TextBox3.TabIndex = 4
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(180, 37)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(107, 23)
        TextBox4.TabIndex = 1
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(18, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 15)
        Label5.TabIndex = 2
        Label5.Text = "Total TVA                        "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(14, 10)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 15)
        Label6.TabIndex = 1
        Label6.Text = "Resultas"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(120, 304)
        Button2.Name = "Button2"
        Button2.Size = New Size(121, 28)
        Button2.TabIndex = 6
        Button2.Text = "EFFACER"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(268, 304)
        Button3.Name = "Button3"
        Button3.Size = New Size(121, 28)
        Button3.TabIndex = 7
        Button3.Text = "FERMER"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' calculeTVA
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Green
        ClientSize = New Size(564, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Panel2)
        Controls.Add(Button1)
        Controls.Add(Panel1)
        Name = "calculeTVA"
        Text = "calculeTVA"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
