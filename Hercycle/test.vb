Imports System.Drawing

Public Class test
    Private Sub PeriodTracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Customize MonthCalendar properties
        MonthCalendar1.MaxSelectionCount = 1 ' Single date selection
        MonthCalendar1.BoldedDates = GetPeriodDates()
    End Sub

    ' Function to retrieve bolded dates for periods
    Private Function GetPeriodDates() As Date()
        Dim periodStart As Date = New Date(2024, 11, 1) ' Example start date
        Dim cycleLength As Integer = 28 ' Example cycle length
        Dim periodLength As Integer = 5 ' Example period length

        Dim periodDates As New List(Of Date)
        Dim currentPeriodDate = periodStart

        ' Generate period dates for the next 12 months
        While currentPeriodDate < Date.Today.AddMonths(12)
            For i = 0 To periodLength - 1
                periodDates.Add(currentPeriodDate.AddDays(i))
            Next
            currentPeriodDate = currentPeriodDate.AddDays(cycleLength)
        End While

        Return periodDates.ToArray()
    End Function

    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Dim selectedDate = e.Start
        Dim message = If(MonthCalendar1.BoldedDates.Contains(selectedDate), "Period day", "Non-period day")
        MessageBox.Show($"Selected date: {selectedDate.ToShortDateString()} is a {message}.")
    End Sub
End Class
