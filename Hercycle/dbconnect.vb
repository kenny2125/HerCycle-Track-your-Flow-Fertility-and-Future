Imports System.Security.Cryptography
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


    Public Sub insert(ByVal date1 As Date, ByVal startdate As Date, ByVal enddate As Date, ByVal duration As Integer, ByVal notes As String)

    End Sub

End Class
