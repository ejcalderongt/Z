Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class clsLnBeneficio

    Public Function Insertar(ByRef oBeBeneficio As clsBeBeneficio, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Ins.Init("beneficio")
            Ins.Add("idbeneficio", "@idbeneficio", "F")
            Ins.Add("idtipobeneficio", "@idtipobeneficio", "F")
            Ins.Add("nombre", "@nombre", "F")
            Ins.Add("modelo", "@modelo", "F")
            Ins.Add("nochasis", "@nochasis", "F")
            Ins.Add("noplaca", "@noplaca", "F")
            Ins.Add("motor", "@motor", "F")
            Ins.Add("numerotelefono", "@numerotelefono", "F")
            Ins.Add("empresatelco", "@empresatelco", "F")
            Ins.Add("fecha_asignacion", "@fecha_asignacion", "F")
            Ins.Add("activo", "@activo", "F")
            Ins.Add("user_mod", "@user_mod", "F")
            Ins.Add("fec_agr", "@fec_agr", "F")
            Ins.Add("fec_mod", "@fec_mod", "F")
            Ins.Add("user_agr", "@user_agr", "F")

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


            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBENEFICIO", oBeBeneficio.IdBeneficio))            
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDTIPOBENEFICIO", oBeBeneficio.TipoBeneficio.IdTipoBeneficio))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOMBRE", oBeBeneficio.Nombre))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@MODELO", oBeBeneficio.Modelo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOCHASIS", oBeBeneficio.NoChasis))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOPLACA", oBeBeneficio.NoPlaca))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@MOTOR", oBeBeneficio.Motor))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NUMEROTELEFONO", oBeBeneficio.NumeroTelefono))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@EMPRESATELCO", oBeBeneficio.EmpresaTelco))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FECHA_ASIGNACION", oBeBeneficio.Fecha_asignacion))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ACTIVO", oBeBeneficio.Activo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeBeneficio.User_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeBeneficio.Fec_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeBeneficio.Fec_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeBeneficio.User_agr))

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

	Public Function Actualizar(ByRef oBeBeneficio As clsBeBeneficio, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			Upd.Init("beneficio")
			Upd.Add("idbeneficio","@idbeneficio","F")
			Upd.Add("idtipobeneficio","@idtipobeneficio","F")
			Upd.Add("nombre","@nombre","F")
			Upd.Add("modelo","@modelo","F")
			Upd.Add("nochasis","@nochasis","F")
			Upd.Add("noplaca","@noplaca","F")
			Upd.Add("motor","@motor","F")
			Upd.Add("numerotelefono","@numerotelefono","F")
			Upd.Add("empresatelco","@empresatelco","F")
			Upd.Add("fecha_asignacion","@fecha_asignacion","F")
			Upd.Add("activo","@activo","F")
			Upd.Add("user_mod","@user_mod","F")
			Upd.Add("fec_agr","@fec_agr","F")
			Upd.Add("fec_mod","@fec_mod","F")
			Upd.Add("user_agr","@user_agr","F")
			Upd.Where("IdBeneficio = @IdBeneficio")

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

			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBENEFICIO", oBeBeneficio.IdBeneficio))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDTIPOBENEFICIO", oBeBeneficio.TipoBeneficio.IdTipoBeneficio))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOMBRE", oBeBeneficio.Nombre))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@MODELO", oBeBeneficio.Modelo))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOCHASIS", oBeBeneficio.NoChasis))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOPLACA", oBeBeneficio.NoPlaca))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@MOTOR", oBeBeneficio.Motor))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NUMEROTELEFONO", oBeBeneficio.NumeroTelefono))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@EMPRESATELCO", oBeBeneficio.EmpresaTelco))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FECHA_ASIGNACION", oBeBeneficio.Fecha_asignacion))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ACTIVO", oBeBeneficio.Activo))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeBeneficio.User_mod))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeBeneficio.Fec_agr))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeBeneficio.Fec_mod))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeBeneficio.User_agr))
			
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


	Public Function Eliminar(ByRef oBeBeneficio As clsBeBeneficio,Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			cmd.CommandType=CommandType.Text


			Dim sp As String = " Delete from Beneficio" & _ 
			 "  Where(IdBeneficio = @IdBeneficio)"
			

			Dim EsTransaccional As Boolean = (Not pConection is Nothing Andalso Not pTransaction Is Nothing)

			If EsTransaccional then 

				cmd = New MySqlClient.MySqlCommand(sp, pConection)
				cmd.Transaction = pTransaction
			Else

				cmd = New MySqlClient.MySqlCommand(sp, cnn)
				cnn.Open()

			End If


			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBENEFICIO", oBeBeneficio.IdBeneficio))

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
			Dim sp As String = "SELECT * FROM Beneficio"
			
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

	Public Function Obtener(ByRef oBeBeneficio As clsBeBeneficio) As Boolean

        Try

            Dim sp As String = "SELECT * FROM Beneficio" & _
            " Where(IdBeneficio = @IdBeneficio)"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDBENEFICIO", oBeBeneficio.IdBeneficio))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                Cargar(oBeBeneficio, dt.Rows(0))
            Else
                Throw New Exception("No se pudo obtener el registro")
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try

	End Function

End Class
