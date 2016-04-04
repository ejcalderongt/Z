Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class clsLnDescuento_enc

    Public Function Insertar(ByRef oBeDescuento_enc As clsBeDescuento_enc, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Ins.Init("descuento_enc")
            Ins.Add("iddescuentoenc", "@iddescuentoenc", "F")
            Ins.Add("idcef", "@idcef", "F")
            Ins.Add("idfranquiciado", "@idfranquiciado", "F")
            Ins.Add("idtipodescuento", "@idtipodescuento", "F")
            Ins.Add("fec_agr", "@fec_agr", "F")
            Ins.Add("fec_mod", "@fec_mod", "F")
            Ins.Add("user_agr", "@user_agr", "F")
            Ins.Add("user_mod", "@user_mod", "F")

            Dim sp As String = Ins.SQL()

            Dim EsTransaccional As Boolean = (Not pConection Is Nothing AndAlso Not pTransaction Is Nothing)

            cmd.CommandType = CommandType.Text


            If EsTransaccional Then
                cmd = New MySqlClient.MySqlCommand(sp, pConection)
                cmd.Transaction = pTransaction
            Else

                cmd = New MySqlClient.MySqlCommand(sp, cnn)
                cnn.Open()
            End If


            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOENC", oBeDescuento_enc.IdDescuentoEnc))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDCEF", oBeDescuento_enc.CEF.IdCef))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDFRANQUICIADO", oBeDescuento_enc.Franquiciado.IdFranquiciado))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDTIPODESCUENTO", oBeDescuento_enc.IdTipoDescuento))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeDescuento_enc.Fec_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeDescuento_enc.Fec_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeDescuento_enc.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeDescuento_enc.User_mod))

            Dim rowsAffected As Integer = 0
            rowsAffected = cmd.ExecuteNonQuery()
            Return rowsAffected

            oBeDescuento_enc.IdDescuentoEnc = CInt(cmd.Parameters("@IDDESCUENTOENC").Value)

        Catch ex As Exception
            Throw ex
        Finally
            If cnn.State = ConnectionState.Open Then cnn.Close()
            cnn.Dispose()
            cmd.Dispose()
        End Try

    End Function

	Public Function Actualizar(ByRef oBeDescuento_enc As clsBeDescuento_enc, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			Upd.Init("descuento_enc")
			Upd.Add("iddescuentoenc","@iddescuentoenc","F")
			Upd.Add("idcef","@idcef","F")
			Upd.Add("idfranquiciado","@idfranquiciado","F")
			Upd.Add("idtipodescuento","@idtipodescuento","F")
			Upd.Add("fec_agr","@fec_agr","F")
			Upd.Add("fec_mod","@fec_mod","F")
			Upd.Add("user_agr","@user_agr","F")
			Upd.Add("user_mod","@user_mod","F")
			Upd.Where("IdDescuentoEnc = @IdDescuentoEnc")

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

			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOENC", oBeDescuento_enc.IdDescuentoEnc))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDCEF", oBeDescuento_enc.CEF.IdCef))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDFRANQUICIADO", oBeDescuento_enc.Franquiciado.IdFranquiciado))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDTIPODESCUENTO", oBeDescuento_enc.IdTipoDescuento))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeDescuento_enc.Fec_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeDescuento_enc.Fec_mod))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeDescuento_enc.User_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeDescuento_enc.User_mod))
			
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

	Public Function Eliminar(ByRef oBeDescuento_enc As clsBeDescuento_enc,Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			cmd.CommandType=CommandType.Text


			Dim sp As String = " Delete from Descuento_enc" & _ 
			 "  Where(IdDescuentoEnc = @IdDescuentoEnc)"
			

			Dim EsTransaccional As Boolean = (Not pConection is Nothing Andalso Not pTransaction Is Nothing)

			If EsTransaccional then 

				cmd = New MySqlClient.MySqlCommand(sp, pConection)
				cmd.Transaction = pTransaction
			Else

				cmd = New MySqlClient.MySqlCommand(sp, cnn)
				cnn.Open()

			End If


			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOENC", oBeDescuento_enc.IdDescuentoEnc))

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
			Dim sp As String = "SELECT * FROM Descuento_enc"
			
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

    Public Function Obtener(ByRef oBeDescuento_enc As clsBeDescuento_enc) As Boolean

        Try



            Dim sp As String = "SELECT * FROM Descuento_enc" & _
            " Where(IdDescuentoEnc = @IdDescuentoEnc)"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOENC", oBeDescuento_enc.IdDescuentoEnc))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                Cargar(oBeDescuento_enc, dt.Rows(0))
            Else
                Throw New Exception("No se pudo obtener el registro")
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
