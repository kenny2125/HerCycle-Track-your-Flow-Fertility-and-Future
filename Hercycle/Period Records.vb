Imports MySql.Data.MySqlClient

Public Class Period_Records
    ' Declare the duration globally
    Private duration As Integer

    Private currentUserId As Integer = CurrentUser.UserId

    Public Event RecordAdded()


    Private Sub CalculateDuration()
        ' Check if both date pickers have valid dates
        If datetmpick_start.Value <= datetmpick_end.Value Then
            ' Calculate the difference in days
            duration = (datetmpick_end.Value - datetmpick_start.Value).Days
            lbl_duration.Text = duration.ToString() & " days"
            lbl_duration.Visible = True
        Else
            lbl_duration.Text = "Invalid date range"
            lbl_duration.Visible = True
        End If
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        ' Reset the date pickers to the current date
        datetmpick_start.Value = DateTime.Now
        datetmpick_end.Value = DateTime.Now

        ' Hide the duration label
        lbl_duration.Visible = False

        ' Clear the notes textbox
        txt_notes.Clear()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
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
            RaiseEvent RecordAdded() ' Raise the event to notify the parent form

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub datetmpick_start_ValueChanged(sender As Object, e As EventArgs) Handles datetmpick_start.ValueChanged
        CalculateDuration()
    End Sub

    Private Sub datetmpick_end_ValueChanged(sender As Object, e As EventArgs) Handles datetmpick_end.ValueChanged
        CalculateDuration()
    End Sub

    Private Sub Period_Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_duration.Visible = False
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub lbl_header_Click(sender As Object, e As EventArgs) Handles lbl_header.Click

    End Sub
End Class
