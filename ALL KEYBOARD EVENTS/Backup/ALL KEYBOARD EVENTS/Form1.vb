Public Class Form1

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        MessageBox.Show("KEY-DOWN EVENT IS CALLED")
        TextBox2.Text = "OCCURS WHEN A KEY IS FIRST PRESSED,IT IS INVOKED AFTER PREVIEW-KEYDOWN EVENT"

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        MessageBox.Show("KEY-PRESS EVENT IS CALLED")
        TextBox2.Text = "OCCURS WHEN THE CONTROL HAS FOCUS AND THE USER PRESSES AND RELEASES A KEY,IT IS INVOKE AFTER THE PREVIEW-KEYDOWN BUT BEFOR KEY-DOWN EVENT"
    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        MessageBox.Show("KEY-UP EVENT IS CALLED")
        TextBox2.Text = "OCCURS WHEN A KEY IS RELEASED,IT IS INVOKE AT LAST COMPARING TO OTHER EVENTS"
    End Sub

    Private Sub TextBox1_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        MessageBox.Show("PREVIEW-KEYDOWN EVENT IS CALLED,IT IS CALLED BEFORE KEY-DOWN EVENT")
        TextBox2.Text = "OCCURS BEFORE THE KEYDOWN EVENT WHEN A KEY IS PRESSED WHILE FOCUS IS ON THIS CONTROL,IT IS INVOKED BEFORE ANY OTHER KEY-BOARD EVENTS"
    End Sub
    Private Sub B_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_EXIT.Click
        Me.Dispose()
    End Sub

End Class
