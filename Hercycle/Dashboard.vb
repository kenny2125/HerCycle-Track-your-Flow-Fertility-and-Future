Public Class Dashboard


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Period_Records.Show()

        Me.Hide()
    End Sub
End Class