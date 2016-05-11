Public Class frmSupervisorList

    Private SupL As New clsLnCefsupervisor
    Public Property Modo As pModo

    Enum pModo
        Lista = 1
        Seleccion = 2
    End Enum

    Private Sub Listar_Supervisor()

        Try

            Dgrid.DataSource = SupL.Listar("")

            If GridView1.Columns.Count > 0 Then
                GridView1.Columns("Id").Visible = False
            End If

            lblRegs.Caption = String.Format("Registros: {0}", GridView1.RowCount)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmSupervisorList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Listar_Supervisor()
    End Sub

    Private Sub frmSupervisorList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Supervisor()
    End Sub

    Private Sub mnuSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub Nuevo_Sup()
        Dim Sup As New frmSupervisor(frmSupervisor.TipoTrans.Nuevo)
        Sup.ShowDialog()
        Sup.Dispose()
    End Sub

    Private Sub mnuNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuNuevo.ItemClick
        Nuevo_Sup() : Listar_Supervisor()
    End Sub

    Private Sub Dgrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgrid.DoubleClick

        Try

            If GridView1.RowCount > 0 Then

                Dim Dr As DataRowView = GridView1.GetFocusedRow

                If Modo = pModo.Lista Then

                    Dim Sup As New frmSupervisor(frmSupervisor.TipoTrans.Editar)
                    Sup.Sup.IdSupervisor = Integer.Parse(Dr.Item("Id").ToString)
                    Sup.ShowDialog()
                    Sup.Dispose()
                    Listar_Supervisor()

                ElseIf Modo = pModo.Seleccion Then
                    Me.Hide()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuActualizar.ItemClick
        Listar_Supervisor()
    End Sub

    Private Sub chkActivos_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles chkActivos.CheckedChanged
        Listar_Supervisor()
    End Sub

    Private Sub txtFiltro_EditValueChanged(sender As Object, e As EventArgs)
        Listar_Supervisor()
    End Sub

End Class