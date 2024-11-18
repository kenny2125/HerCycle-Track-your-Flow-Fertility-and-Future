Imports MySql.Data.MySqlClient

Public Class Period_Records
    ' Assuming you have a way to get the logged-in user's ID, for example from a session or global variable
    Private currentUserId As Integer = CurrentUser.UserId

    Private Sub Period_Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        Try
            Dim dbconnect As New dbconnect
            dbconnect.connect()


            ' Prepare the SQL insert statement
            Dim query As String = "INSERT INTO tbl_records (user_id, date, datestart, dateend, duration, notes) VALUES (@userid, @date, @datestart, @dateend, @duration, @notes)"
            Using cmd As New MySqlCommand(query, dbconnect.conn)
                ' Add parameters with the parsed dates
                cmd.Parameters.AddWithValue("@userid", currentUserId)
                cmd.Parameters.AddWithValue("@datestart", Guna2DateTimePicker2.Value.Date) ' Use the parsed start date
                cmd.Parameters.AddWithValue("@dateend", Guna2DateTimePicker3.Value.Date) ' Use the parsed end date
                cmd.Parameters.AddWithValue("@duration", Convert.ToInt32(TextBox4.Text)) ' Assuming TextBox4 is an integer
                cmd.Parameters.AddWithValue("@notes", TextBox5.Text) ' Assuming TextBox5 is for notes

                ' Execute the command
                cmd.ExecuteNonQuery()

            End Using

            MessageBox.Show("Successfully Inserted")


        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class
