Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim conn As OleDb.OleDbConnection
        Dim dbProvider As String
        Dim dbSources As String
        Dim MyDocumentFolder As String
        Dim TheDatabase As String
        Dim FullDatabasePath As String

        conn = New OleDb.OleDbConnection

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        TheDatabase = "/AddressBook.mdb"
        MyDocumentFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        FullDatabasePath = MyDocumentFolder & TheDatabase
        dbSources = "Data Source = " & FullDatabasePath
        conn.ConnectionString = dbProvider & FullDatabasePath

        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim sql As String
        Dim Name1 As String
        Name1 = "Rambahadur"

        conn.Open()
        sql = "insert table tblContacts([FirstName]) Values(Name1) "
        da = New OleDb.OleDbDataAdapter(sql, conn)
        da.Fill(ds, "Address Book")
        MessageBox.Show("Database is now open")

        conn.Close()
        MessageBox.Show("Database is now close")



    End Sub
End Class
