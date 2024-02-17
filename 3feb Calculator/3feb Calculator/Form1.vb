Public Class Form1
    Dim total1 As Integer
    Dim number2 As Integer
    Dim answer As Integer
    Dim operator1 As String
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        total1 = Val(txtDisplay.Text)
        operator1 = "+"
        txtDisplay.Clear()

    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        txtDisplay.Text = txtDisplay.Text & btnZero.Text

    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        txtDisplay.Text = txtDisplay.Text & btnOne.Text
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        txtDisplay.Text = txtDisplay.Text & btnTwo.Text
    End Sub

    Private Sub btnequal_Click(sender As Object, e As EventArgs) Handles btnequal.Click
        Select Case operator1
            Case "+"
                total1 += Val(txtDisplay.Text)
                txtDisplay.Text = total1
            Case "-"
                total1 -= Val(txtDisplay.Text)
                txtDisplay.Text = total1
            Case "*"
                total1 *= Val(txtDisplay.Text)
                txtDisplay.Text = total1
            Case "/"
                total1 /= Val(txtDisplay.Text)
                txtDisplay.Text = total1

        End Select
        MessageBox.Show(total1)
        total1 = 0
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Clear()
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        txtDisplay.Text = txtDisplay.Text & btnThree.Text
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        txtDisplay.Text = txtDisplay.Text & btnFour.Text
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        txtDisplay.Text = txtDisplay.Text & btnFive.Text
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        txtDisplay.Text = txtDisplay.Text & btnSix.Text
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        txtDisplay.Text = txtDisplay.Text & btnSeven.Text
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        txtDisplay.Text = txtDisplay.Text & btnEight.Text
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        txtDisplay.Text = txtDisplay.Text & btnNine.Text
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click

        operator1 = "*"
        total1 = Val(txtDisplay.Text)
        Debug.WriteLine(total1)
        txtDisplay.Clear()

    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        total1 = Val(txtDisplay.Text)
        operator1 = "-"
        txtDisplay.Clear()
    End Sub

    Private Sub btnQuotient_Click_1(sender As Object, e As EventArgs) Handles btnQuotient.Click
        total1 = Val(txtDisplay.Text)
        operator1 = "/"
        txtDisplay.Clear()
    End Sub
End Class
