Imports MySql.Data.MySqlClient
Public Class Gestion
    Inherits Conexion

    Public Sub registrar()
        Dim conn = database()
        Dim query As String = "INSERT INTO personas(nombre, apellido) VALUES (?nombre,?apellido)"
        Dim cm = New MySqlCommand(query, conn)
        cm.Parameters.Add("?nombre", MySqlDbType.VarChar)
        cm.Parameters("?nombre").Value = "juan"
        cm.Parameters.Add("?apellido", MySqlDbType.VarChar)
        cm.Parameters("?apellido").Value = "perez"
        cm.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Function buscar() As DataSet
        Dim conn = database()
        Dim sql As String = " SELECT vt_cantidad FROM inventario WHERE vt_codigo= @cod"
        Dim cmd As New MySqlCommand(sql, conn)
        cmd.Parameters.AddWithValue("@cod", Convert.ToInt32("codigo"))
        Dim dataset As DataSet
        Dim adactador = New MySqlDataAdapter(sql, conn)
        adactador.Fill(dataset, "persona")
        Dim resultado As MySqlDataReader

        resultado = cmd.ExecuteReader
        'listestudios.Items.Add(resultado)
        Return dataset
    End Function

End Class
