Imports MySql.Data.MySqlClient
Imports MySql.Data

Partial Public Class clsLnFranquiciadocef

    'Public Function Obtener(ByRef oBeFranquiciadocef As clsBeFranquiciadocef) As Boolean

    '    Try

    '        Dim sp As String = "SELECT * FROM Franquiciadocef" & _
    '        " Where (IdAsignacionFranquiciado = @IdAsignacionFranquiciado)"

    '        Dim cnn As New MySqlConnection(BD.CadenaConexion)
    '        Dim cmd As New MySqlCommand(sp, cnn)
    '        cmd.CommandType = CommandType.Text


    '        Dim dad As New MySqlDataAdapter(cmd)
    '        dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDASIGNACIONFRANQUICIADO", oBeFranquiciadocef.IdAsignacionFranquiciado))

    '        Dim dt As New DataTable
    '        dad.Fill(dt)

    '        If dt.Rows.Count = 1 Then
    '            Cargar(oBeFranquiciadocef, dt.Rows(0))
    '        Else
    '            Throw New Exception("No se pudo obtener el registro")
    '        End If

    '        Return True
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Function

End Class
