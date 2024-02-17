Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim myVariable As String

        myVariable = ComboBox1.Text
        MessageBox.Show(myVariable)
    End Sub
End Class
