﻿Public Class frmRepDescuentoDet

    Enum TipoReporte As Integer

        CuotasDetalleDescuento = 1

    End Enum

    Private Property TipoRep As TipoReporte = -1

    Public Property DescuentoEnc As New clsBeDescuento_enc

    Public Sub New(pTipoReporte As TipoReporte)

        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        TipoRep = pTipoReporte

        ' This line of code is generated by Data Source Configuration Wizard
        'DtDescuentoDetRepGridTableAdapter1.Fill(DsetRep1.dtDescuentoDetRepGrid)

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

    Private Sub Llenar_Grid()


        Try

            Dim lSQL As String = String.Format("SELECT b.Nombre,b.Modelo,b.NoChasis, b.NoPlaca,b.Motor,b.NumeroTelefono, " _
                                                     & " b.EmpresaTelco, tp.EsVehiculo, tp.EsTelefono, tp.EsServicio, r.FechaCobro, r.NoCuota, r.Monto, " _
                                                     & "r.Abonado, r.pagada, tipodescuento.Nombre AS TipoDescuento " _
                                                     & "FROM descuento_ref AS r " _
                                                     & "INNER JOIN descuento_det AS det ON r.IdDescuentoEnc= det.IdDescuentoEnc " _
                                                     & "AND r.IdDescuentoDet = det.IdDescuentoDet " _
                                                     & "INNER JOIN beneficio AS b ON r.IdBeneficio = b.IdBeneficio " _
                                                     & "INNER JOIN TipoBeneficio AS tp ON b.IdTipoBeneficio = tp.IdTipoBeneficio " _
                                                     & "INNER JOIN descuento_enc AS enc ON det.IdDescuentoEnc = enc.IdDescuentoEnc " _
                                                     & "INNER JOIN tipodescuento ON enc.IdTipoDescuento = tipodescuento.IdTipoDescuento " _
                                                     & "WHERE r.IdDescuentoEnc={0}", DescuentoEnc.IdDescuentoEnc)

            Dim DT As New DataTable("Resultante1")
            BD.OpenDT(DT, lSQL)

            If DT.Rows.Count > 0 = False Then
                DT = New DataTable("Resultante2")
                lSQL = String.Format("SELECT b.Nombre,b.Modelo,b.NoChasis, b.NoPlaca,b.Motor,b.NumeroTelefono, " _
                     & "b.EmpresaTelco,tp.EsVehiculo, tp.EsTelefono, tp.EsServicio,det.FechaAPartirDe AS FechaCobro," _
                     & "det.MontoTotal AS Monto,tpd.Nombre AS TipoDescuento " _
                     & "FROM descuento_enc AS enc " _
                     & "INNER JOIN descuento_det AS det ON enc.IdDescuentoEnc = det.IdDescuentoEnc " _
                     & "INNER JOIN beneficio AS b ON det.IdBeneficio = b.IdBeneficio " _
                     & "INNER JOIN TipoBeneficio AS tp ON b.IdTipoBeneficio = tp.IdTipoBeneficio " _
                     & "INNER JOIN tipodescuento AS tpd ON enc.IdTipoDescuento = tpd.IdTipoDescuento " _
                     & "WHERE enc.IdDescuentoEnc={0}", DescuentoEnc.IdDescuentoEnc)
                BD.OpenDT(DT, lSQL)
            End If

            dgrid.DataSource = DT
            GridView1.OptionsBehavior.Editable = False

            Application.DoEvents()

            Select Case TipoRep

                Case TipoReporte.CuotasDetalleDescuento

                    GridView1.OptionsView.ShowFooter = True

                    GridView1.Columns("Nombre").GroupIndex = 1

                    GridView1.Columns("NoCuota").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                    GridView1.Columns("NoCuota").SummaryItem.DisplayFormat = "{0:n2}"

                    GridView1.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    GridView1.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"

                    GridView1.Columns("Abonado").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    GridView1.Columns("Abonado").SummaryItem.DisplayFormat = "{0:n2}"

                    GridView1.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    GridView1.Columns("Monto").DisplayFormat.FormatString = "{0:n2}"

                    GridView1.Columns("Abonado").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    GridView1.Columns("Abonado").DisplayFormat.FormatString = "{0:n2}"

                    GridView1.Columns("FechaCobro").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                    GridView1.Columns("FechaCobro").DisplayFormat.FormatString = "dd/MM/yyyy"

                    GridView1.ExpandAllGroups()

                Case Else


            End Select

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

            Llenar_Grid()

            If IO.File.Exists(CurDir() & "\" & Nom_Rep & ".xml") Then IO.File.Delete(CurDir() & "\" & Nom_Rep & ".xml")

            If IO.File.Exists(CurDir() & "\" & Nom_Rep & ".xml") Then GridView1.RestoreLayoutFromXml(CurDir() & "\" & Nom_Rep & ".xml")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub cmdImprimir_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdImprimir.ItemClick
        Imprimir_Vista()
    End Sub


End Class