Imports MySql.Data.MySqlClient

Public Class Period_Records
    ' Assuming you have a way to get the logged-in user's ID, for example from a session or global variable
    Private currentUserId As Integer = CurrentUser.UserId

    Private Sub Period_Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserRecords()
    End Sub

    Private Sub LoadUserRecords()
        ' Load the data from tbl_records for the current user
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        ' Update the query to filter records by the current user's ID
        Dim query As String = "SELECT * FROM tbl_records WHERE user_id = @userId"
        Dim cmd As New MySqlCommand(query, dbconnect.conn)
        cmd.Parameters.AddWithValue("@userId", currentUserId) ' Use the current user's ID

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Show on the DataGridView
        If reader.HasRows Then
            Dim dt As New DataTable
            dt.Load(reader)
            DataGridView1.DataSource = dt
        Else
            MessageBox.Show("No records found for the current user.")
        End If

        ' Clean up
        reader.Close()
        dbconnect.conn.Close() ' Ensure the connection is closed after use
    End Sub

    Private Sub btnSaveRec_Click(sender As Object, e As EventArgs) Handles btnSaveRec.Click
        Try
            Dim dbconnect As New dbconnect
            dbconnect.connect()


            ' Prepare the SQL insert statement
            Dim query As String = "INSERT INTO tbl_records (user_id, date, datestart, dateend, duration, notes) VALUES (@userid, @date, @datestart, @dateend, @duration, @notes)"
            Using cmd As New MySqlCommand(query, dbconnect.conn)
                ' Add parameters with the parsed dates
                cmd.Parameters.AddWithValue("@userid", currentUserId)
                cmd.Parameters.AddWithValue("@date", DateTimePicker1.Value.Date) ' Use the parsed date
                cmd.Parameters.AddWithValue("@datestart", DateTimePicker2.Value.Date) ' Use the parsed start date
                cmd.Parameters.AddWithValue("@dateend", DateTimePicker3.Value.Date) ' Use the parsed end date
                cmd.Parameters.AddWithValue("@duration", Convert.ToInt32(TextBox4.Text)) ' Assuming TextBox4 is an integer
                cmd.Parameters.AddWithValue("@notes", TextBox5.Text) ' Assuming TextBox5 is for notes

                ' Execute the command
                cmd.ExecuteNonQuery()

            End Using

            MessageBox.Show("Successfully Inserted")
            LoadUserRecords() ' Reload the records after insertion

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class
