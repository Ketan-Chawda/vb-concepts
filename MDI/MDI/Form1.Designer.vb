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
        Me.B_FORM2 = New System.Windows.Forms.Button
        Me.B_FORM3 = New System.Windows.Forms.Button
        Me.B_EXIT = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'B_FORM2
        '
        Me.B_FORM2.Location = New System.Drawing.Point(177, 39)
        Me.B_FORM2.Name = "B_FORM2"
        Me.B_FORM2.Size = New System.Drawing.Size(75, 23)
        Me.B_FORM2.TabIndex = 1
        Me.B_FORM2.Text = "FORM2"
        Me.B_FORM2.UseVisualStyleBackColor = True
        '
        'B_FORM3
        '
        Me.B_FORM3.Location = New System.Drawing.Point(177, 123)
        Me.B_FORM3.Name = "B_FORM3"
        Me.B_FORM3.Size = New System.Drawing.Size(75, 23)
        Me.B_FORM3.TabIndex = 2
        Me.B_FORM3.Text = "FORM3"
        Me.B_FORM3.UseVisualStyleBackColor = True
        '
        'B_EXIT
        '
        Me.B_EXIT.Location = New System.Drawing.Point(151, 205)
        Me.B_EXIT.Name = "B_EXIT"
        Me.B_EXIT.Size = New System.Drawing.Size(75, 23)
        Me.B_EXIT.TabIndex = 3
        Me.B_EXIT.Text = "EXIT"
        Me.B_EXIT.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.B_EXIT)
        Me.Controls.Add(Me.B_FORM3)
        Me.Controls.Add(Me.B_FORM2)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents B_FORM2 As System.Windows.Forms.Button
    Friend WithEvents B_FORM3 As System.Windows.Forms.Button
    Friend WithEvents B_EXIT As System.Windows.Forms.Button

End Class
