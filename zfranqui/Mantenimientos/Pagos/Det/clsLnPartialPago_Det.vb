Partial Public Class clsLnPago_det

    Public Shared Function MaxID(ByVal pIdDescuentoEnc As Integer) As Integer

        Try

            Dim lMax As Integer = 0
            'Validacion y estandarizacion de los datos
            Using lConnection As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)
                'Acceso a los datos.
                Using lCommand As New MySql.Data.MySqlClient.MySqlCommand(String.Format("SELECT Max(IdPagoDet) FROM pago_det WHERE IdPagoEnc={0}", pIdDescuentoEnc), lConnection)
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

    Public Shared Function GetAllByPagoEnc(ByVal pIdPagoEnc As Integer) As List(Of clsBePago_det)

        GetAllByPagoEnc = Nothing

        Dim lReturnList As New List(Of clsBePago_det)
        Dim ObjLnB As New clsLnBeneficio

        Try

            'Validacion y estandarización de los datos
            Using lCnn As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)

                Dim lSQL As String = String.Format("SELECT * FROM pago_det WHERE IdPagoEnc={0}", pIdPagoEnc)

                'Acceso a los datos.
                Using lDTA As New MySql.Data.MySqlClient.MySqlDataAdapter(lSQL, lCnn)

                    lDTA.SelectCommand.CommandType = CommandType.Text

                    Dim lDataTable As New DataTable
                    lDTA.Fill(lDataTable)

                    Dim Obj As clsBePago_det

                    If lDataTable IsNot Nothing AndAlso lDataTable.Rows.Count > 0 Then

                        For Each lRow As DataRow In lDataTable.Rows

                            Obj = New clsBePago_det

                            Obj.IdPagoEnc = CType(lRow("IdPagoEnc"), System.Int32)

                            If lRow("IdPagoDet") IsNot DBNull.Value AndAlso lRow("IdPagoDet") IsNot Nothing Then
                                Obj.IdPagoDet = CType(lRow("IdPagoDet"), System.Int32)
                            End If

                            If lRow("IdDescuentoEnc") IsNot DBNull.Value AndAlso lRow("IdDescuentoEnc") IsNot Nothing Then
                                Obj.IdDescuentoEnc = CType(lRow("IdDescuentoEnc"), System.Int32)
                            End If

                            If lRow("IdDescuentoDet") IsNot DBNull.Value AndAlso lRow("IdDescuentoDet") IsNot Nothing Then
                                Obj.IdDescuentoDet = CType(lRow("IdDescuentoDet"), System.Int32)
                            End If

                            If lRow("IdDescuentoRef") IsNot DBNull.Value AndAlso lRow("IdDescuentoRef") IsNot Nothing Then
                                Obj.IdDescuentoRef = CType(lRow("IdDescuentoRef"), System.Int32)
                            End If

                            If lRow("IdBeneficio") IsNot DBNull.Value AndAlso lRow("IdBeneficio") IsNot Nothing Then
                                Obj.IdBeneficio = CType(lRow("IdBeneficio"), System.Int32)
                                Obj.Beneficio.IdBeneficio = Obj.IdBeneficio
                                ObjLnB.Obtener(Obj.Beneficio)
                            End If

                            If lRow("NoCuota") IsNot DBNull.Value AndAlso lRow("NoCuota") IsNot Nothing Then
                                Obj.NoCuota = CType(lRow("NoCuota"), System.Int32)
                            End If

                            If lRow("MontoCuota") IsNot DBNull.Value AndAlso lRow("MontoCuota") IsNot Nothing Then
                                Obj.MontoCuota = CType(lRow("MontoCuota"), System.Decimal)
                            End If

                            If lRow("MontoAbono") IsNot DBNull.Value AndAlso lRow("MontoAbono") IsNot Nothing Then
                                Obj.MontoAbono = CType(lRow("MontoAbono"), System.Decimal)
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

    Public Shared Function GetAllByPagoEnc(ByVal pIdDescuentoEnc As Integer, ByVal pIdDescuentoDet As Integer) As List(Of clsBePago_det)

        GetAllByPagoEnc = Nothing

        Dim lReturnList As New List(Of clsBePago_det)

        Try

            'Validacion y estandarización de los datos
            Using lCnn As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)

                Dim lSQL As String = String.Format("SELECT * FROM pago_det WHERE IdDescuentoEnc={0}  AND IdDescuentoDet={1}", pIdDescuentoEnc, pIdDescuentoDet)
                'Acceso a los datos.
                Using lDTA As New MySql.Data.MySqlClient.MySqlDataAdapter(lSQL, lCnn)
                    lDTA.SelectCommand.CommandType = CommandType.Text
                    Dim lDataTable As New DataTable
                    lDTA.Fill(lDataTable)
                    Dim Obj As clsBePago_det
                    If lDataTable IsNot Nothing AndAlso lDataTable.Rows.Count > 0 Then
                        For Each lRow As DataRow In lDataTable.Rows

                            Obj = New clsBePago_det
                            Obj.IdPagoEnc = CType(lRow("IdPagoEnc"), System.Int32)
                            If lRow("IdPagoDet") IsNot DBNull.Value AndAlso lRow("IdPagoDet") IsNot Nothing Then
                                Obj.IdPagoDet = CType(lRow("IdPagoDet"), System.Int32)
                            End If
                            If lRow("IdDescuentoEnc") IsNot DBNull.Value AndAlso lRow("IdDescuentoEnc") IsNot Nothing Then
                                Obj.IdDescuentoEnc = CType(lRow("IdDescuentoEnc"), System.Int32)
                            End If
                            If lRow("IdDescuentoDet") IsNot DBNull.Value AndAlso lRow("IdDescuentoDet") IsNot Nothing Then
                                Obj.IdDescuentoDet = CType(lRow("IdDescuentoDet"), System.Int32)
                            End If
                            If lRow("IdDescuentoRef") IsNot DBNull.Value AndAlso lRow("IdDescuentoRef") IsNot Nothing Then
                                Obj.IdDescuentoRef = CType(lRow("IdDescuentoRef"), System.Int32)
                            End If
                            If lRow("IdBeneficio") IsNot DBNull.Value AndAlso lRow("IdBeneficio") IsNot Nothing Then
                                Obj.IdBeneficio = CType(lRow("IdBeneficio"), System.Int32)
                            End If
                            If lRow("NoCuota") IsNot DBNull.Value AndAlso lRow("NoCuota") IsNot Nothing Then
                                Obj.NoCuota = CType(lRow("NoCuota"), System.Int32)
                            End If
                            If lRow("MontoCuota") IsNot DBNull.Value AndAlso lRow("MontoCuota") IsNot Nothing Then
                                Obj.MontoCuota = CType(lRow("MontoCuota"), System.Decimal)
                            End If
                            If lRow("MontoAbono") IsNot DBNull.Value AndAlso lRow("MontoAbono") IsNot Nothing Then
                                Obj.MontoAbono = CType(lRow("MontoAbono"), System.Decimal)
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
                            Obj.IsNew = False
                            lReturnList.Add(Obj)
                        Next
                    End If
                End Using
            End Using

            Return lReturnList

        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
