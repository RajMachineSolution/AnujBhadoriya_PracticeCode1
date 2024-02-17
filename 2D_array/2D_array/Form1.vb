Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim row As Integer
        Dim col As Integer
        Dim ends As Integer
        Dim count As Integer = 1

        Dim i As Integer
        ends = Val(TextBox1.Text)
        Dim matrix(ends, ends) As Integer


        For row = 0 To ends
            For col = 0 To ends

                matrix(row, col) = count
                count += 2


            Next

        Next

        Dim temp As String = ""

        For row = 0 To ends
            For col = 0 To ends

                temp = temp & " " & matrix(row, col)


            Next

            ListBox1.Items.Add(temp)
            temp = ""

        Next



    End Sub
End Class
