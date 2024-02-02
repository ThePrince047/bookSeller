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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        pnlTop = New Guna.UI2.WinForms.Guna2Panel()
        Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Label1 = New Label()
        NightControlBox1 = New ReaLTaiizor.Controls.NightControlBox()
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        pnlSide = New Guna.UI2.WinForms.Guna2Panel()
        Label3 = New Label()
        Label2 = New Label()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        pnlMain = New Guna.UI2.WinForms.Guna2Panel()
        pnlTop.SuspendLayout()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        pnlSide.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderRadius = 10
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.FromArgb(CByte(40), CByte(54), CByte(24))
        Guna2Button1.Font = New Font("Jellee Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(12, 32)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(225, 56)
        Guna2Button1.TabIndex = 0
        Guna2Button1.Text = "Account"
        ' 
        ' pnlTop
        ' 
        pnlTop.BackColor = Color.FromArgb(CByte(188), CByte(108), CByte(37))
        pnlTop.Controls.Add(Guna2PictureBox2)
        pnlTop.Controls.Add(Label1)
        pnlTop.Controls.Add(NightControlBox1)
        pnlTop.CustomizableEdges = CustomizableEdges5
        pnlTop.Dock = DockStyle.Top
        pnlTop.Location = New Point(0, 0)
        pnlTop.Name = "pnlTop"
        pnlTop.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        pnlTop.Size = New Size(1104, 40)
        pnlTop.TabIndex = 1
        ' 
        ' Guna2PictureBox2
        ' 
        Guna2PictureBox2.CustomizableEdges = CustomizableEdges3
        Guna2PictureBox2.Image = My.Resources.Resources.icons8_book
        Guna2PictureBox2.ImageRotate = 0F
        Guna2PictureBox2.Location = New Point(3, 6)
        Guna2PictureBox2.Name = "Guna2PictureBox2"
        Guna2PictureBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
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
        ' pnlSide
        ' 
        pnlSide.BackColor = Color.FromArgb(CByte(221), CByte(161), CByte(94))
        pnlSide.Controls.Add(Label3)
        pnlSide.Controls.Add(Label2)
        pnlSide.Controls.Add(Guna2Button2)
        pnlSide.Controls.Add(Guna2Button1)
        pnlSide.CustomizableEdges = CustomizableEdges9
        pnlSide.Dock = DockStyle.Left
        pnlSide.Location = New Point(0, 40)
        pnlSide.Name = "pnlSide"
        pnlSide.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        pnlSide.Size = New Size(250, 622)
        pnlSide.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Jellee Bold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(34, 595)
        Label3.Name = "Label3"
        Label3.Size = New Size(181, 18)
        Label3.TabIndex = 3
        Label3.Text = "@ Developed By Prince"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Jellee Bold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(93, 574)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 21)
        Label2.TabIndex = 2
        Label2.Text = "V 2.0"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.BorderRadius = 10
        Guna2Button2.CustomizableEdges = CustomizableEdges7
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.FromArgb(CByte(40), CByte(54), CByte(24))
        Guna2Button2.Font = New Font("Jellee Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Location = New Point(12, 120)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2Button2.Size = New Size(225, 56)
        Guna2Button2.TabIndex = 1
        Guna2Button2.Text = "panelTest"
        ' 
        ' pnlMain
        ' 
        pnlMain.CustomizableEdges = CustomizableEdges11
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(250, 40)
        pnlMain.Name = "pnlMain"
        pnlMain.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        pnlMain.Size = New Size(854, 622)
        pnlMain.TabIndex = 3
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        ClientSize = New Size(1104, 662)
        Controls.Add(pnlMain)
        Controls.Add(pnlSide)
        Controls.Add(pnlTop)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmDashboard"
        pnlTop.ResumeLayout(False)
        pnlTop.PerformLayout()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        pnlSide.ResumeLayout(False)
        pnlSide.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents NightControlBox1 As ReaLTaiizor.Controls.NightControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pnlSide As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
End Class
