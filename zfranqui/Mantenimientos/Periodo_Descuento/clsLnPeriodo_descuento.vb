Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class clsLnPeriodo_descuento

	Public Sub Cargar(ByRef oBePeriodo_descuento As clsBePeriodo_descuento, ByRef dr As DataRow)

        Try

            With oBePeriodo_descuento
                .IdPeriodo = IIf(IsDBNull(dr.Item("IdPeriodo")), 0, dr.Item("IdPeriodo"))
                .Nombre = IIf(IsDBNull(dr.Item("Nombre")), "", dr.Item("Nombre"))
                .Dias = IIf(IsDBNull(dr.Item("Dias")), 0, dr.Item("Dias"))
                .Fec_agr = IIf(IsDBNull(dr.Item("fec_agr")), Date.Now, dr.Item("fec_agr"))
                .Fec_mod = IIf(IsDBNull(dr.Item("fec_mod")), Date.Now, dr.Item("fec_mod"))
                .User_agr = IIf(IsDBNull(dr.Item("user_agr")), 0, dr.Item("user_agr"))
                .User_mod = IIf(IsDBNull(dr.Item("user_mod")), 0, dr.Item("user_mod"))
            End With

        Catch ex As Exception
            Throw ex
        End Try

	End Sub

	Public Function Insertar(ByRef oBePeriodo_descuento As clsBePeriodo_descuento, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction= Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			Ins.Init("periodo_descuento")
			Ins.Add("idperiodo","@idperiodo","F")
			Ins.Add("nombre","@nombre","F")
			Ins.Add("dias","@dias","F")
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


			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDPERIODO", oBePeriodo_descuento.IdPeriodo))			
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOMBRE", oBePeriodo_descuento.Nombre))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@DIAS", oBePeriodo_descuento.Dias))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBePeriodo_descuento.Fec_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBePeriodo_descuento.Fec_mod))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBePeriodo_descuento.User_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBePeriodo_descuento.User_mod))

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

	Public Function Actualizar(ByRef oBePeriodo_descuento As clsBePeriodo_descuento, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			Upd.Init("periodo_descuento")
			Upd.Add("idperiodo","@idperiodo","F")
			Upd.Add("nombre","@nombre","F")
			Upd.Add("dias","@dias","F")
			Upd.Add("fec_agr","@fec_agr","F")
			Upd.Add("fec_mod","@fec_mod","F")
			Upd.Add("user_agr","@user_agr","F")
			Upd.Add("user_mod","@user_mod","F")
			Upd.Where("IdPeriodo = @IdPeriodo")

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

			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDPERIODO", oBePeriodo_descuento.IdPeriodo))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOMBRE", oBePeriodo_descuento.Nombre))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@DIAS", oBePeriodo_descuento.Dias))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBePeriodo_descuento.Fec_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBePeriodo_descuento.Fec_mod))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBePeriodo_descuento.User_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBePeriodo_descuento.User_mod))
			
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


	Public Function Eliminar(ByRef oBePeriodo_descuento As clsBePeriodo_descuento,Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			cmd.CommandType=CommandType.Text


			Dim sp As String = " Delete from Periodo_descuento" & _ 
			 "  Where(IdPeriodo = @IdPeriodo)"
			

			Dim EsTransaccional As Boolean = (Not pConection is Nothing Andalso Not pTransaction Is Nothing)

			If EsTransaccional then 

				cmd = New MySqlClient.MySqlCommand(sp, pConection)
				cmd.Transaction = pTransaction
			Else

				cmd = New MySqlClient.MySqlCommand(sp, cnn)
				cnn.Open()

			End If


			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDPERIODO", oBePeriodo_descuento.IdPeriodo))

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

    Public Function Listar(ByVal Filtro As String) As DataTable

        Try

            Dim sp As String = "SELECT IdPeriodo as Codigo, Nombre, Dias FROM Periodo_descuento Where 1 > 0"

            If Filtro <> "" Then
                sp += " and (IdPeriodo like '%" & Filtro & "%'"
                sp += " or Nombre like '%" & Filtro & "%')"
            End If


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

    Public Function Obtener(ByRef oBePeriodo_descuento As clsBePeriodo_descuento) As Boolean

        Try

            Dim sp As String = "SELECT * FROM Periodo_descuento" & _
            " Where(IdPeriodo = @IdPeriodo)"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDPERIODO", oBePeriodo_descuento.IdPeriodo))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                Cargar(oBePeriodo_descuento, dt.Rows(0))
            Else
                Throw New Exception("No se pudo obtener el registro")
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Generar_Nuevo_IdPeriodoBeneficio() As Integer

        Generar_Nuevo_IdPeriodoBeneficio = 1

        Try

            vSQL$ = "SELECT MAX(IdPeriodo) + 1 AS nuevo FROM periodo_descuento "

            Dim sp As String = vSQL
            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count > 0 Then
                Generar_Nuevo_IdPeriodoBeneficio = Integer.Parse(IIf(IsDBNull(dt.Rows(0).Item("nuevo")), "1", dt.Rows(0).Item("nuevo")).ToString)
            End If

            cnn.Dispose()
            cmd.Dispose()
            dad.Dispose()
            dt.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

End Class
