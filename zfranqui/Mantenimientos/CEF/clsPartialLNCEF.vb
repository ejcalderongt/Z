Imports MySql.Data.MySqlClient
Imports MySql.Data

Partial Public Class clsLnCef

    Public Shared Function Get_IdCEF(ByVal Codigo As String) As Integer

        Get_IdCEF = 0

        Try

            vSQL$ = "SELECT IdCEF FROM CEF WHERE Codigo ='" & Codigo & "'"

            Dim sp As String = vSQL
            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count > 0 Then
                Get_IdCEF = dt.Rows(0).Item("IdCEF")
            End If

            cnn.Dispose()
            cmd.Dispose()
            dad.Dispose()
            dt.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Shared Sub Cargar(ByRef oBeCef As clsBeCef, ByRef dr As DataRow, ByVal Parcial As Boolean)

        Try

            With oBeCef

                .IdCef = IIf(IsDBNull(dr.Item("IdCef")), 0, dr.Item("IdCef"))
                .Codigo = IIf(IsDBNull(dr.Item("Codigo")), "", dr.Item("Codigo"))
                .Descripcion = IIf(IsDBNull(dr.Item("Descripcion")), "", dr.Item("Descripcion"))
                .Encargado = IIf(IsDBNull(dr.Item("Encargado")), "", dr.Item("Encargado"))
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

    Public Shared Function Exists(ByVal pIdCef As Integer) As Boolean

        Dim lExists As Boolean = False

        Try

            'Validacion y estandarizacion de los datos
            Using lConnection As New MySqlConnection(BD.CadenaConexion)

                'Acceso a los datos.
                Using lCommand As New MySqlCommand("SELECT COUNT(*) FROM franquiciadocef WHERE IdCef=@IdCef", lConnection)

                    lCommand.CommandType = CommandType.Text
                    lCommand.Parameters.AddWithValue("@IdCef", pIdCef)

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

    Public Shared Function GetPersona(ByVal pCodigo As String) As clsPersona

        Try

            'Validacion y estandarización de los datos
            Using lCnn As New MySqlConnection(BD.CadenaConexion)

                Dim lSQLC As String = String.Format("SELECT c.IdCef,f.IdFranquiciado FROM cef AS c " _
                                                    & "INNER JOIN franquiciadocef AS fc ON c.IdCef = fc.IdCEF " _
                                                    & "INNER JOIN franquiciado AS f ON fc.IdFranquiciado = f.IdFranquiciado " _
                                                    & "WHERE c.Codigo ='{0}'", pCodigo)

                'Acceso a los datos.
                Using lDTA As New MySqlDataAdapter(lSQLC, lCnn)

                    lDTA.SelectCommand.CommandType = CommandType.Text

                    Dim lDT As New DataTable
                    lDTA.Fill(lDT)

                    Dim Obj As clsPersona

                    If lDT IsNot Nothing AndAlso lDT.Rows.Count > 0 Then
                        Obj = New clsPersona
                        Obj.IdCef = CType(lDT(0)("IdCef"), System.Int32)
                        Obj.IdFranquiciado = CType(lDT(0)("IdFranquiciado"), System.Int32)
                        Return Obj
                    End If

                End Using
            End Using

            Return Nothing

        Catch ex As Exception
            Throw ex
        End Try

    End Function


End Class
