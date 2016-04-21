Imports DevExpress.XtraGrid.Views.Grid

Public Class frmPagosDet

    Enum TipoReporte As Integer

        CuotasDetalleDescuento = 1

    End Enum

    Public Sub New()

        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    Private _Nom_Rep As String = ""
    Public Property Nom_Rep() As String
        Get
            Return _Nom_Rep
        End Get
        Set(ByVal value As String)
            _Nom_Rep = value
        End Set
    End Property

    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.ItemClick
        Llenar_Grid()
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
            printLink.Component = Dgrid
            printLink.Landscape = True
            printLink.CreateDocument(printingSystem1)
            printingSystem1.PreviewFormEx.ShowDialog()
            printingSystem1.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs)

        Dim reportHeader As String = vbNewLine & "Reporte detalle de pagos " & _
        "Desde: " & dtpFechaDesde.Value.Date & " Hasta: " & dtpFechaHasta.Value.Date

        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)

        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 70)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)


    End Sub

    Private Sub Llenar_Grid()

        Try

            vSQL = " SELECT " & _
                   " 	cef.Codigo AS CodigoCEF, " & _
                   " 	cef.Descripcion AS NomCEF, " & _
                   " 	descuento_ref.FechaCobro, " & _
                   " 	pago_enc.FechaPago, " & _
                   " 	pago_det.NoCuota, " & _
                   " 	pago_det.MontoCuota, " & _
                   " 	pago_det.MontoAbono, " & _
                   " 	(pago_det.MontoCuota - pago_det.MontoAbono)  as SaldoCuota, " & _
                   " 	pago_det.PagoAutomatico, " & _
                   " 	franquiciado.Codigo AS CodigoFranquiciado, " & _
                   " 	franquiciado.Nombres AS NomFranquiciado, " & _
                   "	beneficio.Nombre, " & _
                   "	beneficio.Modelo, " & _
                   "	beneficio.NoChasis, " & _
                   "	beneficio.NoPlaca, " & _
                   "	beneficio.Motor, " & _
                   "	beneficio.NumeroTelefono, " & _
                   "	beneficio.EmpresaTelco, " & _
                   "	pago_det.IdPagoEnc as NoPago, " & _
                   "	pago_det.IdPagoDet, " & _
                   "	pago_det.IdDescuentoEnc, " & _
                   "	pago_det.IdDescuentoDet, " & _
                   "	pago_det.IdDescuentoRef " & _
                   " FROM " & _
                   "	pago_enc " & _
                   " INNER JOIN pago_det ON pago_enc.IdPagoEnc = pago_det.IdPagoEnc " & _
                   " INNER JOIN descuento_ref ON pago_det.IdDescuentoRef = descuento_ref.IdDescuentoRef " & _
                   " INNER JOIN franquiciado ON pago_enc.IdFranquiciado = franquiciado.IdFranquiciado " & _
                   " INNER JOIN cef ON pago_enc.IdCEF = cef.IdCef " & _
                   " INNER JOIN beneficio ON pago_det.IdBeneficio = beneficio.IdBeneficio " & _
                   " WHERE cast(pago_enc.FechaPago AS DATE) BETWEEN " & FormatoFechas.fFecha(dtpFechaDesde.Value) & _
                   " AND " & FormatoFechas.fFecha(dtpFechaHasta.Value)

            If txtFiltro.Text.Trim <> "" Then
                vSQL += "AND (franquiciado.Codigo LIKE '%" & txtFiltro.Text.Trim & "%'" & _
                    " OR ( franquiciado.Nombres LIKE '%" & txtFiltro.Text.Trim & "%'" & _
                    " OR ( beneficio.NoChasis LIKE '%" & txtFiltro.Text.Trim & "%'" & _
                    " OR ( beneficio.Motor LIKE '%" & txtFiltro.Text.Trim & "%'" & _
                    " OR ( cef.Codigo LIKE '%" & txtFiltro.Text.Trim & "%')"
            End If

            If chkActivo.Checked Then
                vSQL += "AND (Pago_Enc.Anulado =0) " & _
                    " AND (descuento_ref.Anulada=0)"
            End If

            vSQL += "Order by  descuento_ref.FechaCobro,pago_enc.FechaPago,franquiciado.Codigo "


            Dim DT As New DataTable
            BD.OpenDT(DT, vSQL)
            Dgrid.DataSource = DT
            GridView1.OptionsBehavior.Editable = False

            Application.DoEvents()

            If GridView1.Columns.Count = 0 AndAlso GridView1.RowCount = 0 Then Exit Sub

            'GridView1.Columns("CEF").GroupIndex = 0
            'GridView1.Columns("Franquiciado").GroupIndex = 1

            GridView1.Columns("MontoCuota").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            GridView1.Columns("MontoCuota").SummaryItem.DisplayFormat = "{0:n2}"

            GridView1.Columns("MontoCuota").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns("MontoCuota").DisplayFormat.FormatString = "{0:n2}"

            GridView1.Columns("MontoAbono").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            GridView1.Columns("MontoAbono").SummaryItem.DisplayFormat = "{0:n2}"

            GridView1.Columns("MontoAbono").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns("MontoAbono").DisplayFormat.FormatString = "{0:n2}"

            GridView1.Columns("SaldoCuota").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            GridView1.Columns("SaldoCuota").SummaryItem.DisplayFormat = "{0:n2}"
            GridView1.Columns("SaldoCuota").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns("SaldoCuota").DisplayFormat.FormatString = "{0:n2}"

            GridView1.Columns("FechaCobro").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridView1.Columns("FechaCobro").DisplayFormat.FormatString = "dd/MM/yyyy"

            GridView1.Columns("FechaPago").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridView1.Columns("FechaPago").DisplayFormat.FormatString = "dd/MM/yyyy"

            'GridView1.Columns("NoPago").Visible = False
            GridView1.Columns("IdPagoDet").Visible = False
            GridView1.Columns("IdDescuentoEnc").Visible = False
            GridView1.Columns("IdDescuentoDet").Visible = False
            GridView1.Columns("IdDescuentoRef").Visible = False

            'GridView1.ExpandAllGroups()

            GridView1.BestFitColumns()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub frmRepEnGrid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try

            If IO.File.Exists(CurDir() & "\" & Nom_Rep & ".xml") Then IO.File.Delete(CurDir() & "\" & Nom_Rep & ".xml")
            GridView1.SaveLayoutToXml(CurDir() & "\" & Nom_Rep & ".xml")

        Catch ex As Exception
        End Try

    End Sub

    Private Sub frmRepEnGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            'Llenar_Grid()

            If IO.File.Exists(CurDir() & "\" & Nom_Rep & ".xml") Then IO.File.Delete(CurDir() & "\" & Nom_Rep & ".xml")

            If IO.File.Exists(CurDir() & "\" & Nom_Rep & ".xml") Then GridView1.RestoreLayoutFromXml(CurDir() & "\" & Nom_Rep & ".xml")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub cmdImprimir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdImprimir.ItemClick
        Imprimir_Vista()
    End Sub


    Private Sub dtpFechaDesde_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaDesde.ValueChanged
        Llenar_Grid()
    End Sub

    Private Sub dtpFechaHasta_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaHasta.ValueChanged
        Llenar_Grid()
    End Sub

    Private Sub chkActivo_CheckedChanged(sender As Object, e As EventArgs) Handles chkActivo.CheckedChanged
        Llenar_Grid()
    End Sub

    Private Sub txtFiltro_EditValueChanged(sender As Object, e As EventArgs) Handles txtFiltro.EditValueChanged
        Llenar_Grid()
    End Sub

    Private Sub GridView1_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle

        'Dim View As GridView = sender
        'If (e.RowHandle >= 0) Then
        '    Dim category As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Abonado"))
        '    If category = "0.00" Then
        '        e.Appearance.BackColor = Color.Salmon
        '        e.Appearance.BackColor2 = Color.SeaShell
        '    End If
        'End If

    End Sub

End Class