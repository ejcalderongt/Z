Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Partial Public Class clsLnCefsupervisor

    
    Public Function Listar(ByVal Filtro As String) As DataTable

        Try

            Dim sp As String = "SELECT IdSupervisor as Id, Codigo, Nombre FROM Cefsupervisor Where 1 > 0"

            If Filtro <> "" Then
                sp += " and (IdSupervisor like '%" & Filtro & "%'"                
                sp += " or Nombre like '%" & Filtro & "%'"
                sp += " or Codigo like '%" & Filtro & "%')"
            End If

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable
            dad.Fill(dt)

            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Existe_Codigo(ByVal Codigo As String, ByVal IdFranquiciado As Integer) As Boolean

        Existe_Codigo = False

        Try

            vSQL$ = "SELECT IdSupervisor FROM cefsupervisor WHERE Codigo ='" & Codigo & "'" & _
                " AND Idsupervisor <> " & IdFranquiciado

            Dim sp As String = vSQL
            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            dad.Fill(dt)

            Existe_Codigo = dt.Rows.Count > 0

            cnn.Dispose()
            cmd.Dispose()
            dad.Dispose()
            dt.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

End Class
