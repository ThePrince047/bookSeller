<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgUser = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(dgUser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgUser
        ' 
        DataGridViewCellStyle4.BackColor = Color.White
        dgUser.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgUser.ColumnHeadersHeight = 4
        dgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgUser.DefaultCellStyle = DataGridViewCellStyle6
        dgUser.Dock = DockStyle.Fill
        dgUser.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgUser.Location = New Point(0, 0)
        dgUser.Name = "dgUser"
        dgUser.RowHeadersVisible = False
        dgUser.RowHeadersWidth = 51
        dgUser.Size = New Size(880, 662)
        dgUser.TabIndex = 0
        dgUser.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgUser.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgUser.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgUser.ThemeStyle.BackColor = Color.White
        dgUser.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgUser.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgUser.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgUser.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgUser.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgUser.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgUser.ThemeStyle.HeaderStyle.Height = 4
        dgUser.ThemeStyle.ReadOnly = False
        dgUser.ThemeStyle.RowsStyle.BackColor = Color.White
        dgUser.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgUser.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgUser.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgUser.ThemeStyle.RowsStyle.Height = 29
        dgUser.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgUser.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' frmUsers
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(880, 662)
        Controls.Add(dgUser)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmUsers"
        Text = "frmUsers"
        CType(dgUser, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgUser As Guna.UI2.WinForms.Guna2DataGridView
End Class
