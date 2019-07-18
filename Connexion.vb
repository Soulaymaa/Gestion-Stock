Imports MySql.Data.MySqlClient
Module Connexion
    Public cn As New MySqlConnection
    Public sql As String
    Public slt As String
    Public cmd As New MySqlCommand
    Public data As MySqlDataReader
    Sub etabliconection()
        If cn.State = ConnectionState.Closed Then
            cn.ConnectionString = " Server=localhost; Database=gestion_stock; user=root; passwd=;"
            'MsgBox("Connection Reussie")
            cn.Open()
        End If
    End Sub
End Module
