Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Public Class frmPago


    Public pObjBeEnc As New clsBePago_enc
    Private ObjLnF As New clsLnFranquiciado
    Private ObjLnC As New clsLnCef
    Private ListObjRef As New List(Of clsBeDescuento_ref)
    Private ListObjPago As List(Of clsBePago_det)

    Public Enum TipoTrans
        Nuevo = 1
        Editar = 2
    End Enum
    Enum pTipoPago
        Definido = 1
        Indefinido = 2
        Unico = 3
    End Enum
    Public Property TipoPago As pTipoPago

    Private Property Modo As TipoTrans

    Sub New(ByVal pModo As TipoTrans)

        InitializeComponent()
        Modo = pModo

    End Sub

    Private Sub frmPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            ListObjPago = New List(Of clsBePago_det)

            Select Case Modo

                Case TipoTrans.Nuevo

                    'Me.lblCodigo.Text = "-"

                    User_agrTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_agrDateEdit.Text = Now.ToShortDateString

                    User_modTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_modDateEdit.Text = Now.ToShortDateString

                    mnuGuardar.Enabled = True
                    mnuActualizar.Enabled = False
                    mnuEliminar.Enabled = False
                    cmdImprimir1.Enabled = False
                    pObjBeEnc.IsNew = True

                Case TipoTrans.Editar

                    pObjBeEnc.IsNew = False

                    CargarDatos()

                    mnuGuardar.Enabled = False
                    mnuActualizar.Enabled = True
                    mnuEliminar.Enabled = True
                    cmdImprimir1.Enabled = True

            End Select

            txtCodigoFranquiciado.Focus()

            Application.DoEvents()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try

    End Sub

    Private Sub mnuGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuGuardar.ItemClick
        If Datos_Correctos() Then
            If MessageBox.Show("¿Guardar Pago?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If GuardarDatos() Then
                    MsgBox("Se guardó el registro", MsgBoxStyle.Information, Me.Text)
                    If MessageBox.Show("¿Desea Imprimir el Reporte?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        ImprimirReporte()
                    End If
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Function GuardarDatos() As Boolean

        GuardarDatos = False

        Dim lConnection As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)
        Dim lTransaction As MySql.Data.MySqlClient.MySqlTransaction = Nothing

        Dim ObjLNenc As New clsLnPago_enc
        Dim ObjLNDet As New clsLnPago_det

        Try

            lConnection.Open()
            lTransaction = lConnection.BeginTransaction()

            pObjBeEnc = New clsBePago_enc
            pObjBeEnc.IdPagoEnc = clsLnPago_enc.Generar_Nuevo_IdPago()

            pObjBeEnc.CEF.IdCef = txtCodCEF.Tag
            pObjBeEnc.Franquiciado.IdFranquiciado = txtCodigoFranquiciado.Tag
            pObjBeEnc.User_agr = gUsuario.IdUsuario
            pObjBeEnc.Fec_agr = Now
            pObjBeEnc.User_mod = gUsuario.IdUsuario
            pObjBeEnc.Fec_mod = Now

            ObjLNenc.Insertar(pObjBeEnc, lConnection, lTransaction)

            Dim lMaxDet As Integer = clsLnPago_det.MaxID(pObjBeEnc.IdPagoEnc)

            For Each Obj As clsBePago_det In ListObjPago

                lMaxDet += 1
                Obj.IdPagoEnc = pObjBeEnc.IdPagoEnc
                Obj.IdPagoDet = lMaxDet
                Obj.User_agr = gUsuario.IdUsuario
                Obj.User_mod = gUsuario.IdUsuario
                ObjLNDet.Insertar(Obj, lConnection, lTransaction)

            Next

            For Each Obj As clsBeDescuento_ref In ListObjRef
                If Obj.IsNew = False Then
                    clsLnDescuento_ref.ActualizarByPago(Obj, lConnection, lTransaction)
                End If
            Next

            lTransaction.Commit()

            GuardarDatos = True
            'lblCodigo.Text = pObjBeEnc.IdPagoEnc

        Catch ex As Exception
            lTransaction.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        Finally
            lConnection.Close()
        End Try

    End Function

    Private Sub mnuActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuActualizar.ItemClick
        If GuardarDatos() Then
            MsgBox("Se actualizó el registro", MsgBoxStyle.Information, Me.Text)
            Me.Close()
        End If
    End Sub

    Private Function Datos_Correctos() As Boolean

        Datos_Correctos = False

        Try

            If String.IsNullOrEmpty(txtCodigoFranquiciado.Text) Then
                MsgBox("Seleccione Persona.", MsgBoxStyle.Exclamation, Me.Text)
                txtCodCEF.Focus()
            Else
                Datos_Correctos = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try

    End Function

    Private Sub mnuEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuEliminar.ItemClick

        If CBool(MsgBox("¿Eliminar el Pago?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes) Then
            Dim ObjLNenc As New clsLnPago_enc
            If ObjLNenc.Eliminar(pObjBeEnc) > 0 Then
                MsgBox("Se ha eliminado el registro", MsgBoxStyle.Information, Me.Text)
                Me.Close()
            End If
        End If

    End Sub

    Private Sub lnkFranquiciado_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkFranquiciado.LinkClicked

        Try

            Dim FraList As New frmFranquiciadoList
            FraList.Modo = frmFranquiciadoList.pModo.Seleccion
            FraList.StartPosition = FormStartPosition.CenterScreen
            FraList.ShowDialog()

            If Not FraList.Franqui.Codigo = 0 Then

                pObjBeEnc.Franquiciado = FraList.Franqui
                txtCodigoFranquiciado.Tag = FraList.Franqui.IdFranquiciado
                txtCodigoFranquiciado.Text = FraList.Franqui.Codigo
                txtCodigoFranquiciado_LostFocus(Nothing, Nothing)
                txtNombres.Text = FraList.Franqui.Nombres
                txtApellidos.Text = FraList.Franqui.Apellidos
                txtCodCEF.Tag = FraList.Franqui.CEF.IdCef
                txtCodCEF.Text = FraList.Franqui.CEF.Codigo
                txtNomCEF.Text = FraList.Franqui.CEF.Descripcion

                CargaResumenDescuento()
                CargaCuotas()

            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub CargaResumenDescuento()

        Try

            If pObjBeEnc.CEF.IdCef <> 0 Then
                GridDescuento.DataSource = clsLnDescuento_enc.GetAllByCefFranquiciadoResumen(pObjBeEnc.CEF.IdCef, pObjBeEnc.Franquiciado.IdFranquiciado)
            ElseIf String.IsNullOrEmpty(txtCodCEF.Tag) = False AndAlso IsNumeric(txtCodCEF.Tag) AndAlso txtCodCEF.Tag <> 0 Then
                GridDescuento.DataSource = clsLnDescuento_enc.GetAllByCefFranquiciadoResumen(CInt(txtCodCEF.Tag), pObjBeEnc.Franquiciado.IdFranquiciado)
            End If

            If GridViewDescuento.RowCount > 0 Then
                GridViewDescuento.Columns("IdDescuentoEnc").Visible = False
                GridViewDescuento.Columns("IdDescuentoDet").Visible = False
                GridViewDescuento.Columns("IdBeneficio").Visible = False
                GridViewDescuento.Columns("IdTipoDescuento").Visible = False

                GridViewDescuento.Columns("Periodo").GroupIndex = 3

                GridViewDescuento.OptionsView.ShowFooter = True

                GridViewDescuento.Columns("Cuotas").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                GridViewDescuento.Columns("Cuotas").SummaryItem.DisplayFormat = "{0:n2}"

                GridViewDescuento.Columns("Monto Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                GridViewDescuento.Columns("Monto Total").SummaryItem.DisplayFormat = "{0:n2}"
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargaCuotas()

        Try

            If pObjBeEnc.CEF.IdCef <> 0 Then
                GridCuota.DataSource = clsLnDescuento_enc.GetAllByCefFranquiciadoCuota(pObjBeEnc.CEF.IdCef, pObjBeEnc.Franquiciado.IdFranquiciado)
            ElseIf String.IsNullOrEmpty(txtCodCEF.Tag) = False AndAlso IsNumeric(txtCodCEF.Tag) AndAlso txtCodCEF.Tag <> 0 Then
                GridCuota.DataSource = clsLnDescuento_enc.GetAllByCefFranquiciadoCuota(CInt(txtCodCEF.Tag), pObjBeEnc.Franquiciado.IdFranquiciado)
            End If

            If GridViewCuota.RowCount > 0 Then

                GridViewCuota.Columns("IdDescuentoEnc").Visible = False
                GridViewCuota.Columns("IdDescuentoDet").Visible = False
                GridViewCuota.Columns("IdDescuentoRef").Visible = False
                GridViewCuota.Columns("IdBeneficio").Visible = False
                GridViewCuota.OptionsView.ShowFooter = True

                GridViewCuota.Columns("No. Cuota").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                GridViewCuota.Columns("No. Cuota").SummaryItem.DisplayFormat = "{0:n2}"

                GridViewCuota.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                GridViewCuota.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"

                GridViewCuota.Columns("Abonado").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                GridViewCuota.Columns("Abonado").SummaryItem.DisplayFormat = "{0:n2}"

                GridViewCuota.Columns("Monto Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                GridViewCuota.Columns("Monto Total").SummaryItem.DisplayFormat = "{0:n2}"

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub txtCodigoFranquiciado_EditValueChanged(sender As Object, e As EventArgs) Handles txtCodigoFranquiciado.EditValueChanged
        txtNombres.Text = ""
        txtApellidos.Text = ""
    End Sub

    Private Sub txtCodigoFranquiciado_LostFocus(sender As Object, e As EventArgs) Handles txtCodigoFranquiciado.LostFocus

        Try

            If Val(txtCodigoFranquiciado.Text) > 0 Then

                pObjBeEnc.Franquiciado.Codigo = txtCodigoFranquiciado.Text

                If ObjLnF.Obtener(pObjBeEnc.Franquiciado, False) Then

                    pObjBeEnc.Franquiciado = pObjBeEnc.Franquiciado
                    txtCodigoFranquiciado.Tag = pObjBeEnc.Franquiciado.IdFranquiciado
                    txtCodigoFranquiciado.Text = pObjBeEnc.Franquiciado.Codigo
                    txtNombres.Text = pObjBeEnc.Franquiciado.Nombres
                    txtApellidos.Text = pObjBeEnc.Franquiciado.Apellidos
                    txtCodCEF.Tag = pObjBeEnc.Franquiciado.CEF.IdCef
                    txtCodCEF.Text = pObjBeEnc.Franquiciado.CEF.Codigo
                    txtNomCEF.Text = pObjBeEnc.Franquiciado.CEF.Descripcion

                    CargaResumenDescuento()
                    CargaCuotas()

                Else
                    'MsgBox("El código ingresado de franquiciado no es válido", MsgBoxStyle.Exclamation, Me.Text)
                    XtraMessageBox.Show("El código ingresado de franquiciado no es válido", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub


    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click

        If pObjBeEnc.IsNew = False Then Exit Sub

        Try

            If String.IsNullOrEmpty(txtCodigoFranquiciado.Text) Then
                MsgBox("Seleccione Persona.", MsgBoxStyle.Information, Me.Text)
            Else

                If GridViewDescuento.RowCount > 0 Then
                    Dim Dr As DataRowView = GridViewDescuento.GetFocusedRow
                    Dim Obj As New clsBeDescuento_det
                    Obj.IdDescuentoEnc = CInt(Dr.Item("IdDescuentoEnc"))
                    Obj.IdDescuentoDet = CInt(Dr.Item("IdDescuentoDet"))
                    Obj.Beneficio.IdBeneficio = CInt(Dr.Item("IdBeneficio"))

                    Dim lBeneficio As String = String.Format("{0} {1} {2} {3} {4} {5}", Dr.Item("Nombre"), _
                                                             Dr.Item("Modelo"), Dr.Item("No. Placa"), _
                                                             Dr.Item("No. Chasis"), Dr.Item("No. Telefono"), Dr.Item("Empresa")).ToString.Trim()

                    Dim lTipoPeriodo As String = Dr.Item("Periodo").ToString.Trim
                    Dim lIdTipoDescuento As Integer = CInt(Dr.Item("IdTipoDescuento"))

                    Dim Pago As New frmGeneraPago
                    'Pago.pListObjDet = clsLnPago_det.GetAllByPagoEnc(Obj.IdDescuentoEnc, Obj.IdDescuentoDet)
                    If lIdTipoDescuento = 3 Then
                        Pago.lblCuota.Visible = False
                        Pago.txtCuota.Visible = False
                        Pago.Text = "Pago´Único"
                    ElseIf lIdTipoDescuento = 2 Then
                        Pago.Text = "Pago Indefinido"
                        Pago.lblCuota.Visible = True
                        Pago.txtCuota.Visible = True
                    ElseIf lIdTipoDescuento = 1 Then
                        Pago.Text = "Pago Definido"
                        Pago.lblCuota.Visible = True
                        Pago.txtCuota.Visible = True
                    End If
                    Pago.pObj = Obj
                    Pago.pListObjDet = ListObjPago
                    Pago.pListObjRef = ListObjRef
                    Pago.lblInformacionBeneficio.Text = lBeneficio
                    Pago.lblTipoPeriodo.Text = lTipoPeriodo
                    'Pago.Cargar = New frmGeneraPago.Operar(AddressOf CargaResumenDescuento)
                    Pago.ShowDialog()
                    Pago.Dispose()
                End If

            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub CargarDatos()

        Try

            If pObjBeEnc.IdPagoEnc = Nothing Then pObjBeEnc.IdPagoEnc = 0
            pObjBeEnc = clsLnPago_enc.GetSingle(pObjBeEnc.CEF.IdCef, pObjBeEnc.Franquiciado.IdFranquiciado, pObjBeEnc.IdPagoEnc)

            'ObjLNenc.Obtener(pObjBeEnc)

            'Me.lblCodigo.Text = pObjBeEnc.IdPagoEnc

            'Bitácora
            Dim UserBitacora As New clsBeUsuario
            UserBitacora.IdUsuario = pObjBeEnc.User_agr
            gdUsuario.Obtener(UserBitacora)

            'Usuario agregó
            User_agrTextEdit.Text = UserBitacora.Codigo
            Fec_agrDateEdit.Text = pObjBeEnc.Fec_agr.ToShortDateString

            'Usuario modificó
            UserBitacora.IdUsuario = pObjBeEnc.User_mod
            gdUsuario.Obtener(UserBitacora)

            User_modTextEdit.Text = UserBitacora.Codigo
            Fec_modDateEdit.Text = pObjBeEnc.Fec_mod.ToShortDateString
            'Fin Bitácora

            ''''''-----------

            Dim ObjF As New clsBeFranquiciado
            ObjF.IdFranquiciado = pObjBeEnc.Franquiciado.IdFranquiciado
            ObjLnF.Obtener(ObjF)

            txtCodigoFranquiciado.Text = ObjF.Codigo
            txtNombres.Text = ObjF.Nombres
            txtApellidos.Text = ObjF.Apellidos

            Dim ObjC As New clsBeCef
            ObjC.IdCef = pObjBeEnc.CEF.IdCef
            ObjLnC.Obtener(ObjC)

            txtCodCEF.Text = ObjC.Codigo
            txtNomCEF.Text = ObjC.Descripcion

            ListObjPago = clsLnPago_det.GetAllByPagoEnc(pObjBeEnc.IdPagoEnc)

            CargaResumenDescuento()
            CargaCuotas()
            CargarPagosRealizados()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargarPagosRealizados()

        Try

            Dim DT As New DataTable("Result")
            DT.Columns.Add("Beneficio", GetType(String))
            DT.Columns.Add("No. Cuota", GetType(Integer))
            DT.Columns.Add("Monto Cuota", GetType(Double))
            DT.Columns.Add("Monto Abonado", GetType(Double))

            For Each Obj As clsBePago_det In ListObjPago
                DT.Rows.Add(Obj.Beneficio.Nombre, Obj.NoCuota, Obj.MontoCuota, Obj.MontoAbono)
            Next

            GridPago.DataSource = DT

            If GridViewPago.RowCount > 0 Then
                GridViewPago.Columns("No. Cuota").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                GridViewPago.Columns("No. Cuota").SummaryItem.DisplayFormat = "{0:n2}"

                GridViewPago.Columns("Monto Cuota").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                GridViewPago.Columns("Monto Cuota").SummaryItem.DisplayFormat = "{0:n2}"

                GridViewPago.Columns("Monto Abonado").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                GridViewPago.Columns("Monto Abonado").SummaryItem.DisplayFormat = "{0:n2}"
            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'Private Sub CargarDetalle()

    '    Try

    '        Dim ObjLnB As New clsLnBeneficio
    '        Dim ObjLnTP As New clsLnTipobeneficio

    '        Dim DT As New DataTable("Result")
    '        DT.Columns.Add("IdPagoDet", GetType(Integer))
    '        DT.Columns.Add("IdBeneficio", GetType(Integer))
    '        DT.Columns.Add("Beneficio", GetType(String))
    '        DT.Columns.Add("Modelo", GetType(String))
    '        DT.Columns.Add("Chasis", GetType(String))
    '        DT.Columns.Add("Placa", GetType(String))
    '        DT.Columns.Add("No Teléfono", GetType(String))
    '        DT.Columns.Add("Empresa", GetType(String))
    '        DT.Columns.Add("Período (Días)", GetType(String))
    '        DT.Columns.Add("Total", GetType(Decimal))
    '        DT.Columns.Add("Cuotas", GetType(Integer))
    '        DT.Columns.Add("Estado", GetType(String))

    '        If ListObjDD IsNot Nothing AndAlso ListObjDD.Count > 0 Then

    '            Application.DoEvents()

    '            For Each Obj As clsBePago_det In ListObjDD

    '                Dim ObjB As New clsBeBeneficio
    '                ObjB.IdBeneficio = Obj.IdBeneficio
    '                ObjLnB.Obtener(ObjB)

    '                Dim ObjTP As New clsBeTipobeneficio
    '                ObjTP.IdTipoBeneficio = ObjB.TipoBeneficio.IdTipoBeneficio
    '                ObjLnTP.Obtener(ObjTP)

    '                DT.Rows.Add(Obj.IdPagoDet, ObjB.IdBeneficio, ObjB.TipoBeneficio.Nombre, ObjB.Modelo, _
    '                            ObjB.NoChasis, ObjB.NoPlaca, ObjB.NumeroTelefono, _
    '                            ObjB.EmpresaTelco, "", _
    '                            "Obj.MontoTotal", "Obj.Cuotas")

    '            Next

    '        End If

    '        Dgrid.DataSource = DT
    '        GridViewPago.Columns("IdPagoDet").Visible = False
    '        GridViewPago.Columns("IdBeneficio").Visible = False
    '        GridViewPago.Columns("Estado").Visible = False

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub

    'Private Sub Dgrid_DoubleClick(sender As Object, e As EventArgs) Handles Dgrid.DoubleClick

    '    Try

    '        If GridViewPago.RowCount > 0 Then

    '            Dim Dr As DataRowView = GridViewPago.GetFocusedRow
    '            Dim lIndex As Integer = ListObjDD.FindIndex(Function(b) b.IdBeneficio = CInt(Dr.Item("IdBeneficio")))

    '            Dim Periodo As New frmPeriodo
    '            Periodo.ShowDialog()

    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
    '    End Try

    'End Sub
    'Private Sub CargarCuota()

    '    Try

    '        ListObjDR = clsLnDescuento_ref.GetAllByEncabezado(pObjBDesceEnc.IdDescuentoEnc)

    '        If ListObjDR IsNot Nothing AndAlso ListObjDR.Count > 0 Then

    '            Dim DT As New DataTable("Result")
    '            DT.Columns.Add("Beneficio", GetType(String))
    '            DT.Columns.Add("Fecha_Cobro", GetType(DateTime))
    '            DT.Columns.Add("No_Cuota", GetType(Integer))
    '            DT.Columns.Add("Monto", GetType(Decimal))
    '            DT.Columns.Add("Abonado", GetType(Decimal))
    '            DT.Columns.Add("Pagada", GetType(Boolean))

    '            For Each Obj As clsBeDescuento_ref In ListObjDR

    '                Application.DoEvents()

    '                Dim Row As DataRow = DT.NewRow

    '                If Obj.EsVehiculo Then
    '                    Row.Item(0) = String.Format("{0} {1} {2} {3} {4}", Obj.Beneficio.Nombre, Obj.Beneficio.Modelo, Obj.Beneficio.NoPlaca, Obj.Beneficio.Motor, Obj.Beneficio.NoChasis).Trim()
    '                ElseIf Obj.EsTelefono Then
    '                    Row.Item(0) = String.Format("{0} {1} {2}", Obj.Beneficio.Nombre, Obj.Beneficio.NumeroTelefono, Obj.Beneficio.EmpresaTelco).Trim()
    '                ElseIf Obj.EsServicio Then
    '                    Row.Item(0) = String.Format("{0}", Obj.Beneficio.Nombre).Trim()
    '                End If

    '                Row.Item(1) = Obj.FechaCobro
    '                Row.Item(2) = Obj.NoCuota
    '                Row.Item(3) = Obj.Monto
    '                Row.Item(4) = Obj.Abonado
    '                Row.Item(5) = Obj.Pagada
    '                DT.Rows.Add(Row)

    '            Next

    '            GridCuota.DataSource = DT
    '            GridViewCuota.Columns(0).GroupIndex = 1
    '            GridViewCuota.OptionsView.ShowFooter = True

    '            GridViewCuota.Columns("No_Cuota").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
    '            GridViewCuota.Columns("No_Cuota").SummaryItem.DisplayFormat = "{0:n2}"

    '            GridViewCuota.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
    '            GridViewCuota.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"

    '            GridViewCuota.Columns("Abonado").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
    '            GridViewCuota.Columns("Abonado").SummaryItem.DisplayFormat = "{0:n2}"

    '            GridViewCuota.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '            GridViewCuota.Columns("Monto").DisplayFormat.FormatString = "{0:n2}"

    '            GridViewCuota.Columns("Abonado").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '            GridViewCuota.Columns("Abonado").DisplayFormat.FormatString = "{0:n2}"

    '            GridViewCuota.Columns("Fecha_Cobro").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime

    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub

    Private Sub cmdImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdImprimir1.ItemClick

        Try

            If GridViewDescuento.RowCount > 0 Then
                ImprimirReporte()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try

    End Sub

    Private Sub ImprimirReporte()

        Dim Reporte As New frmRepPagoRealizado
        Reporte.pObjPagoEnc = pObjBeEnc
        Reporte.ShowDialog()
        Reporte.Dispose()

    End Sub

End Class