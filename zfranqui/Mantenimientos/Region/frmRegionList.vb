Public Class frmRegionList

    Private RegL As New clsLnCefregion
    Public Property Modo As pModo

    Enum pModo
        Lista = 1
        Seleccion = 2
    End Enum

    Private Sub Listar_Regiones()

        Try

            Dgrid.DataSource = RegL.Listar(txtFiltro.Text)
            lblRegs.Caption = String.Format("Registros: {0}", GridView1.RowCount)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmDepartamentoList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Listar_Regiones()
    End Sub

    Private Sub frmDepartamentoList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Regiones()
    End Sub

    Private Sub mnuSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub Nueva_Region()
        Dim Reg As New frmRegion(frmRegion.TipoTrans.Nuevo)
        Reg.ShowDialog()
        Reg.Dispose()
    End Sub

    Private Sub mnuNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuNuevo.ItemClick
        Nueva_Region() : Listar_Regiones()
    End Sub

    Private Sub Dgrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgrid.DoubleClick

        Try

            If GridView1.RowCount > 0 Then

                Dim Dr As DataRowView = GridView1.GetFocusedRow

                If Modo = pModo.Lista Then

                    Dim Reg As New frmRegion(frmRegion.TipoTrans.Editar)
                    Reg.pRegion.IdRegion = Integer.Parse(Dr.Item("Codigo").ToString)
                    Reg.ShowDialog()
                    Reg.Dispose()
                    Listar_Regiones()

                ElseIf Modo = pModo.Seleccion Then
                    Me.Hide()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuActualizar.ItemClick
        Listar_Regiones()
    End Sub

    Private Sub chkActivos_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles chkActivos.CheckedChanged
        Listar_Regiones()
    End Sub

    Private Sub txtFiltro_EditValueChanged(sender As Object, e As EventArgs) Handles txtFiltro.EditValueChanged
        Listar_Regiones()
    End Sub

End Class