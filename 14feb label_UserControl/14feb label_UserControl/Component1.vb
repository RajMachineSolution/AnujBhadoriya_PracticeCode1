Imports System.Data.SqlClient
Public Class Component1
    Private myConn As SqlConnection
    Private myCmd As New SqlCommand
    Private myReader As SqlDataReader
    Private ds As New DataSet
    Private da As SqlDataAdapter
    Private dt As New DataTable()
    Private results As String
    Private results1 As String()
    Public Ddata(500) As Int16


    Public Sub ConnectSqlServer1()
        myConn = New SqlConnection("Data Source=Desktop-Asus;Initial Catalog=admin1;Integrated Security=SSPI;")
        myCmd = myConn.CreateCommand
        da = New SqlDataAdapter(myCmd)
        myCmd.CommandText = "select [D] from D1000 where [serialno] = 1"
        myConn.Open()
        da.Fill(ds)
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            results = myReader.GetString(0) & vbLf

        Loop
        myReader.Close()
        myConn.Close()

        results1 = Split(results, ",")
        Dim i As Integer

        Do While i < results1.Length()
            Ddata(i) = Val(results1(i))
            i = i + 1
        Loop

    End Sub
End Class
