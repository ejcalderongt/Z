Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class clsLnPago_det

	Public Sub Cargar(ByRef oBePago_det As clsBePago_det, ByRef dr As DataRow)
		Try
			With oBePago_det
				.IdPagoDet = IIf(IsDBNull(dr.Item("IdPagoDet")), 0, dr.Item("IdPagoDet"))
				.IdPagoEnc = IIf(IsDBNull(dr.Item("IdPagoEnc")), 0, dr.Item("IdPagoEnc"))
				.IdDescuentoEnc = IIf(IsDBNull(dr.Item("IdDescuentoEnc")), 0, dr.Item("IdDescuentoEnc"))
				.IdDescuentoDet = IIf(IsDBNull(dr.Item("IdDescuentoDet")), 0, dr.Item("IdDescuentoDet"))
				.IdDescuentoRef = IIf(IsDBNull(dr.Item("IdDescuentoRef")), 0, dr.Item("IdDescuentoRef"))
				.IdBeneficio = IIf(IsDBNull(dr.Item("IdBeneficio")), 0, dr.Item("IdBeneficio"))
				.NoCuota = IIf(IsDBNull(dr.Item("NoCuota")), 0, dr.Item("NoCuota"))
				.MontoCuota = IIf(IsDBNull(dr.Item("MontoCuota")), 0.0, dr.Item("MontoCuota"))
				.MontoAbono = IIf(IsDBNull(dr.Item("MontoAbono")), 0.0, dr.Item("MontoAbono"))
				.Fec_agr = IIf(IsDBNull(dr.Item("fec_agr")), Date.Now, dr.Item("fec_agr"))
				.Fec_mod = IIf(IsDBNull(dr.Item("fec_mod")), Date.Now, dr.Item("fec_mod"))
				.User_agr = IIf(IsDBNull(dr.Item("user_agr")), 0, dr.Item("user_agr"))
				.User_mod = IIf(IsDBNull(dr.Item("user_mod")), 0, dr.Item("user_mod"))
			End With
		Catch ex As Exception
			Throw ex
		End Try
	End Sub

	Public Function Insertar(ByRef oBePago_det As clsBePago_det, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction= Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			Ins.Init("pago_det")
			Ins.Add("idpagodet","@idpagodet","F")
			Ins.Add("idpagoenc","@idpagoenc","F")
			Ins.Add("iddescuentoenc","@iddescuentoenc","F")
			Ins.Add("iddescuentodet","@iddescuentodet","F")
			Ins.Add("iddescuentoref","@iddescuentoref","F")
			Ins.Add("idbeneficio","@idbeneficio","F")
			Ins.Add("nocuota","@nocuota","F")
			Ins.Add("montocuota","@montocuota","F")
			Ins.Add("montoabono","@montoabono","F")
			Ins.Add("fec_agr","@fec_agr","F")
			Ins.Add("fec_mod","@fec_mod","F")
			Ins.Add("user_agr","@user_agr","F")
			Ins.Add("user_mod","@user_mod","F")

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


			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDPAGODET", oBePago_det.IdPagoDet))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDPAGOENC", oBePago_det.IdPagoEnc))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOENC", oBePago_det.IdDescuentoEnc))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTODET", oBePago_det.IdDescuentoDet))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOREF", oBePago_det.IdDescuentoRef))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBENEFICIO", oBePago_det.IdBeneficio))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOCUOTA", oBePago_det.NoCuota))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@MONTOCUOTA", oBePago_det.MontoCuota))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@MONTOABONO", oBePago_det.MontoAbono))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBePago_det.Fec_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBePago_det.Fec_mod))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBePago_det.User_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBePago_det.User_mod))

			Dim rowsAffected As Integer = 0
			rowsAffected = cmd.ExecuteNonQuery()
			Return rowsAffected
			
			oBePago_det.IdPagoDet = CInt(cmd.Parameters("@IDPAGODET").Value)
			
		Catch ex As Exception
			Throw ex
		Finally
			If cnn.State =ConnectionState.Open Then cnn.Close
			cnn.Dispose
			cmd.Dispose
		End Try

	End Function

	Public Function Actualizar(ByRef oBePago_det As clsBePago_det, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			Upd.Init("pago_det")
			Upd.Add("idpagodet","@idpagodet","F")
			Upd.Add("idpagoenc","@idpagoenc","F")
			Upd.Add("iddescuentoenc","@iddescuentoenc","F")
			Upd.Add("iddescuentodet","@iddescuentodet","F")
			Upd.Add("iddescuentoref","@iddescuentoref","F")
			Upd.Add("idbeneficio","@idbeneficio","F")
			Upd.Add("nocuota","@nocuota","F")
			Upd.Add("montocuota","@montocuota","F")
			Upd.Add("montoabono","@montoabono","F")
			Upd.Add("fec_agr","@fec_agr","F")
			Upd.Add("fec_mod","@fec_mod","F")
			Upd.Add("user_agr","@user_agr","F")
			Upd.Add("user_mod","@user_mod","F")
            Upd.Where("IdPagoDet = @IdPagoDet " & _
                "AND IdPagoEnc = @IdPagoEnc")

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

			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDPAGODET", oBePago_det.IdPagoDet))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDPAGOENC", oBePago_det.IdPagoEnc))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOENC", oBePago_det.IdDescuentoEnc))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTODET", oBePago_det.IdDescuentoDet))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOREF", oBePago_det.IdDescuentoRef))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBENEFICIO", oBePago_det.IdBeneficio))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOCUOTA", oBePago_det.NoCuota))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@MONTOCUOTA", oBePago_det.MontoCuota))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@MONTOABONO", oBePago_det.MontoAbono))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBePago_det.Fec_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBePago_det.Fec_mod))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBePago_det.User_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBePago_det.User_mod))
			
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


	Public Function Eliminar(ByRef oBePago_det As clsBePago_det,Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			cmd.CommandType=CommandType.Text


            Dim sp As String = " Delete from Pago_det" & _
             "  Where(IdPagoDet = @IdPagoDet) " & _
             "  AND (IdPagoEnc = @IdPagoEnc)"
			

			Dim EsTransaccional As Boolean = (Not pConection is Nothing Andalso Not pTransaction Is Nothing)

			If EsTransaccional then 

				cmd = New MySqlClient.MySqlCommand(sp, pConection)
				cmd.Transaction = pTransaction
			Else

				cmd = New MySqlClient.MySqlCommand(sp, cnn)
				cnn.Open()

			End If


			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDPAGODET", oBePago_det.IdPagoDet))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDPAGOENC", oBePago_det.IdPagoEnc))

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
			Dim sp As String = "SELECT * FROM Pago_det"
			
			Dim cnn As New MySqlConnection(BD.CadenaConexion)
			Dim cmd As New MySqlCommand(sp, cnn)
			cmd.CommandType=CommandType.Text

			
			Dim dad As New MySqlDataAdapter(cmd)
			
			Dim dt As New DataTable
			dad.Fill(dt)
			
			Return dt
		Catch ex As Exception
			Throw ex
		End Try
	End Function

	Public Function Obtener(ByRef oBePago_det As clsBePago_det) As Boolean
		Try
            Dim sp As String = "SELECT * FROM Pago_det" & _
            " Where(IdPagoDet = @IdPagoDet) " & _
            "AND (IdPagoEnc = @IdPagoEnc)"
			
			Dim cnn As New MySqlConnection(BD.CadenaConexion)
			Dim cmd As New MySqlCommand(sp, cnn)
			cmd.CommandType=CommandType.Text

			
			Dim dad As New MySqlDataAdapter(cmd)
			dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDPAGODET", oBePago_det.IdPagoDet))
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDPAGOENC", oBePago_det.IdPagoEnc))
			
			Dim dt As New DataTable
			dad.Fill(dt)
			
			If dt.Rows.Count = 1 Then
				Cargar(oBePago_det, dt.Rows(0))
			Else
				Throw New Exception("No se pudo obtener el registro")
			End If
			
			Return True
		Catch ex As Exception
			Throw ex
		End Try
	End Function

End Class
