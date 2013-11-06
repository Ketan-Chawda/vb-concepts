Public Class MATHS

    Private Overloads Function ADD(ByVal T1 As Integer, ByVal T2 As Integer)
        MessageBox.Show("A FUNCTION WITH 2 ARGUMENTS IS CALLED OF INTEGER")
        Return T1 + T2
    End Function
    Private Overloads Function ADD(ByVal T1 As Double, ByVal T2 As Double)
        MessageBox.Show("A FUNCTION WITH 2 ARGUMENTS IS CALLED OF DOUBLE")
        Return T1 + T2
    End Function


    Private Overloads Function ADD(ByVal T1 As Integer, ByVal T2 As Integer, ByVal T3 As Integer)
        MessageBox.Show("A FUNCTION WITH 3 ARGUMENTS IS CALLED")
        Return T1 + T2 + T3
    End Function

    Private Overloads Function ADD(ByVal T1 As Integer, ByVal T2 As Integer, ByVal T3 As Integer, ByVal T4 As Integer)
        MessageBox.Show("A FUNCTION WITH 4 ARGUMENTS IS CALLED")
        Return T1 + T2 + T3 + T4
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If (TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "") Then
            TextBox5.Text = ADD(CInt(TextBox1.Text), CInt(TextBox2.Text), CInt(TextBox3.Text), CInt(TextBox4.Text))
        ElseIf (TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "") Then
            TextBox5.Text = ADD(CInt(TextBox1.Text), CInt(TextBox2.Text), CInt(TextBox3.Text))
        ElseIf (TextBox1.Text <> "" And TextBox2.Text <> "") Then
            TextBox5.Text = ADD(11, 22.333)
        Else
            MessageBox.Show("INSUFFICIENT VALUE FOR CALLNG A FUNCTON")
        End If
    End Sub

    Private Sub B_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_EXIT.Click
        Me.Dispose()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If (TextBox1.Text.Length > 0) Then
            TextBox2.Enabled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If (TextBox2.Text.Length > 0) Then
            TextBox3.Enabled = True
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If (TextBox3.Text.Length > 0) Then
            TextBox4.Enabled = True
        End If
    End Sub

    Private Sub MATHS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
    End Sub

End Class
