<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KETAN
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
        Me.B_EXIT = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'B_DISPLAY
        '
        Me.B_DISPLAY.AutoSize = True
        Me.B_DISPLAY.Location = New System.Drawing.Point(12, 71)
        Me.B_DISPLAY.Name = "B_DISPLAY"
        Me.B_DISPLAY.Size = New System.Drawing.Size(133, 23)
        Me.B_DISPLAY.TabIndex = 0
        Me.B_DISPLAY.Text = "DISPLAY PROCEDURE"
        Me.B_DISPLAY.UseVisualStyleBackColor = True
        '
        'B_EXIT
        '
        Me.B_EXIT.AutoSize = True
        Me.B_EXIT.Location = New System.Drawing.Point(195, 71)
        Me.B_EXIT.Name = "B_EXIT"
        Me.B_EXIT.Size = New System.Drawing.Size(66, 23)
        Me.B_EXIT.TabIndex = 3
        Me.B_EXIT.Text = "EXIT"
        Me.B_EXIT.UseVisualStyleBackColor = True
        '
        'KETAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.B_EXIT)
        Me.Controls.Add(Me.B_DISPLAY)
        Me.Name = "KETAN"
        Me.Text = "MYBASE KEYWORD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_DISPLAY As System.Windows.Forms.Button
    Friend WithEvents B_EXIT As System.Windows.Forms.Button

End Class
