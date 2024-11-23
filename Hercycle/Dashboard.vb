Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class Dashboard

    Private currentUserId As Integer = CurrentUser.UserId

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Period_Records.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs)
        ' Show periods record
        Period_Records.Show()
        Me.Hide()
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
            Guna2DataGridView1.DataSource = dt

            ' Hide the first two columns
            If Guna2DataGridView1.Columns.Count > 1 Then
                Guna2DataGridView1.Columns(0).Visible = False
                Guna2DataGridView1.Columns(1).Visible = False
            End If
        Else
            MessageBox.Show("No records found for the current user.")
        End If

        ' Clean up
        reader.Close()
        dbconnect.conn.Close() ' Ensure the connection is closed after use
    End Sub

    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        Period_Records.Show()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserRecords()
        PreScreening.Show()
        CalculateAverageDuration() ' Call the function to calculate average duration
    End Sub

    Private Sub picb_profile_Click(sender As Object, e As EventArgs) Handles picb_profile.Click
        MyProfile.Show()
    End Sub

    Private Sub lbl_phasedayno_Click(sender As Object, e As EventArgs) Handles lbl_phasedayno.Click

    End Sub

    Private Sub lbl_phasesub_Click(sender As Object, e As EventArgs) Handles lbl_phasesub.Click

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

    Private Sub lbl_greet_Click(sender As Object, e As EventArgs) Handles lbl_name.Click

    End Sub

    Private Sub pnl_editprof_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub lbl_phase_Click(sender As Object, e As EventArgs) Handles lbl_phase.Click

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub lbl_phaseday_Click(sender As Object, e As EventArgs) Handles lbl_phaseday.Click

    End Sub

    Private Sub lbl_phaseheader_Click(sender As Object, e As EventArgs) Handles lbl_phaseheader.Click

    End Sub

    Private Sub pnl_dashboardbg_Paint(sender As Object, e As PaintEventArgs) Handles pnl_dashboardbg.Paint

    End Sub

    Private Sub lbl_dailydigest_Click(sender As Object, e As EventArgs) Handles lbl_dailydigest.Click

    End Sub

    Private Sub linklbl_details_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklbl_details.LinkClicked

    End Sub

    Private Sub lbl_periodtracker_Click(sender As Object, e As EventArgs) Handles lbl_periodtracker.Click

    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub gridview_tracker_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridview_tracker.CellContentClick

    End Sub
End Class
