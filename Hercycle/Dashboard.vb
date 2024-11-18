Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Public Class Dashboard

    Private currentUserId As Integer = CurrentUser.UserId


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Period_Records.Show()

        Me.Hide()
    End Sub



    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs)
        'show periods record
        Period_Records.Show()
        Me.Hide()
    End Sub

    Private Sub LoadUserRecords()
        ' Load the data from tbl_records for the current user
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        ' Update the query to filter records by the current user's ID
        Dim query As String = "SELECT * FROM tbl_records WHERE user_id = @userId"
        Dim cmd As New MySqlCommand(query, dbconnect.conn)
        cmd.Parameters.AddWithValue("@userId", currentUserId) ' Use the current user's ID

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Show on the DataGridView
        If reader.HasRows Then
            Dim dt As New DataTable
            dt.Load(reader)
            Guna2DataGridView1.DataSource = dt

            ' Hide the first two columns
            If Guna2DataGridView1.Columns.Count > 1 Then
                Guna2DataGridView1.Columns(0).Visible = False
                Guna2DataGridView1.Columns(1).Visible = False
            End If
        Else
            MessageBox.Show("No records found for the current user.")
        End If

        ' Clean up
        reader.Close()
        dbconnect.conn.Close() ' Ensure the connection is closed after use
    End Sub

    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click
        Period_Records.Show()


    End Sub


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserRecords()
        PreScreening.Show()


    End Sub
End Class

Public Class OtherForm
    Public Sub LoadUserRecords()
        ' Your code to load user records
    End Sub
End Class