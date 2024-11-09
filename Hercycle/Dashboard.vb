Imports MySql.Data.MySqlClient
Public Class Dashboard


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Period_Records.Show()

        Me.Hide()
    End Sub



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        'load the data from tbl_records to the datagridview
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        Dim query As String = "SELECT * FROM tbl_records"
        Dim cmd As New MySqlCommand(query, dbconnect.conn)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            Dim dt As New DataTable
            dt.Load(reader)
            Guna2DataGridView1.DataSource = dt
        Else
            MessageBox.Show("No records found.")
        End If

        reader.Close()
        dbconnect.conn.Close()


    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        'show periods record
        Period_Records.Show()
        Me.Hide()
    End Sub
End Class