Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration

Public Class frmlogin
    Private Sub loginSubmitBtn_Click(sender As Object, e As EventArgs) Handles loginSubmitBtn.Click
        If String.IsNullOrEmpty(txtUsernameLogin.Text) = True Then
            MessageBox.Show("Please Enter Your Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf String.IsNullOrEmpty(txtPasswordLogin.Text) = True Then
            MessageBox.Show("Please Enter Your Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.net Projects\bookseller.accdb")
            con.Open()
            Dim cmd As New OleDbCommand("SELECT username,password FROM userTable WHERE username = '" & txtUsernameLogin.Text & "' AND password = '" & txtPasswordLogin.Text & "'", con)
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            If dr.HasRows = True Then
                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmDashboard.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub signuptxt_Click(sender As Object, e As EventArgs) Handles signuptxt.Click
        frmsignup.Show()
        Me.Hide()
    End Sub


End Class
