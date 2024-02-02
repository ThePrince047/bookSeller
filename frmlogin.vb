Public Class frmlogin
    Private Sub loginSubmitBtn_Click(sender As Object, e As EventArgs) Handles loginSubmitBtn.Click
        frmDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub signuptxt_Click(sender As Object, e As EventArgs) Handles signuptxt.Click
        frmsignup.Show()
        Me.Hide()
    End Sub
End Class
