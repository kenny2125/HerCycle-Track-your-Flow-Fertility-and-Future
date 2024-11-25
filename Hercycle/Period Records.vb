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
            btn_add.Text = "Save Record"
        Else
            lbl_duration.Text = "Invalid date range"
            lbl_duration.Visible = True
            btn_add.Text = "Save Record"
        End If
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        ' Reset the date pickers to the current date
        datetmpick_start.Value = DateTime.Now
        datetmpick_end.Value = DateTime.Now

        ' Hide the duration label
        lbl_duration.Visible = False
        lbl_dateadded.Text = DateTime.Now.ToString("MM/dd/yyyy")

        ' Clear the notes textbox
        txt_notes.Clear()
        currentRecordIndex = 0 ' Reset the index if no more records
    End Sub

    Private currentRecordIndex As Integer = 0





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
        btn_add.Text = "Save Record"


    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub lbl_header_Click(sender As Object, e As EventArgs) Handles lbl_header.Click

    End Sub

    Private Sub txt_notes_TextChanged(sender As Object, e As EventArgs) Handles txt_notes.TextChanged

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Prev_LoadUserRecords()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Next_LoadUserRecords()
    End Sub

    Private Sub Prev_LoadUserRecords()
        ' Load the data from tbl_records for the current user
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        ' Explicitly select columns to ensure records_id is included
        Dim query As String = "SELECT records_id, date_added, datestart, dateend, duration, notes FROM tbl_records WHERE user_id = @userId"
        Dim cmd As New MySqlCommand(query, dbconnect.conn)
        cmd.Parameters.AddWithValue("@userId", currentUserId) ' Use the current user's ID

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Show on the DataGridView
        If reader.HasRows Then
            Dim dt As New DataTable
            dt.Load(reader)

            ' Check if there are more records to display
            If currentRecordIndex < dt.Rows.Count Then
                Dim currentRecord As DataRow = dt.Rows(currentRecordIndex)
                Dim currentRecordDuration As Integer = Convert.ToInt32(currentRecord("duration"))

                ' Update lbl_recordID, datestarted, dateended, and txt_notes
                lbl_recordID.Text = currentRecord("records_id").ToString()
                datetmpick_start.Text = Convert.ToDateTime(currentRecord("datestart")).ToString("MM/dd/yyyy")
                datetmpick_end.Text = Convert.ToDateTime(currentRecord("dateend")).ToString("MM/dd/yyyy")
                lbl_duration.Text = currentRecordDuration.ToString() & " days"
                lbl_duration.Visible = True
                txt_notes.Text = currentRecord("notes").ToString() ' Load the notes into the TextBox
                lbl_dateadded.Text = currentRecord("date_added").ToString() ' Load the notes into the TextBox

                ' Increment the record index for the next call
                currentRecordIndex += -1
            Else
                MessageBox.Show("No more records found for the current user.")
                currentRecordIndex = 0 ' Reset the index if no more records
            End If
        Else
            MessageBox.Show("No records found for the current user.")
        End If

        ' Clean up
        reader.Close()
        dbconnect.conn.Close() ' Ensure the connection is closed after use

    End Sub



    Private Sub Next_LoadUserRecords()
        ' Load the data from tbl_records for the current user
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        ' Explicitly select columns to ensure records_id is included
        Dim query As String = "SELECT records_id, date_added, datestart, dateend, duration, notes FROM tbl_records WHERE user_id = @userId"
        Dim cmd As New MySqlCommand(query, dbconnect.conn)
        cmd.Parameters.AddWithValue("@userId", currentUserId) ' Use the current user's ID

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Show on the DataGridView
        If reader.HasRows Then
            Dim dt As New DataTable
            dt.Load(reader)

            ' Check if there are more records to display
            If currentRecordIndex < dt.Rows.Count Then
                Dim currentRecord As DataRow = dt.Rows(currentRecordIndex)
                Dim currentRecordDuration As Integer = Convert.ToInt32(currentRecord("duration"))

                ' Update lbl_recordID, datestarted, dateended, and txt_notes
                lbl_recordID.Text = currentRecord("records_id").ToString()
                datetmpick_start.Text = Convert.ToDateTime(currentRecord("datestart")).ToString("MM/dd/yyyy")
                datetmpick_end.Text = Convert.ToDateTime(currentRecord("dateend")).ToString("MM/dd/yyyy")
                lbl_duration.Text = currentRecordDuration.ToString() & " days"
                lbl_duration.Visible = True
                txt_notes.Text = currentRecord("notes").ToString() ' Load the notes into the TextBox
                lbl_dateadded.Text = currentRecord("date_added").ToString() ' Load the notes into the TextBox

                ' Increment the record index for the next call
                currentRecordIndex += 1
            Else
                MessageBox.Show("No more records found for the current user.")
                currentRecordIndex = 0 ' Reset the index if no more records
            End If
        Else
            MessageBox.Show("No records found for the current user.")
        End If

        ' Clean up
        reader.Close()
        dbconnect.conn.Close() ' Ensure the connection is closed after use
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Try
            ' Ensure that a record is selected
            If String.IsNullOrEmpty(lbl_recordID.Text) Then
                MessageBox.Show("No record selected to delete.")
                Return
            End If

            ' Confirm deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Return
            End If

            ' Connect to the database
            Dim dbconnect As New dbconnect
            dbconnect.connect()

            ' Prepare the SQL delete statement
            Dim query As String = "DELETE FROM tbl_records WHERE records_id = @recordId"
            Using cmd As New MySqlCommand(query, dbconnect.conn)
                ' Add parameter with the record ID
                cmd.Parameters.AddWithValue("@recordId", lbl_recordID.Text)

                ' Execute the command
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Record successfully deleted.")
            RaiseEvent RecordAdded() ' Raise the event to notify the parent form

            ' Reset the form
            btn_reset_Click(sender, e)

            ' Reset the currentRecordIndex
            currentRecordIndex = 0

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class
