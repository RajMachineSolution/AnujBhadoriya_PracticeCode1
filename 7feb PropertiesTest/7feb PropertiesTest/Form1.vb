Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim student As New PropertyTest()
        student.ConvertToUpper = TextBox1.Text
        TextBox1.Text = student.ConvertToUpper

        student.DisplayGreeting = TextBox1.Text

        Dim finalMessage As String = student.WrapUp
        MessageBox.Show(finalMessage)


    End Sub
End Class
