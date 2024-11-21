<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Period_Records
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
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.btn_addnew = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DateTimePicker2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2DateTimePicker3 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(192, 345)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(284, 50)
        Me.TextBox5.TabIndex = 7
        '
        'btn_addnew
        '
        Me.btn_addnew.BorderRadius = 6
        Me.btn_addnew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addnew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_addnew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_addnew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_addnew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_addnew.FillColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.btn_addnew.Font = New System.Drawing.Font("Sitka Text", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addnew.ForeColor = System.Drawing.Color.White
        Me.btn_addnew.Location = New System.Drawing.Point(320, 502)
        Me.btn_addnew.Name = "btn_addnew"
        Me.btn_addnew.Size = New System.Drawing.Size(156, 32)
        Me.btn_addnew.TabIndex = 20
        Me.btn_addnew.Text = "Save Record"
        '
        'Guna2DateTimePicker2
        '
        Me.Guna2DateTimePicker2.Checked = True
        Me.Guna2DateTimePicker2.FillColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker2.Location = New System.Drawing.Point(192, 136)
        Me.Guna2DateTimePicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker2.Name = "Guna2DateTimePicker2"
        Me.Guna2DateTimePicker2.Size = New System.Drawing.Size(259, 36)
        Me.Guna2DateTimePicker2.TabIndex = 22
        Me.Guna2DateTimePicker2.Value = New Date(2024, 11, 18, 19, 4, 13, 189)
        '
        'Guna2DateTimePicker3
        '
        Me.Guna2DateTimePicker3.Checked = True
        Me.Guna2DateTimePicker3.FillColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker3.Location = New System.Drawing.Point(192, 203)
        Me.Guna2DateTimePicker3.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker3.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker3.Name = "Guna2DateTimePicker3"
        Me.Guna2DateTimePicker3.Size = New System.Drawing.Size(259, 36)
        Me.Guna2DateTimePicker3.TabIndex = 23
        Me.Guna2DateTimePicker3.Value = New Date(2024, 11, 18, 19, 4, 13, 189)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Hercycle.My.Resources.Resources.Frame_10
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(552, 592)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'TextBox4
        '
        Me.TextBox4.AutoSize = True
        Me.TextBox4.Location = New System.Drawing.Point(189, 282)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(39, 13)
        Me.TextBox4.TabIndex = 24
        Me.TextBox4.Text = "Label1"
        '
        'Period_Records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 583)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Guna2DateTimePicker3)
        Me.Controls.Add(Me.Guna2DateTimePicker2)
        Me.Controls.Add(Me.btn_addnew)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Period_Records"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Period_Records"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_addnew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DateTimePicker2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2DateTimePicker3 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents TextBox4 As Label
End Class
