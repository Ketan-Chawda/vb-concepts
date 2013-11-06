Public Class Form1

    Private Sub B_ADD1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_ADD1.Click
        ListBox1.Items.Add(T_INPUT.Text)
        T_INPUT.Text = ""
    End Sub

    Private Sub B_ADD2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_ADD2.Click
        ListBox2.Items.Add(T_INPUT.Text)
        T_INPUT.Text = ""
    End Sub

    Private Sub SEARCH1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCH1.Click
        Dim FINDITEM As String = T_INPUT.Text
        If (ListBox1.Items.Contains(FINDITEM)) Then
            MessageBox.Show("YES THE ITEM IS FOUND IN THIS COLLECTION LISTBOX1")
            MessageBox.Show("IT IS LOCATED AT=" & ListBox1.Items.IndexOf(FINDITEM))
        Else
            MessageBox.Show("NO THE ITEM IS NOT FOUND IN THIS COLLECTION LISTBOX1")
        End If
    End Sub

    Private Sub SEARCH2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEARCH2.Click
        Dim FINDITEM As String = T_INPUT.Text
        If (ListBox2.Items.Contains(FINDITEM)) Then
            MessageBox.Show("YES THE ITEM IS FOUND IN THIS COLLECTION LISTBOX2")
            MessageBox.Show("IT IS LOCATED AT=" & ListBox2.Items.IndexOf(FINDITEM))
        Else
            MessageBox.Show("NO THE ITEM IS NOT FOUND IN THIS COLLECTION LISTBOX2")
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("A")
        ListBox2.Items.Add("B")
        ListBox1.Items.Add("C")
        ListBox2.Items.Add("D")
    End Sub

    Private Sub B_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_EXIT.Click
        Me.Dispose()
    End Sub

    Private Sub C12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C12.Click
        Dim TOTAL As Integer = ListBox1.SelectedItems.Count()
        Dim K As Integer
        For K = 0 To TOTAL - 1
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        Next
    End Sub

    Private Sub C21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C21.Click
        Dim TOTAL As Integer = ListBox2.SelectedItems.Count()
        Dim K As Integer
        For K = 0 To TOTAL - 1
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        Next
    End Sub

    Private Sub CALL12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CALL12.Click
        Dim ALL As Integer = ListBox1.Items.Count()
        Dim S As Integer
        For S = 0 To ALL - 1
            ListBox2.Items.Add(ListBox1.Items.Item(0))
            ListBox1.Items.RemoveAt(0)
        Next
    End Sub

    Private Sub CALL21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CALL21.Click
        Dim ALL As Integer = ListBox2.Items.Count()
        Dim S As Integer
        For S = 0 To ALL - 1
            ListBox1.Items.Add(ListBox2.Items.Item(0))
            ListBox2.Items.RemoveAt(0)
        Next
    End Sub

    Private Sub C_SORT1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_SORT1.CheckedChanged
        If (C_SORT1.Checked) Then
            ListBox1.Sorted = True
        Else
            ListBox1.Sorted = False
        End If
    End Sub

    Private Sub C_SORT2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_SORT2.CheckedChanged
        If (C_SORT2.Checked) Then
            ListBox2.Sorted = True
        Else
            ListBox2.Sorted = False
        End If
    End Sub
End Class
