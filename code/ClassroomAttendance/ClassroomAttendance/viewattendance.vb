Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports VB = Microsoft.VisualBasic
Public Class viewattendance
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim adp As OleDbDataAdapter
    Public Shared ds As DataSet ' whole data shared to access data from diffrent table n in d   
    Public Shared dv As DataView ' abstract data 
    Dim cm As CurrencyManager
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;data source=D:\myfinalproject\database\ProjectDatabase.accdb")
        cmd = New OleDbCommand()
        cmd.Connection = cn 'oledbconnctn obj
        Try
           
            adp = New OleDbDataAdapter("SELECT * FROM Attendance WHERE Date like '%" & TextBox1.Text & "%'", cn)
        Catch ex As Exception
            MsgBox("Attendance is already taken ")
        End Try
        filldatasetanddataview()
        bindingfields()
    End Sub
    Private Sub filldatasetanddataview()
        ds = New DataSet()
        adp.Fill(ds, "Attendance")
        dv = New DataView(ds.Tables("Attendance"))
        If ds.Tables("Attendance").Rows.Count = 0 Then
            MsgBox("Attendance not taken on this date!")
        End If

        cm = CType(Me.BindingContext(dv), CurrencyManager)
        DataGridView1.DataSource = dv
        DataGridView1.Refresh()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        operations.Show()
    End Sub
    Private Sub bindingfields()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        start.Show()
    End Sub
End Class