Imports System.Data.OleDb
Public Class registerteacher
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim temp As String
    Dim cmd As OleDbCommand
    Dim myReader As OleDbDataReader
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        adminstart.Show()
    End Sub
    Private Sub registerteacher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\ClassroomAttendanceManagementSystem\database\ProjectDatabase.accdb"
        connString = provider & datafile
        myconnection = New OleDbConnection(connString)
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(class) from class "
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox1.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        start.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\ClassroomAttendanceManagementSystem\database\ProjectDatabase.accdb"
        connString = provider & datafile
        myconnection.ConnectionString = connString
        myconnection.Open()
        Dim str As String
        str = "Insert into teacher Values(@tname,@username,@password,@contact)"
        cmd = New OleDbCommand(str, myconnection)
        cmd.Parameters.AddWithValue("tname", TextBox5.Text)
        cmd.Parameters.AddWithValue("username", TextBox2.Text)
        cmd.Parameters.AddWithValue("password", TextBox3.Text)
        cmd.Parameters.AddWithValue("contact", TextBox4.Text)
        cmd.ExecuteNonQuery()
        Dim str1 As String = ""
        str1 = "insert into subject values(@username,@Subject,@Class)"
        cmd = New OleDbCommand(str1, myconnection)
        cmd.Parameters.AddWithValue("username", TextBox2.Text)
        cmd.Parameters.AddWithValue("Subject", TextBox1.Text)
        cmd.Parameters.AddWithValue("Class", ComboBox1.SelectedItem)
        cmd.ExecuteNonQuery()
        MsgBox("Teacher Registered Successfully..!!")
        Select Case MsgBox("Do you want to add new class or subject to teacher?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                ComboBox1.Text = ""
                TextBox1.Text = ""
            Case MsgBoxResult.No
                Me.Hide()
                adminstart.Show()
        End Select
        myconnection.Close()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class