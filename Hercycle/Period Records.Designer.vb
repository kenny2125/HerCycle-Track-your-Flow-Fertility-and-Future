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
        Me.components = New System.ComponentModel.Container()
        Me.pnl_record = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.datetmpick_start = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.datetmpick_end = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_dateadded = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_recordID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_duration = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_add = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_reset = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_notes = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_prduration = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_enddate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txt_notes = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_startdate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_header = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.pnl_record.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl_record
        '
        Me.pnl_record.BackColor = System.Drawing.Color.Transparent
        Me.pnl_record.Controls.Add(Me.Guna2HtmlLabel3)
        Me.pnl_record.Controls.Add(Me.datetmpick_start)
        Me.pnl_record.Controls.Add(Me.datetmpick_end)
        Me.pnl_record.Controls.Add(Me.Guna2HtmlLabel2)
        Me.pnl_record.Controls.Add(Me.lbl_dateadded)
        Me.pnl_record.Controls.Add(Me.lbl_recordID)
        Me.pnl_record.Controls.Add(Me.Guna2HtmlLabel1)
        Me.pnl_record.Controls.Add(Me.Guna2Button4)
        Me.pnl_record.Controls.Add(Me.Guna2Button2)
        Me.pnl_record.Controls.Add(Me.Guna2Button3)
        Me.pnl_record.Controls.Add(Me.Guna2Button1)
        Me.pnl_record.Controls.Add(Me.lbl_duration)
        Me.pnl_record.Controls.Add(Me.btn_add)
        Me.pnl_record.Controls.Add(Me.btn_reset)
        Me.pnl_record.Controls.Add(Me.lbl_notes)
        Me.pnl_record.Controls.Add(Me.lbl_prduration)
        Me.pnl_record.Controls.Add(Me.lbl_enddate)
        Me.pnl_record.Controls.Add(Me.txt_notes)
        Me.pnl_record.Controls.Add(Me.lbl_startdate)
        Me.pnl_record.Controls.Add(Me.lbl_header)
        Me.pnl_record.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pnl_record.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.pnl_record.Location = New System.Drawing.Point(-2, 0)
        Me.pnl_record.Name = "pnl_record"
        Me.pnl_record.Size = New System.Drawing.Size(550, 509)
        Me.pnl_record.TabIndex = 6
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.AutoSize = False
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(80, 92)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(374, 50)
        Me.Guna2HtmlLabel3.TabIndex = 87
        Me.Guna2HtmlLabel3.Text = "Add atleast two consecutive previous records of menstruation "
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.Guna2HtmlLabel3.Visible = False
        '
        'datetmpick_start
        '
        Me.datetmpick_start.Animated = True
        Me.datetmpick_start.AutoRoundedCorners = True
        Me.datetmpick_start.BackColor = System.Drawing.Color.Transparent
        Me.datetmpick_start.BorderRadius = 21
        Me.datetmpick_start.Checked = True
        Me.datetmpick_start.FillColor = System.Drawing.Color.White
        Me.datetmpick_start.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.datetmpick_start.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetmpick_start.IndicateFocus = True
        Me.datetmpick_start.Location = New System.Drawing.Point(50, 166)
        Me.datetmpick_start.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.datetmpick_start.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.datetmpick_start.Name = "datetmpick_start"
        Me.datetmpick_start.Size = New System.Drawing.Size(146, 45)
        Me.datetmpick_start.TabIndex = 69
        Me.datetmpick_start.Value = New Date(2024, 11, 24, 2, 20, 27, 767)
        '
        'datetmpick_end
        '
        Me.datetmpick_end.Animated = True
        Me.datetmpick_end.AutoRoundedCorners = True
        Me.datetmpick_end.BackColor = System.Drawing.Color.Transparent
        Me.datetmpick_end.BorderRadius = 21
        Me.datetmpick_end.Checked = True
        Me.datetmpick_end.FillColor = System.Drawing.Color.White
        Me.datetmpick_end.Font = New System.Drawing.Font("Sitka Banner", 15.0!)
        Me.datetmpick_end.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetmpick_end.IndicateFocus = True
        Me.datetmpick_end.Location = New System.Drawing.Point(332, 166)
        Me.datetmpick_end.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.datetmpick_end.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.datetmpick_end.Name = "datetmpick_end"
        Me.datetmpick_end.Size = New System.Drawing.Size(146, 45)
        Me.datetmpick_end.TabIndex = 70
        Me.datetmpick_end.Value = New Date(2024, 11, 24, 2, 20, 27, 767)
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(50, 224)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(107, 31)
        Me.Guna2HtmlLabel2.TabIndex = 86
        Me.Guna2HtmlLabel2.Text = "Date Added"
        '
        'lbl_dateadded
        '
        Me.lbl_dateadded.AutoSize = False
        Me.lbl_dateadded.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dateadded.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dateadded.Location = New System.Drawing.Point(50, 261)
        Me.lbl_dateadded.Name = "lbl_dateadded"
        Me.lbl_dateadded.Size = New System.Drawing.Size(124, 31)
        Me.lbl_dateadded.TabIndex = 85
        Me.lbl_dateadded.Text = "lbl_dateadded"
        '
        'lbl_recordID
        '
        Me.lbl_recordID.AutoSize = False
        Me.lbl_recordID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_recordID.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_recordID.Location = New System.Drawing.Point(50, 335)
        Me.lbl_recordID.Name = "lbl_recordID"
        Me.lbl_recordID.Size = New System.Drawing.Size(87, 31)
        Me.lbl_recordID.TabIndex = 84
        Me.lbl_recordID.Text = "Record_ID"
        Me.lbl_recordID.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_recordID.Visible = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(50, 298)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(87, 31)
        Me.Guna2HtmlLabel1.TabIndex = 83
        Me.Guna2HtmlLabel1.Text = "Record_ID"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2Button4
        '
        Me.Guna2Button4.BorderRadius = 6
        Me.Guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Guna2Button4.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Location = New System.Drawing.Point(50, 371)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(171, 43)
        Me.Guna2Button4.TabIndex = 82
        Me.Guna2Button4.Text = "Delete"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 6
        Me.Guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(376, 420)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(102, 43)
        Me.Guna2Button2.TabIndex = 81
        Me.Guna2Button2.Text = "Next"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BorderRadius = 6
        Me.Guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(249, 420)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(121, 43)
        Me.Guna2Button3.TabIndex = 80
        Me.Guna2Button3.Text = "Previous"
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
        Me.Guna2Button1.Font = New System.Drawing.Font("Sylfaen", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(494, 12)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(43, 43)
        Me.Guna2Button1.TabIndex = 79
        Me.Guna2Button1.Text = "X"
        '
        'lbl_duration
        '
        Me.lbl_duration.AutoSize = False
        Me.lbl_duration.BackColor = System.Drawing.Color.Transparent
        Me.lbl_duration.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_duration.Location = New System.Drawing.Point(192, 166)
        Me.lbl_duration.Name = "lbl_duration"
        Me.lbl_duration.Size = New System.Drawing.Size(150, 31)
        Me.lbl_duration.TabIndex = 78
        Me.lbl_duration.Text = "5"
        Me.lbl_duration.TextAlignment = System.Drawing.ContentAlignment.TopCenter
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
        Me.btn_add.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Location = New System.Drawing.Point(249, 371)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(229, 43)
        Me.btn_add.TabIndex = 77
        Me.btn_add.Text = "Save Record"
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
        Me.btn_reset.Font = New System.Drawing.Font("Sylfaen", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.ForeColor = System.Drawing.Color.White
        Me.btn_reset.Location = New System.Drawing.Point(50, 420)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(171, 43)
        Me.btn_reset.TabIndex = 76
        Me.btn_reset.Text = "Reset"
        '
        'lbl_notes
        '
        Me.lbl_notes.AutoSize = False
        Me.lbl_notes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_notes.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_notes.Location = New System.Drawing.Point(304, 224)
        Me.lbl_notes.Name = "lbl_notes"
        Me.lbl_notes.Size = New System.Drawing.Size(54, 33)
        Me.lbl_notes.TabIndex = 75
        Me.lbl_notes.Text = "Notes"
        '
        'lbl_prduration
        '
        Me.lbl_prduration.AutoSize = False
        Me.lbl_prduration.BackColor = System.Drawing.Color.Transparent
        Me.lbl_prduration.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prduration.Location = New System.Drawing.Point(186, 129)
        Me.lbl_prduration.Name = "lbl_prduration"
        Me.lbl_prduration.Size = New System.Drawing.Size(162, 31)
        Me.lbl_prduration.TabIndex = 74
        Me.lbl_prduration.Text = "Period Duration"
        Me.lbl_prduration.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_enddate
        '
        Me.lbl_enddate.AutoSize = False
        Me.lbl_enddate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_enddate.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_enddate.Location = New System.Drawing.Point(362, 129)
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
        Me.txt_notes.Font = New System.Drawing.Font("Lucida Sans", 12.0!)
        Me.txt_notes.ForeColor = System.Drawing.Color.Black
        Me.txt_notes.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_notes.Location = New System.Drawing.Point(192, 261)
        Me.txt_notes.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_notes.PlaceholderText = ""
        Me.txt_notes.SelectedText = ""
        Me.txt_notes.Size = New System.Drawing.Size(286, 100)
        Me.txt_notes.TabIndex = 72
        '
        'lbl_startdate
        '
        Me.lbl_startdate.AutoSize = False
        Me.lbl_startdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_startdate.Font = New System.Drawing.Font("Sitka Banner", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_startdate.Location = New System.Drawing.Point(80, 129)
        Me.lbl_startdate.Name = "lbl_startdate"
        Me.lbl_startdate.Size = New System.Drawing.Size(87, 31)
        Me.lbl_startdate.TabIndex = 68
        Me.lbl_startdate.Text = "Start" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Date"
        Me.lbl_startdate.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_header
        '
        Me.lbl_header.BackColor = System.Drawing.Color.Transparent
        Me.lbl_header.Font = New System.Drawing.Font("Sitka Banner", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_header.Location = New System.Drawing.Point(118, 27)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(298, 71)
        Me.lbl_header.TabIndex = 52
        Me.lbl_header.Text = "Period Records"
        Me.lbl_header.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 20
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Period_Records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 503)
        Me.Controls.Add(Me.pnl_record)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
    Friend WithEvents lbl_enddate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_notes As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_prduration As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_add As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_reset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents lbl_duration As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_recordID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_dateadded As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
