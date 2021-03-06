﻿Public Class frmFranquiciadoList

    Private FranquiL As New clsLnFranquiciado
    Public Franqui As New clsBeFranquiciado

    Public Property Modo As pModo

    Enum pModo
        Lista = 1
        Seleccion = 2
    End Enum

    Private Sub Listar_Franquiciados()

        Try

            Dgrid.DataSource = FranquiL.Listar("", Modo)

            lblReg.Caption = String.Format("Registros: {0}", GridView1.RowCount)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmFranquiciadoList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Listar_Franquiciados()
    End Sub

    Private Sub frmFranquiciadoList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Franquiciados()
    End Sub

    Private Sub Nuevo_Franqui()
        Dim Franqui As New frmFranquiciado(frmFranquiciado.TipoTrans.Nuevo)
        Franqui.ShowDialog()
        Franqui.Dispose()
    End Sub

    Private Sub Dgrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgrid.DoubleClick

        Try

            If GridView1.RowCount > 0 Then

                Dim Dr As DataRowView = GridView1.GetFocusedRow
                Dim dFranqui As New clsLnFranquiciado

                Franqui.IdFranquiciado = Integer.Parse(Dr.Item("IdFranquiciado").ToString)

                If dFranqui.Obtener(Franqui) Then

                    If Modo = pModo.Lista Then

                        Dim frmFranqui As New frmFranquiciado(frmFranquiciado.TipoTrans.Editar)
                        frmFranqui.Franqui.IdFranquiciado = Integer.Parse(Dr.Item("IdFranquiciado").ToString)
                        frmFranqui.Franqui = Franqui
                        frmFranqui.ShowDialog()
                        frmFranqui.Dispose()
                        Listar_Franquiciados()

                    ElseIf Modo = pModo.Seleccion Then
                        Me.Hide()
                    End If


                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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

        Dim reportHeader As String = vbNewLine & "Listado de Franquiciados"

        e.Graph.StringFormat = New DevExpress.XtraPrinting.BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 12, FontStyle.Bold)

        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 70)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)

    End Sub

    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs)

        UseWaitCursor = True

        Try

            If e.KeyCode = Keys.Enter Then
                Listar_Franquiciados()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            UseWaitCursor = False
        End Try

    End Sub


    Private Sub mnuNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuNuevo.ItemClick
        Nuevo_Franqui()
    End Sub

    Private Sub mnuSvyuslixst_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSvyuslixst.ItemClick
        Listar_Franquiciados()
    End Sub

    Private Sub mnuSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub mnuImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuImprimir.ItemClick
        Imprimir_Vista()
    End Sub

    Private Sub txtFiltro_EditValueChanged(sender As Object, e As EventArgs)

    End Sub
End Class