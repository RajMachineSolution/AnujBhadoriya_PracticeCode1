Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strUpper As String
        strUpper = TextBox1.Text
        TextBox2.Text = strUpper.ToUpper()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FirstName As String
        FirstName = Trim(txtFirst.Text)
        If FirstName = "" Then
            MessageBox.Show("Please enter the first name ")
            Exit Sub
        End If
        MessageBox.Show(FirstName)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim OneCharacter As Char
        Dim FirstName As String
        Dim i As Integer
        Dim TextLength As Integer

        FirstName = txtChars.Text
        TextLength = FirstName.Length

        For i = 0 To TextLength - 1

            OneCharacter = FirstName.Chars(i)

            If IsNumeric(OneCharacter) Then

                MessageBox.Show("Number Found - Exiting")
                Exit Sub

            End If
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim LineOfText As String
        Dim i As Integer
        Dim aryTextFile() As String

        LineOfText = "UserName1, Password1, UserName2, Password2"
        aryTextFile = LineOfText.Split(",")
        For i = 0 To UBound(aryTextFile)
            MessageBox.Show(aryTextFile(i))
        Next i
    End Sub

    Private Sub Txtbtn4_TextChanged(sender As Object, e As EventArgs) Handles Txtbtn4.TextChanged

    End Sub
End Class
