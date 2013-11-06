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
        Me.L_OPENFILE = New System.Windows.Forms.LinkLabel
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.L_COLORDIALOGBOX = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'L_OPENFILE
        '
        Me.L_OPENFILE.AutoSize = True
        Me.L_OPENFILE.Location = New System.Drawing.Point(12, 147)
        Me.L_OPENFILE.Name = "L_OPENFILE"
        Me.L_OPENFILE.Size = New System.Drawing.Size(121, 13)
        Me.L_OPENFILE.TabIndex = 0
        Me.L_OPENFILE.TabStop = True
        Me.L_OPENFILE.Text = "OPENFILEDIALOGBOX"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'L_COLORDIALOGBOX
        '
        Me.L_COLORDIALOGBOX.AutoSize = True
        Me.L_COLORDIALOGBOX.Location = New System.Drawing.Point(12, 188)
        Me.L_COLORDIALOGBOX.Name = "L_COLORDIALOGBOX"
        Me.L_COLORDIALOGBOX.Size = New System.Drawing.Size(84, 13)
        Me.L_COLORDIALOGBOX.TabIndex = 2
        Me.L_COLORDIALOGBOX.TabStop = True
        Me.L_COLORDIALOGBOX.Text = "COLORDIALOG"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DEFAULT LINK-COLOR IS =BLUE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "DEFAULT ACTIVE-LINK-COLOR IS=RED"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(230, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "DEFAULT VISITED-LINK-COLOR IS=PURPLE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "GIVEN BELOW ARE ALL LINK-LABEL"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 303)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.L_COLORDIALOGBOX)
        Me.Controls.Add(Me.L_OPENFILE)
        Me.Name = "Form1"
        Me.Text = "LINK LABEL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents L_OPENFILE As System.Windows.Forms.LinkLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents L_COLORDIALOGBOX As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
