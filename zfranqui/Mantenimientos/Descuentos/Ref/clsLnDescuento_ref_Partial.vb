Imports MySql.Data.MySqlClient
Imports MySql.Data

Partial Public Class clsLnDescuento_ref

    Public Shared Function GetAllByDetalle(ByVal pIdDescuentoEnc As Integer, ByVal pIdDescuentoDet As Integer) As List(Of clsBeDescuento_ref)

        Dim lReturnList As New List(Of clsBeDescuento_ref)

        Try

            'Validacion y estandarización de los datos
            Using lCnn As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)

                Dim lSQL As String = String.Format("SELECT * FROM descuento_ref WHERE IdDescuentoEnc={0} AND IdDescuentoDet={1}", pIdDescuentoEnc, pIdDescuentoDet)

                'Acceso a los datos.
                Using lDTA As New MySql.Data.MySqlClient.MySqlDataAdapter(lSQL, lCnn)

                    lDTA.SelectCommand.CommandType = CommandType.Text

                    Dim lDataTable As New DataTable
                    lDTA.Fill(lDataTable)

                    Dim Obj As clsBeDescuento_ref

                    If lDataTable IsNot Nothing AndAlso lDataTable.Rows.Count > 0 Then
                        For Each lRow As DataRow In lDataTable.Rows
                            Obj = New clsBeDescuento_ref

                            Obj.IdDescuentoEnc = CType(lRow("IdDescuentoEnc"), System.Int32)

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
                            If lRow("Monto") IsNot DBNull.Value AndAlso lRow("Monto") IsNot Nothing Then
                                Obj.Monto = CType(lRow("Monto"), System.Decimal)
                            End If
                            If lRow("Abonado") IsNot DBNull.Value AndAlso lRow("Abonado") IsNot Nothing Then
                                Obj.Abonado = CType(lRow("Abonado"), System.Decimal)
                            End If
                            If lRow("FechaCobro") IsNot DBNull.Value AndAlso lRow("FechaCobro") IsNot Nothing Then
                                Obj.FechaCobro = CType(lRow("FechaCobro"), System.DateTime)
                            End If
                            If lRow("Pagada") IsNot DBNull.Value AndAlso lRow("Pagada") IsNot Nothing Then
                                Obj.Pagada = CType(lRow("Pagada"), System.Boolean)
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
                            If lRow("Anulada") IsNot DBNull.Value AndAlso lRow("Anulada") IsNot Nothing Then
                                Obj.Anulada = CType(lRow("Anulada"), System.Boolean)
                            End If

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

    Public Shared Function GetAllByEncabezadoPago(ByVal pIdDescuentoEnc As Integer) As List(Of clsBeDescuento_ref)

        Dim lReturnList As New List(Of clsBeDescuento_ref)

        Try

            'Validacion y estandarización de los datos
            Using lCnn As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)

                Dim lSQL As String = String.Format("SELECT * FROM descuento_ref WHERE IdDescuentoEnc={0}", pIdDescuentoEnc)

                'Acceso a los datos.
                Using lDTA As New MySql.Data.MySqlClient.MySqlDataAdapter(lSQL, lCnn)

                    lDTA.SelectCommand.CommandType = CommandType.Text

                    Dim lDataTable As New DataTable
                    lDTA.Fill(lDataTable)

                    Dim Obj As clsBeDescuento_ref

                    If lDataTable IsNot Nothing AndAlso lDataTable.Rows.Count > 0 Then
                        For Each lRow As DataRow In lDataTable.Rows
                            Obj = New clsBeDescuento_ref

                            Obj.IdDescuentoEnc = CType(lRow("IdDescuentoEnc"), System.Int32)

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
                            If lRow("Monto") IsNot DBNull.Value AndAlso lRow("Monto") IsNot Nothing Then
                                Obj.Monto = CType(lRow("Monto"), System.Decimal)
                            End If
                            If lRow("Abonado") IsNot DBNull.Value AndAlso lRow("Abonado") IsNot Nothing Then
                                Obj.Abonado = CType(lRow("Abonado"), System.Decimal)
                            End If
                            If lRow("FechaCobro") IsNot DBNull.Value AndAlso lRow("FechaCobro") IsNot Nothing Then
                                Obj.FechaCobro = CType(lRow("FechaCobro"), System.DateTime)
                            End If
                            If lRow("Pagada") IsNot DBNull.Value AndAlso lRow("Pagada") IsNot Nothing Then
                                Obj.Pagada = CType(lRow("Pagada"), System.Boolean)
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
                            If lRow("Anulada") IsNot DBNull.Value AndAlso lRow("Anulada") IsNot Nothing Then
                                Obj.Anulada = CType(lRow("Anulada"), System.Boolean)
                            End If

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

    Public Shared Function GetAllByEncabezado(ByVal pIdDescuentoEnc As Integer) As List(Of clsBeDescuento_ref)

        Dim lReturnList As New List(Of clsBeDescuento_ref)

        Try

            'Validacion y estandarización de los datos
            Using lCnn As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)

                Dim lSQL As String = String.Format("SELECT r.IdDescuentoEnc, r.IdDescuentoDet, r.IdDescuentoRef, r.IdBeneficio, " _
                                                 & " b.Nombre,b.Modelo,b.NoChasis, b.NoPlaca,b.Motor,b.NumeroTelefono, " _
                                                 & " b.EmpresaTelco, tp.EsVehiculo, tp.EsTelefono, tp.EsServicio, r.FechaCobro, r.NoCuota, r.Monto, " _
                                                 & "r.Abonado, det.MontoTotal, r.pagada " _
                                                 & "FROM descuento_ref AS r " _
                                                 & "INNER JOIN descuento_det AS det ON r.IdDescuentoEnc= det.IdDescuentoEnc " _
                                                 & "AND r.IdDescuentoDet = det.IdDescuentoDet " _
                                                 & "INNER JOIN beneficio AS b ON r.IdBeneficio = b.IdBeneficio " _
                                                 & "INNER JOIN TipoBeneficio AS tp ON b.IdTipoBeneficio = tp.IdTipoBeneficio " _
                                                 & "WHERE r.IdDescuentoEnc={0} AND r.Anulada = 0 ", pIdDescuentoEnc)


                'Acceso a los datos.
                Using lDTA As New MySql.Data.MySqlClient.MySqlDataAdapter(lSQL, lCnn)

                    lDTA.SelectCommand.CommandType = CommandType.Text

                    Dim lDataTable As New DataTable
                    lDTA.Fill(lDataTable)

                    Dim Obj As clsBeDescuento_ref

                    If lDataTable IsNot Nothing AndAlso lDataTable.Rows.Count > 0 Then

                        For Each lRow As DataRow In lDataTable.Rows

                            Obj = New clsBeDescuento_ref

                            If lRow("Nombre") IsNot DBNull.Value AndAlso lRow("Nombre") IsNot Nothing Then

                                Obj.Beneficio = New clsBeBeneficio
                                Obj.IdDescuentoEnc = CType(lRow("IdDescuentoEnc"), System.Int32)
                                Obj.IdDescuentoDet = CType(lRow("IdDescuentoDet"), System.Int32)
                                Obj.IdDescuentoRef = CType(lRow("IdDescuentoRef"), System.Int32)
                                Obj.IdBeneficio = CType(lRow("IdBeneficio"), System.Int32)

                                Obj.Beneficio.Nombre = CType(lRow("Nombre"), System.String)

                                If lRow("Modelo") IsNot DBNull.Value AndAlso lRow("Modelo") IsNot Nothing Then
                                    Obj.Beneficio.Modelo = CType(lRow("Modelo"), System.String)
                                End If

                                If lRow("NoChasis") IsNot DBNull.Value AndAlso lRow("NoChasis") IsNot Nothing Then
                                    Obj.Beneficio.NoChasis = CType(lRow("NoChasis"), System.String)
                                End If

                                If lRow("NoPlaca") IsNot DBNull.Value AndAlso lRow("NoPlaca") IsNot Nothing Then
                                    Obj.Beneficio.NoPlaca = CType(lRow("NoPlaca"), System.String)
                                End If

                                If lRow("Motor") IsNot DBNull.Value AndAlso lRow("Motor") IsNot Nothing Then
                                    Obj.Beneficio.Motor = CType(lRow("Motor"), System.String)
                                End If

                                If lRow("NumeroTelefono") IsNot DBNull.Value AndAlso lRow("NumeroTelefono") IsNot Nothing Then
                                    Obj.Beneficio.NumeroTelefono = CType(lRow("NumeroTelefono"), System.String)
                                End If

                                If lRow("EmpresaTelco") IsNot DBNull.Value AndAlso lRow("EmpresaTelco") IsNot Nothing Then
                                    Obj.Beneficio.EmpresaTelco = CType(lRow("EmpresaTelco"), System.String)
                                End If

                            End If

                            If lRow("FechaCobro") IsNot DBNull.Value AndAlso lRow("FechaCobro") IsNot Nothing Then
                                Obj.FechaCobro = CType(lRow("FechaCobro"), System.DateTime)
                            End If

                            If lRow("NoCuota") IsNot DBNull.Value AndAlso lRow("NoCuota") IsNot Nothing Then
                                Obj.NoCuota = CType(lRow("NoCuota"), System.Int32)
                            End If

                            If lRow("Monto") IsNot DBNull.Value AndAlso lRow("Monto") IsNot Nothing Then
                                Obj.Monto = CType(lRow("Monto"), System.Decimal)
                            End If

                            If lRow("Abonado") IsNot DBNull.Value AndAlso lRow("Abonado") IsNot Nothing Then
                                Obj.Abonado = CType(lRow("Abonado"), System.Decimal)
                            End If

                            If lRow("MontoTotal") IsNot DBNull.Value AndAlso lRow("MontoTotal") IsNot Nothing Then
                                Obj.MontoTotal = CType(lRow("MontoTotal"), System.Decimal)
                            End If

                            If lRow("Pagada") IsNot DBNull.Value AndAlso lRow("Pagada") IsNot Nothing Then
                                Obj.Pagada = CType(lRow("Pagada"), System.Boolean)
                            End If

                            If lRow("EsVehiculo") IsNot DBNull.Value AndAlso lRow("EsVehiculo") IsNot Nothing Then
                                Obj.EsVehiculo = CType(lRow("EsVehiculo"), System.Boolean)
                            End If

                            If lRow("EsTelefono") IsNot DBNull.Value AndAlso lRow("EsTelefono") IsNot Nothing Then
                                Obj.EsTelefono = CType(lRow("EsTelefono"), System.Boolean)
                            End If

                            If lRow("EsServicio") IsNot DBNull.Value AndAlso lRow("EsServicio") IsNot Nothing Then
                                Obj.EsServicio = CType(lRow("EsServicio"), System.Boolean)
                            End If

                            Obj.IsNew = False

                            lReturnList.Add(Obj)

                        Next

                    End If

                End Using

            End Using

            Return lReturnList

        Catch ex As Exception
            MsgBox("GetAllByEncabezado " & ex.Message, MsgBoxStyle.Exclamation, "Error")
        End Try

    End Function

    Public Shared Function MaxID(ByVal pIdDescuentoEnc As Integer, ByVal pIdDescuentoDet As Integer) As Integer

        MaxID = 1

        Try

            Dim lMax As Integer = 1

            'Validacion y estandarizacion de los datos

            Using lConnection As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)
                'Acceso a los datos.

                Using lCommand As New MySql.Data.MySqlClient.MySqlCommand(String.Format("SELECT Max(IdDescuentoRef) FROM descuento_ref WHERE IdDescuentoEnc={0} AND IdDescuentoDet={1}", pIdDescuentoEnc, pIdDescuentoDet), lConnection)

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
            MsgBox(ex.Message)
        End Try

    End Function

    Public Shared Function MaxCuota(ByVal pIdDescuentoEnc As Integer, ByVal pIdDescuentoDet As Integer) As Integer

        MaxCuota = 1

        Try

            Dim lMax As Integer = 1

            'Validacion y estandarizacion de los datos

            Using lConnection As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)
                'Acceso a los datos.

                Using lCommand As New MySql.Data.MySqlClient.MySqlCommand(String.Format("SELECT Max(NoCuota) FROM descuento_ref WHERE IdDescuentoEnc={0} AND IdDescuentoDet={1}", pIdDescuentoEnc, pIdDescuentoDet), lConnection)

                    lCommand.CommandType = CommandType.Text
                    lConnection.Open()

                    Dim lReturnValue As Object = lCommand.ExecuteScalar()

                    lConnection.Close()

                    If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                        lMax = CInt(lReturnValue) + 1
                    End If

                    MaxCuota = lMax

                End Using

            End Using

            Return lMax

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Shared Function TienePago(ByVal DetRef As clsBeDescuento_ref) As Boolean

        TienePago = False

        Dim DT As New DataTable

        Try

            vSQL = "select * from pago_det where IdDescuentoEnc = " & DetRef.IdDescuentoEnc & _
                " and IdDescuentoDet =" & DetRef.IdDescuentoDet & _
                " and IdDescuentoRef =" & DetRef.IdDescuentoRef & _
                " and IdBeneficio = " & DetRef.IdBeneficio
            BD.OpenDT(DT, vSQL)

            TienePago = DT.Rows.Count > 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Shared Function TienePago(ByVal DescuentoDet As clsBeDescuento_det) As Boolean

        TienePago = False

        Dim DT As New DataTable

        Try

            vSQL = "select * from pago_det where IdDescuentoEnc = " & DescuentoDet.IdDescuentoEnc & _
                " and IdDescuentoDet =" & DescuentoDet.IdDescuentoDet & _
                " and IdBeneficio = " & DescuentoDet.Beneficio.IdBeneficio
            BD.OpenDT(DT, vSQL)

            TienePago = DT.Rows.Count > 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Shared Function AnularCuota(ByVal DetRef As clsBeDescuento_ref) As Boolean

        AnularCuota = False

        Dim DT As New DataTable

        Try


            Upd.Init("descuento_ref")
            Upd.Add("anulada", "1", "N")
            Upd.Where("IdDescuentoEnc=" & DetRef.IdDescuentoEnc & _
                      " and IdDescuentoDet =" & DetRef.IdDescuentoDet & _
                      " and IdDescuentoRef =" & DetRef.IdDescuentoRef & _
                      " and IdBeneficio =" & DetRef.IdBeneficio)
            BD.Xcute(Upd.SQL())

            AnularCuota = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Shared Function AnularDetalleDescuento(ByVal Det As clsBeDescuento_det) As Boolean

        AnularDetalleDescuento = False

        Dim DT As New DataTable
        Dim lConnection As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)
        Dim lTransaction As MySql.Data.MySqlClient.MySqlTransaction = Nothing

        Try

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand()

            lConnection.Open()
            lTransaction = lConnection.BeginTransaction()

            vSQL = "DELETE FROM DESCUENTO_DET " & _
                " WHERE IDDESCUENTOENC =" & Det.IdDescuentoEnc & _
                " AND IDDESCUENTODET =" & Det.IdDescuentoDet & _
                " AND IDBENEFICIO =" & Det.Beneficio.IdBeneficio

            cmd.CommandType = CommandType.Text
            cmd = New MySqlClient.MySqlCommand(vSQL, lConnection)
            cmd.Transaction = lTransaction
            cmd.ExecuteNonQuery()

            vSQL = "DELETE FROM DESCUENTO_REF " & _
                " WHERE IDDESCUENTOENC =" & Det.IdDescuentoEnc & _
                " AND IDDESCUENTODET =" & Det.IdDescuentoDet & _
                " AND IDBENEFICIO =" & Det.Beneficio.IdBeneficio

            cmd.CommandType = CommandType.Text
            cmd = New MySqlClient.MySqlCommand(vSQL, lConnection)
            cmd.Transaction = lTransaction
            cmd.ExecuteNonQuery()

            AnularDetalleDescuento = True

            lTransaction.Commit()
            lConnection.Close()

        Catch ex As Exception
            lTransaction.Rollback()
            lConnection.Dispose()
            MsgBox(ex.Message)
        Finally
            lConnection.Dispose()
            lTransaction.Dispose()
        End Try

    End Function

    Public Shared Function GetCuotasByBeneficio(ByVal pObj As clsBeDescuento_det) As DataTable

        Dim lTable As New DataTable("Result")

        Try
            Dim lSQl As String = String.Format("SELECT IdDescuentoRef,NoCuota AS 'No. Cuota',Abonado,Monto,Pagada,FechaCobro AS 'Fecha Cobro' FROM descuento_ref " _
                                             & "WHERE IdDescuentoEnc={0} AND IdDescuentoDet={1} AND IdBeneficio={2}", _
                                             pObj.IdDescuentoEnc, pObj.IdDescuentoDet, pObj.Beneficio.IdBeneficio)

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

    Public Shared Function ActualizarByPago(ByRef oBeDescuento_ref As clsBeDescuento_ref, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Upd.Init("descuento_ref")
            Upd.Add("iddescuentoenc", "@iddescuentoenc", "F")
            Upd.Add("iddescuentodet", "@iddescuentodet", "F")
            Upd.Add("iddescuentoref", "@iddescuentoref", "F")
            Upd.Add("abonado", "@abonado", "F")
            Upd.Add("pagada", "@pagada", "F")
            Upd.Add("anulada", "@anulada", "F")
            Upd.Where("IdDescuentoEnc = @IdDescuentoEnc " & _
                "AND IdDescuentoDet = @IdDescuentoDet " & _
                "AND IdDescuentoRef = @IdDescuentoRef")

            Dim sp As String = Upd.SQL()

            Dim EsTransaccional As Boolean = (Not pConection Is Nothing AndAlso Not pTransaction Is Nothing)

            cmd.CommandType = CommandType.Text


            If EsTransaccional Then
                cmd = New MySqlClient.MySqlCommand(sp, pConection)
                cmd.Transaction = pTransaction
            Else
                cmd = New MySqlClient.MySqlCommand(sp, cnn)
                cnn.Open()
            End If

            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOENC", oBeDescuento_ref.IdDescuentoEnc))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTODET", oBeDescuento_ref.IdDescuentoDet))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOREF", oBeDescuento_ref.IdDescuentoRef))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ABONADO", oBeDescuento_ref.Abonado))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@PAGADA", oBeDescuento_ref.Pagada))
          
            Dim rowsAffected As Integer = 0
            rowsAffected = cmd.ExecuteNonQuery()
            Return rowsAffected


        Catch ex As Exception
            Throw ex
        Finally
            If cnn.State = ConnectionState.Open Then cnn.Close()
            cnn.Dispose()
            cmd.Dispose()
        End Try

    End Function

End Class
