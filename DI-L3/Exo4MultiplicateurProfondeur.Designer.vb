<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exo4MultiplicateurProfondeur
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
        ListView1 = New ListView()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(12, 25)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(510, 313)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(543, 121)
        Button1.Name = "Button1"
        Button1.Size = New Size(245, 56)
        Button1.TabIndex = 2
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(543, 25)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(245, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(543, 70)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(245, 23)
        TextBox2.TabIndex = 4
        ' 
        ' Exo4MultiplicateurProfondeur
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(ListView1)
        Name = "Exo4MultiplicateurProfondeur"
        Text = "Exo4MultiplicateurProfondeur"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
