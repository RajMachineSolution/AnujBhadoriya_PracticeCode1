Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.F1 Then
            TextBox1.Clear()
            MessageBox.Show("Help!!!")
        End If
        Dim recordText As String
        recordText = recordText & Chr(e.KeyCode)
    End Sub
End Class
