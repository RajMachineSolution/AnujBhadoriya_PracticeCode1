Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objAlterPicBox As OwnProperty
        Dim newHeight As Integer
        Dim newWidth As Integer
        objAlterPicBox = New OwnProperty

        objAlterPicBox.ChangeHeight = Val(txtHeight.Text)
        newHeight = objAlterPicBox.ChangeHeight
        PictureBox1.Height = newHeight

        objAlterPicBox.ChangeWidth = Val(txtWidth.Text)
        newWidth = objAlterPicBox.ChangeWidth
        PictureBox1.Width = newWidth


    End Sub
End Class
