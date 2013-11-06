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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.B_ADD = New System.Windows.Forms.Button
        Me.C_SORT = New System.Windows.Forms.CheckBox
        Me.B_EXIT = New System.Windows.Forms.Button
        Me.B_SEARCH = New System.Windows.Forms.Button
        Me.T_INPUT = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"X", "A", "Y", "B", "Z", "C", "D", "E"})
        Me.ComboBox1.Location = New System.Drawing.Point(117, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(243, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'B_ADD
        '
        Me.B_ADD.AutoSize = True
        Me.B_ADD.Location = New System.Drawing.Point(145, 115)
        Me.B_ADD.Name = "B_ADD"
        Me.B_ADD.Size = New System.Drawing.Size(75, 23)
        Me.B_ADD.TabIndex = 1
        Me.B_ADD.Text = "ADD"
        Me.B_ADD.UseVisualStyleBackColor = True
        '
        'C_SORT
        '
        Me.C_SORT.AutoSize = True
        Me.C_SORT.Location = New System.Drawing.Point(145, 160)
        Me.C_SORT.Name = "C_SORT"
        Me.C_SORT.Size = New System.Drawing.Size(56, 17)
        Me.C_SORT.TabIndex = 2
        Me.C_SORT.Text = "SORT"
        Me.C_SORT.UseVisualStyleBackColor = True
        '
        'B_EXIT
        '
        Me.B_EXIT.AutoSize = True
        Me.B_EXIT.Location = New System.Drawing.Point(145, 235)
        Me.B_EXIT.Name = "B_EXIT"
        Me.B_EXIT.Size = New System.Drawing.Size(75, 23)
        Me.B_EXIT.TabIndex = 3
        Me.B_EXIT.Text = "EXIT"
        Me.B_EXIT.UseVisualStyleBackColor = True
        '
        'B_SEARCH
        '
        Me.B_SEARCH.AutoSize = True
        Me.B_SEARCH.Location = New System.Drawing.Point(145, 197)
        Me.B_SEARCH.Name = "B_SEARCH"
        Me.B_SEARCH.Size = New System.Drawing.Size(75, 23)
        Me.B_SEARCH.TabIndex = 4
        Me.B_SEARCH.Text = "SEARCH"
        Me.B_SEARCH.UseVisualStyleBackColor = True
        '
        'T_INPUT
        '
        Me.T_INPUT.Location = New System.Drawing.Point(132, 75)
        Me.T_INPUT.Name = "T_INPUT"
        Me.T_INPUT.Size = New System.Drawing.Size(158, 20)
        Me.T_INPUT.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ENTER"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 335)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.T_INPUT)
        Me.Controls.Add(Me.B_SEARCH)
        Me.Controls.Add(Me.B_EXIT)
        Me.Controls.Add(Me.C_SORT)
        Me.Controls.Add(Me.B_ADD)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "COMBOBOX"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents B_ADD As System.Windows.Forms.Button
    Friend WithEvents C_SORT As System.Windows.Forms.CheckBox
    Friend WithEvents B_EXIT As System.Windows.Forms.Button
    Friend WithEvents B_SEARCH As System.Windows.Forms.Button
    Friend WithEvents T_INPUT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
