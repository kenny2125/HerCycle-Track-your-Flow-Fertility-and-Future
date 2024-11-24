<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyProfile
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
        Me.btn_logout = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_close = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_tracking = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lbl_ans4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_ans3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_ans2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_ans1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_ques4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_ques3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_ques2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_ques1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dvd_myprofile = New MaterialSkin.Controls.MaterialDivider()
        Me.lbl_subheader = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_age = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_birthdate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_age = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_birthdate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_password = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_username = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_email = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_name = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_name = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_header = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_tracking.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_logout
        '
        Me.btn_logout.BorderRadius = 6
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_logout.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_logout.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.Location = New System.Drawing.Point(482, 371)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(171, 32)
        Me.btn_logout.TabIndex = 21
        Me.btn_logout.Text = "Log Out"
        '
        'btn_close
        '
        Me.btn_close.BorderRadius = 6
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_close.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_close.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.White
        Me.btn_close.Location = New System.Drawing.Point(680, 371)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(197, 32)
        Me.btn_close.TabIndex = 22
        Me.btn_close.Text = "Close Program"
        '
        'pnl_tracking
        '
        Me.pnl_tracking.BackColor = System.Drawing.Color.Transparent
        Me.pnl_tracking.Controls.Add(Me.lbl_ans4)
        Me.pnl_tracking.Controls.Add(Me.lbl_ans3)
        Me.pnl_tracking.Controls.Add(Me.lbl_ans2)
        Me.pnl_tracking.Controls.Add(Me.lbl_ans1)
        Me.pnl_tracking.Controls.Add(Me.lbl_ques4)
        Me.pnl_tracking.Controls.Add(Me.lbl_ques3)
        Me.pnl_tracking.Controls.Add(Me.lbl_ques2)
        Me.pnl_tracking.Controls.Add(Me.lbl_ques1)
        Me.pnl_tracking.Controls.Add(Me.dvd_myprofile)
        Me.pnl_tracking.Controls.Add(Me.lbl_subheader)
        Me.pnl_tracking.Controls.Add(Me.txt_age)
        Me.pnl_tracking.Controls.Add(Me.txt_birthdate)
        Me.pnl_tracking.Controls.Add(Me.lbl_age)
        Me.pnl_tracking.Controls.Add(Me.lbl_birthdate)
        Me.pnl_tracking.Controls.Add(Me.txt_password)
        Me.pnl_tracking.Controls.Add(Me.txt_username)
        Me.pnl_tracking.Controls.Add(Me.lbl_password)
        Me.pnl_tracking.Controls.Add(Me.lbl_username)
        Me.pnl_tracking.Controls.Add(Me.txt_email)
        Me.pnl_tracking.Controls.Add(Me.lbl_email)
        Me.pnl_tracking.Controls.Add(Me.txt_name)
        Me.pnl_tracking.Controls.Add(Me.btn_close)
        Me.pnl_tracking.Controls.Add(Me.lbl_name)
        Me.pnl_tracking.Controls.Add(Me.btn_logout)
        Me.pnl_tracking.Controls.Add(Me.lbl_header)
        Me.pnl_tracking.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pnl_tracking.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.pnl_tracking.Location = New System.Drawing.Point(-1, 0)
        Me.pnl_tracking.Name = "pnl_tracking"
        Me.pnl_tracking.Size = New System.Drawing.Size(951, 417)
        Me.pnl_tracking.TabIndex = 27
        '
        'lbl_ans4
        '
        Me.lbl_ans4.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ans4.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ans4.Location = New System.Drawing.Point(463, 329)
        Me.lbl_ans4.Name = "lbl_ans4"
        Me.lbl_ans4.Size = New System.Drawing.Size(24, 31)
        Me.lbl_ans4.TabIndex = 76
        Me.lbl_ans4.Text = "28"
        '
        'lbl_ans3
        '
        Me.lbl_ans3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ans3.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ans3.Location = New System.Drawing.Point(463, 255)
        Me.lbl_ans3.Name = "lbl_ans3"
        Me.lbl_ans3.Size = New System.Drawing.Size(35, 31)
        Me.lbl_ans3.TabIndex = 75
        Me.lbl_ans3.Text = "YES"
        '
        'lbl_ans2
        '
        Me.lbl_ans2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ans2.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ans2.Location = New System.Drawing.Point(463, 181)
        Me.lbl_ans2.Name = "lbl_ans2"
        Me.lbl_ans2.Size = New System.Drawing.Size(29, 31)
        Me.lbl_ans2.TabIndex = 74
        Me.lbl_ans2.Text = "NO"
        '
        'lbl_ans1
        '
        Me.lbl_ans1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ans1.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ans1.Location = New System.Drawing.Point(463, 107)
        Me.lbl_ans1.Name = "lbl_ans1"
        Me.lbl_ans1.Size = New System.Drawing.Size(35, 31)
        Me.lbl_ans1.TabIndex = 73
        Me.lbl_ans1.Text = "YES"
        '
        'lbl_ques4
        '
        Me.lbl_ques4.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ques4.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_ques4.Location = New System.Drawing.Point(454, 292)
        Me.lbl_ques4.Name = "lbl_ques4"
        Me.lbl_ques4.Size = New System.Drawing.Size(476, 31)
        Me.lbl_ques4.TabIndex = 72
        Me.lbl_ques4.Text = "What is the average length of your menstrual cycle (in days)?"
        '
        'lbl_ques3
        '
        Me.lbl_ques3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ques3.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_ques3.Location = New System.Drawing.Point(454, 218)
        Me.lbl_ques3.Name = "lbl_ques3"
        Me.lbl_ques3.Size = New System.Drawing.Size(199, 31)
        Me.lbl_ques3.TabIndex = 71
        Me.lbl_ques3.Text = "Are your periods regular?"
        '
        'lbl_ques2
        '
        Me.lbl_ques2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ques2.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_ques2.Location = New System.Drawing.Point(454, 144)
        Me.lbl_ques2.Name = "lbl_ques2"
        Me.lbl_ques2.Size = New System.Drawing.Size(220, 31)
        Me.lbl_ques2.TabIndex = 70
        Me.lbl_ques2.Text = "Are you currently pregnant?"
        '
        'lbl_ques1
        '
        Me.lbl_ques1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ques1.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_ques1.Location = New System.Drawing.Point(454, 78)
        Me.lbl_ques1.Name = "lbl_ques1"
        Me.lbl_ques1.Size = New System.Drawing.Size(337, 31)
        Me.lbl_ques1.TabIndex = 69
        Me.lbl_ques1.Text = "Are you gonna use period plus for yourself?"
        '
        'dvd_myprofile
        '
        Me.dvd_myprofile.BackColor = System.Drawing.Color.White
        Me.dvd_myprofile.Depth = 0
        Me.dvd_myprofile.Location = New System.Drawing.Point(427, 41)
        Me.dvd_myprofile.MouseState = MaterialSkin.MouseState.HOVER
        Me.dvd_myprofile.Name = "dvd_myprofile"
        Me.dvd_myprofile.Size = New System.Drawing.Size(10, 338)
        Me.dvd_myprofile.TabIndex = 68
        Me.dvd_myprofile.Text = "MaterialDivider1"
        '
        'lbl_subheader
        '
        Me.lbl_subheader.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subheader.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subheader.Location = New System.Drawing.Point(454, 41)
        Me.lbl_subheader.Name = "lbl_subheader"
        Me.lbl_subheader.Size = New System.Drawing.Size(191, 31)
        Me.lbl_subheader.TabIndex = 67
        Me.lbl_subheader.Text = "Pre Screening Answers"
        '
        'txt_age
        '
        Me.txt_age.BackColor = System.Drawing.Color.Transparent
        Me.txt_age.BorderColor = System.Drawing.Color.White
        Me.txt_age.BorderThickness = 0
        Me.txt_age.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_age.DefaultText = ""
        Me.txt_age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_age.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_age.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.txt_age.ForeColor = System.Drawing.Color.Black
        Me.txt_age.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_age.Location = New System.Drawing.Point(349, 280)
        Me.txt_age.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_age.PlaceholderText = ""
        Me.txt_age.SelectedText = ""
        Me.txt_age.Size = New System.Drawing.Size(54, 28)
        Me.txt_age.TabIndex = 66
        '
        'txt_birthdate
        '
        Me.txt_birthdate.BackColor = System.Drawing.Color.Transparent
        Me.txt_birthdate.BorderColor = System.Drawing.Color.White
        Me.txt_birthdate.BorderThickness = 0
        Me.txt_birthdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_birthdate.DefaultText = ""
        Me.txt_birthdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_birthdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_birthdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_birthdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_birthdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_birthdate.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.txt_birthdate.ForeColor = System.Drawing.Color.Black
        Me.txt_birthdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_birthdate.Location = New System.Drawing.Point(216, 280)
        Me.txt_birthdate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_birthdate.Name = "txt_birthdate"
        Me.txt_birthdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_birthdate.PlaceholderText = ""
        Me.txt_birthdate.SelectedText = ""
        Me.txt_birthdate.Size = New System.Drawing.Size(121, 28)
        Me.txt_birthdate.TabIndex = 65
        '
        'lbl_age
        '
        Me.lbl_age.BackColor = System.Drawing.Color.Transparent
        Me.lbl_age.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_age.Location = New System.Drawing.Point(361, 243)
        Me.lbl_age.Name = "lbl_age"
        Me.lbl_age.Size = New System.Drawing.Size(31, 31)
        Me.lbl_age.TabIndex = 64
        Me.lbl_age.Text = "Age"
        '
        'lbl_birthdate
        '
        Me.lbl_birthdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_birthdate.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_birthdate.Location = New System.Drawing.Point(228, 243)
        Me.lbl_birthdate.Name = "lbl_birthdate"
        Me.lbl_birthdate.Size = New System.Drawing.Size(75, 31)
        Me.lbl_birthdate.TabIndex = 63
        Me.lbl_birthdate.Text = "Birthdate"
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.Transparent
        Me.txt_password.BorderColor = System.Drawing.Color.White
        Me.txt_password.BorderThickness = 0
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.DefaultText = ""
        Me.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.txt_password.ForeColor = System.Drawing.Color.Black
        Me.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.Location = New System.Drawing.Point(18, 351)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_password.PlaceholderText = ""
        Me.txt_password.SelectedText = ""
        Me.txt_password.Size = New System.Drawing.Size(185, 28)
        Me.txt_password.TabIndex = 62
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.Transparent
        Me.txt_username.BorderColor = System.Drawing.Color.White
        Me.txt_username.BorderThickness = 0
        Me.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_username.DefaultText = ""
        Me.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.txt_username.ForeColor = System.Drawing.Color.Black
        Me.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.Location = New System.Drawing.Point(18, 280)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_username.PlaceholderText = ""
        Me.txt_username.SelectedText = ""
        Me.txt_username.Size = New System.Drawing.Size(187, 28)
        Me.txt_username.TabIndex = 61
        '
        'lbl_password
        '
        Me.lbl_password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_password.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_password.Location = New System.Drawing.Point(20, 314)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(76, 31)
        Me.lbl_password.TabIndex = 60
        Me.lbl_password.Text = "Password"
        '
        'lbl_username
        '
        Me.lbl_username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_username.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_username.Location = New System.Drawing.Point(17, 243)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(79, 31)
        Me.lbl_username.TabIndex = 59
        Me.lbl_username.Text = "Username"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.Transparent
        Me.txt_email.BorderColor = System.Drawing.Color.White
        Me.txt_email.BorderThickness = 0
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.DefaultText = ""
        Me.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.txt_email.ForeColor = System.Drawing.Color.Black
        Me.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email.Location = New System.Drawing.Point(18, 209)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.PlaceholderText = ""
        Me.txt_email.SelectedText = ""
        Me.txt_email.Size = New System.Drawing.Size(385, 28)
        Me.txt_email.TabIndex = 58
        '
        'lbl_email
        '
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_email.Location = New System.Drawing.Point(18, 172)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(113, 31)
        Me.lbl_email.TabIndex = 57
        Me.lbl_email.Text = "Email Address"
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.Color.Transparent
        Me.txt_name.BorderColor = System.Drawing.Color.White
        Me.txt_name.BorderThickness = 0
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_name.DefaultText = ""
        Me.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_name.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.txt_name.ForeColor = System.Drawing.Color.Black
        Me.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_name.Location = New System.Drawing.Point(17, 138)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_name.PlaceholderText = ""
        Me.txt_name.SelectedText = ""
        Me.txt_name.Size = New System.Drawing.Size(386, 28)
        Me.txt_name.TabIndex = 56
        '
        'lbl_name
        '
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_name.Location = New System.Drawing.Point(18, 101)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(48, 31)
        Me.lbl_name.TabIndex = 55
        Me.lbl_name.Text = "Name"
        '
        'lbl_header
        '
        Me.lbl_header.BackColor = System.Drawing.Color.Transparent
        Me.lbl_header.Font = New System.Drawing.Font("Sitka Banner", 50.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_header.Location = New System.Drawing.Point(18, 3)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(285, 99)
        Me.lbl_header.TabIndex = 51
        Me.lbl_header.Text = "My Profile"
        Me.lbl_header.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'MyProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 415)
        Me.Controls.Add(Me.pnl_tracking)
        Me.Name = "MyProfile"
        Me.Text = "MyProfile"
        Me.pnl_tracking.ResumeLayout(False)
        Me.pnl_tracking.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_logout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnl_tracking As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lbl_header As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_name As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_name As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_birthdate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_password As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_username As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_email As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_age As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_birthdate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_age As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_subheader As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_ques4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_ques3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_ques2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_ques1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dvd_myprofile As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents lbl_ans1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_ans4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_ans3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_ans2 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
