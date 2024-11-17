<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogIn
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
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.btn_login = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_question = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.linklbl_create = New System.Windows.Forms.LinkLabel()
        Me.txt_usernamefield = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_passwordfield = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Sitka Banner", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(14, 144)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(130, 42)
        Me.lbl_username.TabIndex = 0
        Me.lbl_username.Text = "Username"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Sitka Banner", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(14, 260)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(123, 42)
        Me.lbl_password.TabIndex = 1
        Me.lbl_password.Text = "Password"
        '
        'btn_login
        '
        Me.btn_login.AutoRoundedCorners = True
        Me.btn_login.BorderRadius = 32
        Me.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_login.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_login.Font = New System.Drawing.Font("Sylfaen", 23.0!, System.Drawing.FontStyle.Bold)
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(151, 379)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(256, 67)
        Me.btn_login.TabIndex = 7
        Me.btn_login.Text = "Log In"
        '
        'lbl_question
        '
        Me.lbl_question.BackColor = System.Drawing.Color.Transparent
        Me.lbl_question.Font = New System.Drawing.Font("Sitka Text", 14.0!)
        Me.lbl_question.Location = New System.Drawing.Point(89, 459)
        Me.lbl_question.Name = "lbl_question"
        Me.lbl_question.Size = New System.Drawing.Size(207, 30)
        Me.lbl_question.TabIndex = 9
        Me.lbl_question.Text = "Don't have an account?"
        '
        'linklbl_create
        '
        Me.linklbl_create.AutoSize = True
        Me.linklbl_create.Font = New System.Drawing.Font("Sitka Text", 14.0!)
        Me.linklbl_create.LinkColor = System.Drawing.Color.Black
        Me.linklbl_create.Location = New System.Drawing.Point(296, 460)
        Me.linklbl_create.Name = "linklbl_create"
        Me.linklbl_create.Size = New System.Drawing.Size(173, 28)
        Me.linklbl_create.TabIndex = 10
        Me.linklbl_create.TabStop = True
        Me.linklbl_create.Text = "Create an Account"
        '
        'txt_usernamefield
        '
        Me.txt_usernamefield.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_usernamefield.DefaultText = ""
        Me.txt_usernamefield.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_usernamefield.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_usernamefield.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_usernamefield.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_usernamefield.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_usernamefield.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_usernamefield.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_usernamefield.ForeColor = System.Drawing.Color.DarkGray
        Me.txt_usernamefield.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_usernamefield.Location = New System.Drawing.Point(21, 184)
        Me.txt_usernamefield.Name = "txt_usernamefield"
        Me.txt_usernamefield.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_usernamefield.PlaceholderText = ""
        Me.txt_usernamefield.SelectedText = ""
        Me.txt_usernamefield.Size = New System.Drawing.Size(513, 54)
        Me.txt_usernamefield.TabIndex = 11
        '
        'txt_passwordfield
        '
        Me.txt_passwordfield.BackColor = System.Drawing.Color.Silver
        Me.txt_passwordfield.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_passwordfield.DefaultText = ""
        Me.txt_passwordfield.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_passwordfield.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_passwordfield.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_passwordfield.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_passwordfield.FillColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_passwordfield.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_passwordfield.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_passwordfield.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txt_passwordfield.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_passwordfield.Location = New System.Drawing.Point(21, 300)
        Me.txt_passwordfield.Name = "txt_passwordfield"
        Me.txt_passwordfield.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_passwordfield.PlaceholderText = ""
        Me.txt_passwordfield.SelectedText = ""
        Me.txt_passwordfield.Size = New System.Drawing.Size(513, 54)
        Me.txt_passwordfield.TabIndex = 12
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(576, 507)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_passwordfield)
        Me.Controls.Add(Me.txt_usernamefield)
        Me.Controls.Add(Me.linklbl_create)
        Me.Controls.Add(Me.lbl_question)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_username)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(592, 546)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(592, 546)
        Me.Name = "LogIn"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogIn"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_username As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_question As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents linklbl_create As LinkLabel
    Friend WithEvents txt_usernamefield As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_passwordfield As Guna.UI2.WinForms.Guna2TextBox
End Class
