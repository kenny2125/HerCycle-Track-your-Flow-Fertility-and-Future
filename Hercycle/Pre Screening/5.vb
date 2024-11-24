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
                MessageBox.Show("Answer updated successfully!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Period_Records.Show()
        PreScreening.Hide()
        _1.Hide()
        _2.Hide()
        _3.Hide()
        _4.Hide()
        Me.Hide()
        UpdateAnswer()
    End Sub
End Class