Imports MySql.Data.MySqlClient
Public Class SignUp

    Private Sub Label12_Click(sender As Object, e As EventArgs)
        LogIn.Show()
        Me.Hide()
    End Sub


    Private Sub btn_signup_Click(sender As Object, e As EventArgs)
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
            cmd.Parameters.AddWithValue("@gender", cmbox_gender.Text)
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

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles pnl_signup.Paint

    End Sub

    Private Sub txt_email_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbl_surname_Click(sender As Object, e As EventArgs) Handles lbl_surname.Click

    End Sub

    Private Sub txt_age_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel4_Click(sender As Object, e As EventArgs) Handles lbl_middleint.Click

    End Sub

    Private Sub Guna2HtmlLabel5_Click(sender As Object, e As EventArgs) Handles lbl_email.Click

    End Sub

    Private Sub Guna2HtmlLabel7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbox_gender_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txt_usernamefield_TextChanged(sender As Object, e As EventArgs) Handles txt_surname.TextChanged

    End Sub

    Private Sub Guna2HtmlLabel7_Click_1(sender As Object, e As EventArgs) Handles lbl_birthdate.Click

    End Sub

    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txt_email.TextChanged

    End Sub
End Class