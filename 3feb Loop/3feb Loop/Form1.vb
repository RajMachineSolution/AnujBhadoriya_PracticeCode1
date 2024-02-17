Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim startNumber As Integer
        Dim answer As Integer

        For startNumber = 1 To 10
            answer = answer + startNumber
        Next startNumber
        TextBox1.Text = answer
        TextBox1.Text = answer
        MessageBox.Show(answer)
    End Sub
End Class
