Imports System.Data.OleDb
Public Class updatestudent
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim temp As String
    Dim cmd As OleDbCommand
    Dim myReader As OleDbDataReader
    Private Sub updatestudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\ClassroomAttendanceManagementSystem\database\ProjectDatabase.accdb"
        connString = provider & datafile
        myconnection = New OleDbConnection(connString)
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select Class from class "
        cmd = New OleDbCommand(query, myconnection)
        'cmd.Connection = cn
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox2.Items.Add(myReader(0))
            End While

        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select rollno from student where Class='" & ComboBox2.SelectedItem & "'"
        cmd = New OleDbCommand(query, myconnection)
        'cmd.Connection = cn
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox4.Items.Add(myReader(0))
            End While

        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\ClassroomAttendanceManagementSystem\database\ProjectDatabase.accdb"
        connString = provider & datafile
        myconnection.ConnectionString = connString
        myconnection.Open()

        'Select Case MsgBox("Are you sure You want to update?", MsgBoxStyle.YesNo, "Confirmation")
        ' Case MsgBoxResult.Yes
        Dim str As String

        If (ComboBox1.SelectedItem().Equals("Name")) Then
            str = "Update [student] set [Name]='" & TextBox3.Text & "' where [Class] = '" & ComboBox2.SelectedItem & "' and [rollno]='" & ComboBox4.SelectedItem & "'"
            'str1 = "Update [subject] set [username]='" & TextBox3.Text & "'where [username] = '" & TextBox1.Text & "' "
        ElseIf (ComboBox1.SelectedItem().Equals("Contact")) Then
            str = "Update [student] set [Contact]='" & TextBox3.Text & "' where [Class] = '" & ComboBox2.SelectedItem & "' and [rollno]='" & ComboBox4.SelectedItem & "'"
        End If

        'str = "update teacher set" + ComboBox1.Text + "=" + "'" + "TextBox3.Text" + "'" + "where" + " " + ComboBox1.Text + "=" + "'" + TextBox2.Text + "'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        Try
            cmd.ExecuteNonQuery()
            myconnection.Close()
            MsgBox("Record Updated Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconnection.Close()

        ' '   Case MsgBoxResult.No
        ' TextBox2.Clear()
        'TextBox3.Clear()

        ' End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label4.Text = "Enter New " + ComboBox1.SelectedItem
    End Sub
End Class