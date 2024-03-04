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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgUser = New ReaLTaiizor.Controls.PoisonDataGridView()
        CType(dgUser, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgUser
        ' 
        dgUser.AllowUserToResizeRows = False
        dgUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgUser.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        dgUser.BorderStyle = BorderStyle.None
        dgUser.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(188), CByte(108), CByte(37))
        DataGridViewCellStyle1.Font = New Font("Jellee Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(188), CByte(108), CByte(37))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(136), CByte(136), CByte(136))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(0), CByte(198), CByte(247))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgUser.DefaultCellStyle = DataGridViewCellStyle2
        dgUser.Dock = DockStyle.Fill
        dgUser.EnableHeadersVisualStyles = False
        dgUser.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        dgUser.GridColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        dgUser.Location = New Point(0, 0)
        dgUser.Name = "dgUser"
        dgUser.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        DataGridViewCellStyle3.Font = New Font("Jellee Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(188), CByte(108), CByte(37))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgUser.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgUser.RowHeadersWidth = 51
        dgUser.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgUser.Size = New Size(880, 662)
        dgUser.TabIndex = 0
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

    Friend WithEvents dgUser As ReaLTaiizor.Controls.PoisonDataGridView
End Class
