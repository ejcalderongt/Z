Imports MySql.Data.MySqlClient

Partial Public Class clsLnTipobeneficio

    Public Shared Function Exists(ByVal pIdBeneficio As Integer) As Boolean

        Dim lExists As Boolean = False

        Try

            'Validacion y estandarizacion de los datos
            Using lConnection As New MySqlConnection(BD.CadenaConexion)

                'Acceso a los datos.
                Using lCommand As New MySqlCommand("SELECT COUNT(*) FROM beneficio WHERE IdBeneficio=@IdBeneficio", lConnection)

                    lCommand.CommandType = CommandType.Text
                    lCommand.Parameters.AddWithValue("@IdBeneficio", pIdBeneficio)

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
