Imports MySql.Data.MySqlClient

Public Class dbconnect

    Public conn As New MySqlConnection
    Public Sub connect()
        conn.ConnectionString = "server=127.0.0.1;userid=root;password=;database=db_hercycle"

        ' Open the connection
        Try
            conn.Open()
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
