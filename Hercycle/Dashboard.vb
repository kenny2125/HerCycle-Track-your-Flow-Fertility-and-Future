﻿Imports MySql.Data.MySqlClient

Public Class Dashboard

    Private currentUserId As Integer = CurrentUser.UserId
    Public Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDashboard()

        ' Handle PreScreening visibility
        If Not IsAnswered() Then
            PreScreening.Show()
        Else
            PreScreening.Close()
        End If

        ' Check if the user has any records


    End Sub
    Private Sub RefreshDashboard()

        LoadName()
        LoadUserRecords()

        IdentifyCurrentCycleDay()
        CalculateAverageDuration()
        UpdateFertilityWatcher()



        DisplayCurrentPeriod()
        CalculateNextPhases()


    End Sub
    Private Sub CalculateNextPhases()
        ' Connect to the database
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        ' Query to get the most recent menstruation data, sorted by date started
        Dim query As String = "SELECT datestart, dateend FROM tbl_records WHERE user_id = @userId ORDER BY datestart DESC LIMIT 1"
        Dim cmd As New MySqlCommand(query, dbconnect.conn)
        cmd.Parameters.AddWithValue("@userId", currentUserId)

        ' Execute the query and get the result
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Dim menstruationStart As DateTime = reader.GetDateTime("datestart")
            Dim menstruationEnd As DateTime = reader.GetDateTime("dateend")

            ' Get the cycle length from lbl_phasedayno
            Dim cycleLength As Integer
            If Integer.TryParse(lbl_phasedayno.Text, cycleLength) AndAlso cycleLength > 0 Then

                ' Calculate the next menstruation start date (start of the next cycle)
                Dim nextMenstruationStart As DateTime = menstruationEnd.AddDays(1) ' Start of follicular phase

                ' Calculate the follicular phase (12 days from menstruation start)
                Dim follicularPhaseEnd As DateTime = nextMenstruationStart.AddDays(cycleLength * 0.5 - 1) ' Half of cycle length
                lbl_follicularval.Text = nextMenstruationStart.ToString("MM/dd/yyyy") & " - " & follicularPhaseEnd.ToString("MM/dd/yyyy")

                ' Calculate the ovulation phase (typically around 1/3 of the cycle)
                Dim ovulationStart As DateTime = follicularPhaseEnd.AddDays(1) ' Ovulation starts right after follicular phase
                Dim ovulationEnd As DateTime = ovulationStart.AddDays(cycleLength * 0.17 - 1) ' Approx 1/3 of the cycle
                lbl_ovulationval.Text = ovulationStart.ToString("MM/dd/yyyy") & " - " & ovulationEnd.ToString("MM/dd/yyyy")

                ' Calculate the luteal phase (remaining days after ovulation)
                Dim lutealStart As DateTime = ovulationEnd.AddDays(1) ' Luteal phase starts right after ovulation
                Dim lutealEnd As DateTime = lutealStart.AddDays(cycleLength * 0.33 - 1) ' Remaining time in luteal phase
                lbl_lutealval.Text = lutealStart.ToString("MM/dd/yyyy") & " - " & lutealEnd.ToString("MM/dd/yyyy")

                ' Calculate the next menstruation phase (cycle length days from menstruation start)
                Dim nextMenstruationEnd As DateTime = lutealEnd.AddDays(1) ' Next menstruation starts right after luteal phase ends
                lbl_menstruationval.Text = nextMenstruationEnd.ToString("MM/dd/yyyy")

            Else
                ' Handle invalid or missing cycle length
                lbl_follicularval.Text = ""
                lbl_ovulationval.Text = ""
                lbl_lutealval.Text = ""
                lbl_menstruationval.Text = ""
            End If

        Else
            ' Handle case where there is no data for menstruation
            lbl_follicularval.Text = ""
            lbl_ovulationval.Text = ""
            lbl_lutealval.Text = ""
            lbl_menstruationval.Text = ""
        End If

        reader.Close()
        dbconnect.conn.Close()
    End Sub


    Private Sub CalculateAverageDuration()
        ' Connect to the database
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        ' Query to get the relevant records for the current user, ordered by start date
        Dim query As String = "SELECT datestart, dateend FROM tbl_records WHERE user_id = @userId ORDER BY YEAR(datestart), MONTH(datestart)"
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

        ' Check if there are intervals to evaluate
        If cycleIntervals.Count > 0 Then
            ' Calculate the average interval across all records
            Dim averageInterval As Integer = CInt(cycleIntervals.Average())

            ' Output the average interval
            lbl_phasedayno.Text = averageInterval.ToString()

            ' Determine if the cycle is regular based on intervals
            If cycleIntervals.All(Function(i) i >= 24 And i <= 38) Then
                lbl_phasesub.Text = "Regular"
            Else
                lbl_phasesub.Text = "Irregular"
            End If
        Else
            ' Handle the case with no records
            lbl_phasesub.Text = "No Data"
            lbl_phasedayno.Text = ""
        End If

        ' Clean up
        reader.Close()
        dbconnect.conn.Close() ' Ensure the connection is closed after use
    End Sub

    Private Sub LoadUserRecords()
        ' Load the data from tbl_records for the current user
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        ' Explicitly select columns to ensure records_id is included
        Dim query As String = "SELECT records_id, date_added, datestart, dateend, duration, notes FROM tbl_records WHERE user_id = @userId ORDER BY datestart"
        Dim cmd As New MySqlCommand(query, dbconnect.conn)
        cmd.Parameters.AddWithValue("@userId", currentUserId) ' Use the current user's ID

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Show on the DataGridView
        If reader.HasRows Then
            Dim dt As New DataTable
            dt.Load(reader)

            ' Sort the data table based on the calculated intervals (by `datestart`)
            ' Assume that `cycleIntervals` is a sorted list from the previous average calculation
            ' Applying the sort
            dt.DefaultView.Sort = "datestart ASC"

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
            'MessageBox.Show("No records found for the current user.")
        End If

        ' Clean up
        reader.Close()
        dbconnect.conn.Close() ' Ensure the connection is closed after use
    End Sub






    Public Sub UpdateCycleDayInfo(cycleDay As String)
        Select Case cycleDay
        ' **Menstrual Phase (Days 1-5)**
            Case "Day 1"
                lbl_dailydigestval.Text = "Cycle Day 1: Menstruation starts. Advice: Rest as the cycle begins. Use heat packs for cramps and hydrate well."
            Case "Day 2"
                lbl_dailydigestval.Text = "Cycle Day 2: Menstruation. Advice: Consume iron-rich foods (e.g., spinach, lentils) to replenish energy."
            Case "Day 3"
                lbl_dailydigestval.Text = "Cycle Day 3: Menstruation. Advice: Engage in light yoga or stretching to relieve menstrual discomfort."
            Case "Day 4"
                lbl_dailydigestval.Text = "Cycle Day 4: Menstruation. Advice: Monitor the flow for irregularities and continue self-care."
            Case "Day 5"
                lbl_dailydigestval.Text = "Cycle Day 5: Menstruation ends. Advice: Prepare for the follicular phase by focusing on balanced meals and hydration."

        ' **Follicular Phase (Days 6-13)**
            Case "Day 6"
                lbl_dailydigestval.Text = "Cycle Day 6: Low fertility. Advice: Begin tracking cervical mucus. Stay active with light exercise."
            Case "Day 7"
                lbl_dailydigestval.Text = "Cycle Day 7: Low fertility. Advice: Maintain a diet rich in protein and vitamins to support follicle development."
            Case "Day 8"
                lbl_dailydigestval.Text = "Cycle Day 8: Fertility begins to rise. Advice: Look for changes in cervical mucus (sticky texture)."
            Case "Day 9"
                lbl_dailydigestval.Text = "Cycle Day 9: Fertility rising. Advice: Stay hydrated and ensure sleep quality to support hormone production."
            Case "Day 10"
                lbl_dailydigestval.Text = "Cycle Day 10: High fertility. Advice: Fertility is high. Focus on reducing stress."
            Case "Day 11"
                lbl_dailydigestval.Text = "Cycle Day 11: High fertility. Advice: Engage in intercourse if trying to conceive. Limit caffeine and alcohol."
            Case "Day 12"
                lbl_dailydigestval.Text = "Cycle Day 12: High fertility. Advice: Maintain physical activity to promote blood circulation."
            Case "Day 13"
                lbl_dailydigestval.Text = "Cycle Day 13: Peak fertility. Advice: Prioritize intimacy if conception is the goal."

        ' **Ovulation Phase (Day 14)**
            Case "Day 14"
                lbl_dailydigestval.Text = "Cycle Day 14: Ovulation. Advice: Maximize this day for conception if desired. Avoid high-intensity stress and maintain hydration."

        ' **Luteal Phase (Days 15-28)**
            Case "Day 15"
                lbl_dailydigestval.Text = "Cycle Day 15: High fertility lingers briefly. Advice: Maintain hydration and monitor for ovulation-related cramping."
            Case "Day 16"
                lbl_dailydigestval.Text = "Cycle Day 16: Fertility declines. Advice: Focus on nutrient-dense foods like leafy greens and nuts."
            Case "Day 17"
                lbl_dailydigestval.Text = "Cycle Day 17: Low fertility. Advice: Consider light meditation to manage mood swings."
            Case "Day 18"
                lbl_dailydigestval.Text = "Cycle Day 18: Low fertility. Advice: Avoid overexertion. Include healthy fats (e.g., avocados) in your meals."
            Case "Day 19"
                lbl_dailydigestval.Text = "Cycle Day 19: Low fertility. Advice: Maintain stable blood sugar by eating small, frequent meals."
            Case "Day 20"
                lbl_dailydigestval.Text = "Cycle Day 20: Low fertility. Advice: Engage in light exercise, such as walking, to improve mood and circulation."
            Case "Day 21"
                lbl_dailydigestval.Text = "Cycle Day 21: If conception occurred, implantation may begin. Advice: Avoid alcohol or smoking."
            Case "Day 22"
                lbl_dailydigestval.Text = "Cycle Day 22: Low fertility. Advice: Combat bloating with water-rich foods like cucumber."
            Case "Day 23"
                lbl_dailydigestval.Text = "Cycle Day 23: PMS symptoms may appear. Advice: Include magnesium-rich foods (e.g., dark chocolate) to ease cramps or irritability."
            Case "Day 24"
                lbl_dailydigestval.Text = "Cycle Day 24: Low fertility. Advice: Prioritize sleep to manage fatigue and hormonal changes."
            Case "Day 25"
                lbl_dailydigestval.Text = "Cycle Day 25: PMS symptoms may increase. Advice: Practice mindfulness to alleviate stress or anxiety."
            Case "Day 26"
                lbl_dailydigestval.Text = "Cycle Day 26: PMS symptoms may worsen. Advice: Focus on gentle stretches and a calming routine."
            Case "Day 27"
                lbl_dailydigestval.Text = "Cycle Day 27: Prepare for menstruation. Advice: Avoid salty foods to reduce bloating."
            Case "Day 28"
                lbl_dailydigestval.Text = "Cycle Day 28: End of cycle. Advice: Monitor for menstrual onset. Take a pregnancy test if trying to conceive and there’s a delay."

        ' **Days 29-31 (If cycle extends beyond 28 days)**
            Case "Day 29"
                lbl_dailydigestval.Text = "Cycle Day 29: Extended luteal phase. Advice: Continue hydration and rest."
            Case "Day 30"
                lbl_dailydigestval.Text = "Cycle Day 30: Extended luteal phase. Advice: Monitor for signs of delayed menstruation or early pregnancy."
            Case "Day 31"
                lbl_dailydigestval.Text = "Cycle Day 31: Extended luteal phase. Advice: If menstruation hasn’t started, consult a healthcare provider for clarity."

                ' Default case for any other days (not within 1-31)
            Case Else
                lbl_dailydigestval.Text = "Cycle Day: " & cycleDay
        End Select
    End Sub

    Private Sub UpdateFertilityWatcher()
        Select Case lbl_periodtitle.Text
            Case "Menstruation"
                lbl_fertilityphase.Text = "Menstruation Phase"
                pic_fertility.Image = Hercycle.My.Resources.Resources.No_chance ' Reference to the image in resources
                pic_fertility.SizeMode = PictureBoxSizeMode.StretchImage
                lbl_prediction.Text = "No chance of pregnancy during menstruation."

            Case "Follicular Phase"
                lbl_fertilityphase.Text = "Follicular Phase"
                pic_fertility.Image = Hercycle.My.Resources.Resources.Low_Fertility
                pic_fertility.SizeMode = PictureBoxSizeMode.StretchImage
                lbl_prediction.Text = "Low chance of pregnancy during the follicular phase.
