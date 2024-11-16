Imports MySql.Data.MySqlClient
Public Class SignUp

    Private Sub Label12_Click(sender As Object, e As EventArgs)
        LogIn.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
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
            cmd.Parameters.AddWithValue("@gender", txb_gender)
            cmd.Parameters.AddWithValue("@username", txb_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("User successfully registered")
            LogIn.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles lbl_question.Click

    End Sub

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2HtmlLabel4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txb_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub

    Private Sub txb_username_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel6_Click_1(sender As Object, e As EventArgs) Handles lbl_password.Click

    End Sub

    Private Sub Guna2HtmlLabel12_Click(sender As Object, e As EventArgs)

    End Sub
End Class