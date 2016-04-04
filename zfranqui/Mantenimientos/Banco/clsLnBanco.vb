Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class clsLnBanco

	Public Sub Cargar(ByRef oBeBanco As clsBeBanco, ByRef dr As DataRow)
		Try
			With oBeBanco
				.IdBanco = IIf(IsDBNull(dr.Item("IdBanco")), 0, dr.Item("IdBanco"))
				.Nombre = IIf(IsDBNull(dr.Item("Nombre")), "", dr.Item("Nombre"))
				.Fec_agr = IIf(IsDBNull(dr.Item("fec_agr")), Date.Now, dr.Item("fec_agr"))
				.Fec_mod = IIf(IsDBNull(dr.Item("fec_mod")), Date.Now, dr.Item("fec_mod"))
				.User_agr = IIf(IsDBNull(dr.Item("user_agr")), 0, dr.Item("user_agr"))
				.User_mod = IIf(IsDBNull(dr.Item("user_mod")), 0, dr.Item("user_mod"))
			End With
		Catch ex As Exception
            Throw
		End Try
	End Sub

	Public Function Insertar(ByRef oBeBanco As clsBeBanco, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction= Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Ins.Init("banco")
            Ins.Add("idbanco", "@idbanco", "F")
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


            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBANCO", oBeBanco.IdBanco))            
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOMBRE", oBeBanco.Nombre))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeBanco.Fec_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeBanco.Fec_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeBanco.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeBanco.User_mod))

            Dim rowsAffected As Integer = 0
            rowsAffected = cmd.ExecuteNonQuery()
            Return rowsAffected

            oBeBanco.IdBanco = CInt(cmd.Parameters("@IDBANCO").Value)

        Catch ex As Exception
            Throw ex
        Finally
            If cnn.State = ConnectionState.Open Then cnn.Close()
            cnn.Dispose()
            cmd.Dispose()
        End Try

    End Function

    Public Function Actualizar(ByRef oBeBanco As clsBeBanco, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Upd.Init("banco")
            Upd.Add("idbanco", "@idbanco", "F")
            Upd.Add("nombre", "@nombre", "F")
            Upd.Add("fec_agr", "@fec_agr", "F")
            Upd.Add("fec_mod", "@fec_mod", "F")
            Upd.Add("user_agr", "@user_agr", "F")
            Upd.Add("user_mod", "@user_mod", "F")
            Upd.Where("IdBanco = @IdBanco")

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

            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBANCO", oBeBanco.IdBanco))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOMBRE", oBeBanco.Nombre))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeBanco.Fec_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeBanco.Fec_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeBanco.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeBanco.User_mod))

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


    Public Function Eliminar(ByRef oBeBanco As clsBeBanco, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            cmd.CommandType = CommandType.Text


            Dim sp As String = " Delete from Banco" & _
             "  Where(IdBanco = @IdBanco)"


            Dim EsTransaccional As Boolean = (Not pConection Is Nothing AndAlso Not pTransaction Is Nothing)

            If EsTransaccional Then

                cmd = New MySqlClient.MySqlCommand(sp, pConection)
                cmd.Transaction = pTransaction
            Else

                cmd = New MySqlClient.MySqlCommand(sp, cnn)
                cnn.Open()

            End If


            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBANCO", oBeBanco.IdBanco))

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

    Public Function Listar(ByVal Filtro As String) As DataTable

        Try

            Dim sp As String = "SELECT IdBanco as Codigo, Nombre FROM Banco " & _
                " WHERE 1 >0  "


            If Filtro <> "" Then
                sp += " and (IdBanco like '%" & Filtro & "%'"
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

    Public Function Listar() As DataTable
        Try
            Dim sp As String = "SELECT * FROM Banco"

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

    Public Sub Llenar_Combo(ByRef cmb As ComboBox)

        Try

            Dim sp As String = "SELECT IdBanco as Codigo, Nombre FROM Banco "

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

    Public Function Obtener(ByRef oBeBanco As clsBeBanco) As Boolean
        Try
            Dim sp As String = "SELECT * FROM Banco" & _
            " Where(IdBanco = @IdBanco)"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDBANCO", oBeBanco.IdBanco))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                Cargar(oBeBanco, dt.Rows(0))
            Else
                Throw New Exception("No se pudo obtener el registro")
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Generar_Nuevo_IdBanco() As Integer

        Generar_Nuevo_IdBanco = 1

        Try

            vSQL$ = "SELECT MAX(IdBanco) + 1 AS nuevo FROM Banco"

            Dim sp As String = vSQL
            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count > 0 Then
                Generar_Nuevo_IdBanco = Integer.Parse(IIf(IsDBNull(dt.Rows(0).Item("nuevo")), "1", dt.Rows(0).Item("nuevo")).ToString)
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
