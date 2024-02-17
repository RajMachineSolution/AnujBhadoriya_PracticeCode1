Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number1 As Integer
        Dim number2 As Integer
        Dim number3 As Integer
        Dim answer As Integer

        number1 = 10
        number2 = 5
        number3 = 50

        answer = number3 * (number1 - number2)
        TextBox1.Text = answer
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
