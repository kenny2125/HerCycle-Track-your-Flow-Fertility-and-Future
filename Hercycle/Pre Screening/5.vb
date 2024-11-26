Imports MySql.Data.MySqlClient

Public Class _5
    Private currentUserId As Integer = CurrentUser.UserId
    Private db As New dbconnect()

    Private Sub UpdateAnswer()
        ' Ensure connection is open
        db.connect()

        ' Prepare SQL query to update the answer for Q2 (or whichever field) for the current user ID
        Dim query As String = "UPDATE tbl_answers SET answered = @answered WHERE user_ID = @user_ID"

        ' Use the connection object from DbConnect class
        Using cmd As New MySqlCommand(query, db.conn)
            cmd.Parameters.AddWithValue("@answered", 1)
            cmd.Parameters.AddWithValue("@user_ID", currentUserId)

            Try
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        PreScreening.Close()
        Me.Close()
        UpdateAnswer()
        Dashboard.Show()
        If Not IsRecorded() Then
            Period_Records.TopMost = True
            Period_Records.Show()
        Else
            Period_Records.TopMost = False
            Period_Records.Close()
        End If
    End Sub

    Private Function IsRecorded() As Boolean
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        Try
            ' Query to check if the current user has any records in tbl_records
            Dim query As String = "SELECT COUNT(*) FROM tbl_records WHERE user_ID = @user_ID"
            Dim cmd As New MySqlCommand(query, dbconnect.conn)
            cmd.Parameters.AddWithValue("@user_ID", CurrentUser.UserId)

            ' Execute the query and get the count of records
            Dim result As Object = cmd.ExecuteScalar()
            If result IsNot DBNull.Value AndAlso Convert.ToInt32(result) > 0 Then
                Return True ' At least one record exists
            Else
                Return False ' No records found
            End If
        Catch ex As Exception
            MessageBox.Show("Error checking records: " & ex.Message)
        Finally
            dbconnect.conn.Close()
        End Try

        Return False ' Default to false if no records or an error occurs
    End Function
End Class