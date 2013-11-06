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
        Me.Picture1 = New System.Windows.Forms.PictureBox
        Me.B_DISPLAY = New System.Windows.Forms.Button
        Me.T_INPUT = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.B_EXIT = New System.Windows.Forms.Button
        Me.B_BROWSE = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.C_TILE = New System.Windows.Forms.CheckBox
        Me.C_CENTER = New System.Windows.Forms.CheckBox
        Me.C_ZOOM = New System.Windows.Forms.CheckBox
        Me.C_STRETCH = New System.Windows.Forms.CheckBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picture1
        '
        Me.Picture1.BackgroundImage = Global.PICTUREBOX_COMPLETE.My.Resources.Resources.aish1_1_
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picture1.Location = New System.Drawing.Point(2, 74)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.Size = New System.Drawing.Size(471, 195)
        Me.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture1.TabIndex = 1
        Me.Picture1.TabStop = False
        '
        'B_DISPLAY
        '
        Me.B_DISPLAY.Location = New System.Drawing.Point(381, 31)
        Me.B_DISPLAY.Name = "B_DISPLAY"
        Me.B_DISPLAY.Size = New System.Drawing.Size(75, 23)
        Me.B_DISPLAY.TabIndex = 1
        Me.B_DISPLAY.Text = "DISPLAY"
        Me.B_DISPLAY.UseVisualStyleBackColor = True
        '
        'T_INPUT
        '
        Me.T_INPUT.Location = New System.Drawing.Point(81, 33)
        Me.T_INPUT.Name = "T_INPUT"
        Me.T_INPUT.Size = New System.Drawing.Size(199, 20)
        Me.T_INPUT.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ENTER PATH"
        '
        'B_EXIT
        '
        Me.B_EXIT.Location = New System.Drawing.Point(398, 311)
        Me.B_EXIT.Name = "B_EXIT"
        Me.B_EXIT.Size = New System.Drawing.Size(75, 23)
        Me.B_EXIT.TabIndex = 5
        Me.B_EXIT.Text = "EXIT"
        Me.B_EXIT.UseVisualStyleBackColor = True
        '
        'B_BROWSE
        '
        Me.B_BROWSE.Location = New System.Drawing.Point(285, 33)
        Me.B_BROWSE.Name = "B_BROWSE"
        Me.B_BROWSE.Size = New System.Drawing.Size(75, 23)
        Me.B_BROWSE.TabIndex = 6
        Me.B_BROWSE.Text = "BROWSE"
        Me.B_BROWSE.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'C_TILE
        '
        Me.C_TILE.AutoSize = True
        Me.C_TILE.Location = New System.Drawing.Point(12, 315)
        Me.C_TILE.Name = "C_TILE"
        Me.C_TILE.Size = New System.Drawing.Size(49, 17)
        Me.C_TILE.TabIndex = 11
        Me.C_TILE.Text = "TILE"
        Me.C_TILE.UseVisualStyleBackColor = True
        '
        'C_CENTER
        '
        Me.C_CENTER.AutoSize = True
        Me.C_CENTER.Location = New System.Drawing.Point(81, 315)
        Me.C_CENTER.Name = "C_CENTER"
        Me.C_CENTER.Size = New System.Drawing.Size(70, 17)
        Me.C_CENTER.TabIndex = 12
        Me.C_CENTER.Text = "CENTER"
        Me.C_CENTER.UseVisualStyleBackColor = True
        '
        'C_ZOOM
        '
        Me.C_ZOOM.AutoSize = True
        Me.C_ZOOM.Location = New System.Drawing.Point(177, 317)
        Me.C_ZOOM.Name = "C_ZOOM"
        Me.C_ZOOM.Size = New System.Drawing.Size(58, 17)
        Me.C_ZOOM.TabIndex = 13
        Me.C_ZOOM.Text = "ZOOM"
        Me.C_ZOOM.UseVisualStyleBackColor = True
        '
        'C_STRETCH
        '
        Me.C_STRETCH.AutoSize = True
        Me.C_STRETCH.Location = New System.Drawing.Point(267, 317)
        Me.C_STRETCH.Name = "C_STRETCH"
        Me.C_STRETCH.Size = New System.Drawing.Size(77, 17)
        Me.C_STRETCH.TabIndex = 14
        Me.C_STRETCH.Text = "STRETCH"
        Me.C_STRETCH.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(177, 288)
        Me.ProgressBar1.Maximum = 500000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 15
        Me.ProgressBar1.Value = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 346)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.C_STRETCH)
        Me.Controls.Add(Me.C_ZOOM)
        Me.Controls.Add(Me.C_CENTER)
        Me.Controls.Add(Me.C_TILE)
        Me.Controls.Add(Me.B_BROWSE)
        Me.Controls.Add(Me.B_EXIT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.T_INPUT)
        Me.Controls.Add(Me.B_DISPLAY)
        Me.Controls.Add(Me.Picture1)
        Me.Name = "Form1"
        Me.Text = "INSERT IMAGE AT RUNTIME"
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Picture1 As System.Windows.Forms.PictureBox
    Friend WithEvents B_DISPLAY As System.Windows.Forms.Button
    Friend WithEvents T_INPUT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents B_EXIT As System.Windows.Forms.Button
    Friend WithEvents B_BROWSE As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents C_TILE As System.Windows.Forms.CheckBox
    Friend WithEvents C_CENTER As System.Windows.Forms.CheckBox
    Friend WithEvents C_ZOOM As System.Windows.Forms.CheckBox
    Friend WithEvents C_STRETCH As System.Windows.Forms.CheckBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

End Class
