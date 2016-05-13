Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns

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
                    lRow(4) = r(3)

                    Dim lIndex As Integer = -1
                    lIndex = pListObjDet.FindIndex(Function(b) b.IdDescuentoEnc = pObj.IdDescuentoEnc _
                                                       And b.IdDescuentoDet = pObj.IdDescuentoDet _
                                                       And b.IdDescuentoRef = CInt(r(0)))
                    If lIndex > -1 Then
                        lRow(2) = pListObjDet(lIndex).MontoAbono
                        lRow(3) = pListObjDet(lIndex).MontoAbono
                        If CDbl(lRow(4)) = pListObjDet(lIndex).MontoAbono Then
                            lRow(5) = True
                        Else
                            lRow(5) = False
                        End If
                    Else
                        lRow(2) = lAbonado
                        lRow(3) = lAbonado
                        lRow(5) = r(4)
                    End If

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

                'Dim row As Integer = IIf(GridView1.FocusedRowHandle > 0, GridView1.FocusedRowHandle - 1, GridView1.FocusedRowHandle)

                If GridView1.FocusedRowHandle > 0 Then
                    Dim row As Integer
                    If GridView1.FocusedRowHandle > 0 Then
                        row = GridView1.FocusedRowHandle - 1
                    Else
                        row = GridView1.FocusedRowHandle
                    End If
                    If AbonoAnteriorFaltante(row) Then
                        txtAbono.Enabled = False
                        cmdGuardaPago.Enabled = False
                        dtmFechaPago.Enabled = False
                        Limpiar()
                        Throw New Exception("Debe completar el pago de la cuota anterior.")
                    End If
                End If

                dtmFechaCobro.Value = Dr.Item("Fecha Cobro")
                dtmFechaPago.Value = Now
                txtCuota.Tag = Dr.Item("IdDescuentoRef")
                txtCuota.Value = Dr.Item("No. Cuota")
                txtMontoCancelar.Value = Dr.Item("Monto")
                txtAbono.Tag = Dr.Item("setAbonado")

                Dim monto As Double = CDbl(Dr.Item("Monto"))
                Dim abonado As Double = CDbl(Dr.Item("Abonado"))

                Dim dif As Double = monto - abonado

                txtAbono.Value = dif
                txtAbono.Focus()

                Dim red As Double = Math.Round(abonado, 2)

                If monto = red Then
                    txtAbono.Enabled = False
                    cmdGuardaPago.Enabled = False
                    dtmFechaPago.Enabled = False
                    Limpiar()
                    XtraMessageBox.Show("El pago total ya fue realizado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    txtAbono.Enabled = True
                    cmdGuardaPago.Enabled = True
                    dtmFechaPago.Enabled = True
                End If

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

    Private Sub setAbono(ByVal pIdDescuentoRef As Integer, ByVal pAbono As Double, ByVal pPagada As Boolean)

        Try

            If GridView1.RowCount > 0 Then
                For i As Integer = 0 To GridView1.RowCount - 1
                    Dim row As DataRow = GridView1.GetDataRow(i)
                    If row.Item("IdDescuentoRef") = pIdDescuentoRef Then
                        row.Item("Abonado") = pAbono : row.Item("Pagada") = pPagada
                        Exit For
                    End If
                Next
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Function AbonoAnteriorFaltante(ByVal row As Integer) As Boolean

        AbonoAnteriorFaltante = False
        Try
            Dim colabono As GridColumn = GridView1.Columns("Abonado")
            Dim celabono = Convert.ToString(GridView1.GetRowCellValue(row, colabono))

            Dim colmonto As GridColumn = GridView1.Columns("Monto")
            Dim celmonto = Convert.ToString(GridView1.GetRowCellValue(row, colmonto))

            If celabono = "0" Then
                AbonoAnteriorFaltante = True
            Else
                Dim red1 As Double = Math.Round(CDbl(celabono), 2)
                Dim red2 As Double = Math.Round(CDbl(celmonto), 2)
                If red1 < red2 Then
                    AbonoAnteriorFaltante = True
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub txtAbono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAbono.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                cmdGuardaPago_Click(sender, e)
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub cmdGuardaPago_Click(sender As Object, e As EventArgs) Handles cmdGuardaPago.Click

        Cursor = Cursors.WaitCursor

        Try

            If String.IsNullOrEmpty(txtMontoCancelar.Value) Then
                Throw New Exception("Monto a cancelar debe ser mayor a 0.")
            ElseIf txtMontoCancelar.Value <= 0 Then
                Throw New Exception("Monto a cancelar debe ser mayor a 0.")
            ElseIf txtAbono.Value <= 0 Then
                Throw New Exception("El abono debe ser mayor a 0.")
            ElseIf txtAbono.Value > txtMontoCancelar.Value Then
                'Throw New Exception("El abono sobrepasa el monto a cancelar.")
                If XtraMessageBox.Show(String.Format("El abono excede el monto a cancelar en la cuota {0}. ¿Desea repartir lo restante entre los demás pagos?", txtCuota.Value), Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Return
                Else
                    If ExcedeGranTotal(CDbl(txtAbono.Value)) Then
                        Throw New Exception(String.Format("El abono {0} excede el monto total a pagar por todas las cuotas restantes.", txtCuota.Value))
                    End If
                End If
            End If

            If pListObjDet IsNot Nothing Then

                Dim lIndex As Integer = -1

                lIndex = pListObjDet.FindIndex(Function(b) b.IdDescuentoEnc = pObj.IdDescuentoEnc _
                                                   And b.IdDescuentoDet = pObj.IdDescuentoDet _
                                                   And b.IdDescuentoRef = CInt(txtCuota.Tag))

                If lIndex > -1 Then

                    If pListObjDet(lIndex).MontoAbono < CDbl(txtAbono.Tag) Then
                        pListObjDet(lIndex).MontoAbono += txtAbono.Value + txtAbono.Tag
                    Else
                        pListObjDet(lIndex).MontoAbono += txtAbono.Value
                    End If

                    'pListObjDet(lIndex).MontoAbono += txtAbono.Value
                    pListObjRef(lIndex).Abonado = pListObjDet(lIndex).MontoAbono

                    If pListObjRef(lIndex).Abonado = txtMontoCancelar.Value Then
                        pListObjRef(lIndex).Pagada = True
                    ElseIf pListObjRef(lIndex).Abonado > txtMontoCancelar.Value Then
                        Throw New Exception("No puede pagar más del monto total.")
                    Else
                        pListObjRef(lIndex).Pagada = False
                    End If

                    setAbono(pListObjDet(lIndex).IdDescuentoRef, pListObjDet(lIndex).MontoAbono, pListObjRef(lIndex).Pagada)

                Else

                    Dim val As Double = CDbl(txtMontoCancelar.Value) - CDbl(txtAbono.Tag)
                    If txtAbono.Value > txtMontoCancelar.Value Or txtAbono.Value > val Then

                        Dim lAbonadoOriginal As Double = txtAbono.Value

                        For i As Integer = 0 To GridView1.RowCount - 1

                            Dim Obj As New clsBePago_det

                            Dim lIdRef As Integer = Integer.Parse(GridView1.GetRowCellValue(i, "IdDescuentoRef").ToString)
                            Dim lNoCuota As Integer = Integer.Parse(GridView1.GetRowCellValue(i, "No. Cuota").ToString)
                            Dim lAbonado As Double = Double.Parse(GridView1.GetRowCellValue(i, "Abonado").ToString)
                            Dim lMontoSinV As Double = Double.Parse(GridView1.GetRowCellValue(i, "Monto").ToString)
                            Dim lMontoCancelar As Double = Double.Parse(GridView1.GetRowCellValue(i, "Monto").ToString)

                            If lAbonado = lMontoCancelar Then
                                Continue For
                            Else
                                lMontoCancelar -= lAbonado
                            End If

                            Dim ObjR As New clsBeDescuento_ref
                            ObjR = clsLnDescuento_ref.GetSingle(pObj.IdDescuentoEnc, pObj.IdDescuentoDet, lIdRef)

                            If lAbonado = 0 Then
                                If lMontoCancelar <= lAbonadoOriginal Or lAbonadoOriginal = 0 Then
                                    lAbonado = lMontoCancelar
                                    ObjR.Pagada = True
                                Else
                                    lAbonado += lAbonadoOriginal
                                    If lAbonado = lMontoCancelar Then
                                        ObjR.Pagada = True
                                    Else
                                        ObjR.Pagada = False
                                    End If
                                End If
                            Else
                                lAbonado += lMontoCancelar
                                If lAbonado = lMontoSinV Then
                                    ObjR.Pagada = True
                                Else
                                    ObjR.Pagada = False
                                End If
                            End If

                            lAbonadoOriginal -= lMontoCancelar

                            Obj.IdDescuentoEnc = pObj.IdDescuentoEnc
                            Obj.IdDescuentoDet = pObj.IdDescuentoDet
                            Obj.IdDescuentoRef = lIdRef
                            Obj.IdBeneficio = pObj.Beneficio.IdBeneficio
                            Obj.NoCuota = lNoCuota
                            Obj.MontoCuota = lMontoCancelar
                            Obj.MontoAbono = lAbonado
                            Obj.Fec_agr = Now
                            Obj.User_agr = gUsuario.IdUsuario
                            Obj.Fec_mod = Now
                            Obj.User_mod = gUsuario.IdUsuario
                            Obj.IsNew = True
                            pListObjDet.Add(Obj)

                            ObjR.Abonado = Obj.MontoAbono

                            ObjR.IsNew = False
                            pListObjRef.Add(ObjR)
                            setAbono(Obj.IdDescuentoRef, ObjR.Abonado, ObjR.Pagada)

                            If lAbonadoOriginal < 0 Then
                                Limpiar()
                                Exit Sub
                            End If

                        Next

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
                            If ObjR.Abonado = Obj.MontoCuota Then
                                ObjR.Pagada = True
                            Else
                                ObjR.Pagada = False
                            End If

                            ObjR.IsNew = False
                            pListObjRef.Add(ObjR)
                            setAbono(Obj.IdDescuentoRef, ObjR.Abonado, ObjR.Pagada)

                        End If

                    End If

                End If

            End If

            Limpiar()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub

    Private Function ExcedeGranTotal(ByVal pCantidadIngresada As Double) As Boolean

        ExcedeGranTotal = False
        Try

            Dim suma As Double = 0
            For i As Integer = 0 To GridView1.RowCount - 1

                Dim colabono As GridColumn = GridView1.Columns("Abonado")
                Dim celabono As Double = Double.Parse(GridView1.GetRowCellValue(i, colabono).ToString)

                Dim colmonto As GridColumn = GridView1.Columns("Monto")
                Dim celmonto As Double = Double.Parse(GridView1.GetRowCellValue(i, colmonto).ToString)

                Dim dif As Double = celmonto - celabono

                If celabono <> celmonto Then
                    suma += dif
                End If

            Next

            If pCantidadIngresada > suma Then
                ExcedeGranTotal = True
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Function

End Class