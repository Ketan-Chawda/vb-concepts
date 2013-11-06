Public Class Form1
   
    Private Sub B_REF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_BYREF.Click
        BYREFERENCE(TextBox1.Text, TextBox2.Text)
    End Sub
    Private Sub B_BYVAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_BYVAL.Click
        Dim V1 As String = TextBox1.Text
        Dim V2 As String = TextBox2.Text
        BYVALUE(V1, V2)
        
    End Sub

    Public Sub BYVALUE(ByVal A As String, ByVal B As String)
        Try
            Dim C As String
            C = A
            A = B
            B = C
            TextBox1.Text = A
            TextBox2.Text = B
            MessageBox.Show("THE VALUE IS INTERCHANGE BYVALUE")
        Catch KAC As Exception
            MessageBox.Show(KAC.Message)
        End Try
    End Sub
    Public Sub BYREFERENCE(ByRef A As String, ByRef B As String)
        Try
            Dim C As String
            C = A
            A = B
            B = C
            MessageBox.Show("THE VALUE IS INTERCHANGE BYREFERENCE")
        Catch KS As Exception
            MessageBox.Show(KS.Message)
        End Try
    End Sub

    Private Sub B_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_EXIT.Click
        Me.Dispose()
    End Sub

End Class
