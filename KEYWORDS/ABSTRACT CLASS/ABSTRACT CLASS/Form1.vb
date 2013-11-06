Public MustInherit Class CLIENT
    Protected CNO As Integer = 12
    Protected CNAME As String = "KETAN A CHAWDA"

    Public Function DISPLAYCLIENT() As String
        Return "CLIENT NUMBER IS =" + CNO.ToString + vbCrLf + CNAME
    End Function

    Private Sub B_CLIENT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_CLIENT.Click
        MessageBox.Show("YOU CAN'T CREATE THE OBJECT OR INSTANCE OF THIS CLASS,IT IS ABSTRACT CLASS")
    End Sub

    Private Sub B_PRODUCT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_PRODUCT.Click
        Try
            Dim C1 As New PRODUCT()
            MessageBox.Show("YES OBJECT IS CREATED")
        Catch EX As Exception
            MessageBox.Show(EX.Message)
        End Try
    End Sub

    Private Sub B_ORDER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_ORDER.Click
        Try
            Dim C1 As New ORDER()
            MessageBox.Show("YES OBJECT IS CREATED")
        Catch EX As Exception
            MessageBox.Show(EX.Message)
        End Try
    End Sub

    Private Sub B_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_EXIT.Click
        Me.Dispose()
    End Sub

    Private Sub B_ALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_ALL.Click
        Dim KAC As New ORDER
        TextBox1.Text = KAC.DISPLAYCLIENT
        TextBox2.Text = KAC.DISPLAYPRODUCT
        TextBox3.Text = KAC.DISPLAYORDER
        MessageBox.Show("BY CREATING OBJECT OF OREDER CLASS WE CAN ACCESS ALL SINCE WE HAVE INHERITED FROM BOTH THE TWO ABOVE CLASS")
    End Sub
End Class
Public Class PRODUCT
    Inherits CLIENT
    Private PNO As Integer = 6532
    Private PNAME As String = "SPLENDOR+"

    Public Function DISPLAYPRODUCT() As String
        Return "PRODUCT NUMBER IS =" + PNO.ToString + vbCrLf + PNAME
    End Function

End Class
Public Class ORDER
    Inherits PRODUCT
    Private ONO As Integer
    Public Function DISPLAYORDER() As String
        Return "ORDER NUMBER IS =" + ONO.ToString
    End Function
End Class

