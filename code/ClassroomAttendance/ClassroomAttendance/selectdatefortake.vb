Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports VB = Microsoft.VisualBasic
Public Class selectdatefortake
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myReader As OleDbDataReader
    Dim cmd As OleDbCommand
    Dim flag As Boolean
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub selectdatefortake_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MonthCalendar1.MaxDate = Today
        provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\ClassroomAttendanceManagementSystem\database\ProjectDatabase.accdb"
        connString = provider & datafile
        myconnection.ConnectionString = connString
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.MonthCalendar1.MaxSelectionCount = 14
        Dim a As Date
        If Me.MonthCalendar1.SelectionRange.Start = _
            Me.MonthCalendar1.SelectionRange.End Then
            takeattendance.TextBoxdate.Text = CStr(Me.MonthCalendar1.SelectionStart)
            updateattendance.TextBoxdate.Text = Me.MonthCalendar1.SelectionRange.Start
        Else
            takeattendance.TextBoxdate.Text = Me.MonthCalendar1.SelectionRange.Start & _
                " - " & Me.MonthCalendar1.SelectionRange.End
            updateattendance.TextBoxdate.Text = Me.MonthCalendar1.SelectionRange.Start


        End If
        'MsgBox(Me.MonthCalendar1.SelectionRange.Start )
        myconnection.Open()
        Dim str As String
        Dim c1 As String = ""
        Dim c2 As String = ""
        Dim c3 As String = ""
        Dim c4 As String = ""
        str = "select * from Attendance"
        cmd = New OleDbCommand(str, myconnection)
        Dim temp As String
        temp = CType(Me.MonthCalendar1.SelectionRange.Start, String)
        MsgBox(temp)

        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                c1 = myReader(0)
                c2 = myReader(1)
                c3 = myReader(2)
                c4 = myReader(3)
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
        If (c1.Equals(teacherstart.ComboBox1.Text) And c2.Equals(temp) And c4.Equals(teacherstart.ComboBox2.Text)) Then
            MsgBox("Attendance already taken")
            Me.Hide()
            Select Case MsgBox("Do you want to update record?", MsgBoxStyle.YesNo, "Confirmation")
                Case MsgBoxResult.Yes
                    updateattendance.TextBoxroll.Text = ""
                    updateattendance.TextBoxroll.Text = ""
                    updateattendance.Show()
                Case MsgBoxResult.No
            End Select
        Else
            Me.Hide()
            takeattendance.Show()
        End If
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        start.Show()
    End Sub
End Class