Imports System.Data.OleDb
Public Class deleteclass
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim cmd As OleDbCommand
    Dim myReader As OleDbDataReader
    Dim myconnection As OleDbConnection
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        start.Show()
    End Sub

    Private Sub deleteclass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        str = "select Class from class"
        Dim classname As String = ""
        cmd = New OleDbCommand(str, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                classname = (myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
        If (classname.Equals(ComboBox1.SelectedItem)) Then
            myconnection.Open()
            str = "delete * from class where Class='" & ComboBox1.SelectedItem & "'"
            cmd = New OleDbCommand(str, myconnection)
            cmd.ExecuteNonQuery()
            str = "delete * from subject where Class='" & ComboBox1.SelectedItem & "'"
            cmd = New OleDbCommand(str, myconnection)
            cmd.ExecuteNonQuery()
            MsgBox("CLASS DELETED")
            myconnection.Close()
        Else
            MsgBox("INVALID USERNAME")
        End If
    End Sub


End Class