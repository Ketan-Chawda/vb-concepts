Public Class Form1

    Private Sub B_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_EXIT.Click
        Me.Dispose()
    End Sub

    Private Sub B_TEST_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles B_TEST.MouseDown
        MessageBox.Show("MOUSE-DOWN EVENT IS CALLED")
        TextBox1.Text = "THIS MOUSE-DOWN EVENT IS CALLED WHENEVER USER PRESS RIGHT OR LEFT KEY OF MOUSE"
    End Sub

    Private Sub B_TEST_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_TEST.MouseEnter
        MessageBox.Show("MOUSE-ENTER EVENT IS CALLED")
        TextBox1.Text = "THIS MOUSE-ENTER EVENT IS CALLED WHEN-EVER USER BRINGS THE MOUSE-POINTER ON THE CONTROL"
    End Sub

    Private Sub B_TEST_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_TEST.MouseHover
        MessageBox.Show("MOUSE-HOVER EVENT IS CALLED")
        TextBox1.Text = "THIS MOUSE-HOVER EVENT IS CALLED WHEN-EVER USER BRINGS THE MOUSE-POINTER AND KEEPS FOR A WHILE"
    End Sub

    Private Sub B_TEST_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles B_TEST.MouseLeave
        MessageBox.Show("MOUSE-LEAVE EVENT IS CALLED")
        TextBox1.Text = "THIS MOUSE-LEAVE EVENT IS CALLED WHEN-EVER USER LEAVES THE HOVER FROM THE CONTROL"
    End Sub

    Private Sub B_TEST_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles B_TEST.MouseMove
        MessageBox.Show("MOUSE-MOVE EVENT IS CALLED SAME AS MOUSE-HOVER AND MOUSE-ENTER")
        TextBox1.Text = "THIS MOUSE-MOVE EVENT IS CALLED WHENEVER MOUSE IS MOVED ON CONTROL,SAME AS MOUSE-HOVER AND MOUSE-ENTER"
    End Sub

    Private Sub B_TEST_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles B_TEST.MouseUp
        MessageBox.Show("MOUSE-UP EVENT IS CALLED ")
        TextBox1.Text = "THIS MOUSE-UP EVENT IS CALLED WHENEVER BOTH BUTTON OF MOUSE IS RELEASED,RIGHT & LEFT"
    End Sub
End Class
