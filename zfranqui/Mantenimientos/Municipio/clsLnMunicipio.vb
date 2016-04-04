Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class clsLnMunicipio

	Public Sub Cargar(ByRef oBeMunicipio As clsBeMunicipio, ByRef dr As DataRow)
		Try
			With oBeMunicipio
				.IdMunicipio = IIf(IsDBNull(dr.Item("IdMunicipio")), 0, dr.Item("IdMunicipio"))
				.IdDepartamento = IIf(IsDBNull(dr.Item("IdDepartamento")), 0, dr.Item("IdDepartamento"))
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

	Public Function Insertar(ByRef oBeMunicipio As clsBeMunicipio, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction= Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Ins.Init("municipio")
            Ins.Add("idmunicipio", "@idmunicipio", "F")
            Ins.Add("iddepartamento", "@iddepartamento", "F")
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


            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDMUNICIPIO", oBeMunicipio.IdMunicipio))
            cmd.Parameters("@IDMUNICIPIO").Direction = ParameterDirection.Output
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDEPARTAMENTO", oBeMunicipio.IdDepartamento))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOMBRE", oBeMunicipio.Nombre))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeMunicipio.Fec_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeMunicipio.Fec_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeMunicipio.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeMunicipio.User_mod))

            Dim rowsAffected As Integer = 0
            rowsAffected = cmd.ExecuteNonQuery()
            Return rowsAffected

            oBeMunicipio.IdMunicipio = CInt(cmd.Parameters("@IDMUNICIPIO").Value)

        Catch ex As Exception
            Throw ex
        Finally
            If cnn.State = ConnectionState.Open Then cnn.Close()
            cnn.Dispose()
            cmd.Dispose()
        End Try

    End Function

    Public Function Actualizar(ByRef oBeMunicipio As clsBeMunicipio, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Upd.Init("municipio")
            Upd.Add("idmunicipio", "@idmunicipio", "F")
            'Upd.Add("iddepartamento", "@iddepartamento", "F")
            Upd.Add("nombre", "@nombre", "F")
            Upd.Add("fec_agr", "@fec_agr", "F")
            Upd.Add("fec_mod", "@fec_mod", "F")
            Upd.Add("user_agr", "@user_agr", "F")
            Upd.Add("user_mod", "@user_mod", "F")
            Upd.Where("IdMunicipio = @IdMunicipio" & _
                      " AND IdDepartamento =@IdDepartamento)")

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

            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDMUNICIPIO", oBeMunicipio.IdMunicipio))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDEPARTAMENTO", oBeMunicipio.IdDepartamento))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOMBRE", oBeMunicipio.Nombre))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeMunicipio.Fec_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeMunicipio.Fec_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeMunicipio.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeMunicipio.User_mod))

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


    Public Function Eliminar(ByRef oBeMunicipio As clsBeMunicipio, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            cmd.CommandType = CommandType.Text


            Dim sp As String = " Delete from Municipio" & _
             "  Where(IdMunicipio = @IdMunicipio " & _
             " AND IdDepartamento = @IdDepartamento) "


            Dim EsTransaccional As Boolean = (Not pConection Is Nothing AndAlso Not pTransaction Is Nothing)

            If EsTransaccional Then

                cmd = New MySqlClient.MySqlCommand(sp, pConection)
                cmd.Transaction = pTransaction
            Else

                cmd = New MySqlClient.MySqlCommand(sp, cnn)
                cnn.Open()

            End If


            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDMUNICIPIO", oBeMunicipio.IdMunicipio))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDEPARTAMENTO", oBeMunicipio.IdDepartamento))

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

            Dim sp As String = "SELECT a.IdMunicipio as Codigo, a.Nombre as Nombre, " & _
                " b.Nombre as Departamento, b.IdDepartamento  " & _
                " FROM Municipio a, Departamento B " & _
                " Where a.IdDepartamento = b.IdDepartamento "

            If Filtro <> "" Then
                sp += " and (IdMunicipio like '%" & Filtro & "%'"
                sp += " or a.Nombre like '%" & Filtro & "%'"
                sp += " or b.Nombre like '%" & Filtro & "%')"
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

    Public Sub Llenar_Combo_Por_Departamento(ByVal IdDepartamento As Integer, ByRef Cmb As ComboBox)

        Try

            If Val(IdDepartamento) <= 0 Then Exit Sub

            Dim sp As String = "SELECT a.IdMunicipio as Codigo, a.Nombre as Nombre, " & _
                " b.Nombre as Departamento " & _
                " FROM Municipio a, Departamento B " & _
                " Where a.IdDepartamento = b.IdDepartamento " & _
                " and a.IdDepartamento = " & IdDepartamento


            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable
            dad.Fill(dt)

            Cmb.DataSource = dt
            Cmb.DisplayMember = "Nombre"
            Cmb.ValueMember = "Codigo"

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function Obtener(ByRef oBeMunicipio As clsBeMunicipio) As Boolean

        Try

            Dim sp As String = "SELECT * FROM Municipio" & _
            " Where(IdMunicipio = @IdMunicipio " & _
            " and IdDepartamento =@IdDepartamento) "

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IdMunicipio", oBeMunicipio.IdMunicipio))
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IdDepartamento", oBeMunicipio.IdDepartamento))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                Cargar(oBeMunicipio, dt.Rows(0))
            Else
                Throw New Exception("No se pudo obtener el registro")
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Generar_Nuevo_IdMunicipio(ByVal IdDepartamento As Integer) As Integer

        Generar_Nuevo_IdMunicipio = 1

        Try

            vSQL$ = "SELECT MAX(IdMunicipio) + 1 AS nuevo FROM Municipio Where IdDepartamento = @IdDepartamento "

            Dim sp As String = vSQL
            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IdDepartamento", IdDepartamento))
            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count > 0 Then
                Generar_Nuevo_IdMunicipio = Integer.Parse(IIf(IsDBNull(dt.Rows(0).Item("nuevo")), "1", dt.Rows(0).Item("nuevo")).ToString)
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