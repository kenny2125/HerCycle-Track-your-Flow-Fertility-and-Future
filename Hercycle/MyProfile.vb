Imports MySql.Data.MySqlClient

Public Class MyProfile

    Private currentUserId As Integer = CurrentUser.UserId

    Private db As New dbconnect()
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Application.Exit()
    End Sub
    Private Sub MyProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load user data for labels 1-6
        LoadUserData()

        ' Load answer data for labels 7-10 based on the current logged-in user
        LoadAnswerData()
    End Sub

    Private Sub LoadUserData()
        ' Ensure connection is open
        db.connect()

        ' SQL query to get user data (assuming fields: name, email, etc. in tbl_user)
        Dim query As String = "SELECT firstname, middleinitial, lastname, email, gender, username, password FROM tbl_user WHERE user_ID = @user_ID"

        ' Use the connection object from DbConnect class
        Using cmd As New MySqlCommand(query, db.conn)
            cmd.Parameters.AddWithValue("@user_ID", currentUserId)

            Try
                ' Execute the query and read data
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Concatenate the first and last name for label1
                        txt_name.Text = reader("firstname").ToString() & " " & reader("middleinitial").ToString() & reader("lastname").ToString()
                        ' Set other labels with user data
                        txt_email.Text = reader("email").ToString()
                        txt_username.Text = reader("username").ToString()
                        txt_birthdate.Text = reader("password").ToString()
                        txt_age.Text = reader("age").ToString()


                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadAnswerData()
        ' Ensure connection is open
        db.connect()

        ' SQL query to get the answers based on user ID
        Dim query As String = "SELECT Q1, Q2, Q3, Q4 FROM tbl_answers WHERE user_ID = @user_ID"

        ' Use the connection object from DbConnect class
        Using cmd As New MySqlCommand(query, db.conn)
            cmd.Parameters.AddWithValue("@user_ID", currentUserId)

            Try
                ' Execute the query and read data
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Set labels for Q1 to Q4 from tbl_answers
                        lbl_ans1.Text = reader("Q1").ToString()
                        lbl_ans2.Text = reader("Q2").ToString()
                        lbl_ans3.Text = reader("Q3").ToString()
                        lbl_ans4.Text = reader("Q4").ToString()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        ' Reset the current user ID to 0
        CurrentUser.UserId = 0

        ' Optionally, you can show a message confirming the reset
        MessageBox.Show("User session reset. Please log in again.", "Session Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Open the login form or the form where the user will log in again
        LogIn.Show()

        ' Hide the current form instead of closing it
        Me.Hide()
        Dashboard.Hide()



        ' Alternatively, you can dispose the form explicitly to free up resources
        ' Me.Dispose()
    End Sub

    Private Sub lbl_header_Click(sender As Object, e As EventArgs) Handles lbl_header.Click

    End Sub

    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txt_birthdate.TextChanged

    End Sub

    Private Sub Guna2HtmlLabel5_Click(sender As Object, e As EventArgs) Handles lbl_age.Click

    End Sub

    Private Sub Guna2HtmlLabel4_Click(sender As Object, e As EventArgs) Handles lbl_birthdate.Click

    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub

    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged

    End Sub

    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs) Handles lbl_password.Click

    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles lbl_username.Click

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_email.TextChanged

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles lbl_email.Click

    End Sub

    Private Sub txt_passwordfield_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged

    End Sub

    Private Sub lbl_givenname_Click(sender As Object, e As EventArgs) Handles lbl_name.Click

    End Sub

    Private Sub Guna2TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txt_age.TextChanged

    End Sub

    Private Sub Guna2HtmlLabel10_Click(sender As Object, e As EventArgs) Handles lbl_ques4.Click

    End Sub

    Private Sub Guna2HtmlLabel11_Click(sender As Object, e As EventArgs) Handles lbl_ans1.Click

    End Sub
End Class
