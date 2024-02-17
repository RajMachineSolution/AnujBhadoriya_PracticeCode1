Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim testNumber As Short
        Dim number3 As Integer
        Dim number2 As Single
        Dim number1 As Double
        Dim number4 As Decimal

        testNumber = Val(txtNumber.Text)
        number3 = 5 + testNumber

        MessageBox.Show(testNumber)
        MessageBox.Show(number3)

        number2 = 545.4678 * 456
        txtSingle.Text = number2
        MessageBox.Show(number2)

        number1 = 4567.4567 * 5
        txtDouble.Text = number1
        MessageBox.Show(number1)

        number4 = 54.55 * 56
        txtDecimal.Text = number4
        MessageBox.Show(number4)



    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtSingle.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_2(sender As Object, e As EventArgs) Handles txtDecimal.TextChanged

    End Sub
End Class
