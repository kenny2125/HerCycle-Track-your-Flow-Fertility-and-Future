<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogIn
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
        Me.btn_login = New Guna.UI2.WinForms.Guna2Button()
        Me.linklbl_create = New System.Windows.Forms.LinkLabel()
        Me.txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnl_login = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lbl_question = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_password = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_username = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_login.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.AutoRoundedCorners = True
        Me.btn_login.BackColor = System.Drawing.Color.Transparent
        Me.btn_login.BorderRadius = 31
        Me.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_login.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_login.Font = New System.Drawing.Font("Sylfaen", 23.0!, System.Drawing.FontStyle.Bold)
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(175, 379)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(238, 65)
        Me.btn_login.TabIndex = 7
        Me.btn_login.Text = "Log In"
        '
        'linklbl_create
        '
        Me.linklbl_create.AutoSize = True
        Me.linklbl_create.BackColor = System.Drawing.Color.Transparent
        Me.linklbl_create.Font = New System.Drawing.Font("Sitka Banner", 18.0!)
        Me.linklbl_create.LinkColor = System.Drawing.Color.Black
        Me.linklbl_create.Location = New System.Drawing.Point(310, 455)
        Me.linklbl_create.Name = "linklbl_create"
        Me.linklbl_create.Size = New System.Drawing.Size(179, 35)
        Me.linklbl_create.TabIndex = 10
        Me.linklbl_create.TabStop = True
        Me.linklbl_create.Text = "Create an Account"
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
        Me.txt_password.Location = New System.Drawing.Point(37, 308)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.PlaceholderText = ""
        Me.txt_password.SelectedText = ""
        Me.txt_password.Size = New System.Drawing.Size(496, 56)
        Me.txt_password.TabIndex = 11
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.Transparent
        Me.txt_username.BorderColor = System.Drawing.Color.White
        Me.txt_username.BorderRadius = 10
        Me.txt_username.BorderThickness = 0
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
        Me.txt_username.Location = New System.Drawing.Point(37, 188)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_username.PlaceholderText = ""
        Me.txt_username.SelectedText = ""
        Me.txt_username.Size = New System.Drawing.Size(496, 56)
        Me.txt_username.TabIndex = 12
        '
        'pnl_login
        '
        Me.pnl_login.Controls.Add(Me.lbl_question)
        Me.pnl_login.Controls.Add(Me.lbl_password)
        Me.pnl_login.Controls.Add(Me.linklbl_create)
        Me.pnl_login.Controls.Add(Me.txt_username)
        Me.pnl_login.Controls.Add(Me.lbl_username)
        Me.pnl_login.Controls.Add(Me.txt_password)
        Me.pnl_login.Controls.Add(Me.btn_login)
        Me.pnl_login.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.pnl_login.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.pnl_login.Location = New System.Drawing.Point(1, 0)
        Me.pnl_login.Name = "pnl_login"
        Me.pnl_login.Size = New System.Drawing.Size(575, 534)
        Me.pnl_login.TabIndex = 14
        '
        'lbl_question
        '
        Me.lbl_question.BackColor = System.Drawing.Color.Transparent
        Me.lbl_question.Font = New System.Drawing.Font("Sitka Banner", 18.0!)
        Me.lbl_question.Location = New System.Drawing.Point(91, 453)
        Me.lbl_question.Name = "lbl_question"
        Me.lbl_question.Size = New System.Drawing.Size(213, 37)
        Me.lbl_question.TabIndex = 14
        Me.lbl_question.Text = "Don't have an account?"
        '
        'lbl_password
        '
        Me.lbl_password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_password.Font = New System.Drawing.Font("Sitka Banner", 20.0!)
        Me.lbl_password.Location = New System.Drawing.Point(37, 261)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(102, 41)
        Me.lbl_password.TabIndex = 13
        Me.lbl_password.Text = "Password"
        '
        'lbl_username
        '
        Me.lbl_username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_username.Font = New System.Drawing.Font("Sitka Banner", 20.0!)
        Me.lbl_username.Location = New System.Drawing.Point(37, 140)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(109, 41)
        Me.lbl_username.TabIndex = 8
        Me.lbl_username.Text = "Username"
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(576, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl_login)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(592, 585)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(592, 546)
        Me.Name = "LogIn"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogIn"
        Me.TopMost = True
        Me.pnl_login.ResumeLayout(False)
        Me.pnl_login.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents linklbl_create As LinkLabel
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pnl_login As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lbl_username As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_password As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_question As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
