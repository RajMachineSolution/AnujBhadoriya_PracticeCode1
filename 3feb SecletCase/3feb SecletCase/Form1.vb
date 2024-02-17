Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim realage As Integer
        realage = Val(TextBox1.Text)
        Select Case realage

            Case 0 To 14
                MessageBox.Show("Pediatric group")
            Case 15 To 47
                MessageBox.Show("youth group")
            Case 48 To 63
                MessageBox.Show("mmiddle age group")
            Case Else
                MessageBox.Show("elderly group")
        End Select

    End Sub
End Class
