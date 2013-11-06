Public Class Form1

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Label6.Text = TrackBar1.Value
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = TrackBar1.Maximum
        Label4.Text = TrackBar1.Minimum
        Label6.Text = TrackBar1.Value
    End Sub
End Class
