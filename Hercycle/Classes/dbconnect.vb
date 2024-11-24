Imports MySql.Data.MySqlClient

Public Class dbconnect

    Public conn As New MySqlConnection
    Public Sub connect()
        ' Set the connection string only once before attempting to open the connection
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=db_hercycle;"
        End If

        ' Check if the connection is already open
        If conn.State <> ConnectionState.Open Then
            Try
                ' Open the connection if it's not already open
                conn.Open()
                Console.WriteLine("Connected to database")
            Catch ex As MySqlException
                Select Case ex.Number
                    Case 0
                        Console.WriteLine("Cannot connect to server. Contact administrator")
                    Case 1045
                        Console.WriteLine("Invalid username/password, please try again")
                    Case Else
                        Console.WriteLine(ex.Message)
                End Select
                MessageBox.Show("Please check your database connection")
            End Try
        Else
            Console.WriteLine("Connection is already open")
        End If
    End Sub



End Class


Public Class CurrentUser
    Public Shared Property UserId As Integer
End Class

Public Class CurrentUserEvents
    ' Declare the event
    Public Shared Event UserLoggedIn As EventHandler
    Public Shared Event UserLoggedOut As EventHandler
End Class
