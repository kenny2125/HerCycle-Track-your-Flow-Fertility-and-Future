<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreScreening
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PreScreening))
        Me.btn_start = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_header = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbl_subheader = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_message = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lbl_message = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_message.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_start
        '
        Me.btn_start.BorderRadius = 20
        Me.btn_start.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_start.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_start.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btn_start.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btn_start.ForeColor = System.Drawing.Color.Black
        Me.btn_start.Location = New System.Drawing.Point(268, 436)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(112, 41)
        Me.btn_start.TabIndex = 1
        Me.btn_start.Text = "Start"
        Me.btn_start.TextOffset = New System.Drawing.Point(0, -3)
        '
        'lbl_header
        '
        Me.lbl_header.BackColor = System.Drawing.Color.Transparent
        Me.lbl_header.Font = New System.Drawing.Font("Sitka Banner", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_header.ForeColor = System.Drawing.Color.White
        Me.lbl_header.Location = New System.Drawing.Point(151, 12)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(332, 50)
        Me.lbl_header.TabIndex = 51
        Me.lbl_header.Text = "Hello there! Welcome to"
        '
        'lbl_subheader
        '
        Me.lbl_subheader.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subheader.Font = New System.Drawing.Font("Sitka Banner", 18.0!)
        Me.lbl_subheader.ForeColor = System.Drawing.Color.White
        Me.lbl_subheader.Location = New System.Drawing.Point(204, 242)
        Me.lbl_subheader.Name = "lbl_subheader"
        Me.lbl_subheader.Size = New System.Drawing.Size(229, 37)
        Me.lbl_subheader.TabIndex = 52
        Me.lbl_subheader.Text = "Pre-Screening Questions"
        '
        'pnl_message
        '
        Me.pnl_message.BorderRadius = 20
        Me.pnl_message.Controls.Add(Me.lbl_message)
        Me.pnl_message.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.pnl_message.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.pnl_message.Location = New System.Drawing.Point(79, 281)
        Me.pnl_message.Name = "pnl_message"
        Me.pnl_message.Size = New System.Drawing.Size(486, 149)
        Me.pnl_message.TabIndex = 53
        '
        'lbl_message
        '
        Me.lbl_message.AutoSize = False
        Me.lbl_message.BackColor = System.Drawing.Color.Transparent
        Me.lbl_message.Font = New System.Drawing.Font("Sitka Banner", 13.5!)
        Me.lbl_message.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_message.Location = New System.Drawing.Point(25, -11)
        Me.lbl_message.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_message.Name = "lbl_message"
        Me.lbl_message.Size = New System.Drawing.Size(435, 153)
        Me.lbl_message.TabIndex = 54
        Me.lbl_message.Text = resources.GetString("lbl_message.Text")
        Me.lbl_message.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PreScreening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(652, 489)
        Me.Controls.Add(Me.pnl_message)
        Me.Controls.Add(Me.lbl_subheader)
        Me.Controls.Add(Me.lbl_header)
        Me.Controls.Add(Me.btn_start)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "PreScreening"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PreScreening"
        Me.TopMost = True
        Me.pnl_message.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_start As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_header As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_subheader As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnl_message As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lbl_message As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
