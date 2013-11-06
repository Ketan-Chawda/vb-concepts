<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class STUDENT
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
        Me.B_DISPLAY1 = New System.Windows.Forms.Button
        Me.B_DISPLAYALL1 = New System.Windows.Forms.Button
        Me.B_DISPLAY2 = New System.Windows.Forms.Button
        Me.B_DISPLAYALL2 = New System.Windows.Forms.Button
        Me.B_EXIT = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.B_GETDATA1 = New System.Windows.Forms.Button
        Me.B_GETDATA2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'B_DISPLAY1
        '
        Me.B_DISPLAY1.AutoSize = True
        Me.B_DISPLAY1.Location = New System.Drawing.Point(264, 65)
        Me.B_DISPLAY1.Name = "B_DISPLAY1"
        Me.B_DISPLAY1.Size = New System.Drawing.Size(75, 23)
        Me.B_DISPLAY1.TabIndex = 0
        Me.B_DISPLAY1.Text = "DISPLAY"
        Me.B_DISPLAY1.UseVisualStyleBackColor = True
        '
        'B_DISPLAYALL1
        '
        Me.B_DISPLAYALL1.AutoSize = True
        Me.B_DISPLAYALL1.Location = New System.Drawing.Point(354, 65)
        Me.B_DISPLAYALL1.Name = "B_DISPLAYALL1"
        Me.B_DISPLAYALL1.Size = New System.Drawing.Size(84, 23)
        Me.B_DISPLAYALL1.TabIndex = 1
        Me.B_DISPLAYALL1.Text = "DISPLAY ALL"
        Me.B_DISPLAYALL1.UseVisualStyleBackColor = True
        '
        'B_DISPLAY2
        '
        Me.B_DISPLAY2.AutoSize = True
        Me.B_DISPLAY2.Location = New System.Drawing.Point(264, 162)
        Me.B_DISPLAY2.Name = "B_DISPLAY2"
        Me.B_DISPLAY2.Size = New System.Drawing.Size(75, 23)
        Me.B_DISPLAY2.TabIndex = 2
        Me.B_DISPLAY2.Text = "DISPLAY"
        Me.B_DISPLAY2.UseVisualStyleBackColor = True
        '
        'B_DISPLAYALL2
        '
        Me.B_DISPLAYALL2.AutoSize = True
        Me.B_DISPLAYALL2.Location = New System.Drawing.Point(354, 162)
        Me.B_DISPLAYALL2.Name = "B_DISPLAYALL2"
        Me.B_DISPLAYALL2.Size = New System.Drawing.Size(81, 23)
        Me.B_DISPLAYALL2.TabIndex = 3
        Me.B_DISPLAYALL2.Text = "DISPLAYALL"
        Me.B_DISPLAYALL2.UseVisualStyleBackColor = True
        '
        'B_EXIT
        '
        Me.B_EXIT.AutoSize = True
        Me.B_EXIT.Location = New System.Drawing.Point(309, 231)
        Me.B_EXIT.Name = "B_EXIT"
        Me.B_EXIT.Size = New System.Drawing.Size(75, 23)
        Me.B_EXIT.TabIndex = 4
        Me.B_EXIT.Text = "EXIT"
        Me.B_EXIT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "STUDENT FUNCTION & PROCEDURE"
        Me.Label1.UseMnemonic = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 65)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(249, 120)
        Me.TextBox1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(306, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "STAFF FUNCTION & PROCEDURE"
        Me.Label3.UseMnemonic = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(151, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 10
        '
        'B_GETDATA1
        '
        Me.B_GETDATA1.AutoSize = True
        Me.B_GETDATA1.Location = New System.Drawing.Point(444, 63)
        Me.B_GETDATA1.Name = "B_GETDATA1"
        Me.B_GETDATA1.Size = New System.Drawing.Size(81, 23)
        Me.B_GETDATA1.TabIndex = 12
        Me.B_GETDATA1.Text = "GETDATA"
        Me.B_GETDATA1.UseVisualStyleBackColor = True
        '
        'B_GETDATA2
        '
        Me.B_GETDATA2.AutoSize = True
        Me.B_GETDATA2.Location = New System.Drawing.Point(444, 162)
        Me.B_GETDATA2.Name = "B_GETDATA2"
        Me.B_GETDATA2.Size = New System.Drawing.Size(81, 23)
        Me.B_GETDATA2.TabIndex = 13
        Me.B_GETDATA2.Text = "GETDATA"
        Me.B_GETDATA2.UseVisualStyleBackColor = True
        '
        'STUDENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 266)
        Me.Controls.Add(Me.B_GETDATA2)
        Me.Controls.Add(Me.B_GETDATA1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_EXIT)
        Me.Controls.Add(Me.B_DISPLAYALL2)
        Me.Controls.Add(Me.B_DISPLAY2)
        Me.Controls.Add(Me.B_DISPLAYALL1)
        Me.Controls.Add(Me.B_DISPLAY1)
        Me.Name = "STUDENT"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_DISPLAY1 As System.Windows.Forms.Button
    Friend WithEvents B_DISPLAYALL1 As System.Windows.Forms.Button
    Friend WithEvents B_DISPLAY2 As System.Windows.Forms.Button
    Friend WithEvents B_DISPLAYALL2 As System.Windows.Forms.Button
    Friend WithEvents B_EXIT As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents B_GETDATA1 As System.Windows.Forms.Button
    Friend WithEvents B_GETDATA2 As System.Windows.Forms.Button

End Class
