<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.B_TEST = New System.Windows.Forms.Button
        Me.B_EXIT = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'B_TEST
        '
        Me.B_TEST.Location = New System.Drawing.Point(49, 185)
        Me.B_TEST.Name = "B_TEST"
        Me.B_TEST.Size = New System.Drawing.Size(75, 23)
        Me.B_TEST.TabIndex = 0
        Me.B_TEST.Text = "TESTING"
        Me.B_TEST.UseVisualStyleBackColor = True
        '
        'B_EXIT
        '
        Me.B_EXIT.Location = New System.Drawing.Point(331, 185)
        Me.B_EXIT.Name = "B_EXIT"
        Me.B_EXIT.Size = New System.Drawing.Size(75, 23)
        Me.B_EXIT.TabIndex = 1
        Me.B_EXIT.Text = "EXIT"
        Me.B_EXIT.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(159, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(259, 113)
        Me.TextBox1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 266)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.B_EXIT)
        Me.Controls.Add(Me.B_TEST)
        Me.Name = "Form1"
        Me.Text = "MOUSE EVENTS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_TEST As System.Windows.Forms.Button
    Friend WithEvents B_EXIT As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
