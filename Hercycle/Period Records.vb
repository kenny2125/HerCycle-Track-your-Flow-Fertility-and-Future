Imports MySql.Data.MySqlClient

Public Class Period_Records
    ' Declare the duration globally
    Private duration As Integer

    Private currentUserId As Integer = CurrentUser.UserId

    Public Event RecordAdded()

    Private Sub Period_Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_duration.Visible = False
        btn_add.Text = "Save Record"
        lbl_dateadded.Text = DateTime.Now.ToString("MM/dd/yyyy")
        datetmpick_start.Text = DateTime.Now
        datetmpick_end.Text = DateTime.Now

        ' Bring the form to the front

        Me.BringToFront()
        Me.Activate()
        Me.BringToFront()
        Me.Activate()
        Me.BringToFront()
        Me.Activate()

    End Sub
    Private Sub CalculateDuration()
        ' Check if both date pickers have valid dates
        If datetmpick_start.Value <= datetmpick_end.Value Then
            ' Calculate the difference in days
            duration = (datetmpick_end.Value - datetmpick_start.Value).Days
            lbl_duration.Text = duration.ToString() & " days"
            lbl_duration.Visible = True
            'btn_add.Text = "Save Record"
        Else
            lbl_duration.Text = "Invalid date range"
            lbl_duration.Visible = True
            'btn_add.Text = "Save Record"
        End If
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        ' Reset the date pickers to the current date
        datetmpick_start.Value = DateTime.Now
        datetmpick_end.Value = DateTime.Now
        btn_add.Text = "Save Record"
        lbl_recordID.Visible = False
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
            ' Ensure that duration is set correctly before proceeding
            If duration = 0 Then
                MessageBox.Show("Please calculate a valid duration.")
                Return
            End If

            ' Call the appropriate method based on the button text
            If btn_add.Text = "Save Record" Then
                SaveRecord()
            ElseIf btn_add.Text = "Update Record" Then
                UpdateRecord()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub SaveRecord()
        Try
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

            MessageBox.Show("Record successfully saved.")
            RaiseEvent RecordAdded() ' Raise the event to notify the parent form
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateRecord()
        Try
            ' Ensure a record is selected
            If String.IsNullOrEmpty(lbl_recordID.Text) Then
                MessageBox.Show("No record selected to update.")
                Return
            End If

            ' Convert lbl_recordID.Text to Integer
            Dim recordId As Integer = Convert.ToInt32(lbl_recordID.Text)

            ' Connect to the database
            Dim dbconnect As New dbconnect
            dbconnect.connect()

            ' Prepare the SQL update statement
            Dim query As String = "UPDATE tbl_records SET datestart = @datestart, dateend = @dateend, duration = @duration, notes = @notes WHERE records_id = @recordId"
            Using cmd As New MySqlCommand(query, dbconnect.conn)
                ' Add parameters with the parsed dates and record ID
                cmd.Parameters.AddWithValue("@datestart", datetmpick_start.Value.Date)
                cmd.Parameters.AddWithValue("@dateend", datetmpick_end.Value.Date)
                cmd.Parameters.AddWithValue("@duration", duration)
                cmd.Parameters.AddWithValue("@notes", txt_notes.Text)
                cmd.Parameters.AddWithValue("@recordId", recordId) ' Use the converted Integer value

                ' Execute the command
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Output the result
                If rowsAffected > 0 Then
                    MessageBox.Show($"Record with ID {recordId} successfully updated.")
                    RaiseEvent RecordAdded() ' Raise the event to notify the parent form
                Else
                    MessageBox.Show("No changes were made. Please verify the record exists.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating: " & ex.Message)
        End Try
    End Sub



    Private Sub datetmpick_start_ValueChanged(sender As Object, e As EventArgs) Handles datetmpick_start.ValueChanged
        CalculateDuration()

    End Sub

    Private Sub datetmpick_end_ValueChanged(sender As Object, e As EventArgs) Handles datetmpick_end.ValueChanged
        CalculateDuration()


    End Sub



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            ' Connect to the database
            Dim dbconnect As New dbconnect
            dbconnect.connect()

            ' Query to count records for the current user
            Dim query As String = "SELECT COUNT(*) FROM tbl_records WHERE user_id = @userId"
            Dim cmd As New MySqlCommand(query, dbconnect.conn)
            cmd.Parameters.AddWithValue("@userId", currentUserId)

            ' Execute the query and retrieve the count
            Dim recordCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Check if the user has at least two records
            If recordCount < 2 Then
                MessageBox.Show("You need to add more records before closing.", "Insufficient Records", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Me.Close() ' Close the form if the condition is met
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
        btn_add.Text = "Update Record"
        ' Load data into a DataTable
        Dim dt As New DataTable
        dt.Load(reader)
        If dt.Rows.Count > 0 Then
            ' Check if there are more records to display
            If currentRecordIndex > 0 Then
                currentRecordIndex -= 1
                Dim currentRecord As DataRow = dt.Rows(currentRecordIndex)

                ' Update labels and textboxes with the record's data

                lbl_recordID.Visible = True
                lbl_recordID.Text = currentRecord("records_id").ToString()
                datetmpick_start.Value = Convert.ToDateTime(currentRecord("datestart"))
                datetmpick_end.Value = Convert.ToDateTime(currentRecord("dateend"))
                lbl_duration.Text = currentRecord("duration").ToString() & " days"
                lbl_duration.Visible = True
                txt_notes.Text = currentRecord("notes").ToString()
                lbl_dateadded.Text = Convert.ToDateTime(currentRecord("date_added")).ToString("MM/dd/yyyy")
            Else
                MessageBox.Show("You are already at the first record.")
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

        ' Load data into a DataTable
        Dim dt As New DataTable
        dt.Load(reader)

        If dt.Rows.Count > 0 Then
            ' Check if there are more records to display
            If currentRecordIndex < dt.Rows.Count - 1 Then
                currentRecordIndex += 1
                Dim currentRecord As DataRow = dt.Rows(currentRecordIndex)

                ' Update labels and textboxes with the record's data
                btn_add.Text = "Update Record"
                lbl_recordID.Visible = True
                lbl_recordID.Text = currentRecord("records_id").ToString()
                datetmpick_start.Value = Convert.ToDateTime(currentRecord("datestart"))
                datetmpick_end.Value = Convert.ToDateTime(currentRecord("dateend"))
                lbl_duration.Text = currentRecord("duration").ToString() & " days"
                lbl_duration.Visible = True
                txt_notes.Text = currentRecord("notes").ToString()
                lbl_dateadded.Text = Convert.ToDateTime(currentRecord("date_added")).ToString("MM/dd/yyyy")
            Else
                MessageBox.Show("You are already at the last record.")
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

            ' Convert lbl_recordID.Text to Integer
            Dim recordId As Integer = Convert.ToInt32(lbl_recordID.Text)

            ' Connect to the database
            Dim dbconnect As New dbconnect
            dbconnect.connect()

            ' Prepare the SQL delete statement
            Dim query As String = "DELETE FROM tbl_records WHERE records_id = @recordId"
            Using cmd As New MySqlCommand(query, dbconnect.conn)
                ' Add parameter with the record ID
                cmd.Parameters.AddWithValue("@recordId", recordId)

                ' Execute the command
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Output result
                If rowsAffected > 0 Then
                    MessageBox.Show("Record successfully deleted.")
                    RaiseEvent RecordAdded() ' Raise the event to notify the parent form
                Else
                    MessageBox.Show("No record found with the given ID.")
                End If
            End Using

            ' Reset the form
            btn_reset_Click(sender, e)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub


End Class
