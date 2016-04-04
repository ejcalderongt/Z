
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class clsLnDescuento_det

	Public Sub Cargar(ByRef oBeDescuento_det As clsBeDescuento_det, ByRef dr As DataRow)

        Try

            With oBeDescuento_det

                .IdDescuentoEnc = IIf(IsDBNull(dr.Item("IdDescuentoEnc")), 0, dr.Item("IdDescuentoEnc"))
                .IdDescuentoDet = IIf(IsDBNull(dr.Item("IdDescuentoDet")), 0, dr.Item("IdDescuentoDet"))
                .Beneficio.IdBeneficio = IIf(IsDBNull(dr.Item("IdBeneficio")), 0, dr.Item("IdBeneficio"))
                .PeriodoDescuento.IdPeriodo = IIf(IsDBNull(dr.Item("IdPeriodoDescuento")), 0, dr.Item("IdPeriodoTipoDescuento"))
                .MontoTotal = IIf(IsDBNull(dr.Item("MontoTotal")), 0.0, dr.Item("MontoTotal"))
                .Cuotas = IIf(IsDBNull(dr.Item("Cuotas")), 0.0, dr.Item("Cuotas"))
                .Fec_agr = IIf(IsDBNull(dr.Item("fec_agr")), Date.Now, dr.Item("fec_agr"))
                .Fec_mod = IIf(IsDBNull(dr.Item("fec_mod")), Date.Now, dr.Item("fec_mod"))
                .User_agr = IIf(IsDBNull(dr.Item("user_agr")), 0, dr.Item("user_agr"))
                .User_mod = IIf(IsDBNull(dr.Item("user_mod")), 0, dr.Item("user_mod"))
                .FechaAPartirDe = IIf(IsDBNull(dr.Item("user_mod")), Date.Now, dr.Item("user_mod"))
                .Activo = IIf(IsDBNull(dr.Item("activo")), Date.Now, dr.Item("activo"))

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

	End Sub

	Public Function Insertar(ByRef oBeDescuento_det As clsBeDescuento_det, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction= Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			Ins.Init("descuento_det")
			Ins.Add("iddescuentoenc","@iddescuentoenc","F")
			Ins.Add("iddescuentodet","@iddescuentodet","F")
			Ins.Add("idbeneficio","@idbeneficio","F")
			Ins.Add("idperiododescuento","@idperiododescuento","F")
            Ins.Add("montototal", "@montototal", "F")
			Ins.Add("cuotas","@cuotas","F")
			Ins.Add("fec_agr","@fec_agr","F")
			Ins.Add("fec_mod","@fec_mod","F")
			Ins.Add("user_agr","@user_agr","F")
            Ins.Add("FechaAPartirDe", "@FechaAPartirDe", "F")
            Ins.Add("activo", "@activo", "F")

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

			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOENC", oBeDescuento_det.IdDescuentoEnc))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTODET", oBeDescuento_det.IdDescuentoDet))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBENEFICIO", oBeDescuento_det.Beneficio.IdBeneficio))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDPERIODODESCUENTO", oBeDescuento_det.PeriodoDescuento.IdPeriodo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@MONTOTOTAL", oBeDescuento_det.MontoTotal))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@CUOTAS", oBeDescuento_det.Cuotas))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeDescuento_det.Fec_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeDescuento_det.Fec_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeDescuento_det.User_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeDescuento_det.User_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FechaAPartirDe", oBeDescuento_det.FechaAPartirDe))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ACTIVO", oBeDescuento_det.Activo))

			Dim rowsAffected As Integer = 0
            rowsAffected = cmd.ExecuteNonQuery()

            Upd.Init("beneficio")
            Upd.Add("fecha_asignacion", "Now()", "F")
            Upd.Where("IdBeneficio = @IdBeneficio")

            sp = Upd.SQL()

            cmd.CommandType = CommandType.Text

            If EsTransaccional Then
                cmd = New MySqlClient.MySqlCommand(sp, pConection)
                cmd.Transaction = pTransaction
            Else
                cmd = New MySqlClient.MySqlCommand(sp, cnn)
                cnn.Open()
            End If

            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBENEFICIO", oBeDescuento_det.Beneficio.IdBeneficio))
            
             rowsAffected += cmd.ExecuteNonQuery()

			Return rowsAffected

		Catch ex As Exception
			Throw ex
		Finally
			If cnn.State =ConnectionState.Open Then cnn.Close
			cnn.Dispose
			cmd.Dispose
		End Try

	End Function

	Public Function Actualizar(ByRef oBeDescuento_det As clsBeDescuento_det, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			Upd.Init("descuento_det")
			Upd.Add("iddescuentoenc","@iddescuentoenc","F")
			Upd.Add("iddescuentodet","@iddescuentodet","F")
			Upd.Add("idbeneficio","@idbeneficio","F")
			Upd.Add("idperiododescuento","@idperiododescuento","F")
            Upd.Add("montototal", "@montototal", "F")
			Upd.Add("cuotas","@cuotas","F")
			Upd.Add("fec_agr","@fec_agr","F")
			Upd.Add("fec_mod","@fec_mod","F")
			Upd.Add("user_agr","@user_agr","F")
            Upd.Add("user_mod", "@user_mod", "F")
            Upd.Add("FechaAPartirDe", "@FechaAPartirDe", "F")
            Upd.Add("activo", "@activo", "F")
            Upd.Where("IdDescuentoEnc = @IdDescuentoEnc " & _
                "AND IdDescuentoDet = @IdDescuentoDet")

			Dim sp As String = Upd.SQL()

			Dim EsTransaccional As Boolean = (Not pConection is Nothing Andalso Not pTransaction Is Nothing)

			cmd.CommandType=CommandType.Text

            If EsTransaccional Then
                cmd = New MySqlClient.MySqlCommand(sp, pConection)
                cmd.Transaction = pTransaction
            Else
                cmd = New MySqlClient.MySqlCommand(sp, cnn)
                cnn.Open()
            End If

			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOENC", oBeDescuento_det.IdDescuentoEnc))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTODET", oBeDescuento_det.IdDescuentoDet))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBENEFICIO", oBeDescuento_det.Beneficio.IdBeneficio))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDPERIODODESCUENTO", oBeDescuento_det.PeriodoDescuento.IdPeriodo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@MONTOTOTAL", oBeDescuento_det.MontoTotal))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@CUOTAS", oBeDescuento_det.Cuotas))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeDescuento_det.Fec_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeDescuento_det.Fec_mod))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeDescuento_det.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeDescuento_det.User_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FechaAPartirDe", oBeDescuento_det.FechaAPartirDe))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ACTIVO", oBeDescuento_det.Activo))
			
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


	Public Function Eliminar(ByRef oBeDescuento_det As clsBeDescuento_det,Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			cmd.CommandType=CommandType.Text


            Dim sp As String = " Delete from Descuento_det" & _
             "  Where(IdDescuentoEnc = @IdDescuentoEnc) " & _
             "  AND (IdDescuentoDet = @IdDescuentoDet)"
			

			Dim EsTransaccional As Boolean = (Not pConection is Nothing Andalso Not pTransaction Is Nothing)

			If EsTransaccional then 

				cmd = New MySqlClient.MySqlCommand(sp, pConection)
				cmd.Transaction = pTransaction
			Else

				cmd = New MySqlClient.MySqlCommand(sp, cnn)
				cnn.Open()

			End If


			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOENC", oBeDescuento_det.IdDescuentoEnc))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTODET", oBeDescuento_det.IdDescuentoDet))

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
            Dim sp As String = "SELECT * FROM Descuento_det"

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

    Public Function Obtener(ByRef oBeDescuento_det As clsBeDescuento_det) As Boolean

        Try

            Dim sp As String = "SELECT * FROM Descuento_det" & _
            " Where(IdDescuentoEnc = @IdDescuentoEnc) " & _
            "AND (IdDescuentoDet = @IdDescuentoDet)"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOENC", oBeDescuento_det.IdDescuentoEnc))
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTODET", oBeDescuento_det.IdDescuentoDet))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                Cargar(oBeDescuento_det, dt.Rows(0))
            Else
                Throw New Exception("No se pudo obtener el registro")
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
