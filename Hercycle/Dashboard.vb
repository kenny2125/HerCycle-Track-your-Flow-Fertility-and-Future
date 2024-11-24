Imports MySql.Data.MySqlClient

Public Class Dashboard

    Private currentUserId As Integer = CurrentUser.UserId
    Public Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserRecords()
        LoadName()
        'MessageBox.Show("Current User ID: " & currentUserId.ToString())
        If Not IsAnswered() Then
            PreScreening.Show()
        End If

        CalculateAverageDuration() ' Call the function to calculate average duration

    End Sub

    Private Sub LoadUserRecords()
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


            gridview_tracker.DataSource = dt

            ' Set column headers
            gridview_tracker.Columns("records_id").HeaderText = "Record ID"
            gridview_tracker.Columns("date_added").HeaderText = "Date Added"
            gridview_tracker.Columns("datestart").HeaderText = "Date Started"
            gridview_tracker.Columns("dateend").HeaderText = "Date Ended"
            gridview_tracker.Columns("duration").HeaderText = "Period Duration"
            gridview_tracker.Columns("notes").HeaderText = "Notes"

            ' Set visibility of columns if necessary
            gridview_tracker.Columns("records_id").Visible = True
            gridview_tracker.Columns("date_added").Visible = True
        Else
            MessageBox.Show("No records found for the current user.")
        End If

        ' Clean up
        reader.Close()
        dbconnect.conn.Close() ' Ensure the connection is closed after use
    End Sub



    Private Sub ChangeGridViewFont()
        ' Change the font of the DataGridView
        Dim newFont As New Font("Sitka Banner", 12, FontStyle.Bold)
        gridview_tracker.Font = newFont
        gridview_tracker.ColumnHeadersDefaultCellStyle.Font = newFont
    End Sub

    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        Dim periodRecordsForm As New Period_Records()
        AddHandler periodRecordsForm.RecordAdded, AddressOf RefreshDashboard
        periodRecordsForm.Show()

    End Sub


    Private Sub RefreshDashboard()
        LoadUserRecords() ' Refresh the DataGridView
    End Sub



    Private Sub LoadName()
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        Try
            ' Query to get first name and last name for the current user
            Dim query As String = "SELECT firstname, lastname FROM tbl_user WHERE user_ID = @user_ID"
            Dim cmd As New MySqlCommand(query, dbconnect.conn)
            cmd.Parameters.AddWithValue("@user_ID", CurrentUser.UserId)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                ' Concatenate first name and last name
                Dim fullName As String = $"{reader("firstname")} {reader("lastname")}"
                lbl_profname.Text = fullName
            Else
                lbl_profname.Text = "User not found"
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading user name: " & ex.Message)
        Finally
            dbconnect.conn.Close()
        End Try
    End Sub


    Private Function IsAnswered() As Boolean
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        Try
            ' Query to check if the current user has answered set to 1
            Dim query As String = "SELECT answered FROM tbl_answers WHERE user_ID = @user_ID"
            Dim cmd As New MySqlCommand(query, dbconnect.conn)
            cmd.Parameters.AddWithValue("@user_ID", CurrentUser.UserId)

            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot DBNull.Value AndAlso Convert.ToInt32(result) = 1 Then
                Return True ' User has already answered
            End If
        Catch ex As Exception
            MessageBox.Show("Error checking answered status: " & ex.Message)
        Finally
            dbconnect.conn.Close()
        End Try

        Return False ' Default to false if no result or an error occurs
    End Function


    Private Sub picb_profile_Click(sender As Object, e As EventArgs) Handles picb_profile.Click
        MyProfile.Show()
    End Sub


    Private Sub CalculateAverageDuration()
        ' Connect to the database
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        ' Query to get the average duration of records for the current user
        Dim query As String = "SELECT AVG(duration) AS avg_duration FROM tbl_records WHERE user_id = @userId"
        Dim cmd As New MySqlCommand(query, dbconnect.conn)
        cmd.Parameters.AddWithValue("@userId", currentUserId)

        ' Execute the query and get the result
        Dim averageDuration As Object = cmd.ExecuteScalar()

        ' Check if a valid result is returned
        If averageDuration IsNot DBNull.Value Then
            Dim avgDuration As Integer = Convert.ToInt32(averageDuration)

            ' Display the average duration in lbl_phasedayno
            lbl_phasedayno.Text = avgDuration.ToString()

            ' Determine the phase based on the average duration and set lbl_phasesub
            If avgDuration >= 21 And avgDuration <= 35 Then
                lbl_phasesub.Text = "Regular"
            Else
                lbl_phasesub.Text = "Irregular"
            End If
        Else
            lbl_phasedayno.Text = "No data available"
            lbl_phasesub.Text = "N/A"
        End If

        ' Clean up
        dbconnect.conn.Close() ' Ensure the connection is closed after use
    End Sub

    Private Sub gridview_tracker_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridview_tracker.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim columnName As String = gridview_tracker.Columns(e.ColumnIndex).Name

            ' Optional: Restrict editing to specific columns
            If columnName <> "datestart" And columnName <> "dateend" And columnName <> "notes" Then
                MessageBox.Show("This column is not editable.")
            End If
        End If
    End Sub




    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        ' Save changes made in the DataGridView to the database
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        Try
            For Each row As DataGridViewRow In gridview_tracker.Rows
                If Not row.IsNewRow Then
                    ' Assuming you have columns for ID and the fields you want to update
                    Dim recordId As Integer = Convert.ToInt32(row.Cells("records_id").Value)

                    ' Parse datestart and dateend as DateTime, handling any potential empty or invalid values
                    Dim dateStart As DateTime
                    Dim dateEnd As DateTime

                    If DateTime.TryParse(row.Cells("datestart").Value?.ToString(), dateStart) Then
                        ' Valid dateStart
                    Else
                        ' Handle invalid or empty dateStart (e.g., assign a default value)
                        dateStart = DateTime.MinValue
                    End If

                    If DateTime.TryParse(row.Cells("dateend").Value?.ToString(), dateEnd) Then
                        ' Valid dateEnd
                    Else
                        ' Handle invalid or empty dateEnd (e.g., assign a default value)
                        dateEnd = DateTime.MinValue
                    End If

                    Dim duration As Integer = If(IsDBNull(row.Cells("duration").Value), 0, Convert.ToInt32(row.Cells("duration").Value))
                    Dim notes As String = row.Cells("notes").Value?.ToString() ?? String.Empty

