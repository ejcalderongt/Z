Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class clsLnTipobeneficio

	Public Sub Cargar(ByRef oBeTipobeneficio As clsBeTipobeneficio, ByRef dr As DataRow)

        Try

            With oBeTipobeneficio
                .IdTipoBeneficio = IIf(IsDBNull(dr.Item("IdTipoBeneficio")), 0, dr.Item("IdTipoBeneficio"))
                .Nombre = IIf(IsDBNull(dr.Item("Nombre")), "", dr.Item("Nombre"))
                .Fecha_agregado = IIf(IsDBNull(dr.Item("fec_agr")), Date.Now, dr.Item("fec_agr"))
                .Fecha_modificado = IIf(IsDBNull(dr.Item("fec_mod")), Date.Now, dr.Item("fec_mod"))
                .IdUsuarioAgrego = IIf(IsDBNull(dr.Item("user_mod")), 0, dr.Item("user_mod"))
                .IdUsuarioModifico = IIf(IsDBNull(dr.Item("user_mod")), 0, dr.Item("user_mod"))
                .EsVehiculo = IIf(IsDBNull(dr.Item("EsVehiculo")), False, dr.Item("EsVehiculo"))
                .EsTelefono = IIf(IsDBNull(dr.Item("EsTelefono")), False, dr.Item("EsTelefono"))
                .EsServicio = IIf(IsDBNull(dr.Item("EsServicio")), False, dr.Item("EsServicio"))
            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function Insertar(ByRef oBeTipobeneficio As clsBeTipobeneficio, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Ins.Init("tipobeneficio")
            Ins.Add("idtipobeneficio", "@idtipobeneficio", "F")
            Ins.Add("nombre", "@nombre", "F")
            Ins.Add("fec_agr", "@fec_agr", "F")
            Ins.Add("fec_mod", "@fec_mod", "F")
            Ins.Add("user_mod", "@user_mod", "F")
            Ins.Add("user_mod", "@user_mod", "F")
            Ins.Add("esvehiculo", "@esvehiculo", "F")
            Ins.Add("estelefono", "@estelefono", "F")
            Ins.Add("esservicio", "@esservicio", "F")

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


            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDTIPOBENEFICIO", oBeTipobeneficio.IdTipoBeneficio))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOMBRE", oBeTipobeneficio.Nombre))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@fec_agr", oBeTipobeneficio.Fecha_agregado))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@fec_mod", oBeTipobeneficio.Fecha_modificado))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@user_mod", oBeTipobeneficio.IdUsuarioAgrego))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@user_mod", oBeTipobeneficio.IdUsuarioModifico))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ESVEHICULO", oBeTipobeneficio.EsVehiculo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ESTELEFONO", oBeTipobeneficio.EsTelefono))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ESERVICIO", oBeTipobeneficio.EsServicio))

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

    Public Function Actualizar(ByRef oBeTipobeneficio As clsBeTipobeneficio, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Upd.Init("tipobeneficio")
            Upd.Add("idtipobeneficio", "@idtipobeneficio", "F")
            Upd.Add("nombre", "@nombre", "F")
            Upd.Add("fec_agr", "@fec_agr", "F")
            Upd.Add("fec_mod", "@fec_mod", "F")
            Upd.Add("user_mod", "@user_mod", "F")
            Upd.Add("user_mod", "@user_mod", "F")
            Upd.Add("esvehiculo", "@esvehiculo", "F")
            Upd.Add("estelefono", "@estelefono", "F")
            Upd.Add("esservicio", "@esservicio", "F")
            Upd.Where("IdTipoBeneficio = @IdTipoBeneficio")

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

            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDTIPOBENEFICIO", oBeTipobeneficio.IdTipoBeneficio))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOMBRE", oBeTipobeneficio.Nombre))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@fec_agr", oBeTipobeneficio.Fecha_agregado))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@fec_mod", oBeTipobeneficio.Fecha_modificado))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@user_mod", oBeTipobeneficio.IdUsuarioAgrego))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@user_mod", oBeTipobeneficio.IdUsuarioModifico))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ESVEHICULO", oBeTipobeneficio.EsVehiculo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ESTELEFONO", oBeTipobeneficio.EsTelefono))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ESSERVICIO", oBeTipobeneficio.EsServicio))

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


	Public Function Eliminar(ByRef oBeTipobeneficio As clsBeTipobeneficio,Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			cmd.CommandType=CommandType.Text


			Dim sp As String = " Delete from Tipobeneficio" & _ 
			 "  Where(IdTipoBeneficio = @IdTipoBeneficio)"
			

			Dim EsTransaccional As Boolean = (Not pConection is Nothing Andalso Not pTransaction Is Nothing)

			If EsTransaccional then 

				cmd = New MySqlClient.MySqlCommand(sp, pConection)
				cmd.Transaction = pTransaction
			Else

				cmd = New MySqlClient.MySqlCommand(sp, cnn)
				cnn.Open()

			End If


			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDTIPOBENEFICIO", oBeTipobeneficio.IdTipoBeneficio))

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
            Dim sp As String = "SELECT * FROM Tipobeneficio"

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

    Public Function Obtener(ByRef oBeTipobeneficio As clsBeTipobeneficio) As Boolean

        Try

            Dim sp As String = "SELECT * FROM Tipobeneficio" & _
            " Where(IdTipoBeneficio = @IdTipoBeneficio)"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDTIPOBENEFICIO", oBeTipobeneficio.IdTipoBeneficio))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                Cargar(oBeTipobeneficio, dt.Rows(0))
            Else
                Throw New Exception("No se pudo obtener el registro")
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
