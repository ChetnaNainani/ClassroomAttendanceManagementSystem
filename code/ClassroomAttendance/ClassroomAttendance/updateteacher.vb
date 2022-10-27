Imports System.Data.OleDb
Public Class updateteacher
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim temp As String
    Dim cmd As OleDbCommand
    Dim myReader As OleDbDataReader
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        Label4.Text = "Enter New " + ComboBox1.Text
        If (ComboBox1.SelectedItem().Equals("username")) Then
            Label4.Show()
            TextBox3.Show()
        ElseIf (ComboBox1.SelectedItem().Equals("contact")) Then
            Label4.Show()
            TextBox3.Show()
        ElseIf (ComboBox1.SelectedItem().Equals("password")) Then
            Label4.Show()
            TextBox3.Show()
            Label6.Show()
            TextBox4.Show()
        ElseIf (ComboBox1.SelectedItem().Equals("subject")) Then
            Label4.Show()
            TextBox3.Show()
            Label3.Show()
            TextBox2.Show()
            Label5.Show()
            ComboBox3.Show()
        End If
        myconnection.Open()
        Dim cmd As New OleDbCommand
        Dim str As String
        Dim number As String = ""
        str = "select username from teacher where tname='" & ComboBox2.Text & "'"
        cmd = New OleDbCommand(str, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                TextBox1.Text = (myReader(0))
            End While

        Loop While myReader.NextResult()
        myReader.Close()

        cmd.Connection = myconnection 'oledbconnctn obj
        Dim str1 As String

        str1 = "select Class from subject where username='" & TextBox1.Text & "'  "
        cmd = New OleDbCommand(str1, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox3.Items.Add(myReader(0))
            End While

        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub updateteacher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Hide()
        provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\ClassroomAttendanceManagementSystem\database\ProjectDatabase.accdb"
        connString = provider & datafile
        myconnection = New OleDbConnection(connString)
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(tname) from teacher "
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
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        ComboBox3.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        Label6.Hide()
        TextBox4.Hide()

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
        Dim str1 As String
        If (ComboBox1.SelectedItem().Equals("Name")) Then
            str = "Update [teacher] set [username]='" & TextBox3.Text & "' where [tname] = '" & ComboBox2.SelectedItem & "'"
            str1 = "Update [subject] set [username]='" & TextBox3.Text & "'where [username] = '" & TextBox1.Text & "' "
        ElseIf (ComboBox1.SelectedItem().Equals("contact")) Then
            str = "Update [teacher] set [contact]='" & TextBox3.Text & "' where [tname] = '" & ComboBox2.SelectedItem & "' and [password]='" & TextBox4.Text & "'"
        ElseIf (ComboBox1.SelectedItem().Equals("password")) Then
            str = "Update [teacher] set [password]='" & TextBox3.Text & "' where [tname] = '" & ComboBox2.SelectedItem & "'"
        ElseIf (ComboBox1.SelectedItem().Equals("subject")) Then
            str = "Update [subject] set [Subject]='" & TextBox3.Text & "' where [username] = '" & TextBox1.Text & "' and [Class]='" & ComboBox3.SelectedItem & "' and [Subject]='" & TextBox2.Text & "'"
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
        myconnection.Open()
        Dim cmd1 As OleDbCommand = New OleDbCommand(str1, myconnection)
        Try
            cmd1.ExecuteNonQuery()
            myconnection.Close()

        Catch ex As Exception

        End Try
        ' '   Case MsgBoxResult.No
        ' TextBox2.Clear()
        'TextBox3.Clear()

        ' End Select
    End Sub
    Private Sub updateteacher1()

    End Sub
End Class