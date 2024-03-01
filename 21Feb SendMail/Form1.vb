Imports System.Data.SqlClient
Imports System.IO

Imports System.Net.Mail
Public Class Form1
    Public myConn As New SqlConnection("Data Source=Desktop-Asus;Initial Catalog=admin1;Integrated Security=True")
    Public myCmd As New SqlCommand
    Public myReader As SqlDataReader
    Public da As New SqlDataAdapter()
    Public ds As New DataSet
    Public dt As New DataTable()
    Public notduplicateKey As Boolean
    Dim countcheck As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim serial As Integer = 4
        Dim empname As String = "jaiho"
        Dim usrname As String = "lsdjf"
        Dim phnnum As Integer = 62646
        Dim pswd As String = "lsdkfja"
        Dim emlid As String = "ldkfjd"
        Dim fathrname As String = "lkdfjaioe"
        Dim adrs As String = "oiruoiqwu"
        Dim empid As String = TextBox1.Text
        Dim count1 As Integer
        'Dim query1 As String = "insert into EmployeePersonalDetails ([serial no],[Employee Id],[Employee's name],[Date Of Birth], [Phone Number],[fathers's Name],[Address],[Email id],[UserName],[Password]) values('" & serial & "','" & empid & "','" & empname & "', '2001-05-05','" & phnnum & "','" & fathrname & "','" & adrs & " ','" & emlid & "','" & usrname & "','" & pswd & "')"
        Dim EmpIdQuery As String = "select [serial no],[Employee Id] from employeePersonalDetails where [Employee Id] = '" & TextBox1.Text & "' "
        Dim i As String = "('" & serial & "','" & empid & "','" & empname & "', '2001-05-05','" & phnnum & "','" & fathrname & "','" & adrs & " ','" & emlid & "','" & usrname & "','" & pswd & "')"
        Dim query2 As String = "insert into EmployeePersonalDetails ([serial no],[Employee Id],[Employee's name],[Date Of Birth], [Phone Number],[fathers's Name],[Address],[Email id],[UserName],[Password]) values" & i
        MessageBox.Show(query2)
        myCmd = myConn.CreateCommand
        da = New SqlDataAdapter(myCmd)
        myCmd.CommandText = EmpIdQuery
        myConn.Open()

        notduplicateKey = True
        'myReader = myCmd.ExecuteReader()
        'If myReader.Read() Then
        '    myConn.Close()
        '    MessageBox.Show("duplicate id")
        '    notduplicateKey = False
        '    myReader.Close()
        '    myConn.Close()
        'Else
        '    myReader.Close()
        '    myConn.Close()
        '    myCmd.CommandText = query1
        '    myConn.Open()
        '    da.Fill(dt)
        '    myCmd.ExecuteNonQuery()
        '    MessageBox.Show("Add successfully")
        'End If
        count1 = myCmd.ExecuteScalar()
        If count1 = 0 Then
            myCmd.CommandText = query2
            myCmd.ExecuteNonQuery()
        End If
        myConn.Close()
        MessageBox.Show("add sussessfully")

        MessageBox.Show(query2)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim i As String = "ram and "
        Dim j As String = "shyam "
        Dim k As String = "kalki " & i


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result As Integer = MsgBox("Is The Dev Codes awesome?", MessageBoxButtons.YesNoCancel)
        MessageBox.Show(result)
        Dim formatDate As Date

        TextBox2.Text = Format(formatDate, "yyyy-MM-dd")
        Dim varInput = InputBox("enter Employee Id :-")
        MessageBox.Show(varInput)
    End Sub
    Public Sub showData()
        myCmd = myConn.CreateCommand()
        myConn.Open()
    End Sub

    Private Sub btnShowData_Click(sender As Object, e As EventArgs) Handles btnShowData.Click
        myCmd = myConn.CreateCommand
        da = New SqlDataAdapter(myCmd)
        showData()
        myCmd.CommandText = "select * from EmployeePersonalDetails"

        myReader = myCmd.ExecuteReader
        If myReader.Read() Then
            MessageBox.Show("All ok")
        Else
            MessageBox.Show("nothing ok")
        End If
        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged


    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        Dim txtbx As String = Nothing
        TextBox2.Text = Date.DaysInMonth(2024, 2)

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        TextBox2.Text = MonthCalendar1.Handle
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim varDate As String = Date.Today
        Dim vartime As String = TimeOfDay
        MessageBox.Show(varDate)
        MessageBox.Show(vartime)
    End Sub

    Private Sub btnDateDifference_Click(sender As Object, e As EventArgs) Handles btnDateDifference.Click
        Dim date1 As String = Date.Today
        Dim Year1() As String = date1.Split("/")
        MessageBox.Show(Year1(0) & Year1(1) & Year1(2))
        Dim time1 As String = "12:00:00"
        Dim Shours1() As String = time1.Split(":")
        Dim time2 As String = "18:30:00"
        Dim EHours1() As String = time2.Split(":")

        Dim stime1 As New DateTime(Year1(2), Year1(0), Year1(1), Shours1(0), Shours1(1), Shours1(2))
        Dim etime2 As New DateTime(Year1(2), Year1(0), Year1(1), EHours1(0), EHours1(1), EHours1(2))
        Dim datediff1 As TimeSpan = etime2 - stime1
        Dim varh As New DateTime(2024, 2, 28, datediff1.Hours, datediff1.Minutes, datediff1.Seconds)

        MessageBox.Show(varh)
    End Sub

    Private Sub btnSendMail_Click(sender As Object, e As EventArgs) Handles btnSendMail.Click
        Dim smtpServer As New SmtpClient
        Dim e_mail As New MailMessage()
        Dim senderEmail As String = "anujbhadoriya0102rmsse@outlook.com"
        Dim senderPassword As String = "nxanqsjczohwktvn"
        Dim recieverEmail As String = "banuj2106singh@gmail.com"

        Try
            smtpServer.UseDefaultCredentials = False
            smtpServer.Credentials = New Net.NetworkCredential(senderEmail, senderPassword)
            smtpServer.EnableSsl = True
            smtpServer.Port = 587
            smtpServer.Host = "smtp.office365.com"
            e_mail = New MailMessage
            e_mail.From = New MailAddress(senderEmail)
            e_mail.To.Add(recieverEmail)
            e_mail.Subject = "otp "
            e_mail.IsBodyHtml = False
            e_mail.Body = "2345"
            MessageBox.Show("Ok")
            smtpServer.Send(e_mail)
            MessageBox.Show("send Otp")
        Catch ex As Exception
            Console.WriteLine("Error Sending Otp email : " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim Dgvcheckbox As New DataGridViewCheckBoxColumn


    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex = 0 Then
            Dim ischecked As Boolean = CBool(DataGridView1.CurrentCell.Value)
            If ischecked Then
                countcheck = countcheck + 1
                MessageBox.Show("checked" & countcheck)
            Else
                MessageBox.Show("unchecked")

            End If
        End If
    End Sub

    Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
        'RemoveHandler DataGridView1.CurrentCellDirtyStateChanged, AddressOf DataGridView1_CurrentCellDirtyStateChanged

        'If TypeOf DataGridView1.CurrentCell Is DataGridViewCheckBoxCell Then
        '    DataGridView1.EndEdit()
        '    Dim ischecked As Boolean = CBool(DataGridView1.CurrentCell.Value)
        '    MessageBox.Show(ischecked)
        '    If ischecked Then
        '        countcheck = countcheck + 1
        '        MessageBox.Show("checked" & countcheck)

        '    Else
        '        MessageBox.Show("unchecked")

        '    End If
        'End If
        'AddHandler DataGridView1.CurrentCellDirtyStateChanged, AddressOf DataGridView1_CurrentCellDirtyStateChanged
    End Sub
End Class
