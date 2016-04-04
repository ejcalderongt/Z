Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class clsLnFranquiciadocef

    Public Sub Cargar(ByRef oBeFranquiciadocef As clsBeFranquiciadocef, ByRef dr As DataRow)
		Try
			With oBeFranquiciadocef
                .IdAsignacionFranquiciado = IIf(IsDBNull(dr.Item("IdAsignacionFranquiciado")), 0, dr.Item("IdAsignacionFranquiciado"))
				.IdCEF = IIf(IsDBNull(dr.Item("IdCEF")), 0, dr.Item("IdCEF"))
				.IdFranquiciado = IIf(IsDBNull(dr.Item("IdFranquiciado")), 0, dr.Item("IdFranquiciado"))
				.Fec_agr = IIf(IsDBNull(dr.Item("fec_agr")), Date.Now, dr.Item("fec_agr"))
				.Fec_mod = IIf(IsDBNull(dr.Item("fec_mod")), Date.Now, dr.Item("fec_mod"))
				.User_agr = IIf(IsDBNull(dr.Item("user_agr")), 0, dr.Item("user_agr"))
				.User_mod = IIf(IsDBNull(dr.Item("user_mod")), 0, dr.Item("user_mod"))
				.Activo = IIf(IsDBNull(dr.Item("activo")), False, dr.Item("activo"))
			End With
		Catch ex As Exception
			Throw ex
		End Try
	End Sub

    Public Function Insertar(ByRef oBeFranquiciadocef As clsBeFranquiciadocef, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing, Optional ByVal EliminarPrevio As Boolean = False) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try


            Ins.Init("franquiciadocef")
            Ins.Add("idasignacionfranquiciado", "@idasignacionfranquiciado", "F")
            Ins.Add("idcef", "@idcef", "F")
            Ins.Add("idfranquiciado", "@idfranquiciado", "F")
            Ins.Add("fec_agr", "@fec_agr", "F")
            Ins.Add("fec_mod", "@fec_mod", "F")
            Ins.Add("user_agr", "@user_agr", "F")
            Ins.Add("user_mod", "@user_mod", "F")
            Ins.Add("activo", "@activo", "F")

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


            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDASIGNACIONFRANQUICIADO", oBeFranquiciadocef.IdAsignacionFranquiciado))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDCEF", oBeFranquiciadocef.IdCEF))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDFRANQUICIADO", oBeFranquiciadocef.IdFranquiciado))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeFranquiciadocef.Fec_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeFranquiciadocef.Fec_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeFranquiciadocef.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeFranquiciadocef.User_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ACTIVO", oBeFranquiciadocef.Activo))

            Dim rowsAffected As Integer = 0
            rowsAffected = cmd.ExecuteNonQuery()
            Return rowsAffected

            oBeFranquiciadocef.IdAsignacionFranquiciado = CInt(cmd.Parameters("@IDASIGNACIONFRANQUICIADO").Value)

        Catch ex As Exception
            Throw ex
        Finally
            If cnn.State = ConnectionState.Open Then cnn.Close()
            cnn.Dispose()
            cmd.Dispose()
        End Try

    End Function

    Public Function Actualizar(ByRef oBeFranquiciadocef As clsBeFranquiciadocef, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Upd.Init("franquiciadocef")
            Upd.Add("idasignacionfranquiciado", "@idasignacionfranquiciado", "F")
            Upd.Add("idcef", "@idcef", "F")
            Upd.Add("idfranquiciado", "@idfranquiciado", "F")
            'Upd.Add("fec_agr", "@fec_agr", "F")
            Upd.Add("fec_mod", "@fec_mod", "F")
            'Upd.Add("user_agr", "@user_agr", "F")
            Upd.Add("user_mod", "@user_mod", "F")
            Upd.Add("activo", "@activo", "F")
            Upd.Where("IdAsignacionFranquiciado = @IdAsignacionFranquiciado")

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

            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDASIGNACIONFRANQUICIADO", oBeFranquiciadocef.IdAsignacionFranquiciado))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDCEF", oBeFranquiciadocef.IdCEF))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDFRANQUICIADO", oBeFranquiciadocef.IdFranquiciado))
            'cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeFranquiciadocef.Fec_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeFranquiciadocef.Fec_mod))
            'cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeFranquiciadocef.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeFranquiciadocef.User_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ACTIVO", oBeFranquiciadocef.Activo))

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

    Public Function Eliminar(ByRef oBeFranquiciadocef As clsBeFranquiciadocef, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            cmd.CommandType = CommandType.Text


            Dim sp As String = " Delete from Franquiciadocef" & _
             "  Where(IdAsignacionFranquiciado = @IdAsignacionFranquiciado)"


            Dim EsTransaccional As Boolean = (Not pConection Is Nothing AndAlso Not pTransaction Is Nothing)

            If EsTransaccional Then

                cmd = New MySqlClient.MySqlCommand(sp, pConection)
                cmd.Transaction = pTransaction
            Else

                cmd = New MySqlClient.MySqlCommand(sp, cnn)
                cnn.Open()

            End If


            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDASIGNACIONFRANQUICIADO", oBeFranquiciadocef.IdAsignacionFranquiciado))

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

    Public Function Listar() As DataTable
        Try
            Dim sp As String = "SELECT * FROM Franquiciadocef"

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

    Public Function Obtener(ByRef oBeFranquiciadocef As clsBeFranquiciadocef) As Boolean

        Obtener = False

        Try

            Dim sp As String = "SELECT * FROM Franquiciadocef" & _
            " Where(IdAsignacionFranquiciado = @IdAsignacionFranquiciado)"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDASIGNACIONFRANQUICIADO", oBeFranquiciadocef.IdAsignacionFranquiciado))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                Cargar(oBeFranquiciadocef, dt.Rows(0))
                Return True
            ElseIf oBeFranquiciadocef.IdAsignacionFranquiciado <> 0 Then
                Throw New Exception("No se pudo obtener el registro")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function TieneCEFAsignado(ByRef oBeFranquiciadocef As clsBeFranquiciadocef) As Boolean

        TieneCEFAsignado = False

        Try

            Dim sp As String = "SELECT * FROM Franquiciadocef" & _
            " Where(IdFranquiciado = @IdFranquiciado)"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDFRANQUICIADO", oBeFranquiciadocef.IdFranquiciado))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                Cargar(oBeFranquiciadocef, dt.Rows(0))
                TieneCEFAsignado = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


    Public Function Generar_Nuevo_IdAsignacionFranquiciado() As Integer

        Generar_Nuevo_IdAsignacionFranquiciado = 1

        Try

            vSQL$ = "SELECT MAX(IdAsignacionFranquiciado) + 1 AS nuevo FROM franquiciadocef "

            Dim sp As String = vSQL
            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count > 0 Then
                Generar_Nuevo_IdAsignacionFranquiciado = Integer.Parse(IIf(IsDBNull(dt.Rows(0).Item("nuevo")), "1", dt.Rows(0).Item("nuevo")).ToString)
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
