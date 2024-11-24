<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Period_Records
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
        Me.pnl_record = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btn_add = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_reset = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_notes = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_prduration = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_enddate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_notes = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_prduration = New Guna.UI2.WinForms.Guna2TextBox()
        Me.datetmpick_end = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.datetmpick_start = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lbl_startdate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_header = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_record.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_record
        '
        Me.pnl_record.BackColor = System.Drawing.Color.Transparent
        Me.pnl_record.Controls.Add(Me.btn_add)
        Me.pnl_record.Controls.Add(Me.btn_reset)
        Me.pnl_record.Controls.Add(Me.lbl_notes)
        Me.pnl_record.Controls.Add(Me.lbl_prduration)
        Me.pnl_record.Controls.Add(Me.lbl_enddate)
        Me.pnl_record.Controls.Add(Me.txt_notes)
        Me.pnl_record.Controls.Add(Me.txt_prduration)
        Me.pnl_record.Controls.Add(Me.datetmpick_end)
        Me.pnl_record.Controls.Add(Me.datetmpick_start)
        Me.pnl_record.Controls.Add(Me.lbl_startdate)
        Me.pnl_record.Controls.Add(Me.lbl_header)
        Me.pnl_record.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pnl_record.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.pnl_record.Location = New System.Drawing.Point(-2, 0)
        Me.pnl_record.Name = "pnl_record"
        Me.pnl_record.Size = New System.Drawing.Size(550, 585)
        Me.pnl_record.TabIndex = 6
        '
        'btn_add
        '
        Me.btn_add.BorderRadius = 6
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_add.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_add.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Location = New System.Drawing.Point(265, 519)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(189, 43)
        Me.btn_add.TabIndex = 77
        Me.btn_add.Text = "Add Record"
        '
        'btn_reset
        '
        Me.btn_reset.BorderRadius = 6
        Me.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_reset.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_reset.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btn_reset.ForeColor = System.Drawing.Color.White
        Me.btn_reset.Location = New System.Drawing.Point(102, 519)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(136, 43)
        Me.btn_reset.TabIndex = 76
        Me.btn_reset.Text = "Reset"
        '
        'lbl_notes
        '
        Me.lbl_notes.AutoSize = False
        Me.lbl_notes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_notes.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_notes.Location = New System.Drawing.Point(63, 389)
        Me.lbl_notes.Name = "lbl_notes"
        Me.lbl_notes.Size = New System.Drawing.Size(87, 31)
        Me.lbl_notes.TabIndex = 75
        Me.lbl_notes.Text = "Notes"
        Me.lbl_notes.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_prduration
        '
        Me.lbl_prduration.AutoSize = False
        Me.lbl_prduration.BackColor = System.Drawing.Color.Transparent
        Me.lbl_prduration.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prduration.Location = New System.Drawing.Point(63, 236)
        Me.lbl_prduration.Name = "lbl_prduration"
        Me.lbl_prduration.Size = New System.Drawing.Size(87, 60)
        Me.lbl_prduration.TabIndex = 74
        Me.lbl_prduration.Text = "Period Duration"
        Me.lbl_prduration.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_enddate
        '
        Me.lbl_enddate.AutoSize = False
        Me.lbl_enddate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_enddate.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_enddate.Location = New System.Drawing.Point(63, 183)
        Me.lbl_enddate.Name = "lbl_enddate"
        Me.lbl_enddate.Size = New System.Drawing.Size(87, 31)
        Me.lbl_enddate.TabIndex = 73
        Me.lbl_enddate.Text = "End Date"
        Me.lbl_enddate.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_notes
        '
        Me.txt_notes.BackColor = System.Drawing.Color.Transparent
        Me.txt_notes.BorderRadius = 10
        Me.txt_notes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_notes.DefaultText = ""
        Me.txt_notes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_notes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_notes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_notes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_notes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_notes.Font = New System.Drawing.Font("Sitka Banner", 18.0!)
        Me.txt_notes.ForeColor = System.Drawing.Color.Black
        Me.txt_notes.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_notes.Location = New System.Drawing.Point(166, 309)
        Me.txt_notes.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_notes.PlaceholderText = ""
        Me.txt_notes.SelectedText = ""
        Me.txt_notes.Size = New System.Drawing.Size(327, 191)
        Me.txt_notes.TabIndex = 72
        '
        'txt_prduration
        '
        Me.txt_prduration.BackColor = System.Drawing.Color.Transparent
        Me.txt_prduration.BorderRadius = 10
        Me.txt_prduration.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_prduration.DefaultText = ""
        Me.txt_prduration.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_prduration.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_prduration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_prduration.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_prduration.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_prduration.Font = New System.Drawing.Font("Sitka Banner", 18.0!)
        Me.txt_prduration.ForeColor = System.Drawing.Color.Black
        Me.txt_prduration.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_prduration.Location = New System.Drawing.Point(166, 236)
        Me.txt_prduration.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txt_prduration.Name = "txt_prduration"
        Me.txt_prduration.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_prduration.PlaceholderText = ""
        Me.txt_prduration.SelectedText = ""
        Me.txt_prduration.Size = New System.Drawing.Size(327, 57)
        Me.txt_prduration.TabIndex = 71
        '
        'datetmpick_end
        '
        Me.datetmpick_end.BackColor = System.Drawing.Color.Transparent
        Me.datetmpick_end.BorderRadius = 10
        Me.datetmpick_end.Checked = True
        Me.datetmpick_end.FillColor = System.Drawing.Color.White
        Me.datetmpick_end.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.datetmpick_end.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.datetmpick_end.Location = New System.Drawing.Point(166, 177)
        Me.datetmpick_end.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.datetmpick_end.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.datetmpick_end.Name = "datetmpick_end"
        Me.datetmpick_end.Size = New System.Drawing.Size(327, 45)
        Me.datetmpick_end.TabIndex = 70
        Me.datetmpick_end.Value = New Date(2024, 11, 24, 2, 20, 27, 767)
        '
        'datetmpick_start
        '
        Me.datetmpick_start.BackColor = System.Drawing.Color.Transparent
        Me.datetmpick_start.BorderRadius = 10
        Me.datetmpick_start.Checked = True
        Me.datetmpick_start.FillColor = System.Drawing.Color.White
        Me.datetmpick_start.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.datetmpick_start.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.datetmpick_start.Location = New System.Drawing.Point(166, 114)
        Me.datetmpick_start.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.datetmpick_start.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.datetmpick_start.Name = "datetmpick_start"
        Me.datetmpick_start.Size = New System.Drawing.Size(327, 45)
        Me.datetmpick_start.TabIndex = 69
        Me.datetmpick_start.Value = New Date(2024, 11, 24, 2, 20, 27, 767)
        '
        'lbl_startdate
        '
        Me.lbl_startdate.AutoSize = False
        Me.lbl_startdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_startdate.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_startdate.Location = New System.Drawing.Point(63, 119)
        Me.lbl_startdate.Name = "lbl_startdate"
        Me.lbl_startdate.Size = New System.Drawing.Size(87, 31)
        Me.lbl_startdate.TabIndex = 68
        Me.lbl_startdate.Text = "Start" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Date"
        Me.lbl_startdate.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_header
        '
        Me.lbl_header.BackColor = System.Drawing.Color.Transparent
        Me.lbl_header.Font = New System.Drawing.Font("Sitka Banner", 50.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_header.Location = New System.Drawing.Point(66, 0)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(415, 99)
        Me.lbl_header.TabIndex = 52
        Me.lbl_header.Text = "Period Records"
        Me.lbl_header.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Period_Records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 583)
        Me.Controls.Add(Me.pnl_record)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Period_Records"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Period_Records"
        Me.pnl_record.ResumeLayout(False)
        Me.pnl_record.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_record As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lbl_header As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_startdate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents datetmpick_end As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents datetmpick_start As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txt_notes As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_prduration As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_enddate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_notes As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_prduration As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_add As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_reset As Guna.UI2.WinForms.Guna2Button
End Class
