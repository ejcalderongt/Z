Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class clsLnCefsupervisor

	Public Sub Cargar(ByRef oBeCefsupervisor As clsBeCefsupervisor, ByRef dr As DataRow)
		Try
			With oBeCefsupervisor
				.IdSupervisor = IIf(IsDBNull(dr.Item("IdSupervisor")), 0, dr.Item("IdSupervisor"))
				.Codigo = IIf(IsDBNull(dr.Item("Codigo")), "", dr.Item("Codigo"))
				.Nombre = IIf(IsDBNull(dr.Item("Nombre")), "", dr.Item("Nombre"))
				.Fec_agr = IIf(IsDBNull(dr.Item("fec_agr")), Date.Now, dr.Item("fec_agr"))
				.Fec_mod = IIf(IsDBNull(dr.Item("fec_mod")), Date.Now, dr.Item("fec_mod"))
				.User_agr = IIf(IsDBNull(dr.Item("user_agr")), 0, dr.Item("user_agr"))
				.User_mod = IIf(IsDBNull(dr.Item("user_mod")), 0, dr.Item("user_mod"))
			End With
		Catch ex As Exception
			Throw ex
		End Try
	End Sub

	Public Function Insertar(ByRef oBeCefsupervisor As clsBeCefsupervisor, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction= Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Ins.Init("cefsupervisor")
            Ins.Add("idsupervisor", "@idsupervisor", "F")
            Ins.Add("codigo", "@codigo", "F")
            Ins.Add("nombre", "@nombre", "F")
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


            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDSUPERVISOR", oBeCefsupervisor.IdSupervisor))            
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@CODIGO", oBeCefsupervisor.Codigo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOMBRE", oBeCefsupervisor.Nombre))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeCefsupervisor.Fec_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeCefsupervisor.Fec_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeCefsupervisor.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeCefsupervisor.User_mod))

            Dim rowsAffected As Integer = 0
            rowsAffected = cmd.ExecuteNonQuery()
            Return rowsAffected

            oBeCefsupervisor.IdSupervisor = CInt(cmd.Parameters("@IDSUPERVISOR").Value)

        Catch ex As Exception
            Throw ex
        Finally
            If cnn.State = ConnectionState.Open Then cnn.Close()
            cnn.Dispose()
            cmd.Dispose()
        End Try

    End Function

    Public Function Actualizar(ByRef oBeCefsupervisor As clsBeCefsupervisor, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Upd.Init("cefsupervisor")
            Upd.Add("idsupervisor", "@idsupervisor", "F")
            Upd.Add("codigo", "@codigo", "F")
            Upd.Add("nombre", "@nombre", "F")
            Upd.Add("fec_agr", "@fec_agr", "F")
            Upd.Add("fec_mod", "@fec_mod", "F")
            Upd.Add("user_agr", "@user_agr", "F")
            Upd.Add("user_mod", "@user_mod", "F")
            Upd.Where("IdSupervisor = @IdSupervisor")

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

            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDSUPERVISOR", oBeCefsupervisor.IdSupervisor))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@CODIGO", oBeCefsupervisor.Codigo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOMBRE", oBeCefsupervisor.Nombre))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeCefsupervisor.Fec_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeCefsupervisor.Fec_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeCefsupervisor.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeCefsupervisor.User_mod))

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


    Public Function Eliminar(ByRef oBeCefsupervisor As clsBeCefsupervisor, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            cmd.CommandType = CommandType.Text


            Dim sp As String = " Delete from Cefsupervisor" & _
             "  Where(IdSupervisor = @IdSupervisor)"


            Dim EsTransaccional As Boolean = (Not pConection Is Nothing AndAlso Not pTransaction Is Nothing)

            If EsTransaccional Then

                cmd = New MySqlClient.MySqlCommand(sp, pConection)
                cmd.Transaction = pTransaction
            Else

                cmd = New MySqlClient.MySqlCommand(sp, cnn)
                cnn.Open()

            End If


            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDSUPERVISOR", oBeCefsupervisor.IdSupervisor))

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

    Public Sub Llenar_Combo(ByRef cmb As ComboBox)

        Try

            Dim sp As String = "SELECT IdSupervisor as Codigo, Nombre FROM Cefsupervisor"


            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable
            dad.Fill(dt)

            cmb.DataSource = dt
            cmb.DisplayMember = "Nombre"
            cmb.ValueMember = "Codigo"

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function Obtener(ByRef oBeCefsupervisor As clsBeCefsupervisor) As Boolean
        Try
            Dim sp As String = "SELECT * FROM Cefsupervisor" & _
            " Where(IdSupervisor = @IdSupervisor)"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDSUPERVISOR", oBeCefsupervisor.IdSupervisor))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                Cargar(oBeCefsupervisor, dt.Rows(0))
            Else
                Throw New Exception("No se pudo obtener el registro")
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Generar_Nuevo_IdSupervisor() As Integer

        Generar_Nuevo_IdSupervisor = 1

        Try

            vSQL$ = "SELECT MAX(IdSupervisor) + 1 AS nuevo FROM cefSupervisor "

            Dim sp As String = vSQL
            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count > 0 Then
                Generar_Nuevo_IdSupervisor = Integer.Parse(IIf(IsDBNull(dt.Rows(0).Item("nuevo")), "1", dt.Rows(0).Item("nuevo")).ToString)
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
