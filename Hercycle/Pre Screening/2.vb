Imports MySql.Data.MySqlClient

Public Class _2

    Private currentUserId As Integer = CurrentUser.UserId
    Private db As New dbconnect()

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        UpdateAnswer("Yes")
        _3.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        UpdateAnswer("No")
        _3.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub UpdateAnswer(answer As String)
        ' Ensure connection is open
        db.connect()

        ' Prepare SQL query to update the answer for Q2 for the current user ID
        Dim query As String = "UPDATE tbl_answers SET Q2 = @Q2 WHERE user_ID = @user_ID"

        ' Use the connection object from DbConnect class
        Using cmd As New MySqlCommand(query, db.conn)
            cmd.Parameters.AddWithValue("@Q2", answer)
            cmd.Parameters.AddWithValue("@user_ID", currentUserId)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Answer updated successfully!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub _2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
