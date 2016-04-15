﻿Public Class frmRepFranquiciadosCEF

    Enum TipoReporte As Integer

        CuotasDetalleDescuento = 1

    End Enum

    Public Sub New()

        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

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


        Dim reportHeader As String = vbNewLine & "Franquiciados por CEF "

        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 10, FontStyle.Bold)

        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 70)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)


    End Sub

    Private Sub Llenar_Grid()


        Try


                   
            Dim lSQL As String = " SELECT CONCAT(cef.Codigo , ' - ', cef.Descripcion ) AS CEF, franquiciado.IdFranquiciado, franquiciado.Codigo, franquiciado.Nombres, franquiciado.Apellidos, franquiciado.DPI, " & _
                 " banco.Nombre AS Banco, franquiciado.NoCuenta, franquiciado.NIT " & _
                 " FROM banco INNER JOIN " & _
                 " franquiciado ON banco.IdBanco = franquiciado.IdBanco INNER JOIN " & _
                 " cef INNER JOIN " & _
                 " franquiciadocef ON cef.IdCef = franquiciadocef.IdCEF " & _
                 " AND franquiciado.IdFranquiciado = franquiciadocef.IdFranquiciado " & _
                 " WHERE 1 > 0 " & _
                 " ORDER BY  cef.Codigo, franquiciado.Nombres "

            GridView1.Columns.Clear()

            Dim DT As New DataTable
            BD.OpenDT(DT, lSQL)
            dgrid.DataSource = DT
            GridView1.OptionsBehavior.Editable = False

            Application.DoEvents()


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