Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class clsLnVentasenc

    

	Public Sub Cargar(ByRef oBeVentasenc As clsBeVentasenc, ByRef dr As DataRow)
		Try
			With oBeVentasenc
				.IdPeriodoVenta = IIf(IsDBNull(dr.Item("IdPeriodoVenta")), 0, dr.Item("IdPeriodoVenta"))
				.IdCEF = IIf(IsDBNull(dr.Item("IdCEF")), 0, dr.Item("IdCEF"))
				.IdFranquiciado = IIf(IsDBNull(dr.Item("IdFranquiciado")), 0, dr.Item("IdFranquiciado"))
                .FechaDesde = IIf(IsDBNull(dr.Item("FechaDesde")), Now.Date, dr.Item("FechaDesde"))
                .FechaHasta = IIf(IsDBNull(dr.Item("FechaHasta")), Now.Date, dr.Item("FechaHasta"))
				.Monto = IIf(IsDBNull(dr.Item("Monto")), 0.0, dr.Item("Monto"))
				.Pagado = IIf(IsDBNull(dr.Item("Pagado")), 0.0, dr.Item("Pagado"))
				.Saldo = IIf(IsDBNull(dr.Item("Saldo")), 0.0, dr.Item("Saldo"))
                .Fec_agr = IIf(IsDBNull(dr.Item("fec_agr")), Now.Date, dr.Item("fec_agr"))
				.User_agr = IIf(IsDBNull(dr.Item("user_agr")), 0, dr.Item("user_agr"))
			End With
		Catch ex As Exception
			Throw ex
		End Try
	End Sub

	Public Function Insertar(ByRef oBeVentasenc As clsBeVentasenc, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction= Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			Ins.Init("ventasenc")
			Ins.Add("idperiodoventa","@idperiodoventa","F")
			Ins.Add("idcef","@idcef","F")
			Ins.Add("idfranquiciado","@idfranquiciado","F")
			Ins.Add("fechadesde","@fechadesde","F")
			Ins.Add("fechahasta","@fechahasta","F")
			Ins.Add("monto","@monto","F")
			Ins.Add("pagado","@pagado","F")
			Ins.Add("saldo","@saldo","F")
			Ins.Add("fec_agr","@fec_agr","F")
			Ins.Add("user_agr","@user_agr","F")

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


			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDPERIODOVENTA", oBeVentasenc.IdPeriodoVenta))
			cmd.Parameters("@IDPERIODOVENTA").Direction = ParameterDirection.Output
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDCEF", oBeVentasenc.IdCEF))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDFRANQUICIADO", oBeVentasenc.IdFranquiciado))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FECHADESDE", oBeVentasenc.FechaDesde))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FECHAHASTA", oBeVentasenc.FechaHasta))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@MONTO", oBeVentasenc.Monto))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@PAGADO", oBeVentasenc.Pagado))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@SALDO", oBeVentasenc.Saldo))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeVentasenc.Fec_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeVentasenc.User_agr))

			Dim rowsAffected As Integer = 0
			rowsAffected = cmd.ExecuteNonQuery()
			Return rowsAffected
			
			oBeVentasenc.IdPeriodoVenta = CInt(cmd.Parameters("@IDPERIODOVENTA").Value)
			
		Catch ex As Exception
			Throw ex
		Finally
			If cnn.State =ConnectionState.Open Then cnn.Close
			cnn.Dispose
			cmd.Dispose
		End Try

	End Function

	Public Function Actualizar(ByRef oBeVentasenc As clsBeVentasenc, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			Upd.Init("ventasenc")
            'Upd.Add("idperiodoventa","@idperiodoventa","F")
            'Upd.Add("idcef","@idcef","F")
            'Upd.Add("idfranquiciado","@idfranquiciado","F")
            'Upd.Add("fechadesde","@fechadesde","F")
            'Upd.Add("fechahasta","@fechahasta","F")
            'Upd.Add("monto","@monto","F")
			Upd.Add("pagado","@pagado","F")
			Upd.Add("saldo","@saldo","F")
            Upd.Add("fec_agr", "@fec_agr", "F")
			Upd.Add("user_agr","@user_agr","F")
			Upd.Where("IdPeriodoVenta = @IdPeriodoVenta")

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

			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDPERIODOVENTA", oBeVentasenc.IdPeriodoVenta))
            '         cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDCEF", oBeVentasenc.IdCEF))
            'cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDFRANQUICIADO", oBeVentasenc.IdFranquiciado))
            'cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FECHADESDE", oBeVentasenc.FechaDesde))
            'cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FECHAHASTA", oBeVentasenc.FechaHasta))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@MONTO", oBeVentasenc.Monto))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@PAGADO", oBeVentasenc.Pagado))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@SALDO", oBeVentasenc.MontoInicial - oBeVentasenc.Pagado))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeVentasenc.Fec_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeVentasenc.User_agr))
			
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


	Public Function Eliminar(ByRef oBeVentasenc As clsBeVentasenc,Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			cmd.CommandType=CommandType.Text


			Dim sp As String = " Delete from Ventasenc" & _ 
			 "  Where(IdPeriodoVenta = @IdPeriodoVenta)"
			

			Dim EsTransaccional As Boolean = (Not pConection is Nothing Andalso Not pTransaction Is Nothing)

			If EsTransaccional then 

				cmd = New MySqlClient.MySqlCommand(sp, pConection)
				cmd.Transaction = pTransaction
			Else

				cmd = New MySqlClient.MySqlCommand(sp, cnn)
				cnn.Open()

			End If


			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDPERIODOVENTA", oBeVentasenc.IdPeriodoVenta))

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
			Dim sp As String = "SELECT * FROM Ventasenc"
			
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

	Public Function Obtener(ByRef oBeVentasenc As clsBeVentasenc) As Boolean
		Try
			Dim sp As String = "SELECT * FROM Ventasenc" & _ 
			" Where(IdPeriodoVenta = @IdPeriodoVenta)"
			
			Dim cnn As New MySqlConnection(BD.CadenaConexion)
			Dim cmd As New MySqlCommand(sp, cnn)
			cmd.CommandType=CommandType.Text

			
			Dim dad As New MySqlDataAdapter(cmd)
			dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDPERIODOVENTA", oBeVentasenc.IdPeriodoVenta))
			
			Dim dt As New DataTable
			dad.Fill(dt)
			
			If dt.Rows.Count = 1 Then
				Cargar(oBeVentasenc, dt.Rows(0))
			Else
				Throw New Exception("No se pudo obtener el registro")
			End If
			
			Return True
		Catch ex As Exception
			Throw ex
		End Try
	End Function

    Public Function ExisteRegistro(ByRef oBeVentasdet As clsBeVentasenc) As Boolean

        ExisteRegistro = False

        Try

            Dim sp As String = "SELECT * FROM Ventasenc" & _
            " Where(IdFranquiciado = @IdFranquiciado " & _
            " AND FechaDesde>= @FechaDesde " & _
            " AND FechaHasta <= @FechaHasta)"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDFRANQUICIADO", oBeVentasdet.IdFranquiciado))
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@FECHADESDE", oBeVentasdet.FechaDesde))
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@FECHAHASTA", oBeVentasdet.FechaHasta))


            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                ExisteRegistro = True
            End If

            Return ExisteRegistro

        Catch ex As Exception
            Throw ex
        End Try


    End Function

    

End Class
