Public Class frmSecond
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim ChangeCase As String
        ChangeCase = Form1.tb.Text
        If optUpperCase.Checked Then

            ChangeCase = ChangeCase.ToUpper

        ElseIf optLowerCase.Checked Then

            ChangeCase = ChangeCase.ToLower

        ElseIf optProperCase.Checked Then

            ChangeCase = StrConv(ChangeCase, VbStrConv.ProperCase)

        End If

        Form1.tb.Text = ChangeCase

        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class