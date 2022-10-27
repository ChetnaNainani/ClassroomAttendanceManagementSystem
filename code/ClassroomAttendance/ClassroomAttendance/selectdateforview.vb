Public Class selectdateforview
  
    Private Sub selectdatesnehalec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MonthCalendar2.MaxDate = Today
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.MonthCalendar2.MaxSelectionCount = 14

        If Me.MonthCalendar2.SelectionRange.Start = _
            Me.MonthCalendar2.SelectionRange.End Then

            viewattendance.TextBox1.Text = CStr(Me.MonthCalendar2.SelectionStart)

        Else

            viewattendance.TextBox1.Text = Me.MonthCalendar2.SelectionRange.Start & _
                " - " & Me.MonthCalendar2.SelectionRange.End

        End If
        Me.Hide()
        viewattendance.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        start.Show()
    End Sub
End Class