Public Class STUDENT
    Implements GLOBALLY
    Function DISPLAY() As String Implements GLOBALLY.DISPLAY
        Return "THIS IS A FUNCTION CREATED IN STUDENT-CLASS"
    End Function
    Private Sub DISPLAYALL() Implements GLOBALLY.DISPLAYALL
        MessageBox.Show("THIS IS A PROCEDURE CREATED IN STUDENT-CLASS")
    End Sub

    Private Sub B_DISPLAY1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_DISPLAY1.Click
        Dim K1 As New STUDENT()
        TextBox1.Text = K1.DISPLAY()
    End Sub

    Private Sub B_DISPLAYALL1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_DISPLAYALL1.Click
        Dim K2 As New STUDENT
        K2.DISPLAYALL()
    End Sub

    Private Sub B_DISPLAY2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_DISPLAY2.Click
        Dim S1 As New STAFF
        TextBox1.Text = S1.DISPLAY()
    End Sub

    Private Sub B_DISPLAYALL2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_DISPLAYALL2.Click
        Dim S2 As New STAFF
        S2.DISPLAYALL()
    End Sub

    Private Sub B_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_EXIT.Click
        Me.Dispose()
    End Sub
End Class
Public Class STAFF
    Implements GLOBALLY
    Function DISPLAY() As String Implements GLOBALLY.DISPLAY
        Return "THIS IS A FUNCTION CREATED IN STAFF-CLASS"
    End Function
    Sub DISPLAYALL() Implements GLOBALLY.DISPLAYALL
        MessageBox.Show("THIS IS A PROCEDURE CREATED IN STAFF-CLASS")
    End Sub
End Class
Public Interface GLOBALLY
    Function DISPLAY() As String
    Sub DISPLAYALL()
End Interface