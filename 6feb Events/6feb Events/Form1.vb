Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click
        MessageBox.Show("I can handle two buttons click")
    End Sub

    Private Sub Button3_MouseDown(sender As Object, e As MouseEventArgs) Handles Button3.MouseDown
        If e.Button = MouseButtons.Right Then
            MessageBox.Show("Right button clicked")
        End If
        If e.Button = MouseButtons.Middle Then
            MessageBox.Show("middle button clicked")
        End If
        If e.Button = MouseButtons.Left Then
            MessageBox.Show("Left button clicked")
        End If

    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

        Dim xPos As Integer
        Dim yPos As Integer
        If e.Button = MouseButtons.Right Then

            xPos = e.X
            yPos = e.Y

            MessageBox.Show("The X Position is " & xPos & "the Y Position is " & yPos)
        End If

    End Sub
End Class
