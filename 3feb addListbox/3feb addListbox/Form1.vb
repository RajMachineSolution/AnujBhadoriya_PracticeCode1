Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblStart.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblEnd.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtStart.TextChanged

    End Sub

    Private Sub TxtEnd_TextChanged(sender As Object, e As EventArgs) Handles TxtEnd.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim startNumber As Integer
        Dim endNumber As Integer
        Dim i As Integer
        Dim answer As Integer
        Dim multiplier As Integer

        multiplier = 2

        startNumber = TxtStart.Text
        endNumber = Val(TxtEnd.Text)

        For i = startNumber To endNumber
            answer = i * multiplier
            ListBox1.Items.Add(i & " times " & multiplier & " = " & answer)
        Next i
    End Sub
End Class
