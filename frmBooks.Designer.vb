<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooks
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
        dgBooks = New Guna.UI2.WinForms.Guna2DataGridView()
        CType(dgBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgBooks
        ' 
        DataGridViewCellStyle4.BackColor = Color.White
        dgBooks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgBooks.ColumnHeadersHeight = 4
        dgBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgBooks.DefaultCellStyle = DataGridViewCellStyle6
        dgBooks.Dock = DockStyle.Fill
        dgBooks.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgBooks.Location = New Point(0, 0)
        dgBooks.Name = "dgBooks"
        dgBooks.RowHeadersVisible = False
        dgBooks.RowHeadersWidth = 51
        dgBooks.Size = New Size(880, 662)
        dgBooks.TabIndex = 0
        dgBooks.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgBooks.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgBooks.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgBooks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgBooks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgBooks.ThemeStyle.BackColor = Color.White
        dgBooks.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgBooks.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgBooks.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgBooks.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgBooks.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgBooks.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgBooks.ThemeStyle.HeaderStyle.Height = 4
        dgBooks.ThemeStyle.ReadOnly = False
        dgBooks.ThemeStyle.RowsStyle.BackColor = Color.White
        dgBooks.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgBooks.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgBooks.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgBooks.ThemeStyle.RowsStyle.Height = 29
        dgBooks.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgBooks.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' frmBooks
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(880, 662)
        Controls.Add(dgBooks)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmBooks"
        Text = "frmBooks"
        CType(dgBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgBooks As Guna.UI2.WinForms.Guna2DataGridView
End Class
