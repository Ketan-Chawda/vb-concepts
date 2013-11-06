Public Class Form1

    Private Sub B_CHECK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_CHECK.Click
        Dim VALUE As Integer
        VALUE = InputBox("ENTER THE NUMBER=")
        TextBox1.Text = VALUE
        If (VALUE > 0) Then
            MessageBox.Show("IT IS A POSITIVE NUMBER")
        ElseIf (VALUE < 0) Then
            MessageBox.Show("IT IS A NEGATIVE NUMBER")
        ElseIf (VALUE = 0) Then
            MessageBox.Show("IT IS A ZERO")
        Else
            MessageBox.Show("IT IS NOT A INTEGER VALUE")
        End If
    End Sub

    Private Sub B_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_EXIT.Click
        Me.Dispose()
    End Sub
End Class
