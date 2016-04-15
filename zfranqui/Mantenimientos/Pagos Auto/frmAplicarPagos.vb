Imports MySql.Data.MySqlClient

Public Class frmAplicarPagos

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
        Llenar_Ventas()
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
            printLink.Component = dgridDescuentos
            printLink.Landscape = True
            printLink.CreateDocument(printingSystem1)
            printingSystem1.PreviewFormEx.ShowDialog()
            printingSystem1.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs)


        Select Case TipoRep

            Case TipoReporte.CuotasDetalleDescuento

                Dim reportHeader As String = vbNewLine & "Detalle de descuentos " & vbNewLine & _
                "Franquiciado: " & DescuentoEnc.Franquiciado.Codigo & " - " & DescuentoEnc.Franquiciado.Nombres & " CEF: " & DescuentoEnc.Franquiciado.CEF.Codigo & " - " & DescuentoEnc.Franquiciado.CEF.Descripcion

                e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)
                e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)

                Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 70)
                e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)

            Case Else

        End Select

    End Sub

    Private Sub Llenar_Ventas()

        Try

            vSQL = "SELECT " & _
                    "ventasdet.IdVenta," & _
                    "cef.Codigo AS CEF, " & _
                    "franquiciado.Codigo AS Franquiciado, " & _
                    "ventasdet.IdFranquiciado, " & _
                    "SUM(ventasdet.Monto) AS Monto, " & _
                    "ventasdet.Fecha, " & _
                    "ventasdet.Saldo, " & _
                    "ventasdet.Pagado " & _
                    "FROM " & _
                    "	franquiciadocef " & _
                    "INNER JOIN cef ON franquiciadocef.IdCEF = cef.IdCef " & _
                    "INNER JOIN ventasdet ON franquiciadocef.IdFranquiciado = ventasdet.IdFranquiciado " & _
                    "INNER JOIN franquiciado ON franquiciadocef.IdFranquiciado = franquiciado.IdFranquiciado " & _
                    " AND ventasdet.fecha>=" & FormatoFechas.fFecha(dtpFechaDesdeVentas.Value) & _
                   " AND ventasdet.fecha<=" & FormatoFechas.fFecha(dtpFechaHastaVentas.Value)

            vSQL += "GROUP BY " & _
                    "ventasdet.IdVenta, " & _
                    "cef.Codigo, " & _
                    "franquiciado.Codigo, " & _
                    "ventasdet.IdFranquiciado, " & _
                    "ventasdet.Fecha, " & _
                    "ventasdet.Saldo, " & _
                    "ventasdet.Pagado "

            Dim DT As New DataTable
            BD.OpenDT(DT, vSQL)
            dgridDescuentos.DataSource = DT
            GridView1.OptionsBehavior.Editable = False

            Application.DoEvents()

            If GridView1.Columns.Count = 0 Then Exit Sub

            GridView1.Columns("crmrdi").GroupIndex = 0

            GridView1.Columns("Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            GridView1.Columns("Total").SummaryItem.DisplayFormat = "{0:n2}"

            GridView1.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns("Total").DisplayFormat.FormatString = "{0:n2}"

            GridView1.ExpandAllGroups()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Llenar_DescuentosREF()

        Try

            clsLnDescuento_enc.GetAllByCefFranquiciadoCuota(dtpFechaDesdeDescuentos.Value, dtpFechaHastaDescuentos.Value)

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

            'If IO.File.Exists(CurDir() & "\" & Nom_Rep & ".xml") Then IO.File.Delete(CurDir() & "\" & Nom_Rep & ".xml")

            'If IO.File.Exists(CurDir() & "\" & Nom_Rep & ".xml") Then GridView1.RestoreLayoutFromXml(CurDir() & "\" & Nom_Rep & ".xml")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub cmdImprimir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdImprimir.ItemClick
        Imprimir_Vista()
    End Sub


    Private Sub dtpFechaDesde_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaDesdeVentas.ValueChanged
        Llenar_Ventas()
    End Sub

    Private Sub dtpFechaHasta_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaHastaVentas.ValueChanged
        Llenar_Ventas()
    End Sub

    Private Sub chkActivo_CheckedChanged(sender As Object, e As EventArgs)
        Llenar_Ventas()
    End Sub

    Private Sub txtFiltro_EditValueChanged(sender As Object, e As EventArgs)
        Llenar_Ventas()
    End Sub

    Private Sub mnuProcesar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuProcesar.ItemClick
        SincronizarVentas()
    End Sub


    Public Function SincronizarVentas() As Boolean

        SincronizarVentas = False

        Dim DT As New DataTable
        Dim v As New clsBeVentasdet
        Dim dv As New clsLnVentasdet
        Dim lv As New List(Of clsBeVentasdet)
        Dim ListaCEFSinFranquiciados As New List(Of String)

        txt.Visible = True
        txt.Text = ""

        Try

            vSQL = " SELECT " & _
                " 	e.crmrdi as IdCEF, " & _
                " 	c.despes as despes, " & _
                " 	SUM(a.cant) as cilindros, " & _
                " 	d.cantidad as 'RetencionCliente', " & _
                " 	SUM(a.cant) * d.cantidad as Monto, " & _
                "	b.fecha as Fecha " & _
                " FROM " & _
                " 	facdet a " & _
                " INNER JOIN facenc b ON a.codpla = b.codpla " & _
                " AND a.serie = b.serie " & _
                " AND a.numero = b.numero " & _
                " INNER JOIN pesmae c ON a.codpes = c.codpes " & _
                " INNER JOIN retencionmae d ON a.codpes = d.codpes " & _
                " INNER JOIN rdimae e ON a.codcli = e.codrdi " & _
                " WHERE  b.status='ACTIVA' " & _
                " AND b.fecha>=" & FormatoFechas.fFecha(dtpFechaDesdeVentas.Value) & _
                " AND b.fecha<=" & FormatoFechas.fFecha(dtpFechaHastaVentas.Value) & _
                " GROUP BY " & _
                " 	e.crmrdi, " & _
                " 	a.codpes, " & _
                " 	b.fecha " & _
                " ORDER BY " & _
                " b.fecha, " & _
                " a.codcli; "

            BD.OpenDT(DT, vSQL, BD.CadenaConexionZVentas)

            Dim vPkVentaDET As Integer = dv.MaxID() + 1

            Dim CodigoCEF As String = ""
            Dim IdCEF As Integer = 0
            Dim dCEF As New clsLnCef

            Dim dfran As New clsLnFranquiciadocef
            Dim IdFranqui As Integer = 0

            prg.Maximum = DT.Rows.Count

            txt.AppendText("Procesando " & DT.Rows.Count & " Detalles de ventas..." & vbNewLine)

            Application.DoEvents()

            For i As Integer = 0 To DT.Rows.Count - 1

                v = New clsBeVentasdet
                v.Cilindros = IIf(IsDBNull(DT.Rows(i).Item("cilindros")), 0, DT.Rows(i).Item("cilindros"))
                v.Despes = IIf(IsDBNull(DT.Rows(i).Item("despes")), 0, DT.Rows(i).Item("despes"))
                v.Fec_agr = Now
                v.Fecha = IIf(IsDBNull(DT.Rows(i).Item("Fecha")), 0, DT.Rows(i).Item("Fecha"))

                CodigoCEF = IIf(IsDBNull(DT.Rows(i).Item("IdCEF")), 0, DT.Rows(i).Item("IdCEF"))

                'If CodigoCEF <> "AT39" Then MsgBox("ESPERA")

                If Not ListaCEFSinFranquiciados.Contains(CodigoCEF) Then

                    IdCEF = dCEF.Get_IdCEF(CodigoCEF)

                    txt.AppendText("Obteniendo IdCEF: " & IdCEF & vbNewLine)

                    IdFranqui = dfran.GetIdFranquiciado(IdCEF)
                    txt.AppendText("Obteniendo IdFranquiciado: " & IdFranqui & vbNewLine)

                    If IdFranqui <= 0 Then

                        txt.AppendText("No se pudo obtener el IdFranquiciado para el CEF: " & CodigoCEF & vbNewLine)
                        ListaCEFSinFranquiciados.Add(CodigoCEF)

                    Else

                        v.IdFranquiciado = IdFranqui
                        v.IdPagoDet = 0
                        v.IdPagoEnc = 0
                        v.Monto = IIf(IsDBNull(DT.Rows(i).Item("Monto")), 0, DT.Rows(i).Item("Monto"))
                        v.Pagado = 0
                        v.Pagado = 0
                        v.RetencionCliente = IIf(IsDBNull(DT.Rows(i).Item("RetencionCliente")), 0, DT.Rows(i).Item("RetencionCliente"))
                        v.IdVenta = vPkVentaDET
                        vPkVentaDET += 1

                        If Not dv.ExisteRegistro(v) Then
                            lv.Add(v)
                            txt.AppendText("Adicionando a la lista de transacciones CEF: " & CodigoCEF & " Fecha: " & v.Fecha & " Monto: " & v.Monto & vbNewLine)
                        Else
                            txt.AppendText("Omitiendo CEF: " & CodigoCEF & " Fecha: " & v.Fecha & " Monto: " & v.Monto & " ***(Ya existe)*** " & vbNewLine)
                        End If

                    End If

                Else

                    txt.AppendText("Omitiendo registros de CEF: " & CodigoCEF & " (Sin Franquiciado) " & i & vbNewLine)

                End If

                prg.Value = i

                Application.DoEvents()

            Next

            prg.Value = 0

            If lv.Count > 0 Then

                txt.AppendText("Iniciando inserción transaccional..." & vbNewLine)

                Dim cnn As New MySqlConnection(BD.CadenaConexion)
                Dim ltrans As MySqlTransaction = Nothing

                Try

                    cnn.Open()

                    ltrans = cnn.BeginTransaction

                    prg.Maximum = lv.Count

                    Dim Contador As Integer = 0

                    For Each ven As clsBeVentasdet In lv

                        txt.AppendText("Procesando VentaId: " & ven.IdVenta & vbNewLine)

                        dv.Insertar(ven, cnn, ltrans)
                        prg.Value = Contador
                        Contador += 1
                        Application.DoEvents()

                    Next

                    ltrans.Commit()

                    MsgBox("Se procesaro correctamente " & lv.Count & " Registros de ventas", MsgBoxStyle.Information, Me.Text)

                Catch ex As Exception
                    ltrans.Rollback()
                    MsgBox("Error al insertar el detalle de ventas: " & ex.Message)
                Finally
                    If Not cnn Is Nothing AndAlso cnn.State = ConnectionState.Open Then cnn.Close()
                    ltrans.Dispose()
                End Try

            Else
                MsgBox("No se encontraron registros para insertar", MsgBoxStyle.Exclamation, Me.Text)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            prg.Visible = False
            'txt.Visible = False
        End Try

    End Function

    Private Sub txt_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txt.MouseDoubleClick
        txt.Visible = False
    End Sub

    Private Sub dtpFechaDesdeDescuentos_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaDesdeDescuentos.ValueChanged
        Llenar_DescuentosREF()
    End Sub
    Private Sub dtpFechaHastaDescuentos_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaHastaDescuentos.ValueChanged
        Llenar_DescuentosREF()
    End Sub

End Class