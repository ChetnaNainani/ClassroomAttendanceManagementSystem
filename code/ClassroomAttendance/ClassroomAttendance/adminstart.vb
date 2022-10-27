Public Class adminstart

    Private Sub ViewAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAttendanceToolStripMenuItem.Click
        Me.Hide()
        viewattendance.Show()
    End Sub
    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        Me.Hide()
        registerteacher.Show()
    End Sub
    Private Sub DeleteFacultyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteFacultyToolStripMenuItem.Click
        Me.Hide()
        deleteteacher.Show()
    End Sub
    Private Sub UpdateFacultyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateFacultyToolStripMenuItem.Click
        Me.Hide()
        updateteacher.Show()
    End Sub
    Private Sub ViewFacultyInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewFacultyInformationToolStripMenuItem.Click
        Me.Hide()
        facultydetails.Show()
    End Sub
    Private Sub AddClassToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddClassToolStripMenuItem.Click
        Me.Hide()
        addclass.show()
    End Sub
    Private Sub DeleteClassToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteClassToolStripMenuItem.Click
        Me.Hide()
        deleteclass.Show()
    End Sub
    Private Sub AddStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStudentToolStripMenuItem.Click
        Me.Hide()
        addstudent.Show()
    End Sub
    Private Sub DeleteStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteStudentToolStripMenuItem.Click
        Me.Hide()
        deletestudent.Show()
    End Sub
    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        start.Show()
    End Sub
    Private Sub NoticeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoticeToolStripMenuItem.Click
        Me.Hide()
        addnotice.Show()
    End Sub

    Private Sub StudentDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentDetailsToolStripMenuItem.Click
        Me.Hide()
        updatestudent.Show()
    End Sub

    Private Sub adminstart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SetTimetableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetTimetableToolStripMenuItem.Click
        Me.Hide()
        setTimetable.Show()
    End Sub
End Class