﻿Public Class frmDepartamentoList

    Private DeptoL As New clsLnDepartamento

    Public Property Modo As pModo

    Enum pModo
        Lista = 1
        Seleccion = 2
    End Enum

    Private Sub Listar_Departamentos()

        Try

            Dgrid.DataSource = DeptoL.Listar("")
            lblRegs.Caption = String.Format("Registros: {0}", GridView1.RowCount)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmDepartamentoList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Listar_Departamentos()
    End Sub

    Private Sub frmDepartamentoList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Departamentos()
    End Sub

    Private Sub mnuSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub Nuevo_Depto()
        Dim Depto As New frmDepartamento(frmDepartamento.TipoTrans.Nuevo)
        Depto.ShowDialog()
        Depto.Dispose()
    End Sub

    Private Sub mnuNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuNuevo.ItemClick
        Nuevo_Depto() : Listar_Departamentos()
    End Sub

    Private Sub Dgrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgrid.DoubleClick

        Try

            If GridView1.RowCount > 0 Then

                Dim Dr As DataRowView = GridView1.GetFocusedRow

                If Modo = pModo.Lista Then

                    Dim Depto As New frmDepartamento(frmDepartamento.TipoTrans.Editar)
                    Depto.Depto.IdDepartamento = Integer.Parse(Dr.Item("Codigo").ToString)
                    Depto.ShowDialog()
                    Depto.Dispose()
                    Listar_Departamentos()

                ElseIf Modo = pModo.Seleccion Then
                    Me.Hide()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuActualizar.ItemClick
        Listar_Departamentos()
    End Sub

    Private Sub chkActivos_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles chkActivos.CheckedChanged
        Listar_Departamentos()
    End Sub

    Private Sub txtFiltro_EditValueChanged(sender As Object, e As EventArgs)
        Listar_Departamentos()
    End Sub

End Class