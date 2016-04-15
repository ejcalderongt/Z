Imports MySql.Data.MySqlClient
Imports MySql.Data

Partial Public Class clsLnFranquiciadocef

    Public Function GetIdFranquiciado(ByVal IdCEF) As Integer

        GetIdFranquiciado = 0

        Try

            Dim sp As String = "SELECT IdFranquiciado FROM Franquiciadocef " & _
            " Where (IdCEF = @IdCEF)"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDCEF", IdCEF))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                GetIdFranquiciado = dt.Rows(0).Item("IdFranquiciado")
            ElseIf dt.Rows.Count > 1 Then
                Throw New Exception("No se pudo obtener el IdFranquiciado para el CEF:" & IdCEF & " porque se encontró más de un franquiciado asignado al CEF")
            End If

            Return GetIdFranquiciado
        Catch ex As Exception
            MsgBox("Error GetIdFranquiciado: " & ex.Message)
        End Try

    End Function

End Class
