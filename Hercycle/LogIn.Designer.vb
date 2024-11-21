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
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.btn_login = New Guna.UI2.WinForms.Guna2Button()
        Me.linklbl_create = New System.Windows.Forms.LinkLabel()
        Me.txt_usernamefield = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_passwordfield = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_password.Font = New System.Drawing.Font("Sitka Banner", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(133, 307)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(0, 42)
        Me.lbl_password.TabIndex = 1
        '
        'btn_login
        '
        Me.btn_login.AutoRoundedCorners = True
        Me.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_login.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_login.Font = New System.Drawing.Font("Sylfaen", 23.0!, System.Drawing.FontStyle.Bold)
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(210, 423)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(173, 45)
        Me.btn_login.TabIndex = 7
        Me.btn_login.Text = "Log In"
        '
        'linklbl_create
        '
        Me.linklbl_create.AutoSize = True
        Me.linklbl_create.BackColor = System.Drawing.Color.Transparent
        Me.linklbl_create.Font = New System.Drawing.Font("Sitka Text", 14.0!)
        Me.linklbl_create.LinkColor = System.Drawing.Color.Black
        Me.linklbl_create.Location = New System.Drawing.Point(321, 497)
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
        Me.txt_usernamefield.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_usernamefield.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_usernamefield.ForeColor = System.Drawing.Color.Black
        Me.txt_usernamefield.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_usernamefield.Location = New System.Drawing.Point(38, 213)
        Me.txt_usernamefield.Name = "txt_usernamefield"
        Me.txt_usernamefield.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_usernamefield.PlaceholderText = ""
        Me.txt_usernamefield.SelectedText = ""
        Me.txt_usernamefield.Size = New System.Drawing.Size(496, 41)
        Me.txt_usernamefield.TabIndex = 11
        '
        'txt_passwordfield
        '
        Me.txt_passwordfield.BackColor = System.Drawing.Color.White
        Me.txt_passwordfield.BorderColor = System.Drawing.Color.White
        Me.txt_passwordfield.BorderThickness = 0
        Me.txt_passwordfield.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_passwordfield.DefaultText = ""
        Me.txt_passwordfield.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_passwordfield.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_passwordfield.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_passwordfield.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_passwordfield.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_passwordfield.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_passwordfield.ForeColor = System.Drawing.Color.Black
        Me.txt_passwordfield.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_passwordfield.Location = New System.Drawing.Point(38, 349)
        Me.txt_passwordfield.Name = "txt_passwordfield"
        Me.txt_passwordfield.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_passwordfield.PlaceholderText = ""
        Me.txt_passwordfield.SelectedText = ""
        Me.txt_passwordfield.Size = New System.Drawing.Size(496, 43)
        Me.txt_passwordfield.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hercycle.My.Resources.Resources.Login
        Me.PictureBox1.Location = New System.Drawing.Point(-6, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(583, 549)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'LogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(576, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_passwordfield)
        Me.Controls.Add(Me.txt_usernamefield)
        Me.Controls.Add(Me.linklbl_create)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_password As Label
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents linklbl_create As LinkLabel
    Friend WithEvents txt_usernamefield As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_passwordfield As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
