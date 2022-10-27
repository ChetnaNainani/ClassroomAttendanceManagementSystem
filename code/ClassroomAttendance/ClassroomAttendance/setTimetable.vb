Imports System.Data.OleDb
Public Class setTimetable
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim cmd, cmd1 As OleDbCommand
    Dim myReader As OleDbDataReader
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim myconnection As OleDbConnection
    Private Sub setTimetable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\ClassroomAttendanceManagementSystem\database\ProjectDatabase.accdb"
        connString = provider & datafile
        myconnection = New OleDbConnection(connString)
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(username) from teacher "
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox73.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()

    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        'Dim oddcombobox() As ComboBox = {ComboBox1, ComboBox3, ComboBox5, ComboBox7, ComboBox9, ComboBox11, ComboBox13, ComboBox15, ComboBox17, ComboBox19, ComboBox21, ComboBox23, ComboBox25, ComboBox27, ComboBox29, ComboBox31, ComboBox33, ComboBox35, ComboBox37, ComboBox39, ComboBox41, ComboBox43, ComboBox45, ComboBox47, ComboBox49, ComboBox51, ComboBox53, ComboBox55, ComboBox57, ComboBox59, ComboBox61, ComboBox63, ComboBox65, ComboBox67, ComboBox69}
        'Dim evencombobox() As ComboBox = {ComboBox2, ComboBox4, ComboBox6, ComboBox8, ComboBox10, ComboBox12, ComboBox14, ComboBox16, ComboBox18, ComboBox20, ComboBox22, ComboBox24, ComboBox26, ComboBox28, ComboBox30, ComboBox32, ComboBox34, ComboBox36, ComboBox38, ComboBox40, ComboBox42, ComboBox44, ComboBox46, ComboBox48, ComboBox50, ComboBox52, ComboBox54, ComboBox56, ComboBox58, ComboBox60, ComboBox62, ComboBox64, ComboBox66, ComboBox68, ComboBox70}

        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Class) from subject where username= '" & ComboBox73.Text & "' "
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()

                ComboBox2.Items.Add(myReader(0))
                ComboBox4.Items.Add(myReader(0))
                ComboBox6.Items.Add(myReader(0))
                ComboBox8.Items.Add(myReader(0))
                ComboBox10.Items.Add(myReader(0))
                ComboBox12.Items.Add(myReader(0))
                ComboBox14.Items.Add(myReader(0))
                ComboBox16.Items.Add(myReader(0))
                ComboBox18.Items.Add(myReader(0))
                ComboBox20.Items.Add(myReader(0))
                ComboBox22.Items.Add(myReader(0))
                ComboBox24.Items.Add(myReader(0))
                ComboBox26.Items.Add(myReader(0))
                ComboBox28.Items.Add(myReader(0))
                ComboBox30.Items.Add(myReader(0))
                ComboBox32.Items.Add(myReader(0))
                ComboBox34.Items.Add(myReader(0))
                ComboBox36.Items.Add(myReader(0))
                ComboBox38.Items.Add(myReader(0))
                ComboBox40.Items.Add(myReader(0))
                ComboBox42.Items.Add(myReader(0))
                ComboBox44.Items.Add(myReader(0))
                ComboBox46.Items.Add(myReader(0))
                ComboBox48.Items.Add(myReader(0))
                ComboBox50.Items.Add(myReader(0))
                ComboBox52.Items.Add(myReader(0))
                ComboBox54.Items.Add(myReader(0))
                ComboBox56.Items.Add(myReader(0))
                ComboBox58.Items.Add(myReader(0))
                ComboBox60.Items.Add(myReader(0))
                ComboBox62.Items.Add(myReader(0))
                ComboBox64.Items.Add(myReader(0))
                ComboBox66.Items.Add(myReader(0))
                ComboBox68.Items.Add(myReader(0))
                ComboBox70.Items.Add(myReader(0))
                ComboBox72.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox2.Text & "' and username='" & ComboBox73.Text & "'"
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

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox4.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox3.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox6.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox5.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox8.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox7.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox10.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox9.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox12.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox11.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox20.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox19.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox18.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox17.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox16.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox15.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox14.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox13.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox56.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox55.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox54.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox53.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox28.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox27.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox26.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox25.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox24.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox23.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox22.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox21.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox60.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox59.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox58.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox57.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox30.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox29.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox32.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox31.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox34.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox33.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox36.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox35.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox38.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox37.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox40.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox39.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox42.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox41.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox44.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox43.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox46.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox45.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox48.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox47.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox50.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox49.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox52.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox51.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox62.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox61.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox64.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox63.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox66.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox65.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox68.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox67.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox70.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox69.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        myconnection.Open()
        Dim cmd As New OleDbCommand()
        cmd.Connection = myconnection 'oledbconnctn obj
        Dim query As String = "Select distinct(Subject) from subject where Class='" & ComboBox72.Text & "' and username='" & ComboBox73.Text & "'"
        cmd = New OleDbCommand(query, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                ComboBox70.Items.Add(myReader(0))
            End While
        Loop While myReader.NextResult()
        myReader.Close()
        myconnection.Close()
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        Me.Hide()
        viewtimetable.Show()
    End Sub
End Class
