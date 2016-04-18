Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class clsLnVentasdet

    Public Function MaxID() As Integer

        Try

            Dim lMax As Integer = 0
            'Validacion y estandarizacion de los datos
            Using lConnection As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)
                'Acceso a los datos.
                Using lCommand As New MySql.Data.MySqlClient.MySqlCommand(String.Format("SELECT Max(IdVenta) FROM ventasdet"), lConnection)
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


	Public Sub Cargar(ByRef oBeVentasdet As clsBeVentasdet, ByRef dr As DataRow)
		Try
			With oBeVentasdet
				.IdVenta = IIf(IsDBNull(dr.Item("IdVenta")), 0, dr.Item("IdVenta"))
				.IdFranquiciado = IIf(IsDBNull(dr.Item("IdFranquiciado")), 0, dr.Item("IdFranquiciado"))
				.Despes = IIf(IsDBNull(dr.Item("Despes")), "", dr.Item("Despes"))
				.Cilindros = IIf(IsDBNull(dr.Item("Cilindros")), 0.0, dr.Item("Cilindros"))
				.RetencionCliente = IIf(IsDBNull(dr.Item("RetencionCliente")), 0, dr.Item("RetencionCliente"))
				.Monto = IIf(IsDBNull(dr.Item("Monto")), 0.0, dr.Item("Monto"))
                .Fecha = IIf(IsDBNull(dr.Item("Fecha")), Date.Now, dr.Item("Fecha"))
				.Pagado = IIf(IsDBNull(dr.Item("Pagado")), 0.0, dr.Item("Pagado"))
				.Saldo = IIf(IsDBNull(dr.Item("Saldo")), 0.0, dr.Item("Saldo"))
				.IdPagoEnc = IIf(IsDBNull(dr.Item("IdPagoEnc")), 0, dr.Item("IdPagoEnc"))
				.IdPagoDet = IIf(IsDBNull(dr.Item("IdPagoDet")), 0, dr.Item("IdPagoDet"))
                .Fec_agr = IIf(IsDBNull(dr.Item("fec_agr")), Date.Now, dr.Item("fec_agr"))
				.User_agr = IIf(IsDBNull(dr.Item("user_agr")), 0, dr.Item("user_agr"))
			End With
		Catch ex As Exception
			Throw ex
		End Try
	End Sub

	Public Function Insertar(ByRef oBeVentasdet As clsBeVentasdet, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction= Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			Ins.Init("ventasdet")
			Ins.Add("idventa","@idventa","F")
			Ins.Add("idfranquiciado","@idfranquiciado","F")
			Ins.Add("despes","@despes","F")
			Ins.Add("cilindros","@cilindros","F")
			Ins.Add("retencioncliente","@retencioncliente","F")
			Ins.Add("monto","@monto","F")
			Ins.Add("fecha","@fecha","F")
			Ins.Add("pagado","@pagado","F")
			Ins.Add("saldo","@saldo","F")
			Ins.Add("idpagoenc","@idpagoenc","F")
			Ins.Add("idpagodet","@idpagodet","F")
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


			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDVENTA", oBeVentasdet.IdVenta))
			cmd.Parameters("@IDVENTA").Direction = ParameterDirection.Output
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDFRANQUICIADO", oBeVentasdet.IdFranquiciado))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@DESPES", oBeVentasdet.Despes))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@CILINDROS", oBeVentasdet.Cilindros))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@RETENCIONCLIENTE", oBeVentasdet.RetencionCliente))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@MONTO", oBeVentasdet.Monto))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FECHA", oBeVentasdet.Fecha))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@PAGADO", oBeVentasdet.Pagado))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@SALDO", oBeVentasdet.Saldo))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDPAGOENC", oBeVentasdet.IdPagoEnc))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDPAGODET", oBeVentasdet.IdPagoDet))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeVentasdet.Fec_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeVentasdet.User_agr))

			Dim rowsAffected As Integer = 0
			rowsAffected = cmd.ExecuteNonQuery()
			Return rowsAffected
			
			oBeVentasdet.IdVenta = CInt(cmd.Parameters("@IDVENTA").Value)
			
		Catch ex As Exception
			Throw ex
		Finally
			If cnn.State =ConnectionState.Open Then cnn.Close
			cnn.Dispose
			cmd.Dispose
		End Try

	End Function

	Public Function Actualizar(ByRef oBeVentasdet As clsBeVentasdet, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			Upd.Init("ventasdet")
			Upd.Add("idventa","@idventa","F")
			Upd.Add("idfranquiciado","@idfranquiciado","F")
			Upd.Add("despes","@despes","F")
			Upd.Add("cilindros","@cilindros","F")
			Upd.Add("retencioncliente","@retencioncliente","F")
			Upd.Add("monto","@monto","F")
			Upd.Add("fecha","@fecha","F")
			Upd.Add("pagado","@pagado","F")
			Upd.Add("saldo","@saldo","F")
			Upd.Add("idpagoenc","@idpagoenc","F")
			Upd.Add("idpagodet","@idpagodet","F")
			Upd.Add("fec_agr","@fec_agr","F")
			Upd.Add("user_agr","@user_agr","F")
			Upd.Where("IdVenta = @IdVenta")

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

			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDVENTA", oBeVentasdet.IdVenta))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDFRANQUICIADO", oBeVentasdet.IdFranquiciado))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@DESPES", oBeVentasdet.Despes))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@CILINDROS", oBeVentasdet.Cilindros))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@RETENCIONCLIENTE", oBeVentasdet.RetencionCliente))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@MONTO", oBeVentasdet.Monto))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FECHA", oBeVentasdet.Fecha))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@PAGADO", oBeVentasdet.Pagado))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@SALDO", oBeVentasdet.Saldo))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDPAGOENC", oBeVentasdet.IdPagoEnc))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDPAGODET", oBeVentasdet.IdPagoDet))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeVentasdet.Fec_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeVentasdet.User_agr))
			
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


	Public Function Eliminar(ByRef oBeVentasdet As clsBeVentasdet,Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			cmd.CommandType=CommandType.Text


			Dim sp As String = " Delete from Ventasdet" & _ 
			 "  Where(IdVenta = @IdVenta)"
			

			Dim EsTransaccional As Boolean = (Not pConection is Nothing Andalso Not pTransaction Is Nothing)

			If EsTransaccional then 

				cmd = New MySqlClient.MySqlCommand(sp, pConection)
				cmd.Transaction = pTransaction
			Else

				cmd = New MySqlClient.MySqlCommand(sp, cnn)
				cnn.Open()

			End If


			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDVENTA", oBeVentasdet.IdVenta))

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
			Dim sp As String = "SELECT * FROM Ventasdet"
			
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

    Public Function Obtener(ByRef oBeVentasdet As clsBeVentasdet) As Boolean

        Try

            Dim sp As String = "SELECT * FROM Ventasdet" & _
            " Where(IdVenta = @IdVenta)"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDVENTA", oBeVentasdet.IdVenta))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                Cargar(oBeVentasdet, dt.Rows(0))
            Else
                Throw New Exception("No se pudo obtener el registro")
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ExisteRegistro(ByRef oBeVentasdet As clsBeVentasdet) As Boolean

        ExisteRegistro = False

        Try

            Dim sp As String = "SELECT * FROM Ventasdet" & _
            " Where(IdFranquiciado = @IdFranquiciado " & _
            " AND Fecha= @Fecha " & _
            " AND Monto = @Monto)"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDFRANQUICIADO", oBeVentasdet.IdFranquiciado))
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@FECHA", oBeVentasdet.Fecha))
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@MONTO", oBeVentasdet.Monto))


            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                ExisteRegistro = True 'Cargar(oBeVentasdet, dt.Rows(0))
                'Else
                '    Throw New Exception("No se pudo obtener el registro")
            End If

            Return ExisteRegistro

        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