' Update the database
Dim query As String = "UPDATE tbl_records SET datestart = @dateStart, dateend = @dateEnd, duration = @duration, notes = @notes WHERE records_id = @records_id"
                    Dim cmd As New MySqlCommand(query, dbconnect.conn)

                    cmd.Parameters.AddWithValue("@records_id", recordId)
                    cmd.Parameters.AddWithValue("@dateStart", dateStart.ToString("yyyy-MM-dd")) ' Convert DateTime to MySQL DATE format
                    cmd.Parameters.AddWithValue("@dateEnd", dateEnd.ToString("yyyy-MM-dd")) ' Convert DateTime to MySQL DATE format
                    cmd.Parameters.AddWithValue("@duration", duration)
                    cmd.Parameters.AddWithValue("@notes", notes)

                    cmd.ExecuteNonQuery()


                    cmd.ExecuteNonQuery()
                End If
            Next

            MessageBox.Show("Changes saved successfully.")
        Catch ex As Exception
            MessageBox.Show("Error saving changes: " & ex.Message)
        Finally
            dbconnect.conn.Close()
            gridview_tracker.ReadOnly = True ' Disable editing after saving
        End Try
    End Sub


    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        ' Enable editing mode for the DataGridView
        gridview_tracker.ReadOnly = False
        MessageBox.Show("Editing mode enabled. Click on a cell to edit.")
    End Sub
End Class
