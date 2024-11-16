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
        Me.Guna2ShapesTool1 = New Guna.UI2.WinForms.Guna2ShapesTool(Me.components)
        Me.pnl_dashboard = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnl_editprof = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnl_dashboardbg = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.pnl_tracker = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_periodtracker = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_others = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_luteal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_ovulation = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_follicular = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_menstruation = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_currenttime = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_dailydigest = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_dailydigest = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_fertility = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_prediction = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_fertilityphase = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_fertility = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_phase = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_phasesub = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_phaseheader = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_phaseday = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_phasedayno = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_phase = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_period = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_periodtitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_periodday = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_period = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_displaycurrenttime = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.picb_profile = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lbl_greet = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_menstruation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_follicular = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_ovulation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_luteal = New Guna.UI2.WinForms.Guna2TextBox()
        Me.linklbl_details = New System.Windows.Forms.LinkLabel()
        Me.txt_trackercolumn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_column1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_column2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_column3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_column4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_column5 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_column6 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_addnew = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_dashboard.SuspendLayout()
        Me.pnl_editprof.SuspendLayout()
        Me.pnl_dashboardbg.SuspendLayout()
        Me.pnl_tracker.SuspendLayout()
        Me.pnl_others.SuspendLayout()
        Me.pnl_dailydigest.SuspendLayout()
        Me.pnl_fertility.SuspendLayout()
        Me.pnl_phase.SuspendLayout()
        Me.pnl_period.SuspendLayout()
        CType(Me.picb_profile, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'pnl_dashboard
        '
        Me.pnl_dashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.pnl_dashboard.Controls.Add(Me.pnl_editprof)
        Me.pnl_dashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_dashboard.Location = New System.Drawing.Point(0, 0)
        Me.pnl_dashboard.Name = "pnl_dashboard"
        Me.pnl_dashboard.Size = New System.Drawing.Size(1904, 170)
        Me.pnl_dashboard.TabIndex = 0
        '
        'pnl_editprof
        '
        Me.pnl_editprof.AutoRoundedCorners = True
        Me.pnl_editprof.AutoSize = True
        Me.pnl_editprof.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.pnl_editprof.BorderRadius = 49
        Me.pnl_editprof.Controls.Add(Me.lbl_greet)
        Me.pnl_editprof.Controls.Add(Me.picb_profile)
        Me.pnl_editprof.Location = New System.Drawing.Point(1509, 31)
        Me.pnl_editprof.Name = "pnl_editprof"
        Me.pnl_editprof.Size = New System.Drawing.Size(371, 101)
        Me.pnl_editprof.TabIndex = 0
        '
        'pnl_dashboardbg
        '
        Me.pnl_dashboardbg.Controls.Add(Me.pnl_tracker)
        Me.pnl_dashboardbg.Controls.Add(Me.pnl_others)
        Me.pnl_dashboardbg.Controls.Add(Me.pnl_dailydigest)
        Me.pnl_dashboardbg.Controls.Add(Me.pnl_fertility)
        Me.pnl_dashboardbg.Controls.Add(Me.pnl_phase)
        Me.pnl_dashboardbg.Controls.Add(Me.pnl_period)
        Me.pnl_dashboardbg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_dashboardbg.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnl_dashboardbg.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.pnl_dashboardbg.Location = New System.Drawing.Point(0, 170)
        Me.pnl_dashboardbg.Name = "pnl_dashboardbg"
        Me.pnl_dashboardbg.Size = New System.Drawing.Size(1904, 871)
        Me.pnl_dashboardbg.TabIndex = 2
        '
        'pnl_tracker
        '
        Me.pnl_tracker.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnl_tracker.Controls.Add(Me.btn_addnew)
        Me.pnl_tracker.Controls.Add(Me.txt_column6)
        Me.pnl_tracker.Controls.Add(Me.txt_column5)
        Me.pnl_tracker.Controls.Add(Me.txt_column4)
        Me.pnl_tracker.Controls.Add(Me.txt_column3)
        Me.pnl_tracker.Controls.Add(Me.txt_column2)
        Me.pnl_tracker.Controls.Add(Me.txt_column1)
        Me.pnl_tracker.Controls.Add(Me.txt_trackercolumn)
        Me.pnl_tracker.Controls.Add(Me.lbl_periodtracker)
        Me.pnl_tracker.Location = New System.Drawing.Point(751, 516)
        Me.pnl_tracker.Name = "pnl_tracker"
        Me.pnl_tracker.Size = New System.Drawing.Size(1129, 343)
        Me.pnl_tracker.TabIndex = 5
        '
        'lbl_periodtracker
        '
        Me.lbl_periodtracker.BackColor = System.Drawing.Color.Transparent
        Me.lbl_periodtracker.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_periodtracker.Location = New System.Drawing.Point(27, 10)
        Me.lbl_periodtracker.Name = "lbl_periodtracker"
        Me.lbl_periodtracker.Size = New System.Drawing.Size(166, 41)
        Me.lbl_periodtracker.TabIndex = 3
        Me.lbl_periodtracker.Text = "Period Tracker"
        '
        'pnl_others
        '
        Me.pnl_others.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnl_others.Controls.Add(Me.txt_luteal)
        Me.pnl_others.Controls.Add(Me.txt_ovulation)
        Me.pnl_others.Controls.Add(Me.txt_follicular)
        Me.pnl_others.Controls.Add(Me.txt_menstruation)
        Me.pnl_others.Controls.Add(Me.lbl_displaycurrenttime)
        Me.pnl_others.Controls.Add(Me.lbl_luteal)
        Me.pnl_others.Controls.Add(Me.lbl_ovulation)
        Me.pnl_others.Controls.Add(Me.lbl_follicular)
        Me.pnl_others.Controls.Add(Me.lbl_menstruation)
        Me.pnl_others.Controls.Add(Me.lbl_currenttime)
        Me.pnl_others.Location = New System.Drawing.Point(29, 516)
        Me.pnl_others.Name = "pnl_others"
        Me.pnl_others.Size = New System.Drawing.Size(701, 343)
        Me.pnl_others.TabIndex = 4
        '
        'lbl_luteal
        '
        Me.lbl_luteal.BackColor = System.Drawing.Color.Transparent
        Me.lbl_luteal.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_luteal.Location = New System.Drawing.Point(29, 262)
        Me.lbl_luteal.Name = "lbl_luteal"
        Me.lbl_luteal.Size = New System.Drawing.Size(140, 41)
        Me.lbl_luteal.TabIndex = 6
        Me.lbl_luteal.Text = "Luteal Phase"
        '
        'lbl_ovulation
        '
        Me.lbl_ovulation.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ovulation.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ovulation.Location = New System.Drawing.Point(29, 215)
        Me.lbl_ovulation.Name = "lbl_ovulation"
        Me.lbl_ovulation.Size = New System.Drawing.Size(110, 41)
        Me.lbl_ovulation.TabIndex = 5
        Me.lbl_ovulation.Text = "Ovulation"
        '
        'lbl_follicular
        '
        Me.lbl_follicular.BackColor = System.Drawing.Color.Transparent
        Me.lbl_follicular.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_follicular.Location = New System.Drawing.Point(29, 168)
        Me.lbl_follicular.Name = "lbl_follicular"
        Me.lbl_follicular.Size = New System.Drawing.Size(175, 41)
        Me.lbl_follicular.TabIndex = 4
        Me.lbl_follicular.Text = "Follicular Phase"
        '
        'lbl_menstruation
        '
        Me.lbl_menstruation.BackColor = System.Drawing.Color.Transparent
        Me.lbl_menstruation.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_menstruation.Location = New System.Drawing.Point(29, 116)
        Me.lbl_menstruation.Name = "lbl_menstruation"
        Me.lbl_menstruation.Size = New System.Drawing.Size(153, 41)
        Me.lbl_menstruation.TabIndex = 3
        Me.lbl_menstruation.Text = "Menstruation"
        '
        'lbl_currenttime
        '
        Me.lbl_currenttime.BackColor = System.Drawing.Color.Transparent
        Me.lbl_currenttime.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_currenttime.Location = New System.Drawing.Point(29, 30)
        Me.lbl_currenttime.Name = "lbl_currenttime"
        Me.lbl_currenttime.Size = New System.Drawing.Size(153, 41)
        Me.lbl_currenttime.TabIndex = 2
        Me.lbl_currenttime.Text = "Current Time"
        '
        'pnl_dailydigest
        '
        Me.pnl_dailydigest.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnl_dailydigest.Controls.Add(Me.linklbl_details)
        Me.pnl_dailydigest.Controls.Add(Me.lbl_dailydigest)
        Me.pnl_dailydigest.Location = New System.Drawing.Point(1430, 21)
        Me.pnl_dailydigest.Name = "pnl_dailydigest"
        Me.pnl_dailydigest.Size = New System.Drawing.Size(450, 450)
        Me.pnl_dailydigest.TabIndex = 3
        '
        'lbl_dailydigest
        '
        Me.lbl_dailydigest.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dailydigest.Font = New System.Drawing.Font("Sitka Banner", 50.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_dailydigest.Location = New System.Drawing.Point(62, 130)
        Me.lbl_dailydigest.Name = "lbl_dailydigest"
        Me.lbl_dailydigest.Size = New System.Drawing.Size(330, 99)
        Me.lbl_dailydigest.TabIndex = 1
        Me.lbl_dailydigest.Text = "Daily Digest"
        Me.lbl_dailydigest.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'pnl_fertility
        '
        Me.pnl_fertility.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnl_fertility.Controls.Add(Me.lbl_prediction)
        Me.pnl_fertility.Controls.Add(Me.lbl_fertilityphase)
        Me.pnl_fertility.Controls.Add(Me.lbl_fertility)
        Me.pnl_fertility.Location = New System.Drawing.Point(961, 21)
        Me.pnl_fertility.Name = "pnl_fertility"
        Me.pnl_fertility.Size = New System.Drawing.Size(450, 450)
        Me.pnl_fertility.TabIndex = 2
        '
        'lbl_prediction
        '
        Me.lbl_prediction.BackColor = System.Drawing.Color.Transparent
        Me.lbl_prediction.Font = New System.Drawing.Font("Sitka Banner", 27.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_prediction.Location = New System.Drawing.Point(50, 343)
        Me.lbl_prediction.Name = "lbl_prediction"
        Me.lbl_prediction.Size = New System.Drawing.Size(358, 54)
        Me.lbl_prediction.TabIndex = 3
        Me.lbl_prediction.Text = "No Chance" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " of Pregnancy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_fertilityphase
        '
        Me.lbl_fertilityphase.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fertilityphase.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_fertilityphase.Location = New System.Drawing.Point(145, 89)
        Me.lbl_fertilityphase.Name = "lbl_fertilityphase"
        Me.lbl_fertilityphase.Size = New System.Drawing.Size(168, 31)
        Me.lbl_fertilityphase.TabIndex = 2
        Me.lbl_fertilityphase.Text = "Menstruation Phase"
        '
        'lbl_fertility
        '
        Me.lbl_fertility.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fertility.Font = New System.Drawing.Font("Sitka Banner", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_fertility.Location = New System.Drawing.Point(111, 42)
        Me.lbl_fertility.Name = "lbl_fertility"
        Me.lbl_fertility.Size = New System.Drawing.Size(233, 50)
        Me.lbl_fertility.TabIndex = 1
        Me.lbl_fertility.Text = "Fertility Watcher"
        '
        'pnl_phase
        '
        Me.pnl_phase.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnl_phase.Controls.Add(Me.lbl_phasesub)
        Me.pnl_phase.Controls.Add(Me.lbl_phaseheader)
        Me.pnl_phase.Controls.Add(Me.lbl_phaseday)
        Me.pnl_phase.Controls.Add(Me.lbl_phasedayno)
        Me.pnl_phase.Controls.Add(Me.lbl_phase)
        Me.pnl_phase.Location = New System.Drawing.Point(494, 21)
        Me.pnl_phase.Name = "pnl_phase"
        Me.pnl_phase.Size = New System.Drawing.Size(450, 450)
        Me.pnl_phase.TabIndex = 1
        '
        'lbl_phasesub
        '
        Me.lbl_phasesub.BackColor = System.Drawing.Color.Transparent
        Me.lbl_phasesub.Font = New System.Drawing.Font("Sitka Banner", 35.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_phasesub.Location = New System.Drawing.Point(97, 362)
        Me.lbl_phasesub.Name = "lbl_phasesub"
        Me.lbl_phasesub.Size = New System.Drawing.Size(265, 70)
        Me.lbl_phasesub.TabIndex = 3
        Me.lbl_phasesub.Text = "Menstruation"
        '
        'lbl_phaseheader
        '
        Me.lbl_phaseheader.BackColor = System.Drawing.Color.Transparent
        Me.lbl_phaseheader.Font = New System.Drawing.Font("Sitka Banner", 27.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_phaseheader.Location = New System.Drawing.Point(134, 311)
        Me.lbl_phaseheader.Name = "lbl_phaseheader"
        Me.lbl_phaseheader.Size = New System.Drawing.Size(192, 54)
        Me.lbl_phaseheader.TabIndex = 4
        Me.lbl_phaseheader.Text = "Currently on"
        '
        'lbl_phaseday
        '
        Me.lbl_phaseday.BackColor = System.Drawing.Color.Transparent
        Me.lbl_phaseday.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_phaseday.Location = New System.Drawing.Point(297, 274)
        Me.lbl_phaseday.Name = "lbl_phaseday"
        Me.lbl_phaseday.Size = New System.Drawing.Size(55, 41)
        Me.lbl_phaseday.TabIndex = 3
        Me.lbl_phaseday.Text = "Days"
        '
        'lbl_phasedayno
        '
        Me.lbl_phasedayno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_phasedayno.Font = New System.Drawing.Font("Lucida Fax", 131.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phasedayno.Location = New System.Drawing.Point(117, 104)
        Me.lbl_phasedayno.Name = "lbl_phasedayno"
        Me.lbl_phasedayno.Size = New System.Drawing.Size(235, 201)
        Me.lbl_phasedayno.TabIndex = 2
        Me.lbl_phasedayno.Text = "14"
        '
        'lbl_phase
        '
        Me.lbl_phase.BackColor = System.Drawing.Color.Transparent
        Me.lbl_phase.Font = New System.Drawing.Font("Sitka Banner", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_phase.Location = New System.Drawing.Point(124, 42)
        Me.lbl_phase.Name = "lbl_phase"
        Me.lbl_phase.Size = New System.Drawing.Size(208, 50)
        Me.lbl_phase.TabIndex = 1
        Me.lbl_phase.Text = "Phase Tracking"
        '
        'pnl_period
        '
        Me.pnl_period.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.pnl_period.Controls.Add(Me.lbl_periodtitle)
        Me.pnl_period.Controls.Add(Me.lbl_periodday)
        Me.pnl_period.Controls.Add(Me.lbl_period)
        Me.pnl_period.Location = New System.Drawing.Point(29, 21)
        Me.pnl_period.Name = "pnl_period"
        Me.pnl_period.Size = New System.Drawing.Size(450, 450)
        Me.pnl_period.TabIndex = 0
        '
        'lbl_periodtitle
        '
        Me.lbl_periodtitle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_periodtitle.Font = New System.Drawing.Font("Sitka Banner", 27.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_periodtitle.Location = New System.Drawing.Point(105, 343)
        Me.lbl_periodtitle.Name = "lbl_periodtitle"
        Me.lbl_periodtitle.Size = New System.Drawing.Size(241, 54)
        Me.lbl_periodtitle.TabIndex = 2
        Me.lbl_periodtitle.Text = "of Menstruation"
        '
        'lbl_periodday
        '
        Me.lbl_periodday.BackColor = System.Drawing.Color.Transparent
        Me.lbl_periodday.Font = New System.Drawing.Font("Lucida Fax", 90.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_periodday.Location = New System.Drawing.Point(42, 150)
        Me.lbl_periodday.Name = "lbl_periodday"
        Me.lbl_periodday.Size = New System.Drawing.Size(366, 139)
        Me.lbl_periodday.TabIndex = 1
        Me.lbl_periodday.Text = "Day 1"
        '
        'lbl_period
        '
        Me.lbl_period.BackColor = System.Drawing.Color.Transparent
        Me.lbl_period.Font = New System.Drawing.Font("Sitka Banner", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_period.Location = New System.Drawing.Point(115, 42)
        Me.lbl_period.Name = "lbl_period"
        Me.lbl_period.Size = New System.Drawing.Size(217, 50)
        Me.lbl_period.TabIndex = 0
        Me.lbl_period.Text = "Period Tracking"
        '
        'Timer1
        '
        '
        'lbl_displaycurrenttime
        '
        Me.lbl_displaycurrenttime.BackColor = System.Drawing.Color.Transparent
        Me.lbl_displaycurrenttime.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_displaycurrenttime.Location = New System.Drawing.Point(417, 30)
        Me.lbl_displaycurrenttime.Name = "lbl_displaycurrenttime"
        Me.lbl_displaycurrenttime.Size = New System.Drawing.Size(153, 41)
        Me.lbl_displaycurrenttime.TabIndex = 7
        Me.lbl_displaycurrenttime.Text = "Current Time"
        '
        'picb_profile
        '
        Me.picb_profile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picb_profile.ImageRotate = 0!
        Me.picb_profile.Location = New System.Drawing.Point(264, 10)
        Me.picb_profile.Name = "picb_profile"
        Me.picb_profile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.picb_profile.Size = New System.Drawing.Size(83, 81)
        Me.picb_profile.TabIndex = 1
        Me.picb_profile.TabStop = False
        '
        'lbl_greet
        '
        Me.lbl_greet.BackColor = System.Drawing.Color.Transparent
        Me.lbl_greet.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_greet.Location = New System.Drawing.Point(28, 30)
        Me.lbl_greet.Name = "lbl_greet"
        Me.lbl_greet.Size = New System.Drawing.Size(209, 37)
        Me.lbl_greet.TabIndex = 4
        Me.lbl_greet.Text = "Good Evening! Danel"
        '
        'txt_menstruation
        '
        Me.txt_menstruation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_menstruation.DefaultText = ""
        Me.txt_menstruation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_menstruation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_menstruation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_menstruation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_menstruation.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_menstruation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_menstruation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_menstruation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_menstruation.Location = New System.Drawing.Point(306, 121)
        Me.txt_menstruation.Name = "txt_menstruation"
        Me.txt_menstruation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_menstruation.PlaceholderText = ""
        Me.txt_menstruation.SelectedText = ""
        Me.txt_menstruation.Size = New System.Drawing.Size(369, 36)
        Me.txt_menstruation.TabIndex = 8
        '
        'txt_follicular
        '
        Me.txt_follicular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_follicular.DefaultText = ""
        Me.txt_follicular.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_follicular.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_follicular.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_follicular.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_follicular.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_follicular.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_follicular.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_follicular.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_follicular.Location = New System.Drawing.Point(306, 173)
        Me.txt_follicular.Name = "txt_follicular"
        Me.txt_follicular.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_follicular.PlaceholderText = ""
        Me.txt_follicular.SelectedText = ""
        Me.txt_follicular.Size = New System.Drawing.Size(369, 36)
        Me.txt_follicular.TabIndex = 9
        '
        'txt_ovulation
        '
        Me.txt_ovulation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_ovulation.DefaultText = ""
        Me.txt_ovulation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_ovulation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_ovulation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ovulation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_ovulation.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_ovulation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ovulation.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_ovulation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ovulation.Location = New System.Drawing.Point(306, 220)
        Me.txt_ovulation.Name = "txt_ovulation"
        Me.txt_ovulation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_ovulation.PlaceholderText = ""
        Me.txt_ovulation.SelectedText = ""
        Me.txt_ovulation.Size = New System.Drawing.Size(369, 36)
        Me.txt_ovulation.TabIndex = 10
        '
        'txt_luteal
        '
        Me.txt_luteal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_luteal.DefaultText = ""
        Me.txt_luteal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_luteal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_luteal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_luteal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_luteal.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_luteal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_luteal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_luteal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_luteal.Location = New System.Drawing.Point(306, 267)
        Me.txt_luteal.Name = "txt_luteal"
        Me.txt_luteal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_luteal.PlaceholderText = ""
        Me.txt_luteal.SelectedText = ""
        Me.txt_luteal.Size = New System.Drawing.Size(369, 36)
        Me.txt_luteal.TabIndex = 11
        '
        'linklbl_details
        '
        Me.linklbl_details.AutoSize = True
        Me.linklbl_details.Font = New System.Drawing.Font("Sitka Text", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linklbl_details.LinkColor = System.Drawing.Color.Black
        Me.linklbl_details.Location = New System.Drawing.Point(167, 235)
        Me.linklbl_details.Name = "linklbl_details"
        Me.linklbl_details.Size = New System.Drawing.Size(132, 39)
        Me.linklbl_details.TabIndex = 2
        Me.linklbl_details.TabStop = True
        Me.linklbl_details.Text = "Details >"
        '
        'txt_trackercolumn
        '
        Me.txt_trackercolumn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_trackercolumn.DefaultText = ""
        Me.txt_trackercolumn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_trackercolumn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_trackercolumn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_trackercolumn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_trackercolumn.FillColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txt_trackercolumn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_trackercolumn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_trackercolumn.ForeColor = System.Drawing.Color.Gray
        Me.txt_trackercolumn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_trackercolumn.Location = New System.Drawing.Point(27, 61)
        Me.txt_trackercolumn.Name = "txt_trackercolumn"
        Me.txt_trackercolumn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_trackercolumn.PlaceholderText = ""
        Me.txt_trackercolumn.SelectedText = ""
        Me.txt_trackercolumn.Size = New System.Drawing.Size(1071, 36)
        Me.txt_trackercolumn.TabIndex = 12
        '
        'txt_column1
        '
        Me.txt_column1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_column1.DefaultText = ""
        Me.txt_column1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_column1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_column1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_column1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_column1.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_column1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_column1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_column1.ForeColor = System.Drawing.Color.Gray
        Me.txt_column1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_column1.Location = New System.Drawing.Point(27, 96)
        Me.txt_column1.Name = "txt_column1"
        Me.txt_column1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_column1.PlaceholderText = ""
        Me.txt_column1.SelectedText = ""
        Me.txt_column1.Size = New System.Drawing.Size(1071, 36)
        Me.txt_column1.TabIndex = 13
        '
        'txt_column2
        '
        Me.txt_column2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_column2.DefaultText = ""
        Me.txt_column2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_column2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_column2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_column2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_column2.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_column2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_column2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_column2.ForeColor = System.Drawing.Color.Gray
        Me.txt_column2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_column2.Location = New System.Drawing.Point(27, 132)
        Me.txt_column2.Name = "txt_column2"
        Me.txt_column2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_column2.PlaceholderText = ""
        Me.txt_column2.SelectedText = ""
        Me.txt_column2.Size = New System.Drawing.Size(1071, 36)
        Me.txt_column2.TabIndex = 14
        '
        'txt_column3
        '
        Me.txt_column3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_column3.DefaultText = ""
        Me.txt_column3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_column3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_column3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_column3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_column3.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_column3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_column3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_column3.ForeColor = System.Drawing.Color.Gray
        Me.txt_column3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_column3.Location = New System.Drawing.Point(27, 168)
        Me.txt_column3.Name = "txt_column3"
        Me.txt_column3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_column3.PlaceholderText = ""
        Me.txt_column3.SelectedText = ""
        Me.txt_column3.Size = New System.Drawing.Size(1071, 36)
        Me.txt_column3.TabIndex = 15
        '
        'txt_column4
        '
        Me.txt_column4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_column4.DefaultText = ""
        Me.txt_column4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_column4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_column4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_column4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_column4.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_column4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_column4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_column4.ForeColor = System.Drawing.Color.Gray
        Me.txt_column4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_column4.Location = New System.Drawing.Point(27, 204)
        Me.txt_column4.Name = "txt_column4"
        Me.txt_column4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_column4.PlaceholderText = ""
        Me.txt_column4.SelectedText = ""
        Me.txt_column4.Size = New System.Drawing.Size(1071, 36)
        Me.txt_column4.TabIndex = 16
        '
        'txt_column5
        '
        Me.txt_column5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_column5.DefaultText = ""
        Me.txt_column5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_column5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_column5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_column5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_column5.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_column5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_column5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_column5.ForeColor = System.Drawing.Color.Gray
        Me.txt_column5.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_column5.Location = New System.Drawing.Point(27, 240)
        Me.txt_column5.Name = "txt_column5"
        Me.txt_column5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_column5.PlaceholderText = ""
        Me.txt_column5.SelectedText = ""
        Me.txt_column5.Size = New System.Drawing.Size(1071, 36)
        Me.txt_column5.TabIndex = 17
        '
        'txt_column6
        '
        Me.txt_column6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_column6.DefaultText = ""
        Me.txt_column6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_column6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_column6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_column6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_column6.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_column6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_column6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_column6.ForeColor = System.Drawing.Color.Gray
        Me.txt_column6.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_column6.Location = New System.Drawing.Point(27, 276)
        Me.txt_column6.Name = "txt_column6"
        Me.txt_column6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_column6.PlaceholderText = ""
        Me.txt_column6.SelectedText = ""
        Me.txt_column6.Size = New System.Drawing.Size(1071, 36)
        Me.txt_column6.TabIndex = 18
        '
        'btn_addnew
        '
        Me.btn_addnew.BorderRadius = 6
        Me.btn_addnew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_addnew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_addnew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_addnew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_addnew.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_addnew.Font = New System.Drawing.Font("Sitka Text", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addnew.ForeColor = System.Drawing.Color.White
        Me.btn_addnew.Location = New System.Drawing.Point(240, 12)
        Me.btn_addnew.Name = "btn_addnew"
        Me.btn_addnew.Size = New System.Drawing.Size(204, 40)
        Me.btn_addnew.TabIndex = 19
        Me.btn_addnew.Text = "Add New Record"
        '
        'Dashboard
        '
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.pnl_dashboardbg)
        Me.Controls.Add(Me.pnl_dashboard)
        Me.Name = "Dashboard"
        Me.pnl_dashboard.ResumeLayout(False)
        Me.pnl_dashboard.PerformLayout()
        Me.pnl_editprof.ResumeLayout(False)
        Me.pnl_editprof.PerformLayout()
        Me.pnl_dashboardbg.ResumeLayout(False)
        Me.pnl_tracker.ResumeLayout(False)
        Me.pnl_tracker.PerformLayout()
        Me.pnl_others.ResumeLayout(False)
        Me.pnl_others.PerformLayout()
        Me.pnl_dailydigest.ResumeLayout(False)
        Me.pnl_dailydigest.PerformLayout()
        Me.pnl_fertility.ResumeLayout(False)
        Me.pnl_fertility.PerformLayout()
        Me.pnl_phase.ResumeLayout(False)
        Me.pnl_phase.PerformLayout()
        Me.pnl_period.ResumeLayout(False)
        Me.pnl_period.PerformLayout()
        CType(Me.picb_profile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2ShapesTool1 As Guna.UI2.WinForms.Guna2ShapesTool
    Friend WithEvents pnl_dashboard As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnl_editprof As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnl_dashboardbg As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents pnl_dailydigest As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnl_fertility As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnl_phase As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnl_period As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnl_tracker As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnl_others As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_periodtitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_periodday As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_period As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_phaseday As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_phasedayno As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_phase As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_phaseheader As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_dailydigest As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_prediction As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_fertilityphase As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_fertility As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_currenttime As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_periodtracker As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_luteal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_ovulation As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_follicular As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_menstruation As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_phasesub As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_displaycurrenttime As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents picb_profile As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lbl_greet As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_menstruation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_luteal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_ovulation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_follicular As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents linklbl_details As LinkLabel
    Friend WithEvents txt_trackercolumn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_column1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_column5 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_column4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_column3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_column2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_column6 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_addnew As Guna.UI2.WinForms.Guna2Button
End Class
