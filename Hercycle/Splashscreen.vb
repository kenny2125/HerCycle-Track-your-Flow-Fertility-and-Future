Public Class Splashscreen
    Private Sub Splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim pictureBox As New PictureBox()

        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox.Dock = DockStyle.Fill
        Me.Controls.Add(pictureBox)

        'Dim dbconnect As New dbconnect
        'dbconnect.connect()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        LogIn.Show()

    End Sub
End Class