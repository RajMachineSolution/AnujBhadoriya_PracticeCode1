Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call AddNumbers()
    End Sub
    Private Sub AddNumbers()
        Dim First As Integer
        Dim Second As Integer
        Dim answer As Integer

        First = Val(TxtFirstNumber.Text)
        Second = Val(txtSecondNumber.Text)

        answer = First + Second
        MessageBox.Show(answer)

    End Sub

    Private Sub btnCheckEmail_Click(sender As Object, e As EventArgs) Handles btnCheckEmail.Click
        Dim email As String
        Dim chars_to_check As Char = "@"
        email = TextBox1.Text


        Call TestEmail(email, chars_to_check)


    End Sub
    Private Sub TestEmail(email As String, chars_to_check As String)
        Dim position As String
        position = InStr(email, chars_to_check)
        If position = 0 Then
            MessageBox.Show("email is not valid")
            Exit Sub
        End If
        MessageBox.Show("email is valid")
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim IsError As Boolean
        IsError = ErrorCheck()
        If IsError = True Then
            MessageBox.Show("Blank TextBox detected")
        Else
            MessageBox.Show("TextBox is not Blank")
        End If
    End Sub
    Private Function ErrorCheck() As Boolean
        Dim TextBoxData As String
        TextBoxData = Trim(txtFunction.Text)
        If TextBoxData = "" Then
            MessageBox.Show("Blank TextBox detected")
            ErrorCheck = True
        Else
            MessageBox.Show(TextBoxData)
            ErrorCheck = False
        End If
    End Function
End Class
