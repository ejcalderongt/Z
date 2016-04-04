Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class clsLnBitacora

	Public Sub Cargar(ByRef oBeBitacora As clsBeBitacora, ByRef dr As DataRow)
		Try
			With oBeBitacora
				.IdBitacora = IIf(IsDBNull(dr.Item("IdBitacora")), 0, dr.Item("IdBitacora"))
				.IdUsuario = IIf(IsDBNull(dr.Item("IdUsuario")), 0, dr.Item("IdUsuario"))
                .Fecha = IIf(IsDBNull(dr.Item("fecha")), Now, dr.Item("fecha"))
				.Modulo = IIf(IsDBNull(dr.Item("modulo")), "", dr.Item("modulo"))
				.Accion = IIf(IsDBNull(dr.Item("accion")), "", dr.Item("accion"))
				.Id1 = IIf(IsDBNull(dr.Item("Id1")), 0, dr.Item("Id1"))
				.Id2 = IIf(IsDBNull(dr.Item("Id2")), 0, dr.Item("Id2"))
				.Id3 = IIf(IsDBNull(dr.Item("Id3")), 0, dr.Item("Id3"))
				.Id4 = IIf(IsDBNull(dr.Item("Id4")), 0, dr.Item("Id4"))
				.Observacion = IIf(IsDBNull(dr.Item("observacion")), "", dr.Item("observacion"))
			End With
		Catch ex As Exception
			Throw ex
		End Try
	End Sub

	Public Function Insertar(ByRef oBeBitacora As clsBeBitacora, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction= Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			Ins.Init("bitacora")
			Ins.Add("idbitacora","@idbitacora","F")
			Ins.Add("idusuario","@idusuario","F")
			Ins.Add("fecha","@fecha","F")
			Ins.Add("modulo","@modulo","F")
			Ins.Add("accion","@accion","F")
			Ins.Add("id1","@id1","F")
			Ins.Add("id2","@id2","F")
			Ins.Add("id3","@id3","F")
			Ins.Add("id4","@id4","F")
			Ins.Add("observacion","@observacion","F")

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


			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBITACORA", oBeBitacora.IdBitacora))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDUSUARIO", oBeBitacora.IdUsuario))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FECHA", oBeBitacora.Fecha))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@MODULO", oBeBitacora.Modulo))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ACCION", oBeBitacora.Accion))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ID1", oBeBitacora.Id1))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ID2", oBeBitacora.Id2))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ID3", oBeBitacora.Id3))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ID4", oBeBitacora.Id4))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@OBSERVACION", oBeBitacora.Observacion))

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

	Public Function Actualizar(ByRef oBeBitacora As clsBeBitacora, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			Upd.Init("bitacora")
			Upd.Add("idbitacora","@idbitacora","F")
			Upd.Add("idusuario","@idusuario","F")
			Upd.Add("fecha","@fecha","F")
			Upd.Add("modulo","@modulo","F")
			Upd.Add("accion","@accion","F")
			Upd.Add("id1","@id1","F")
			Upd.Add("id2","@id2","F")
			Upd.Add("id3","@id3","F")
			Upd.Add("id4","@id4","F")
			Upd.Add("observacion","@observacion","F")
			Upd.Where("IdBitacora = @IdBitacora")

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

			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBITACORA", oBeBitacora.IdBitacora))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDUSUARIO", oBeBitacora.IdUsuario))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FECHA", oBeBitacora.Fecha))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@MODULO", oBeBitacora.Modulo))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ACCION", oBeBitacora.Accion))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ID1", oBeBitacora.Id1))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ID2", oBeBitacora.Id2))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ID3", oBeBitacora.Id3))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ID4", oBeBitacora.Id4))
			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@OBSERVACION", oBeBitacora.Observacion))
			
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


	Public Function Eliminar(ByRef oBeBitacora As clsBeBitacora,Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction = Nothing) As Integer

		Dim cnn As New MySqlConnection(BD.CadenaConexion)
		Dim cmd As New MySqlCommand()

		Try

			cmd.CommandType=CommandType.Text


			Dim sp As String = " Delete from Bitacora" & _ 
			 "  Where(IdBitacora = @IdBitacora)"
			

			Dim EsTransaccional As Boolean = (Not pConection is Nothing Andalso Not pTransaction Is Nothing)

			If EsTransaccional then 

				cmd = New MySqlClient.MySqlCommand(sp, pConection)
				cmd.Transaction = pTransaction
			Else

				cmd = New MySqlClient.MySqlCommand(sp, cnn)
				cnn.Open()

			End If


			cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBITACORA", oBeBitacora.IdBitacora))

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

            Dim sp As String = "SELECT * FROM Bitacora"

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

    Public Function Obtener(ByRef oBeBitacora As clsBeBitacora) As Boolean

        Try

            Dim sp As String = "SELECT * FROM Bitacora" & _
            " Where(IdBitacora = @IdBitacora)"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDBITACORA", oBeBitacora.IdBitacora))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                Cargar(oBeBitacora, dt.Rows(0))
            Else
                Throw New Exception("No se pudo obtener el registro")
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
