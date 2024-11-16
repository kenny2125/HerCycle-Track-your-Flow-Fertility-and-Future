<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Guna2ShapesTool1 = New Guna.UI2.WinForms.Guna2ShapesTool(Me.components)
        Me.DASHBOARD_TOP_PANEL = New Guna.UI2.WinForms.Guna2Panel()
        Me.EDIT_PROFILE_PANEL = New Guna.UI2.WinForms.Guna2Panel()
        Me.BACKGROUND = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.PERIOD_PANEL = New Guna.UI2.WinForms.Guna2Panel()
        Me.PHASE_PANEL = New Guna.UI2.WinForms.Guna2Panel()
        Me.FERTILITY_PAMEL = New Guna.UI2.WinForms.Guna2Panel()
        Me.ADVICE_PANEL = New Guna.UI2.WinForms.Guna2Panel()
        Me.OTHERS_PANEL = New Guna.UI2.WinForms.Guna2Panel()
        Me.PERIOD_TRACKER_PANEL = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2HtmlLabel12 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel13 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel14 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel15 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel16 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel17 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel18 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel19 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2HtmlLabel20 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DASHBOARD_TOP_PANEL.SuspendLayout()
        Me.BACKGROUND.SuspendLayout()
        Me.PERIOD_PANEL.SuspendLayout()
        Me.PHASE_PANEL.SuspendLayout()
        Me.FERTILITY_PAMEL.SuspendLayout()
        Me.ADVICE_PANEL.SuspendLayout()
        Me.OTHERS_PANEL.SuspendLayout()
        Me.PERIOD_TRACKER_PANEL.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2ShapesTool1
        '
        Me.Guna2ShapesTool1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2ShapesTool1.PolygonSkip = 1
        Me.Guna2ShapesTool1.Rotate = 0!
        Me.Guna2ShapesTool1.Size = New System.Drawing.Size(200, 200)
        Me.Guna2ShapesTool1.TargetControl = Nothing
        '
        'DASHBOARD_TOP_PANEL
        '
        Me.DASHBOARD_TOP_PANEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.DASHBOARD_TOP_PANEL.Controls.Add(Me.EDIT_PROFILE_PANEL)
        Me.DASHBOARD_TOP_PANEL.Dock = System.Windows.Forms.DockStyle.Top
        Me.DASHBOARD_TOP_PANEL.Location = New System.Drawing.Point(0, 0)
        Me.DASHBOARD_TOP_PANEL.Name = "DASHBOARD_TOP_PANEL"
        Me.DASHBOARD_TOP_PANEL.Size = New System.Drawing.Size(1904, 170)
        Me.DASHBOARD_TOP_PANEL.TabIndex = 0
        '
        'EDIT_PROFILE_PANEL
        '
        Me.EDIT_PROFILE_PANEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.EDIT_PROFILE_PANEL.Location = New System.Drawing.Point(1509, 31)
        Me.EDIT_PROFILE_PANEL.Name = "EDIT_PROFILE_PANEL"
        Me.EDIT_PROFILE_PANEL.Size = New System.Drawing.Size(355, 101)
        Me.EDIT_PROFILE_PANEL.TabIndex = 0
        '
        'BACKGROUND
        '
        Me.BACKGROUND.Controls.Add(Me.PERIOD_TRACKER_PANEL)
        Me.BACKGROUND.Controls.Add(Me.OTHERS_PANEL)
        Me.BACKGROUND.Controls.Add(Me.ADVICE_PANEL)
        Me.BACKGROUND.Controls.Add(Me.FERTILITY_PAMEL)
        Me.BACKGROUND.Controls.Add(Me.PHASE_PANEL)
        Me.BACKGROUND.Controls.Add(Me.PERIOD_PANEL)
        Me.BACKGROUND.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BACKGROUND.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BACKGROUND.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.BACKGROUND.Location = New System.Drawing.Point(0, 170)
        Me.BACKGROUND.Name = "BACKGROUND"
        Me.BACKGROUND.Size = New System.Drawing.Size(1904, 871)
        Me.BACKGROUND.TabIndex = 2
        '
        'PERIOD_PANEL
        '
        Me.PERIOD_PANEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.PERIOD_PANEL.Controls.Add(Me.Guna2HtmlLabel3)
        Me.PERIOD_PANEL.Controls.Add(Me.Guna2HtmlLabel2)
        Me.PERIOD_PANEL.Controls.Add(Me.Guna2HtmlLabel1)
        Me.PERIOD_PANEL.Location = New System.Drawing.Point(29, 21)
        Me.PERIOD_PANEL.Name = "PERIOD_PANEL"
        Me.PERIOD_PANEL.Size = New System.Drawing.Size(450, 450)
        Me.PERIOD_PANEL.TabIndex = 0
        '
        'PHASE_PANEL
        '
        Me.PHASE_PANEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.PHASE_PANEL.Controls.Add(Me.Guna2HtmlLabel19)
        Me.PHASE_PANEL.Controls.Add(Me.Guna2HtmlLabel7)
        Me.PHASE_PANEL.Controls.Add(Me.Guna2HtmlLabel6)
        Me.PHASE_PANEL.Controls.Add(Me.Guna2HtmlLabel5)
        Me.PHASE_PANEL.Controls.Add(Me.Guna2HtmlLabel4)
        Me.PHASE_PANEL.Location = New System.Drawing.Point(494, 21)
        Me.PHASE_PANEL.Name = "PHASE_PANEL"
        Me.PHASE_PANEL.Size = New System.Drawing.Size(450, 450)
        Me.PHASE_PANEL.TabIndex = 1
        '
        'FERTILITY_PAMEL
        '
        Me.FERTILITY_PAMEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.FERTILITY_PAMEL.Controls.Add(Me.Guna2HtmlLabel10)
        Me.FERTILITY_PAMEL.Controls.Add(Me.Guna2HtmlLabel9)
        Me.FERTILITY_PAMEL.Controls.Add(Me.Guna2HtmlLabel8)
        Me.FERTILITY_PAMEL.Location = New System.Drawing.Point(961, 21)
        Me.FERTILITY_PAMEL.Name = "FERTILITY_PAMEL"
        Me.FERTILITY_PAMEL.Size = New System.Drawing.Size(450, 450)
        Me.FERTILITY_PAMEL.TabIndex = 2
        '
        'ADVICE_PANEL
        '
        Me.ADVICE_PANEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.ADVICE_PANEL.Controls.Add(Me.Guna2HtmlLabel12)
        Me.ADVICE_PANEL.Controls.Add(Me.Label1)
        Me.ADVICE_PANEL.Controls.Add(Me.Guna2HtmlLabel11)
        Me.ADVICE_PANEL.Location = New System.Drawing.Point(1430, 21)
        Me.ADVICE_PANEL.Name = "ADVICE_PANEL"
        Me.ADVICE_PANEL.Size = New System.Drawing.Size(450, 450)
        Me.ADVICE_PANEL.TabIndex = 3
        '
        'OTHERS_PANEL
        '
        Me.OTHERS_PANEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.OTHERS_PANEL.Controls.Add(Me.Guna2HtmlLabel20)
        Me.OTHERS_PANEL.Controls.Add(Me.Guna2HtmlLabel17)
        Me.OTHERS_PANEL.Controls.Add(Me.Guna2HtmlLabel16)
        Me.OTHERS_PANEL.Controls.Add(Me.Guna2HtmlLabel15)
        Me.OTHERS_PANEL.Controls.Add(Me.Guna2HtmlLabel14)
        Me.OTHERS_PANEL.Controls.Add(Me.Guna2HtmlLabel13)
        Me.OTHERS_PANEL.Location = New System.Drawing.Point(29, 516)
        Me.OTHERS_PANEL.Name = "OTHERS_PANEL"
        Me.OTHERS_PANEL.Size = New System.Drawing.Size(701, 343)
        Me.OTHERS_PANEL.TabIndex = 4
        '
        'PERIOD_TRACKER_PANEL
        '
        Me.PERIOD_TRACKER_PANEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.PERIOD_TRACKER_PANEL.Controls.Add(Me.Guna2HtmlLabel18)
        Me.PERIOD_TRACKER_PANEL.Location = New System.Drawing.Point(751, 516)
        Me.PERIOD_TRACKER_PANEL.Name = "PERIOD_TRACKER_PANEL"
        Me.PERIOD_TRACKER_PANEL.Size = New System.Drawing.Size(1129, 343)
        Me.PERIOD_TRACKER_PANEL.TabIndex = 5
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Sitka Banner", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(115, 42)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(217, 50)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Period Tracking"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Lucida Fax", 90.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(42, 150)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(366, 139)
        Me.Guna2HtmlLabel2.TabIndex = 1
        Me.Guna2HtmlLabel2.Text = "Day 1"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Sitka Banner", 27.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(105, 343)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(241, 54)
        Me.Guna2HtmlLabel3.TabIndex = 2
        Me.Guna2HtmlLabel3.Text = "of Menstruation"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Sitka Banner", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(124, 42)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(208, 50)
        Me.Guna2HtmlLabel4.TabIndex = 1
        Me.Guna2HtmlLabel4.Text = "Phase Tracking"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Lucida Fax", 110.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(132, 120)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(197, 169)
        Me.Guna2HtmlLabel5.TabIndex = 2
        Me.Guna2HtmlLabel5.Text = "14"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(297, 264)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(55, 41)
        Me.Guna2HtmlLabel6.TabIndex = 3
        Me.Guna2HtmlLabel6.Text = "Days"
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Sitka Banner", 27.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(134, 311)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(192, 54)
        Me.Guna2HtmlLabel7.TabIndex = 4
        Me.Guna2HtmlLabel7.Text = "Currently on"
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Sitka Banner", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(117, 42)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(233, 50)
        Me.Guna2HtmlLabel8.TabIndex = 1
        Me.Guna2HtmlLabel8.Text = "Fertility Watcher"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(152, 92)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(168, 31)
        Me.Guna2HtmlLabel9.TabIndex = 2
        Me.Guna2HtmlLabel9.Text = "Menstruation Phase"
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Sitka Banner", 27.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(50, 343)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(358, 54)
        Me.Guna2HtmlLabel10.TabIndex = 3
        Me.Guna2HtmlLabel10.Text = "No Chance" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " of Pregnancy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Sitka Banner", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(88, 42)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(282, 50)
        Me.Guna2HtmlLabel11.TabIndex = 1
        Me.Guna2HtmlLabel11.Text = "Menstruation Advice"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Sitka Banner", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 180)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Guna2HtmlLabel12
        '
        Me.Guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel12.Font = New System.Drawing.Font("Sitka Banner", 27.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel12.Location = New System.Drawing.Point(115, 343)
        Me.Guna2HtmlLabel12.Name = "Guna2HtmlLabel12"
        Me.Guna2HtmlLabel12.Size = New System.Drawing.Size(216, 54)
        Me.Guna2HtmlLabel12.TabIndex = 3
        Me.Guna2HtmlLabel12.Text = "Stay Hydrated"
        '
        'Guna2HtmlLabel13
        '
        Me.Guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel13.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel13.Location = New System.Drawing.Point(29, 30)
        Me.Guna2HtmlLabel13.Name = "Guna2HtmlLabel13"
        Me.Guna2HtmlLabel13.Size = New System.Drawing.Size(153, 41)
        Me.Guna2HtmlLabel13.TabIndex = 2
        Me.Guna2HtmlLabel13.Text = "Current Time"
        '
        'Guna2HtmlLabel14
        '
        Me.Guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel14.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel14.Location = New System.Drawing.Point(29, 116)
        Me.Guna2HtmlLabel14.Name = "Guna2HtmlLabel14"
        Me.Guna2HtmlLabel14.Size = New System.Drawing.Size(153, 41)
        Me.Guna2HtmlLabel14.TabIndex = 3
        Me.Guna2HtmlLabel14.Text = "Menstruation"
        '
        'Guna2HtmlLabel15
        '
        Me.Guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel15.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel15.Location = New System.Drawing.Point(29, 163)
        Me.Guna2HtmlLabel15.Name = "Guna2HtmlLabel15"
        Me.Guna2HtmlLabel15.Size = New System.Drawing.Size(175, 41)
        Me.Guna2HtmlLabel15.TabIndex = 4
        Me.Guna2HtmlLabel15.Text = "Follicular Phase"
        '
        'Guna2HtmlLabel16
        '
        Me.Guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel16.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel16.Location = New System.Drawing.Point(29, 210)
        Me.Guna2HtmlLabel16.Name = "Guna2HtmlLabel16"
        Me.Guna2HtmlLabel16.Size = New System.Drawing.Size(110, 41)
        Me.Guna2HtmlLabel16.TabIndex = 5
        Me.Guna2HtmlLabel16.Text = "Ovulation"
        '
        'Guna2HtmlLabel17
        '
        Me.Guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel17.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel17.Location = New System.Drawing.Point(29, 257)
        Me.Guna2HtmlLabel17.Name = "Guna2HtmlLabel17"
        Me.Guna2HtmlLabel17.Size = New System.Drawing.Size(140, 41)
        Me.Guna2HtmlLabel17.TabIndex = 6
        Me.Guna2HtmlLabel17.Text = "Luteal Phase"
        '
        'Guna2HtmlLabel18
        '
        Me.Guna2HtmlLabel18.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel18.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel18.Location = New System.Drawing.Point(40, 42)
        Me.Guna2HtmlLabel18.Name = "Guna2HtmlLabel18"
        Me.Guna2HtmlLabel18.Size = New System.Drawing.Size(166, 41)
        Me.Guna2HtmlLabel18.TabIndex = 3
        Me.Guna2HtmlLabel18.Text = "Period Tracker"
        '
        'Guna2HtmlLabel19
        '
        Me.Guna2HtmlLabel19.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel19.Font = New System.Drawing.Font("Sitka Banner", 35.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel19.Location = New System.Drawing.Point(97, 362)
        Me.Guna2HtmlLabel19.Name = "Guna2HtmlLabel19"
        Me.Guna2HtmlLabel19.Size = New System.Drawing.Size(265, 70)
        Me.Guna2HtmlLabel19.TabIndex = 3
        Me.Guna2HtmlLabel19.Text = "Menstruation"
        '
        'Timer1
        '
        '
        'Guna2HtmlLabel20
        '
        Me.Guna2HtmlLabel20.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel20.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel20.Location = New System.Drawing.Point(404, 30)
        Me.Guna2HtmlLabel20.Name = "Guna2HtmlLabel20"
        Me.Guna2HtmlLabel20.Size = New System.Drawing.Size(153, 41)
        Me.Guna2HtmlLabel20.TabIndex = 7
        Me.Guna2HtmlLabel20.Text = "Current Time"
        '
        'Dashboard
        '
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.BACKGROUND)
        Me.Controls.Add(Me.DASHBOARD_TOP_PANEL)
        Me.Name = "Dashboard"
        Me.DASHBOARD_TOP_PANEL.ResumeLayout(False)
        Me.BACKGROUND.ResumeLayout(False)
        Me.PERIOD_PANEL.ResumeLayout(False)
        Me.PERIOD_PANEL.PerformLayout()
        Me.PHASE_PANEL.ResumeLayout(False)
        Me.PHASE_PANEL.PerformLayout()
        Me.FERTILITY_PAMEL.ResumeLayout(False)
        Me.FERTILITY_PAMEL.PerformLayout()
        Me.ADVICE_PANEL.ResumeLayout(False)
        Me.ADVICE_PANEL.PerformLayout()
        Me.OTHERS_PANEL.ResumeLayout(False)
        Me.OTHERS_PANEL.PerformLayout()
        Me.PERIOD_TRACKER_PANEL.ResumeLayout(False)
        Me.PERIOD_TRACKER_PANEL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2ShapesTool1 As Guna.UI2.WinForms.Guna2ShapesTool
    Friend WithEvents DASHBOARD_TOP_PANEL As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents EDIT_PROFILE_PANEL As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BACKGROUND As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents ADVICE_PANEL As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FERTILITY_PAMEL As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PHASE_PANEL As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PERIOD_PANEL As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PERIOD_TRACKER_PANEL As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents OTHERS_PANEL As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel12 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2HtmlLabel13 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel18 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel17 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel16 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel15 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel14 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel19 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2HtmlLabel20 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
