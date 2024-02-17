Public Class ConvertPoscode
    Public Function DoConvert(ByVal postcode As String) As String
        Dim convertPostcode As String
        convertPostcode = StrConv(postcode, VbStrConv.Uppercase)
        DoConvert = convertPostcode
    End Function

End Class
