Public Class frmAdminPortal
    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
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

    Private Sub frmAdminPortal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        childform(frmUsers)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        childform(frmBooks)
    End Sub
End Class