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
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        pnlTop = New Guna.UI2.WinForms.Guna2Panel()
        Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Label1 = New Label()
        NightControlBox1 = New ReaLTaiizor.Controls.NightControlBox()
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        pnlTop.SuspendLayout()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(83, 398)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(225, 56)
        Guna2Button1.TabIndex = 0
        Guna2Button1.Text = "Guna2Button1"
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
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        ClientSize = New Size(1104, 662)
        Controls.Add(pnlTop)
        Controls.Add(Guna2Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmDashboard"
        pnlTop.ResumeLayout(False)
        pnlTop.PerformLayout()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents NightControlBox1 As ReaLTaiizor.Controls.NightControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
End Class
