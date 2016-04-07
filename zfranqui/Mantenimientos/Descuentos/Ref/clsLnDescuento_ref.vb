
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class clsLnDescuento_ref

	Public Sub Cargar(ByRef oBeDescuento_ref As clsBeDescuento_ref, ByRef dr As DataRow)
		Try
			With oBeDescuento_ref
                .IdDescuentoEnc = IIf(IsDBNull(dr.Item("IdDescuentoEnc")), 0, dr.Item("IdDescuentoEnc"))
				.IdDescuentoDet = IIf(IsDBNull(dr.Item("IdDescuentoDet")), 0, dr.Item("IdDescuentoDet"))
				.IdDescuentoRef = IIf(IsDBNull(dr.Item("IdDescuentoRef")), 0, dr.Item("IdDescuentoRef"))
				.IdBeneficio = IIf(IsDBNull(dr.Item("IdBeneficio")), 0, dr.Item("IdBeneficio"))
				.NoCuota = IIf(IsDBNull(dr.Item("NoCuota")), 0, dr.Item("NoCuota"))
				.Monto = IIf(IsDBNull(dr.Item("Monto")), 0.0, dr.Item("Monto"))
				.Abonado = IIf(IsDBNull(dr.Item("Abonado")), 0.0, dr.Item("Abonado"))
				.FechaCobro = IIf(IsDBNull(dr.Item("FechaCobro")), Date.Now, dr.Item("FechaCobro"))
				.Pagada = IIf(IsDBNull(dr.Item("Pagada")), False, dr.Item("Pagada"))
				.Fec_agr = IIf(IsDBNull(dr.Item("fec_agr")), Date.Now, dr.Item("fec_agr"))
				.Fec_mod = IIf(IsDBNull(dr.Item("fec_mod")), Date.Now, dr.Item("fec_mod"))
				.User_agr = IIf(IsDBNull(dr.Item("user_agr")), 0, dr.Item("user_agr"))
                .User_mod = IIf(IsDBNull(dr.Item("user_mod")), 0, dr.Item("user_mod"))
                .Anulada = IIf(IsDBNull(dr.Item("anulada")), 0, dr.Item("anulada"))

			End With
		Catch ex As Exception
			Throw ex
		End Try
	End Sub

	Public Function Insertar(ByRef oBeDescuento_ref As clsBeDescuento_ref, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction= Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			Ins.Init("descuento_ref")
			Ins.Add("iddescuentoenc","@iddescuentoenc","F")
			Ins.Add("iddescuentodet","@iddescuentodet","F")
			Ins.Add("iddescuentoref","@iddescuentoref","F")
			Ins.Add("idbeneficio","@idbeneficio","F")
			Ins.Add("nocuota","@nocuota","F")
			Ins.Add("monto","@monto","F")
			Ins.Add("abonado","@abonado","F")
			Ins.Add("fechacobro","@fechacobro","F")
			Ins.Add("pagada","@pagada","F")
			Ins.Add("fec_agr","@fec_agr","F")
			Ins.Add("fec_mod","@fec_mod","F")
			Ins.Add("user_agr","@user_agr","F")
            Ins.Add("user_mod", "@user_mod", "F")
            Ins.Add("anulada", "@anulada", "F")

			Dim sp As String = Ins.SQL()

			Dim EsTransaccional As Boolean = (Not pConection is Nothing Andalso Not pTransaction Is Nothing)

			cmd.CommandType=CommandType.Text


			If EsTransaccional then 
				cmd = New MySqlClient.MySqlCommand(sp, pConection)
				cmd.Transaction = pTransaction
			Else

				cmd = New MySqlClient.MySqlCommand(sp, cnn)
				cnn.Open()
			End If


			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOENC", oBeDescuento_ref.IdDescuentoEnc))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTODET", oBeDescuento_ref.IdDescuentoDet))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOREF", oBeDescuento_ref.IdDescuentoRef))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBENEFICIO", oBeDescuento_ref.IdBeneficio))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOCUOTA", oBeDescuento_ref.NoCuota))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@MONTO", oBeDescuento_ref.Monto))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ABONADO", oBeDescuento_ref.Abonado))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FECHACOBRO", oBeDescuento_ref.FechaCobro.Date))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@PAGADA", oBeDescuento_ref.Pagada))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeDescuento_ref.Fec_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeDescuento_ref.Fec_mod))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeDescuento_ref.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeDescuento_ref.User_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ANULADA", oBeDescuento_ref.Anulada))

			Dim rowsAffected As Integer = 0
            rowsAffected = cmd.ExecuteNonQuery()

			Return rowsAffected
			
        Catch ex As Exception
            Throw ex
		Finally
			If cnn.State =ConnectionState.Open Then cnn.Close
			cnn.Dispose
			cmd.Dispose
		End Try

	End Function

	Public Function Actualizar(ByRef oBeDescuento_ref As clsBeDescuento_ref, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			Upd.Init("descuento_ref")
			Upd.Add("iddescuentoenc","@iddescuentoenc","F")
			Upd.Add("iddescuentodet","@iddescuentodet","F")
			Upd.Add("iddescuentoref","@iddescuentoref","F")
			Upd.Add("idbeneficio","@idbeneficio","F")
			Upd.Add("nocuota","@nocuota","F")
			Upd.Add("monto","@monto","F")
			Upd.Add("abonado","@abonado","F")
			Upd.Add("fechacobro","@fechacobro","F")
			Upd.Add("pagada","@pagada","F")
			Upd.Add("fec_agr","@fec_agr","F")
			Upd.Add("fec_mod","@fec_mod","F")
			Upd.Add("user_agr","@user_agr","F")
            Upd.Add("user_mod", "@user_mod", "F")
            Upd.Add("anulada", "@anulada", "F")
            Upd.Where("IdDescuentoEnc = @IdDescuentoEnc " & _
                "AND IdDescuentoDet = @IdDescuentoDet " & _
                "AND IdDescuentoRef = @IdDescuentoRef")

			Dim sp As String = Upd.SQL()

			Dim EsTransaccional As Boolean = (Not pConection is Nothing Andalso Not pTransaction Is Nothing)

			cmd.CommandType=CommandType.Text


			If EsTransaccional then 
				cmd = New MySqlClient.MySqlCommand(sp, pConection)
				cmd.Transaction = pTransaction
			Else
				cmd = New MySqlClient.MySqlCommand(sp, cnn)
				cnn.Open()
			End If

			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOENC", oBeDescuento_ref.IdDescuentoEnc))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTODET", oBeDescuento_ref.IdDescuentoDet))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOREF", oBeDescuento_ref.IdDescuentoRef))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBENEFICIO", oBeDescuento_ref.IdBeneficio))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOCUOTA", oBeDescuento_ref.NoCuota))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@MONTO", oBeDescuento_ref.Monto))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ABONADO", oBeDescuento_ref.Abonado))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FECHACOBRO", oBeDescuento_ref.FechaCobro))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@PAGADA", oBeDescuento_ref.Pagada))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeDescuento_ref.Fec_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeDescuento_ref.Fec_mod))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeDescuento_ref.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeDescuento_ref.User_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ANULADA", oBeDescuento_ref.Anulada))
			
			Dim rowsAffected As Integer = 0
			rowsAffected = cmd.ExecuteNonQuery()
			Return rowsAffected
			
			
		Catch ex As Exception
			Throw ex
		Finally
			If cnn.State =ConnectionState.Open Then cnn.Close
			cnn.Dispose
			cmd.Dispose
		End Try

	End Function


	Public Function Eliminar(ByRef oBeDescuento_ref As clsBeDescuento_ref,Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			cmd.CommandType=CommandType.Text


            Dim sp As String = " Delete from Descuento_ref" & _
             "  Where(IdDescuentoEnc = @IdDescuentoEnc) " & _
             "  AND (IdDescuentoDet = @IdDescuentoDet) " & _
             "  AND (IdDescuentoRef = @IdDescuentoRef)"
			

			Dim EsTransaccional As Boolean = (Not pConection is Nothing Andalso Not pTransaction Is Nothing)

			If EsTransaccional then 

				cmd = New MySqlClient.MySqlCommand(sp, pConection)
				cmd.Transaction = pTransaction
			Else

				cmd = New MySqlClient.MySqlCommand(sp, cnn)
				cnn.Open()

			End If


			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOENC", oBeDescuento_ref.IdDescuentoEnc))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTODET", oBeDescuento_ref.IdDescuentoDet))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOREF", oBeDescuento_ref.IdDescuentoRef))

			Dim rowsAffected As Integer = 0
			rowsAffected = cmd.ExecuteNonQuery()
			Return rowsAffected
			
			
		Catch ex As Exception
			Throw ex
		Finally
			If cnn.State =ConnectionState.Open Then cnn.Close
			cnn.Dispose
			cmd.Dispose
		End Try
	End Function

    Public Function Listar() As DataTable

        Try

            Dim sp As String = "SELECT * FROM Descuento_ref "

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

    Public Function Obtener(ByRef oBeDescuento_ref As clsBeDescuento_ref) As Boolean

        Try

            Dim sp As String = "SELECT * FROM Descuento_ref" & _
            " Where(IdDescuentoEnc = @IdDescuentoEnc) " & _
            "AND (IdDescuentoDet = @IdDescuentoDet) " & _
            "AND (IdDescuentoRef = @IdDescuentoRef)"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOENC", oBeDescuento_ref.IdDescuentoEnc))
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTODET", oBeDescuento_ref.IdDescuentoEnc))
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOREF", oBeDescuento_ref.IdDescuentoEnc))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                Cargar(oBeDescuento_ref, dt.Rows(0))
            Else
                Throw New Exception("No se pudo obtener el registro")
            End If

            Return True

        Catch ex As Exception
            Throw ex
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
