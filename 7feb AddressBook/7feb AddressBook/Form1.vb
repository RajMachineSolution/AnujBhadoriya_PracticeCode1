Public Class Form1
    Dim inc As Integer
    Dim maxRows As Integer


    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbsource As String
    Dim myDocumentsFolder As String
    Dim theDatabase As String
    Dim fullDatabasePath As String

    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Private Sub TblContactsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblContactsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblContactsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AddressBookDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbProvider = "PROVIDER=Microsoft.jet.OLEDB.4.0;"
        theDatabase = "/AddressBook.mdb"
        myDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        fullDatabasePath = myDocumentsFolder & theDatabase
        dbsource = "Data Source =  " & fullDatabasePath
        con.ConnectionString = dbProvider & dbsource

        con.Open()
        Sql = "select * from tblContacts"
        da = New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "address Book")
        MessageBox.Show("Database is now open")

        con.Close()
        MessageBox.Show("Database is now closed")

        maxRows = ds.Tables("Address Book").Rows.Count
        inc = -1
    End Sub
    Private Sub NavigateRecords()
        txtFirstName.Text = ds.Tables("Address Book").Rows(inc).Item(1)
        txtSurName.Text = ds.Tables("Address Book").Rows(inc).Item(2)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If inc <> maxRows - 1 Then
            inc = inc + 1
            Call NavigateRecords()
        Else
            MessageBox.Show("No More Rows")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If inc > 0 Then
            inc = inc - 1
            Call NavigateRecords()
        Else
            MessageBox.Show("first Record")
        End If
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        If inc <> 0 Then
            inc = 0
            Call NavigateRecords()
        End If
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        If inc <> maxRows - 1 Then
            inc = maxRows - 1
            Call NavigateRecords()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        ds.Tables("Address Book").Rows(inc).Item(1) = txtFirstName.Text
        ds.Tables("AddressBook").Rows(inc).Item(2) = txtSurName.Text
        da.Update(ds, "Address Book")
        MessageBox.Show("Data Updated")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        btnCommit.Enabled = False
        btnAddNew.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True

        inc = 0
        NavigateRecords()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        btnCommit.Enabled = True
        btnAddNew.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False

        txtFirstName.Clear()
        txtSurName.Clear()
        If inc <> -1 Then

            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow

            dsNewRow = ds.Tables("AddressBook").NewRow()

            dsNewRow.Item("FirstName") = txtFirstName.Text
            dsNewRow.Item("Surname") = txtSurName.Text

            ds.Tables("AddressBook").Rows.Add(dsNewRow)

            da.Update(ds, "AddressBook")

            MessageBox.Show("New Record added to the Database")

            btnCommit.Enabled = False
            btnAddNew.Enabled = True
            btnUpdate.Enabled = True >
            btnDelete.Enabled = True

        End If
    End Sub
End Class
