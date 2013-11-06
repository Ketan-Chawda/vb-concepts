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
        Me.B_RUN = New System.Windows.Forms.Button
        Me.B_EXIT = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'B_RUN
        '
        Me.B_RUN.Location = New System.Drawing.Point(184, 34)
        Me.B_RUN.Name = "B_RUN"
        Me.B_RUN.Size = New System.Drawing.Size(75, 23)
        Me.B_RUN.TabIndex = 0
        Me.B_RUN.Text = "RUN"
        Me.B_RUN.UseVisualStyleBackColor = True
        '
        'B_EXIT
        '
        Me.B_EXIT.Location = New System.Drawing.Point(205, 231)
        Me.B_EXIT.Name = "B_EXIT"
        Me.B_EXIT.Size = New System.Drawing.Size(75, 23)
        Me.B_EXIT.TabIndex = 1
        Me.B_EXIT.Text = "EXIT"
        Me.B_EXIT.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(39, 137)
        Me.ProgressBar1.Maximum = 50000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(162, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Value = 50
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.B_EXIT)
        Me.Controls.Add(Me.B_RUN)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents B_RUN As System.Windows.Forms.Button
    Friend WithEvents B_EXIT As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

End Class
