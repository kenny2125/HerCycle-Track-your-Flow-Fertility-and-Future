Imports MySql.Data.MySqlClient
Public Class SignUp
    Private Function ValidateInputsAndUniqueness() As Boolean
        ' Check if all fields are filled
        If String.IsNullOrWhiteSpace(txt_givenname.Text) OrElse
       String.IsNullOrWhiteSpace(txt_surname.Text) OrElse
       String.IsNullOrWhiteSpace(txt_middleint.Text) OrElse
       String.IsNullOrWhiteSpace(txt_email.Text) OrElse
       String.IsNullOrWhiteSpace(txt_username.Text) OrElse
       String.IsNullOrWhiteSpace(txt_password.Text) OrElse
       String.IsNullOrWhiteSpace(txt_cnfirmpassword.Text) Then
            MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Check if lbl_agevalue is visible (filled)
        If Not lbl_agevalue.Visible Then
            MessageBox.Show("Please select a valid birthdate to calculate your age.", "Missing Age", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Validate if passwords match
        If txt_password.Text <> txt_cnfirmpassword.Text Then
            MessageBox.Show("Passwords do not match. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Validate password strength
        If txt_password.Text.Length < 8 Then
            MessageBox.Show("Password must be at least 8 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        ' Check if username or password already exists in the database
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        Try
            Dim query As String = "SELECT COUNT(*) FROM tbl_user WHERE username = @username OR password = @password"
            Dim cmd As New MySqlCommand(query, dbconnect.conn)
            cmd.Parameters.AddWithValue("@username", txt_username.Text)
            cmd.Parameters.AddWithValue("@password", txt_password.Text)

            Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If result > 0 Then
                MessageBox.Show("Username or password already exists. Please choose a different one.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking uniqueness: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            dbconnect.conn.Close()
        End Try

        ' All validations passed
        Return True
    End Function



    Private Sub btn_signup_Click_1(sender As Object, e As EventArgs) Handles btn_signup.Click
        If ValidateInputsAndUniqueness() Then
            Try
                ' Proceed with database insertion
                Dim dbconnect As New dbconnect
                dbconnect.connect()

                Dim query As String = "INSERT INTO tbl_user (firstname, middleinitial, lastname, email, age, birthdate, username, password) VALUES (@firstname, @middleinitial, @lastname, @email, @age, @birthdate, @username, @password)"
                Dim cmd As New MySqlCommand(query, dbconnect.conn)
                cmd.Parameters.AddWithValue("@firstname", txt_givenname.Text)
                cmd.Parameters.AddWithValue("@middleinitial", txt_middleint.Text)
                cmd.Parameters.AddWithValue("@lastname", txt_surname.Text)
                cmd.Parameters.AddWithValue("@email", txt_email.Text)
                cmd.Parameters.AddWithValue("@age", lbl_agevalue.Text)
                cmd.Parameters.AddWithValue("@birthdate", datetmpick_birthdate.Value.Date)
                cmd.Parameters.AddWithValue("@username", txt_username.Text)
                cmd.Parameters.AddWithValue("@password", txt_password.Text)

                cmd.ExecuteNonQuery()

                MessageBox.Show("User successfully registered.", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LogIn.Show()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



    Private Sub linklbl_login_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklbl_login.LinkClicked
        LogIn.Show()
        Me.Hide()
    End Sub

    Private Sub datetmpick_birthdate_ValueChanged(sender As Object, e As EventArgs) Handles datetmpick_birthdate.ValueChanged
        Try
            Dim birthdate As DateTime = datetmpick_birthdate.Value
            Dim today As DateTime = DateTime.Today
            Dim age As Integer = today.Year - birthdate.Year
            If birthdate > today.AddYears(-age) Then age -= 1
            lbl_agevalue.Text = age.ToString()
            lbl_agevalue.Visible = True
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_agevalue.Visible = False
        datetmpick_birthdate.MaxDate = DateTime.Today ' Prevent selecting future dates
    End Sub

    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged
        If Guna2ToggleSwitch1.Checked Then
            txt_password.PasswordChar = ""
        Else
            txt_password.PasswordChar = "*"c
        End If
    End Sub

    Private Sub Guna2ToggleSwitch2_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch2.CheckedChanged
        If Guna2ToggleSwitch2.Checked Then
            txt_cnfirmpassword.PasswordChar = ""
        Else
            txt_cnfirmpassword.PasswordChar = "*"c
        End If
    End Sub

    Private Sub pnl_signup_Paint(sender As Object, e As PaintEventArgs) Handles pnl_signup.Paint

    End Sub
End Class