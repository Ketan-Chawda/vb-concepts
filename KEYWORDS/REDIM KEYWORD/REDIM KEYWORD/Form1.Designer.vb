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
        Me.B_DISPLAY = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.B_RESIZE = New System.Windows.Forms.Button
        Me.B_EXIT = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'B_DISPLAY
        '
        Me.B_DISPLAY.AutoSize = True
        Me.B_DISPLAY.Location = New System.Drawing.Point(175, 72)
        Me.B_DISPLAY.Name = "B_DISPLAY"
        Me.B_DISPLAY.Size = New System.Drawing.Size(75, 23)
        Me.B_DISPLAY.TabIndex = 0
        Me.B_DISPLAY.Text = "DISPLAY"
        Me.B_DISPLAY.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 57)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 128)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'B_RESIZE
        '
        Me.B_RESIZE.AutoSize = True
        Me.B_RESIZE.Location = New System.Drawing.Point(175, 123)
        Me.B_RESIZE.Name = "B_RESIZE"
        Me.B_RESIZE.Size = New System.Drawing.Size(75, 23)
        Me.B_RESIZE.TabIndex = 3
        Me.B_RESIZE.Text = "RESIZE"
        Me.B_RESIZE.UseVisualStyleBackColor = True
        '
        'B_EXIT
        '
        Me.B_EXIT.AutoSize = True
        Me.B_EXIT.Location = New System.Drawing.Point(175, 211)
        Me.B_EXIT.Name = "B_EXIT"
        Me.B_EXIT.Size = New System.Drawing.Size(75, 23)
        Me.B_EXIT.TabIndex = 5
        Me.B_EXIT.Text = "EXIT"
        Me.B_EXIT.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.B_EXIT)
        Me.Controls.Add(Me.B_RESIZE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.B_DISPLAY)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_DISPLAY As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents B_RESIZE As System.Windows.Forms.Button
    Friend WithEvents B_EXIT As System.Windows.Forms.Button

End Class
