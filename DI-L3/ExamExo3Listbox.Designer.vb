<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamExo3Listbox
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
        ListBox1 = New ListBox()
        Button1 = New Button()
        Button3 = New Button()
        TextBox2 = New TextBox()
        Button4 = New Button()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Button5 = New Button()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Button2 = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(315, 25)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(91, 304)
        ListBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 25)
        Button1.Name = "Button1"
        Button1.Size = New Size(129, 23)
        Button1.TabIndex = 1
        Button1.Text = "generate 1 and 100 "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(12, 73)
        Button3.Name = "Button3"
        Button3.Size = New Size(129, 23)
        Button3.TabIndex = 4
        Button3.Text = "remove"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(173, 74)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 5
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(12, 157)
        Button4.Name = "Button4"
        Button4.Size = New Size(78, 23)
        Button4.TabIndex = 6
        Button4.Text = "insert in"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(112, 157)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(73, 23)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(200, 158)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(73, 23)
        TextBox4.TabIndex = 8
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(12, 203)
        Button5.Name = "Button5"
        Button5.Size = New Size(78, 23)
        Button5.TabIndex = 9
        Button5.Text = "find"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(112, 203)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(73, 23)
        TextBox5.TabIndex = 10
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(200, 203)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(73, 23)
        TextBox6.TabIndex = 11
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(12, 115)
        Button2.Name = "Button2"
        Button2.Size = New Size(129, 23)
        Button2.TabIndex = 12
        Button2.Text = "remove el"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(173, 115)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 13
        ' 
        ' ExamExo3Listbox
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(418, 341)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(Button5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Button4)
        Controls.Add(TextBox2)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Name = "ExamExo3Listbox"
        Text = "listboxExmpl"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
