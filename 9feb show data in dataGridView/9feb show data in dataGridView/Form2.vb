Public Class Form2
    Dim frmDialog As New Form1
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.DialogResult = DialogResult.OK
        If frmDialog.ShowDialog() = DialogResult.OK Then
            MessageBox.Show("done")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.DialogResult = DialogResult.Cancel
        If frmDialog.ShowDialog() = DialogResult.Cancel Then
            MessageBox.Show("Back")
        End If
    End Sub
End Class