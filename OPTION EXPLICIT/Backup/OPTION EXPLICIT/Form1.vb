Imports OPTION_EXPLICIT
Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MYKETAN()
    End Sub
OPTION Explicit OFF
    Sub MYKETAN()
        Try
            Dim K As Integer = 12
            Dim S As Integer = 31
            L = K + S
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
        End Try

    End Sub
End Class
