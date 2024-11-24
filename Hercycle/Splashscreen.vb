Public Class Splashscreen
    Private Sub Splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim pictureBox As New PictureBox()

        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox.Dock = DockStyle.Fill
        Me.Controls.Add(pictureBox)



    End Sub


    Private Sub btn_getstarted_Click(sender As Object, e As EventArgs) Handles btn_getstarted.Click
        LogIn.Show()
    End Sub
End Class