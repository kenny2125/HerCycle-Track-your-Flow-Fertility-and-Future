Imports MySql.Data.MySqlClient
Public Class Dashboard


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Period_Records.Show()

        Me.Hide()
    End Sub



    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        'load the data from tbl_records to the datagridview
        Dim dbconnect As New dbconnect
        dbconnect.connect()

        Dim query As String = "SELECT * FROM tbl_records"
        Dim cmd As New MySqlCommand(query, dbconnect.conn)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.HasRows Then
            Dim dt As New DataTable
            dt.Load(reader)
            gridview_tracker.DataSource = dt
        Else
            MessageBox.Show("No records found.")
        End If

        reader.Close()
        dbconnect.conn.Close()


    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs)
        'show periods record
        Period_Records.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles pnl_dashboardbg.Paint

    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles pnl_phase.Paint

    End Sub

    Private Sub PERIOD_TRACKER_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2HtmlLabel6_Click(sender As Object, e As EventArgs) Handles lbl_phaseday.Click

    End Sub

    Private Sub Guna2HtmlLabel5_Click(sender As Object, e As EventArgs) Handles lbl_phasedayno.Click

    End Sub

    Private Sub Guna2HtmlLabel7_Click_1(sender As Object, e As EventArgs) Handles lbl_phaseheader.Click

    End Sub

    Private Sub Guna2HtmlLabel19_Click(sender As Object, e As EventArgs) Handles lbl_phasesub.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub Guna2HtmlLabel11_Click(sender As Object, e As EventArgs) Handles lbl_dailydigest.Click

    End Sub

    Private Sub Guna2HtmlLabel15_Click(sender As Object, e As EventArgs) Handles lbl_follicular.Click

    End Sub

    Private Sub Guna2HtmlLabel12_Click_1(sender As Object, e As EventArgs) Handles lbl_greet.Click

    End Sub

    Private Sub EDIT_PROFILE_PANEL_Paint(sender As Object, e As PaintEventArgs) Handles pnl_editprof.Paint

    End Sub

    Private Sub Guna2GradientButton1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_addnew_Click(sender As Object, e As EventArgs) Handles btn_addnew.Click

    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridview_tracker.CellContentClick

    End Sub
End Class