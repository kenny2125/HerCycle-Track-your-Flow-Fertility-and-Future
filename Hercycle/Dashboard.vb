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

        DisplayCurrentPeriod()
        CalculateNextMonthFollicular()
        CalculateNextMonthOvulation()
        CalculateNextMonthLuteal()
        CalculateNextMonthMenstruation()
        IdentifyCurrentCycleDay()
    End Sub


    Private Sub IdentifyCurrentCycleDay()
        ' Get today's date
        'Dim today As DateTime = New DateTime(2024, 12, 10) ' Hardcoded for testing, replace with DateTime.Today in production
        Dim today As DateTime = DateTime.Today

        ' Connect to the database
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        ' Query to get the most recent period data for the current user
        Dim query As String = "SELECT datestart, dateend FROM tbl_records WHERE user_id = @userId ORDER BY records_id DESC LIMIT 1"
        Dim cmd As New MySqlCommand(query, dbconnect.conn)
        cmd.Parameters.AddWithValue("@userId", currentUserId)

        ' Execute the query and load the result into a reader
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Declare variables to hold the start and end date of the most recent period
        Dim lastPeriodStart As DateTime = DateTime.MinValue
        Dim lastPeriodEnd As DateTime = DateTime.MinValue

        ' Fetch the most recent period's start and end date
        If reader.Read() Then
            lastPeriodStart = Convert.ToDateTime(reader("datestart"))
            lastPeriodEnd = Convert.ToDateTime(reader("dateend"))
        End If

        ' Close the reader
        reader.Close()

        ' Calculate the current cycle day
        If lastPeriodStart <> DateTime.MinValue AndAlso lastPeriodEnd <> DateTime.MinValue Then
            ' Calculate total cycle length from database if needed (e.g., for future use)
            Dim totalCycleLength As Integer = (lastPeriodEnd - lastPeriodStart).Days + 1

            ' Calculate the cycle day based on today's date
            Dim cycleDay As Integer = (today - lastPeriodStart).Days + 1 ' +1 to start from Day 1

            ' Ensure cycle day starts from Day 1
            If cycleDay < 1 Then
                lbl_cycleday.Text = "Day 1"
            Else
                lbl_cycleday.Text = "Day " & cycleDay.ToString()
            End If

            ' Check for the current phase and update lbl_periodtitle accordingly
            Dim phaseTitle As String = ""

            ' **Menstruation Phase**: if today is between the start and end of menstruation
            If today >= lastPeriodStart AndAlso today <= lastPeriodEnd Then
                phaseTitle = "Menstruation"
            Else
                ' **Follicular Phase**: if today is within 14 days after menstruation
                Dim follicularStart As DateTime = lastPeriodStart
                Dim follicularEnd As DateTime = follicularStart.AddDays(13) ' Assuming follicular phase lasts 14 days
                If today >= follicularStart AndAlso today <= follicularEnd Then
                    phaseTitle = "Follicular Phase"
                End If

                ' **Ovulation Phase**: If it's around the midpoint of the cycle (approximated)
                Dim ovulationStart As DateTime = follicularEnd.AddDays(1) ' Ovulation is expected around day 14-15
                Dim ovulationEnd As DateTime = ovulationStart.AddDays(1) ' Ovulation lasts a couple of days
                If today >= ovulationStart AndAlso today <= ovulationEnd Then
                    phaseTitle = "Ovulation"
                End If

                ' **Luteal Phase**: after ovulation, typically lasting 14 days
                Dim lutealStart As DateTime = ovulationEnd.AddDays(1)
                Dim lutealEnd As DateTime = lutealStart.AddDays(13) ' Luteal phase lasts approximately 14 days
                If today >= lutealStart AndAlso today <= lutealEnd Then
                    phaseTitle = "Luteal Phase"
                End If
            End If

            ' Update lbl_periodtitle based on the phase
            lbl_periodtitle.Text = phaseTitle

        Else
            lbl_cycleday.Text = "No data available for cycle."
        End If

        ' Clean up
        dbconnect.conn.Close()
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

        ' Query to get the relevant records for the current user, ordered by start date
        Dim query As String = "SELECT datestart, dateend FROM tbl_records WHERE user_id = @userId ORDER BY datestart"
        Dim cmd As New MySqlCommand(query, dbconnect.conn)
        cmd.Parameters.AddWithValue("@userId", currentUserId)

        ' Execute the query and get the result
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' List to store intervals between periods
        Dim cycleIntervals As New List(Of Integer)()

        ' Track the last period's end date
        Dim lastEndDate As DateTime? = Nothing

        ' Process each record
        While reader.Read()
            Dim startDate As DateTime = Convert.ToDateTime(reader("datestart"))
            Dim endDate As DateTime = Convert.ToDateTime(reader("dateend"))

            ' Calculate the interval between the end of the previous period and the start of the current period
            If lastEndDate.HasValue Then
                Dim interval As Integer = (startDate - lastEndDate.Value).Days
                cycleIntervals.Add(interval)
            End If

            ' Update the last end date
            lastEndDate = endDate
        End While

        ' Check if there are enough intervals to evaluate regularity
        If cycleIntervals.Count >= 2 Then ' At least two intervals are required to determine regularity
            ' Calculate the average and standard deviation of the intervals
            Dim averageInterval As Integer = CInt(cycleIntervals.Average())

            ' Determine if the cycle is regular based on intervals
            ' For example, if the interval is consistently between 24 and 38 days, it's regular
            If cycleIntervals.All(Function(i) i >= 24 And i <= 38) Then
                lbl_phasesub.Text = "Regular"
            Else
                lbl_phasesub.Text = "Irregular"
            End If

            ' Display the average interval
            lbl_phasedayno.Text = averageInterval.ToString()
        Else
            lbl_phasedayno.Text = "|"
            lbl_phasesub.Text = "Insufficient data"
        End If

        ' Clean up
        reader.Close()
        dbconnect.conn.Close() ' Ensure the connection is closed after use
    End Sub

    Private Sub CalculateNextMonthMenstruation()
        ' Connect to the database
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        ' Query to get the most recent period data for the current user
        Dim query As String = "SELECT datestart, dateend FROM tbl_records WHERE user_id = @userId ORDER BY records_id DESC LIMIT 1"
        Dim cmd As New MySqlCommand(query, dbconnect.conn)
        cmd.Parameters.AddWithValue("@userId", currentUserId)

        ' Execute the query and load the result into a reader
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Declare variables to hold the start and end date of the most recent period
        Dim lastPeriodEnd As DateTime = DateTime.MinValue

        ' Fetch the most recent period's end date
        If reader.Read() Then
            lastPeriodEnd = Convert.ToDateTime(reader("dateend"))
        End If

        ' Close the reader
        reader.Close()

        ' Get the cycle length from lbl_phasedayno (assuming it contains the average cycle length in days)
        Dim cycleLength As Integer
        If Integer.TryParse(lbl_phasedayno.Text, cycleLength) Then
            ' If the cycle length is valid, proceed with the calculation
            If lastPeriodEnd <> DateTime.MinValue Then
                ' Calculate the next menstruation start date using the cycle length
                Dim nextMenstruationStart As DateTime = lastPeriodEnd.AddDays(cycleLength) ' Add cycle length days for the next cycle

                ' Calculate the end date for the next menstruation phase (Assume 5-day period length)
                Dim nextMenstruationEnd As DateTime = nextMenstruationStart.AddDays(4) ' Assuming 5 days menstruation duration

                ' Check if the projected menstruation period is within the next month (December)
                If nextMenstruationStart.Month = 12 Then
                    lbl_menstruationval.Text = nextMenstruationStart.ToString("MM/dd/yyyy") & " - " & nextMenstruationEnd.ToString("MM/dd/yyyy")
                Else
                    lbl_menstruationval.Text = "is not in December."
                End If
            Else
                lbl_menstruationval.Text = "No data available to calculate next menstruation phase."
            End If
        Else
            lbl_menstruationval.Text = "Invalid cycle length value."
        End If

        ' Clean up
        dbconnect.conn.Close()
    End Sub


    Private Sub CalculateNextMonthFollicular()
        ' Get the most recent menstruation data for the user (highest records_id)
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        ' Query to get the most recent menstruation data (based on records_id)
        Dim query As String = "SELECT datestart, dateend, duration FROM tbl_records WHERE user_id = @userId ORDER BY records_id DESC LIMIT 1"
        Dim cmd As New MySqlCommand(query, dbconnect.conn)
        cmd.Parameters.AddWithValue("@userId", currentUserId)

        ' Execute the query and get the result
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Dim menstruationStart As DateTime = reader.GetDateTime("datestart")
            Dim menstruationEnd As DateTime = reader.GetDateTime("dateend")
            Dim cycleDuration As Integer = reader.GetInt32("duration")

            ' Project the next menstruation start date by adding the cycle duration to the current menstruation start date
            Dim nextMenstruationStart As DateTime = menstruationStart.AddDays(cycleDuration) ' Add cycle duration for next month

            ' Calculate the Follicular Phase: Starts on the next menstruation day and lasts until ovulation
            ' Assuming the Follicular Phase lasts 14 days
            Dim follicularPhaseEnd As DateTime = nextMenstruationStart.AddDays(13) ' 14 days for the follicular phase

            ' Display the projected Follicular Phase in the label
            lbl_follicularval.Text = nextMenstruationStart.ToString("MM/dd/yyyy") & " - " & follicularPhaseEnd.ToString("MM/dd/yyyy")
        Else
            ' Handle case where there is no data for menstruation
            lbl_follicularval.Text = "No menstruation data found."
        End If

        reader.Close()
        dbconnect.conn.Close()
    End Sub


    Private Sub CalculateNextMonthOvulation()
        ' Connect to the database
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        ' Query to get the most recent menstruation data (based on records_id)
        Dim query As String = "SELECT datestart, dateend FROM tbl_records WHERE user_id = @userId ORDER BY records_id DESC LIMIT 1"
        Dim cmd As New MySqlCommand(query, dbconnect.conn)
        cmd.Parameters.AddWithValue("@userId", currentUserId)

        ' Execute the query and get the result
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Dim menstruationEnd As DateTime = reader.GetDateTime("dateend")
            Dim cycleAverage As Integer = Integer.Parse(lbl_phasedayno.Text) ' Use average cycle duration from lbl_phasedayno

            ' Calculate the projected next menstruation start date
            Dim nextMenstruationStart As DateTime = menstruationEnd.AddDays(cycleAverage)

            ' Calculate ovulation range (10–14 days before next menstruation start)
            Dim ovulationStart As DateTime = nextMenstruationStart.AddDays(-14)
            Dim ovulationEnd As DateTime = nextMenstruationStart.AddDays(-10)

            ' Display the ovulation range
            lbl_ovulationval.Text = ovulationStart.ToString("MM/dd/yyyy") & " - " & ovulationEnd.ToString("MM/dd/yyyy")
        Else
            ' Handle case where there is no data for menstruation
            lbl_ovulationval.Text = "No menstruation data found."
        End If

        reader.Close()
        dbconnect.conn.Close()
    End Sub

    Private Sub CalculateNextMonthLuteal()
        ' Connect to the database
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        ' Query to get the most recent menstruation data (based on records_id)
        Dim query As String = "SELECT datestart, dateend FROM tbl_records WHERE user_id = @userId ORDER BY records_id DESC LIMIT 1"
        Dim cmd As New MySqlCommand(query, dbconnect.conn)
        cmd.Parameters.AddWithValue("@userId", currentUserId)

        ' Execute the query and get the result
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Dim menstruationEnd As DateTime = reader.GetDateTime("dateend")
            Dim cycleAverage As Integer = Integer.Parse(lbl_phasedayno.Text) ' Use average cycle duration from lbl_phasedayno

            ' Calculate the projected next menstruation start date
            Dim nextMenstruationStart As DateTime = menstruationEnd.AddDays(cycleAverage)

            ' Calculate luteal phase range
            Dim lutealPhaseStart As DateTime = nextMenstruationStart.AddDays(-9) ' Luteal phase starts 9 days before menstruation
            Dim lutealPhaseEnd As DateTime = nextMenstruationStart.AddDays(-1)  ' Ends the day before menstruation

            ' Display the luteal phase range
            lbl_lutealval.Text = lutealPhaseStart.ToString("MM/dd/yyyy") & " - " & lutealPhaseEnd.ToString("MM/dd/yyyy")
        Else
            ' Handle case where there is no data for menstruation
            lbl_lutealval.Text = "No menstruation data found."
        End If

        reader.Close()
        dbconnect.conn.Close()
    End Sub


    Private Sub DisplayCurrentPeriod()
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        Try
            ' Query to get the most recent period data for the current user
            Dim query As String = "SELECT datestart, dateend FROM tbl_records WHERE user_id = @userId ORDER BY records_id DESC LIMIT 1"
            Dim cmd As New MySqlCommand(query, dbconnect.conn)
            cmd.Parameters.AddWithValue("@userId", currentUserId)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim startDate As DateTime = Convert.ToDateTime(reader("datestart"))
                Dim endDate As DateTime = Convert.ToDateTime(reader("dateend"))
                lbl_currentperiod.Text = startDate.ToString("MM/dd/yyyy") & " - " & endDate.ToString("MM/dd/yyyy")
            Else
                lbl_currentperiod.Text = "No current period data found."
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading current period data: " & ex.Message)
        Finally
            dbconnect.conn.Close()
        End Try
    End Sub

    Private Sub lbl_period_Click(sender As Object, e As EventArgs) Handles lbl_period.Click
        IdentifyCurrentCycleDay()
    End Sub
End Class
