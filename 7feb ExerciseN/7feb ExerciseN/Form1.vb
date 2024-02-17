Public Class Form1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        Dim checkBox As String
        checkBox = Trim(TextBox1.Text)
        checkBox = StrConv(checkBox, VbStrConv.Uppercase)
        TextBox1.Text = checkBox

    End Sub
End Class
