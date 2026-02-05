<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exam2025Exo2
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
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(64, 67)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(136, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(347, 67)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(136, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(532, 67)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(136, 23)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(347, 127)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(136, 23)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(532, 127)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(136, 23)
        TextBox5.TabIndex = 4
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(347, 187)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(136, 23)
        TextBox6.TabIndex = 5
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(532, 187)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(136, 23)
        TextBox7.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(64, 127)
        Button1.Name = "Button1"
        Button1.Size = New Size(136, 83)
        Button1.TabIndex = 7
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Exam2025Exo2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Exam2025Exo2"
        Text = "Exam2025Exo2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button1 As Button
End Class
