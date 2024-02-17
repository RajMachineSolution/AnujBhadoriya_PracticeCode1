Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NewCode As String
        Dim objConvertPoscode As ConvertPoscode
        objConvertPoscode = New ConvertPoscode
        NewCode = objConvertPoscode.DoConvert(TextBox1.Text)
        TextBox1.Text = NewCode

    End Sub
End Class
