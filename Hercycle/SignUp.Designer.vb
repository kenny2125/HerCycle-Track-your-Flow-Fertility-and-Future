<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.txt_surname = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_givenname = New System.Windows.Forms.TextBox()
        Me.txt_middleint = New System.Windows.Forms.TextBox()
        Me.txt_age = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_confirmpass = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_create = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_question = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_surname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.btn_signup = New Guna.UI2.WinForms.Guna2Button()
        Me.linklbl_create = New System.Windows.Forms.LinkLabel()
        Me.lbl_username = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_password = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_confirmpass = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.chckbox_terms = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.lbl_givenname = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_middleint = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_email = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_gender = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbox_gender = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lbl_age = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_divider = New Guna.UI2.WinForms.Guna2Panel()
        Me.SuspendLayout()
        '
        'txt_surname
        '
        Me.txt_surname.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_surname.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_surname.Location = New System.Drawing.Point(69, 217)
        Me.txt_surname.Name = "txt_surname"
        Me.txt_surname.Size = New System.Drawing.Size(296, 50)
        Me.txt_surname.TabIndex = 1
        '
        'txt_email
        '
        Me.txt_email.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_email.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(69, 369)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(709, 50)
        Me.txt_email.TabIndex = 4
        '
        'txt_givenname
        '
        Me.txt_givenname.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_givenname.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_givenname.Location = New System.Drawing.Point(386, 217)
        Me.txt_givenname.Name = "txt_givenname"
        Me.txt_givenname.Size = New System.Drawing.Size(578, 50)
        Me.txt_givenname.TabIndex = 2
        '
        'txt_middleint
        '
        Me.txt_middleint.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_middleint.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_middleint.Location = New System.Drawing.Point(982, 217)
        Me.txt_middleint.Name = "txt_middleint"
        Me.txt_middleint.Size = New System.Drawing.Size(157, 50)
        Me.txt_middleint.TabIndex = 3
        '
        'txt_age
        '
        Me.txt_age.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_age.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_age.Location = New System.Drawing.Point(799, 369)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(128, 50)
        Me.txt_age.TabIndex = 5
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(1239, 274)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(408, 50)
        Me.txt_password.TabIndex = 8
        '
        'txt_confirmpass
        '
        Me.txt_confirmpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_confirmpass.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirmpass.Location = New System.Drawing.Point(1239, 412)
        Me.txt_confirmpass.Name = "txt_confirmpass"
        Me.txt_confirmpass.Size = New System.Drawing.Size(408, 50)
        Me.txt_confirmpass.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(36, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(318, 37)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Already have an account?"
        '
        'lbl_create
        '
        Me.lbl_create.BackColor = System.Drawing.Color.Transparent
        Me.lbl_create.Font = New System.Drawing.Font("Sitka Text", 45.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_create.Location = New System.Drawing.Point(27, 12)
        Me.lbl_create.Name = "lbl_create"
        Me.lbl_create.Size = New System.Drawing.Size(536, 89)
        Me.lbl_create.TabIndex = 23
        Me.lbl_create.Text = "Create an Account"
        '
        'lbl_question
        '
        Me.lbl_question.BackColor = System.Drawing.Color.Transparent
        Me.lbl_question.Font = New System.Drawing.Font("Sitka Text", 13.0!)
        Me.lbl_question.Location = New System.Drawing.Point(67, 100)
        Me.lbl_question.Name = "lbl_question"
        Me.lbl_question.Size = New System.Drawing.Size(203, 26)
        Me.lbl_question.TabIndex = 24
        Me.lbl_question.Text = " Already have an account?"
        '
        'lbl_surname
        '
        Me.lbl_surname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_surname.Font = New System.Drawing.Font("Sitka Text", 18.0!)
        Me.lbl_surname.Location = New System.Drawing.Point(69, 174)
        Me.lbl_surname.Name = "lbl_surname"
        Me.lbl_surname.Size = New System.Drawing.Size(104, 37)
        Me.lbl_surname.TabIndex = 25
        Me.lbl_surname.Text = "Surname"
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_username.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(1239, 132)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(408, 50)
        Me.txt_username.TabIndex = 34
        '
        'btn_signup
        '
        Me.btn_signup.BorderRadius = 6
        Me.btn_signup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_signup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_signup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_signup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_signup.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_signup.Font = New System.Drawing.Font("Sitka Text", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btn_signup.ForeColor = System.Drawing.Color.White
        Me.btn_signup.Location = New System.Drawing.Point(1364, 544)
        Me.btn_signup.Name = "btn_signup"
        Me.btn_signup.Size = New System.Drawing.Size(197, 58)
        Me.btn_signup.TabIndex = 35
        Me.btn_signup.Text = "Sign Up"
        '
        'linklbl_create
        '
        Me.linklbl_create.AutoSize = True
        Me.linklbl_create.Font = New System.Drawing.Font("Sitka Text", 13.0!)
        Me.linklbl_create.LinkColor = System.Drawing.Color.Black
        Me.linklbl_create.Location = New System.Drawing.Point(271, 99)
        Me.linklbl_create.Name = "linklbl_create"
        Me.linklbl_create.Size = New System.Drawing.Size(65, 26)
        Me.linklbl_create.TabIndex = 37
        Me.linklbl_create.TabStop = True
        Me.linklbl_create.Text = "Log In"
        '
        'lbl_username
        '
        Me.lbl_username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_username.Font = New System.Drawing.Font("Sitka Text", 18.0!)
        Me.lbl_username.Location = New System.Drawing.Point(1239, 89)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(119, 37)
        Me.lbl_username.TabIndex = 38
        Me.lbl_username.Text = "Username"
        '
        'lbl_password
        '
        Me.lbl_password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_password.Font = New System.Drawing.Font("Sitka Text", 18.0!)
        Me.lbl_password.Location = New System.Drawing.Point(1239, 231)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(110, 37)
        Me.lbl_password.TabIndex = 39
        Me.lbl_password.Text = "Password"
        '
        'lbl_confirmpass
        '
        Me.lbl_confirmpass.BackColor = System.Drawing.Color.Transparent
        Me.lbl_confirmpass.Font = New System.Drawing.Font("Sitka Text", 18.0!)
        Me.lbl_confirmpass.Location = New System.Drawing.Point(1239, 369)
        Me.lbl_confirmpass.Name = "lbl_confirmpass"
        Me.lbl_confirmpass.Size = New System.Drawing.Size(210, 37)
        Me.lbl_confirmpass.TabIndex = 40
        Me.lbl_confirmpass.Text = "Confirm Password"
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Sitka Text", 18.0!)
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(961, 474)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(3, 2)
        Me.Guna2HtmlLabel11.TabIndex = 41
        '
        'chckbox_terms
        '
        Me.chckbox_terms.AutoSize = True
        Me.chckbox_terms.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chckbox_terms.CheckedState.BorderRadius = 0
        Me.chckbox_terms.CheckedState.BorderThickness = 0
        Me.chckbox_terms.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chckbox_terms.Font = New System.Drawing.Font("Sitka Text", 9.0!)
        Me.chckbox_terms.Location = New System.Drawing.Point(1282, 484)
        Me.chckbox_terms.Name = "chckbox_terms"
        Me.chckbox_terms.Size = New System.Drawing.Size(342, 22)
        Me.chckbox_terms.TabIndex = 42
        Me.chckbox_terms.Text = "I agree to the Terms and Conditions while using this app"
        Me.chckbox_terms.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.chckbox_terms.UncheckedState.BorderRadius = 0
        Me.chckbox_terms.UncheckedState.BorderThickness = 0
        Me.chckbox_terms.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'lbl_givenname
        '
        Me.lbl_givenname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_givenname.Font = New System.Drawing.Font("Sitka Text", 18.0!)
        Me.lbl_givenname.Location = New System.Drawing.Point(386, 174)
        Me.lbl_givenname.Name = "lbl_givenname"
        Me.lbl_givenname.Size = New System.Drawing.Size(142, 37)
        Me.lbl_givenname.TabIndex = 43
        Me.lbl_givenname.Text = "Given Name"
        '
        'lbl_middleint
        '
        Me.lbl_middleint.BackColor = System.Drawing.Color.Transparent
        Me.lbl_middleint.Font = New System.Drawing.Font("Sitka Text", 18.0!)
        Me.lbl_middleint.Location = New System.Drawing.Point(982, 174)
        Me.lbl_middleint.Name = "lbl_middleint"
        Me.lbl_middleint.Size = New System.Drawing.Size(41, 37)
        Me.lbl_middleint.TabIndex = 44
        Me.lbl_middleint.Text = "M.I"
        '
        'lbl_email
        '
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Font = New System.Drawing.Font("Sitka Text", 18.0!)
        Me.lbl_email.Location = New System.Drawing.Point(69, 326)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(165, 37)
        Me.lbl_email.TabIndex = 45
        Me.lbl_email.Text = "Email Address"
        '
        'lbl_gender
        '
        Me.lbl_gender.BackColor = System.Drawing.Color.Transparent
        Me.lbl_gender.Font = New System.Drawing.Font("Sitka Text", 18.0!)
        Me.lbl_gender.Location = New System.Drawing.Point(944, 326)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(86, 37)
        Me.lbl_gender.TabIndex = 46
        Me.lbl_gender.Text = "Gender"
        '
        'cmbox_gender
        '
        Me.cmbox_gender.BackColor = System.Drawing.Color.Transparent
        Me.cmbox_gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbox_gender.DropDownHeight = 116
        Me.cmbox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbox_gender.DropDownWidth = 50
        Me.cmbox_gender.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cmbox_gender.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbox_gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbox_gender.Font = New System.Drawing.Font("Sitka Text", 24.0!)
        Me.cmbox_gender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbox_gender.IntegralHeight = False
        Me.cmbox_gender.ItemHeight = 44
        Me.cmbox_gender.Location = New System.Drawing.Point(944, 369)
        Me.cmbox_gender.Name = "cmbox_gender"
        Me.cmbox_gender.Size = New System.Drawing.Size(195, 50)
        Me.cmbox_gender.TabIndex = 47
        '
        'lbl_age
        '
        Me.lbl_age.BackColor = System.Drawing.Color.Transparent
        Me.lbl_age.Font = New System.Drawing.Font("Sitka Text", 18.0!)
        Me.lbl_age.Location = New System.Drawing.Point(799, 326)
        Me.lbl_age.Name = "lbl_age"
        Me.lbl_age.Size = New System.Drawing.Size(44, 37)
        Me.lbl_age.TabIndex = 48
        Me.lbl_age.Text = "Age"
        '
        'pnl_divider
        '
        Me.pnl_divider.BackColor = System.Drawing.Color.Black
        Me.pnl_divider.Location = New System.Drawing.Point(1187, 57)
        Me.pnl_divider.Name = "pnl_divider"
        Me.pnl_divider.Size = New System.Drawing.Size(10, 553)
        Me.pnl_divider.TabIndex = 49
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1731, 696)
        Me.Controls.Add(Me.pnl_divider)
        Me.Controls.Add(Me.lbl_age)
        Me.Controls.Add(Me.cmbox_gender)
        Me.Controls.Add(Me.lbl_gender)
        Me.Controls.Add(Me.lbl_email)
        Me.Controls.Add(Me.lbl_middleint)
        Me.Controls.Add(Me.lbl_givenname)
        Me.Controls.Add(Me.chckbox_terms)
        Me.Controls.Add(Me.Guna2HtmlLabel11)
        Me.Controls.Add(Me.lbl_confirmpass)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.linklbl_create)
        Me.Controls.Add(Me.btn_signup)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.lbl_surname)
        Me.Controls.Add(Me.lbl_question)
        Me.Controls.Add(Me.lbl_create)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_confirmpass)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_age)
        Me.Controls.Add(Me.txt_middleint)
        Me.Controls.Add(Me.txt_givenname)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_surname)
        Me.Name = "SignUp"
        Me.Text = "SignUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_surname As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_givenname As TextBox
    Friend WithEvents txt_middleint As TextBox
    Friend WithEvents txt_age As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_confirmpass As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_create As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_question As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_surname As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_username As TextBox
    Friend WithEvents btn_signup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents linklbl_create As LinkLabel
    Friend WithEvents lbl_username As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_password As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_confirmpass As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents chckbox_terms As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents lbl_givenname As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_middleint As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_email As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_gender As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbox_gender As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lbl_age As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnl_divider As Guna.UI2.WinForms.Guna2Panel
End Class
