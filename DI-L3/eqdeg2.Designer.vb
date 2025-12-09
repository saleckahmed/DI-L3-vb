<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eqdeg2
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
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(245, 76)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(41, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(351, 76)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(41, 23)
        TextBox2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(351, 145)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(245, 180)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 15)
        Label2.TabIndex = 3
        Label2.Text = "X ="
        ' 
        ' TextBox3
        ' 
        TextBox3.Enabled = False
        TextBox3.Location = New Point(351, 172)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(41, 23)
        TextBox3.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(245, 244)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 5
        Button1.Text = "Calcule"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(226, 79)
        Label3.Name = "Label3"
        Label3.Size = New Size(13, 15)
        Label3.TabIndex = 6
        Label3.Text = "a"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(331, 79)
        Label4.Name = "Label4"
        Label4.Size = New Size(14, 15)
        Label4.TabIndex = 7
        Label4.Text = "b"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(226, 300)
        Button2.Name = "Button2"
        Button2.Size = New Size(186, 23)
        Button2.TabIndex = 8
        Button2.Text = "Menu"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' eqdeg2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(TextBox3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "eqdeg2"
        Text = "eqdeg2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
End Class
