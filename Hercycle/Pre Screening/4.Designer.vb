<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _4
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
        Me.lbl_header = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_subheader = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_input = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_enter = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_no = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'lbl_header
        '
        Me.lbl_header.BackColor = System.Drawing.Color.Transparent
        Me.lbl_header.Font = New System.Drawing.Font("Sitka Banner", 18.0!)
        Me.lbl_header.ForeColor = System.Drawing.Color.White
        Me.lbl_header.Location = New System.Drawing.Point(207, 12)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(229, 37)
        Me.lbl_header.TabIndex = 54
        Me.lbl_header.Text = "Pre-Screening Questions"
        '
        'lbl_subheader
        '
        Me.lbl_subheader.AutoSize = False
        Me.lbl_subheader.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subheader.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_subheader.ForeColor = System.Drawing.Color.White
        Me.lbl_subheader.Location = New System.Drawing.Point(72, 55)
        Me.lbl_subheader.Name = "lbl_subheader"
        Me.lbl_subheader.Size = New System.Drawing.Size(500, 88)
        Me.lbl_subheader.TabIndex = 57
        Me.lbl_subheader.Text = "What is the average length of your menstrual cycle (in days)?"
        Me.lbl_subheader.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_input
        '
        Me.txt_input.BackColor = System.Drawing.Color.Transparent
        Me.txt_input.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.txt_input.BorderRadius = 20
        Me.txt_input.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_input.DefaultText = ""
        Me.txt_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_input.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.txt_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_input.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_input.Location = New System.Drawing.Point(178, 363)
        Me.txt_input.Name = "txt_input"
        Me.txt_input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_input.PlaceholderText = ""
        Me.txt_input.SelectedText = ""
        Me.txt_input.Size = New System.Drawing.Size(158, 41)
        Me.txt_input.TabIndex = 58
        '
        'btn_enter
        '
        Me.btn_enter.BorderRadius = 20
        Me.btn_enter.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_enter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_enter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_enter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_enter.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btn_enter.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btn_enter.ForeColor = System.Drawing.Color.Black
        Me.btn_enter.Location = New System.Drawing.Point(342, 363)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(112, 41)
        Me.btn_enter.TabIndex = 59
        Me.btn_enter.Text = "Enter"
        Me.btn_enter.TextOffset = New System.Drawing.Point(0, -3)
        '
        'btn_no
        '
        Me.btn_no.BorderRadius = 20
        Me.btn_no.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_no.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_no.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_no.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_no.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btn_no.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btn_no.ForeColor = System.Drawing.Color.Black
        Me.btn_no.Location = New System.Drawing.Point(251, 417)
        Me.btn_no.Name = "btn_no"
        Me.btn_no.Size = New System.Drawing.Size(130, 41)
        Me.btn_no.TabIndex = 60
        Me.btn_no.Text = "Not Sure"
        Me.btn_no.TextOffset = New System.Drawing.Point(0, -3)
        '
        '_4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(649, 481)
        Me.Controls.Add(Me.btn_no)
        Me.Controls.Add(Me.btn_enter)
        Me.Controls.Add(Me.txt_input)
        Me.Controls.Add(Me.lbl_subheader)
        Me.Controls.Add(Me.lbl_header)
        Me.Name = "_4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "_4"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_header As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_subheader As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txt_input As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_enter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_no As Guna.UI2.WinForms.Guna2Button
End Class
