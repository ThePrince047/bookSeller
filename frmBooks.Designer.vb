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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgBooks = New ReaLTaiizor.Controls.PoisonDataGridView()
        CType(dgBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgBooks
        ' 
        dgBooks.AllowUserToResizeRows = False
        dgBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgBooks.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        dgBooks.BorderStyle = BorderStyle.None
        dgBooks.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(188), CByte(108), CByte(37))
        DataGridViewCellStyle1.Font = New Font("Jellee Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(188), CByte(108), CByte(37))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(188), CByte(108), CByte(37))
        DataGridViewCellStyle2.Font = New Font("Jellee Bold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(188), CByte(108), CByte(37))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgBooks.DefaultCellStyle = DataGridViewCellStyle2
        dgBooks.Dock = DockStyle.Fill
        dgBooks.EnableHeadersVisualStyles = False
        dgBooks.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        dgBooks.GridColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        dgBooks.Location = New Point(0, 0)
        dgBooks.Name = "dgBooks"
        dgBooks.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(0), CByte(174), CByte(219))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(0), CByte(198), CByte(247))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(17), CByte(17), CByte(17))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgBooks.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgBooks.RowHeadersWidth = 51
        dgBooks.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgBooks.Size = New Size(880, 662)
        dgBooks.TabIndex = 0
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

    Friend WithEvents dgBooks As ReaLTaiizor.Controls.PoisonDataGridView
End Class
