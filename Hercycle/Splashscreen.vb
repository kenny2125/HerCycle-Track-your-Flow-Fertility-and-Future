Public Class Splashscreen
    Private Sub Splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pictureBox As New PictureBox()
        pictureBox.Image = Image.FromFile("C:\Users\GameWorks\source\repos\Hercycle\Hercycle\Splashscreen Form.jpg")
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox.Dock = DockStyle.Fill
        Me.Controls.Add(pictureBox)
    End Sub
End Class