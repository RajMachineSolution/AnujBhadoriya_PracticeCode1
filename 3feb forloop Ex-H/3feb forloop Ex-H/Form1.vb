Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim startNumber As Integer
        Dim endNumber As Integer
        Dim i As Integer
        Dim answer As Integer

        startNumber = Val(TextBox1.Text)
        endNumber = Val(TextBox2.Text)
        If startNumber = 0 Or endNumber = 0 Then
            MessageBox.Show("empty textbox")
            Exit Sub
        End If
        For i = startNumber To endNumber
            answer = answer + i
        Next i
        MessageBox.Show(answer)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
