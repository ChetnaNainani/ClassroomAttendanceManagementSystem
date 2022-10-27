Imports System.Data.OleDb

Public Class studentinformation
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim myReader As OleDbDataReader
    Public Shared ds As DataSet ' whole data shared to access data from diffrent table n in d   
    Public Shared dv As DataView ' abstract data 
    Dim cmd As OleDbCommand
    Dim adp As OleDbDataAdapter
    Dim cm As CurrencyManager
    Private Sub studentinformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Hide()
        provider = "provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datafile = "D:\ClassroomAttendanceManagementSystem\database\ProjectDatabase.accdb"
        connString = provider & datafile
        myconnection.ConnectionString = connString
        myconnection.Open()
        Dim str As String = "select * from student"
        cmd = New OleDbCommand(str, myconnection)
        myReader = cmd.ExecuteReader
        Do
            While myReader.Read()
                TextBox1.Text = myReader(0)
                TextBox2.Text = myReader(1)
                TextBox3.Text = myReader(2)
                TextBox4.Text = myReader(3)
            End While

        Loop While myReader.NextResult()
        myReader.Close()
        adp = New OleDbDataAdapter(str, myconnection)
        filldatasetanddataview()
        bindingfields()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        start.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cm.Position = 0
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cm.Position -= 1
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cm.Position += 1
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        cm.Position = cm.Count - 1
    End Sub
    Private Sub filldatasetanddataview()
        ds = New DataSet()
        adp.Fill(ds, "student")
        dv = New DataView(ds.Tables("student"))
        cm = CType(Me.BindingContext(dv), CurrencyManager)
        DataGridView1.DataSource = dv
    End Sub
    Private Sub bindingfields()
        TextBox1.DataBindings.Clear()
        TextBox2.DataBindings.Clear()
        TextBox3.DataBindings.Clear()
        TextBox4.DataBindings.Clear()
        TextBox1.DataBindings.Add("text", dv, "rollno")
        TextBox2.DataBindings.Add("text", dv, "Name")
        TextBox3.DataBindings.Add("text", dv, "Contact")
        TextBox4.DataBindings.Add("text", dv, "Class")
    End Sub
End Class