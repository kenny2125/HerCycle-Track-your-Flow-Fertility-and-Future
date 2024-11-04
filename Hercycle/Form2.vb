Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices.ComTypes

Public Class Form2
    Public conn As New MySqlConnection

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connection string
        conn.ConnectionString = "server=127.0.0.1;userid=root;password=;database=db_hercycle"

        ' Open the connection
        Try
            conn.Open()
            MsgBox("Connected")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim date1 As Date = DateTimePicker1.Value
        Dim startdate As Date = DateTimePicker2.Value
        Dim enddate As Date = DateTimePicker3.Value

        ' Display formatted dates in a message box
        MsgBox("Date1: " & date1.ToString("yyyy-MM-dd") & vbCrLf &
               "Start Date: " & startdate.ToString("yyyy-MM-dd") & vbCrLf &
               "End Date: " & enddate.ToString("yyyy-MM-dd"))

        ' SQL command to insert data
        Dim sqlCommand As String = "INSERT INTO tbl_records (date, datestart, dateend) VALUES (@date1, @startdate, @enddate)"
        Dim command As New MySqlCommand(sqlCommand, conn)

        ' Add parameters and format dates as "yyyy-MM-dd"
        command.Parameters.AddWithValue("@date1", date1.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@startdate", startdate.ToString("yyyy-MM-dd"))
        command.Parameters.AddWithValue("@enddate", enddate.ToString("yyyy-MM-dd"))

        ' Execute the command
        Try
            command.ExecuteNonQuery()
            MsgBox("Data inserted successfully!")
        Catch ex As Exception
            MsgBox("Error inserting data: " & ex.Message)
        End Try
    End Sub
End Class
