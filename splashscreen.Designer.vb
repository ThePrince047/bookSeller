<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class splashscreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splashscreen))
        ProgressBar1 = New Guna.UI2.WinForms.Guna2ProgressBar()
        lb_percent = New Label()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.CustomizableEdges = CustomizableEdges1
        ProgressBar1.Location = New Point(152, 446)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.ProgressColor = Color.FromArgb(CByte(188), CByte(108), CByte(37))
        ProgressBar1.ProgressColor2 = Color.FromArgb(CByte(188), CByte(108), CByte(37))
        ProgressBar1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        ProgressBar1.Size = New Size(375, 38)
        ProgressBar1.TabIndex = 0
        ProgressBar1.Text = "Guna2ProgressBar1"
        ProgressBar1.TextRenderingHint = Drawing.Text.TextRenderingHint.SystemDefault
        ' 
        ' lb_percent
        ' 
        lb_percent.AutoSize = True
        lb_percent.Font = New Font("Jellee Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lb_percent.ForeColor = Color.FromArgb(CByte(188), CByte(108), CByte(37))
        lb_percent.Location = New Point(317, 415)
        lb_percent.Name = "lb_percent"
        lb_percent.Size = New Size(60, 28)
        lb_percent.TabIndex = 2
        lb_percent.Text = "000"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 8
        Guna2Elipse1.TargetControl = Me
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges3
        Guna2PictureBox1.ErrorImage = Nothing
        Guna2PictureBox1.Image = My.Resources.Resources.book
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(152, 99)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2PictureBox1.Size = New Size(375, 250)
        Guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Guna2PictureBox1.TabIndex = 3
        Guna2PictureBox1.TabStop = False
        ' 
        ' splashscreen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        ClientSize = New Size(699, 496)
        Controls.Add(Guna2PictureBox1)
        Controls.Add(lb_percent)
        Controls.Add(ProgressBar1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "splashscreen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Splashscreen"
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents lb_percent As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
