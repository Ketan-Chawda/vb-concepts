<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CLIENT
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
        Me.B_CLIENT = New System.Windows.Forms.Button
        Me.B_PRODUCT = New System.Windows.Forms.Button
        Me.B_ORDER = New System.Windows.Forms.Button
        Me.B_EXIT = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.B_ALL = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'B_CLIENT
        '
        Me.B_CLIENT.AutoSize = True
        Me.B_CLIENT.Location = New System.Drawing.Point(49, 241)
        Me.B_CLIENT.Name = "B_CLIENT"
        Me.B_CLIENT.Size = New System.Drawing.Size(104, 23)
        Me.B_CLIENT.TabIndex = 0
        Me.B_CLIENT.Text = "CREATE OBJECT"
        Me.B_CLIENT.UseVisualStyleBackColor = True
        '
        'B_PRODUCT
        '
        Me.B_PRODUCT.AutoSize = True
        Me.B_PRODUCT.Location = New System.Drawing.Point(229, 241)
        Me.B_PRODUCT.Name = "B_PRODUCT"
        Me.B_PRODUCT.Size = New System.Drawing.Size(104, 23)
        Me.B_PRODUCT.TabIndex = 1
        Me.B_PRODUCT.Text = "CREATE OBJECT"
        Me.B_PRODUCT.UseVisualStyleBackColor = True
        '
        'B_ORDER
        '
        Me.B_ORDER.AutoSize = True
        Me.B_ORDER.Location = New System.Drawing.Point(427, 241)
        Me.B_ORDER.Name = "B_ORDER"
        Me.B_ORDER.Size = New System.Drawing.Size(104, 23)
        Me.B_ORDER.TabIndex = 2
        Me.B_ORDER.Text = "CREATE OBJECT"
        Me.B_ORDER.UseVisualStyleBackColor = True
        '
        'B_EXIT
        '
        Me.B_EXIT.Location = New System.Drawing.Point(467, 295)
        Me.B_EXIT.Name = "B_EXIT"
        Me.B_EXIT.Size = New System.Drawing.Size(75, 23)
        Me.B_EXIT.TabIndex = 3
        Me.B_EXIT.Text = "EXIT"
        Me.B_EXIT.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1, 84)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 137)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "THIS IS ABSTRACT CLASS,WE HAVE USED ""MUSTINHERIT"" KEYWORD FOR MAKING IT"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(218, 84)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(203, 137)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "THIS A DERIVED CLASS FROM CLIENT CLASS AND BASE-CLASS FOR ORDER-CLASS"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(427, 84)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(211, 137)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.Text = "THIS A DERIVED CLASS FROM PRODUCT CLASS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CLIENT CLASS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(251, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "PRODUCT CLASS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(474, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ORDER CLASS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-2, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(652, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "BY CREATING OBJECT OF OREDER CLASS WE CAN ACCESS ALL SINCE WE HV INHERITED FROM B" & _
            "OTH THE 2 ABOVE CLASS"
        '
        'B_ALL
        '
        Me.B_ALL.AutoSize = True
        Me.B_ALL.Location = New System.Drawing.Point(167, 295)
        Me.B_ALL.Name = "B_ALL"
        Me.B_ALL.Size = New System.Drawing.Size(242, 23)
        Me.B_ALL.TabIndex = 11
        Me.B_ALL.Text = "DISPLAY RESPECTIVE FUNCTION ANYHOW"
        Me.B_ALL.UseVisualStyleBackColor = True
        '
        'CLIENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 330)
        Me.Controls.Add(Me.B_ALL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.B_EXIT)
        Me.Controls.Add(Me.B_ORDER)
        Me.Controls.Add(Me.B_PRODUCT)
        Me.Controls.Add(Me.B_CLIENT)
        Me.Name = "CLIENT"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_CLIENT As System.Windows.Forms.Button
    Friend WithEvents B_PRODUCT As System.Windows.Forms.Button
    Friend WithEvents B_ORDER As System.Windows.Forms.Button
    Friend WithEvents B_EXIT As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents B_ALL As System.Windows.Forms.Button

End Class
