Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class clsLnCef

	Public Sub Cargar(ByRef oBeCef As clsBeCef, ByRef dr As DataRow)

        Try

            With oBeCef

                .IdCef = IIf(IsDBNull(dr.Item("IdCef")), 0, dr.Item("IdCef"))

                .Municipo.IdMunicipio = IIf(IsDBNull(dr.Item("IdMunicipio")), 0, dr.Item("IdMunicipio"))
                .Municipo.IdDepartamento = IIf(IsDBNull(dr.Item("IdDepartamento")), 0, dr.Item("IdDepartamento"))
                .dMuni.Obtener(.Municipo)

                .Depto.IdDepartamento = IIf(IsDBNull(dr.Item("IdDepartamento")), 0, dr.Item("IdDepartamento"))
                .dDepto.Obtener(.Depto)

                .Reg.IdRegion = IIf(IsDBNull(dr.Item("IdRegion")), 0, dr.Item("IdRegion"))
                .dReg.Obtener(.Reg)

                .Sup.IdSupervisor = IIf(IsDBNull(dr.Item("IdSupervisor")), 0, dr.Item("IdSupervisor"))
                .dSup.Obtener(.Sup)

                .Encargado = IIf(IsDBNull(dr.Item("Encargado")), "", dr.Item("Encargado"))
                .Codigo = IIf(IsDBNull(dr.Item("Codigo")), "", dr.Item("Codigo"))
                .Descripcion = IIf(IsDBNull(dr.Item("Descripcion")), "", dr.Item("Descripcion"))
                .Celular = IIf(IsDBNull(dr.Item("Celular")), "", dr.Item("Celular"))
                .Telefono = IIf(IsDBNull(dr.Item("Telefono")), "", dr.Item("Telefono"))
                .Observaciones = IIf(IsDBNull(dr.Item("Observaciones")), "", dr.Item("Observaciones"))
                .Fec_agr = IIf(IsDBNull(dr.Item("fec_agr")), Date.Now, dr.Item("fec_agr"))
                .Fec_mod = IIf(IsDBNull(dr.Item("fec_mod")), Date.Now, dr.Item("fec_mod"))
                .User_agr = IIf(IsDBNull(dr.Item("user_agr")), 0, dr.Item("user_agr"))
                .User_mod = IIf(IsDBNull(dr.Item("user_mod")), 0, dr.Item("user_mod"))

            End With

        Catch ex As Exception
            Throw ex
        End Try

	End Sub

	Public Function Insertar(ByRef oBeCef As clsBeCef, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction= Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Ins.Init("cef")
            Ins.Add("idcef", "@idcef", "F")
            Ins.Add("idsupervisor", "@idsupervisor", "F")
            Ins.Add("idregion", "@idregion", "F")
            Ins.Add("idmunicipio", "@idmunicipio", "F")
            Ins.Add("iddepartamento", "@iddepartamento", "F")
            Ins.Add("encargado", "@encargado", "F")
            Ins.Add("codigo", "@codigo", "F")
            Ins.Add("descripcion", "@descripcion", "F")
            Ins.Add("celular", "@celular", "F")
            Ins.Add("telefono", "@telefono", "F")
            Ins.Add("observaciones", "@observaciones", "F")
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


            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDCEF", oBeCef.IdCef))            
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDSUPERVISOR", oBeCef.Sup.IdSupervisor))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDREGION", oBeCef.Reg.IdRegion))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDMUNICIPIO", oBeCef.Municipo.IdMunicipio))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDEPARTAMENTO", oBeCef.Depto.IdDepartamento))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ENCARGADO", oBeCef.Encargado))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@CODIGO", oBeCef.Codigo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@DESCRIPCION", oBeCef.Descripcion))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@CELULAR", oBeCef.Celular))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@TELEFONO", oBeCef.Telefono))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@OBSERVACIONES", oBeCef.Observaciones))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeCef.Fec_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeCef.Fec_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeCef.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeCef.User_mod))

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

    Public Function Actualizar(ByRef oBeCef As clsBeCef, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Upd.Init("cef")
            Upd.Add("idcef", "@idcef", "F")
            Upd.Add("idsupervisor", "@idsupervisor", "F")
            Upd.Add("idregion", "@idregion", "F")
            Upd.Add("idmunicipio", "@idmunicipio", "F")
            Upd.Add("iddepartamento", "@iddepartamento", "F")
            Upd.Add("encargado", "@encargado", "F")
            Upd.Add("codigo", "@codigo", "F")
            Upd.Add("descripcion", "@descripcion", "F")
            Upd.Add("celular", "@celular", "F")
            Upd.Add("telefono", "@telefono", "F")
            Upd.Add("observaciones", "@observaciones", "F")
            Upd.Add("fec_agr", "@fec_agr", "F")
            Upd.Add("fec_mod", "@fec_mod", "F")
            Upd.Add("user_agr", "@user_agr", "F")
            Upd.Add("user_mod", "@user_mod", "F")
            Upd.Where("IdCef = @IdCef")

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

            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDCEF", oBeCef.IdCef))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDSUPERVISOR", oBeCef.Sup.IdSupervisor))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDREGION", oBeCef.Reg.IdRegion))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDMUNICIPIO", oBeCef.Municipo.IdMunicipio))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDDEPARTAMENTO", oBeCef.Depto.IdDepartamento))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ENCARGADO", oBeCef.Encargado))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@CODIGO", oBeCef.Codigo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@DESCRIPCION", oBeCef.Descripcion))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@CELULAR", oBeCef.Celular))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@TELEFONO", oBeCef.Telefono))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@OBSERVACIONES", oBeCef.Observaciones))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeCef.Fec_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeCef.Fec_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeCef.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeCef.User_mod))

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


    Public Function Eliminar(ByRef oBeCef As clsBeCef, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            cmd.CommandType = CommandType.Text


            Dim sp As String = " Delete from Cef" & _
             "  Where(IdCef = @IdCef)"


            Dim EsTransaccional As Boolean = (Not pConection Is Nothing AndAlso Not pTransaction Is Nothing)

            If EsTransaccional Then

                cmd = New MySqlClient.MySqlCommand(sp, pConection)
                cmd.Transaction = pTransaction
            Else

                cmd = New MySqlClient.MySqlCommand(sp, cnn)
                cnn.Open()

            End If


            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDCEF", oBeCef.IdCef))

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

            Dim sp As String = " SELECT cef.IdCef, cefsupervisor.Nombre AS Supervisor, cefregion.Nombre AS Region, municipio.Nombre AS Municipio, " & _
                    " departamento.Nombre AS Departamento, cef.Encargado, cef.Codigo, cef.Descripcion, cef.Celular, cef.Telefono, cef.fec_agr, " & _
                    " cef.fec_mod, cef.user_agr, cef.user_mod " & _
                    " FROM  cef INNER JOIN " & _
                    " cefregion ON cef.IdRegion = cefregion.IdRegion " & _
                    " INNER JOIN cefsupervisor ON cef.IdSupervisor = cefsupervisor.IdSupervisor " & _
                    " LEFT JOIN municipio ON cef.IdMunicipio = municipio.IdMunicipio " & _
                    " AND cef.IdDepartamento= municipio.IdDepartamento " &
                    " INNER JOIN departamento ON departamento.IdDepartamento = municipio.IdDepartamento " & _
                    " WHERE  1 > 0"


            If Filtro <> "" Then
                sp += " and (cefsupervisor.Nombre like '%" & Filtro & "%'"
                sp += " or cefregion.Nombre like '%" & Filtro & "%'"
                sp += " or municipio.Nombre like '%" & Filtro & "%'"
                sp += " or cef.Encargado like '%" & Filtro & "%'"
                sp += " or cef.Codigo like '%" & Filtro & "%'"
                sp += " or cef.Descripcion like '%" & Filtro & "%')"

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
            Dim sp As String = "SELECT * FROM Cef"

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

    Public Function Obtener(ByRef oBeCef As clsBeCef, Optional ByVal Parcial As Boolean = False) As Boolean

        Obtener = False

        Try

            Dim sp As String = ""

            If oBeCef.IdCef <> 0 Then

                sp = "SELECT * FROM Cef" & _
                " Where(IdCef = @IdCef)"

            ElseIf oBeCef.Codigo.Trim <> "" Then

                sp = "SELECT * FROM Cef " & _
                " Where(Codigo= @Codigo)"

            End If

            If sp = "" Then Exit Function

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)

            If oBeCef.IdCef <> 0 Then
                dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDCEF", oBeCef.IdCef))
            ElseIf oBeCef.Codigo.Trim <> "" Then
                dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@CODIGO", oBeCef.Codigo))
            End If


            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then

                If Parcial Then
                    Cargar(oBeCef, dt.Rows(0), True)
                Else
                    Cargar(oBeCef, dt.Rows(0))
                End If

            Else
                Throw New Exception("No se pudo obtener el registro")
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Generar_Nuevo_IdCEF() As Integer

        Generar_Nuevo_IdCEF = 1

        Try

            vSQL$ = "SELECT MAX(IdCEF) + 1 AS nuevo FROM CEF "

            Dim sp As String = vSQL
            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count > 0 Then
                Generar_Nuevo_IdCEF = Integer.Parse(IIf(IsDBNull(dt.Rows(0).Item("nuevo")), "1", dt.Rows(0).Item("nuevo")).ToString)
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
