Imports System.Data.OleDb
Public Class defaulters
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myReader As OleDbDataReader
    Dim cmd As OleDbCommand
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim temp As String
    Private Sub defaulters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As Integer
        ' for loop execution 
        For a = 1945 To 2016
            ComboBox2.Items.Add(a)
        Next
        provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\project (3)\ClassroomAttendanceManagementSystem\database\ProjectDatabase.accdb"
        connString = provider & datafile
        myconnection.ConnectionString = connString
        myconnection.Open()
        Dim str As String
        Dim str1 As String
        Dim str2 As String
        str1 = login.TextBox4.Text
        str = "Select distinct (Subject) from subject where username='" & str1 & "'"
        cmd = New OleDbCommand(str, myconnection)
        '......cmd.Connection = myconnection
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox3.Items.Add(myReader(0))


            End While

        Loop While myReader.NextResult()
        myReader.Close()
        str2 = "Select distinct (Class) from subject where username='" & str1 & "'"
        cmd = New OleDbCommand(str2, myconnection)
        '......cmd.Connection = myconnection
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox4.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim n As Integer = 0
        If (ComboBox1.Text = "January") Then
            n = 1
        ElseIf (ComboBox1.Text = "February") Then
            n = 2
        ElseIf (ComboBox1.Text = "March") Then
            n = 3
        ElseIf (ComboBox1.Text = "April") Then
            n = 4
        ElseIf (ComboBox1.Text = "May") Then
            n = 5
        ElseIf (ComboBox1.Text = "June") Then
            n = 6
        ElseIf (ComboBox1.Text = "July") Then
            n = 7
        ElseIf (ComboBox1.Text = "August") Then
            n = 8
        ElseIf (ComboBox1.Text = "September") Then
            n = 9
        ElseIf (ComboBox1.Text = "October") Then
            n = 10
        ElseIf (ComboBox1.Text = "November") Then
            n = 11
        ElseIf (ComboBox1.Text = "December") Then
            n = 12
        End If
        Dim count As Integer = 0
        Dim str1 As String
        str1 = login.TextBox4.Text
        Dim str2 As String
        str2 = "Select Date from Attendance where Subject='" & ComboBox3.Text & "'and Class='" & ComboBox4.Text & "'"
        cmd = New OleDbCommand(str2, myconnection)
        '......cmd.Connection = myconnection
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                MsgBox(myReader(0))
                count = count + 1
            End While
        Loop While myReader.NextResult()
        TextBox3.Text = count.ToString()
        myReader.Close()

        Dim rollnos(100) As Integer
        Dim str3 As String
        Dim temp As String
        str3 = "Select AbsentRollNos from Attendance where Subject='" & ComboBox3.Text & "'and Class='" & ComboBox4.Text & "'"
        cmd = New OleDbCommand(str3, myconnection)
        '......cmd.Connection = myconnection
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                temp = myReader(0)
                Dim result As String() = temp.Split(New String() {","}, StringSplitOptions.None)
                For Each s As String In result
                    'MessageBox.Show(s)
                    If (s.Equals("") = False) Then
                        MessageBox.Show(s)
                        'MessageBox.Show(CInt(s))
                        rollnos(CInt(s)) = rollnos(CInt(s)) + 1
                        If ((((rollnos(CInt(s)) / count)) * 100) < 75) Then
                            TextBox5.Text = TextBox5.Text + "," + s
                        Else
                            TextBox5.Text = "No defaulter in this month"
                        End If

                        'MsgBox(rollnos(CInt(s)))

                    End If
                    'rollnos(s) = rollnos(s) + 1

                    ' rollnos(CInt(s)) = rollnos(CInt(s)) + 1

                Next
              
            End While
        Loop While myReader.NextResult()
        'For count = 1 To rollnos.Length - 1
        'If ((MsgBox(count) > 1)) Then

        'MsgBox(count)
        'End If

        'MsgBox(rollnos(count))
        'Next
        myconnection.Close()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class