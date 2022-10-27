Public Class displaynotice

    Private Sub displaynotice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextBox1.Text = addnotice.TextBox1.Text
        If (TextBox1.Text = "") Then
            TextBox1.Text = "No New Notice"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        adminstart.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        start.Show()
    End Sub
End Class