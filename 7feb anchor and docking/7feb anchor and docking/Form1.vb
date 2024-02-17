Public Class Form1
    Public Shared tb As TextBox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SecondForm As New frmSecond
        SecondForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmDialogue As New frmSecond
        If frmDialogue.ShowDialog() = DialogResult.OK Then
            MessageBox.Show("ok button clicked")
        End If
        If frmDialogue.ShowDialog() = DialogResult.Cancel Then
            MessageBox.Show("cancel button clicked")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        tb = TextBox3
    End Sub
End Class
