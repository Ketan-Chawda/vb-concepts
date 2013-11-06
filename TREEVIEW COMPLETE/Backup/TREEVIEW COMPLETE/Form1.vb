Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim total As Integer
        Dim str As String
        Dim myarray() As String
        'TreeView1.Sort()
        'TreeView1.ExpandAll()
        'TreeView1.CollapseAll()
        'TreeView1.Dispose ()
        'TreeView1.Hide()
        'TreeView1.Show()
        'total = TreeView1.GetNodeCount(True)
        TextBox1.Text = total
        'TreeView1.ToString()
        'TreeView1.GetNodeAt (50, 100)
        '**********************************************************************************
        'TreeView1.BeginUpdate()
        'TreeView1.GetNextControl(TextBox1, True)
        'If (TreeView1.Contains() = True) Then
        'End If
        '********************************************************************************
        TreeView1.Nodes.Clear()
        TreeView1.Nodes.Add("ketan")
        'TreeView1.Nodes.CopyTo(myarray, 3)
        'TreeView1.Nodes.Insert(2, "india")
        'TreeView1.Nodes.RemoveAt(1)
        '        Dim myarray() As String
        '       TreeView1.Nodes.CopyTo(myarray, 0)
        'TextBox1.Text = TreeView1.Nodes.Find("india", True).ToString
        'TreeView1.Nodes.RemoveByKey("australia")
        total = TreeView1.Nodes.IndexOf()
        TextBox1.Text = TreeView1.Nodes.Count()
        'TreeView1.Nodes.Remove("india")
        'If (TreeView1.IsMnemonic(*, "india")) Then

        '  End If
        str = TextBox1.SelectedText()
        MessageBox.Show("selected text is=", str)


        'If (TreeView1.IsMnemonic("&")) Then

        'End If
        'Label1.Dispose()
        'TextBox1.ToString()
        'TreeView1.ToString()
    End Sub
End Class
