Partial Public Class clsLnVentasdet

    Public Shared Function GetByDate(ByVal FechaDesde As Date, ByVal FechaHasta As Date) As List(Of clsBeVentasdet)

        GetByDate = Nothing

        Try

            vSQL = "SELECT " & _
                  "ventasdet.IdVenta," & _
                  "cef.Codigo AS CEF, " & _
                  "cef.IdCef, " & _
                  "franquiciado.Codigo AS Franquiciado, " & _
                  "ventasdet.IdFranquiciado, " & _
                  "SUM(ventasdet.Monto) AS Monto, " & _
                  "ventasdet.Fecha, " & _
                  "ventasdet.Saldo, " & _
                  "ventasdet.Pagado " & _
                  "FROM " & _
                  "	franquiciadocef " & _
                  "INNER JOIN cef ON franquiciadocef.IdCEF = cef.IdCef " & _
                  "INNER JOIN ventasdet ON franquiciadocef.IdFranquiciado = ventasdet.IdFranquiciado " & _
                  "INNER JOIN franquiciado ON franquiciadocef.IdFranquiciado = franquiciado.IdFranquiciado " & _
                  " WHERE ventasdet.fecha>=" & FormatoFechas.fFecha(FechaDesde) & _
                  " AND ventasdet.fecha<=" & FormatoFechas.fFecha(FechaHasta) & _
                  " AND ventasdet.monto > ventasdet.pagado "

            vSQL += "GROUP BY " & _
                    "ventasdet.IdVenta, " & _
                    "cef.Codigo, " & _
                    "franquiciado.Codigo, " & _
                    "ventasdet.IdFranquiciado, " & _
                    "ventasdet.Fecha, " & _
                    "ventasdet.Saldo, " & _
                    "ventasdet.Pagado "

            Dim lReturnList As New List(Of clsBeVentasdet)

            Using lCnn As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)

                'Acceso a los datos.
                Using lDTA As New MySql.Data.MySqlClient.MySqlDataAdapter(vSQL, lCnn)

                    lDTA.SelectCommand.CommandType = CommandType.Text

                    Dim lDataTable As New DataTable
                    lDTA.Fill(lDataTable)

                    Dim Obj As clsBeVentasdet

                    If lDataTable IsNot Nothing AndAlso lDataTable.Rows.Count > 0 Then

                        For Each lRow As DataRow In lDataTable.Rows

                            Obj = New clsBeVentasdet
                            Obj.IdVenta = lRow.Item("IdVenta")
                            Obj.CodigoCEF = lRow.Item("CEF")
                            Obj.IdCEF = lRow.Item("CEF")
                            Obj.CodigoFranquiciado = lRow.Item("Franquiciado")
                            Obj.IdFranquiciado = lRow.Item("IdFranquiciado")
                            Obj.Monto = IIf(IsDBNull(lRow.Item("Monto")), 0, lRow.Item("Monto"))
                            Obj.Fecha = lRow.Item("Fecha")
                            Obj.Saldo = IIf(IsDBNull(lRow.Item("Saldo")), 0, lRow.Item("Saldo"))
                            Obj.Pagado = IIf(IsDBNull(lRow.Item("Pagado")), 0, lRow.Item("Pagado"))
                            lReturnList.Add(Obj)

                        Next

                    End If

                End Using

            End Using

            Return lReturnList

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    

End Class
