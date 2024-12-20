﻿Imports MySql.Data.MySqlClient

Public Class _1

    Private currentUserId As Integer = CurrentUser.UserId

    ' Assuming you have an instance of the DbConnect class for the connection
    Private db As New dbconnect()


    Private Sub InsertAnswer(answer As String)
        ' Ensure connection is open
        db.connect()

        ' Prepare SQL query for inserting the answer
        Dim query As String = "INSERT INTO tbl_answers (Q1, user_ID) VALUES (@Q1, @user_ID)"

        ' Use the connection object from DbConnect class
        Using cmd As New MySqlCommand(query, db.conn)
            cmd.Parameters.AddWithValue("@Q1", answer)
            cmd.Parameters.AddWithValue("@user_ID", currentUserId)

            Try
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub



    Private Sub btn_yes_Click(sender As Object, e As EventArgs) Handles btn_yes.Click
        InsertAnswer("Yes")
        _2.Show()
        Me.Close()
    End Sub

    Private Sub btn_no_Click(sender As Object, e As EventArgs) Handles btn_no.Click
        InsertAnswer("No")
        _2.Show()
        Me.Close()
    End Sub
End Class
