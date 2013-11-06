Public Class KETAN
    Protected Overridable Sub DISPLAY()
        MessageBox.Show("THIS IS A DISPLAY-PROCEDURE WAS CREATED IN BASE-CLASS")
    End Sub
    Protected Overridable Sub LIST()
        MessageBox.Show("THIS IS A LIST-PROCEDURE WAS CREATED IN BASE-CLASS")
    End Sub


    Private Sub B_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_EXIT.Click
        Me.Dispose()
    End Sub

    Private Sub B_DISPLAY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_DISPLAY.Click
        Dim K As New KAC()
        K.DISPLAY()
    End Sub
End Class
Public Class KAC
    Inherits KETAN
    Protected Overrides Sub DISPLAY()
        MessageBox.Show("THIS IS A DISPLAY-PROCEDURE WAS CREATED IN DERIVED-CLASS")
        MyClass.LIST()
    End Sub
    Protected Overrides Sub LIST()
        MessageBox.Show("THIS IS A LIST-PROCEDURE WAS CREATED IN DERIVED-CLASS")
    End Sub

End Class
