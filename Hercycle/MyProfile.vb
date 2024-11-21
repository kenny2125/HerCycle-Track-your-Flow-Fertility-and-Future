Class MyProfile



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Application.Exit()
    End Sub

    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        ' Reset shared properties to log out
        CurrentUser.UserId = 0
        LoginStatus.loginSuccess = False

        ' Hide all forms
        Dashboard.Hide()
        LogIn.Hide()
        Period_Records.Hide()
        SignUp.Hide()
        Me.Hide()

        ' Show the splash screen or login screen
        Splashscreen.Show()

        Dim confirmLogout As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmLogout = DialogResult.Yes Then
            CurrentUser.UserId = 0
            LoginStatus.loginSuccess = False
            Me.Hide()
            LogIn.Show()
        End If

    End Sub


    Private Sub MyProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class