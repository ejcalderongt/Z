Public Class frmReporte

    Public pIdDescuentoEnc As Integer

    Private Sub frmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Carga()

    End Sub

    Private Sub Carga()

        Try

            Dim DT As New DataTable
            'DT = clsLnDescuento_enc.GetAllByEncabezado(pIdDescuentoEnc)

            rptView.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
            rptView.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\PeriodoDefinido.rdlc"
            rptView.LocalReport.DataSources.Clear()
            rptView.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", DT))
            rptView.DocumentMapCollapsed = True
            rptView.RefreshReport()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try

    End Sub

End Class