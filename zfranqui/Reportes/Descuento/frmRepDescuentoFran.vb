Imports DevExpress.XtraGrid.Views.Grid

Public Class frmRepDescuentoFran

    Public pIdFranquiciado As Integer

    Enum TipoReporte As Integer

        CuotasDetalleDescuento = 1

    End Enum

    Private Property TipoRep As TipoReporte = -1

    Public Property DescuentoEnc As New clsBeDescuento_enc

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


        'Select Case TipoRep

        'Case TipoReporte.CuotasDetalleDescuento

        'Dim reportHeader As String = vbNewLine & "Detalle de descuentos " & vbNewLine & _
        '"Franquiciado: " & DescuentoEnc.Franquiciado.Codigo & " - " & DescuentoEnc.Franquiciado.Nombres & " CEF: " & DescuentoEnc.Franquiciado.CEF.Codigo & " - " & DescuentoEnc.Franquiciado.CEF.Descripcion

        Dim reportHeader As String = vbNewLine & "Reporte Descuentos por Franquiciados " & _
       "Desde: " & dtpFechaDesde.Value.Date & " Hasta: " & dtpFechaHasta.Value.Date

        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)

        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 70)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)


        'Case Else


        'End Select



    End Sub

    Private Sub Llenar_Grid()

        Try

            vSQL = "    SELECT " & _
                   "	descuento_enc.fec_agr AS FechaDescuento, " & _
                   "	b.Nombre, " & _
                   "	b.Modelo, " & _
                   "	b.NoChasis, " & _
                   "	b.NoPlaca, " & _
                   "	b.Motor, " & _
                   "	b.NumeroTelefono, " & _
                   "	b.EmpresaTelco, " & _
                   "	tp.EsVehiculo, " & _
                   "	tp.EsTelefono, " & _
                   "	tp.EsServicio, " & _
                   "	descuento_det.MontoTotal AS Monto, " & _
                   "	SUM(r.Abonado) AS Abonado, " & _
                   "	tipodescuento.Nombre AS TipoDescuento, " & _
                   "	CONCAT( " & _
                   "		franquiciado.Codigo, " & _
                   "		' ', " & _
                   "		franquiciado.Nombres " & _
                   "	) AS Franquiciado, " & _
                   "	CONCAT( 		cef.Codigo, 		' ', 		cef.Descripcion, 		 ' - Inter: ', " & _
                   "   cast(if(cef.Interlocutor is null,'',cef.Interlocutor) as unsigned), ' Pts: ', cast(if(cef.Puntos is null,'',cef.Puntos) as unsigned)) AS CEF  " & _
                   "   FROM " & _
                   "	descuento_ref AS r " & _
                   "   INNER JOIN beneficio AS b ON r.IdBeneficio = b.IdBeneficio " & _
                   "   INNER JOIN tipobeneficio AS tp ON b.IdTipoBeneficio = tp.IdTipoBeneficio " & _
                   "   INNER JOIN descuento_enc ON r.IdDescuentoEnc = descuento_enc.IdDescuentoEnc " & _
                   "   INNER JOIN tipodescuento ON descuento_enc.IdTipoDescuento = tipodescuento.IdTipoDescuento " & _
                   "   INNER JOIN franquiciado ON descuento_enc.IdFranquiciado = franquiciado.IdFranquiciado " & _
                   "   INNER JOIN cef ON descuento_enc.IdCEF = cef.IdCef " & _
                   "   INNER JOIN descuento_det ON r.IdDescuentoEnc = descuento_det.IdDescuentoEnc " & _
                   "   AND r.IdDescuentoDet = descuento_det.IdDescuentoDet " & _
                   "   AND r.IdBeneficio = descuento_det.IdBeneficio " & _
                   "   WHERE cast(descuento_enc.fec_agr AS DATE) BETWEEN " & FormatoFechas.fFecha(dtpFechaDesde.Value) & _
                   "   AND " & FormatoFechas.fFecha(dtpFechaHasta.Value)

            If txtFiltro.Text.Trim <> "" Then
                vSQL += "AND (franquiciado.Codigo LIKE '%" & txtFiltro.Text.Trim & "%'" & _
                    " OR ( franquiciado.Nombres LIKE '%" & txtFiltro.Text.Trim & "%'" & _
                    " OR ( b.NoChasis LIKE '%" & txtFiltro.Text.Trim & "%'" & _
                    " OR ( b.Motor LIKE '%" & txtFiltro.Text.Trim & "%'" & _
                    " OR ( cef.Codigo LIKE '%" & txtFiltro.Text.Trim & "%')"
            End If

            If chkActivo.Checked Then
                vSQL += "AND (descuento_det.Activo =1) "
                vSQL += "AND (r.Anulada =0) "
            End If

            If pIdFranquiciado <> 0 Then
                vSQL += " AND franquiciado.IdFranquiciado=" & pIdFranquiciado & " "
            End If

            vSQL += "GROUP BY " & _
                    "	b.Nombre, " & _
                    "	b.Modelo, " & _
                    "	b.NoChasis, " & _
                    "	b.NoPlaca, " & _
                    "	b.Motor, " & _
                    "	b.NumeroTelefono, " & _
                    "	b.EmpresaTelco, " & _
                    "	tp.EsVehiculo, " & _
                    "	tp.EsTelefono, " & _
                    "	tp.EsServicio, " & _
                    "	tipodescuento.Nombre, " & _
                    "	franquiciado.Codigo, " & _
                    "	franquiciado.Nombres, " & _
                    "	cef.Codigo, " & _
                    "	cef.Descripcion, " & _
                    "	descuento_enc.fec_agr, " & _
                    "	descuento_det.MontoTotal "

            'Se hace a traves del campo activo cuando un descuento se pagó en su totalidad se actualiza la bandera activo = false
            'vSQL += " HAVING descuento_det.MontoTotal > SUM(r.Abonado) "

            Dim DT As New DataTable
            BD.OpenDT(DT, vSQL)
            Dgrid.DataSource = DT
            GridView1.OptionsBehavior.Editable = False

            Application.DoEvents()

            If GridView1.Columns.Count = 0 Then Exit Sub

            GridView1.Columns("CEF").GroupIndex = 0
            GridView1.Columns("Franquiciado").GroupIndex = 1

            GridView1.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            GridView1.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"

            GridView1.Columns("Abonado").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            GridView1.Columns("Abonado").SummaryItem.DisplayFormat = "{0:n2}"

            GridView1.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns("Monto").DisplayFormat.FormatString = "{0:n2}"

            GridView1.Columns("Abonado").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns("Abonado").DisplayFormat.FormatString = "{0:n2}"

            GridView1.Columns("FechaDescuento").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            GridView1.Columns("FechaDescuento").DisplayFormat.FormatString = "dd/MM/yyyy"

            GridView1.ExpandAllGroups()

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

    Private Sub GridView1_RowStyle(ByVal sender As Object, _
ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle

        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim category As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("Abonado"))
            If category = "0.00" Then
                e.Appearance.BackColor = Color.Salmon
                e.Appearance.BackColor2 = Color.SeaShell
            End If
        End If

    End Sub

End Class