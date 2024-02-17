Imports System.Data.SqlClient
Public Class Form1
    Inherits System.Windows.Forms.Form
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private intSearch As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        myConn = New SqlConnection("Data Source=DESKTOP-ASUS;Initial Catalog=admin1;Integrated Security=True")
        myCmd = myConn.CreateCommand


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        myCmd.CommandText = "select * from Persons"

        Dim inc As Integer = 1
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            results = myReader.GetInt32(0) & vbTab & myReader.GetString(1) & vbTab & myReader.GetString(2) & vbTab & myReader.GetString(3) & vbTab & myReader.GetString(4) & vbLf

            If intSearch = inc Then
                MessageBox.Show(results)
            End If
            inc += 1
        Loop

        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub txtPersonId_TextChanged(sender As Object, e As EventArgs) Handles txtPersonId.TextChanged
        intSearch = Val(txtPersonId.Text)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click



        myCmd.CommandText = "insert into Persons([PersonID],[LastName],[FirstName],[Address],[City]) Values('" & txtPersonId.Text & "','" & txtLastName.Text & "','" & txtFirstName.Text & "','" & txtAddress.Text & "','" & txtCity.Text & "')"


            myConn.Open()
            myReader = myCmd.ExecuteReader()

            myReader.Close()
            myConn.Close()

            MessageBox.Show("New data add to dataBase")
        txtPersonId.Clear()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtAddress.Clear()
        txtCity.Clear()

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

        myCmd.CommandText = "Update Persons SET PersonID = '" & txtPersonId.Text & "' Where LastName = '" & txtLastName.Text & "' or FirstName ='" & txtFirstName.Text & "'or Address='" & txtAddress.Text & "'or City = '" & txtCity.Text & "'"


        myConn.Open()
        myReader = myCmd.ExecuteReader()



        myReader.Close()
        myConn.Close()

        MessageBox.Show("data updated successfully")
        txtPersonId.Clear()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        myCmd.CommandText = "Delete from Persons where PersonID = '" & txtPersonId.Text & "' or LastName = '" & txtLastName.Text & "' or FirstName ='" & txtFirstName.Text & "'or Address='" & txtAddress.Text & "'or City = '" & txtCity.Text & "'"


        myConn.Open()
        myReader = myCmd.ExecuteReader()



        myReader.Close()
        myConn.Close()

        MessageBox.Show("Data Deleted")
        txtPersonId.Clear()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
    End Sub

    Private Sub btnShowTable_Click(sender As Object, e As EventArgs) Handles btnShowTable.Click

        myCmd.CommandText = "select * from Persons"


        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            results = myReader.GetInt32(0) & vbTab & myReader.GetString(1) & vbTab & myReader.GetString(2) & vbTab & myReader.GetString(3) & vbTab & myReader.GetString(4) & vbLf
            ListBox1.Items.Add(results)
        Loop

        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim dtable As New DataTable("Persons")
        'dtable.Columns.Add("PersonId", Type.GetType("System.Int32"))
        'dtable.Columns.Add("LastName", Type.GetType("System.string"))
        'dtable.Columns.Add("FirstName", Type.GetType("System.string"))
        'dtable.Columns.Add("Address", Type.GetType("System.string"))
        'dtable.Columns.Add("City", Type.GetType("System.string"))


    End Sub


End Class
