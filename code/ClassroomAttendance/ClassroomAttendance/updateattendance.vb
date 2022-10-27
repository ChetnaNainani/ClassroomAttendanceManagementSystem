Imports System.Data.OleDb

Public Class updateattendance
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim cmd As OleDbCommand
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        

        Dim myList As New List(Of String)()

        If (CheckBox1.Checked) Then
            TextBox1.Text = "A"
            myList.Add("1")
        Else
            TextBox1.Text = "P"
        End If
        If (CheckBox2.Checked) Then
            TextBox2.Text = "A"
            myList.Add("2")
        Else
            TextBox2.Text = "P"
        End If
        If (CheckBox3.Checked) Then
            TextBox3.Text = "A"
            myList.Add("3")
        Else
            TextBox3.Text = "P"
        End If
        If (CheckBox4.Checked) Then
            TextBox4.Text = "A"
            myList.Add("4")
        Else
            TextBox4.Text = "P"
        End If
        If (CheckBox5.Checked) Then
            TextBox5.Text = "A"
            myList.Add("5")
        Else
            TextBox5.Text = "P"
        End If
        If (CheckBox6.Checked) Then
            TextBox6.Text = "A"
            myList.Add("6")
        Else
            TextBox6.Text = "P"
        End If
        If (CheckBox7.Checked) Then
            TextBox7.Text = "A"
            myList.Add("7")
        Else
            TextBox7.Text = "P"
        End If
        If (CheckBox8.Checked) Then
            TextBox8.Text = "A"
            myList.Add("8")
        Else
            TextBox8.Text = "P"
        End If
        If (CheckBox9.Checked) Then
            TextBox9.Text = "A"
            myList.Add("9")
        Else
            TextBox9.Text = "P"
        End If
        If (CheckBox10.Checked) Then
            TextBox10.Text = "A"
            myList.Add("10")
        Else
            TextBox10.Text = "P"
        End If
        If (CheckBox11.Checked) Then
            TextBox11.Text = "A"
            myList.Add("11")
        Else
            TextBox11.Text = "P"
        End If
        If (CheckBox12.Checked) Then
            TextBox12.Text = "A"
            myList.Add("12")
        Else
            TextBox12.Text = "P"
        End If
        If (CheckBox13.Checked) Then
            TextBox13.Text = "A"
            myList.Add("13")
        Else
            TextBox13.Text = "P"
        End If
        If (CheckBox14.Checked) Then
            TextBox14.Text = "A"
            myList.Add("14")
        Else
            TextBox14.Text = "P"
        End If
        If (CheckBox15.Checked) Then
            TextBox15.Text = "A"
            myList.Add("15")
        Else
            TextBox15.Text = "P"
        End If
        If (CheckBox16.Checked) Then
            TextBox16.Text = "A"
            myList.Add("16")
        Else
            TextBox16.Text = "P"
        End If
        If (CheckBox17.Checked) Then
            TextBox17.Text = "A"
            myList.Add("17")
        Else
            TextBox17.Text = "P"
        End If
        If (CheckBox18.Checked) Then
            TextBox18.Text = "A"
            myList.Add("18")
        Else
            TextBox18.Text = "P"
        End If
        If (CheckBox19.Checked) Then
            TextBox19.Text = "A"
            myList.Add("19")
        Else
            TextBox19.Text = "P"

        End If
        If (CheckBox20.Checked) Then
            TextBox20.Text = "A"
            myList.Add("20")
        Else
            TextBox20.Text = "P"
        End If
        If (CheckBox21.Checked) Then
            TextBox21.Text = "A"
            myList.Add("21")
        Else
            TextBox21.Text = "P"
        End If
        If (CheckBox22.Checked) Then
            TextBox22.Text = "A"
            myList.Add("22")
        Else
            TextBox22.Text = "P"
        End If
        If (CheckBox23.Checked) Then
            TextBox23.Text = "A"
            myList.Add("23")
        Else
            TextBox23.Text = "P"
        End If
        If (CheckBox24.Checked) Then
            TextBox24.Text = "A"
            myList.Add("24")
        Else
            TextBox24.Text = "P"
        End If
        If (CheckBox25.Checked) Then
            TextBox25.Text = "A"
            myList.Add("25")
        Else
            TextBox25.Text = "P"
        End If
        If (CheckBox26.Checked) Then
            TextBox26.Text = "A"
            myList.Add("26")
        Else
            TextBox26.Text = "P"
        End If

        If (CheckBox27.Checked) Then
            TextBox27.Text = "A"
            myList.Add("27")
        Else
            TextBox27.Text = "P"
        End If
        If (CheckBox28.Checked) Then
            TextBox28.Text = "A"
            myList.Add("28")
        Else
            TextBox28.Text = "P"
        End If
        If (CheckBox29.Checked) Then
            TextBox29.Text = "A"
            myList.Add("29")
        Else
            TextBox29.Text = "P"
        End If
        If (CheckBox30.Checked) Then
            TextBox30.Text = "A"
            myList.Add("30")
        Else
            TextBox30.Text = "P"
        End If
        If (CheckBox31.Checked) Then
            TextBox31.Text = "A"
            myList.Add("31")
        Else
            TextBox31.Text = "P"
        End If
        If (CheckBox32.Checked) Then
            TextBox32.Text = "A"
            myList.Add("32")
        Else
            TextBox32.Text = "P"
        End If
        If (CheckBox33.Checked) Then
            TextBox33.Text = "A"
            myList.Add("33")
        Else
            TextBox33.Text = "P"
        End If
        If (CheckBox34.Checked) Then
            TextBox34.Text = "A"
            myList.Add("34")
        Else
            TextBox34.Text = "P"
        End If
        If (CheckBox35.Checked) Then
            TextBox35.Text = "A"
            myList.Add("35")
        Else
            TextBox35.Text = "P"
        End If
        If (CheckBox36.Checked) Then
            TextBox36.Text = "A"
            myList.Add("36")
        Else
            TextBox36.Text = "P"
        End If
        If (CheckBox37.Checked) Then
            TextBox37.Text = "A"
            myList.Add("37")
        Else
            TextBox37.Text = "P"
        End If
        If (CheckBox38.Checked) Then
            TextBox38.Text = "A"
            myList.Add("38")
        Else
            TextBox38.Text = "P"
        End If
        If (CheckBox39.Checked) Then
            TextBox39.Text = "A"
            myList.Add("39")
        Else
            TextBox39.Text = "P"
        End If
        If (CheckBox40.Checked) Then
            TextBox40.Text = "A"
            myList.Add("40")
        Else
            TextBox40.Text = "P"
        End If
        If (CheckBox41.Checked) Then
            TextBox41.Text = "A"
            myList.Add("41")
        Else
            TextBox41.Text = "P"
        End If
        If (CheckBox42.Checked) Then
            TextBox42.Text = "A"
            myList.Add("42")
        Else
            TextBox42.Text = "P"
        End If
        If (CheckBox43.Checked) Then
            TextBox43.Text = "A"
            myList.Add("43")
        Else
            TextBox43.Text = "P"
        End If
        If (CheckBox44.Checked) Then
            TextBox44.Text = "A"
            myList.Add("44")
        Else
            TextBox44.Text = "P"
        End If
        If (CheckBox45.Checked) Then
            TextBox45.Text = "A"
            myList.Add("45")
        Else
            TextBox45.Text = "P"
        End If
        If (CheckBox46.Checked) Then
            TextBox46.Text = "A"
            myList.Add("46")
        Else
            TextBox46.Text = "P"
        End If
        If (CheckBox47.Checked) Then
            TextBox47.Text = "A"
            myList.Add("47")
        Else
            TextBox47.Text = "P"
        End If
        If (CheckBox48.Checked) Then
            TextBox48.Text = "A"
            myList.Add("48")
        Else
            TextBox48.Text = "P"
        End If
        If (CheckBox49.Checked) Then
            TextBox49.Text = "A"
            myList.Add("49")
        Else
            TextBox49.Text = "P"
        End If
        If (CheckBox50.Checked) Then
            TextBox50.Text = "A"
            myList.Add("50")
        Else
            TextBox50.Text = "P"
        End If
        If (CheckBox51.Checked) Then
            TextBox51.Text = "A"
            myList.Add("51")
        Else
            TextBox51.Text = "P"
        End If
        If (CheckBox52.Checked) Then
            TextBox52.Text = "A"
            myList.Add("52")
        Else
            TextBox52.Text = "P"
        End If
        If (CheckBox53.Checked) Then
            TextBox53.Text = "A"
            myList.Add("53")
        Else
            TextBox53.Text = "P"
        End If
        If (CheckBox54.Checked) Then
            TextBox54.Text = "A"
            myList.Add("54")
        Else
            TextBox54.Text = "P"
        End If
        If (CheckBox55.Checked) Then
            TextBox55.Text = "A"
            myList.Add("55")
        Else
            TextBox55.Text = "P"
        End If
        If (CheckBox56.Checked) Then
            TextBox56.Text = "A"
            myList.Add("56")
        Else
            TextBox56.Text = "P"
        End If
        If (CheckBox57.Checked) Then
            TextBox57.Text = "A"
            myList.Add("57")
        Else
            TextBox57.Text = "P"
        End If
        If (CheckBox58.Checked) Then
            TextBox58.Text = "A"
            myList.Add("58")
        Else
            TextBox58.Text = "P"
        End If
        If (CheckBox59.Checked) Then
            TextBox59.Text = "A"
            myList.Add("59")
        Else
            TextBox59.Text = "P"
        End If
        If (CheckBox60.Checked) Then
            TextBox60.Text = "A"
            myList.Add("60")
        Else
            TextBox60.Text = "P"
        End If
        If (CheckBox61.Checked) Then
            TextBox61.Text = "A"
            myList.Add("61")
        Else
            TextBox61.Text = "P"
        End If
        If (CheckBox62.Checked) Then
            TextBox62.Text = "A"
            myList.Add("62")
        Else
            TextBox62.Text = "P"
        End If
        If (CheckBox63.Checked) Then
            TextBox63.Text = "A"
            myList.Add("63")
        Else
            TextBox63.Text = "P"
        End If
        If (CheckBox64.Checked) Then
            TextBox64.Text = "A"
            myList.Add("64")
        Else
            TextBox64.Text = "P"
        End If
        If (CheckBox65.Checked) Then
            TextBox65.Text = "A"
            myList.Add("65")
        Else
            TextBox65.Text = "P"
        End If
        If (CheckBox66.Checked) Then
            TextBox66.Text = "A"
            myList.Add("66")
        Else
            TextBox66.Text = "P"
        End If
        If (CheckBox67.Checked) Then
            TextBox67.Text = "A"
            myList.Add("67")
        Else
            TextBox67.Text = "P"
        End If
        If (CheckBox68.Checked) Then
            TextBox68.Text = "A"
            myList.Add("68")
        Else
            TextBox68.Text = "P"
        End If
        If (CheckBox69.Checked) Then
            TextBox69.Text = "A"
            myList.Add("69")
        Else
            TextBox69.Text = "P"
        End If
        If (CheckBox70.Checked) Then
            TextBox70.Text = "A"
            myList.Add("70")
        Else
            TextBox70.Text = "P"
        End If
        If (CheckBox71.Checked) Then
            TextBox71.Text = "A"
            myList.Add("71")
        Else
            TextBox71.Text = "P"
        End If
        If (CheckBox72.Checked) Then
            TextBox72.Text = "A"
            myList.Add("72")
        Else
            TextBox72.Text = "P"
        End If
        If (CheckBox73.Checked) Then
            TextBox73.Text = "A"
            myList.Add("73")
        Else
            TextBox73.Text = "P"
        End If
        If (CheckBox74.Checked) Then
            TextBox74.Text = "A"
            myList.Add("74")
        Else
            TextBox74.Text = "P"
        End If
        If (CheckBox75.Checked) Then
            TextBox75.Text = "A"
            myList.Add("75")
        Else
            TextBox75.Text = "P"
        End If
        If (CheckBox76.Checked) Then
            TextBox76.Text = "A"
            myList.Add("76")
        Else
            TextBox76.Text = "P"

        End If
        If (CheckBox77.Checked) Then
            TextBox77.Text = "A"
            myList.Add("77")
        Else
            TextBox77.Text = "P"
        End If
        If (CheckBox78.Checked) Then
            TextBox78.Text = "A"
            myList.Add("78")
        Else
            TextBox78.Text = "P"
        End If
        If (CheckBox79.Checked) Then
            TextBox79.Text = "A"
            myList.Add("79")
        Else
            TextBox79.Text = "P"
        End If
        If (CheckBox80.Checked) Then
            TextBox80.Text = "A"
            myList.Add("80")
        Else
            TextBox80.Text = "P"
        End If
        If (CheckBox81.Checked) Then
            TextBox81.Text = "A"
            myList.Add("81")
        Else
            TextBox37.Text = "P"
        End If
        If (CheckBox82.Checked) Then
            TextBox82.Text = "A"
            myList.Add("82")
        Else
            TextBox82.Text = "P"
        End If
        If (CheckBox83.Checked) Then
            TextBox83.Text = "A"
            myList.Add("83")
        Else
            TextBox83.Text = "P"
        End If
        If (CheckBox84.Checked) Then
            TextBox84.Text = "A"
            myList.Add("84")
        Else
            TextBox84.Text = "P"
        End If
        If (CheckBox85.Checked) Then
            TextBox85.Text = "A"
            myList.Add("85")
        Else
            TextBox85.Text = "P"
        End If
        If (CheckBox86.Checked) Then
            TextBox86.Text = "A"
            myList.Add("86")
        Else
            TextBox86.Text = "P"
        End If
        If (CheckBox87.Checked) Then
            TextBox87.Text = "A"
            myList.Add("87")
        Else
            TextBox87.Text = "P"
        End If
        If (CheckBox88.Checked) Then
            TextBox88.Text = "A"
            myList.Add("88")
        Else
            TextBox88.Text = "P"
        End If
        If (CheckBox89.Checked) Then
            TextBox89.Text = "A"
            myList.Add("89")
        Else
            TextBox89.Text = "P"
        End If
        If (CheckBox90.Checked) Then
            TextBox90.Text = "A"
            myList.Add("90")
        Else
            TextBox90.Text = "P"
        End If
        If (CheckBox91.Checked) Then
            TextBox91.Text = "A"
            myList.Add("91")
        Else
            TextBox91.Text = "P"
        End If
        If (CheckBox92.Checked) Then
            TextBox92.Text = "A"
            myList.Add("92")
        Else
            TextBox92.Text = "P"
        End If
        If (CheckBox93.Checked) Then
            TextBox93.Text = "A"
            myList.Add("93")
        Else
            TextBox93.Text = "P"
        End If
        If (CheckBox94.Checked) Then
            TextBox94.Text = "A"
            myList.Add("94")
        Else
            TextBox94.Text = "P"
        End If
        If (CheckBox95.Checked) Then
            TextBox95.Text = "A"
            myList.Add("95")
        Else
            TextBox95.Text = "P"
        End If
        If (CheckBox96.Checked) Then
            TextBox96.Text = "A"
            myList.Add("96")
        Else
            TextBox96.Text = "P"
        End If
        If (CheckBox97.Checked) Then
            TextBox97.Text = "A"
            myList.Add("97")
        Else
            TextBox97.Text = "P"
        End If
        If (CheckBox98.Checked) Then
            TextBox98.Text = "A"
            myList.Add("98")
        Else
            TextBox98.Text = "P"
        End If
        If (CheckBox99.Checked) Then
            TextBox92.Text = "A"
            myList.Add("99")
        Else
            TextBox99.Text = "P"
        End If
        If (CheckBox100.Checked) Then
            TextBox100.Text = "A"
            myList.Add("100")
        Else
            TextBox100.Text = "P"
        End If
        Dim myArray As String() = myList.ToArray()
        For i As Integer = 0 To myArray.Length - 1
            ' MessageBox.Show(myArray(i).ToString())
            TextBoxroll.Text = TextBoxroll.Text + myArray(i).ToString() + ","
        Next
        myconnection.Open()
        Dim Str As String
        Str = "delete * from Attendance where Class='" & teacherstart.ComboBox2.SelectedItem & "' and Subject='" & teacherstart.ComboBox1.SelectedItem & "'and Date='" & TextBoxdate.Text & "'"
        cmd = New OleDbCommand(Str, myconnection)
        cmd.ExecuteNonQuery()
        'MsgBox("deleted 1 record")
        Str = "insert into Attendance values(@Subject,@Date,@AbsentRollNos,@Class)"
        cmd = New OleDbCommand(Str, myconnection)
        cmd.Parameters.AddWithValue("Subject", teacherstart.ComboBox1.Text)
        cmd.Parameters.AddWithValue("Date", takeattendance.TextBoxdate.Text)
        cmd.Parameters.AddWithValue("AbsentRollNos", TextBoxroll.Text)
        cmd.Parameters.AddWithValue("Class", teacherstart.ComboBox2.Text)
        cmd.ExecuteNonQuery()
        MsgBox("RECORD UPDATED")
        myconnection.Close()
        Me.Hide()
        operations.Show()

    End Sub
    Private Sub updateattendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBoxdate.Text = ""
        TextBoxroll.Text = ""
        provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\ClassroomAttendanceManagementSystem\database\ProjectDatabase.accdb"
        connString = provider & datafile
        myconnection.ConnectionString = connString
        Dim textboxarray() As TextBox = {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12, TextBox13, TextBox14, TextBox15, TextBox16, TextBox17, TextBox18, TextBox19, TextBox20, TextBox21, TextBox22, TextBox23, TextBox24, TextBox25, TextBox26, TextBox27, TextBox28, TextBox29, TextBox30, TextBox31, TextBox32, TextBox33, TextBox34, TextBox35, TextBox36, TextBox37, TextBox38, TextBox39, TextBox40, TextBox41, TextBox42, TextBox43, TextBox44, TextBox45, TextBox46, TextBox47, TextBox48, TextBox49, TextBox50, TextBox51, TextBox52, TextBox53, TextBox54, TextBox55, TextBox56, TextBox57, TextBox58, TextBox59, TextBox60, TextBox61, TextBox62, TextBox63, TextBox64, TextBox65, TextBox66, TextBox67, TextBox68, TextBox69, TextBox70, TextBox71, TextBox72, TextBox73, TextBox74, TextBox75, TextBox76, TextBox77, TextBox78, TextBox79, TextBox80, TextBox81, TextBox82, TextBox83, TextBox84, TextBox85, TextBox86, TextBox87, TextBox88, TextBox89, TextBox90, TextBox91, TextBox92, TextBox93, TextBox94, TextBox95, TextBox96, TextBox97, TextBox98, TextBox99, TextBox100}
        Dim checkboxarray() As CheckBox = {CheckBox1, CheckBox2, CheckBox3, CheckBox4, CheckBox5, CheckBox6, CheckBox7, CheckBox8, CheckBox9, CheckBox10, CheckBox11, CheckBox12, CheckBox13, CheckBox14, CheckBox15, CheckBox16, CheckBox17, CheckBox18, CheckBox19, CheckBox20, CheckBox21, CheckBox22, CheckBox23, CheckBox24, CheckBox25, CheckBox26, CheckBox27, CheckBox28, CheckBox29, CheckBox30, CheckBox31, CheckBox32, CheckBox33, CheckBox34, CheckBox35, CheckBox36, CheckBox37, CheckBox38, CheckBox39, CheckBox40, CheckBox41, CheckBox42, CheckBox43, CheckBox44, CheckBox45, CheckBox46, CheckBox47, CheckBox48, CheckBox49, CheckBox50, CheckBox51, CheckBox52, CheckBox53, CheckBox54, CheckBox55, CheckBox56, CheckBox57, CheckBox58, CheckBox59, CheckBox60, CheckBox61, CheckBox62, CheckBox63, CheckBox64, CheckBox65, CheckBox66, CheckBox67, CheckBox68, CheckBox69, CheckBox70, CheckBox71, CheckBox72, CheckBox73, CheckBox74, CheckBox75, CheckBox76, CheckBox77, CheckBox78, CheckBox79, CheckBox80, CheckBox81, CheckBox82, CheckBox83, CheckBox84, CheckBox85, CheckBox86, CheckBox87, CheckBox88, CheckBox89, CheckBox90, CheckBox91, CheckBox92, CheckBox93, CheckBox94, CheckBox95, CheckBox96, CheckBox97, CheckBox98, CheckBox99, CheckBox100}
        Dim a As Integer
        a = CInt(Int(teacherstart.TextBox1.Text))
        For i = 0 To 99
            textboxarray(i).Hide()
            checkboxarray(i).Hide()
        Next i
        For i = 0 To a - 1
            textboxarray(i).Text = ""
            textboxarray(i).Show()
            checkboxarray(i).Show()
        Next i
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        start.Show()
    End Sub


End Class