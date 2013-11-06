Public Class Form1
    Private Sub L_COLORDIALOGBOX_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles L_COLORDIALOGBOX.LinkClicked
        ColorDialog1.ShowDialog()
    End Sub

    Private Sub L_OPENFILE_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles L_OPENFILE.LinkClicked
        OpenFileDialog1.ShowDialog()
    End Sub

End Class
