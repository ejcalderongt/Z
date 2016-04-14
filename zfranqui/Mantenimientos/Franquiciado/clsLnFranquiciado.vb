Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class clsLnFranquiciado

    Public Sub Cargar(ByRef oBeFranquiciado As clsBeFranquiciado, ByRef dr As DataRow)

        Try

            With oBeFranquiciado

                .IdFranquiciado = IIf(IsDBNull(dr.Item("IdFranquiciado")), 0, dr.Item("IdFranquiciado"))
                .IdBanco = IIf(IsDBNull(dr.Item("IdBanco")), 0, dr.Item("IdBanco"))
                .Codigo = IIf(IsDBNull(dr.Item("Codigo")), 0, dr.Item("Codigo"))
                .Nombres = IIf(IsDBNull(dr.Item("Nombres")), "", dr.Item("Nombres"))
                .Apellidos = IIf(IsDBNull(dr.Item("Apellidos")), "", dr.Item("Apellidos"))
                .DPI = IIf(IsDBNull(dr.Item("DPI")), "", dr.Item("DPI"))
                .NoCuenta = IIf(IsDBNull(dr.Item("NoCuenta")), "", dr.Item("NoCuenta"))
                .Direccion = IIf(IsDBNull(dr.Item("Direccion")), "", dr.Item("Direccion"))
                .NIT = IIf(IsDBNull(dr.Item("NIT")), "", dr.Item("NIT"))
                .Fec_agr = IIf(IsDBNull(dr.Item("fec_agr")), Date.Now, dr.Item("fec_agr"))
                .Fec_mod = IIf(IsDBNull(dr.Item("fec_mod")), Date.Now, dr.Item("fec_mod"))
                .User_agr = IIf(IsDBNull(dr.Item("user_agr")), 0, dr.Item("user_agr"))
                .User_mod = IIf(IsDBNull(dr.Item("user_mod")), 0, dr.Item("user_mod"))
                .Activo = IIf(IsDBNull(dr.Item("Activo")), 0, dr.Item("Activo"))
                .Interlocutor = IIf(IsDBNull(dr.Item("Interlocutor")), 0, dr.Item("Interlocutor"))

                .CEFAsignado.IdAsignacionFranquiciado = IIf(IsDBNull(dr.Item("IdAsignacionFranquiciado")), 0, dr.Item("IdAsignacionFranquiciado"))

                If .CEFAsignadoLN.Obtener(.CEFAsignado) Then
                    .CEF.IdCef = .CEFAsignado.IdCEF
                    .dCEF.Obtener(.CEF)
                End If

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

	Public Function Insertar(ByRef oBeFranquiciado As clsBeFranquiciado, Optional ByVal pConection as MySqlConnection = Nothing, Optional Byval pTransaction as MySqlTransaction= Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Ins.Init("franquiciado")
            Ins.Add("idfranquiciado", "@idfranquiciado", "F")
            Ins.Add("idbanco", "@idbanco", "F")
            Ins.Add("codigo", "@codigo", "F")
            Ins.Add("nombres", "@nombres", "F")
            Ins.Add("apellidos", "@apellidos", "F")
            Ins.Add("dpi", "@dpi", "F")
            Ins.Add("nocuenta", "@nocuenta", "F")
            Ins.Add("direccion", "@direccion", "F")
            Ins.Add("nit", "@nit", "F")
            Ins.Add("fec_agr", "@fec_agr", "F")
            Ins.Add("fec_mod", "@fec_mod", "F")
            Ins.Add("user_agr", "@user_agr", "F")
            Ins.Add("user_mod", "@user_mod", "F")
            Ins.Add("interlocutor", "@interlocutor", "F")
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


            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDFRANQUICIADO", oBeFranquiciado.IdFranquiciado))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBANCO", oBeFranquiciado.IdBanco))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@CODIGO", oBeFranquiciado.Codigo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOMBRES", oBeFranquiciado.Nombres))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@APELLIDOS", oBeFranquiciado.Apellidos))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@DPI", oBeFranquiciado.DPI))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOCUENTA", oBeFranquiciado.NoCuenta))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@DIRECCION", oBeFranquiciado.Direccion))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NIT", oBeFranquiciado.NIT))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeFranquiciado.Fec_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeFranquiciado.Fec_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeFranquiciado.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeFranquiciado.User_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ACTIVO", oBeFranquiciado.Activo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@INTERLOCUTOR", oBeFranquiciado.Interlocutor))

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

    Public Function Insertar(ByRef oBeFranquiciado As clsBeFranquiciado, ByRef oBeFranquiciadoCEF As clsBeFranquiciadocef) As Boolean

        Insertar = False

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim ltrans As MySqlTransaction = Nothing

        Dim dFCEF As New clsLnFranquiciadocef

        Try

            cnn.Open()

            ltrans = cnn.BeginTransaction()

            Insertar(oBeFranquiciado, cnn, ltrans)

            If Not oBeFranquiciadoCEF Is Nothing AndAlso oBeFranquiciadoCEF.IdCEF <> 0 Then
                dFCEF.Insertar(oBeFranquiciadoCEF, cnn, ltrans)
            End If

            ltrans.Commit()

            Insertar = True

        Catch ex As Exception
            If Not ltrans Is Nothing Then ltrans.Rollback()
            Throw ex
        Finally
            If cnn.State = ConnectionState.Open Then cnn.Close()
            cnn.Dispose()
            ltrans.Dispose()
        End Try

    End Function

    Public Function Actualizar(ByRef oBeFranquiciado As clsBeFranquiciado, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Upd.Init("franquiciado")
            Upd.Add("idfranquiciado", "@idfranquiciado", "F")
            Upd.Add("idbanco", "@idbanco", "F")
            Upd.Add("codigo", "@codigo", "F")
            Upd.Add("nombres", "@nombres", "F")
            Upd.Add("apellidos", "@apellidos", "F")
            Upd.Add("dpi", "@dpi", "F")
            Upd.Add("nocuenta", "@nocuenta", "F")
            Upd.Add("direccion", "@direccion", "F")
            Upd.Add("nit", "@nit", "F")
            Upd.Add("fec_agr", "@fec_agr", "F")
            Upd.Add("fec_mod", "@fec_mod", "F")
            Upd.Add("user_agr", "@user_agr", "F")
            Upd.Add("user_mod", "@user_mod", "F")
            Upd.Add("activo", "@activo", "F")
            Upd.Add("interlocutor", "@interlocutor", "F")
            Upd.Where("IdFranquiciado = @IdFranquiciado")

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

            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDFRANQUICIADO", oBeFranquiciado.IdFranquiciado))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDBANCO", oBeFranquiciado.IdBanco))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@CODIGO", oBeFranquiciado.Codigo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOMBRES", oBeFranquiciado.Nombres))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@APELLIDOS", oBeFranquiciado.Apellidos))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@DPI", oBeFranquiciado.DPI))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NOCUENTA", oBeFranquiciado.NoCuenta))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@DIRECCION", oBeFranquiciado.Direccion))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@NIT", oBeFranquiciado.NIT))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_AGR", oBeFranquiciado.Fec_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeFranquiciado.Fec_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_AGR", oBeFranquiciado.User_agr))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeFranquiciado.User_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ACTIVO", oBeFranquiciado.Activo))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@INTERLOCUTOR", oBeFranquiciado.Interlocutor))

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


    Public Function Actualizar(ByRef oBeFranquiciado As clsBeFranquiciado, ByRef oBeFranquiciadoCEF As clsBeFranquiciadocef) As Integer

        Actualizar = False

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim ltrans As MySqlTransaction

        cnn.Open()

        ltrans = cnn.BeginTransaction

        Dim dFranquciadoCEF As New clsLnFranquiciadocef

        Dim pFranquiciadoCEF As New clsBeFranquiciadocef
        pFranquiciadoCEF.IdFranquiciado = oBeFranquiciado.IdFranquiciado

        Try

            Actualizar(oBeFranquiciado, cnn, ltrans)

            If Not dFranquciadoCEF.TieneCEFAsignado(pFranquiciadoCEF) Then 'No tiene CEF Asignado                
                oBeFranquiciadoCEF.IdAsignacionFranquiciado = dFranquciadoCEF.Generar_Nuevo_IdAsignacionFranquiciado()
                dFranquciadoCEF.Insertar(oBeFranquiciadoCEF, cnn, ltrans)
            ElseIf pFranquiciadoCEF.IdCEF <> oBeFranquiciadoCEF.IdCEF AndAlso oBeFranquiciadoCEF.IdCEF <> 0 Then 'Ya tiene CEF Asignado pero lo cambiaron                
                oBeFranquiciadoCEF.IdAsignacionFranquiciado = pFranquiciadoCEF.IdAsignacionFranquiciado 'Update sobre la asignación
                dFranquciadoCEF.Actualizar(oBeFranquiciadoCEF, cnn, ltrans)
            ElseIf dFranquciadoCEF.TieneCEFAsignado(pFranquiciadoCEF) AndAlso oBeFranquiciadoCEF.IdCEF = 0 Then 'Se eliminó la asignación
                oBeFranquiciadoCEF.IdAsignacionFranquiciado = pFranquiciadoCEF.IdAsignacionFranquiciado 'Update sobre la asignación
                dFranquciadoCEF.Eliminar(oBeFranquiciadoCEF, cnn, ltrans)
            End If

            ltrans.Commit()

            Actualizar = True

        Catch ex As Exception
            Throw ex
        Finally
            If cnn.State = ConnectionState.Open Then cnn.Close()
            cnn.Dispose()
        End Try

    End Function

    Public Function Eliminar(ByRef oBeFranquiciado As clsBeFranquiciado, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            cmd.CommandType = CommandType.Text


            Dim sp As String = " Delete from Franquiciado" & _
             "  Where(IdFranquiciado = @IdFranquiciado)"


            Dim EsTransaccional As Boolean = (Not pConection Is Nothing AndAlso Not pTransaction Is Nothing)

            If EsTransaccional Then

                cmd = New MySqlClient.MySqlCommand(sp, pConection)
                cmd.Transaction = pTransaction
            Else

                cmd = New MySqlClient.MySqlCommand(sp, cnn)
                cnn.Open()

            End If


            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@IDFRANQUICIADO", oBeFranquiciado.IdFranquiciado))

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
            Dim sp As String = "SELECT * FROM Franquiciado"

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

    Public Function Obtener(ByRef oBeFranquiciado As clsBeFranquiciado, Optional ByVal ThrowEx As Boolean = True, Optional ByVal Parcial As Boolean = False) As Boolean

        Obtener = False

        Try

            Dim dt As New DataTable

            If oBeFranquiciado.IdFranquiciado = 0 Then

                'Busqueda por código de franquiciado

                Dim sp As String = " SELECT franquiciado.*, franquiciadocef.IdAsignacionFranquiciado " & _
                              " FROM franquiciado LEFT OUTER JOIN " & _
                              " franquiciadocef ON franquiciado.IdFranquiciado = franquiciadocef.IdFranquiciado " & _
                              " Where(franquiciado.Codigo = @IdFranquiciado) "

                Dim cnn As New MySqlConnection(BD.CadenaConexion)
                Dim cmd As New MySqlCommand(sp, cnn)
                cmd.CommandType = CommandType.Text

                Dim dad As New MySqlDataAdapter(cmd)
                dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDFRANQUICIADO", oBeFranquiciado.Codigo))

                dad.Fill(dt)

            Else
                'Busqueda por Id de franquiciado

                Dim sp As String = " SELECT franquiciado.*, franquiciadocef.IdAsignacionFranquiciado " & _
                              " FROM franquiciado LEFT OUTER JOIN " & _
                              " franquiciadocef ON franquiciado.IdFranquiciado = franquiciadocef.IdFranquiciado " & _
                              " Where(franquiciado.IdFranquiciado = @IdFranquiciado) "

                Dim cnn As New MySqlConnection(BD.CadenaConexion)
                Dim cmd As New MySqlCommand(sp, cnn)
                cmd.CommandType = CommandType.Text


                Dim dad As New MySqlDataAdapter(cmd)
                dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDFRANQUICIADO", oBeFranquiciado.IdFranquiciado))

                dad.Fill(dt)

            End If

            If dt.Rows.Count = 1 Then

                If Parcial Then
                    'Carga detalle del franquiciado sin info del CEF asignado.
                    Cargar(oBeFranquiciado, dt.Rows(0), True)
                Else
                    'Carga detalle del CEF asignado al franquiciado.
                    Cargar(oBeFranquiciado, dt.Rows(0), False)
                End If

                Return True
            Else
                If ThrowEx Then Throw New Exception("No se pudo obtener el registro")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

End Class
