Public Class Form1
    Dim MYARRAY(2) As Integer
    Dim INCREASED As Integer = 2


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MYARRAY(0) = 12
        MYARRAY(1) = 31
        MYARRAY(2) = 36
        End Sub

    Private Sub B_DISPLAY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_DISPLAY.Click
        Dim N As Integer
        For N = 0 To INCREASED Step 1
            TextBox1.Text = TextBox1.Text + MYARRAY(N).ToString + vbCrLf
        Next
    End Sub

    Private Sub B_RESIZE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_RESIZE.Click
        TextBox1.Text = ""
        INCREASED = InputBox("ENTER THE SUBSCRIPT OR REDIMENSION OF MYARRAY=")
        ReDim Preserve MYARRAY(INCREASED)
    End Sub

    Private Sub B_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_EXIT.Click
        Me.Dispose()
    End Sub
End Class
