Imports System.Data.OleDb
Imports System.Data


Public Class frmUsers
    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagridshow()
    End Sub

    Private Sub datagridshow()
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.net Projects\bookseller.accdb")
        con.Open()
        Dim da As New OleDbDataAdapter("SELECT * FROM userTable", con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgUser.DataSource = dt
        con.Close()
    End Sub

End Class