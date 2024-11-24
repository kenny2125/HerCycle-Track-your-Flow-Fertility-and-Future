<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _1
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
        Me.btn_yes = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_no = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'lbl_header
        '
        Me.lbl_header.BackColor = System.Drawing.Color.Transparent
        Me.lbl_header.Font = New System.Drawing.Font("Sitka Banner", 18.0!)
        Me.lbl_header.ForeColor = System.Drawing.Color.White
        Me.lbl_header.Location = New System.Drawing.Point(209, 12)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(229, 37)
        Me.lbl_header.TabIndex = 53
        Me.lbl_header.Text = "Pre-Screening Questions"
        '
        'lbl_subheader
        '
        Me.lbl_subheader.BackColor = System.Drawing.Color.Transparent
        Me.lbl_subheader.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_subheader.ForeColor = System.Drawing.Color.White
        Me.lbl_subheader.Location = New System.Drawing.Point(85, 55)
        Me.lbl_subheader.Name = "lbl_subheader"
        Me.lbl_subheader.Size = New System.Drawing.Size(474, 41)
        Me.lbl_subheader.TabIndex = 54
        Me.lbl_subheader.Text = "Are you going to use HerCycle for yourself?"
        '
        'btn_yes
        '
        Me.btn_yes.BorderRadius = 20
        Me.btn_yes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_yes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_yes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_yes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_yes.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btn_yes.Font = New System.Drawing.Font("Sitka Banner", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btn_yes.ForeColor = System.Drawing.Color.Black
        Me.btn_yes.Location = New System.Drawing.Point(262, 364)
        Me.btn_yes.Name = "btn_yes"
        Me.btn_yes.Size = New System.Drawing.Size(112, 41)
        Me.btn_yes.TabIndex = 55
        Me.btn_yes.Text = "Yes"
        Me.btn_yes.TextOffset = New System.Drawing.Point(0, -3)
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
        Me.btn_no.Location = New System.Drawing.Point(109, 417)
        Me.btn_no.Name = "btn_no"
        Me.btn_no.Size = New System.Drawing.Size(423, 41)
        Me.btn_no.TabIndex = 56
        Me.btn_no.Text = "No, I'm tracking for someone else"
        Me.btn_no.TextOffset = New System.Drawing.Point(3, -3)
        '
        '_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(648, 488)
        Me.Controls.Add(Me.btn_no)
        Me.Controls.Add(Me.btn_yes)
        Me.Controls.Add(Me.lbl_subheader)
        Me.Controls.Add(Me.lbl_header)
        Me.Name = "_1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "_1"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_header As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbl_subheader As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_yes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_no As Guna.UI2.WinForms.Guna2Button
End Class
