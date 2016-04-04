Public Class frmPagoList

    Private DtoL As New clsLnPago_enc

    Public Property Modo As pModo

    Enum pTipoPago
        definido = 1
        indefinido = 2
        unico = 3
    End Enum
    Public Property TipoPago As pTipoPago

    Enum pModo
        Lista = 1
        Seleccion = 2
    End Enum

    Private Sub Listar_Pagos()

        Try

            Dgrid.DataSource = DtoL.Listar(txtFiltro.Text, dtpDesde.Value, dtpHasta.Value)

            lblRegs.Caption = String.Format("Registros: {0}", GridView1.RowCount)

            GridView1.OptionsView.ShowFooter = True

            Try

                GridView1.Columns(0).GroupIndex = 1
                GridView1.Columns(1).GroupIndex = 2

                'CantCuotas
                GridView1.Columns(4).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                GridView1.Columns(4).SummaryItem.DisplayFormat = "{0:n2}"

                'MontoCuota
                GridView1.Columns(5).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                GridView1.Columns(5).SummaryItem.DisplayFormat = "{0:n2}"

                'MontoAbono
                GridView1.Columns(6).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                GridView1.Columns(6).SummaryItem.DisplayFormat = "{0:n2}"

            Catch ex As Exception

            End Try
            


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try

    End Sub

    Private Sub frmPagoList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Listar_Pagos()
    End Sub

    Private Sub frmPagoList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Pagos()
        Me.Text = "Listado de Pagos período " & TipoPago.ToString
    End Sub

    Private Sub mnuSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub Nuevo_Dto()
        Dim Dto As New frmPago(frmPago.TipoTrans.Nuevo)
        Dto.TipoPago = TipoPago
        Dto.ShowDialog()
        Dto.Dispose()
    End Sub

    Private Sub mnuNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuNuevo.ItemClick
        Nuevo_Dto() : Listar_Pagos()
    End Sub

    Private Sub Dgrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgrid.DoubleClick

        Try

            If GridView1.RowCount > 0 Then

                Dim Dr As DataRowView = GridView1.GetFocusedRow

                If Modo = pModo.Lista Then

                    Dim Dto As New frmPago(frmPago.TipoTrans.Editar)
                    Dto.pObjBeEnc.IdPagoEnc = Integer.Parse(Dr.Item("CodigoDTO").ToString)
                    Dto.ShowDialog()
                    Dto.Dispose()
                    Listar_Pagos()

                ElseIf Modo = pModo.Seleccion Then
                    Me.Hide()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuActualizar.ItemClick
        Listar_Pagos()
    End Sub

    Private Sub chkActivos_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles chkActivos.CheckedChanged
        Listar_Pagos()
    End Sub

    Private Sub txtFiltro_EditValueChanged(sender As Object, e As EventArgs) Handles txtFiltro.EditValueChanged
        Listar_Pagos()
    End Sub

    Private Sub Dgrid_Click(sender As Object, e As EventArgs) Handles Dgrid.Click

    End Sub
End Class