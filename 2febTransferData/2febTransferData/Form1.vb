Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtVariable.TextChanged

    End Sub

    Private Sub btntransfer_Click(sender As Object, e As EventArgs) Handles btntransfer.Click
        Dim labelContents As String
        Dim btnContents As String

        labelContents = IblTransfer.Text
        txtVariable.Text = labelContents

        btnContents = btntransfer.Text
        TextBox1.Text = btnContents


    End Sub

    Private Sub IblTransfer_Click(sender As Object, e As EventArgs) Handles IblTransfer.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
