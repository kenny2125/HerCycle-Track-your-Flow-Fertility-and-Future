Imports MySql.Data.MySqlClient

Public Class _4
    Private currentUserId As Integer = CurrentUser.UserId
    Private db As New dbconnect()





    Private Sub UpdateAnswer(answer As String)
        ' Ensure connection is open
        db.connect()

        ' Prepare SQL query to update the answer for Q2 (or whichever field) for the current user ID
        Dim query As String = "UPDATE tbl_answers SET Q4 = @Q4 WHERE user_ID = @user_ID"

        ' Use the connection object from DbConnect class
        Using cmd As New MySqlCommand(query, db.conn)
            cmd.Parameters.AddWithValue("@Q4", answer)
            cmd.Parameters.AddWithValue("@user_ID", currentUserId)

            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Answer updated successfully!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub txt_input_TextChanged(sender As Object, e As EventArgs) Handles txt_input.TextChanged
        ' Enable the button only if the TextBox is not empty
        btn_enter.Enabled = Not String.IsNullOrWhiteSpace(txt_input.Text)
    End Sub

    Private Sub btn_enter_Click(sender As Object, e As EventArgs) Handles btn_enter.Click
        ' Get the value from the TextBox
        Dim answer As String = txt_input.Text
        UpdateAnswer(answer)
        _5.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btn_no_Click(sender As Object, e As EventArgs) Handles btn_no.Click
        ' For Button 4, update with "No"
        UpdateAnswer("No")
        _5.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        ' Get the value from the TextBox (assuming the TextBox is named TextBox1)
        Dim answer As String = txt_input.Text
        UpdateAnswer(answer)
        _5.ShowDialog()
        Me.Close()
    End Sub
End Class
