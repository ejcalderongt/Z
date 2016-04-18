Imports MySql.Data.MySqlClient

Public Class frmAplicarPagos

    Public Property lventas As New List(Of clsBeVentasdet)
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

            lventas = New List(Of clsBeVentasdet)

            lventas = clsLnVentasdet.GetByDate(dtpFechaDesdeVentas.Value, dtpFechaHastaVentas.Value)

            If Not lventas Is Nothing Then

                Dim DT As New DataTable("Result")
                DT.Columns.Add("CEF", GetType(String))
                DT.Columns.Add("Franquiciado", GetType(String))                
                'DT.Columns.Add("IdVenta", GetType(Integer))
                DT.Columns.Add("Fecha", GetType(DateTime))
                DT.Columns.Add("Monto", GetType(Decimal))
                DT.Columns.Add("Pagado", GetType(Decimal))
                DT.Columns.Add("Saldo", GetType(Decimal))

                For Each Obj As clsBeVentasdet In lventas

                    Application.DoEvents()

                    Dim Row As DataRow = DT.NewRow

                    Row.Item("CEF") = Obj.CodigoCEF
                    Row.Item("Franquiciado") = Obj.CodigoFranquiciado
                    Row.Item("Fecha") = Obj.Fecha
                    Row.Item("Monto") = Obj.Monto
                    Row.Item("Pagado") = Obj.Pagado
                    Row.Item("Saldo") = Obj.Pagado
                    DT.Rows.Add(Row)

                Next

                dgridVentas.DataSource = DT

                viewVentas.OptionsBehavior.Editable = False

                Application.DoEvents()

                viewVentas.Columns("CEF").GroupIndex = 0

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