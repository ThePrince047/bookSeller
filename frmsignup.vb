Imports System.Data.OleDb
Imports System.Data


Public Class frmsignup
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        frmlogin.Show()
        Me.Hide()
    End Sub

    Private Sub signupSubmitBtn_Click(sender As Object, e As EventArgs) Handles signupSubmitBtn.Click

        If String.IsNullOrEmpty(txtUsernameSignup.Text) = True Then
            MessageBox.Show("Please Enter Your Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf String.IsNullOrEmpty(txtEmailSignup.Text) = True Then
            MessageBox.Show("Please Enter Your Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf String.IsNullOrEmpty(txtPasswordSignup.Text) = True Then
            MessageBox.Show("Please Enter Your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf String.IsNullOrEmpty(txtConpasswordSignup.Text) = True Then
            MessageBox.Show("Please Confirm Your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtPasswordSignup.Text = txtConpasswordSignup.Text Then
                Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.net Projects\bookseller.accdb")
                con.Open()
                If rbAdmin.Checked = True Then
                    Dim cmd As New OleDbCommand("INSERT INTO userTable([username],[email],[password],[isAdmin]) VALUES('" & txtUsernameSignup.Text & "','" & txtEmailSignup.Text & "','" & txtPasswordSignup.Text & "','Yes')", con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Account Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtUsernameSignup.Clear()
                    txtEmailSignup.Clear()
                    txtPasswordSignup.Clear()
                    txtConpasswordSignup.Clear()
                    rbAdmin.Checked = False
                    frmlogin.Show()
                    Me.Hide()
                ElseIf rbUser.Checked = True Then
                    Dim cmd As New OleDbCommand("INSERT INTO userTable([username],[email],[password],[isAdmin]) VALUES('" & txtUsernameSignup.Text & "','" & txtEmailSignup.Text & "','" & txtPasswordSignup.Text & "','No')", con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Account Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtUsernameSignup.Clear()
                    txtEmailSignup.Clear()
                    txtPasswordSignup.Clear()
                    txtConpasswordSignup.Clear()
                    rbUser.Checked = False
                    frmlogin.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Please Select User Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Password Does Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

End Class