Public Class Form1
    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click
        Dim strFileName As String
        OpenFD.InitialDirectory = "C:\"
        OpenFD.Title = "Open a Text File"
        OpenFD.Filter = "Text File(.txt)|*.txt|Word File(.doc)|*.doc"

        Dim didWork As Integer = OpenFD.ShowDialog()
        If didWork = DialogResult.Cancel Then
            MessageBox.Show("Cancel Button Clicked")
        Else
            strFileName = OpenFD.FileName
            TextBox2.Text = strFileName
            MessageBox.Show(strFileName)
            OpenFD.Reset()

        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        SaveFD.ShowDialog()
        SaveFD.OverwritePrompt = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub EdtCpy_Click(sender As Object, e As EventArgs) Handles EdtCpy.Click
        TextBox1.Copy()
    End Sub

    Private Sub EdtPaste_Click(sender As Object, e As EventArgs) Handles EdtPaste.Click
        TextBox2.Paste()
        TextBox1.Paste()
    End Sub

    Private Sub mnViewTextBoxes_Click(sender As Object, e As EventArgs) Handles mnViewTextBoxes.Click
        mnViewTextBoxes.Checked = Not mnViewTextBoxes.Checked
        If mnViewTextBoxes.Checked = True Then
            TextBox1.Visible = True
            TextBox2.Visible = True
        Else
            TextBox1.Visible = False
            TextBox2.Visible = False
        End If
    End Sub

    Private Sub mnuViewImages_Click(sender As Object, e As EventArgs) Handles mnuViewImages.Click
        Dim strFileName As String
        OpenFD.InitialDirectory = "C:\"
        OpenFD.Title = "open an image"
        OpenFD.Filter = "jpegs|*.jpg|gifs|*.gif"
        Dim didWork As Integer = OpenFD.ShowDialog()
        If didWork <> DialogResult.Cancel Then
            strFileName = OpenFD.FileName
            PictureBox1.Image = Image.FromFile(strFileName)
            OpenFD.Reset()

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
