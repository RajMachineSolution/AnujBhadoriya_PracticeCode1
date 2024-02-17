Public Class Form1
    Private rt1 As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rt1 As Object

        Try

            rt1.LoadFile("C:\test10.txt", RichTextBoxStreamType.PlainText)

        Catch ex As System.IO.FileNotFoundException

            MessageBox.Show(ex.Message)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class
