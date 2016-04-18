Imports MySql.Data.MySqlClient

Public Class frmAplicarPagos

    Public Property lventas As New List(Of clsBeVentasenc)
    Public Property ldescuentosref As New List(Of clsBeDescuento_ref)
    Public Sub New()

        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    Private Sub cmdActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActualizar.ItemClick
        Llenar_Ventas()
    End Sub

    Private Sub Imprimir_Vista()

        Try

            Dim printingSystem1 As New DevExpress.XtraPrinting.PrintingSystem()
            Dim printLink As New DevExpress.XtraPrinting.PrintableComponentLink()

            ' AddHandler printLink.CreateReportHeaderArea, AddressOf PrintableComponentLink1_CreateReportHeaderArea

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
    Private Sub Llenar_Ventas()

        Try

            UseWaitCursor = True

            lventas = New List(Of clsBeVentasenc)

            lventas = clsLnVentasenc.GetByDate(dtpFechaDesdeVentas.Value, dtpFechaHastaVentas.Value)

            If Not lventas Is Nothing Then

                Dim DT As New DataTable("Result")
                DT.Columns.Add("IdPeriodoVenta", GetType(Integer))
                DT.Columns.Add("FechaDesde", GetType(Date))
                DT.Columns.Add("FechaHasta", GetType(Date))
                DT.Columns.Add("CEF", GetType(String))
                DT.Columns.Add("Franquiciado", GetType(String))
                DT.Columns.Add("Monto", GetType(Decimal))
                DT.Columns.Add("Pagado", GetType(Decimal))
                DT.Columns.Add("Saldo", GetType(Decimal))

                Dim cef As New clsLnCef
                Dim fra As New clsLnFranquiciado

                For Each Obj As clsBeVentasenc In lventas

                    Application.DoEvents()

                    Dim Row As DataRow = DT.NewRow

                    Row.Item("IdPeriodoVenta") = Obj.IdPeriodoVenta
                    Row.Item("FechaDesde") = Obj.FechaDesde
                    Row.Item("FechaHasta") = Obj.FechaHasta
                    Row.Item("CEF") = Obj.CodigoCEF
                    Row.Item("Franquiciado") = Obj.CodigoFranquiciado
                    Row.Item("Monto") = Obj.Monto
                    Row.Item("Pagado") = Obj.Pagado
                    Row.Item("Saldo") = Obj.Pagado
                    DT.Rows.Add(Row)

                    Application.DoEvents()

                Next

                dgridVentas.DataSource = DT

                viewVentas.OptionsBehavior.Editable = False

                Application.DoEvents()

                'viewVentas.Columns("CEF").GroupIndex = 0

                viewVentas.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                viewVentas.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"

                viewVentas.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                viewVentas.Columns("Monto").DisplayFormat.FormatString = "{0:n2}"

                viewVentas.Columns("Saldo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                viewVentas.Columns("Saldo").SummaryItem.DisplayFormat = "{0:n2}"

                viewVentas.Columns("Saldo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                viewVentas.Columns("Saldo").DisplayFormat.FormatString = "{0:n2}"

                viewVentas.Columns("Pagado").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                viewVentas.Columns("Pagado").SummaryItem.DisplayFormat = "{0:n2}"

                viewVentas.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                viewVentas.Columns("Monto").DisplayFormat.FormatString = "{0:n2}"

                viewVentas.ExpandAllGroups()

                viewVentas.BestFitColumns()

                lblTotalVentas.Text = "Total Ventas: " & Format(viewVentas.Columns("Monto").SummaryItem.SummaryValue(), "C")


            Else

                lblTotalVentas.Text = "Total Ventas: 0.00 "

            End If

            UseWaitCursor = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Llenar_DescuentosREF()

        Try

            ldescuentosref = New List(Of clsBeDescuento_ref)

            ldescuentosref = clsLnDescuento_ref.GetByDate(dtpFechaDesdeDescuentos.Value, dtpFechaHastaDescuentos.Value)

            If Not ldescuentosref Is Nothing Then

                Dim DT As New DataTable("Result")
                DT.Columns.Add("CEF", GetType(String))
                DT.Columns.Add("Franquiciado", GetType(String))
                DT.Columns.Add("IdDescuentoRef", GetType(Integer))
                DT.Columns.Add("Beneficio", GetType(String))
                DT.Columns.Add("Fecha_Descuento", GetType(DateTime))
                DT.Columns.Add("No_Cuota", GetType(Integer))
                DT.Columns.Add("Monto", GetType(Decimal))
                DT.Columns.Add("Abonado", GetType(Decimal))
                DT.Columns.Add("Pagada", GetType(Boolean))

                For Each Obj As clsBeDescuento_ref In ldescuentosref

                    Application.DoEvents()

                    Dim Row As DataRow = DT.NewRow

                    Row.Item("CEF") = Obj.CodigoCEF & " - " & Obj.NomCEF
                    Row.Item("Franquiciado") = Obj.CodigoFranquiciado & " - " & Obj.NomFranquiciado
                    Row.Item("IdDescuentoRef") = Obj.IdDescuentoRef

                    If Obj.Beneficio.TipoBeneficio.EsVehiculo Then
                        Row.Item("Beneficio") = String.Format("{0} {1} {2} {3} {4}", Obj.Beneficio.Nombre, Obj.Beneficio.Modelo, Obj.Beneficio.NoPlaca, Obj.Beneficio.Motor, Obj.Beneficio.NoChasis).Trim()
                    ElseIf Obj.Beneficio.TipoBeneficio.EsTelefono Then
                        Row.Item("Beneficio") = String.Format("{0} {1} {2}", Obj.Beneficio.Nombre, Obj.Beneficio.NumeroTelefono, Obj.Beneficio.EmpresaTelco).Trim()
                    ElseIf Obj.Beneficio.TipoBeneficio.EsServicio Then
                        Row.Item("Beneficio") = String.Format("{0}", Obj.Beneficio.Nombre).Trim()
                    End If

                    Row.Item("Fecha_Descuento") = Obj.FechaCobro
                    Row.Item("No_Cuota") = Obj.NoCuota
                    Row.Item("Monto") = Obj.Monto
                    Row.Item("Abonado") = Obj.Abonado
                    Row.Item("Pagada") = Obj.Pagada
                    DT.Rows.Add(Row)

                Next

                dgridDescuentos.DataSource = DT

                viewDescuentos.OptionsBehavior.Editable = False

                Application.DoEvents()

                If viewDescuentos.Columns.Count = 0 OrElse viewDescuentos.RowCount = 0 Then Exit Sub

                viewDescuentos.Columns("CEF").GroupIndex = 0
                'viewDescuentos.Columns("Franquiciado").GroupIndex = 1

                viewDescuentos.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                viewDescuentos.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"

                viewDescuentos.Columns("Abonado").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                viewDescuentos.Columns("Abonado").SummaryItem.DisplayFormat = "{0:n2}"

                viewDescuentos.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                viewDescuentos.Columns("Monto").DisplayFormat.FormatString = "{0:n2}"

                viewDescuentos.Columns("Abonado").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                viewDescuentos.Columns("Abonado").DisplayFormat.FormatString = "{0:n2}"

                viewDescuentos.Columns("Fecha_Descuento").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                viewDescuentos.Columns("Fecha_Descuento").DisplayFormat.FormatString = "dd/MM/yyyy"

                viewDescuentos.ExpandAllGroups()

                viewDescuentos.BestFitColumns()

                lblTotalDescuentos.Text = "Total Descuentos: " & Format(viewDescuentos.Columns("Monto").SummaryItem.SummaryValue(), "C")

            Else

                lblTotalDescuentos.Text = "Total Descuentos: 0"

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub frmRepEnGrid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try

            'If IO.File.Exists(CurDir() & "\" & Nom_Rep & ".xml") Then IO.File.Delete(CurDir() & "\" & Nom_Rep & ".xml")
            'viewDescuentos.SaveLayoutToXml(CurDir() & "\" & Nom_Rep & ".xml")

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
        AplicarPagosDesdeVentas()
    End Sub


    Public Function AplicarPagosDesdeVentas() As Boolean

        AplicarPagosDesdeVentas = False

        Try

            Dim lpagoenc As New List(Of clsBePago_enc)
            Dim lpagodet As New List(Of clsBePago_det)

            Dim pe As New clsBePago_enc
            Dim pd As New clsBePago_det

            Dim IdPagoEnc As Integer = clsLnPago_enc.Generar_Nuevo_IdPago()
            Dim IdPagoDet As Integer = clsLnPago_det.MaxID(IdPagoEnc)

            If Not lventas Is Nothing AndAlso lventas.Count > 0 Then

                If Not ldescuentosref Is Nothing AndAlso ldescuentosref.Count > 0 Then

                    If MsgBox("¿Se aplicarán los pagos a los descuentos en base a la lista de ventas seleccionada, ¿continuar?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then


                        Dim FranquiciadosConVentas = From f In lventas Select New With {Key f.IdCEF, f.IdFranquiciado} Distinct.ToList

                        'Recorrer los franquiciados que tienen ventas
                        For Each F In FranquiciadosConVentas

                            pe = New clsBePago_enc
                            pe.IdPagoEnc = IdPagoEnc
                            pe.IdFranquiciado = F.IdFranquiciado
                            pe.IdCEF = F.IdCEF
                            pe.IsNew = True
                            pe.Anulado = False
                            pe.FechaPago = Now.Date
                            pe.User_agr = gUsuario.IdUsuario
                            pe.User_mod = gUsuario.IdUsuario
                            pe.Fec_agr = Now
                            pe.Fec_mod = Now
                            'pe.NoDeposito = FormatoFechas.fFechaHora(Now)

                            'Filtrar la lista de ventas por franquiciado.
                            Dim VentasFranqui = lventas.Where(Function(vf) vf.IdFranquiciado = F.IdFranquiciado)

                            'Filtrar la lista de descuentos por franquiciado y solo los descuentos con fecha menor a la actual
                            Dim DescuentosRefPorFranqui = ldescuentosref.Where _
                                                          (Function(df) df.CodigoFranquiciado = clsLnFranquiciado.GetCodigo(F.IdFranquiciado) _
                                                               And df.FechaCobro <= Now.Date).OrderBy(Function(od) od.FechaCobro)

                            'Recorrer el detalle de ventas delfranquiciado filtrado
                            For Each v In VentasFranqui

                                For Each d In DescuentosRefPorFranqui

                                    pd = New clsBePago_det
                                    pd.Beneficio = New clsBeBeneficio
                                    pd.Fec_agr = Date.Now
                                    pd.Fec_mod = Date.Now
                                    pd.IdBeneficio = d.IdBeneficio
                                    pd.IdDescuentoDet = d.IdDescuentoDet
                                    pd.IdDescuentoEnc = d.IdDescuentoEnc
                                    pd.IdDescuentoRef = d.IdDescuentoRef
                                    pd.IdPagoDet = IdPagoDet
                                    pd.IdPagoEnc = IdPagoEnc
                                    pd.IsNew = True
                                    pd.NoCuota = d.NoCuota
                                    pd.MontoCuota = d.Monto

                                    'pd.MontoAbono = 

                                Next

                            Next 'lista de detalle de ventas por franquiciado

                        Next 'lista de franquiciados con ventas

                        For Each v As clsBeVentasenc In lventas

                            'Filtrar la lista de descuentos por franquiciado y solo los descuentos con fecha menor a la actual
                            Dim DescuentosRefPorFranqui = ldescuentosref.Where _
                                                          (Function(f) f.CodigoFranquiciado = clsLnFranquiciado.GetCodigo(v.IdFranquiciado) _
                                                               And f.FechaCobro <= Now.Date)

                            'dr = descuentoref
                            For Each dr In DescuentosRefPorFranqui

                                'Si el monto de esa venta es mayor que la cuota
                                'aplicar el monto de esa venta a la cuota y pagar la todadlidad de la misma

                                If v.Monto >= dr.Monto Then

                                End If

                            Next

                        Next 'Recorrer detalle de ventas para aplicar a descuentos

                    End If 'No confirmó mensaje

                Else
                    MsgBox("No se ha definido la lista de descuentos a los que se le aplicarán los pagos", MsgBoxStyle.Exclamation, Me.Text)
                End If 'No se listaron los descuentos

            Else
                MsgBox("No se encontraron ventas para aplicar los pagos", MsgBoxStyle.Exclamation, Me.Text)
            End If 'No se listaron las ventas


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