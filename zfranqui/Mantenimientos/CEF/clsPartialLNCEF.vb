Imports MySql.Data.MySqlClient

Partial Public Class clsLnCef

    Public Function Get_IdCEF(ByVal Codigo As String) As Integer

        Get_IdCEF = 0

        Try

            vSQL$ = "SELECT IdCEF FROM CEF WHERE Codigo ='" & Codigo & "'"

            Dim sp As String = vSQL
            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count > 0 Then
                Get_IdCEF = dt.Rows(0).Item("IdCEF")
            End If

            cnn.Dispose()
            cmd.Dispose()
            dad.Dispose()
            dt.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Sub Cargar(ByRef oBeCef As clsBeCef, ByRef dr As DataRow, ByVal Parcial As Boolean)

        Try

            With oBeCef

                .IdCef = IIf(IsDBNull(dr.Item("IdCef")), 0, dr.Item("IdCef"))
                .Codigo = IIf(IsDBNull(dr.Item("Codigo")), "", dr.Item("Codigo"))
                .Descripcion = IIf(IsDBNull(dr.Item("Descripcion")), "", dr.Item("Descripcion"))
                .Encargado = IIf(IsDBNull(dr.Item("Encargado")), "", dr.Item("Encargado"))
                .Celular = IIf(IsDBNull(dr.Item("Celular")), "", dr.Item("Celular"))
                .Telefono = IIf(IsDBNull(dr.Item("Telefono")), "", dr.Item("Telefono"))
                .Observaciones = IIf(IsDBNull(dr.Item("Observaciones")), "", dr.Item("Observaciones"))
                .Fec_agr = IIf(IsDBNull(dr.Item("fec_agr")), Date.Now, dr.Item("fec_agr"))
                .Fec_mod = IIf(IsDBNull(dr.Item("fec_mod")), Date.Now, dr.Item("fec_mod"))
                .User_agr = IIf(IsDBNull(dr.Item("user_agr")), 0, dr.Item("user_agr"))
                .User_mod = IIf(IsDBNull(dr.Item("user_mod")), 0, dr.Item("user_mod"))

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class
