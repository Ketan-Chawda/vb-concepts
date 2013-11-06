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
        Me.components = New System.ComponentModel.Container
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.L_MIN = New System.Windows.Forms.Label
        Me.L_SEC = New System.Windows.Forms.Label
        Me.L_HR = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.B_START = New System.Windows.Forms.Button
        Me.B_STOP = New System.Windows.Forms.Button
        Me.B_REFRESH = New System.Windows.Forms.Button
        Me.B_EXIT = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'L_MIN
        '
        Me.L_MIN.AutoSize = True
        Me.L_MIN.Location = New System.Drawing.Point(70, 76)
        Me.L_MIN.Name = "L_MIN"
        Me.L_MIN.Size = New System.Drawing.Size(27, 13)
        Me.L_MIN.TabIndex = 0
        Me.L_MIN.Text = "MIN"
        '
        'L_SEC
        '
        Me.L_SEC.AutoSize = True
        Me.L_SEC.Location = New System.Drawing.Point(113, 76)
        Me.L_SEC.Name = "L_SEC"
        Me.L_SEC.Size = New System.Drawing.Size(28, 13)
        Me.L_SEC.TabIndex = 1
        Me.L_SEC.Text = "SEC"
        '
        'L_HR
        '
        Me.L_HR.AutoSize = True
        Me.L_HR.Location = New System.Drawing.Point(30, 76)
        Me.L_HR.Name = "L_HR"
        Me.L_HR.Size = New System.Drawing.Size(23, 13)
        Me.L_HR.TabIndex = 2
        Me.L_HR.Text = "HR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "HR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "MIN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SEC"
        '
        'B_START
        '
        Me.B_START.Location = New System.Drawing.Point(190, 53)
        Me.B_START.Name = "B_START"
        Me.B_START.Size = New System.Drawing.Size(75, 23)
        Me.B_START.TabIndex = 6
        Me.B_START.Text = "START TIMER"
        Me.B_START.UseVisualStyleBackColor = True
        '
        'B_STOP
        '
        Me.B_STOP.Location = New System.Drawing.Point(190, 118)
        Me.B_STOP.Name = "B_STOP"
        Me.B_STOP.Size = New System.Drawing.Size(75, 23)
        Me.B_STOP.TabIndex = 7
        Me.B_STOP.Text = "STOP"
        Me.B_STOP.UseVisualStyleBackColor = True
        '
        'B_REFRESH
        '
        Me.B_REFRESH.Location = New System.Drawing.Point(190, 173)
        Me.B_REFRESH.Name = "B_REFRESH"
        Me.B_REFRESH.Size = New System.Drawing.Size(75, 23)
        Me.B_REFRESH.TabIndex = 8
        Me.B_REFRESH.Text = "REFRESH"
        Me.B_REFRESH.UseVisualStyleBackColor = True
        '
        'B_EXIT
        '
        Me.B_EXIT.Location = New System.Drawing.Point(190, 220)
        Me.B_EXIT.Name = "B_EXIT"
        Me.B_EXIT.Size = New System.Drawing.Size(75, 23)
        Me.B_EXIT.TabIndex = 9
        Me.B_EXIT.Text = "EXIT"
        Me.B_EXIT.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.B_EXIT)
        Me.Controls.Add(Me.B_REFRESH)
        Me.Controls.Add(Me.B_STOP)
        Me.Controls.Add(Me.B_START)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.L_HR)
        Me.Controls.Add(Me.L_SEC)
        Me.Controls.Add(Me.L_MIN)
        Me.Name = "Form1"
        Me.Text = "TIMER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents L_MIN As System.Windows.Forms.Label
    Friend WithEvents L_SEC As System.Windows.Forms.Label
    Friend WithEvents L_HR As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents B_START As System.Windows.Forms.Button
    Friend WithEvents B_STOP As System.Windows.Forms.Button
    Friend WithEvents B_REFRESH As System.Windows.Forms.Button
    Friend WithEvents B_EXIT As System.Windows.Forms.Button

End Class
