Imports System.Data.SqlClient
Public Class Form1
    Inherits System.Windows.Forms.Form
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results0 As Integer
    Private results1 As String
    Private results2 As String
    Private results3 As String
    Private results4 As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = results0
        TextBox2.Text = results1
        TextBox3.Text = results2
        TextBox4.Text = results3
        TextBox5.Text = results4

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConn = New SqlConnection("Data Source=DESKTOP-ASUS;Initial Catalog=admin1;Integrated Security=True")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "select * from Persons "

        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            results0 = results0 & myReader.GetInt32(0) & vbLf
            results1 = results1 & myReader.GetString(1) & vbLf
            results2 = results2 & myReader.GetString(2) & vbLf
            results3 = results3 & myReader.GetString(3) & vbLf
            results4 = results4 & myReader.GetString(4) & vbLf
        Loop


        myReader.Close()
        myConn.Close()


    End Sub
End Class
