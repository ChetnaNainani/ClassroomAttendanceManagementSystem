Imports System.Data.OleDb
Public Class deleteteacher
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim cmd As OleDbCommand
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim myReader As OleDbDataReader
    Dim temp As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim user As String = ""
        provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\ClassroomAttendanceManagementSystem\database\ProjectDatabase.accdb"
        connString = provider & datafile
        myconnection.ConnectionString = connString
        myconnection.Open()
        Dim str As String
        str = "select username from teacher"
        cmd = New OleDbCommand(str, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                user = (myReader(0))
                If (user.Equals(TextBox1.Text)) Then
                    Exit While
                End If
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
        MsgBox(TextBox1.Text)
        If (user.Equals(TextBox1.Text)) Then
            myconnection.Open()
            str = "delete * from teacher where username='" & TextBox1.Text & "'"
            cmd = New OleDbCommand(str, myconnection)
            cmd.ExecuteNonQuery()
            str = "delete * from subject where username='" & TextBox1.Text & "'"
            cmd = New OleDbCommand(str, myconnection)
            cmd.ExecuteNonQuery()
            TextBox1.Clear()
            myconnection.Close()
            MsgBox("Teacher Deleted")
        Else
            MsgBox("INVALID USERNAME")
            TextBox1.Clear()
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        start.Show()
    End Sub
End Class