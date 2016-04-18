partial Public Class clsLnVentasenc

    Public Shared Function GetByDate(ByVal FechaDesde As Date, ByVal FechaHasta As Date) As List(Of clsBeVentasenc)

        GetByDate = Nothing

        Try

            vSQL = " SELECT a.*, f.codigo as CodigoFranquiciado, c.Codigo as CodigoCEF  " & _
              " from ventasenc   a inner join franquiciado f  " & _
              " on a.idfranquiciado = f.IdFranquiciado " & _
              " inner join cef c on a.idcef = c.IdCef " & _
              " Where a.Monto > a.Pagado " & _
              " AND a.FechaDesde>=" & FormatoFechas.fFecha(FechaDesde) & _
              " AND a.FechaHasta<=" & FormatoFechas.fFecha(FechaHasta)

            Dim lReturnList As New List(Of clsBeVentasenc)

            Using lCnn As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)

                'Acceso a los datos.
                Using lDTA As New MySql.Data.MySqlClient.MySqlDataAdapter(vSQL, lCnn)

                    lDTA.SelectCommand.CommandType = CommandType.Text

                    Dim lDataTable As New DataTable
                    lDTA.Fill(lDataTable)

                    Dim Obj As clsBeVentasenc

                    If lDataTable IsNot Nothing AndAlso lDataTable.Rows.Count > 0 Then

                        For Each lRow As DataRow In lDataTable.Rows

                            Obj = New clsBeVentasenc

                            Obj.IdPeriodoVenta = IIf(IsDBNull(lRow("IdPeriodoVenta")), 0, lRow("IdPeriodoVenta"))
                            Obj.IdFranquiciado = IIf(IsDBNull(lRow("IdFranquiciado")), 0, lRow("IdFranquiciado"))
                            Obj.IdCEF = IIf(IsDBNull(lRow("IdCEF")), 0, lRow("IdCEF"))
                            Obj.Monto = IIf(IsDBNull(lRow("Monto")), 0, lRow("Monto"))
                            Obj.FechaDesde = IIf(IsDBNull(lRow("FechaDesde")), 0, lRow("FechaDesde"))
                            Obj.FechaHasta = IIf(IsDBNull(lRow("FechaHasta")), 0, lRow("FechaHasta"))
                            Obj.Monto = IIf(IsDBNull(lRow("Monto")), 0, lRow("Monto"))
                            Obj.Pagado = IIf(IsDBNull(lRow("Pagado")), 0, lRow("Pagado"))
                            Obj.Saldo = IIf(IsDBNull(lRow("Saldo")), 0, lRow("Saldo"))
                            Obj.CodigoCEF = IIf(IsDBNull(lRow("CodigoCEF")), 0, lRow("CodigoCEF"))
                            Obj.CodigoFranquiciado = IIf(IsDBNull(lRow("CodigoFranquiciado")), 0, lRow("CodigoFranquiciado"))
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

    Public Shared Function MaxID() As Integer

        Try

            Dim lMax As Integer = 0
            'Validacion y estandarizacion de los datos
            Using lConnection As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)
                'Acceso a los datos.
                Using lCommand As New MySql.Data.MySqlClient.MySqlCommand(String.Format("SELECT Max(IdPeriodoVenta) FROM ventasenc"), lConnection)
                    lCommand.CommandType = CommandType.Text
                    lConnection.Open()
                    Dim lReturnValue As Object = lCommand.ExecuteScalar()
                    lConnection.Close()
                    If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                        lMax = CInt(lReturnValue) + 1
                    End If
                End Using
            End Using

            Return lMax

        Catch ex As Exception
            Throw ex
        End Try


    End Function
End Class
