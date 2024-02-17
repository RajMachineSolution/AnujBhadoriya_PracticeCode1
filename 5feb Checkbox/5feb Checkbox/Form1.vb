Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub frmGroupBox2_Enter(sender As Object, e As EventArgs) Handles frmGroupBox2.Enter

    End Sub

    Private Sub btnSitCom_Click(sender As Object, e As EventArgs) Handles btnSitCom.Click
        Dim ChoosenSitCom As String
        If RadioButton1.Checked = True Then
            ChoosenSitCom = RadioButton1.Text
        ElseIf RadioButton2.Checked = True Then
            ChoosenSitCom = RadioButton2.Text
        ElseIf RadioButton3.Checked = True Then
            ChoosenSitCom = RadioButton3.Text
        ElseIf RadioButton4.Checked = True Then
            ChoosenSitCom = RadioButton5.Text
        ElseIf RadioButton5.Checked = True Then
            ChoosenSitCom = RadioButton5.Text
        Else
            ChoosenSitCom = "you have not choosen"
        End If

        MessageBox.Show("Best SitCom" & vbNewLine & ChoosenSitCom)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub btnWatchedMovies_Click(sender As Object, e As EventArgs) Handles btnWatchedMovies.Click
        Dim message As String
        Dim counter As Integer

        If CheckBox1.CheckState = 1 Then
            message = message & CheckBox1.Text & vbNewLine
            counter += 1
        End If
        If CheckBox2.CheckState = 1 Then
            message = message & CheckBox2.Text & vbNewLine
            counter += 1
        End If
        If CheckBox3.CheckState = 1 Then
            message = message & CheckBox3.Text & vbNewLine
            counter += 1
        End If
        If CheckBox4.CheckState = 1 Then
            message = message & CheckBox4.Text & vbNewLine
            counter += 1
        End If
        If CheckBox5.CheckState = 1 Then
            message = message & CheckBox5.Text & vbNewLine
            counter += 1
        End If
        MessageBox.Show("you have chosen" & counter & "movies")
        MessageBox.Show("you have chosen" & vbNewLine & message)

    End Sub
End Class
