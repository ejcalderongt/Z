Imports MySql.Data.MySqlClient

Partial Public Class clsLnDescuento_det

    Public Shared Function GetAllByDescuentoEnc(ByVal pIdDescuentoEnc As Integer, ByVal Activos As Boolean) As List(Of clsBeDescuento_det)

        GetAllByDescuentoEnc = Nothing

        Dim lReturnList As New List(Of clsBeDescuento_det)

        Try

            'Validacion y estandarización de los datos
            Using lCnn As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)

                vSQL = " SELECT descuento_det.IdDescuentoEnc, descuento_det.IdDescuentoDet, descuento_det.IdBeneficio, descuento_det.IdPeriodoDescuento,  " & _
                        " descuento_det.MontoTotal, descuento_det.Cuotas, descuento_det.fec_agr, descuento_det.fec_mod, descuento_det.user_agr,  " & _
                        " descuento_det.user_mod, descuento_det.FechaAPartirDe, beneficio.Nombre, beneficio.Modelo, beneficio.NoChasis, beneficio.NoPlaca,  " & _
                        " beneficio.Motor, beneficio.NumeroTelefono, beneficio.EmpresaTelco, periodo_descuento.Nombre AS Periodo,  periodo_descuento.dias, " & _
                        " tipobeneficio.Nombre AS NomTipoBeneficio, tipobeneficio.IdTipoBeneficio, " & _
                        " descuento_det.Activo " & _
                        " FROM  descuento_det INNER JOIN " & _
                        " beneficio ON descuento_det.IdBeneficio = beneficio.IdBeneficio INNER JOIN " & _
                        " periodo_descuento ON descuento_det.IdPeriodoDescuento = periodo_descuento.IdPeriodo INNER JOIN " & _
                        " tipobeneficio ON beneficio.IdTipoBeneficio = tipobeneficio.IdTipoBeneficio " & _
                        " WHERE descuento_det.IdDescuentoEnc =" & pIdDescuentoEnc

                If Activos Then
                    vSQL += " AND descuento_det.Activo = 1"
                End If

                'Acceso a los datos.
                Using lDTA As New MySql.Data.MySqlClient.MySqlDataAdapter(vSQL, lCnn)

                    lDTA.SelectCommand.CommandType = CommandType.Text

                    Dim lDataTable As New DataTable
                    lDTA.Fill(lDataTable)

                    Dim Obj As clsBeDescuento_det

                    If lDataTable IsNot Nothing AndAlso lDataTable.Rows.Count > 0 Then

                        For Each lRow As DataRow In lDataTable.Rows

                            Obj = New clsBeDescuento_det

                            Obj.IdDescuentoEnc = CType(lRow("IdDescuentoEnc"), System.Int32)

                            If lRow("IdDescuentoDet") IsNot DBNull.Value AndAlso lRow("IdDescuentoDet") IsNot Nothing Then
                                Obj.IdDescuentoDet = CType(lRow("IdDescuentoDet"), System.Int32)
                            End If

                            If lRow("IdBeneficio") IsNot DBNull.Value AndAlso lRow("IdBeneficio") IsNot Nothing Then

                                Obj.Beneficio = New clsBeBeneficio
                                Obj.Beneficio.IdBeneficio = CType(lRow("IdBeneficio"), System.Int32)
                                Obj.Beneficio.Nombre = IIf(IsDBNull(lRow("Nombre")), "", lRow("Nombre"))
                                Obj.Beneficio.Modelo = IIf(IsDBNull(lRow("Modelo")), "", lRow("Modelo"))
                                Obj.Beneficio.Motor = IIf(IsDBNull(lRow("Motor")), "", lRow("Motor"))
                                Obj.Beneficio.NoChasis = IIf(IsDBNull(lRow("NoChasis")), "", lRow("NoChasis"))
                                Obj.Beneficio.NoPlaca = IIf(IsDBNull(lRow("NoPlaca")), "", lRow("NoPlaca"))
                                Obj.Beneficio.NumeroTelefono = IIf(IsDBNull(lRow("NumeroTelefono")), "", lRow("NumeroTelefono"))
                                Obj.Beneficio.EmpresaTelco = IIf(IsDBNull(lRow("EmpresaTelco")), "", lRow("EmpresaTelco"))
                                Obj.Beneficio.TipoBeneficio = New clsBeTipobeneficio
                                Obj.Beneficio.TipoBeneficio.IdTipoBeneficio = IIf(IsDBNull(lRow("IdTipoBeneficio")), "", lRow("IdTipoBeneficio"))
                                Obj.Beneficio.TipoBeneficio.Nombre = IIf(IsDBNull(lRow("NomTipoBeneficio")), "", lRow("NomTipoBeneficio"))

                            End If

                            If lRow("IdPeriodoDescuento") IsNot DBNull.Value AndAlso lRow("IdPeriodoDescuento") IsNot Nothing Then
                                Obj.PeriodoDescuento.IdPeriodo = CType(lRow("IdPeriodoDescuento"), System.Int32)
                                Obj.PeriodoDescuento.Nombre = IIf(IsDBNull(lRow("Periodo")), "", lRow("Periodo"))
                                Obj.PeriodoDescuento.Dias = IIf(IsDBNull(lRow("dias")), "", lRow("dias"))
                            End If

                            If lRow("MontoTotal") IsNot DBNull.Value AndAlso lRow("MontoTotal") IsNot Nothing Then
                                Obj.MontoTotal = CType(lRow("MontoTotal"), System.Decimal)
                            End If

                            If lRow("Cuotas") IsNot DBNull.Value AndAlso lRow("Cuotas") IsNot Nothing Then
                                Obj.Cuotas = CType(lRow("Cuotas"), System.Decimal)
                            End If

                            If lRow("user_agr") IsNot DBNull.Value AndAlso lRow("user_agr") IsNot Nothing Then
                                Obj.User_agr = CType(lRow("user_agr"), System.Int32)
                            End If

                            If lRow("fec_agr") IsNot DBNull.Value AndAlso lRow("fec_agr") IsNot Nothing Then
                                Obj.Fec_agr = CType(lRow("fec_agr"), System.DateTime)
                            End If

                            If lRow("user_mod") IsNot DBNull.Value AndAlso lRow("user_mod") IsNot Nothing Then
                                Obj.User_mod = CType(lRow("user_mod"), System.Int32)
                            End If

                            If lRow("fec_mod") IsNot DBNull.Value AndAlso lRow("fec_mod") IsNot Nothing Then
                                Obj.Fec_mod = CType(lRow("fec_mod"), System.DateTime)
                            End If

                            If lRow("FechaAPartirDe") IsNot DBNull.Value AndAlso lRow("FechaAPartirDe") IsNot Nothing Then
                                Obj.FechaAPartirDe = CType(lRow("FechaAPartirDe"), System.DateTime)
                            End If

                            If lRow("activo") IsNot DBNull.Value AndAlso lRow("activo") IsNot Nothing Then
                                Obj.Activo = CType(lRow("activo"), System.Boolean)
                            End If

                            Obj.IsNew = False

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

    Public Shared Function MaxID(ByVal pIdDescuentoEnc As Integer) As Integer

        Try

            Dim lMax As Integer = 0
            'Validacion y estandarizacion de los datos

            Using lConnection As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)
                'Acceso a los datos.

                Using lCommand As New MySql.Data.MySqlClient.MySqlCommand(String.Format("SELECT Max(IdDescuentoDet) FROM descuento_det WHERE IdDescuentoEnc={0}", pIdDescuentoEnc), lConnection)

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

    Public Shared Function GetDescuentoByEncabezado(ByVal pIdDescuentoEnc As Integer, ByVal pIdFranquiciado As Integer) As DataTable

        Dim lTable As New DataTable("Result")

        Try

            Dim lSQl As String = String.Format("SELECT b.Idbeneficio,b.Nombre,b.Modelo,b.NoChasis,b.NoPlaca," _
                               & " b.Motor,b.NumeroTelefono,b.EmpresaTelco,tp.EsVehiculo," _
                               & "tp.EsTelefono,tp.EsServicio," _
                               & "det.FechaApartirDe,pd.Dias,det.MontoTotal FROM descuento_enc AS enc " _
                               & "INNER JOIN descuento_det AS det ON enc.IdDescuentoEnc = det.IdDescuentoEnc " _
                               & "INNER JOIN beneficio AS b ON det.IdBeneficio = b.IdBeneficio " _
                               & "INNER JOIN tipobeneficio AS tp ON b.IdTipoBeneficio = tp.IdTipoBeneficio " _
                               & "INNER JOIN periodo_descuento AS pd ON det.IdPeriodoDescuento = pd.IdPeriodo " _
                               & "WHERE enc.IdTipoDescuento=2 AND enc.IdDescuentoEnc={0} AND enc.IdFranquiciado={1}", pIdDescuentoEnc, pIdFranquiciado)

            Using lConnection As New MySqlConnection(BD.CadenaConexion)

                Using lDataAdapter As New MySqlDataAdapter(lSQl, lConnection)
                    lDataAdapter.SelectCommand.CommandType = CommandType.Text
                    lDataAdapter.Fill(lTable)
                End Using

            End Using

            Return lTable

        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
