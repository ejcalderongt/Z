Imports MySql.Data.MySqlClient
Imports MySql.Data

Partial Public Class clsLnBeneficio

    Public Function Generar_Nuevo_IdBeneficio() As Integer

        Generar_Nuevo_IdBeneficio = 1

        Try

            vSQL$ = "SELECT MAX(IdBeneficio) + 1 AS nuevo FROM Beneficio"

            Dim sp As String = vSQL
            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count > 0 Then
                Generar_Nuevo_IdBeneficio = Integer.Parse(IIf(IsDBNull(dt.Rows(0).Item("nuevo")), "1", dt.Rows(0).Item("nuevo")).ToString)
            End If

            cnn.Dispose()
            cmd.Dispose()
            dad.Dispose()
            dt.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function LlenaTipoBeneficio() As DataTable
        Dim DT As New DataTable

        Try

            vSQL = "SELECT IdTipoBeneficio, Nombre FROM TipoBeneficio"
            BD.OpenDT(DT, vSQL$)

            Return DT

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return New DataTable()
        End Try

    End Function

    Public Function Get_Franquiciado_Asignado(ByRef oBeFranquiciado As clsBeFranquiciado, ByVal IdBeneficio As Integer) As Boolean

        Get_Franquiciado_Asignado = False

        Try

            vSQL = " SELECT descuento_enc.IdFranquiciado " & _
                   " FROM descuento_det INNER JOIN " & _
                   " descuento_enc ON descuento_det.IdDescuentoEnc = descuento_enc.IdDescuentoEnc " & _
                   " WHERE (descuento_det.IdBeneficio = " & IdBeneficio & ")"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(vSQL, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable
            dad.Fill(dt)

            Dim dFran As New clsLnFranquiciado

            If dt.Rows.Count > 0 Then

                oBeFranquiciado = New clsBeFranquiciado
                oBeFranquiciado.IdFranquiciado = dt.Rows(0).Item("IdFranquiciado")
                dFran.Obtener(oBeFranquiciado)

                Get_Franquiciado_Asignado = True

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Sub Get_TipoBeneficio(ByRef oBeTipoBene As clsBeTipobeneficio)

        Try

            Dim dTipoBene As New clsLnTipobeneficio
            dTipoBene.Obtener(oBeTipoBene)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function Listar(ByVal pTipoBene As clsBeTipobeneficio, ByVal Filtro As String) As DataTable

        Try

            vSQL = " SELECT  beneficio.IdBeneficio AS Codigo, tipobeneficio.Nombre AS Tipo, beneficio.Nombre, " & _
                  " beneficio.NoChasis, " & _
                  " beneficio.NoPlaca, beneficio.Modelo, beneficio.Motor, beneficio.EmpresaTelco, " & _
                  " beneficio.NumeroTelefono, CASE WHEN (descuento_det.IdDescuentoDet IS NULL) THEN 'NO' ELSE 'SI' END AS ASIGNADO " & _
                  " FROM beneficio INNER JOIN " & _
                  " tipobeneficio ON beneficio.IdTipoBeneficio = tipobeneficio.IdTipoBeneficio " & _
                  " LEFT OUTER JOIN descuento_det ON beneficio.IdBeneficio = descuento_det.IdBeneficio " & _
                  " WHERE 1 > 0 " &
                  " AND beneficio.IdTipoBeneficio =" & pTipoBene.IdTipoBeneficio

            If Filtro.Trim <> "" Then

                vSQL += " AND (IdBeneficio LIKE '%" & Filtro & "%'" & _
                    " OR tipobeneficio.Nombre LIKE '%" & Filtro & "%'" & _
                    " OR beneficio.NoChasis LIKE '%" & Filtro & "%'" & _
                    " OR beneficio.Nombre LIKE '%" & Filtro & "%'" & _
                    " OR beneficio.NoPlaca LIKE '%" & Filtro & "%'" & _
                    " OR beneficio.Modelo LIKE '%" & Filtro & "%'" & _
                    " OR beneficio.Motor LIKE '%" & Filtro & "%'" & _
                    " OR beneficio.NumeroTelefono LIKE '%" & Filtro & "%')"

            End If

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(vSQL, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable
            dad.Fill(dt)

            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function Listar(ByVal pIdTipoBeneficio As Integer, ByVal pServicio As Boolean, ByVal Filtro As String) As DataTable

        Try

            vSQL = " SELECT  beneficio.IdBeneficio AS Codigo, tipobeneficio.Nombre AS Tipo, beneficio.Nombre, " & _
                  " beneficio.NoChasis, " & _
                  " beneficio.NoPlaca, beneficio.Modelo, beneficio.Motor, beneficio.EmpresaTelco, " & _
                  " beneficio.NumeroTelefono " & _
                  " FROM beneficio INNER JOIN " & _
                  " tipobeneficio ON beneficio.IdTipoBeneficio = tipobeneficio.IdTipoBeneficio "

            If Not pServicio Then
                vSQL += " WHERE beneficio.IdBeneficio NOT IN (SELECT IdBeneficio FROM descuento_det) " & _
                        " AND beneficio.IdTipoBeneficio =" & pIdTipoBeneficio
            Else
                vSQL += " WHERE beneficio.IdTipoBeneficio =" & pIdTipoBeneficio
            End If

            If Filtro.Trim <> "" Then

                vSQL += " AND (beneficio.IdBeneficio LIKE '%" & Filtro & "%'" & _
                    " OR tipobeneficio.Nombre LIKE '%" & Filtro & "%'" & _
                    " OR beneficio.NoChasis LIKE '%" & Filtro & "%'" & _
                    " OR beneficio.Nombre LIKE '%" & Filtro & "%'" & _
                    " OR beneficio.NoPlaca LIKE '%" & Filtro & "%'" & _
                    " OR beneficio.Modelo LIKE '%" & Filtro & "%'" & _
                    " OR beneficio.Motor LIKE '%" & Filtro & "%'" & _
                    " OR beneficio.NumeroTelefono LIKE '%" & Filtro & "%')"

            End If

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(vSQL, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable
            dad.Fill(dt)

            Return dt

        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Sub Cargar(ByRef oBeBeneficio As clsBeBeneficio, ByRef dr As DataRow)

        Try

            With oBeBeneficio

                .IdBeneficio = IIf(IsDBNull(dr.Item("IdBeneficio")), 0, dr.Item("IdBeneficio"))
                .TipoBeneficio = New clsBeTipobeneficio
                .TipoBeneficio.IdTipoBeneficio = IIf(IsDBNull(dr.Item("IdTipoBeneficio")), 0, dr.Item("IdTipoBeneficio"))
                .Fecha_asignacion = IIf(IsDBNull(dr.Item("fecha_asignacion")), Now, dr.Item("fecha_asignacion"))
                .Fec_agr = IIf(IsDBNull(dr.Item("fec_agr")), Now, dr.Item("fec_agr"))
                .Fec_mod = IIf(IsDBNull(dr.Item("fec_mod")), Now, dr.Item("fec_mod"))
                .User_agr = IIf(IsDBNull(dr.Item("user_agr")), 0, dr.Item("user_agr"))
                .User_mod = IIf(IsDBNull(dr.Item("user_mod")), 0, dr.Item("user_mod"))
                .NoChasis = IIf(IsDBNull(dr.Item("NoChasis")), "", dr.Item("NoChasis"))
                .NoPlaca = IIf(IsDBNull(dr.Item("NoPlaca")), "", dr.Item("NoPlaca"))
                .NumeroTelefono = IIf(IsDBNull(dr.Item("NumeroTelefono")), "", dr.Item("NumeroTelefono"))
                .EmpresaTelco = IIf(IsDBNull(dr.Item("EmpresaTelco")), "", dr.Item("EmpresaTelco"))
                .Modelo = IIf(IsDBNull(dr.Item("Modelo")), "", dr.Item("Modelo"))
                .Motor = IIf(IsDBNull(dr.Item("Motor")), "", dr.Item("Motor"))
                .Nombre = IIf(IsDBNull(dr.Item("Nombre")), "", dr.Item("Nombre"))

                Get_Franquiciado_Asignado(.FranquiciadoAsignado, .IdBeneficio)
                Get_TipoBeneficio(.TipoBeneficio)
                

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function Obtener(ByRef oBeBeneficio As clsBeBeneficio, ByVal Parcial As Boolean) As Boolean

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

                If Parcial Then
                    Cargar(oBeBeneficio, dt.Rows(0), False, True)
                Else
                    Cargar(oBeBeneficio, dt.Rows(0))
                End If

            Else
                Throw New Exception("No se pudo obtener el registro")
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub Cargar(ByRef oBeBeneficio As clsBeBeneficio, ByRef dr As DataRow, ByVal Get_Info_Franquiciado_Asignado As Boolean, ByVal Get_Info_Tipo_Beneficio As Boolean)

        Try

            With oBeBeneficio

                .IdBeneficio = IIf(IsDBNull(dr.Item("IdBeneficio")), 0, dr.Item("IdBeneficio"))
                .TipoBeneficio = New clsBeTipobeneficio
                .TipoBeneficio.IdTipoBeneficio = IIf(IsDBNull(dr.Item("IdTipoBeneficio")), 0, dr.Item("IdTipoBeneficio"))
                .Fecha_asignacion = IIf(IsDBNull(dr.Item("fecha_asignacion")), Now, dr.Item("fecha_asignacion"))
                .Fec_agr = IIf(IsDBNull(dr.Item("fec_agr")), Now, dr.Item("fec_agr"))
                .Fec_mod = IIf(IsDBNull(dr.Item("fec_mod")), Now, dr.Item("fec_mod"))
                .User_agr = IIf(IsDBNull(dr.Item("user_agr")), 0, dr.Item("user_agr"))
                .User_mod = IIf(IsDBNull(dr.Item("user_mod")), 0, dr.Item("user_mod"))
                .NoChasis = IIf(IsDBNull(dr.Item("NoChasis")), "", dr.Item("NoChasis"))
                .NoPlaca = IIf(IsDBNull(dr.Item("NoPlaca")), "", dr.Item("NoPlaca"))
                .NumeroTelefono = IIf(IsDBNull(dr.Item("NumeroTelefono")), "", dr.Item("NumeroTelefono"))
                .EmpresaTelco = IIf(IsDBNull(dr.Item("EmpresaTelco")), "", dr.Item("EmpresaTelco"))
                .Modelo = IIf(IsDBNull(dr.Item("Modelo")), "", dr.Item("Modelo"))
                .Motor = IIf(IsDBNull(dr.Item("Motor")), "", dr.Item("Motor"))
                .Nombre = IIf(IsDBNull(dr.Item("Nombre")), "", dr.Item("Nombre"))

                If Get_Info_Franquiciado_Asignado Then
                    Get_Franquiciado_Asignado(.FranquiciadoAsignado, .IdBeneficio)
                End If

                If Get_Info_Tipo_Beneficio Then
                    Get_TipoBeneficio(.TipoBeneficio)
                End If


            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function Desactivar(ByRef oBeBeneficio As clsBeBeneficio, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Upd.Init("beneficio")
            Upd.Add("activo", "@activo", "F")
            Upd.Add("user_mod", "@user_mod", "F")
            Upd.Add("fec_agr", "@fec_agr", "F")
            Upd.Where("IdBeneficio = @IdBeneficio")

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

            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBENEFICIO", oBeBeneficio.IdBeneficio))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ACTIVO", oBeBeneficio.Activo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeBeneficio.User_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeBeneficio.Fec_mod))
            
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

End Class
