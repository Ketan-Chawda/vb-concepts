Public Class Form1
    Dim TIME As Integer
    Dim HR As Integer
    Dim MIN As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CLEAN()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If (TIME = 59) Then
            MIN = MIN + 1
            TIME = 0
        End If
        If (MIN = 59) Then
            HR = HR + 1
            MIN = 0
        End If
        L_HR.Text = HR
        L_MIN.Text = MIN
        L_SEC.Text = TIME
        TIME = TIME + 1
    End Sub

    Private Sub B_START_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_START.Click
        Timer1.Start()
    End Sub

    Private Sub B_STOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_STOP.Click
        Timer1.Stop()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer1.Start()
    End Sub

    Private Sub B_REFRESH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_REFRESH.Click
        CLEAN()
    End Sub
    Public Sub CLEAN()
        HR = 0
        MIN = 0
        TIME = 0
        L_HR.Text = HR
        L_MIN.Text = MIN
        L_SEC.Text = TIME
    End Sub

    Private Sub B_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_EXIT.Click
        Me.Dispose()
    End Sub
End Class
