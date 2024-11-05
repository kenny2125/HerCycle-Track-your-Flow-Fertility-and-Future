Imports MySql.Data.MySqlClient
Public Class SignUp

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        LogIn.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim dbconnect As New dbconnect
            dbconnect.connect()

            Dim query As String = "INSERT INTO tbl_user (firstname, middleinitial, lastname, email, age, gender, username, password) VALUES (@firstname, @middleinitial, @lastname, @email, @age, @gender, @username, @password)"
            Dim cmd As New MySqlCommand(query, dbconnect.conn)
            cmd.Parameters.AddWithValue("@firstname", txb_firstname.Text)
            cmd.Parameters.AddWithValue("@middleinitial", txb_MI.Text)
            cmd.Parameters.AddWithValue("@lastname", txb_surname.Text)
            cmd.Parameters.AddWithValue("@email", txb_email.Text)
            cmd.Parameters.AddWithValue("@age", txb_age.Text)
            cmd.Parameters.AddWithValue("@gender", txb_gender)
            cmd.Parameters.AddWithValue("@username", txb_username.Text)
            cmd.Parameters.AddWithValue("@password", txb_password.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("User successfully registered")
            LogIn.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class