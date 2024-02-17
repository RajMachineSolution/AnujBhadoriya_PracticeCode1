Module modVerify
    Public Sub AddNumbers(ByVal num1 As Integer)
        Dim answer As Integer
        answer = num1 + 10
        MessageBox.Show(answer)
    End Sub
    Public Function VerifyPostcode(ByVal postcode As String) As String
        postcode = StrConv(postcode, VbStrConv.Uppercase)
        Return postcode
    End Function
End Module

