Public Class frmDescuentoList

    Private DtoL As New clsLnDescuento_enc

    Public Property Modo As pModo

    Public Enum pTipoDescuento
        Definido = 1
        Indefinido = 2
        Unico = 3
    End Enum

    Public Property TipoDescuento As pTipoDescuento

    Enum pModo
        Lista = 1
        Seleccion = 2
    End Enum

    Private Sub Listar_Descuentos()

        Try

            Dgrid.DataSource = DtoL.Listar("", TipoDescuento)
            lblRegs.Caption = String.Format("Registros: {0}", GridView1.RowCount)

            If GridView1.RowCount > 0 Then
                GridView1.Columns("IdFranquiciado").Visible = False
                GridView1.Columns("IdCef").Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try

    End Sub

    Private Sub frmDescuentoList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Listar_Descuentos()
    End Sub

    Private Sub frmDescuentoList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Descuentos()
        Me.Text = "Listado de descuentos período " & TipoDescuento.ToString
        If TipoDescuento = pTipoDescuento.indefinido Then
            cmdGeneraDescuento.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            cmdGeneraDescuento.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
    End Sub

    Private Sub mnuSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub Nuevo_Dto()
        Dim Dto As New frmDescuento(frmDescuento.TipoTrans.Nuevo)
        Dto.TipoDescuento = TipoDescuento
        Dto.pObjEnc.IsNew = True
        Dto.ShowDialog()
        Dto.Dispose()
    End Sub

    Private Sub mnuNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuNuevo.ItemClick
        Nuevo_Dto() : Listar_Descuentos()
    End Sub

    Private Sub mnuActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuActualizar.ItemClick
        Listar_Descuentos()
    End Sub

    Private Sub chkActivos_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles chkActivos.CheckedChanged
        Listar_Descuentos()
    End Sub

    Private Sub txtFiltro_EditValueChanged(sender As Object, e As EventArgs)
        Listar_Descuentos()
    End Sub

    Private Sub Dgrid_DoubleClick(sender As Object, e As EventArgs) Handles Dgrid.DoubleClick
        Try

            If GridView1.RowCount > 0 Then

                Dim Dr As DataRowView = GridView1.GetFocusedRow

                If Modo = pModo.Lista Then

                    Dim Dto As New frmDescuento(frmDescuento.TipoTrans.Editar)
                    Dto.pObjEnc.IdDescuentoEnc = Integer.Parse(Dr.Item("CodigoDTO").ToString)
                    Dto.pObjEnc.Franquiciado.IdFranquiciado = CInt(Dr.Item("IdFranquiciado"))
                    Dto.pObjEnc.CEF.IdCef = CInt(Dr.Item("IdCef"))

                    If TipoDescuento = pTipoDescuento.definido Then
                        Dto.pObjEnc.IdTipoDescuento = pTipoDescuento.definido
                    ElseIf TipoDescuento = pTipoDescuento.indefinido Then
                        Dto.pObjEnc.IdTipoDescuento = pTipoDescuento.indefinido
                    ElseIf TipoDescuento = pTipoDescuento.unico Then
                        Dto.pObjEnc.IdTipoDescuento = pTipoDescuento.unico
                    End If

                    Dto.pObjEnc.IsNew = False
                    Dto.TipoDescuento = TipoDescuento
                    Dto.ShowDialog()
                    Dto.Dispose()
                    Listar_Descuentos()

                ElseIf Modo = pModo.Seleccion Then
                    Me.Hide()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub

    Private Sub cmdGeneraDescuento_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdGeneraDescuento.ItemClick

        GeneraDescuento()

    End Sub

    Private Sub GeneraDescuento()

        Try

            Dim frmGen As New frmDescuentosAuto
            frmGen.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try

    End Sub

End Class