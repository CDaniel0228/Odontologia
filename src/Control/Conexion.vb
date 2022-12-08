Imports MySql.Data.MySqlClient
Public Class Conexion
    Friend conexion As MySqlConnection
    Public Function database() As MySqlConnection
        Try
            Dim servidor As String = "localhost"
            Dim usuario As String = "root"
            Dim pswd As String = ""
            Dim name As String = "namebd"
            conexion = New MySqlConnection()
            conexion.ConnectionString = "server=" & servidor & ";" & "user id=" & usuario & ";" & "password=" & pswd & ";"
            conexion.Open()
            MessageBox.Show("Conectado al servidor")
            Return conexion
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido conectar al servidor")
            Return Nothing
        End Try
    End Function

End Class
