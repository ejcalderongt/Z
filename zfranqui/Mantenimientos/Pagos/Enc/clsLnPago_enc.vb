Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class clsLnPago_enc

    Public Sub Cargar(ByRef oBePago_enc As clsBePago_enc, ByRef dr As DataRow)
        Try
            With oBePago_enc
                .IdPagoEnc = IIf(IsDBNull(dr.Item("IdPagoEnc")), 0, dr.Item("IdPagoEnc"))
                .IdCEF = IIf(IsDBNull(dr.Item("IdCEF")), 0, dr.Item("IdCEF"))
                .IdFranquiciado = IIf(IsDBNull(dr.Item("IdFranquiciado")), 0, dr.Item("IdFranquiciado"))
                .NoDeposito = IIf(IsDBNull(dr.Item("NoDeposito")), "", dr.Item("NoDeposito"))
                .FechaPago = IIf(IsDBNull(dr.Item("FechaPago")), Date.Now, dr.Item("FechaPago"))
                .Fec_agr = IIf(IsDBNull(dr.Item("Fec_agr")), Date.Now, dr.Item("Fec_agr"))
                .Fec_mod = IIf(IsDBNull(dr.Item("Fec_mod")), Date.Now, dr.Item("Fec_mod"))
                .User_agr = IIf(IsDBNull(dr.Item("User_agr")), 0, dr.Item("User_agr"))
                .User_mod = IIf(IsDBNull(dr.Item("User_mod")), 0, dr.Item("User_mod"))
                .Anulado = IIf(IsDBNull(dr.Item("Anulado")), False, dr.Item("Anulado"))
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Insertar(ByRef oBePago_enc As clsBePago_enc, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand

        Try

            Ins.Init("pago_enc")
            Ins.Add("idpagoenc", "@idpagoenc", "F")
            Ins.Add("idcef", "@idcef", "F")
            Ins.Add("idfranquiciado", "@idfranquiciado", "F")
            Ins.Add("nodeposito", "@nodeposito", "F")
            Ins.Add("fechapago", "@fechapago", "F")
            Ins.Add("fec_agr", "@fec_agr", "F")
            Ins.Add("fec_mod", "@fec_mod", "F")
            Ins.Add("user_agr", "@user_agr", "F")
            Ins.Add("user_mod", "@user_mod", "F")
            Ins.Add("anulado", "@anulado", "F")

            Dim sp As String = Ins.SQL()

            Dim EsTransaccional As Boolean = (Not pConection Is Nothing AndAlso Not pTransaction Is Nothing)

            cmd.CommandType = CommandType.Text


            If EsTransaccional Then
                cmd = New MySqlCommand(sp, pConection)
                cmd.Transaction = pTransaction
            Else

                cmd = New MySqlCommand(sp, cnn)
                cnn.Open()
            End If


            cmd.Parameters.Add(New MySqlParameter("@IDPAGOENC", oBePago_enc.IdPagoEnc))
            cmd.Parameters.Add(New MySqlParameter("@IDCEF", oBePago_enc.CEF.IdCef))
            cmd.Parameters.Add(New MySqlParameter("@IDFRANQUICIADO", oBePago_enc.Franquiciado.IdFranquiciado))
            cmd.Parameters.Add(New MySqlParameter("@NODEPOSITO", oBePago_enc.NoDeposito))
            cmd.Parameters.Add(New MySqlParameter("@FECHAPAGO", oBePago_enc.FechaPago))
            cmd.Parameters.Add(New MySqlParameter("@FEC_AGR", oBePago_enc.Fec_agr))
            cmd.Parameters.Add(New MySqlParameter("@FEC_MOD", oBePago_enc.Fec_mod))
            cmd.Parameters.Add(New MySqlParameter("@USER_AGR", oBePago_enc.User_agr))
            cmd.Parameters.Add(New MySqlParameter("@USER_MOD", oBePago_enc.User_mod))
            cmd.Parameters.Add(New MySqlParameter("@ANULADO", oBePago_enc.Anulado))

            Dim rowsAffected As Integer = 0
            rowsAffected = cmd.ExecuteNonQuery()
            Return rowsAffected

            oBePago_enc.IdPagoEnc = CInt(cmd.Parameters("@IDPAGOENC").Value)

        Catch ex As Exception
            Throw ex
        Finally
            If cnn.State = ConnectionState.Open Then cnn.Close()
            cnn.Dispose()
            cmd.Dispose()
        End Try

    End Function

    Public Function Actualizar(ByRef oBePago_enc As clsBePago_enc, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand

        Try

            Upd.Init("pago_enc")
            Upd.Add("idpagoenc", "@idpagoenc", "F")
            Upd.Add("idcef", "@idcef", "F")
            Upd.Add("idfranquiciado", "@idfranquiciado", "F")
            Upd.Add("nodeposito", "@nodeposito", "F")
            Upd.Add("fechapago", "@fechapago", "F")
            Upd.Add("fec_agr", "@fec_agr", "F")
            Upd.Add("fec_mod", "@fec_mod", "F")
            Upd.Add("user_agr", "@user_agr", "F")
            Upd.Add("user_mod", "@user_mod", "F")
            Upd.Add("anulado", "@anulado", "F")
            Upd.Where("IdPagoEnc = @IdPagoEnc")

            Dim sp As String = Upd.SQL()

            Dim EsTransaccional As Boolean = (Not pConection Is Nothing AndAlso Not pTransaction Is Nothing)

            cmd.CommandType = CommandType.Text


            If EsTransaccional Then
                cmd = New MySqlCommand(sp, pConection)
                cmd.Transaction = pTransaction
            Else
                cmd = New MySqlCommand(sp, cnn)
                cnn.Open()
            End If

            cmd.Parameters.Add(New MySqlParameter("@IDPAGOENC", oBePago_enc.IdPagoEnc))
            cmd.Parameters.Add(New MySqlParameter("@IDCEF", oBePago_enc.IdCEF))
            cmd.Parameters.Add(New MySqlParameter("@IDFRANQUICIADO", oBePago_enc.IdFranquiciado))
            cmd.Parameters.Add(New MySqlParameter("@NODEPOSITO", oBePago_enc.NoDeposito))
            cmd.Parameters.Add(New MySqlParameter("@FECHAPAGO", oBePago_enc.FechaPago))
            cmd.Parameters.Add(New MySqlParameter("@FEC_AGR", oBePago_enc.Fec_agr))
            cmd.Parameters.Add(New MySqlParameter("@FEC_MOD", oBePago_enc.Fec_mod))
            cmd.Parameters.Add(New MySqlParameter("@USER_AGR", oBePago_enc.User_agr))
            cmd.Parameters.Add(New MySqlParameter("@USER_MOD", oBePago_enc.User_mod))
            cmd.Parameters.Add(New MySqlParameter("@ANULADO", oBePago_enc.Anulado))

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


    Public Function Eliminar(ByRef oBePago_enc As clsBePago_enc, Optional ByVal pConection As MySqlConnection = Nothing, Optional ByVal pTransaction As MySqlTransaction = Nothing) As Integer

        Dim cnn As New MySqlConnection(BD.CadenaConexion)
        Dim cmd As New MySqlCommand()

        Try

            cmd.CommandType = CommandType.Text


            Dim sp As String = " Delete from Pago_enc" & _
             "  Where(IdPagoEnc = @IdPagoEnc)"


            Dim EsTransaccional As Boolean = (Not pConection Is Nothing AndAlso Not pTransaction Is Nothing)

            If EsTransaccional Then

                cmd = New MySqlCommand(sp, pConection)
                cmd.Transaction = pTransaction
            Else

                cmd = New MySqlCommand(sp, cnn)
                cnn.Open()

            End If


            cmd.Parameters.Add(New MySqlParameter("@IDPAGOENC", oBePago_enc.IdPagoEnc))

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
            Dim sp As String = "SELECT * FROM Pago_enc"

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

    Public Function Obtener(ByRef oBePago_enc As clsBePago_enc) As Boolean
        Try
            Dim sp As String = "SELECT * FROM Pago_enc" & _
            " Where(IdPagoEnc = @IdPagoEnc)"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text


            Dim dad As New MySqlDataAdapter(cmd)
            dad.SelectCommand.Parameters.Add(New MySqlParameter("@IDPAGOENC", oBePago_enc.IdPagoEnc))

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count = 1 Then
                Cargar(oBePago_enc, dt.Rows(0))
            Else
                Throw New Exception("No se pudo obtener el registro")
            End If

            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
