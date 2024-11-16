Imports MySql.Data.MySqlClient

Public Class LogIn

    Private dbconnect As New dbconnect

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnect.connect()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' Get the username and password
        Dim username As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text

        ' SQL query to check if the username and password matched from the database
        Dim query As String = "SELECT user_id FROM tbl_user WHERE username = @username AND password = @password"

        Using cmd As New MySqlCommand(query, dbconnect.conn)
            cmd.Parameters.AddWithValue("@username", username) ' Parameterized query to prevent SQL injection
            cmd.Parameters.AddWithValue("@password", password)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                reader.Read() ' Read the first row
                Dim userId As Integer = reader.GetInt32("user_id") ' Get the user_id from the result

                MsgBox("Login Success")

                ' Store user ID in a static class or variable for global access
                CurrentUser.UserId = userId

                Dashboard.Show()
                Me.Hide()
                Splashscreen.Hide()
            Else
                MsgBox("Login Failed")
            End If
        End Using
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        SignUp.Show()
        Me.Hide()
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

' Create a static class to hold the current user's information
Public Class CurrentUser
    Public Shared Property UserId As Integer
End Class