"
            Case "Ovulation"
                lbl_fertilityphase.Text = "Ovulation Phase"
                pic_fertility.Image = Hercycle.My.Resources.Resources.High_Fertility_Ovulation
                pic_fertility.SizeMode = PictureBoxSizeMode.StretchImage
                lbl_prediction.Text = "High chance of pregnancy during ovulation. Consider contraception if not planning a pregnancy."

            Case "Luteal Phase"
                lbl_fertilityphase.Text = "Luteal Phase"
                pic_fertility.Image = Hercycle.My.Resources.Resources.Low_Fertility_Luteal
                pic_fertility.SizeMode = PictureBoxSizeMode.StretchImage
                lbl_prediction.Text = "Low chance of pregnancy during the luteal phase."

        End Select
    End Sub

    Private Sub IdentifyCurrentCycleDay()
        ' Get today's date
        'Dim today As DateTime = New DateTime(2024, 12, 30)
        Dim today As DateTime = DateTime.Today

        ' Connect to the database
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        ' Query to get the most recent period data for the current user, sorted by datestart
        Dim query As String = "SELECT datestart, dateend FROM tbl_records WHERE user_id = @userId ORDER BY datestart DESC LIMIT 1"
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

        ' Calculate the current cycle day based on the most recent period
        If lastPeriodStart <> DateTime.MinValue AndAlso lastPeriodEnd <> DateTime.MinValue Then
            ' Calculate total cycle length from the database if needed (e.g., for future use)
            Dim totalCycleLength As Integer = (lastPeriodEnd - lastPeriodStart).Days + 1

            ' Calculate the cycle day based on today's date
            Dim cycleDay As Integer = (today - lastPeriodStart).Days + 1 ' +1 to start from Day 1

            ' Ensure cycle day starts from Day 1
            If cycleDay < 1 Then
                lbl_cycleday.Text = "Day 1"
                UpdateCycleDayInfo(lbl_cycleday.Text)
            Else
                lbl_cycleday.Text = "Day " & cycleDay.ToString()
                UpdateCycleDayInfo(lbl_cycleday.Text)
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
            lbl_cycleday.Text = ""
        End If

        ' Clean up
        dbconnect.conn.Close()
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



    Private Sub DisplayCurrentPeriod()
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        Try
            ' Query to get the most recent period data for the current user based on datestart
            Dim query As String = "SELECT datestart, dateend FROM tbl_records WHERE user_id = @userId ORDER BY datestart DESC LIMIT 1"
            Dim cmd As New MySqlCommand(query, dbconnect.conn)
            cmd.Parameters.AddWithValue("@userId", currentUserId)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim startDate As DateTime = Convert.ToDateTime(reader("datestart"))
                Dim endDate As DateTime = Convert.ToDateTime(reader("dateend"))
                lbl_currentperiod.Text = startDate.ToString("MM/dd/yyyy") & " - " & endDate.ToString("MM/dd/yyyy")
            Else
                lbl_currentperiod.Text = ""
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading current period data: " & ex.Message)
        Finally
            dbconnect.conn.Close()
        End Try
    End Sub



    'For debugging purposes
    Private Sub lbl_period_Click(sender As Object, e As EventArgs) Handles lbl_period.Click

        IdentifyCurrentCycleDay()
        UpdateFertilityWatcher()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        RefreshDashboard()
    End Sub
End Class
