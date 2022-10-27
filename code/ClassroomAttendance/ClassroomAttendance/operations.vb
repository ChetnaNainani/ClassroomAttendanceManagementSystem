Public Class operations
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        selectdateforview.Show()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        login.Show()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        teacherstart.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Me.ComboBox1.SelectedItem = "Take Attendance") = True Then
            Me.Hide()
            selectdatefortake.Show()
        ElseIf (Me.ComboBox1.SelectedItem = "View Attendance") = True Then
            Me.Hide()
            selectdateforview.Show()
        ElseIf (Me.ComboBox1.SelectedItem = "View StudentInformation") = True Then
            Me.Hide()
            studentinformation.Show()
        ElseIf (Me.ComboBox1.SelectedItem = "View Notice") = True Then
            Me.Hide()
            displaynotice.Show()
        ElseIf (Me.ComboBox1.SelectedItem = "View Defaulters") = True Then
            Me.Hide()
            defaulters.Show()
        End If
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        start.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class