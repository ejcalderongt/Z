Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class clsLnDepartamento

	Public Sub Cargar(ByRef oBeDepartamento As clsBeDepartamento, ByRef dr As DataRow)
		Try
			With oBeDepartamento
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

	Public Function Insertar(ByRef oBeDepartamento As clsBeDepartamento, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction= Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Ins.Init("departamento")
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

            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDEPARTAMENTO", oBeDepartamento.IdDepartamento))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOMBRE", oBeDepartamento.Nombre))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeDepartamento.Fec_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeDepartamento.Fec_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeDepartamento.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeDepartamento.User_mod))

            Dim rowsAffected As Integer = 0
            rowsAffected = cmd.ExecuteNonQuery()
            Return rowsAffected

            oBeDepartamento.IdDepartamento = CInt(cmd.Parameters("@IDDEPARTAMENTO").Value)

        Catch ex As Exception
            Throw ex
        Finally
            If cnn.State = ConnectionState.Open Then cnn.Close()
            cnn.Dispose()
            cmd.Dispose()
        End Try

    End Function

    Public Function Actualizar(ByRef oBeDepartamento As clsBeDepartamento, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Upd.Init("departamento")
            Upd.Add("iddepartamento", "@iddepartamento", "F")
            Upd.Add("nombre", "@nombre", "F")
            Upd.Add("fec_agr", "@fec_agr", "F")
            Upd.Add("fec_mod", "@fec_mod", "F")
            Upd.Add("user_agr", "@user_agr", "F")
            Upd.Add("user_mod", "@user_mod", "F")
            Upd.Where("IdDepartamento = @IdDepartamento")

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

            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDEPARTAMENTO", oBeDepartamento.IdDepartamento))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOMBRE", oBeDepartamento.Nombre))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeDepartamento.Fec_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeDepartamento.Fec_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeDepartamento.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeDepartamento.User_mod))

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

    Public Function Eliminar(ByRef oBeDepartamento As clsBeDepartamento, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            cmd.CommandType = CommandType.Text


            Dim sp As String = " Delete from Departamento" & _
             "  Where(IdDepartamento = @IdDepartamento)"


            Dim EsTransaccional As Boolean = (Not pConection Is Nothing AndAlso Not pTransaction Is Nothing)

            If EsTransaccional Then

                cmd = New MySqlClient.MySqlCommand(sp, pConection)
                cmd.Transaction = pTransaction
            Else

                cmd = New MySqlClient.MySqlCommand(sp, cnn)
                cnn.Open()

            End If


            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDEPARTAMENTO", oBeDepartamento.IdDepartamento))

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

            Dim sp As String = "SELECT IdDepartamento as Codigo, Nombre FROM Departamento " & _
                " WHERE 1 >0  "


            If Filtro <> "" Then
                sp += " and (IdDepartamento like '%" & Filtro & "%'"
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

            Dim sp As String = "SELECT * FROM Departamento"

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

            Dim sp As String = "SELECT IdDepartamento as Codigo, Nombre FROM Departamento"

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

    Public Function Obtener(ByRef oBeDepartamento As clsBeDepartamento) As Boolean
        Try
            Dim sp As String = "SELECT * FROM Departamento" & _
            " Where(IdDepartamento = @IdDepartamento)"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDDEPARTAMENTO", oBeDepartamento.IdDepartamento))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                Cargar(oBeDepartamento, dt.Rows(0))
            Else
                Throw New Exception("No se pudo obtener el registro")
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Generar_Nuevo_IdDepartamento() As Integer

        Generar_Nuevo_IdDepartamento = 1

        Try

            vSQL$ = "SELECT MAX(IdDepartamento) + 1 AS nuevo FROM Departamento "

            Dim sp As String = vSQL
            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count > 0 Then
                Generar_Nuevo_IdDepartamento = Integer.Parse(IIf(IsDBNull(dt.Rows(0).Item("nuevo")), "1", dt.Rows(0).Item("nuevo")).ToString)
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
