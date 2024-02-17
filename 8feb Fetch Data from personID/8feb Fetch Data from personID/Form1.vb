Imports System.Data.SqlClient
Public Class Form1
    Inherits System.Windows.Forms.Form
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private results1 As String
    Private num1 As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myConn = New SqlConnection("Data Source=DESKTOP-ASUS;Initial Catalog=admin1;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select * From persons "
        myConn.Open()
        myReader = myCmd.ExecuteReader()

        Dim inc As Integer = 1
        Do While myReader.Read()

            results = myReader.GetInt32(0) & vbTab & myReader.GetString(1) & vbTab & myReader.GetString(2) & vbTab & myReader.GetString(3) & vbTab & myReader.GetString(4) & vbLf
            If num1 = inc Then
                ListBox1.Items.Add(results)
            End If
            inc = Inc + 1
        Loop
        myReader.Close()
        myConn.Close()
        MessageBox.Show(num1)



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        num1 = Val(TextBox1.Text)
    End Sub
End Class
