Public Class Form1

    Private Sub B_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_EXIT.Click
        Me.Dispose()
    End Sub

    Private Sub B_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_ADD.Click
        ComboBox1.Items.Add(T_INPUT.Text)
        T_INPUT.Text = ""
    End Sub

    Private Sub C_SORT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_SORT.CheckedChanged
        If (C_SORT.Checked) Then
            ComboBox1.Sorted = True
        Else
            ComboBox1.Sorted = False
        End If
    End Sub

    Private Sub B_SEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_SEARCH.Click
        If (ComboBox1.Items.IndexOf(T_INPUT.Text) >= 0) Then
            MessageBox.Show("YES ITEM IS FOUND AT LOCATION=" & ComboBox1.Items.IndexOf(T_INPUT.Text))
        Else
            MessageBox.Show("NOT FOUND")
        End If
    End Sub
End Class
