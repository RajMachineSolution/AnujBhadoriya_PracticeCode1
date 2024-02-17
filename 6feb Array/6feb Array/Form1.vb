Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number() As Integer
        Dim startAt As Integer
        Dim endAt As Integer
        Dim times As Integer
        Dim storeAnswer As Integer



        Dim i As Integer
        times = Val(txtTimes.Text)
        startAt = Val(txtStartAt.Text)
        endAt = Val(txtEndAt.Text)
        ReDim number(endAt)
        For i = startAt To endAt
            storeAnswer = i * times
            number(i) = storeAnswer
            ListBox1.Items.Add(times & " times " & i & " = " & number(i))
        Next i

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim stringArray(5) As String
        stringArray(0) = txtStringArray0.Text
        stringArray(1) = txtStringArray1.Text
        stringArray(2) = txtStringArray2.Text
        stringArray(3) = txtStringArray3.Text
        stringArray(4) = txtStringArray4.Text
        stringArray(5) = txtStringArray5.Text
        MessageBox.Show(stringArray.Length)
        For i = 0 To 5
            ListBox2.Items.Add(stringArray(i))
        Next

    End Sub

    Private Sub txtStringArray0_TextChanged(sender As Object, e As EventArgs) Handles txtStringArray0.TextChanged

    End Sub
End Class
