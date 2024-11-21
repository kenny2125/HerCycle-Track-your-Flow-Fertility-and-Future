﻿Imports MySql.Data.MySqlClient

Public Class MyProfile

    Private currentUserId As Integer = CurrentUser.UserId

    Private db As New dbconnect()
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Application.Exit()
    End Sub
    Private Sub MyProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load user data for labels 1-6
        LoadUserData()

        ' Load answer data for labels 7-10 based on the current logged-in user
        LoadAnswerData()
    End Sub

    Private Sub LoadUserData()
        ' Ensure connection is open
        db.connect()

        ' SQL query to get user data (assuming fields: name, email, etc. in tbl_user)
        Dim query As String = "SELECT firstname, middleinitial, lastname, email, age, gender, username, password FROM tbl_user WHERE user_ID = @user_ID"

        ' Use the connection object from DbConnect class
        Using cmd As New MySqlCommand(query, db.conn)
            cmd.Parameters.AddWithValue("@user_ID", currentUserId)

            Try
                ' Execute the query and read data
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Concatenate the first and last name for label1
                        Label1.Text = reader("firstname").ToString() & " " & reader("middleinitial").ToString() & reader("lastname").ToString()
                        ' Set other labels with user data
                        Label2.Text = reader("email").ToString()
                        Label3.Text = reader("username").ToString()
                        Label4.Text = reader("password").ToString()
                        Label5.Text = reader("age").ToString()
                        Label6.Text = reader("gender").ToString()

                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadAnswerData()
        ' Ensure connection is open
        db.connect()

        ' SQL query to get the answers based on user ID
        Dim query As String = "SELECT Q1, Q2, Q3, Q4 FROM tbl_answers WHERE user_ID = @user_ID"

        ' Use the connection object from DbConnect class
        Using cmd As New MySqlCommand(query, db.conn)
            cmd.Parameters.AddWithValue("@user_ID", currentUserId)

            Try
                ' Execute the query and read data
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Set labels for Q1 to Q4 from tbl_answers
                        Label7.Text = reader("Q1").ToString()
                        Label8.Text = reader("Q2").ToString()
                        Label9.Text = reader("Q3").ToString()
                        Label10.Text = reader("Q4").ToString()
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        ' Reset the current user ID to 0
        CurrentUser.UserId = 0

        ' Optionally, you can show a message confirming the reset
        MessageBox.Show("User session reset. Please log in again.", "Session Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Open the login form or the form where the user will log in again
        LogIn.Show()

        ' Hide the current form instead of closing it
        Me.Hide()
        Dashboard.Hide()



        ' Alternatively, you can dispose the form explicitly to free up resources
        ' Me.Dispose()
    End Sub

End Class
