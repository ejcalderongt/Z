Imports MySql.Data.MySqlClient

Partial Public Class clsLnPago_enc

    Public Shared Function Generar_Nuevo_IdPago() As Integer

        Generar_Nuevo_IdPago = 1

        Try

            vSQL$ = "SELECT MAX(IdPagoEnc) + 1 AS nuevo FROM pago_enc "

            Dim sp As String = vSQL
            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count > 0 Then
                Generar_Nuevo_IdPago = Integer.Parse(IIf(IsDBNull(dt.Rows(0).Item("nuevo")), "1", dt.Rows(0).Item("nuevo")).ToString)
            End If

            cnn.Dispose()
            cmd.Dispose()
            dad.Dispose()
            dt.Dispose()

            'liberar recursos

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function Listar(ByVal Filtro As String, ByVal FechaDesde As Date, ByVal FechaHasta As Date) As DataTable

        Try

            Dim fFechaDesde As String = FormatoFechas.fFecha(FechaDesde)
            Dim fFechaHasta As String = FormatoFechas.fFecha(FechaHasta)

            Dim SP As String = " SELECT " & _
                                " CEF.CODIGO + ' ' + CEF.DESCRIPCION AS CEF, " & _
                                " FRANQUICIADO.CODIGO + ' ' + FRANQUICIADO.NOMBRES AS Franquiciado, " & _
                                " BENEFICIO.NOMBRE + ' ' + BENEFICIO.MODELO + ' ' + BENEFICIO.NOCHASIS + ' ' + BENEFICIO.NOPLACA + ' ' + BENEFICIO.MOTOR AS 'Vehiculo', " & _
                                " BENEFICIO.NUMEROTELEFONO + ' ' + BENEFICIO.EMPRESATELCO AS 'Telefono', " & _
                                " PAGO_DET.NoCuota, " & _
                                " PAGO_DET.MontoCuota, " & _
                                " PAGO_DET.MontoAbono, " & _
                                " DESCUENTO_REF.FechaCobro, " & _
                                " PAGO_ENC.FechaPago" & _
                                " FROM " & _
                                " PAGO_ENC " & _
                                " INNER JOIN CEF ON PAGO_ENC.IDCEF = CEF.IDCEF " & _
                                " INNER JOIN FRANQUICIADO ON PAGO_ENC.IDFRANQUICIADO = FRANQUICIADO.IDFRANQUICIADO " & _
                                " INNER JOIN PAGO_DET ON PAGO_ENC.IDPAGOENC = PAGO_DET.IDPAGOENC " & _
                                " INNER JOIN DESCUENTO_REF ON PAGO_DET.IDDESCUENTOENC = DESCUENTO_REF.IDDESCUENTOENC " & _
                                " AND PAGO_DET.IDDESCUENTODET = DESCUENTO_REF.IDDESCUENTODET " & _
                                " AND PAGO_DET.IDDESCUENTOREF = DESCUENTO_REF.IDDESCUENTOREF " & _
                                " AND PAGO_DET.IDBENEFICIO = DESCUENTO_REF.IDBENEFICIO " & _
                                " INNER JOIN BENEFICIO ON DESCUENTO_REF.IDBENEFICIO = BENEFICIO.IDBENEFICIO " & _
                                " WHERE FECHAPAGO BETWEEN " & fFechaDesde & " AND " & fFechaHasta

            If Filtro <> "" Then
                SP += " AND (FRANQUICIADO.CODIGO LIKE '%" & Filtro & "%'"
                SP += " OR FRANQUICIADO.NOMBRES LIKE '%" & Filtro & "%'"
                SP += " OR CEF.CODIGO LIKE '%" & Filtro & "%'"
                SP += " OR BENEFICIO.NOMBRE + ' ' + BENEFICIO.MODELO + ' ' + BENEFICIO.NOCHASIS + ' ' + BENEFICIO.NOPLACA + ' ' + BENEFICIO.MOTOR LIKE '%" & Filtro & "%'"
                SP += " OR BENEFICIO.NUMEROTELEFONO + ' ' + BENEFICIO.EMPRESATELCO LIKE '%" & Filtro & "%'"
                SP += " OR CEF.DESCRIPCION LIKE '%" & Filtro & "%')"
            End If


            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable
            dad.Fill(dt)

            Return dt

        Catch ex As Exception
            MsgBox(ex.Message)
            Return New DataTable
        End Try

    End Function

    Public Shared Function GetSingle(ByVal pIdCef As Integer, _
                                     ByVal pIdFranquiciado As Integer, _
                                     ByVal pIdPagoEnc As Integer) As clsBePago_enc

        Try

            Using lCnn As New MySqlConnection(BD.CadenaConexion)

                'Acceso a los datos.
                Using lDTA As New MySqlDataAdapter("SELECT * FROM pago_enc WHERE IdCef=@IdCef AND IdFranquiciado=@IdFranquiciado AND IdPagoEnc=@IdPagoEnc", lCnn)

                    lDTA.SelectCommand.CommandType = CommandType.Text
                    lDTA.SelectCommand.Parameters.AddWithValue("@IdCef", pIdCef)
                    lDTA.SelectCommand.Parameters.AddWithValue("@IdFranquiciado", pIdFranquiciado)
                    lDTA.SelectCommand.Parameters.AddWithValue("@IdPagoEnc", pIdPagoEnc)

                    Dim lDT As New DataTable()
                    lDTA.Fill(lDT)

                    If lDT IsNot Nothing AndAlso lDT.Rows.Count > 0 Then
                        Dim lRow As DataRow = lDT.Rows(0)
                        Dim Obj As New clsBePago_enc()

                        Obj.IdPagoEnc = CType(lRow("IdPagoEnc"), System.Int32)

                        If lRow("IdCEF") IsNot DBNull.Value AndAlso lRow("IdCEF") IsNot Nothing Then
                            Obj.IdCEF = CType(lRow("IdCEF"), System.Int32)
                        End If
                        If lRow("IdFranquiciado") IsNot DBNull.Value AndAlso lRow("IdFranquiciado") IsNot Nothing Then
                            Obj.IdFranquiciado = CType(lRow("IdFranquiciado"), System.String)
                        End If
                        If lRow("NoDeposito") IsNot DBNull.Value AndAlso lRow("NoDeposito") IsNot Nothing Then
                            Obj.NoDeposito = CType(lRow("NoDeposito"), System.String)
                        End If
                        If lRow("FechaPago") IsNot DBNull.Value AndAlso lRow("FechaPago") IsNot Nothing Then
                            Obj.FechaPago = CType(lRow("FechaPago"), System.DateTime)
                        End If
                        If lRow("user_agr") IsNot DBNull.Value AndAlso lRow("user_agr") IsNot Nothing Then
                            Obj.User_agr = CType(lRow("user_agr"), System.String)
                        End If
                        If lRow("fec_agr") IsNot DBNull.Value AndAlso lRow("fec_agr") IsNot Nothing Then
                            Obj.Fec_agr = CType(lRow("fec_agr"), System.DateTime)
                        End If
                        If lRow("user_mod") IsNot DBNull.Value AndAlso lRow("user_mod") IsNot Nothing Then
                            Obj.User_mod = CType(lRow("user_mod"), System.String)
                        End If
                        If lRow("fec_mod") IsNot DBNull.Value AndAlso lRow("fec_mod") IsNot Nothing Then
                            Obj.Fec_mod = CType(lRow("fec_mod"), System.DateTime)
                        End If
                        If lRow("Anulado") IsNot DBNull.Value AndAlso lRow("Anulado") IsNot Nothing Then
                            Obj.Anulado = CType(lRow("Anulado"), System.Boolean)
                        End If
                        Obj.IsNew = False
                        Return Obj
                    End If
                End Using
            End Using

            Return Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Shared Function GetAll() As DataTable

        Dim lTable As New DataTable("Result")

        Try
            Dim lSQl As String = "SELECT enc.IdPagoEnc,c.Codigo , c.Descripcion, " _
                                             & "f.Codigo AS cf , f.Nombres, enc.FechaPago,enc.IdCef,enc.IdFranquiciado " _
                                             & "FROM pago_enc AS enc  " _
                                             & "INNER JOIN cef AS c ON enc.IdCef = c.IdCEF  " _
                                             & "INNER JOIN franquiciado AS f ON enc.IdFranquiciado = f.IdFranquiciado "

            Using lConnection As New MySqlConnection(BD.CadenaConexion)
                Using lDataAdapter As New MySqlDataAdapter(lSQl, lConnection)
                    lDataAdapter.SelectCommand.CommandType = CommandType.Text
                    lDataAdapter.Fill(lTable)
                End Using
            End Using

            Return lTable

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

End Class
