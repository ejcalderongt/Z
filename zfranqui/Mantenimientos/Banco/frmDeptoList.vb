Public Class frmBancoList

    Private DeptoL As New clsLnBanco

    Public Property Modo As pModo

    Enum pModo
        Lista = 1
        Seleccion = 2
    End Enum

    Private Sub Listar_Bancos()

        Try

            Dgrid.DataSource = DeptoL.Listar("")
            lblRegs.Caption = String.Format("Registros: {0}", GridView1.RowCount)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmBancoList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Listar_Bancos()
    End Sub

    Private Sub frmBancoList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Bancos()
    End Sub

    Private Sub mnuSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub Nuevo_Depto()
        Dim Depto As New frmBanco(frmBanco.TipoTrans.Nuevo)
        Depto.ShowDialog()
        Depto.Dispose()
    End Sub

    Private Sub mnuNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuNuevo.ItemClick
        Nuevo_Depto() : Listar_Bancos()
    End Sub

    Private Sub Dgrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgrid.DoubleClick

        Try

            If GridView1.RowCount > 0 Then

                Dim Dr As DataRowView = GridView1.GetFocusedRow

                If Modo = pModo.Lista Then

                    Dim Bank As New frmBanco(frmBanco.TipoTrans.Editar)
                    Bank.Banco.IdBanco = Integer.Parse(Dr.Item("Codigo").ToString)
                    Bank.ShowDialog()
                    Bank.Dispose()
                    Listar_Bancos()
                ElseIf Modo = pModo.Seleccion Then
                    Me.Hide()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuActualizar.ItemClick
        Listar_Bancos()
    End Sub

    Private Sub chkActivos_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles chkActivos.CheckedChanged
        Listar_Bancos()
    End Sub

    Private Sub txtFiltro_EditValueChanged(sender As Object, e As EventArgs)
        Listar_Bancos()
    End Sub

End Class