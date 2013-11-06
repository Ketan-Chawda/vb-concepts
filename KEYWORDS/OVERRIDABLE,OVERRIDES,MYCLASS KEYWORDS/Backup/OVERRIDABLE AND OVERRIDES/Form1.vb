Public Class SUPERSET
    Protected Overridable Sub DISPLAY()
        'TextBox1.Text = "THIS IS A DISPLAY  PROCEDURE OF BASE CLASS"
        MessageBox.Show("THIS IS A DISPLAY PROCEDURE CREATED IN BASE CLASS")
        MyClass.SHOWS()
        'SHOWS()
    End Sub
    Protected Overridable Sub SHOWS()
        MessageBox.Show("THIS IS A SHOW PROCEDURE  CREATED IN BASE CLASS")
        TextBox1.Text += vbCrLf + "THIS IS A SHOW PROCEDURE OF BASE CLASS"
    End Sub

    Private Sub B_DERIVED_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_DERIVED.Click
        Dim KAC As New SUBSET()
        KAC.DISPLAY()
        TextBox1.Text = "THIS IS A DISPLAY  PROCEDURE  CREATED IN BASE CLASS"

    End Sub

    Private Sub B_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_EXIT.Click
        Me.Dispose()
    End Sub
End Class
Public Class SUBSET
    Inherits SUPERSET
    Protected Overrides Sub SHOWS()
        MessageBox.Show("THIS A SHOW PROCEDURE  CREATED IN DERIVED CLASS")
    End Sub
    'Protected Overrides Sub DISPLAY()
    '    MessageBox.Show("THIS IS A PROCEDURE  OF DERIVED CLASS")
    '   TextBox2.Text = "THIS IS A PROCEDURE  OF DERIVED CLASS"
    'End Sub
End Class

