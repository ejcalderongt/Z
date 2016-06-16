Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class clsLnUsuario

    Public Sub Cargar(ByRef oBeUsuario As clsBeUsuario, ByRef dr As DataRow)

        Try

            With oBeUsuario

                .IdUsuario = Int32.Parse(IIf(IsDBNull(dr.Item("IdUsuario")), 0, dr.Item("IdUsuario")).ToString)
                .Nombre = IIf(IsDBNull(dr.Item("Nombre")), "", dr.Item("Nombre")).ToString
                .Activo = Int32.Parse(IIf(IsDBNull(dr.Item("Activo")), 0, dr.Item("Activo")).ToString)
                .Codigo = IIf(IsDBNull(dr.Item("Codigo")), "", dr.Item("Codigo")).ToString
                .Clave = IIf(IsDBNull(dr.Item("Clave")), "", dr.Item("Clave")).ToString
                .IdRol = Int32.Parse(IIf(IsDBNull(dr.Item("IdRol")), 0, dr.Item("IdRol")).ToString)
                .User_agr = IIf(IsDBNull(dr.Item("user_agr")), "", dr.Item("user_agr")).ToString
                .Fec_agr = DateTime.Parse(IIf(IsDBNull(dr.Item("fec_agr")), Date.Now, dr.Item("fec_agr")).ToString)
                .User_mod = IIf(IsDBNull(dr.Item("user_mod")), "", dr.Item("user_mod")).ToString
                .Fec_mod = DateTime.Parse(IIf(IsDBNull(dr.Item("fec_mod")), Date.Now, dr.Item("fec_mod")).ToString)
                .Ultimo_login = DateTime.Parse(IIf(IsDBNull(dr.Item("UltimoIngreso")), Date.Now, dr.Item("UltimoIngreso")).ToString)

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function Insertar(ByRef oBeUsuario As clsBeUsuario, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Ins.Init("usuario")
            Ins.Add("idusuario", "@idusuario", "F")
            Ins.Add("nombre", "@nombre", "F")
            Ins.Add("activo", "@activo", "F")
            Ins.Add("codigo", "@codigo", "F")
            Ins.Add("clave", "@clave", "F")
            Ins.Add("idrol", "@idrol", "F")
            Ins.Add("user_agr", "@user_agr", "F")
            Ins.Add("fec_agr", "@fec_agr", "F")
            Ins.Add("user_mod", "@user_mod", "F")
            Ins.Add("fec_mod", "@fec_mod", "F")

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


            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDUSUARIO", oBeUsuario.IdUsuario))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOMBRE", oBeUsuario.Nombre))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ACTIVO", oBeUsuario.Activo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@CODIGO", oBeUsuario.Codigo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@CLAVE", oBeUsuario.Clave))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDROL", oBeUsuario.IdRol))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeUsuario.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeUsuario.Fec_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeUsuario.User_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeUsuario.Fec_mod))

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

    Public Function Actualizar(ByRef oBeUsuario As clsBeUsuario, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Upd.Init("usuario")
            Upd.Add("idusuario", "@idusuario", "F")
            Upd.Add("nombre", "@nombre", "F")
            Upd.Add("activo", "@activo", "F")
            Upd.Add("Codigo", "@codigo", "F")
            Upd.Add("clave", "@clave", "F")
            Upd.Add("idrol", "@idrol", "F")
            Upd.Add("user_mod", "@user_mod", "F")
            Upd.Add("fec_mod", "@fec_mod", "F")
            Upd.Where("IdUsuario = @IdUsuario")

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

            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDUSUARIO", oBeUsuario.IdUsuario))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOMBRE", oBeUsuario.Nombre))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ACTIVO", oBeUsuario.Activo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@CODIGO", oBeUsuario.Codigo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@CLAVE", oBeUsuario.Clave))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDROL", oBeUsuario.IdRol))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeUsuario.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeUsuario.Fec_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeUsuario.User_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeUsuario.Fec_mod))

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


    Public Function Eliminar(ByRef oBeUsuario As clsBeUsuario, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            cmd.CommandType = CommandType.Text


            Dim sp As String = " Delete from Usuario" & _
             "  Where(IdUsuario = @IdUsuario)"


            Dim EsTransaccional As Boolean = (Not pConection Is Nothing AndAlso Not pTransaction Is Nothing)

            If EsTransaccional Then

                cmd = New MySqlClient.MySqlCommand(sp, pConection)
                cmd.Transaction = pTransaction
            Else

                cmd = New MySqlClient.MySqlCommand(sp, cnn)
                cnn.Open()

            End If


            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDUSUARIO", oBeUsuario.IdUsuario))

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
            Dim sp As String = "SELECT * FROM Usuario"

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

    Public Function Listar(ByVal Activos As Boolean, Filtro As String) As DataTable

        Try

            Dim sp As String = "SELECT IdUsuario as Codigo, nombre as Nombre, " & _
                " UltimoIngreso as Ultimo_Ingreso, Activo " & _
                "FROM Usuario WHERE 1 >0  "

            If Activos Then
                sp += " and activo =1 "
            End If

            If Filtro <> "" Then
                sp += " and (IdUsuario like '%" & Filtro & "%'"
                sp += " or nombres like '%" & Filtro & "%')"
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

    Public Function Obtener(ByRef oBeUsuario As clsBeUsuario) As Boolean
        Try
            Dim sp As String = "SELECT * FROM Usuario" & _
            " Where(IdUsuario = @IdUsuario)"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDUSUARIO", oBeUsuario.IdUsuario))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                Cargar(oBeUsuario, dt.Rows(0))
            ElseIf Not oBeUsuario.IdUsuario = 0 Then
                Throw New Exception("No se pudo obtener el registro")
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Usuario_Valido(ByRef oBeUsuario As clsBeUsuario) As Boolean

        Usuario_Valido = False

        Try

            vSQL = " SELECT IdUsuario, Nombre, Idrol " & _
                   " FROM usuario " & _
                   " WHERE  usuario.codigo = @Codigo " & _
                   " and usuario.clave = @Clave "

            Dim sp As String = vSQL

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text
            Dim dad As New MySqlDataAdapter(cmd)

            dad.SelectCommand.Parameters.Add(New MySqlParameter("@CODIGO", oBeUsuario.Codigo))
            dad.SelectCommand.Parameters.Add(New MySqlParameter("@CLAVE", oBeUsuario.Clave))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count > 0 Then

                oBeUsuario.IdUsuario = Integer.Parse(IIf(IsDBNull(dt.Rows(0).Item("IdUsuario")), "", dt.Rows(0).Item("IdUsuario")).ToString)
                oBeUsuario.Nombre = IIf(IsDBNull(dt.Rows(0).Item("Nombre")), "", dt.Rows(0).Item("Nombre")).ToString
                oBeUsuario.IdRol = Integer.Parse(IIf(IsDBNull(dt.Rows(0).Item("IdRol")), 0, dt.Rows(0).Item("IdRol")).ToString)

                Usuario_Valido = True

            End If

            cnn.Dispose()
            cmd.Dispose()
            dt.Dispose()


        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Sub Actualiza_Ultimo_Ingreso(ByRef oBeUsuario As clsBeUsuario)

        Try

            vSQL = "update usuario set UltimoIngreso =CURRENT_TIMESTAMP() Where IdUsuario = @IdUsuario"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(vSQL, cnn)

            Dim rowsAffected As Integer = 0
            cnn.Open()

            cmd.Parameters.Add(New MySqlParameter("@IDUSUARIO", oBeUsuario.IdUsuario))

            rowsAffected = cmd.ExecuteNonQuery()

            cnn.Close()
            cnn.Dispose()
            cmd.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Function Generar_Nuevo_IdUsuario() As Integer

        Generar_Nuevo_IdUsuario = 1

        Try

            vSQL$ = "SELECT MAX(idusuario) + 1 AS nuevo FROM usuario "

            Dim sp As String = vSQL
            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count > 0 Then
                Generar_Nuevo_IdUsuario = Integer.Parse(IIf(IsDBNull(dt.Rows(0).Item("nuevo")), "1", dt.Rows(0).Item("nuevo")).ToString)
            End If

            cnn.Dispose()
            cmd.Dispose()
            dad.Dispose()
            dt.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function Listar_Roles(ByRef Cmb As ComboBox) As Boolean

        Listar_Roles = False

        Dim DT As New DataTable

        Try

            vSQL = "select Idrol, Nombre from rol where activo=1"
            BD.OpenDT(DT, vSQL$)

            If DT.Rows.Count > 0 Then
                Cmb.DisplayMember = "nombre"
                Cmb.ValueMember = "Idrol"
                Cmb.DataSource = DT
            Else
                MsgBox("No hay definidos roles", MsgBoxStyle.Critical)
            End If

            Listar_Roles = DT.Rows.Count > 0

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function



End Class
