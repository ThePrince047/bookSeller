Public Class frmsignup
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        frmlogin.Show()
        Me.Hide()
    End Sub

    Private Sub signupSubmitBtn_Click(sender As Object, e As EventArgs) Handles signupSubmitBtn.Click
        frmlogin.Show()
        Me.Hide()
    End Sub
End Class