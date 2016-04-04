Public Class frmRolList

    Private RolL As New clsLnRol

    Public Property Modo As pModo

    Enum pModo
        Lista = 1
        Seleccion = 2
    End Enum

    Private Sub Listar_Roles()
        Try
            Dgrid.DataSource = RolL.Listar(chkActivos.Checked, txtFiltro.Text)
            lblRegs.Caption = String.Format("Registros: {0}", GridView1.RowCount)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmUsuList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Listar_Roles()
    End Sub

    Private Sub frmUsuList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Roles()
    End Sub

    Private Sub mnuSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub mnuNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuNuevo.ItemClick
        Dim Rol As New frmRol(frmRol.TipoTrans.Nuevo)
        Rol.ShowDialog()
        Rol.Dispose()
        Listar_Roles()
    End Sub

    Private Sub Dgrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgrid.DoubleClick

        Try
            If GridView1.RowCount > 0 Then

                Dim Dr As DataRowView = GridView1.GetFocusedRow

                If Modo = pModo.Lista Then

                    Dim Rol As New frmRol(frmRol.TipoTrans.Editar)
                    Rol.Rol.IdRol = Integer.Parse(Dr.Item("Codigo").ToString)
                    Rol.ShowDialog()
                    Rol.Dispose()
                    Listar_Roles()

                ElseIf Modo = pModo.Seleccion Then
                    Me.Hide()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuActualizar.ItemClick
        Listar_Roles()
    End Sub

    Private Sub chkActivos_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles chkActivos.CheckedChanged
        Listar_Roles()
    End Sub

    Private Sub txtFiltro_EditValueChanged(sender As Object, e As EventArgs) Handles txtFiltro.EditValueChanged
        Listar_Roles()
    End Sub

    Private Sub Dgrid_Click(sender As Object, e As EventArgs) Handles Dgrid.Click

    End Sub

    Private Sub RibbonControl_Click(sender As Object, e As EventArgs) Handles RibbonControl.Click

    End Sub
End Class