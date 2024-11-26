Imports MySql.Data.MySqlClient

Public Class LogIn

    Private dbconnect As New dbconnect

    Public Event RecordAdded()
    Public Event UserLoggedIn()


    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnect.connect()
    End Sub


    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        ' Get the username and password
        Dim username As String = txt_username.Text ' Fixed order
        Dim password As String = txt_password.Text

        Try
            ' Ensure the database connection is open
            Dim dbconnect As New dbconnect
            dbconnect.connect()

            ' SQL query to check if the username and password match in the database
            Dim query As String = "SELECT user_id FROM tbl_user WHERE username = @username AND password = @password"
            Using cmd As New MySqlCommand(query, dbconnect.conn)
                ' Parameterized query to prevent SQL injection
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                ' Execute query and check for matches
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        reader.Read() ' Read the first row
                        Dim userId As Integer = reader.GetInt32("user_id") ' Get the user_id from the result

                        MsgBox("Login Successful", MsgBoxStyle.Information)

                        ' Store user ID in a static class or variable for global access
                        CurrentUser.UserId = userId ' Set the current user ID

                        ' Show the dashboard and close splashscreen
                        Dashboard.Show()
                        Splashscreen.Close()
                        Me.Hide()
                    Else
                        MsgBox("Login Failed. Invalid username or password.", MsgBoxStyle.Critical)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("An error occurred during login: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub






    Private Sub linklbl_create_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklbl_create.LinkClicked
        SignUp.Show()
        Me.Hide()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_usernamefield_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub

    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged
        If Guna2ToggleSwitch1.Checked Then
            txt_password.PasswordChar = ""
        Else
            txt_password.PasswordChar = "*"c
        End If
    End Sub
End Class

' Create a static class to hold the current user's information

