Imports MySql.Data.MySqlClient

Public Class Period_Records
    ' Declare the duration globally
    Private duration As Integer

    Private currentUserId As Integer = CurrentUser.UserId

    Private Sub Period_Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Any initialization code here if needed
    End Sub

    Private Sub btn_addnew_Click(sender As Object, e As EventArgs)
        Try
            ' Ensure that duration is set correctly before attempting to insert
            If duration = 0 Then
                MessageBox.Show("Please calculate a valid duration.")
                Return
            End If

            ' Connect to the database
            Dim dbconnect As New dbconnect
            dbconnect.connect()

            ' Prepare the SQL insert statement
            Dim query As String = "INSERT INTO tbl_records (user_id, datestart, dateend, duration, notes) VALUES (@userid, @datestart, @dateend, @duration, @notes)"
            Using cmd As New MySqlCommand(query, dbconnect.conn)
                ' Add parameters with the parsed dates
                cmd.Parameters.AddWithValue("@userid", currentUserId)
                cmd.Parameters.AddWithValue("@datestart", datetmpick_start.Value.Date) ' Use the parsed start date
                cmd.Parameters.AddWithValue("@dateend", datetmpick_end.Value.Date) ' Use the parsed end date
                cmd.Parameters.AddWithValue("@duration", duration) ' Use the globally declared duration
                cmd.Parameters.AddWithValue("@notes", txt_notes.Text) ' Assuming TextBox5 is for notes

                ' Execute the command
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Successfully Inserted")

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Guna2DateTimePicker3_ValueChanged(sender As Object, e As EventArgs)
        CalculateDuration()
    End Sub

    Private Sub Guna2DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)
        CalculateDuration()
    End Sub

    Private Sub CalculateDuration()
        ' Check if both date pickers have valid dates
        If datetmpick_start.Value <= datetmpick_end.Value Then
            ' Calculate the difference in days
            duration = (datetmpick_end.Value - datetmpick_start.Value).Days
            txt_prduration.Text = duration.ToString() & " days"
        Else
            txt_prduration.Text = "Invalid date range"
        End If
    End Sub

    Private Sub lbl_subheader_Click(sender As Object, e As EventArgs) Handles lbl_startdate.Click

    End Sub

    Private Sub txt_givenname_TextChanged(sender As Object, e As EventArgs) Handles txt_prduration.TextChanged

    End Sub
End Class
