Imports MySql.Data.MySqlClient
Public Class BaseDatos

    Public AppPath As String = CurDir() & "/"
    Public Property Server As String = "200.35.177.122"
    Public Property NomBD As String = "zetafranquiciados"
    Public Property UsuarioBD As String = "zfran"
    Public Property ClaveBD As String = "Zeta.2016"
    Public Property PuertoBD As String = "3401"

    Public Property CadenaConexion As String = String.Format("server={0};user id={1}; password={2}; port={3}; database={4}; pooling=false", Server, UsuarioBD, ClaveBD, PuertoBD, NomBD)
    Public Property CadenaConexionZVentas As String = String.Format("server={0};user id={1}; password={2}; port={3}; database={4}; pooling=false", Server, UsuarioBD, ClaveBD, PuertoBD, "zgas")

    Public Property FechaExpiracionLicencia As Date = CDate("31/05/2016")

    ''' <summary>
    ''' Ejecuta una sentencia SQL de tipo DDL, devuelve el número de filas afectadas
    ''' </summary>
    ''' <param name="pSQL"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Xcute(ByVal pSql As String) As Integer

        Dim conn As New MySqlConnection(CadenaConexion)

        Try

            conn.Open()

            Dim cmd As New MySqlCommand
            cmd = conn.CreateCommand
            cmd.CommandText = pSql
            Xcute = cmd.ExecuteNonQuery()
            cmd.Dispose()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Close()
            conn.Dispose()
        End Try

    End Function

    ''' <summary>
    ''' Ejecuta sentencias "SELECT"  en la base de datos.
    ''' </summary>
    ''' <param name="DT"></param>
    ''' <param name="vSQL"></param>
    ''' <remarks></remarks>
    Public Sub OpenDT(ByRef dT As DataTable, ByVal vSql As String)

        Dim conn As New MySqlConnection(CadenaConexion)

        Try

            conn.Open()

            Dim dAdapter As New MySqlDataAdapter(vSql, conn)
            Dim dSet As New DataSet
            dAdapter.Fill(dSet, "Query")
            dT = dSet.Tables("Query")

            dAdapter.Dispose()
            dSet.Dispose()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Close()
            conn.Dispose()
        End Try

    End Sub

    Public Sub OpenDT(ByRef dT As DataTable, ByVal vSql As String, ByVal CadenaConexion As String)

        Dim conn As New MySqlConnection(CadenaConexion)

        Try

            conn.Open()

            Dim dAdapter As New MySqlDataAdapter(vSql, conn)
            Dim dSet As New DataSet
            dAdapter.Fill(dSet, "Query")
            dT = dSet.Tables("Query")

            dAdapter.Dispose()
            dSet.Dispose()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            conn.Close()
            conn.Dispose()
        End Try

    End Sub

End Class
