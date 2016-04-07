Imports DevExpress.XtraEditors

Public Class frmGeneraPago

    Public pObj As clsBeDescuento_det
    Public pListObjDet As List(Of clsBePago_det)
    Public pListObjRef As List(Of clsBeDescuento_ref)

    Private Sub CargarCuotas()

        Try

            'IdDescuentoRef()
            'No.Cuota()
            'Abonado()
            'Monto()
            'Pagada()
            'FechaCobro()

            If pObj IsNot Nothing Then
                Dim DTT As New DataTable("Result")
                DTT.Columns.Add("IdDescuentoRef", GetType(Integer))
                DTT.Columns.Add("No. Cuota", GetType(Integer))
                DTT.Columns.Add("Abonado", GetType(Double))
                DTT.Columns.Add("setAbonado", GetType(Double))
                DTT.Columns.Add("Monto", GetType(Double))
                DTT.Columns.Add("Pagada", GetType(Boolean))
                DTT.Columns.Add("Fecha Cobro", GetType(DateTime))
                'DTT.Columns.Add("IsNew", GetType(Boolean))
                Dim DT As DataTable = clsLnDescuento_ref.GetCuotasByBeneficio(pObj)
                For Each r As DataRow In DT.Rows
                    Dim lRow As DataRow = DTT.NewRow
                    Dim lAbonado As Double = CDbl(r(2))
                    lRow(0) = r(0)
                    lRow(1) = r(1)
                    lRow(2) = lAbonado
                    lRow(3) = lAbonado
                    lRow(4) = r(3)
                    lRow(5) = r(4)
                    lRow(6) = r(5)
                    'If lAbonado > 0 Then
                    '    lRow(7) = True
                    'Else
                    '    lRow(7) = False
                    'End If
                    DTT.Rows.Add(lRow)
                Next

                Dgrid.DataSource = DTT
                If GridView1.RowCount > 0 Then
                    GridView1.Columns("IdDescuentoRef").Visible = False
                    GridView1.Columns("setAbonado").Visible = False
                End If
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
                txtAbono.Tag = Dr.Item("setAbonado")
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
        txtAbono.Tag = Nothing
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
                    pListObjDet(lIndex).MontoAbono = txtAbono.Value + txtAbono.Tag
                    pListObjRef(lIndex).Abonado = pListObjDet(lIndex).MontoAbono
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

                    Dim ObjR As New clsBeDescuento_ref
                    ObjR = clsLnDescuento_ref.GetSingle(Obj.IdDescuentoEnc, Obj.IdDescuentoDet, Obj.IdDescuentoRef)
                    If ObjR IsNot Nothing Then
                        ObjR.Abonado += Obj.MontoAbono
                    End If

                    If ObjR.Abonado = Obj.MontoCuota Then
                        ObjR.Pagada = True
                    Else
                        ObjR.Pagada = False
                    End If
                    ObjR.IsNew = False
                    pListObjRef.Add(ObjR)
                    setAbono(Obj.IdDescuentoRef, ObjR.Abonado)

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