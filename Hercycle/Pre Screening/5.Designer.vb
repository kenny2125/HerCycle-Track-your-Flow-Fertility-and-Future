<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class _5
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
        Me.lbl_header = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnl_message = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lbl_message = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btn_start = New Guna.UI2.WinForms.Guna2Button()
        Me.pnl_message.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_header
        '
        Me.lbl_header.BackColor = System.Drawing.Color.Transparent
        Me.lbl_header.Font = New System.Drawing.Font("Sitka Banner", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_header.ForeColor = System.Drawing.Color.White
        Me.lbl_header.Location = New System.Drawing.Point(222, 47)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(179, 60)
        Me.lbl_header.TabIndex = 52
        Me.lbl_header.Text = "Well done!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pnl_message
        '
        Me.pnl_message.BorderRadius = 20
        Me.pnl_message.Controls.Add(Me.lbl_message)
        Me.pnl_message.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.pnl_message.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.pnl_message.Location = New System.Drawing.Point(52, 136)
        Me.pnl_message.Name = "pnl_message"
        Me.pnl_message.Size = New System.Drawing.Size(535, 194)
        Me.pnl_message.TabIndex = 54
        '
        'lbl_message
        '
        Me.lbl_message.AutoSize = False
        Me.lbl_message.BackColor = System.Drawing.Color.Transparent
        Me.lbl_message.Font = New System.Drawing.Font("Sitka Banner", 18.0!)
        Me.lbl_message.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_message.Location = New System.Drawing.Point(23, 6)
        Me.lbl_message.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_message.Name = "lbl_message"
        Me.lbl_message.Size = New System.Drawing.Size(488, 168)
        Me.lbl_message.TabIndex = 54
        Me.lbl_message.Text = "Thank you for answering the pre-screening questions! You can now start adding rec" &
    "ords to track your flow."
        Me.lbl_message.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_start.Location = New System.Drawing.Point(209, 353)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(211, 71)
        Me.btn_start.TabIndex = 55
        Me.btn_start.Text = "Start"
        Me.btn_start.TextOffset = New System.Drawing.Point(0, -3)
        '
        '_5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(648, 480)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.pnl_message)
        Me.Controls.Add(Me.lbl_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "_5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "_5"
        Me.TopMost = True
        Me.pnl_message.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_header As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnl_message As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lbl_message As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_start As Guna.UI2.WinForms.Guna2Button
End Class
