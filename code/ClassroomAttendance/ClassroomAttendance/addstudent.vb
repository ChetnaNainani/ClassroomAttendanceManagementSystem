Imports System.Data.OleDb
Public Class addstudent
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myReader As OleDbDataReader
    Dim cmd As OleDbCommand
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub addstudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\ClassroomAttendanceManagementSystem\database\ProjectDatabase.accdb"
        connString = provider & datafile
        myconnection = New OleDbConnection(connString)
        myconnection.Open()
        Dim query As String = "Select distinct(Class) from class"
        cmd = New OleDbCommand(query, myconnection)
        'cmd.Connection = cn
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox1.Items.Add(myReader(0))
            End While

        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        myconnection.Open()
        Dim str As String
        str = "insert into student values(@rollno,@Name,@Contact,@Class)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.Parameters.AddWithValue("rollno", TextBox1.Text)
        cmd.Parameters.AddWithValue("Name", TextBox2.Text)
        cmd.Parameters.AddWithValue("Contact", TextBox3.Text)
        cmd.Parameters.AddWithValue("Class", ComboBox1.SelectedItem)
        cmd.ExecuteNonQuery()
        MsgBox("DATA INSERTED")
        myconnection.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub
End Class