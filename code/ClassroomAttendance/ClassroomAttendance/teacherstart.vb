Imports System.Data.OleDb
Public Class teacherstart
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim cmd, cmd1 As OleDbCommand
    Dim myReader As OleDbDataReader
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim myconnection As OleDbConnection
    Private Sub teacherstart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Hide()
        provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\myfinalproject\database\ProjectDatabase.accdb"
        connString = provider & datafile
        myconnection = New OleDbConnection(connString)
        myconnection.Open()
        cmd = New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim uname As String = login.TextBox4.Text
        Dim query As String = "Select distinct(Class) from subject where username='" & uname & "'"
        cmd = New OleDbCommand(query, myconnection)
        'cmd.Connection = cn
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox2.Items.Add(myReader(0))
            End While

        Loop While myReader.NextResult()
        myReader.Close()

        Label3.Hide()
        ComboBox1.Hide()
        Button3.Hide()
        myconnection.Close()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        login.Show()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        operations.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        myconnection.Open()
        Dim str As String
        Dim number As String = ""
        str = "select NumberOfStudents from class where class='" & ComboBox2.Text & "'"
        cmd1 = New OleDbCommand(str, myconnection)
        myReader = cmd1.ExecuteReader
        Do
            While myReader.Read()
                TextBox1.Text = (myReader(0))
            End While

        Loop While myReader.NextResult()
        myReader.Close()
        Label1.Hide()
        ComboBox2.Enabled = False
        Button1.Enabled = False
        Label3.Show()
        ComboBox1.Show()
        Button3.Show()

        Dim str1 As String = ComboBox1.Text
        str1 = "select distinct(Subject) from subject where username='" & login.TextBox4.Text & "'"
        cmd1 = New OleDbCommand(str1, myconnection)
        myReader = cmd1.ExecuteReader
        Do
            While myReader.Read()
                ComboBox1.Items.Add(myReader(0))
            End While

        Loop While myReader.NextResult()
        myReader.Close()

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        start.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        start.Show()
    End Sub
End Class