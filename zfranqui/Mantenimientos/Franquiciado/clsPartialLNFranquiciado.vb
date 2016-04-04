Imports MySql.Data.MySqlClient
Imports MySql.Data

Partial Public Class clsLnFranquiciado

    Public Function Generar_Nuevo_IdFranquiciado() As Integer

        Generar_Nuevo_IdFranquiciado = 1

        Try

            vSQL$ = "SELECT MAX(IdFranquiciado) + 1 AS nuevo FROM Franquiciado "

            Dim sp As String = vSQL
            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count > 0 Then
                Generar_Nuevo_IdFranquiciado = Integer.Parse(IIf(IsDBNull(dt.Rows(0).Item("nuevo")), "1", dt.Rows(0).Item("nuevo")).ToString)
            End If

            cnn.Dispose()
            cmd.Dispose()
            dad.Dispose()
            dt.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


    Public Function Existe_Codigo(ByVal Codigo As String, ByVal IdFranquiciado As Integer) As Boolean

        Existe_Codigo = False

        Try

            vSQL$ = "SELECT IdFranquiciado FROM Franquiciado WHERE Codigo ='" & Codigo & "'" & _
                " AND IdFranquiciado <> " & IdFranquiciado

            Dim sp As String = vSQL
            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            dad.Fill(dt)

            Existe_Codigo = dt.Rows.Count > 0

            cnn.Dispose()
            cmd.Dispose()
            dad.Dispose()
            dt.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function Existe_DPI(ByVal DPI As String, ByVal IdFranquiciado As Integer) As Boolean

        Existe_DPI = False

        Try

            vSQL$ = "SELECT IdFranquiciado FROM Franquiciado WHERE DPI ='" & DPI & "'" & _
                " and IdFranquiciado <> " & IdFranquiciado

            Dim sp As String = vSQL
            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            dad.Fill(dt)

            Existe_DPI = dt.Rows.Count > 0

            cnn.Dispose()
            cmd.Dispose()
            dad.Dispose()
            dt.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function Existe_NIT(ByVal NIT As String, ByVal IdFranquiciado As Integer) As Boolean

        Existe_NIT = False

        Try

            vSQL$ = "SELECT IdFranquiciado FROM Franquiciado WHERE NIT ='" & NIT & "'" & _
                " and IdFranquiciado <> " & IdFranquiciado

            Dim sp As String = vSQL
            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            dad.Fill(dt)

            Existe_NIT = dt.Rows.Count > 0

            cnn.Dispose()
            cmd.Dispose()
            dad.Dispose()
            dt.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function Listar(ByVal Filtro As String, ByVal Modo As Integer) As DataTable

        Listar = New DataTable

        Try

            If Modo = 0 Then Exit Function

            Dim sp As String = ""

            If Modo = 1 Then 'Lista

                sp = "SELECT franquiciado.IdFranquiciado, franquiciado.Codigo, franquiciado.Nombres, franquiciado.Apellidos, " & _
                        " franquiciado.DPI, franquiciado.activo, cef.Codigo AS CodCEF, " & _
                        " cef.Descripcion AS CEF " & _
                        " FROM franquiciadocef INNER JOIN " & _
                        " cef ON franquiciadocef.IdCEF = cef.IdCef RIGHT JOIN " & _
                        " franquiciado ON franquiciadocef.IdFranquiciado = franquiciado.IdFranquiciado " & _
                        " WHERE 1 > 0 "

            ElseIf Modo = 2 Then

                sp = " SELECT  franquiciado.IdFranquiciado, franquiciado.Codigo, franquiciado.Nombres, franquiciado.Apellidos, franquiciado.DPI, " & _
                   " banco.Nombre AS Banco, franquiciado.NoCuenta, franquiciado.NIT, cef.Codigo AS CodigoCEF, cef.Descripcion AS NomCEF " & _
                   " FROM banco INNER JOIN " & _
                   " franquiciado ON banco.IdBanco = franquiciado.IdBanco INNER JOIN " & _
                   " cef INNER JOIN " & _
                   " franquiciadocef ON cef.IdCef = franquiciadocef.IdCEF AND franquiciado.IdFranquiciado = franquiciadocef.IdFranquiciado " & _
                   " WHERE 1 > 0 "

            End If


            If Filtro <> "" Then

                sp += " and (franquiciado.IdFranquiciado like '%" & Filtro & "%'"
                sp += " or franquiciado.Codigo like '%" & Filtro & "%'"
                sp += " or franquiciado.Nombres like '%" & Filtro & "%'"
                sp += " or franquiciado.Apellidos like '%" & Filtro & "%'"
                sp += " or franquiciado.DPI like '%" & Filtro & "%'"
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
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function Desactivar(ByRef oBeFranquiciado As clsBeFranquiciado, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            Upd.Init("franquiciado")
            Upd.Add("fec_mod", "@fec_mod", "F")
            Upd.Add("user_mod", "@user_mod", "F")
            Upd.Add("activo", "@activo", "F")
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
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@FEC_MOD", oBeFranquiciado.Fec_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@USER_MOD", oBeFranquiciado.User_mod))
            cmd.Parameters.Add(New MySqlClient.MySqlParameter("@ACTIVO", oBeFranquiciado.Activo))

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

    Public Sub Cargar(ByRef oBeFranquiciado As clsBeFranquiciado, ByRef dr As DataRow, ByVal Parcial As Boolean)

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
                .CEFAsignado.IdAsignacionFranquiciado = IIf(IsDBNull(dr.Item("IdAsignacionFranquiciado")), 0, dr.Item("IdAsignacionFranquiciado"))

                If Not Parcial Then
                    If .CEFAsignadoLN.Obtener(.CEFAsignado) Then
                        .CEF.IdCef = .CEFAsignado.IdCEF
                        .dCEF.Obtener(.CEF)
                    End If
                End If
                

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class
