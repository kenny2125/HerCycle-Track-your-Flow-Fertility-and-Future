Imports MySql.Data.MySqlClient
Public Class SignUp

    Private Sub Label12_Click(sender As Object, e As EventArgs)
        LogIn.Show()
        Me.Hide()
    End Sub

    Private Sub btn_signup_Click_1(sender As Object, e As EventArgs) Handles btn_signup.Click
        Try
            Dim dbconnect As New dbconnect
            dbconnect.connect()

            Dim query As String = "INSERT INTO tbl_user (firstname, middleinitial, lastname, email, age, gender, username, password) VALUES (@firstname, @middleinitial, @lastname, @email, @age, @gender, @username, @password)"
            Dim cmd As New MySqlCommand(query, dbconnect.conn)
            cmd.Parameters.AddWithValue("@firstname", txt_givenname.Text)
            cmd.Parameters.AddWithValue("@middleinitial", txt_middleint.Text)
            cmd.Parameters.AddWithValue("@lastname", txt_surname.Text)
            cmd.Parameters.AddWithValue("@email", txt_email.Text)
            cmd.Parameters.AddWithValue("@age", txt_age.Text)
            cmd.Parameters.AddWithValue("@username", txt_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("User successfully registered")
            LogIn.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class