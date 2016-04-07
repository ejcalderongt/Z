﻿Imports DevExpress.XtraEditors

Public Class frmGeneraPago

    Public pObj As clsBeDescuento_det
    'Public pListObjEnc As List(Of clsBePago_enc)
    '
    Public pListObjRef As List(Of clsBeDescuento_ref)
    Public pListObjDet As List(Of clsBePago_det)

    Private Sub CargarCuotas()

        Try

            If pObj IsNot Nothing Then
                Dgrid.DataSource = clsLnDescuento_ref.GetCuotasByBeneficio(pObj)
                GridView1.Columns("IdDescuentoRef").Visible = False
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub frmGeneraPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        CargarCuotas()
    End Sub

    Private Sub Dgrid_DoubleClick(sender As Object, e As EventArgs) Handles Dgrid.DoubleClick

        Try

            If GridView1.RowCount > 0 Then
                Dim Dr As DataRowView = GridView1.GetFocusedRow()
                dtmFechaCobro.Value = Dr.Item("Fecha Cobro")
                dtmFechaPago.Value = Now
                txtCuota.Tag = Dr.Item("IdDescuentoRef")
                txtCuota.Value = Dr.Item("No. Cuota")
                txtMontoCancelar.Value = Dr.Item("Monto")
                txtAbono.Value = Dr.Item("Abonado")
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub Limpiar()

        dtmFechaCobro.Value = Now
        dtmFechaPago.Value = Now
        txtCuota.Tag = Nothing
        txtCuota.Value = 0
        txtMontoCancelar.Value = 0.0
        txtAbono.Value = 0.0

    End Sub

    Private Sub cmdGrabar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdGrabar.ItemClick

        Me.Close()

    End Sub

    Private Sub cmdGuardarPago_Click(sender As Object, e As EventArgs) Handles cmdGuardarPago.Click

        Try

            If txtAbono.Value <= 0 Then
                Throw New Exception("El abono debe ser mayor a 0.")
            ElseIf txtAbono.Value > txtMontoCancelar.Value Then
                Throw New Exception("El abono sobrepasa el monto a cancelar.")
            End If

            If pListObjDet IsNot Nothing Then
                Dim lIndex As Integer = -1
                lIndex = pListObjDet.FindIndex(Function(b) b.IdDescuentoEnc = pObj.IdDescuentoEnc _
                                                   And b.IdDescuentoDet = pObj.IdDescuentoDet _
                                                   And b.IdDescuentoRef = CInt(txtCuota.Tag))
                If lIndex >= 0 Then
                    pListObjDet(lIndex).MontoAbono = txtAbono.Value
                    setAbono(pListObjDet(lIndex).IdDescuentoRef, pListObjDet(lIndex).MontoAbono)
                Else
                    Dim Obj As New clsBePago_det
                    Obj.IdDescuentoEnc = pObj.IdDescuentoEnc
                    Obj.IdDescuentoDet = pObj.IdDescuentoDet
                    Obj.IdDescuentoRef = txtCuota.Tag
                    Obj.IdBeneficio = pObj.Beneficio.IdBeneficio
                    Obj.NoCuota = txtCuota.Value
                    Obj.MontoCuota = txtMontoCancelar.Value
                    Obj.MontoAbono = txtAbono.Value
                    Obj.Fec_agr = Now
                    Obj.User_agr = gUsuario.IdUsuario
                    Obj.Fec_mod = Now
                    Obj.User_mod = gUsuario.IdUsuario
                    Obj.IsNew = True
                    pListObjDet.Add(Obj)
                    setAbono(Obj.IdDescuentoRef, Obj.MontoAbono)

                    Dim ObjR As New clsBeDescuento_ref
                    ObjR.IdDescuentoEnc = Obj.IdDescuentoEnc
                    ObjR.IdDescuentoDet = Obj.IdDescuentoDet
                    ObjR.IdDescuentoRef = Obj.IdDescuentoRef
                    ObjR.Abonado = Obj.MontoAbono

                    If Obj.MontoAbono = Obj.MontoCuota Then
                        ObjR.Pagada = True
                    Else
                        ObjR.Pagada = False
                    End If
                    ObjR.IsNew = False
                    pListObjRef.Add(ObjR)

                End If
            End If

            Limpiar()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub setAbono(ByVal pIdDescuentoRef As Integer, ByVal pAbono As Double)

        Try

            If GridView1.RowCount > 0 Then
                For i As Integer = 0 To GridView1.RowCount - 1
                    Dim row As DataRow = GridView1.GetDataRow(i)
                    If row.Item("IdDescuentoRef") = pIdDescuentoRef Then
                        row.Item("Abonado") = pAbono
                        Exit For
                    End If
                Next
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

End Class