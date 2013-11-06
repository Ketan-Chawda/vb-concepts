Public Class Form1

    Private Sub B_TEST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_TEST.Click
        Dim V1 As Integer
        Dim REMAINDER As Integer
        V1 = InputBox("ENTER THE NUMBER=")
        TextBox1.Text = V1
        Select Case REMAINDER
            Case 1
                MessageBox.Show("IT IS ODD NUMBER")
            Case 0
                MessageBox.Show("IT IS EVEN NUMBER")
        End Select

    End Sub

    Private Sub B_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_EXIT.Click
        Me.Dispose()
    End Sub
End Class
