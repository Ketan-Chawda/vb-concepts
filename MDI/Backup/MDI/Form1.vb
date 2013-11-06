Public Class Form1

    Private Sub B_FORM2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_FORM2.Click
        Form2.MdiParent = Me
        Form2.Show()
    End Sub

    Private Sub B_FORM3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_FORM3.Click
        Form3.MdiParent = Me
        Form3.Show()
    End Sub

    Private Sub B_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_EXIT.Click
        Me.Dispose()
    End Sub
End Class
