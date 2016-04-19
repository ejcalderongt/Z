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
                    Row.Item("Saldo") = Obj.Saldo
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
            Dim tventas As New List(Of clsBeVentasenc)

            Dim pe As New clsBePago_enc
            Dim pd As New clsBePago_det


            Dim IdPagoEnc As Integer = clsLnPago_enc.Generar_Nuevo_IdPago()
            Dim IdPagoDet As Integer = clsLnPago_det.MaxID(IdPagoEnc) + 1

            If Not lventas Is Nothing AndAlso lventas.Count > 0 Then

                If Not ldescuentosref Is Nothing AndAlso ldescuentosref.Count > 0 Then

                    If MsgBox("Se aplicarán los pagos a los descuentos en base a la lista de ventas seleccionada, ¿continuar?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                        Dim FranquiciadosConVentas = From f In lventas Select New With {Key f.IdCEF, f.IdFranquiciado, f.CodigoFranquiciado, f.CodigoCEF} Distinct.ToList.OrderBy(Function(f) f.IdFranquiciado)

                        prg.Maximum = FranquiciadosConVentas.Count

                        Dim ContadorPrg As Integer = 0

                        'Recorrer los franquiciados que tienen ventas
                        For Each F In FranquiciadosConVentas

                            prg.Value = ContadorPrg

                            pe = New clsBePago_enc
                            pe.Franquiciado = New clsBeFranquiciado
                            pe.CEF = New clsBeCef

                            pe.IdPagoEnc = IdPagoEnc
                            pe.Franquiciado.IdFranquiciado = F.IdFranquiciado
                            pe.CEF.IdCef = F.IdCEF
                            pe.IsNew = True
                            pe.Anulado = False
                            pe.FechaPago = Now.Date
                            pe.User_agr = gUsuario.IdUsuario
                            pe.User_mod = gUsuario.IdUsuario
                            pe.Fec_agr = Now
                            pe.Fec_mod = Now
                            'pe.NoDeposito = FormatoFechas.fFechaHora(Now)

                            txt.AppendText("Procesando Franquiciado: " & F.CodigoFranquiciado & vbNewLine)

                            'Filtrar la lista de ventas por franquiciado.
                            Dim VentasFranqui = lventas.Where(Function(vf) vf.IdFranquiciado = F.IdFranquiciado)

                            txt.AppendText("Consultando monto disponible en ventas : " & VentasFranqui.Sum(Function(v) v.Monto) & vbNewLine)

                            'If F.CodigoCEF = "AT39" Then MsgBox("Espera")

                            'Filtrar la lista de descuentos por franquiciado y solo los descuentos con fecha menor a la actual
                            Dim DescuentosRefPorFranqui = ldescuentosref.Where _
                                                          (Function(df) df.CodigoFranquiciado = F.CodigoFranquiciado _
                                                            And df.CodigoCEF = F.CodigoCEF _
                                                               And df.FechaCobro <= Now.Date).OrderBy(Function(od) od.FechaCobro)


                            txt.AppendText("Filtrando cuotas pendientes por franquiciado: (" & DescuentosRefPorFranqui.Count & ")" & vbNewLine)

                            'Recorrer el detalle de ventas delfranquiciado filtrado
                            For Each v In VentasFranqui

                                'Saldo Disponible
                                v.Monto = v.Monto - v.Pagado

                                'Total disponible (no varía en el ciclo)
                                'Se utiliza para calcular el saldo de venta
                                v.MontoInicial = v.Monto

                                'El franquiciado no tiene descuentos en el rango seleccioando
                                If DescuentosRefPorFranqui.Count = 0 Then Exit For

                                For Each d In DescuentosRefPorFranqui

                                    'Saldo de la cuota
                                    d.Monto = d.Monto - d.Abonado


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
                                    pd.User_agr = gUsuario.IdUsuario
                                    pd.User_mod = gUsuario.IdUsuario
                                    pd.PagoAutomatico = 1
                                    pd.IdVentaDet = v.IdPeriodoVenta

                                    txt.AppendText("IdPagoEnc: " & IdPagoEnc & " IdPagoDet: " & IdPagoDet & vbNewLine)

                                    'Si el saldo de la venta es mayor que el monto de la cuota de descuento
                                    If v.Monto > d.Monto Then

                                        'Pago detalle se le agrega el monto total de la cuota
                                        pd.MontoAbono = d.Monto

                                        'Se le resta al saldo de la venta el monto abonado a la cuota
                                        v.Monto = v.Monto - d.Monto

                                        'Se actualiza en el detalle de la venta, el monto pagado de ese rango de fechas 
                                        If v.Pagado = 0 Then
                                            v.Pagado = d.Monto
                                        Else
                                            v.Pagado += d.Monto
                                        End If

                                        'En el detalle del descuento, se marca la cuota pagada en su totalidad
                                        d.Pagada = True

                                        'Se registra cuanto se abonó en el detalle de esa cuota
                                        If d.Abonado = 0 Then
                                            d.Abonado = d.Monto
                                        Else
                                            d.Abonado += d.Monto
                                        End If

                                        'Se aumenta en 1 el iddescuentodet
                                        IdPagoDet += 1

                                        pd.DescuentosRef = d

                                        txt.AppendText("No cuota: " & d.NoCuota & " Monto: " & d.Monto & " Pagado: " & pd.MontoAbono & " Saldo: " & (d.Monto - pd.MontoAbono) & vbNewLine)

                                        lpagodet.Add(pd)

                                    ElseIf v.Monto < d.Monto Then 'Si el saldo de la venta es menor que el monto de la cuota de descuento

                                        'Pago detalle se le agrega el saldo disponible de la venta a la cuota
                                        pd.MontoAbono = v.Monto

                                        'Se actualiza en el detalle de la venta, el monto pagado de ese rango de fechas 
                                        If v.Pagado = 0 Then
                                            v.Pagado = d.Monto
                                        Else
                                            v.Pagado += d.Monto
                                        End If

                                        'Se actualiza el saldo de la venta a 0, pues se consumió su totalidad
                                        v.Monto = 0

                                        'En el detalle del descuento, se marca la cuota pagada en su totalidad
                                        d.Pagada = True

                                        'Se registra cuanto se abonó en el detalle de esa cuota
                                        If d.Abonado = 0 Then
                                            d.Abonado = d.Monto
                                        Else
                                            d.Abonado += d.Monto
                                        End If

                                        pd.DescuentosRef = d

                                        txt.AppendText("No cuota: " & d.NoCuota & " Monto: " & d.Monto & " Pagado: " & pd.MontoAbono & " Saldo: " & (d.Monto - pd.MontoAbono) & vbNewLine)

                                        lpagodet.Add(pd)

                                        'Se sale del ciclo, pues ya no hay saldo de ventas para cubrir cuotas de descuentos
                                        Exit For

                                    ElseIf v.Monto = d.Monto Then 'Si el saldo de la venta es iugal que el monto de la cuota de descuento

                                        'Pago detalle se le agrega el saldo disponible de la venta a la cuota
                                        pd.MontoAbono = d.Monto

                                        'Se actualiza en el detalle de la venta, el monto pagado de ese rango de fechas 
                                        If v.Pagado = 0 Then
                                            v.Pagado = d.Monto
                                        Else
                                            v.Pagado += d.Monto
                                        End If

                                        'Se actualiza el saldo de la venta a 0, pues se consumió su totalidad
                                        v.Monto = 0

                                        'En el detalle del descuento, se marca la cuota pagada en su totalidad
                                        d.Pagada = True

                                        'Se registra cuanto se abonó en el detalle de esa cuota
                                        If d.Abonado = 0 Then
                                            d.Abonado = d.Monto
                                        Else
                                            d.Abonado += d.Monto
                                        End If

                                        pd.DescuentosRef = d

                                        txt.AppendText("No cuota: " & d.NoCuota & " Monto: " & d.Monto & " Pagado: " & pd.MontoAbono & " Saldo: " & (d.Monto - pd.MontoAbono) & vbNewLine)

                                        lpagodet.Add(pd)

                                        Exit For

                                    End If

                                Next 'Lista de descuentosref por franquiciado

                                lpagoenc.Add(pe)
                                tventas.Add(v)

                                IdPagoDet = 1

                            Next 'lista de detalle de ventas por franquiciado

                            ContadorPrg += 1
                            IdPagoEnc += 1

                        Next 'lista de franquiciados con ventas

                    End If 'No confirmó mensaje

                    'MsgBox("Terminé", MsgBoxStyle.Information, Me.Text)

                    Dim dpe As New clsLnPago_enc
                    Dim dpd As New clsLnPago_det

                    Dim lConnection As New MySqlConnection(BD.CadenaConexion)
                    Dim ltrans As MySqlTransaction = Nothing

                    Try

                        lConnection.Open()

                        ltrans = lConnection.BeginTransaction

                        prg.Maximum = lpagoenc.Count

                        Dim Contador As Integer = 0

                        For Each P As clsBePago_enc In lpagoenc

                            txt.AppendText("Procesando Pagao #: " & P.IdPagoEnc & " Franquiciado: " & P.IdFranquiciado & vbNewLine)

                            'Insertar el encabezado
                            dpe.Insertar(P, lConnection, ltrans)

                            For Each pDet As clsBePago_det In lpagodet.Where(Function(z) z.IdPagoEnc = P.IdPagoEnc)

                                txt.AppendText("Procesando PagaoEnc #: " & P.IdPagoEnc & " PagoDET: " & pDet.IdPagoDet & vbNewLine)

                                'Insertar el detalle del pago
                                dpd.Insertar(pDet, lConnection, ltrans)

                                'Actualizar el detalle del descuento
                                clsLnDescuento_ref.ActualizarByPago(pDet.DescuentosRef, lConnection, ltrans)

                            Next

                            prg.Value = Contador
                            Contador += 1
                            Application.DoEvents()

                        Next

                        Dim dVentasEnc As New clsLnVentasenc

                        For Each v As clsBeVentasenc In tventas
                            dVentasEnc.Actualizar(v, lConnection, ltrans)
                        Next

                        ltrans.Commit()

                        MsgBox("Se procesaro correctamente " & lpagoenc.Count & " Registros de ventas", MsgBoxStyle.Information, Me.Text)

                    Catch ex As Exception
                        ltrans.Rollback()
                        MsgBox("Error al insertar el detalle de ventas: " & ex.Message)
                    Finally
                        If Not lConnection Is Nothing AndAlso lConnection.State = ConnectionState.Open Then lConnection.Close()
                        ltrans.Dispose()
                    End Try

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