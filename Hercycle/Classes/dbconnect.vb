Imports MySql.Data.MySqlClient

Public Class dbconnect

    Public conn As New MySqlConnection
    Public Sub connect()
        conn.ConnectionString = "server=erxv1bzckceve5lh.cbetxkdyhwsb.us-east-1.rds.amazonaws.com;userid=vg2eweo4yg8eydii;password=rccstjx3or46kpl9;database=s0gp0gvxcx3fc7ib"

        ' Open the connection
        Try
            conn.Open()
            MessageBox.Show("Connected to database")

            Console.WriteLine("Connected to database")
        Catch ex As Exception
            Console.WriteLine(ex.Message)

        End Try
    End Sub

End Class

Public Class LoginStatus
    Public Shared Property loginSuccess As Boolean
End Class

Public Class CurrentUser
    Public Shared Property UserId As Integer
End Class

Public Class UserSession
    Public Shared Sub LogOut()
        CurrentUser.UserId = 0
        LoginStatus.loginSuccess = False
        Application.OpenForms.Cast(Of Form).ToList().ForEach(Sub(f) f.Hide())
        LogIn.Show()
    End Sub
End Class
