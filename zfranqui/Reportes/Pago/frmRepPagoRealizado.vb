Imports DevExpress.XtraEditors

Public Class frmRepPagoRealizado

    Public pObjPagoEnc As clsBePago_enc

    Public Sub Carga()

        Try

            Dim lSQL As String = "SELECT c.Codigo AS Cef,c.Descripcion,f.Codigo,f.Nombres," _
                               & "b.Nombre AS Beneficio, det.NoCuota AS 'No. Cuota', det.MontoCuota AS 'Monto Cuota', det.MontoAbono AS 'Monto Abono', enc.FechaPago AS 'Fecha Pago' " _
                               & "FROM pago_enc AS enc " _
                               & "INNER JOIN pago_det AS det ON enc.IdPagoEnc = det.IdPagoEnc " _
                               & "INNER JOIN cef AS c ON enc.IdCEF = c.IdCef " _
                               & "INNER JOIN franquiciado AS f ON enc.IdFranquiciado = f.IdFranquiciado " _
                               & "INNER JOIN beneficio AS b ON det.IdBeneficio = b.IdBeneficio " _
                               & "WHERE enc.IdPagoEnc=" & pObjPagoEnc.IdPagoEnc

            Dim DT As New DataTable
            BD.OpenDT(DT, lSQL)
            dgrid.DataSource = DT
            GridView1.OptionsBehavior.Editable = False

            Application.DoEvents()

            If GridView1.RowCount > 0 Then

                GridView1.OptionsView.ShowFooter = True

                GridView1.Columns(0).GroupIndex = 1
                GridView1.Columns(2).GroupIndex = 1

                GridView1.Columns("No. Cuota").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                GridView1.Columns("No. Cuota").SummaryItem.DisplayFormat = "{0:n2}"

                GridView1.Columns("Monto Cuota").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                GridView1.Columns("Monto Cuota").SummaryItem.DisplayFormat = "{0:n2}"

                GridView1.Columns("Monto Abono").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                GridView1.Columns("Monto Abono").SummaryItem.DisplayFormat = "{0:n2}"

            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub frmRepPagoRealizado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carga()
    End Sub

    Private Sub Imprimir_Vista()

        Try

            Dim printingSystem1 As New DevExpress.XtraPrinting.PrintingSystem()
            Dim printLink As New DevExpress.XtraPrinting.PrintableComponentLink()

            AddHandler printLink.CreateReportHeaderArea, AddressOf PrintableComponentLink1_CreateReportHeaderArea

            Dim leftColumnFoot As String = "Páginas: [Page # of Pages #] "
            Dim leftColumnHead As String = "Usuario: [User Name] - " & gUsuario.Nombre

            Dim rightColumn As String = "Fecha: [Date Printed] [Time Printed] "

            Dim phf As DevExpress.XtraPrinting.PageHeaderFooter = _
            TryCast(printLink.PageHeaderFooter, DevExpress.XtraPrinting.PageHeaderFooter)

            phf.Header.Content.Clear()

            phf.Footer.Content.AddRange(New String() _
            {leftColumnFoot})
            phf.Footer.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Near

            phf.Header.Content.AddRange(New String() _
            {leftColumnHead, "", rightColumn})
            phf.Header.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Far

            printingSystem1.PageSettings.Landscape = True
            printLink.Component = dgrid
            printLink.Landscape = True
            printLink.CreateDocument(printingSystem1)
            printingSystem1.PreviewFormEx.ShowDialog()
            printingSystem1.Dispose()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs)

        Try

            Dim reportHeader As String = vbNewLine & "Detalle de Pagos Realizados " & vbNewLine & _
            "Franquiciado: " & pObjPagoEnc.Franquiciado.Codigo & " - " & pObjPagoEnc.Franquiciado.Nombres & " CEF: " & pObjPagoEnc.Franquiciado.CEF.Codigo & " - " & pObjPagoEnc.Franquiciado.CEF.Descripcion

            e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)
            e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)

            Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 70)
            e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub cmdImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdImprimir.ItemClick
        Imprimir_Vista()
    End Sub

    Private Sub cmdActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdActualizar.ItemClick
        Carga()
    End Sub
End Class