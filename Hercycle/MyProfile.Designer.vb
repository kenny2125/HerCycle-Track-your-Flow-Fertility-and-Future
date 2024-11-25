<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MyProfile
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
        Me.btn_logout = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_close = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_tracking = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_ageval = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_bdayval = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_passwordval = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_usernameval = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_emailval = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_nameval = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_ans4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_ans3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_ans2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_ans1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_ques4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_ques3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_ques2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_ques1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_subheader = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_age = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_birthdate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_password = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_username = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_email = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_name = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_header = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
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
        Me.btn_logout.Location = New System.Drawing.Point(230, 354)
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
        Me.btn_close.Location = New System.Drawing.Point(417, 354)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(197, 32)
        Me.btn_close.TabIndex = 22
        Me.btn_close.Text = "Close Program"
        '
        'pnl_tracking
        '
        Me.pnl_tracking.BackColor = System.Drawing.Color.Transparent
        Me.pnl_tracking.Controls.Add(Me.Guna2Button1)
        Me.pnl_tracking.Controls.Add(Me.lbl_ageval)
        Me.pnl_tracking.Controls.Add(Me.lbl_bdayval)
        Me.pnl_tracking.Controls.Add(Me.lbl_passwordval)
        Me.pnl_tracking.Controls.Add(Me.lbl_usernameval)
        Me.pnl_tracking.Controls.Add(Me.lbl_emailval)
        Me.pnl_tracking.Controls.Add(Me.lbl_nameval)
        Me.pnl_tracking.Controls.Add(Me.lbl_ans4)
        Me.pnl_tracking.Controls.Add(Me.lbl_ans3)
        Me.pnl_tracking.Controls.Add(Me.lbl_ans2)
        Me.pnl_tracking.Controls.Add(Me.lbl_ans1)
        Me.pnl_tracking.Controls.Add(Me.lbl_ques4)
        Me.pnl_tracking.Controls.Add(Me.lbl_ques3)
        Me.pnl_tracking.Controls.Add(Me.lbl_ques2)
        Me.pnl_tracking.Controls.Add(Me.lbl_ques1)
        Me.pnl_tracking.Controls.Add(Me.lbl_subheader)
        Me.pnl_tracking.Controls.Add(Me.lbl_age)
        Me.pnl_tracking.Controls.Add(Me.lbl_birthdate)
        Me.pnl_tracking.Controls.Add(Me.lbl_password)
        Me.pnl_tracking.Controls.Add(Me.lbl_username)
        Me.pnl_tracking.Controls.Add(Me.lbl_email)
        Me.pnl_tracking.Controls.Add(Me.btn_close)
        Me.pnl_tracking.Controls.Add(Me.lbl_name)
        Me.pnl_tracking.Controls.Add(Me.btn_logout)
        Me.pnl_tracking.Controls.Add(Me.lbl_header)
        Me.pnl_tracking.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pnl_tracking.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.pnl_tracking.Location = New System.Drawing.Point(-1, 0)
        Me.pnl_tracking.Name = "pnl_tracking"
        Me.pnl_tracking.Size = New System.Drawing.Size(838, 400)
        Me.pnl_tracking.TabIndex = 27
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Sylfaen", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(789, 12)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(38, 32)
        Me.Guna2Button1.TabIndex = 83
        Me.Guna2Button1.Text = "X"
        '
        'lbl_ageval
        '
        Me.lbl_ageval.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ageval.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_ageval.Location = New System.Drawing.Point(195, 233)
        Me.lbl_ageval.Name = "lbl_ageval"
        Me.lbl_ageval.Size = New System.Drawing.Size(31, 31)
        Me.lbl_ageval.TabIndex = 82
        Me.lbl_ageval.Text = "Age"
        '
        'lbl_bdayval
        '
        Me.lbl_bdayval.BackColor = System.Drawing.Color.Transparent
        Me.lbl_bdayval.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_bdayval.Location = New System.Drawing.Point(195, 198)
        Me.lbl_bdayval.Name = "lbl_bdayval"
        Me.lbl_bdayval.Size = New System.Drawing.Size(75, 31)
        Me.lbl_bdayval.TabIndex = 81
        Me.lbl_bdayval.Text = "Birthdate"
        '
        'lbl_passwordval
        '
        Me.lbl_passwordval.BackColor = System.Drawing.Color.Transparent
        Me.lbl_passwordval.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_passwordval.Location = New System.Drawing.Point(195, 303)
        Me.lbl_passwordval.Name = "lbl_passwordval"
        Me.lbl_passwordval.Size = New System.Drawing.Size(76, 31)
        Me.lbl_passwordval.TabIndex = 80
        Me.lbl_passwordval.Text = "Password"
        '
        'lbl_usernameval
        '
        Me.lbl_usernameval.BackColor = System.Drawing.Color.Transparent
        Me.lbl_usernameval.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_usernameval.Location = New System.Drawing.Point(195, 268)
        Me.lbl_usernameval.Name = "lbl_usernameval"
        Me.lbl_usernameval.Size = New System.Drawing.Size(79, 31)
        Me.lbl_usernameval.TabIndex = 79
        Me.lbl_usernameval.Text = "Username"
        '
        'lbl_emailval
        '
        Me.lbl_emailval.AutoSize = False
        Me.lbl_emailval.BackColor = System.Drawing.Color.Transparent
        Me.lbl_emailval.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_emailval.Location = New System.Drawing.Point(195, 136)
        Me.lbl_emailval.Name = "lbl_emailval"
        Me.lbl_emailval.Size = New System.Drawing.Size(113, 66)
        Me.lbl_emailval.TabIndex = 78
        Me.lbl_emailval.Text = "Email" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Address"
        '
        'lbl_nameval
        '
        Me.lbl_nameval.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nameval.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_nameval.Location = New System.Drawing.Point(195, 101)
        Me.lbl_nameval.Name = "lbl_nameval"
        Me.lbl_nameval.Size = New System.Drawing.Size(48, 31)
        Me.lbl_nameval.TabIndex = 77
        Me.lbl_nameval.Text = "Name"
        '
        'lbl_ans4
        '
        Me.lbl_ans4.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ans4.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ans4.Location = New System.Drawing.Point(757, 247)
        Me.lbl_ans4.Name = "lbl_ans4"
        Me.lbl_ans4.Size = New System.Drawing.Size(24, 31)
        Me.lbl_ans4.TabIndex = 76
        Me.lbl_ans4.Text = "28"
        '
        'lbl_ans3
        '
        Me.lbl_ans3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ans3.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ans3.Location = New System.Drawing.Point(757, 206)
        Me.lbl_ans3.Name = "lbl_ans3"
        Me.lbl_ans3.Size = New System.Drawing.Size(35, 31)
        Me.lbl_ans3.TabIndex = 75
        Me.lbl_ans3.Text = "YES"
        '
        'lbl_ans2
        '
        Me.lbl_ans2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ans2.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ans2.Location = New System.Drawing.Point(757, 171)
        Me.lbl_ans2.Name = "lbl_ans2"
        Me.lbl_ans2.Size = New System.Drawing.Size(29, 31)
        Me.lbl_ans2.TabIndex = 74
        Me.lbl_ans2.Text = "NO"
        '
        'lbl_ans1
        '
        Me.lbl_ans1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ans1.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ans1.Location = New System.Drawing.Point(757, 136)
        Me.lbl_ans1.Name = "lbl_ans1"
        Me.lbl_ans1.Size = New System.Drawing.Size(35, 31)
        Me.lbl_ans1.TabIndex = 73
        Me.lbl_ans1.Text = "YES"
        '
        'lbl_ques4
        '
        Me.lbl_ques4.AutoSize = False
        Me.lbl_ques4.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ques4.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_ques4.Location = New System.Drawing.Point(385, 247)
        Me.lbl_ques4.Name = "lbl_ques4"
        Me.lbl_ques4.Size = New System.Drawing.Size(366, 60)
        Me.lbl_ques4.TabIndex = 72
        Me.lbl_ques4.Text = "What is the average length of your menstrual cycle (in days)?"
        '
        'lbl_ques3
        '
        Me.lbl_ques3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ques3.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_ques3.Location = New System.Drawing.Point(385, 210)
        Me.lbl_ques3.Name = "lbl_ques3"
        Me.lbl_ques3.Size = New System.Drawing.Size(199, 31)
        Me.lbl_ques3.TabIndex = 71
        Me.lbl_ques3.Text = "Are your periods regular?"
        '
        'lbl_ques2
        '
        Me.lbl_ques2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ques2.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_ques2.Location = New System.Drawing.Point(385, 173)
        Me.lbl_ques2.Name = "lbl_ques2"
        Me.lbl_ques2.Size = New System.Drawing.Size(220, 31)
        Me.lbl_ques2.TabIndex = 70
        Me.lbl_ques2.Text = "Are you currently pregnant?"
        '
        'lbl_ques1
        '
        Me.lbl_ques1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ques1.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.lbl_ques1.Location = New System.Drawing.Point(385, 136)
        Me.lbl_ques1.Name = "lbl_ques1"
        Me.lbl_ques1.Size = New System.Drawing.Size(337, 31)
        Me.lbl_ques1.TabIndex = 69
        Me.lbl_ques1.Text = "Are you gonna use period plus for yourself?"
        '
        'lbl_subheader
        '
        Me.lbl_subheader.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subheader.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subheader.Location = New System.Drawing.Point(385, 99)
        Me.lbl_subheader.Name = "lbl_subheader"
        Me.lbl_subheader.Size = New System.Drawing.Size(191, 31)
        Me.lbl_subheader.TabIndex = 67
        Me.lbl_subheader.Text = "Pre Screening Answers"
        '
        'lbl_age
        '
        Me.lbl_age.BackColor = System.Drawing.Color.Transparent
        Me.lbl_age.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_age.Location = New System.Drawing.Point(27, 233)
        Me.lbl_age.Name = "lbl_age"
        Me.lbl_age.Size = New System.Drawing.Size(33, 31)
        Me.lbl_age.TabIndex = 64
        Me.lbl_age.Text = "Age"
        '
        'lbl_birthdate
        '
        Me.lbl_birthdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_birthdate.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_birthdate.Location = New System.Drawing.Point(26, 198)
        Me.lbl_birthdate.Name = "lbl_birthdate"
        Me.lbl_birthdate.Size = New System.Drawing.Size(80, 31)
        Me.lbl_birthdate.TabIndex = 63
        Me.lbl_birthdate.Text = "Birthdate"
        '
        'lbl_password
        '
        Me.lbl_password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_password.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(26, 303)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(81, 31)
        Me.lbl_password.TabIndex = 60
        Me.lbl_password.Text = "Password"
        '
        'lbl_username
        '
        Me.lbl_username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_username.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(26, 268)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(86, 31)
        Me.lbl_username.TabIndex = 59
        Me.lbl_username.Text = "Username"
        '
        'lbl_email
        '
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(27, 136)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(118, 31)
        Me.lbl_email.TabIndex = 57
        Me.lbl_email.Text = "Email Address"
        '
        'lbl_name
        '
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(27, 101)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(50, 31)
        Me.lbl_name.TabIndex = 55
        Me.lbl_name.Text = "Name"
        '
        'lbl_header
        '
        Me.lbl_header.BackColor = System.Drawing.Color.Transparent
        Me.lbl_header.Font = New System.Drawing.Font("Sitka Banner", 50.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_header.Location = New System.Drawing.Point(17, -4)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(285, 99)
        Me.lbl_header.TabIndex = 51
        Me.lbl_header.Text = "My Profile"
        Me.lbl_header.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 20
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'MyProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 398)
        Me.Controls.Add(Me.pnl_tracking)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MyProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents lbl_birthdate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_password As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_username As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_email As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_age As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_subheader As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_ques4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_ques3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_ques2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_ques1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_ans1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_ans4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_ans3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_ans2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents lbl_ageval As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_bdayval As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_passwordval As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_usernameval As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_emailval As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_nameval As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
