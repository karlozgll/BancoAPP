Imports System.Data.SqlClient
Imports System.Data

Module Conexion
    Friend dbConnection As Data.SqlClient.SqlConnection
    Friend dbCommand As Data.SqlClient.SqlCommand
    Friend dbDataReader As Data.SqlClient.SqlDataReader
    Friend dbDataSet As Data.DataSet
    Friend dbDataAdapter As Data.SqlClient.SqlDataAdapter
    '
    Friend CadenaConexion As String
    Friend CadenaSelect As String
    Friend Sub Conectar()
        CadenaConexion = "Data Source=(local)\SQLEXPRESS;Initial Catalog=Banco;Integrated Security=True" '& _

        Try
            dbConnection = New Data.SqlClient.SqlConnection(CadenaConexion)
        Catch e As Exception
            MessageBox.Show("Error al crear la conexión:" & vbCrLf & e.Message)
            Exit Sub
        End Try
        '
        dbConnection.Open()
    End Sub

End Module
