Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strText As String
        Dim letter As String
        Dim letterCount As Integer
        strText = "Debugging"

        For i = 1 To strText.Length - 1
            letter = strText.Substring(1)
            If letter = "g" Then
                letterCount = letterCount + 1
            End If
        Next
    End Sub
End Class
