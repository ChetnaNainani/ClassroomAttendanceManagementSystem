Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports VB = Microsoft.VisualBasic
Public Class login
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim cmd As OleDbCommand
    Dim myReader As OleDbDataReader
    Dim myconnection As OleDbConnection
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\myfinalproject\database\ProjectDatabase.accdb"
        connString = provider & datafile
        myconnection = New OleDbConnection(connString)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim struser As String = TextBox4.Text
        Dim strpass As String = TextBox3.Text
        Dim flag As Boolean
        If TextBox4.Text = "" Then
            MsgBox("Enter the Username first")
        ElseIf TextBox3.Text = "" Then
            MsgBox("Enter the Password first")
        Else
            myconnection.Open()
            Dim query As String = "select * from teacher"
            cmd = New OleDbCommand(query, myconnection)
            myReader = cmd.ExecuteReader
            Do
                While myReader.Read()
                    If (strpass.Equals(myReader(1)) And struser.Equals(myReader(0))) Then
                        flag = True
                    End If
                End While
            Loop While myReader.NextResult()
            myReader.Close()
            myconnection.Close()
            If flag = True Then
                Me.Hide()
                teacherstart.Show()
            Else
                MsgBox("Invalid Username or Password")
                TextBox3.Clear()
                TextBox4.Clear()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        start.Show()
    End Sub
End Class