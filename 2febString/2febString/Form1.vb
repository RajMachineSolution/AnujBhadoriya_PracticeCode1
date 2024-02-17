Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FirstName As String
        Dim LastName As String
        Dim FullName As String

        FirstName = "Bill"
        LastName = "Gates"

        txtFirstName.Text = FirstName
        txtLastName.Text = LastName

        FullName = FirstName & " " & LastName

        txtFullName.Text = FullName

        MessageBox.Show(FullName)

    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtFullName.TextChanged

    End Sub
End Class
