Imports MySql.Data.MySqlClient
Imports MySql.Data

Partial Public Class clsLnPeriodo_descuento

    Public Shared Function LlenaPeriodoDescuento(ByRef cmb As ComboBox) As Boolean

        Try

            Dim sp As String = "SELECT IdPeriodo, Nombre, Dias FROM periodo_descuento"

            Dim cnn As New MySqlConnection(BD.CadenaConexion)
            Dim cmd As New MySqlCommand(sp, cnn)
            cmd.CommandType = CommandType.Text

            Dim dad As New MySqlDataAdapter(cmd)

            Dim dt As New DataTable
            dad.Fill(dt)

            If dt.Rows.Count > 0 Then
                cmb.DisplayMember = "Nombre"
                cmb.ValueMember = "IdPeriodo"
                cmb.DataSource = dt
            End If

            Return True

        Catch ex As Exception
            Throw ex
        End Try

    End Function


End Class
