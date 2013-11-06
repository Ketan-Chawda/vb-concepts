Public Class Form1

    Private Sub B_MESSAGE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_MESSAGE.Click
        MessageBox.Show("THIS IS CALLED MESSAGEBOX", "IT IS KETAN'S MESSAGEBOX", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
    End Sub

    Private Sub B_INPUTBOX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_INPUTBOX.Click
        Dim STR As String
        STR = InputBox("ENTER THE STRING=", "IT IS KETAN'S INPUTBOX", "IT IS DEFAULT VALUE", 200, 200)
        TEXTBOX1.TEXT = STR
    End Sub

    Private Sub B_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_EXIT.Click
        Me.Dispose()
    End Sub
End Class
