Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data

Partial Public Class clsLnDescuento_enc

    Public Shared Function Generar_Nuevo_IdDescuento() As Integer

        Generar_Nuevo_IdDescuento = 1

        Try

            vSQL$ = "SELECT MAX(IdDescuentoEnc) + 1 AS nuevo FROM descuento_enc "

            Dim sp As String = vSQL
            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count > 0 Then
                Generar_Nuevo_IdDescuento = Integer.Parse(IIf(IsDBNull(dt.Rows(0).Item("nuevo")), "1", dt.Rows(0).Item("nuevo")).ToString)
            End If

            cnn.Dispose()
            cmd.Dispose()
            dad.Dispose()
            dt.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function Listar(ByVal Filtro As String, ByVal IdTipoDescuento As Integer) As DataTable

        Try

            Dim sp As String = " SELECT descuento_enc.IdFranquiciado,descuento_enc.IdDescuentoEnc as CodigoDTO, tipodescuento.Nombre as Tipo, franquiciado.Codigo AS CodigoFranquiciado,  " & _
                               " franquiciado.Nombres AS Franquiciado, cef.Codigo AS CodigoCEF, cef.Descripcion AS CEF, cef.IdCef " & _
                               " FROM descuento_enc " & _
                               " INNER JOIN franquiciadocef ON descuento_enc.IdCEF = franquiciadocef.IdCEF AND descuento_enc.IdFranquiciado = franquiciadocef.IdFranquiciado " & _
                               " INNER JOIN franquiciado ON franquiciadocef.IdFranquiciado = franquiciado.IdFranquiciado " & _
                               " INNER JOIN cef ON franquiciadocef.IdCEF = cef.IdCef " & _
                               " INNER JOIN tipodescuento on descuento_enc.IdTipoDescuento = tipodescuento.IdTipoDescuento " & _
                               " Where descuento_enc.IdTipoDescuento =" & IdTipoDescuento

            If Filtro <> "" Then
                sp += " and (franquiciado.Codigo like '%" & Filtro & "%'"
                sp += " or franquiciado.Nombres like '%" & Filtro & "%'"
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

    Public Sub Cargar(ByRef oBeDescuento_enc As clsBeDescuento_enc, ByRef dr As DataRow)

        Try

            Dim dFran As New clsLnFranquiciado
            Dim dCef As New clsLnCef

            With oBeDescuento_enc

                .IdDescuentoEnc = IIf(IsDBNull(dr.Item("IdDescuentoEnc")), 0, dr.Item("IdDescuentoEnc"))
                .CEF.IdCef = IIf(IsDBNull(dr.Item("IdCEF")), 0, dr.Item("IdCEF"))
                .Franquiciado = New clsBeFranquiciado
                .Franquiciado.IdFranquiciado = IIf(IsDBNull(dr.Item("IdFranquiciado")), 0, dr.Item("IdFranquiciado"))
                .IdTipoDescuento = IIf(IsDBNull(dr.Item("IdTipoDescuento")), 0, dr.Item("IdTipoDescuento"))
                .Fec_agr = IIf(IsDBNull(dr.Item("fec_agr")), Date.Now, dr.Item("fec_agr"))
                .Fec_mod = IIf(IsDBNull(dr.Item("fec_mod")), Date.Now, dr.Item("fec_mod"))
                .User_agr = IIf(IsDBNull(dr.Item("user_agr")), 0, dr.Item("user_agr"))
                .User_mod = IIf(IsDBNull(dr.Item("user_mod")), 0, dr.Item("user_mod"))
                dFran.Obtener(.Franquiciado, True, True)
                .Franquiciado.CEF.IdCef = .CEF.IdCef
                dCef.Obtener(.Franquiciado.CEF, True)

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Shared Function GetAllByEncabezado(ByVal pIdDescuentoEnc As Integer) As DataTable

        Dim lTable As New DataTable("Result")

        Try

            Dim lSQl As String = "SELECT DISTINCT enc.IdDescuentoEnc,f.Codigo,f.Nombres,f.Apellidos,c.Codigo,c.Descripcion," _
                               & "det.IdDescuentoDet,det.IdBeneficio,b.Nombre,b.Modelo,b.NoChasis,b.NoPlaca,b.Motor," _
                               & "b.NumeroTelefono,b.EmpresaTelco,pd.Nombre AS Periodo,pd.Dias,det.MontoTotal,det.Cuotas," _
                               & "ref.FechaCobro,ref.NoCuota,ref.Monto,ref.Abonado,ref.Pagada," _
                               & "u1.Codigo AS CodigoU1, U2.Codigo AS CodigoU2,enc.fec_agr,enc.fec_mod" _
                               & ",tp.EsVehiculo,tp.EsTelefono,tp.EsServicio " _
                               & "FROM descuento_enc AS enc " _
                               & "INNER JOIN descuento_det AS det ON enc.IdDescuentoEnc = det.IdDescuentoEnc " _
                               & "LEFT JOIN descuento_ref AS ref ON det.IdDescuentoEnc = ref.IdDescuentoEnc " _
                               & "AND det.IdDescuentoDet = ref.IdDescuentoDet " _
                               & "INNER JOIN franquiciado AS f ON enc.IdFranquiciado = f.IdFranquiciado " _
                               & "INNER JOIN cef AS c ON enc.IdCef = c.IdCef " _
                               & "LEFT JOIN usuario AS u1 ON enc.user_agr = u1.user_agr " _
                               & "LEFT JOIN usuario AS U2 ON enc.user_mod = U2.user_mod " _
                               & "INNER JOIN beneficio AS b ON det.IdBeneficio = b.IdBeneficio " _
                               & "INNER JOIN periodo_descuento AS pd ON det.IdPeriodoDescuento = pd.IdPeriodo " _
                               & "INNER JOIN tipobeneficio AS tp ON b.IdTipoBeneficio = tp.IdTipoBeneficio " _
                               & "WHERE enc.IdDescuentoEnc=" & pIdDescuentoEnc.ToString()

 
            Using lConnection As New MySqlConnection(BD.CadenaConexion)
                Using lDataAdapter As New MySqlDataAdapter(lSQl, lConnection)
                    lDataAdapter.SelectCommand.CommandType = CommandType.Text
                    lDataAdapter.Fill(lTable)
                End Using
            End Using
            Return lTable
        Catch ex As Exception
            Throw ex
        End Try

    End Function


    Public Function ObtenerParcial(ByRef oBeDescuento_enc As clsBeDescuento_enc) As Boolean

        Try

            vSQL = " SELECT descuento_enc.IdDescuentoEnc, descuento_enc.IdCEF, descuento_enc.IdFranquiciado, descuento_enc.fec_agr, descuento_enc.fec_mod, " & _
                    " descuento_enc.user_agr, descuento_enc.user_mod, descuento_enc.IdTipoDescuento, tipodescuento.Nombre AS NomTipoDescuento, " & _
                    " franquiciado.Codigo AS CodigoFrnquiciado, franquiciado.Nombres AS NomFranquiciado, franquiciado.Apellidos AS ApeFranquiciado,  " & _
                    " cef.Codigo AS CodigoCEF, cef.Descripcion AS NomCEF, usuario_1.Nombre AS NomUsuarioModifico, usuario.Nombre AS NomUsuarioAgrego " & _
                    " FROM   descuento_enc INNER JOIN " & _
                    " cef ON descuento_enc.IdCEF = cef.IdCef INNER JOIN " & _
                    " franquiciado ON descuento_enc.IdFranquiciado = franquiciado.IdFranquiciado INNER JOIN " & _
                    " tipodescuento ON descuento_enc.IdTipoDescuento = tipodescuento.IdTipoDescuento INNER JOIN " & _
                    " usuario ON descuento_enc.user_agr = usuario.IdUsuario INNER JOIN " & _
                    " usuario AS usuario_1 ON descuento_enc.user_mod = usuario_1.IdUsuario " & _
                    " WHERE descuento_enc.IdDescuentoEnc=@IdDescuentoEnc"


            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(vSQL, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlClient.MySqlParameter("@IDDESCUENTOENC", oBeDescuento_enc.IdDescuentoEnc))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                CargarParcial(oBeDescuento_enc, dt.Rows(0))
            Else
                Throw New Exception("No se pudo obtener el registro")
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub CargarParcial(ByRef oBeDescuento_enc As clsBeDescuento_enc, ByRef dr As DataRow)

        Try

            With oBeDescuento_enc

                .IdDescuentoEnc = IIf(IsDBNull(dr.Item("IdDescuentoEnc")), 0, dr.Item("IdDescuentoEnc"))
                .CEF.IdCef = IIf(IsDBNull(dr.Item("IdCEF")), 0, dr.Item("IdCEF"))
                .CEF.Codigo = IIf(IsDBNull(dr.Item("CodigoCEF")), 0, dr.Item("CodigoCEF"))
                .CEF.Descripcion = IIf(IsDBNull(dr.Item("NomCEF")), 0, dr.Item("NomCEF"))

                .Franquiciado = New clsBeFranquiciado
                .Franquiciado.IdFranquiciado = IIf(IsDBNull(dr.Item("IdFranquiciado")), 0, dr.Item("IdFranquiciado"))
                .Franquiciado.Codigo = IIf(IsDBNull(dr.Item("CodigoFrnquiciado")), 0, dr.Item("CodigoFrnquiciado"))
                .Franquiciado.Nombres = IIf(IsDBNull(dr.Item("NomFranquiciado")), 0, dr.Item("NomFranquiciado"))
                .Franquiciado.Apellidos = IIf(IsDBNull(dr.Item("ApeFranquiciado")), 0, dr.Item("ApeFranquiciado"))

                .IdTipoDescuento = IIf(IsDBNull(dr.Item("IdTipoDescuento")), 0, dr.Item("IdTipoDescuento"))
                .NomTipoDescuento = IIf(IsDBNull(dr.Item("NomTipoDescuento")), 0, dr.Item("NomTipoDescuento"))

                .Fec_agr = IIf(IsDBNull(dr.Item("fec_agr")), Date.Now, dr.Item("fec_agr"))
                .Fec_mod = IIf(IsDBNull(dr.Item("fec_mod")), Date.Now, dr.Item("fec_mod"))

                .User_agr = IIf(IsDBNull(dr.Item("user_agr")), 0, dr.Item("user_agr"))
                .NomUsuarioAgrego = IIf(IsDBNull(dr.Item("NomUsuarioAgrego")), 0, dr.Item("NomUsuarioAgrego"))

                .User_mod = IIf(IsDBNull(dr.Item("user_mod")), 0, dr.Item("user_mod"))
                .NomUsuarioModifico = IIf(IsDBNull(dr.Item("NomUsuarioModifico")), 0, dr.Item("NomUsuarioModifico"))

                .Detalle = clsLnDescuento_det.GetAllByDescuentoEnc(.IdDescuentoEnc, True)
                .Referencia = clsLnDescuento_ref.GetAllByEncabezado(.IdDescuentoEnc)

            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Shared Function Exists(ByVal Obj As clsBeDescuento_enc) As Boolean

        Dim lExists As Boolean = False

        Try

            'Validacion y estandarizacion de los datos
            Using lConnection As New MySqlConnection(BD.CadenaConexion)
                'Acceso a los datos.
                Using lCommand As New MySqlCommand("SELECT COUNT(*) FROM descuento_enc WHERE IdCef=@IdCef AND IdTipoDescuento=@IdTipoDescuento AND IdFranquiciado=@IdFranquiciado", lConnection)
                    lCommand.CommandType = CommandType.Text
                    lCommand.Parameters.AddWithValue("@IdCef", Obj.CEF.IdCef)
                    lCommand.Parameters.AddWithValue("@IdTipoDescuento", Obj.IdTipoDescuento)
                    lCommand.Parameters.AddWithValue("@IdFranquiciado", Obj.Franquiciado.IdFranquiciado)
                    lConnection.Open()
                    Dim lReturnValue As Object = lCommand.ExecuteScalar()
                    lConnection.Close()
                    If lReturnValue IsNot DBNull.Value AndAlso lReturnValue IsNot Nothing Then
                        lExists = CInt(lReturnValue) > 0
                    End If
                End Using
            End Using

            Return lExists

        Catch ex As Exception
            Throw ex
        End Try

    End Function

End Class
