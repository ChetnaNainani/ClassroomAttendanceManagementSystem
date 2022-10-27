Imports System.Data.OleDb
Public Class deletestudent
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim temp As String
    Dim cmd As OleDbCommand
    Dim myReader As OleDbDataReader
    Private Sub deletestudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        myconnection.Open()
        Dim Str As String = ""
        Str = "select * from student where rollno='" & TextBox1.Text & "'and class='" & ComboBox1.SelectedItem & "'"
        Dim rno As String = ""
        Dim sname As String = ""
        Dim no As String = ""
        Dim cl As String = ""
        cmd = New OleDbCommand(Str, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                rno = (myReader(0))
                sname = (myReader(1))
                no = (myReader(2))
                cl = (myReader(3))
                TextBox2.Text = sname
                TextBox3.Text = no
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        If (cl.Equals(ComboBox1.SelectedItem)) Then
            str = "update Name,Contact from class where Name='" & TextBox2.Text & "'and Contact='" & TextBox3.Text & "'"
            cmd = New OleDbCommand(str, myconnection)
            cmd.ExecuteNonQuery()
            MsgBox("STUDENT DELETED")
            myconnection.Close()
        Else
            MsgBox("INVALID STUDENT")
            myconnection.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Str As String = ""
        Str = "select * from student where rollno='" & TextBox1.Text & "'and class='" & ComboBox1.SelectedItem & "'"
        Dim rno As String = ""
        Dim sname As String = ""
        Dim no As String = ""
        Dim cl As String = ""
        cmd = New OleDbCommand(Str, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                rno = (myReader(0))
                sname = (myReader(1))
                no = (myReader(2))
                cl = (myReader(3))
                TextBox2.Text = sname
                TextBox3.Text = no
            End While
        Loop While myReader.NextResult()
        myReader.Close()
    End Sub
End Class