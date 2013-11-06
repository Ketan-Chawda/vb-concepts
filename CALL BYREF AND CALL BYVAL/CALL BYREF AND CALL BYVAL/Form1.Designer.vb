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
        Me.B_BYREF = New System.Windows.Forms.Button
        Me.B_BYVAL = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.B_EXIT = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'B_BYREF
        '
        Me.B_BYREF.AutoSize = True
        Me.B_BYREF.Location = New System.Drawing.Point(254, 66)
        Me.B_BYREF.Name = "B_BYREF"
        Me.B_BYREF.Size = New System.Drawing.Size(96, 23)
        Me.B_BYREF.TabIndex = 0
        Me.B_BYREF.Text = "BYREFERENCE"
        Me.B_BYREF.UseVisualStyleBackColor = True
        '
        'B_BYVAL
        '
        Me.B_BYVAL.AutoSize = True
        Me.B_BYVAL.Location = New System.Drawing.Point(271, 106)
        Me.B_BYVAL.Name = "B_BYVAL"
        Me.B_BYVAL.Size = New System.Drawing.Size(75, 23)
        Me.B_BYVAL.TabIndex = 1
        Me.B_BYVAL.Text = "BYVALUE"
        Me.B_BYVAL.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "A CODE FOR INTERCHANGING VALUE"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(78, 69)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(78, 108)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "VALUE1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "VALUE2"
        '
        'B_EXIT
        '
        Me.B_EXIT.Location = New System.Drawing.Point(271, 232)
        Me.B_EXIT.Name = "B_EXIT"
        Me.B_EXIT.Size = New System.Drawing.Size(75, 23)
        Me.B_EXIT.TabIndex = 7
        Me.B_EXIT.Text = "EXIT"
        Me.B_EXIT.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 300)
        Me.Controls.Add(Me.B_EXIT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_BYVAL)
        Me.Controls.Add(Me.B_BYREF)
        Me.Name = "Form1"
        Me.Text = "SWAPPING VALUE OF TWO VARIABLE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_BYREF As System.Windows.Forms.Button
    Friend WithEvents B_BYVAL As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents B_EXIT As System.Windows.Forms.Button

End Class
