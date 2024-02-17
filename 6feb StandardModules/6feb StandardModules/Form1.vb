Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer = 10
        Dim str1 As String = "cl5skie"
        Dim checkPostCode As String
        Call AddNumbers(num1)
        str1 = str1.Trim()
        checkPostCode = VerifyPostcode(str1)
        MessageBox.Show(checkPostCode)

    End Sub

    Private Sub btnFileName_Click(sender As Object, e As EventArgs) Handles btnFileName.Click
        Dim PathToFolder As String = "C:\Users\asus\Desktop\febWork"
        Dim files As String() = IO.Directory.GetFiles(PathToFolder)
        For Each filepath In files
            txtFileNames.Items.Add(filepath)
        Next
    End Sub

    Private Sub btnGetAllFileNames_Click(sender As Object, e As EventArgs) Handles btnGetAllFileNames.Click
        Dim PathToFolder As String = "C:\Users\asus\Desktop\febWork"
        Dim files As String() = IO.Directory.GetFiles(PathToFolder)
        For Each fileName In files
            ListBox1.Items.Add(IO.Path.GetFileName(fileName))
        Next
    End Sub

    Private Sub btnGetRandomFile_Click(sender As Object, e As EventArgs) Handles btnGetRandomFile.Click
        Dim PathToFolder As String = "C:\Users\asus\Desktop\febWork"
        Dim files As String() = IO.Directory.GetFiles(PathToFolder)
        For i = 0 To 9
            Dim ranFileName As String = IO.Path.GetRandomFileName()
            ListBox2.Items.Add(ranFileName)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim PathToFolder As String = "C:\Users\asus\Desktop\febWork"
        Dim files As String() = IO.Directory.GetFiles(PathToFolder)
        For Each fileExtension In files
            ListBox3.Items.Add(IO.Path.GetExtension(fileExtension))
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim PathToFolder As String = "C:\Users\asus\Desktop\febWork"
        Dim files As String() = IO.Directory.GetFiles(PathToFolder)
        GetFilesAndFolders(PathToFolder)
    End Sub
    Private Sub GetFilesAndFolders(folder_name)
        ListBox4.Items.Add("===================")
        ListBox4.Items.Add("FOLDER:" & folder_name)
        ListBox4.Items.Add("===================")
        For Each singleFile In IO.Directory.GetFiles(folder_name)
            ListBox4.Items.Add(IO.Path.GetFileName(singleFile))
        Next
        For Each folder In IO.Directory.GetDirectories(folder_name)

            GetFilesAndFolders(folder)

        Next
    End Sub
End Class
