Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Sub USE()
        'USEFUL FOR RESETING THE TEXT PROPERTY
        Button1.ResetText()
        TextBox1.ResetText()
        RichTextBox1.ResetText()
        CheckBox1.ResetText()
        RadioButton1.ResetText()
        Label1.ResetText()

        'USEFUL SETTING FOCUS TO CONTROL
        Button1.Focus()
        TextBox1.Focus()
        RichTextBox1.Focus()
        CheckBox1.Focus()
        RadioButton1.Focus()
        Label1.Focus()

        'USEFUL FOR BRINGING THE CONTROL ON FRONT,ABOVE OF OTHER TAG
        Button1.BringToFront()
        TextBox1.BringToFront()
        RichTextBox1.BringToFront()
        CheckBox1.BringToFront()
        RadioButton1.BringToFront()
        Label1.BringToFront()

        'USEFUL FOR SIZING AND GIVING LOCATION
        Button1.SetBounds(200, 200, 10, 20)
        TextBox1.SetBounds(200, 200, 10, 20)
        RichTextBox1.SetBounds(200, 200, 10, 20)
        CheckBox1.SetBounds(200, 200, 10, 20)
        RadioButton1.SetBounds(200, 200, 10, 20)
        Label1.SetBounds(200, 200, 10, 20)

        'USEFUL FOR HIDING THE CONTROL
        Button1.Hide()
        TextBox1.Hide()
        RichTextBox1.Hide()
        CheckBox1.Hide()
        RadioButton1.Hide()
        Label1.Hide()

        'USEFUL FOR RELEASING THE RESOURCE USED BY CONTROL
        Button1.Dispose()
        TextBox1.Dispose()
        RichTextBox1.Dispose()
        CheckBox1.Dispose()
        RadioButton1.Dispose()
        Label1.Dispose()

        'USEFUL FOR SHOW THE CONTROL
        Button1.Show()
        TextBox1.Show()
        RichTextBox1.Show()
        CheckBox1.Show()
        RadioButton1.Show()
        Label1.Show()

        'USEFUL FOR ACTIVATING THE CONTROL
        Button1.Select()
        TextBox1.Select()
        RichTextBox1.Select()
        CheckBox1.Select()
        RadioButton1.Select()
        Label1.Select()


        'USEFUL FOR CONVERTING TO STRING
        Button1.ToString()
        TextBox1.ToString()
        RichTextBox1.ToString()
        CheckBox1.ToString()
        RadioButton1.ToString()
        Label1.ToString()


        'USEFUL FOR RE-DRAWING THE CLIENT AREA THE CONTROL
        Button1.Update()
        TextBox1.Update()
        RichTextBox1.Update()
        CheckBox1.Update()
        RadioButton1.Update()
        Label1.Update()

    End Sub
End Class
