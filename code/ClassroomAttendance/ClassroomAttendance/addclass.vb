Imports System.Data.OleDb
Public Class addclass
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim cmd As OleDbCommand
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub addclass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\ClassroomAttendanceManagementSystem\database\ProjectDatabase.accdb"
        connString = provider & datafile
        myconnection.ConnectionString = connString
        myconnection.Open()
        Dim str As String
        str = "insert into class Values(@Class,@NumberOfStudents)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.Parameters.AddWithValue("class", TextBox1.Text)
        cmd.Parameters.AddWithValue("NumberOfStudents", TextBox2.Text)
        cmd.ExecuteNonQuery()
        MsgBox("CLASS CREATED")
        myconnection.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        start.Show()
    End Sub
End Class