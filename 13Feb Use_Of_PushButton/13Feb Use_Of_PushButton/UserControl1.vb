Imports System.Data.SqlClient

Public Class UserControl1

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private da As SqlDataAdapter
    Private ds As New DataSet
    Private dt As New DataTable

    Private results As String
    Private dread As Integer
    Private dwrite As Integer



    Private Sub btnPush_Click(sender As Object, e As EventArgs) Handles btnPush.Click

        If dread = 0 Then
            btnPush.BackColor = Color.ForestGreen

            dread = 1
            myCmd.CommandText = "update push_table set [read] ='" & dread & "', [write] = 0 where [serial no] = '" & Val(results) & "' "


            da.Fill(dt)
        ElseIf dread = 1 Then
            btnPush.BackColor = Color.Red
            dread = 0
            myCmd.CommandText = "update push_Table set [read] = '" & dread & "', [write] = 1 where [serial no] = '" & Val(results) & "' "



        End If



        myConn.Open()
        myCmd.ExecuteNonQuery()

        myConn.Close()


    End Sub

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles Me.Load
        myConn = New SqlConnection("Data Source = DESKTOP-ASUS;Initial Catalog=admin1;Integrated Security=SSPI")
        myCmd = myConn.CreateCommand

        da = New SqlDataAdapter(myCmd)

        myCmd.CommandText = "select [serial no],[write],[read] from push_table where [serial no] = (select count([serial no]) from push_table)"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            results = myReader.GetInt32(0) & vbLf
            dwrite = myReader.GetInt32(1) & vbLf
            dread = myReader.GetInt32(2) & vbLf
        Loop
        myConn.Close()

    End Sub
End Class
