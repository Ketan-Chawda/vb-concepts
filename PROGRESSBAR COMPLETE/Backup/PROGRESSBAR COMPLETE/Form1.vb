Public Class Form1

    Private Sub B_RUN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_RUN.Click
        While (ProgressBar1.Value <> ProgressBar1.Maximum)
            ProgressBar1.Value += ProgressBar1.Step
        End While
        MessageBox.Show("THE PROGRAM IS EXECUTED")
    End Sub

    Private Sub B_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_EXIT.Click
        Me.Dispose()
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
