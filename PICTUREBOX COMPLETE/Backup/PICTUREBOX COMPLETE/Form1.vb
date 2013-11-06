Public Class Form1
    Dim STR As String

    Private Sub B_DISPLAY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_DISPLAY.Click
        While (ProgressBar1.Value <> ProgressBar1.Maximum)
            ProgressBar1.Value += ProgressBar1.Step
        End While
        If (STR <> "") Then
            Picture1.BackgroundImage = Image.FromFile(STR)
        Else
            MessageBox.Show("ENTER VALID PATH")
        End If
    End Sub

    Private Sub B_BROWSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_BROWSE.Click
        OpenFileDialog1.ShowDialog()
        STR = OpenFileDialog1.FileName
        T_INPUT.Text = STR
    End Sub

    Private Sub B_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_EXIT.Click
        Me.Dispose()
    End Sub

    Private Sub C_TILE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_TILE.CheckedChanged
        If (C_TILE.Checked) Then
            Picture1.BackgroundImageLayout = ImageLayout.Tile
        End If
    End Sub

    Private Sub C_CENTER_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_CENTER.CheckedChanged
        If (C_CENTER.Checked) Then
            Picture1.BackgroundImageLayout = ImageLayout.Center
        Else
            Picture1.BackgroundImageLayout = ImageLayout.None
        End If
    End Sub

    Private Sub C_ZOOM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_ZOOM.CheckedChanged
        If (C_ZOOM.Checked) Then
            Picture1.BackgroundImageLayout = ImageLayout.Zoom
        Else
            Picture1.BackgroundImageLayout = ImageLayout.None
        End If

    End Sub

    Private Sub C_STRETCH_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C_STRETCH.CheckedChanged
        If (C_STRETCH.Checked) Then
            Picture1.BackgroundImageLayout = ImageLayout.Stretch
        Else
            Picture1.BackgroundImageLayout = ImageLayout.None
        End If
    End Sub

    Private Sub Picture1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picture1.Click

    End Sub
End Class
