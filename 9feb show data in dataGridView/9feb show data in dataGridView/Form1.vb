Imports System.Data.SqlClient
Public Class Form1
    Inherits System.Windows.Forms.Form
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private da As SqlDataAdapter
    Private ds As New DataSet()
    Private dt As New DataTable()
    Private dgv As New DataGridView
    Dim row1 As Integer
    Dim col1 As Integer
    Private Results As String



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        myConn = New SqlConnection("Data Source=DESKTOP-ASUS;Initial Catalog=admin1;Integrated Security=SSPI;")
        myCmd = New SqlCommand("", myConn)
        myCmd = myConn.CreateCommand
        da = New SqlDataAdapter(myCmd)
        dt.Clear()


    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        da.Fill(dt)

        myCmd.CommandText = "insert into Persons([LastName],[FirstName],[Address],[City],[PersonId]) Values('" & DataGridView1.Rows(row1).Cells(0).Value & "','" & DataGridView1.Rows(row1).Cells(1).Value & "','" & DataGridView1.Rows(row1).Cells(2).Value & "','" & DataGridView1.Rows(row1).Cells(3).Value & "','" & DataGridView1.Rows(row1).Cells(4).Value & "')"

        myConn.Open()

        myReader = myCmd.ExecuteReader()
        myReader.Close()



        myConn.Close()
        MessageBox.Show("Data Add")

    End Sub


    Private Sub btnShowTable_Click(sender As Object, e As EventArgs) Handles btnShowTable.Click
        dt.Clear()
        myCmd.CommandText = "Select * from Persons"
        da.Fill(dt)
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            Results = myReader.GetString(0) & vbTab & myReader.GetString(1) & vbTab & myReader.GetString(2) & vbTab & myReader.GetString(3) & vbTab & myReader.GetInt32(4) & vbLf

        Loop

        DataGridView1.DataSource = dt

        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        row1 = e.RowIndex
        col1 = e.ColumnIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(row1)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        da.Fill(dt)
        Dim mycmd1 As Integer
        Dim i As Integer

        myCmd.CommandText = "Update  Persons Set LastName = '" & DataGridView1.Rows(row1).Cells(0).Value & "', FirstName = '" & DataGridView1.Rows(row1).Cells(1).Value & "', Address ='" & DataGridView1.Rows(row1).Cells(2).Value & "', City='" & DataGridView1.Rows(row1).Cells(3).Value & "' where PersonId ='" & DataGridView1.Rows(row1).Cells(4).Value & "' "
        myConn.Open()

            mycmd1 = myCmd.ExecuteNonQuery()

            myConn.Close()


        MessageBox.Show("Update Succeffully")
        dt.Clear()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        da.Fill(dt)
        myCmd.CommandText = "Delete from Persons where LastName = '" & DataGridView1.Rows(row1).Cells(0).Value & "'or FirstName = '" & DataGridView1.Rows(row1).Cells(1).Value & "'or Address = '" & DataGridView1.Rows(row1).Cells(2).Value & "'or City = '" & DataGridView1.Rows(row1).Cells(3).Value & "'or personId = '" & DataGridView1.Rows(row1).Cells(4).Value & "'"
        myConn.Open()
        myReader = myCmd.ExecuteReader()
        myReader.Close()
        myConn.Close()
        MessageBox.Show("Delete row successfully")
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        dt.Clear()

        Dim mycmd1 As Integer
        myCmd.CommandText = "select * from Persons where personId = '" & Val(txtPersonId.Text) & "' or Lastname = '" & txtLastName.Text & "' or FirstName = '" & txtFirstName.Text & "' or Address = '" & txtCity.Text & "' "
        da.Fill(dt)
        myConn.Open()
        myReader = myCmd.ExecuteReader()

        Do While myReader.Read()

            Results = myReader.GetInt32(4) & vbTab & myReader.GetString(0) & vbTab & myReader.GetString(1) & vbTab & myReader.GetString(2) & vbTab & myReader.GetString(3) & vbLf
        Loop

        myReader.Close()
        myConn.Close()

        DataGridView1.DataSource = dt
        MessageBox.Show("Search Succefully")

    End Sub
End Class
