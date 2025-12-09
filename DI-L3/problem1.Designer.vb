<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class problem1
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
        TextBox1 = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(173, 131)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F)
        Label1.Location = New Point(82, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 21)
        Label1.TabIndex = 1
        Label1.Text = "Montant"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(82, 188)
        Button1.Name = "Button1"
        Button1.Size = New Size(191, 26)
        Button1.TabIndex = 2
        Button1.Text = "Calculer"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F)
        Label2.Location = New Point(411, 190)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 21)
        Label2.TabIndex = 3
        Label2.Text = "Cout d'achat "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F)
        Label3.Location = New Point(411, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 21)
        Label3.TabIndex = 4
        Label3.Text = "prix de livraison"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(579, 131)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(172, 23)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(579, 188)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(172, 23)
        TextBox3.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.System
        Label4.Font = New Font("Segoe UI", 20.0F)
        Label4.Location = New Point(249, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(263, 37)
        Label4.TabIndex = 7
        Label4.Text = "calculer votre facteur"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(76, 274)
        Button2.Name = "Button2"
        Button2.Size = New Size(197, 23)
        Button2.TabIndex = 8
        Button2.Text = "Menu"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' problem1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Name = "problem1"
        Text = "problem1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
End Class
