<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminstart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StudentDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteFacultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateFacultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewFacultyInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OtherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NoticeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewTimeTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SetTimetableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentDetailsToolStripMenuItem
        '
        Me.StudentDetailsToolStripMenuItem.Image = Global.ClassroomAttendance.My.Resources.Resources._9396080_Pulsante_Aggiorna_lucido_Archivio_Fotografico
        Me.StudentDetailsToolStripMenuItem.Name = "StudentDetailsToolStripMenuItem"
        Me.StudentDetailsToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.StudentDetailsToolStripMenuItem.Text = "Update Student"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AttendanceToolStripMenuItem, Me.FacultyToolStripMenuItem, Me.ClassToolStripMenuItem, Me.StudentToolStripMenuItem, Me.OtherToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(809, 30)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AttendanceToolStripMenuItem
        '
        Me.AttendanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAttendanceToolStripMenuItem})
        Me.AttendanceToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AttendanceToolStripMenuItem.Image = Global.ClassroomAttendance.My.Resources.Resources.stock_vector_vector_illustration_of_a_checklist_with_a_detailed_pencil_checking_off_tasks_126009953
        Me.AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        Me.AttendanceToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.AttendanceToolStripMenuItem.Text = "Attendance"
        '
        'ViewAttendanceToolStripMenuItem
        '
        Me.ViewAttendanceToolStripMenuItem.Image = Global.ClassroomAttendance.My.Resources.Resources.images__1_
        Me.ViewAttendanceToolStripMenuItem.Name = "ViewAttendanceToolStripMenuItem"
        Me.ViewAttendanceToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.ViewAttendanceToolStripMenuItem.Text = "View Attendance"
        '
        'FacultyToolStripMenuItem
        '
        Me.FacultyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.DeleteFacultyToolStripMenuItem, Me.UpdateFacultyToolStripMenuItem, Me.ViewFacultyInformationToolStripMenuItem, Me.SetTimetableToolStripMenuItem})
        Me.FacultyToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FacultyToolStripMenuItem.Image = Global.ClassroomAttendance.My.Resources.Resources.conference_room
        Me.FacultyToolStripMenuItem.Name = "FacultyToolStripMenuItem"
        Me.FacultyToolStripMenuItem.Size = New System.Drawing.Size(104, 26)
        Me.FacultyToolStripMenuItem.Text = "Faculty"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Image = Global.ClassroomAttendance.My.Resources.Resources.new_user
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.AddToolStripMenuItem.Text = "Add Faculty"
        '
        'DeleteFacultyToolStripMenuItem
        '
        Me.DeleteFacultyToolStripMenuItem.Image = Global.ClassroomAttendance.My.Resources.Resources.eliminar_simbolo_de_contacto_para_la_interfaz_318_46960
        Me.DeleteFacultyToolStripMenuItem.Name = "DeleteFacultyToolStripMenuItem"
        Me.DeleteFacultyToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.DeleteFacultyToolStripMenuItem.Text = "Delete Faculty"
        '
        'UpdateFacultyToolStripMenuItem
        '
        Me.UpdateFacultyToolStripMenuItem.Image = Global.ClassroomAttendance.My.Resources.Resources._14516142_update_icon_on_glossy_orange_round_button1
        Me.UpdateFacultyToolStripMenuItem.Name = "UpdateFacultyToolStripMenuItem"
        Me.UpdateFacultyToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.UpdateFacultyToolStripMenuItem.Text = "Update Faculty"
        '
        'ViewFacultyInformationToolStripMenuItem
        '
        Me.ViewFacultyInformationToolStripMenuItem.Image = Global.ClassroomAttendance.My.Resources.Resources.contact_details__ios_7_interface_symbol_318_33582
        Me.ViewFacultyInformationToolStripMenuItem.Name = "ViewFacultyInformationToolStripMenuItem"
        Me.ViewFacultyInformationToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.ViewFacultyInformationToolStripMenuItem.Text = "Faculty Details"
        '
        'ClassToolStripMenuItem
        '
        Me.ClassToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddClassToolStripMenuItem, Me.DeleteClassToolStripMenuItem})
        Me.ClassToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ClassToolStripMenuItem.Image = Global.ClassroomAttendance.My.Resources.Resources._21936872_Training_icon_Stock_Vector_presentation
        Me.ClassToolStripMenuItem.Name = "ClassToolStripMenuItem"
        Me.ClassToolStripMenuItem.Size = New System.Drawing.Size(88, 26)
        Me.ClassToolStripMenuItem.Text = "Class"
        '
        'AddClassToolStripMenuItem
        '
        Me.AddClassToolStripMenuItem.Image = Global.ClassroomAttendance.My.Resources.Resources.red_plus_md
        Me.AddClassToolStripMenuItem.Name = "AddClassToolStripMenuItem"
        Me.AddClassToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.AddClassToolStripMenuItem.Text = "Add Class "
        '
        'DeleteClassToolStripMenuItem
        '
        Me.DeleteClassToolStripMenuItem.Image = Global.ClassroomAttendance.My.Resources.Resources.notification_remove__1_
        Me.DeleteClassToolStripMenuItem.Name = "DeleteClassToolStripMenuItem"
        Me.DeleteClassToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.DeleteClassToolStripMenuItem.Text = "Delete Class"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStudentToolStripMenuItem, Me.DeleteStudentToolStripMenuItem, Me.StudentDetailsToolStripMenuItem})
        Me.StudentToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.StudentToolStripMenuItem.Image = Global.ClassroomAttendance.My.Resources.Resources.image
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'AddStudentToolStripMenuItem
        '
        Me.AddStudentToolStripMenuItem.Image = Global.ClassroomAttendance.My.Resources.Resources.download
        Me.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem"
        Me.AddStudentToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AddStudentToolStripMenuItem.Text = "Add Student"
        '
        'DeleteStudentToolStripMenuItem
        '
        Me.DeleteStudentToolStripMenuItem.Image = Global.ClassroomAttendance.My.Resources.Resources.images
        Me.DeleteStudentToolStripMenuItem.Name = "DeleteStudentToolStripMenuItem"
        Me.DeleteStudentToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DeleteStudentToolStripMenuItem.Text = "Delete Student"
        '
        'OtherToolStripMenuItem
        '
        Me.OtherToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoticeToolStripMenuItem, Me.ViewTimeTableToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.OtherToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.OtherToolStripMenuItem.Image = Global.ClassroomAttendance.My.Resources.Resources.menu_alt_5123
        Me.OtherToolStripMenuItem.Name = "OtherToolStripMenuItem"
        Me.OtherToolStripMenuItem.Size = New System.Drawing.Size(90, 26)
        Me.OtherToolStripMenuItem.Text = "Other"
        '
        'NoticeToolStripMenuItem
        '
        Me.NoticeToolStripMenuItem.Image = Global.ClassroomAttendance.My.Resources.Resources._105_512
        Me.NoticeToolStripMenuItem.Name = "NoticeToolStripMenuItem"
        Me.NoticeToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.NoticeToolStripMenuItem.Text = "Notice"
        '
        'ViewTimeTableToolStripMenuItem
        '
        Me.ViewTimeTableToolStripMenuItem.Image = Global.ClassroomAttendance.My.Resources.Resources.jadwal1
        Me.ViewTimeTableToolStripMenuItem.Name = "ViewTimeTableToolStripMenuItem"
        Me.ViewTimeTableToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.ViewTimeTableToolStripMenuItem.Text = "View TimeTable"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Image = Global.ClassroomAttendance.My.Resources.Resources.logout__ios_7_interface_symbol_318_33643
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(699, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Admin Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(640, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Login :"
        '
        'SetTimetableToolStripMenuItem
        '
        Me.SetTimetableToolStripMenuItem.Name = "SetTimetableToolStripMenuItem"
        Me.SetTimetableToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.SetTimetableToolStripMenuItem.Text = "Set Timetable"
        '
        'adminstart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ClassroomAttendance.My.Resources.Resources.Knowledge
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(809, 378)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "adminstart"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StudentDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacultyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteFacultyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateFacultyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewFacultyInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoticeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewTimeTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SetTimetableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
