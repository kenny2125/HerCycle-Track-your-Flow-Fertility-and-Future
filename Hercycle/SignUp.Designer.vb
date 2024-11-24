<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp
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
        Me.lbl_surname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_signup = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_agevalue = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_signup = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_cnfirmpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_cnfirmpassword = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_password = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_username = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dvd_signup = New MaterialSkin.Controls.MaterialDivider()
        Me.datetmpick_birthdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lbl_birthdate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_age = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_email = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_email = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_middleint = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_middleint = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_givenname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_givenname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_surname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.linklbl_login = New System.Windows.Forms.LinkLabel()
        Me.lbl_question = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_header = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2ToggleSwitch1 = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.Guna2ToggleSwitch2 = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.pnl_signup.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_surname
        '
        Me.lbl_surname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_surname.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_surname.Location = New System.Drawing.Point(114, 189)
        Me.lbl_surname.Name = "lbl_surname"
        Me.lbl_surname.Size = New System.Drawing.Size(87, 37)
        Me.lbl_surname.TabIndex = 25
        Me.lbl_surname.Text = "Surname"
        '
        'pnl_signup
        '
        Me.pnl_signup.Controls.Add(Me.Guna2ToggleSwitch2)
        Me.pnl_signup.Controls.Add(Me.Guna2ToggleSwitch1)
        Me.pnl_signup.Controls.Add(Me.Guna2PictureBox1)
        Me.pnl_signup.Controls.Add(Me.lbl_agevalue)
        Me.pnl_signup.Controls.Add(Me.btn_signup)
        Me.pnl_signup.Controls.Add(Me.txt_cnfirmpassword)
        Me.pnl_signup.Controls.Add(Me.txt_password)
        Me.pnl_signup.Controls.Add(Me.lbl_cnfirmpassword)
        Me.pnl_signup.Controls.Add(Me.lbl_password)
        Me.pnl_signup.Controls.Add(Me.txt_username)
        Me.pnl_signup.Controls.Add(Me.lbl_username)
        Me.pnl_signup.Controls.Add(Me.dvd_signup)
        Me.pnl_signup.Controls.Add(Me.datetmpick_birthdate)
        Me.pnl_signup.Controls.Add(Me.lbl_birthdate)
        Me.pnl_signup.Controls.Add(Me.lbl_age)
        Me.pnl_signup.Controls.Add(Me.txt_email)
        Me.pnl_signup.Controls.Add(Me.lbl_email)
        Me.pnl_signup.Controls.Add(Me.lbl_middleint)
        Me.pnl_signup.Controls.Add(Me.txt_middleint)
        Me.pnl_signup.Controls.Add(Me.txt_givenname)
        Me.pnl_signup.Controls.Add(Me.lbl_givenname)
        Me.pnl_signup.Controls.Add(Me.txt_surname)
        Me.pnl_signup.Controls.Add(Me.linklbl_login)
        Me.pnl_signup.Controls.Add(Me.lbl_question)
        Me.pnl_signup.Controls.Add(Me.lbl_header)
        Me.pnl_signup.Controls.Add(Me.lbl_surname)
        Me.pnl_signup.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.pnl_signup.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.pnl_signup.Location = New System.Drawing.Point(0, -1)
        Me.pnl_signup.Name = "pnl_signup"
        Me.pnl_signup.Size = New System.Drawing.Size(1731, 698)
        Me.pnl_signup.TabIndex = 49
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.Hercycle.My.Resources.Resources.femme_flow__1_
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(1270, 26)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(300, 200)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 73
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'lbl_agevalue
        '
        Me.lbl_agevalue.BackColor = System.Drawing.Color.Transparent
        Me.lbl_agevalue.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_agevalue.Location = New System.Drawing.Point(1013, 384)
        Me.lbl_agevalue.Name = "lbl_agevalue"
        Me.lbl_agevalue.Size = New System.Drawing.Size(37, 37)
        Me.lbl_agevalue.TabIndex = 72
        Me.lbl_agevalue.Text = "Age"
        '
        'btn_signup
        '
        Me.btn_signup.AutoRoundedCorners = True
        Me.btn_signup.BackColor = System.Drawing.Color.Transparent
        Me.btn_signup.BorderRadius = 31
        Me.btn_signup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_signup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_signup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_signup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_signup.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_signup.Font = New System.Drawing.Font("Sylfaen", 23.0!, System.Drawing.FontStyle.Bold)
        Me.btn_signup.ForeColor = System.Drawing.Color.White
        Me.btn_signup.Location = New System.Drawing.Point(1297, 594)
        Me.btn_signup.Name = "btn_signup"
        Me.btn_signup.Size = New System.Drawing.Size(238, 65)
        Me.btn_signup.TabIndex = 71
        Me.btn_signup.Text = "Sign Up"
        '
        'txt_cnfirmpassword
        '
        Me.txt_cnfirmpassword.BackColor = System.Drawing.Color.Transparent
        Me.txt_cnfirmpassword.BorderRadius = 10
        Me.txt_cnfirmpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cnfirmpassword.DefaultText = ""
        Me.txt_cnfirmpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_cnfirmpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_cnfirmpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cnfirmpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_cnfirmpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cnfirmpassword.Font = New System.Drawing.Font("Sitka Banner", 18.0!)
        Me.txt_cnfirmpassword.ForeColor = System.Drawing.Color.Black
        Me.txt_cnfirmpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_cnfirmpassword.Location = New System.Drawing.Point(1204, 498)
        Me.txt_cnfirmpassword.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txt_cnfirmpassword.Name = "txt_cnfirmpassword"
        Me.txt_cnfirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_cnfirmpassword.PlaceholderText = ""
        Me.txt_cnfirmpassword.SelectedText = ""
        Me.txt_cnfirmpassword.Size = New System.Drawing.Size(415, 74)
        Me.txt_cnfirmpassword.TabIndex = 70
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.Transparent
        Me.txt_password.BorderRadius = 10
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.DefaultText = ""
        Me.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.Font = New System.Drawing.Font("Sitka Banner", 18.0!)
        Me.txt_password.ForeColor = System.Drawing.Color.Black
        Me.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.Location = New System.Drawing.Point(1204, 367)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.PlaceholderText = ""
        Me.txt_password.SelectedText = ""
        Me.txt_password.Size = New System.Drawing.Size(415, 74)
        Me.txt_password.TabIndex = 69
        '
        'lbl_cnfirmpassword
        '
        Me.lbl_cnfirmpassword.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cnfirmpassword.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cnfirmpassword.Location = New System.Drawing.Point(1204, 451)
        Me.lbl_cnfirmpassword.Name = "lbl_cnfirmpassword"
        Me.lbl_cnfirmpassword.Size = New System.Drawing.Size(173, 37)
        Me.lbl_cnfirmpassword.TabIndex = 68
        Me.lbl_cnfirmpassword.Text = "Confirm Password"
        '
        'lbl_password
        '
        Me.lbl_password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_password.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(1204, 320)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(91, 37)
        Me.lbl_password.TabIndex = 67
        Me.lbl_password.Text = "Password"
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.Transparent
        Me.txt_username.BorderRadius = 10
        Me.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_username.DefaultText = ""
        Me.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.Font = New System.Drawing.Font("Sitka Banner", 18.0!)
        Me.txt_username.ForeColor = System.Drawing.Color.Black
        Me.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.Location = New System.Drawing.Point(1204, 236)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_username.PlaceholderText = ""
        Me.txt_username.SelectedText = ""
        Me.txt_username.Size = New System.Drawing.Size(415, 74)
        Me.txt_username.TabIndex = 66
        '
        'lbl_username
        '
        Me.lbl_username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_username.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(1204, 189)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(97, 37)
        Me.lbl_username.TabIndex = 65
        Me.lbl_username.Text = "Username"
        '
        'dvd_signup
        '
        Me.dvd_signup.BackColor = System.Drawing.Color.White
        Me.dvd_signup.Depth = 0
        Me.dvd_signup.Location = New System.Drawing.Point(1133, 52)
        Me.dvd_signup.MouseState = MaterialSkin.MouseState.HOVER
        Me.dvd_signup.Name = "dvd_signup"
        Me.dvd_signup.Size = New System.Drawing.Size(10, 571)
        Me.dvd_signup.TabIndex = 64
        Me.dvd_signup.Text = "MaterialDivider1"
        '
        'datetmpick_birthdate
        '
        Me.datetmpick_birthdate.Animated = True
        Me.datetmpick_birthdate.AutoRoundedCorners = True
        Me.datetmpick_birthdate.BackColor = System.Drawing.Color.Transparent
        Me.datetmpick_birthdate.BorderRadius = 36
        Me.datetmpick_birthdate.Checked = True
        Me.datetmpick_birthdate.FillColor = System.Drawing.Color.White
        Me.datetmpick_birthdate.Font = New System.Drawing.Font("Sitka Banner", 18.0!)
        Me.datetmpick_birthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.datetmpick_birthdate.IndicateFocus = True
        Me.datetmpick_birthdate.Location = New System.Drawing.Point(641, 367)
        Me.datetmpick_birthdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.datetmpick_birthdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.datetmpick_birthdate.Name = "datetmpick_birthdate"
        Me.datetmpick_birthdate.Size = New System.Drawing.Size(319, 74)
        Me.datetmpick_birthdate.TabIndex = 63
        Me.datetmpick_birthdate.Value = New Date(2024, 11, 24, 2, 20, 27, 767)
        '
        'lbl_birthdate
        '
        Me.lbl_birthdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_birthdate.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_birthdate.Location = New System.Drawing.Point(764, 324)
        Me.lbl_birthdate.Name = "lbl_birthdate"
        Me.lbl_birthdate.Size = New System.Drawing.Size(89, 37)
        Me.lbl_birthdate.TabIndex = 62
        Me.lbl_birthdate.Text = "Birthdate"
        '
        'lbl_age
        '
        Me.lbl_age.BackColor = System.Drawing.Color.Transparent
        Me.lbl_age.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_age.Location = New System.Drawing.Point(1013, 324)
        Me.lbl_age.Name = "lbl_age"
        Me.lbl_age.Size = New System.Drawing.Size(37, 37)
        Me.lbl_age.TabIndex = 61
        Me.lbl_age.Text = "Age"
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.Transparent
        Me.txt_email.BorderRadius = 10
        Me.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_email.DefaultText = ""
        Me.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email.Font = New System.Drawing.Font("Sitka Banner", 18.0!)
        Me.txt_email.ForeColor = System.Drawing.Color.Black
        Me.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_email.Location = New System.Drawing.Point(114, 367)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.PlaceholderText = ""
        Me.txt_email.SelectedText = ""
        Me.txt_email.Size = New System.Drawing.Size(503, 74)
        Me.txt_email.TabIndex = 59
        '
        'lbl_email
        '
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(114, 320)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(136, 37)
        Me.lbl_email.TabIndex = 58
        Me.lbl_email.Text = "Email Address"
        '
        'lbl_middleint
        '
        Me.lbl_middleint.BackColor = System.Drawing.Color.Transparent
        Me.lbl_middleint.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_middleint.Location = New System.Drawing.Point(1003, 189)
        Me.lbl_middleint.Name = "lbl_middleint"
        Me.lbl_middleint.Size = New System.Drawing.Size(33, 37)
        Me.lbl_middleint.TabIndex = 57
        Me.lbl_middleint.Text = "M.I"
        '
        'txt_middleint
        '
        Me.txt_middleint.BackColor = System.Drawing.Color.Transparent
        Me.txt_middleint.BorderRadius = 10
        Me.txt_middleint.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_middleint.DefaultText = ""
        Me.txt_middleint.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_middleint.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_middleint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_middleint.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_middleint.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_middleint.Font = New System.Drawing.Font("Sitka Banner", 18.0!)
        Me.txt_middleint.ForeColor = System.Drawing.Color.Black
        Me.txt_middleint.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_middleint.Location = New System.Drawing.Point(986, 236)
        Me.txt_middleint.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txt_middleint.Name = "txt_middleint"
        Me.txt_middleint.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_middleint.PlaceholderText = ""
        Me.txt_middleint.SelectedText = ""
        Me.txt_middleint.Size = New System.Drawing.Size(86, 74)
        Me.txt_middleint.TabIndex = 56
        '
        'txt_givenname
        '
        Me.txt_givenname.BackColor = System.Drawing.Color.Transparent
        Me.txt_givenname.BorderRadius = 10
        Me.txt_givenname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_givenname.DefaultText = ""
        Me.txt_givenname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_givenname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_givenname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_givenname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_givenname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_givenname.Font = New System.Drawing.Font("Sitka Banner", 18.0!)
        Me.txt_givenname.ForeColor = System.Drawing.Color.Black
        Me.txt_givenname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_givenname.Location = New System.Drawing.Point(545, 236)
        Me.txt_givenname.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txt_givenname.Name = "txt_givenname"
        Me.txt_givenname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_givenname.PlaceholderText = ""
        Me.txt_givenname.SelectedText = ""
        Me.txt_givenname.Size = New System.Drawing.Size(415, 74)
        Me.txt_givenname.TabIndex = 55
        '
        'lbl_givenname
        '
        Me.lbl_givenname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_givenname.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_givenname.Location = New System.Drawing.Point(545, 189)
        Me.lbl_givenname.Name = "lbl_givenname"
        Me.lbl_givenname.Size = New System.Drawing.Size(116, 37)
        Me.lbl_givenname.TabIndex = 54
        Me.lbl_givenname.Text = "Given Name"
        '
        'txt_surname
        '
        Me.txt_surname.BackColor = System.Drawing.Color.Transparent
        Me.txt_surname.BorderRadius = 10
        Me.txt_surname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_surname.DefaultText = ""
        Me.txt_surname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_surname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_surname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_surname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_surname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_surname.Font = New System.Drawing.Font("Sitka Banner", 18.0!)
        Me.txt_surname.ForeColor = System.Drawing.Color.Black
        Me.txt_surname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_surname.Location = New System.Drawing.Point(114, 236)
        Me.txt_surname.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txt_surname.Name = "txt_surname"
        Me.txt_surname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_surname.PlaceholderText = ""
        Me.txt_surname.SelectedText = ""
        Me.txt_surname.Size = New System.Drawing.Size(411, 74)
        Me.txt_surname.TabIndex = 53
        '
        'linklbl_login
        '
        Me.linklbl_login.AutoSize = True
        Me.linklbl_login.BackColor = System.Drawing.Color.Transparent
        Me.linklbl_login.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.linklbl_login.LinkColor = System.Drawing.Color.Black
        Me.linklbl_login.Location = New System.Drawing.Point(318, 131)
        Me.linklbl_login.Name = "linklbl_login"
        Me.linklbl_login.Size = New System.Drawing.Size(62, 29)
        Me.linklbl_login.TabIndex = 52
        Me.linklbl_login.TabStop = True
        Me.linklbl_login.Text = "Log In"
        '
        'lbl_question
        '
        Me.lbl_question.BackColor = System.Drawing.Color.Transparent
        Me.lbl_question.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_question.Location = New System.Drawing.Point(114, 130)
        Me.lbl_question.Name = "lbl_question"
        Me.lbl_question.Size = New System.Drawing.Size(201, 31)
        Me.lbl_question.TabIndex = 51
        Me.lbl_question.Text = "Already have an account?"
        '
        'lbl_header
        '
        Me.lbl_header.BackColor = System.Drawing.Color.Transparent
        Me.lbl_header.Font = New System.Drawing.Font("Sitka Banner", 45.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_header.Location = New System.Drawing.Point(114, 39)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(447, 89)
        Me.lbl_header.TabIndex = 50
        Me.lbl_header.Text = "Create an Account"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2ToggleSwitch1
        '
        Me.Guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.Guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2ToggleSwitch1.Location = New System.Drawing.Point(1566, 398)
        Me.Guna2ToggleSwitch1.Name = "Guna2ToggleSwitch1"
        Me.Guna2ToggleSwitch1.Size = New System.Drawing.Size(35, 20)
        Me.Guna2ToggleSwitch1.TabIndex = 74
        Me.Guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.Guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'Guna2ToggleSwitch2
        '
        Me.Guna2ToggleSwitch2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ToggleSwitch2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ToggleSwitch2.CheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.Guna2ToggleSwitch2.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2ToggleSwitch2.Location = New System.Drawing.Point(1566, 528)
        Me.Guna2ToggleSwitch2.Name = "Guna2ToggleSwitch2"
        Me.Guna2ToggleSwitch2.Size = New System.Drawing.Size(35, 20)
        Me.Guna2ToggleSwitch2.TabIndex = 75
        Me.Guna2ToggleSwitch2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2ToggleSwitch2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2ToggleSwitch2.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.Guna2ToggleSwitch2.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1731, 693)
        Me.Controls.Add(Me.pnl_signup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        Me.pnl_signup.ResumeLayout(False)
        Me.pnl_signup.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_surname As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnl_signup As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lbl_question As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_header As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents linklbl_login As LinkLabel
    Friend WithEvents txt_surname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_givenname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_givenname As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_middleint As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_middleint As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_email As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_birthdate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_age As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents datetmpick_birthdate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lbl_cnfirmpassword As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_password As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_username As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dvd_signup As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents txt_cnfirmpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_signup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents lbl_agevalue As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ToggleSwitch2 As Guna.UI2.WinForms.Guna2ToggleSwitch
    Friend WithEvents Guna2ToggleSwitch1 As Guna.UI2.WinForms.Guna2ToggleSwitch
End Class
