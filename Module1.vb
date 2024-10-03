Imports System.Data.SqlClient
Module Module1
    ' Define the connection string
    Public ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database\Reserve.mdf;Database=Reserve; Integrated Security=True"
    Public con As New SqlConnection(ConnectionString)

End Module
