Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim File_Name As String = "C:\Users\asus\Desktop\febWork\3feb work.txt"
        Dim objectReader As New System.IO.StreamReader(File_Name)
        TextBox1.Text = objectReader.ReadToEnd
        objectReader.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim File_Name As String = "C:\Users\asus\Desktop\febWork\5feb work.txt"
        Dim TextLine As String

        Dim objectReader As New System.IO.StreamReader(File_Name)
        If System.IO.File.Exists(File_Name) = True Then
            Do While objectReader.Peek() <> -1
                TextLine = TextLine & objectReader.ReadLine() & vbNewLine
            Loop
            TextBox1.Text = TextLine
        End If

        objectReader.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim File_Name As String = "C:\Users\asus\Desktop\febWork\6feb test.txt"
        Dim objWriter As New System.IO.StreamWriter(File_Name)
        If System.IO.File.Exists(File_Name) = True Then
            objWriter.Write(TextBox1.Text)
            objWriter.Close()
            MessageBox.Show("Text written to file")
            Exit Sub
        End If
        MessageBox.Show("file is empty")
    End Sub
End Class
