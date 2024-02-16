Public Class frmDashboard
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        frmlogin.Show()
        Me.Hide()
    End Sub
    Sub childform(ByVal panel As Form)
        pnlMain.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        pnlMain.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        childform(frmsignup)
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class