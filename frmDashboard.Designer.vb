<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        pnlTop = New Guna.UI2.WinForms.Guna2Panel()
        Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Label1 = New Label()
        NightControlBox1 = New ReaLTaiizor.Controls.NightControlBox()
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        btnAccount = New Guna.UI2.WinForms.Guna2Button()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        pnlMain = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Label3 = New Label()
        Label2 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        pnlTop.SuspendLayout()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Guna2Panel1.SuspendLayout()
        pnlMain.SuspendLayout()
        Guna2Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlTop
        ' 
        pnlTop.BackColor = Color.FromArgb(CByte(188), CByte(108), CByte(37))
        pnlTop.Controls.Add(Guna2PictureBox2)
        pnlTop.Controls.Add(Label1)
        pnlTop.Controls.Add(NightControlBox1)
        pnlTop.CustomizableEdges = CustomizableEdges3
        pnlTop.Dock = DockStyle.Top
        pnlTop.Location = New Point(0, 0)
        pnlTop.Name = "pnlTop"
        pnlTop.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        pnlTop.Size = New Size(1104, 40)
        pnlTop.TabIndex = 1
        ' 
        ' Guna2PictureBox2
        ' 
        Guna2PictureBox2.CustomizableEdges = CustomizableEdges1
        Guna2PictureBox2.Image = My.Resources.Resources.icons8_book
        Guna2PictureBox2.ImageRotate = 0F
        Guna2PictureBox2.Location = New Point(3, 6)
        Guna2PictureBox2.Name = "Guna2PictureBox2"
        Guna2PictureBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2PictureBox2.Size = New Size(25, 25)
        Guna2PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        Guna2PictureBox2.TabIndex = 3
        Guna2PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Jellee Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(34, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 24)
        Label1.TabIndex = 2
        Label1.Text = "Reader's World"
        ' 
        ' NightControlBox1
        ' 
        NightControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        NightControlBox1.BackColor = Color.Transparent
        NightControlBox1.CloseHoverColor = Color.FromArgb(CByte(199), CByte(80), CByte(80))
        NightControlBox1.CloseHoverForeColor = Color.White
        NightControlBox1.DefaultLocation = True
        NightControlBox1.DisableMaximizeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        NightControlBox1.DisableMinimizeColor = Color.FromArgb(CByte(105), CByte(105), CByte(105))
        NightControlBox1.EnableCloseColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        NightControlBox1.EnableMaximizeButton = False
        NightControlBox1.EnableMaximizeColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        NightControlBox1.EnableMinimizeButton = True
        NightControlBox1.EnableMinimizeColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        NightControlBox1.Location = New Point(965, 0)
        NightControlBox1.MaximizeHoverColor = Color.FromArgb(CByte(15), CByte(255), CByte(255), CByte(255))
        NightControlBox1.MaximizeHoverForeColor = Color.White
        NightControlBox1.MinimizeHoverColor = Color.FromArgb(CByte(15), CByte(255), CByte(255), CByte(255))
        NightControlBox1.MinimizeHoverForeColor = Color.White
        NightControlBox1.Name = "NightControlBox1"
        NightControlBox1.Size = New Size(139, 31)
        NightControlBox1.TabIndex = 0
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.TargetControl = pnlTop
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' btnAccount
        ' 
        btnAccount.BorderRadius = 10
        btnAccount.CustomizableEdges = CustomizableEdges5
        btnAccount.DisabledState.BorderColor = Color.DarkGray
        btnAccount.DisabledState.CustomBorderColor = Color.DarkGray
        btnAccount.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAccount.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAccount.FillColor = Color.FromArgb(CByte(40), CByte(54), CByte(24))
        btnAccount.Font = New Font("Jellee Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAccount.ForeColor = Color.White
        btnAccount.Location = New Point(18, 554)
        btnAccount.Name = "btnAccount"
        btnAccount.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnAccount.Size = New Size(181, 56)
        btnAccount.TabIndex = 0
        btnAccount.Text = "Log Out"
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.Controls.Add(pnlMain)
        Guna2Panel1.Controls.Add(Guna2Panel2)
        Guna2Panel1.CustomizableEdges = CustomizableEdges11
        Guna2Panel1.Dock = DockStyle.Fill
        Guna2Panel1.Location = New Point(0, 40)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Panel1.Size = New Size(1104, 622)
        Guna2Panel1.TabIndex = 3
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(TableLayoutPanel1)
        pnlMain.CustomizableEdges = CustomizableEdges7
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(224, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        pnlMain.Size = New Size(880, 622)
        pnlMain.TabIndex = 3
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.BackColor = Color.FromArgb(CByte(221), CByte(161), CByte(94))
        Guna2Panel2.Controls.Add(Label3)
        Guna2Panel2.Controls.Add(Label2)
        Guna2Panel2.Controls.Add(btnAccount)
        Guna2Panel2.CustomizableEdges = CustomizableEdges9
        Guna2Panel2.Dock = DockStyle.Left
        Guna2Panel2.Location = New Point(0, 0)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Panel2.Size = New Size(224, 622)
        Guna2Panel2.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Jellee Bold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(3, 99)
        Label3.Name = "Label3"
        Label3.Size = New Size(226, 105)
        Label3.TabIndex = 2
        Label3.Text = "Find Your Suitable Books " & vbCrLf & "Here And Gain More" & vbCrLf & "Knowldedge..." & vbCrLf & vbCrLf & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Jellee Bold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(3, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(211, 22)
        Label2.TabIndex = 1
        Label2.Text = "Welcome To E-Library"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(880, 622)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        ClientSize = New Size(1104, 662)
        Controls.Add(Guna2Panel1)
        Controls.Add(pnlTop)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmDashboard"
        pnlTop.ResumeLayout(False)
        pnlTop.PerformLayout()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Guna2Panel1.ResumeLayout(False)
        pnlMain.ResumeLayout(False)
        Guna2Panel2.ResumeLayout(False)
        Guna2Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents pnlTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents NightControlBox1 As ReaLTaiizor.Controls.NightControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
