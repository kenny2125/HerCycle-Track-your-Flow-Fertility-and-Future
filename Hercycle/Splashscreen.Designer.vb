<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splashscreen
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splashscreen))
        Me.pnl_splashscreen = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btn_getstarted = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_subheader = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_header = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.pnl_splashscreen.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_splashscreen
        '
        Me.pnl_splashscreen.BackColor = System.Drawing.Color.Transparent
        Me.pnl_splashscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnl_splashscreen.BorderRadius = 25
        Me.pnl_splashscreen.Controls.Add(Me.Guna2Button1)
        Me.pnl_splashscreen.Controls.Add(Me.Guna2PictureBox1)
        Me.pnl_splashscreen.Controls.Add(Me.btn_getstarted)
        Me.pnl_splashscreen.Controls.Add(Me.lbl_subheader)
        Me.pnl_splashscreen.Controls.Add(Me.lbl_header)
        Me.pnl_splashscreen.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pnl_splashscreen.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.pnl_splashscreen.Location = New System.Drawing.Point(258, 234)
        Me.pnl_splashscreen.Name = "pnl_splashscreen"
        Me.pnl_splashscreen.Size = New System.Drawing.Size(1415, 622)
        Me.pnl_splashscreen.TabIndex = 7
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.Hercycle.My.Resources.Resources.femme_flow__1_
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(579, 60)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(300, 200)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 9
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'btn_getstarted
        '
        Me.btn_getstarted.AutoRoundedCorners = True
        Me.btn_getstarted.BackColor = System.Drawing.Color.Transparent
        Me.btn_getstarted.BorderRadius = 31
        Me.btn_getstarted.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_getstarted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_getstarted.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_getstarted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_getstarted.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_getstarted.Font = New System.Drawing.Font("Sylfaen", 23.0!, System.Drawing.FontStyle.Bold)
        Me.btn_getstarted.ForeColor = System.Drawing.Color.White
        Me.btn_getstarted.Location = New System.Drawing.Point(610, 471)
        Me.btn_getstarted.Name = "btn_getstarted"
        Me.btn_getstarted.Size = New System.Drawing.Size(238, 65)
        Me.btn_getstarted.TabIndex = 8
        Me.btn_getstarted.Text = "Get Started"
        '
        'lbl_subheader
        '
        Me.lbl_subheader.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subheader.Font = New System.Drawing.Font("Sitka Banner", 20.0!)
        Me.lbl_subheader.Location = New System.Drawing.Point(487, 388)
        Me.lbl_subheader.Name = "lbl_subheader"
        Me.lbl_subheader.Size = New System.Drawing.Size(485, 41)
        Me.lbl_subheader.TabIndex = 5
        Me.lbl_subheader.Text = "Start to know yourself better by using this app!"
        '
        'lbl_header
        '
        Me.lbl_header.BackColor = System.Drawing.Color.Transparent
        Me.lbl_header.Font = New System.Drawing.Font("Sitka Banner", 100.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_header.Location = New System.Drawing.Point(133, 176)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(1192, 195)
        Me.lbl_header.TabIndex = 2
        Me.lbl_header.Text = "Track your cycle now!"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 20
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Sylfaen", 23.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(1333, 32)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(53, 43)
        Me.Guna2Button1.TabIndex = 9
        Me.Guna2Button1.Text = "X"
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        '
        'Splashscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.BackgroundImage = Global.Hercycle.My.Resources.Resources.Splashscreen_Form
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.pnl_splashscreen)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Splashscreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Splashscreen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl_splashscreen.ResumeLayout(False)
        Me.pnl_splashscreen.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_splashscreen As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lbl_header As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_subheader As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_getstarted As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
End Class
