Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Public Class frmDescuento

    Public pObjEnc As New clsBeDescuento_enc

    Private ObjLNenc As New clsLnDescuento_enc
    Private ObjLnF As New clsLnFranquiciado
    Private ObjLnC As New clsLnCef

    Public Enum TipoTrans
        Nuevo = 1
        Editar = 2
    End Enum

    Public Enum pTipoDescuento
        Definido = 1
        Indefinido = 2
        Unico = 3
    End Enum

    Public Property TipoDescuento As pTipoDescuento

    Private Property Modo As TipoTrans

    Sub New(ByVal pModo As TipoTrans)

        InitializeComponent()
        Modo = pModo

    End Sub

    Private Sub mnuGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuGuardar.ItemClick
        If Datos_Correctos() Then
            If XtraMessageBox.Show("¿Guardar Descuento?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If GuardarDatos() Then
                    XtraMessageBox.Show("Se guardó el registro.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If XtraMessageBox.Show("¿Desea Imprimir el Reporte?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        'ImprimirReporte()
                        ImprimirReporteGrid()
                        Me.Close()
                    End If
                End If
            End If
        End If
    End Sub

    Private Function GuardarDatos() As Boolean

        GuardarDatos = False

        Dim lConnection As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)
        Dim lTransaction As MySql.Data.MySqlClient.MySqlTransaction = Nothing

        Try

            Dim ObjLNDet As New clsLnDescuento_det
            Dim ObjLNRef As New clsLnDescuento_ref

            lConnection.Open()
            lTransaction = lConnection.BeginTransaction()

            ' Validacion y asignacion 
            If pObjEnc.IsNew Then
                'pObjEnc = New clsBeDescuento_enc
                pObjEnc.IdDescuentoEnc = clsLnDescuento_enc.Generar_Nuevo_IdDescuento
                pObjEnc.CEF.IdCef = txtCodCEF.Tag
                pObjEnc.Franquiciado.IdFranquiciado = txtCodigoFranquiciado.Tag
                pObjEnc.User_agr = gUsuario.IdUsuario
                pObjEnc.Fec_agr = Now
                pObjEnc.User_mod = gUsuario.IdUsuario
                pObjEnc.Fec_mod = Now
                If TipoDescuento = pTipoDescuento.Definido Then
                    pObjEnc.IdTipoDescuento = pTipoDescuento.Definido
                ElseIf TipoDescuento = pTipoDescuento.Indefinido Then
                    pObjEnc.IdTipoDescuento = pTipoDescuento.Indefinido
                ElseIf TipoDescuento = pTipoDescuento.Unico Then
                    pObjEnc.IdTipoDescuento = pTipoDescuento.Unico
                End If
                ObjLNenc.Insertar(pObjEnc, lConnection, lTransaction)
            Else
                ObjLNenc.Actualizar(pObjEnc, lConnection, lTransaction)
            End If

            Dim lMaxDet As Integer = clsLnDescuento_det.MaxID(pObjEnc.IdDescuentoEnc)
            For Each Obj As clsBeDescuento_det In pObjEnc.Detalle

                If Obj.IsNew Then
                    lMaxDet += 1
                    Obj.IdDescuentoEnc = pObjEnc.IdDescuentoEnc
                    Obj.IdDescuentoDet = lMaxDet
                    Obj.User_agr = gUsuario.IdUsuario
                    Obj.User_mod = gUsuario.IdUsuario
                    Obj.Fec_mod = Now
                    Obj.Activo = True
                Else
                    Obj.User_mod = gUsuario.IdUsuario
                    Obj.Fec_mod = Now
                End If

                Dim lMaxRef As Integer = clsLnDescuento_ref.MaxID(Obj.IdDescuentoEnc, Obj.IdDescuentoDet)

                For Each ObjR As clsBeDescuento_ref In pObjEnc.Referencia.FindAll(Function(b) b.IdBeneficio = Obj.Beneficio.IdBeneficio)

                    If ObjR.IsNew Then
                        lMaxRef += 1
                        ObjR.IdDescuentoEnc = Obj.IdDescuentoEnc
                        ObjR.IdDescuentoDet = Obj.IdDescuentoDet
                        ObjR.IdDescuentoRef = lMaxRef
                        ObjR.Anulada = False
                        ObjLNRef.Insertar(ObjR, lConnection, lTransaction)
                    End If
                Next

                If Obj.IsNew Then
                    ObjLNDet.Insertar(Obj, lConnection, lTransaction)
                Else
                    ObjLNDet.Actualizar(Obj, lConnection, lTransaction)
                End If
            Next

            lTransaction.Commit()

            GuardarDatos = True
            'lblCodigo.Text = pObjEnc.IdDescuentoEnc
            Me.Close()

        Catch ex As Exception
            Try
                lTransaction.Rollback()
            Catch ex1 As Exception
                MsgBox("No se pudo hacer rollback de la transacción: " & ex.Message)
            End Try
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Finally

            Try
                lConnection.Close()
            Catch ex As Exception
            End Try

        End Try

    End Function

    Private Sub mnuActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuActualizar.ItemClick
        If GuardarDatos() Then
            MsgBox("Se actualizó el registro", MsgBoxStyle.Information, Me.Text)
            If XtraMessageBox.Show("¿Desea Imprimir el Reporte?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                ImprimirReporte()
            End If
            Me.Close()
        End If
    End Sub

    Private Function Datos_Correctos() As Boolean

        Datos_Correctos = False

        Try

            If String.IsNullOrEmpty(txtCodigoFranquiciado.Text) Then
                XtraMessageBox.Show("Seleccione Persona.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf pObjEnc.Detalle IsNot Nothing AndAlso pObjEnc.Detalle.Count = 0 Then
                XtraMessageBox.Show("Ingrese por lo menos 1 beneficio.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Datos_Correctos = True
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Function

    Private Function DescuentoTieneAlgunPago() As Boolean

        DescuentoTieneAlgunPago = False

        Try

            For Each D As clsBeDescuento_det In pObjEnc.Detalle

                If clsLnDescuento_ref.TienePago(D) Then
                    DescuentoTieneAlgunPago = True
                    Exit Function
                End If

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub mnuEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuEliminar.ItemClick

        If CBool(MsgBox("¿Anular el Descuento?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes) Then

            If Not DescuentoTieneAlgunPago() Then

                If clsLnDescuento_enc.AnularDescuento(pObjEnc) Then
                    MsgBox("Se ha eliminado el registro", MsgBoxStyle.Information, Me.Text)
                    Me.Close()
                End If
                
            Else
                MsgBox("Ya se han realizado pagos sobre los beneficios de éste descuento, no se puede anular el registro", MsgBoxStyle.Exclamation, Me.Text)
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

                pObjEnc.Franquiciado = FraList.Franqui
                txtCodigoFranquiciado.Tag = FraList.Franqui.IdFranquiciado
                txtCodigoFranquiciado.Text = FraList.Franqui.Codigo
                txtCodigoFranquiciado_LostFocus(Nothing, Nothing)
                txtNombres.Text = FraList.Franqui.Nombres
                txtApellidos.Text = FraList.Franqui.Apellidos
                txtCodCEF.Tag = FraList.Franqui.CEF.IdCef
                txtCodCEF.Text = FraList.Franqui.CEF.Codigo
                txtNomCEF.Text = FraList.Franqui.CEF.Descripcion

            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub txtCodigoFranquiciado_EditValueChanged(sender As Object, e As EventArgs) Handles txtCodigoFranquiciado.EditValueChanged
        txtNombres.Text = ""
        txtApellidos.Text = ""
    End Sub

    Private Sub txtCodigoFranquiciado_LostFocus(sender As Object, e As EventArgs) Handles txtCodigoFranquiciado.LostFocus

        Try

            If Val(txtCodigoFranquiciado.Text) > 0 Then

                pObjEnc.Franquiciado.Codigo = txtCodigoFranquiciado.Text

                If ObjLnF.Obtener(pObjEnc.Franquiciado, False) Then

                    pObjEnc.Franquiciado = pObjEnc.Franquiciado
                    txtCodigoFranquiciado.Tag = pObjEnc.Franquiciado.IdFranquiciado
                    txtCodigoFranquiciado.Text = pObjEnc.Franquiciado.Codigo
                    txtNombres.Text = pObjEnc.Franquiciado.Nombres
                    txtApellidos.Text = pObjEnc.Franquiciado.Apellidos
                    txtCodCEF.Tag = pObjEnc.Franquiciado.CEF.IdCef
                    txtCodCEF.Text = pObjEnc.Franquiciado.CEF.Codigo
                    txtNomCEF.Text = pObjEnc.Franquiciado.CEF.Descripcion


                Else
                    MsgBox("El código ingresado de franquiciado no es válido", MsgBoxStyle.Exclamation, Me.Text)
                End If

            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click

        Try

            If String.IsNullOrEmpty(txtCodigoFranquiciado.Text) Then
                XtraMessageBox.Show("Seleccione Persona.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                Dim Periodo As New frmPeriodo

                If TipoDescuento = pTipoDescuento.Definido Then
                    Periodo.pTipoDescuento = pTipoDescuento.Definido
                ElseIf TipoDescuento = pTipoDescuento.Indefinido Then
                    Periodo.pTipoDescuento = pTipoDescuento.Indefinido
                ElseIf TipoDescuento = pTipoDescuento.Unico Then
                    Periodo.pTipoDescuento = pTipoDescuento.Unico
                End If

                Periodo.pIndex = -1
                Periodo.pListObjDD = pObjEnc.Detalle
                Periodo.pListObjDR = pObjEnc.Referencia
                Periodo.Cargar = New frmPeriodo.Operar(AddressOf CargarDetalle)
                Periodo.ShowDialog()

            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub CargarDatos()

        UseWaitCursor = True

        Try

            ObjLNenc.ObtenerParcial(pObjEnc)

            Me.lblCodigo.Text = pObjEnc.IdDescuentoEnc

            'Bitácora
            'Dim UserBitacora As New clsBeUsuario
            'UserBitacora.IdUsuario = pObjBeEnc.User_agr
            'gdUsuario.Obtener(UserBitacora)

            'Usuario agregó
            User_agrTextEdit.Text = pObjEnc.NomUsuarioAgrego
            Fec_agrDateEdit.Text = pObjEnc.Fec_agr.ToShortDateString

            'Usuario modificó
            'UserBitacora.IdUsuario = pObjBeEnc.User_mod
            'gdUsuario.Obtener(UserBitacora)

            User_modTextEdit.Text = pObjEnc.NomUsuarioModifico
            Fec_modDateEdit.Text = pObjEnc.Fec_mod.ToShortDateString
            'Fin Bitácora

            txtCodigoFranquiciado.Text = pObjEnc.Franquiciado.Codigo
            txtNombres.Text = pObjEnc.Franquiciado.Nombres
            txtApellidos.Text = pObjEnc.Franquiciado.Apellidos
            txtCodCEF.Text = pObjEnc.CEF.Codigo
            txtNomCEF.Text = pObjEnc.CEF.Descripcion
            'txtCodCEF.Text = pObjBeEnc.Franquiciado.CEF.Codigo
            'txtNomCEF.Text = pObjBeEnc.Franquiciado.CEF.Descripcion

            'ListObjDD = clsLnDescuento_det.GetAllByDescuentoEnc(pObjBeEnc.IdDescuentoEnc, chkDescuentosActivos.Checked)
            'ListObjDR = clsLnDescuento_ref.GetAllByEncabezado(pObjBeEnc.IdDescuentoEnc)

            CargarDetalle()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            UseWaitCursor = False
        End Try

    End Sub

    Private Sub CargarDetalle()

        Try

            Dim ObjLnB As New clsLnBeneficio
            Dim ObjLnTP As New clsLnTipobeneficio
            Dim ObjLNPD As New clsLnPeriodo_descuento

            Dim DT As New DataTable("Result")
            DT.Columns.Add("IdDescuentoDet", GetType(Integer))
            DT.Columns.Add("IdBeneficio", GetType(Integer))
            DT.Columns.Add("Beneficio", GetType(String))
            DT.Columns.Add("Modelo", GetType(String))
            DT.Columns.Add("Chasis", GetType(String))
            DT.Columns.Add("Placa", GetType(String))
            DT.Columns.Add("No Teléfono", GetType(String))
            DT.Columns.Add("Empresa", GetType(String))
            DT.Columns.Add("Período (Días)", GetType(String))
            DT.Columns.Add("Total", GetType(Decimal))
            DT.Columns.Add("Cuotas", GetType(Integer))
            DT.Columns.Add("Estado", GetType(String))
            DT.Columns.Add("Activo", GetType(String))

            If pObjEnc.Detalle IsNot Nothing AndAlso pObjEnc.Detalle.Count > 0 Then

                Application.DoEvents()

                For Each Obj As clsBeDescuento_det In pObjEnc.Detalle

                    Try

                        DT.Rows.Add(Obj.IdDescuentoDet, Obj.Beneficio.IdBeneficio, Obj.Beneficio.TipoBeneficio.Nombre, Obj.Beneficio.Modelo, _
                                Obj.Beneficio.NoChasis, Obj.Beneficio.NoPlaca, Obj.Beneficio.NumeroTelefono, _
                                Obj.Beneficio.EmpresaTelco, Obj.PeriodoDescuento.Nombre & " " & Obj.PeriodoDescuento.Dias, _
                                Obj.MontoTotal, Obj.Cuotas, "", Obj.Activo)

                    Catch ex As Exception
                        XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try

                Next

            End If

            Dgrid.DataSource = DT

            GridViewDescuento.Columns("IdDescuentoDet").Visible = False
            GridViewDescuento.Columns("IdBeneficio").Visible = False
            GridViewDescuento.Columns("Estado").Visible = False

            GridViewDescuento.Columns("Total").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            GridViewDescuento.Columns("Total").SummaryItem.DisplayFormat = "{0:n2}"

            GridViewDescuento.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridViewDescuento.Columns("Total").DisplayFormat.FormatString = "{0:n2}"

            CargarCuota()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub CargarCuota()

        Try

            If pObjEnc.Referencia IsNot Nothing AndAlso pObjEnc.Referencia.Count > 0 Then

                Dim DT As New DataTable("Result")
                DT.Columns.Add("IdDescuentoRef", GetType(Integer))
                DT.Columns.Add("Beneficio", GetType(String))
                DT.Columns.Add("Fecha_Cobro", GetType(DateTime))
                DT.Columns.Add("No_Cuota", GetType(Integer))
                DT.Columns.Add("Monto", GetType(Decimal))
                DT.Columns.Add("Abonado", GetType(Decimal))
                DT.Columns.Add("Pagada", GetType(Boolean))

                For Each Obj As clsBeDescuento_ref In pObjEnc.Referencia

                    Application.DoEvents()

                    Dim Row As DataRow = DT.NewRow

                    Row.Item(0) = Obj.IdDescuentoRef

                    If Obj.EsVehiculo Then
                        Row.Item(1) = String.Format("{0} {1} {2} {3} {4}", Obj.Beneficio.Nombre, Obj.Beneficio.Modelo, Obj.Beneficio.NoPlaca, Obj.Beneficio.Motor, Obj.Beneficio.NoChasis).Trim()
                    ElseIf Obj.EsTelefono Then
                        Row.Item(1) = String.Format("{0} {1} {2}", Obj.Beneficio.Nombre, Obj.Beneficio.NumeroTelefono, Obj.Beneficio.EmpresaTelco).Trim()
                    ElseIf Obj.EsServicio Then
                        Row.Item(1) = String.Format("{0}", Obj.Beneficio.Nombre).Trim()
                    End If

                    Row.Item(2) = Obj.FechaCobro
                    Row.Item(3) = Obj.NoCuota
                    Row.Item(4) = Obj.Monto
                    Row.Item(5) = Obj.Abonado
                    Row.Item(6) = Obj.Pagada
                    DT.Rows.Add(Row)

                Next

                GridCuota.DataSource = DT
                GridViewCuota.Columns(0).Visible = False 'Ocultar IdRef
                GridViewCuota.Columns(1).GroupIndex = 1
                GridViewCuota.OptionsView.ShowFooter = True

                GridViewCuota.Columns("No_Cuota").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                GridViewCuota.Columns("No_Cuota").SummaryItem.DisplayFormat = "{0:n2}"

                GridViewCuota.Columns("Monto").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                GridViewCuota.Columns("Monto").SummaryItem.DisplayFormat = "{0:n2}"

                GridViewCuota.Columns("Abonado").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                GridViewCuota.Columns("Abonado").SummaryItem.DisplayFormat = "{0:n2}"

                GridViewCuota.Columns("Monto").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridViewCuota.Columns("Monto").DisplayFormat.FormatString = "{0:n2}"

                GridViewCuota.Columns("Abonado").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                GridViewCuota.Columns("Abonado").DisplayFormat.FormatString = "{0:n2}"

                GridViewCuota.Columns("Fecha_Cobro").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime

            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub Dgrid_DoubleClick(sender As Object, e As EventArgs) Handles Dgrid.DoubleClick

        Try

            If GridViewDescuento.RowCount > 0 Then

                Dim Dr As DataRowView = GridViewDescuento.GetFocusedRow
                Dim lIndex As Integer = pObjEnc.Detalle.FindIndex(Function(b) b.Beneficio.IdBeneficio = CInt(Dr.Item("IdBeneficio")))
                pObjEnc.Referencia = clsLnDescuento_ref.GetAllByDetalle(pObjEnc.IdDescuentoEnc, CInt(Dr.Item("IdDescuentoDet")))

                Dim Periodo As New frmPeriodo

                If TipoDescuento = pTipoDescuento.Definido Then
                    Periodo.pTipoDescuento = pTipoDescuento.Definido
                ElseIf TipoDescuento = pTipoDescuento.Indefinido Then
                    Periodo.pTipoDescuento = pTipoDescuento.Indefinido
                ElseIf TipoDescuento = pTipoDescuento.Unico Then
                    Periodo.pTipoDescuento = pTipoDescuento.Unico
                End If

                Periodo.pIndex = lIndex
                Periodo.pListObjDD = pObjEnc.Detalle
                Periodo.pListObjDR = pObjEnc.Referencia
                Periodo.Cargar = New frmPeriodo.Operar(AddressOf CargarDetalle)
                Periodo.ShowDialog()

            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub


    Private Sub ImprimirReporte()

        Try

            Dim DT1 As New DataTable
            Dim rpv As New frmRepView
            Dim rtpDetCuotas As New rptDtoDetREF

            Try

                vSQL = " SELECT tipobeneficio.Nombre AS TipoBeneficio, beneficio.Nombre, CONCAT(beneficio.Modelo, '/',beneficio.NoChasis, '/', " & _
                        " beneficio.NoPlaca, '/', beneficio.Motor) AS REF, beneficio.NumeroTelefono, beneficio.EmpresaTelco,  " & _
                        " beneficio.fecha_asignacion, descuento_ref.FechaCobro, descuento_ref.NoCuota, descuento_ref.Monto, descuento_ref.Abonado,  " & _
                        " tipodescuento.Nombre AS TipoDescuento, cef.Codigo AS CodCEF, cef.Descripcion AS DescCEF, franquiciado.Codigo AS CodFranquiciado, " & _
                        " franquiciado.Nombres AS NomFranquiciado, franquiciado.Apellidos AS ApeFranquiciado " & _
                        " FROM  descuento_det INNER JOIN " & _
                        " descuento_ref ON descuento_det.IdDescuentoEnc = descuento_ref.IdDescuentoEnc INNER JOIN " & _
                        " beneficio ON descuento_det.IdBeneficio = beneficio.IdBeneficio INNER JOIN " & _
                        " tipobeneficio ON beneficio.IdTipoBeneficio = tipobeneficio.IdTipoBeneficio INNER JOIN " & _
                        " descuento_enc ON descuento_det.IdDescuentoEnc = descuento_enc.IdDescuentoEnc INNER JOIN " & _
                        " cef ON descuento_enc.IdCEF = cef.IdCef INNER JOIN " & _
                        " tipodescuento ON descuento_enc.IdTipoDescuento = tipodescuento.IdTipoDescuento INNER JOIN " & _
                        " franquiciado ON descuento_enc.IdFranquiciado = franquiciado.IdFranquiciado " & _
                        " WHERE descuento_enc.IdDescuentoEnc = " & pObjEnc.IdDescuentoEnc

                BD.OpenDT(DT1, vSQL)

                If DT1.Rows.Count > 0 Then

                    rtpDetCuotas.SetDataSource(DT1)
                    'rptRecepcion1.SetParameterValue("PolizaNO", DT.Rows(0).Item("poliza_no"))
                    rpv.crview = New CrystalDecisions.Windows.Forms.CrystalReportViewer
                    rpv.crview.ReportSource = rtpDetCuotas
                    rpv.ShowDialog()

                End If

            Catch ex As Exception
                XtraMessageBox.Show("1 " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        Catch ex As Exception
            XtraMessageBox.Show("2 " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub ImprimirReporteGrid()

        Try

            Dim DT1 As New DataTable
            'Dim rpv As New frmRepView
            'Dim rtpDetCuotas As New rptDtoDetREF

            Try

                Dim repG As New frmRepDescuentoDet(frmRepDescuentoDet.TipoReporte.CuotasDetalleDescuento)
                repG.DescuentoEnc = pObjEnc
                repG.ShowDialog()
                repG.Dispose()

            Catch ex As Exception
                XtraMessageBox.Show("1 " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        Catch ex As Exception
            XtraMessageBox.Show("2 " & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub frmDescuento_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Try

            Select Case Modo

                Case TipoTrans.Nuevo

                    Me.lblCodigo.Text = "-"

                    User_agrTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_agrDateEdit.Text = Now.ToShortDateString

                    User_modTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_modDateEdit.Text = Now.ToShortDateString

                    mnuGuardar.Enabled = True
                    mnuActualizar.Enabled = False
                    mnuEliminar.Enabled = False
                    cmdImprimir.Enabled = False

                    txtCodigoFranquiciado.Focus()

                Case TipoTrans.Editar

                    txtCodigoFranquiciado.Enabled = False

                    Dim TiempoIni As DateTime = Now

                    CargarDatos()

                    Dim TiempoFin As DateTime = Now

                    Dim Dif As Integer = DateDiff(DateInterval.Second, TiempoIni, TiempoFin)

                    'MsgBox("Segundos de carga: " & Dif)

                    mnuGuardar.Enabled = False
                    mnuActualizar.Enabled = True
                    mnuEliminar.Enabled = True
                    cmdImprimir.Enabled = True


            End Select

            Application.DoEvents()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub


    Private Sub mnuDetalleCuotas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuDetalleCuotas.ItemClick

        Try

            If GridViewDescuento.RowCount > 0 Then
                ImprimirReporteGrid()
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub mnuAnularDescuento_Click(sender As Object, e As EventArgs) Handles mnuAnularDescuento.Click

        Try

            If GridViewDescuento.RowCount > 0 Then

                Dim Dr As DataRowView = GridViewDescuento.GetFocusedRow
                Dim lIndex As Integer = pObjEnc.Detalle.FindIndex(Function(b) b.IdDescuentoDet = CInt(Dr.Item("IdDescuentoDet")))
                Dim Det As New clsBeDescuento_det
                Det = pObjEnc.Detalle.Find(Function(b) b.IdDescuentoDet = CInt(Dr.Item("IdDescuentoDet")))

                If MsgBox("Eliminar el beneficio: " & Dr(2).ToString & "/" & Dr(3).ToString & "/" & Dr(4).ToString & "/" & Dr(5).ToString & "/" & Dr(6).ToString & "/" & Dr(7).ToString, MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                    If Modo = TipoTrans.Nuevo Then

                        pObjEnc.Detalle.RemoveAt(lIndex)
                        GridViewDescuento.DeleteSelectedRows()

                    Else

                        'VALIDAR SI NO TIENE PAGO PARA ELIMINARLO

                        If Not clsLnDescuento_ref.TienePago(Det) Then

                            If clsLnDescuento_ref.AnularDetalleDescuento(Det) Then

                                MsgBox("Se ha eliminado el beneficio y sus cuotas", MsgBoxStyle.Information, Me.Text)
                                pObjEnc.Detalle.RemoveAt(lIndex) 'Remover de lista de clase
                                GridViewDescuento.DeleteSelectedRows() 'Remover de gridview
                                CargarDetalle()

                                'Si solo tiene un beneficio anular el descuento ?

                            End If

                            'anular el beneficio

                        Else
                            MsgBox("La cuota tiene pago(s) realizado(s), no se puede anular", MsgBoxStyle.Exclamation)
                        End If

                    End If

                End If

            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub mnuEliminarCuota_Click(sender As Object, e As EventArgs) Handles mnuEliminarCuota.Click

        Try

            If GridViewDescuento.RowCount > 0 Then

                Dim Dr As DataRowView = GridViewCuota.GetFocusedRow
                Dim lIndex As Integer = pObjEnc.Referencia.FindIndex(Function(b) b.IdDescuentoRef = CInt(Dr.Item("IdDescuentoRef")))
                Dim Ref As New clsBeDescuento_ref
                Ref = pObjEnc.Referencia.Find(Function(b) b.IdDescuentoRef = CInt(Dr.Item("IdDescuentoRef")))

                If MsgBox("Eliminar cuota #:" & Dr(3).ToString & " Fecha: " & CDate(Dr(2)) & " Monto: " & Dr(4).ToString, MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then

                    If Modo = TipoTrans.Nuevo Then

                        pObjEnc.Referencia.RemoveAt(lIndex)
                        GridViewCuota.DeleteSelectedRows()

                    Else

                        'VALIDAR SI NO TIENE PAGO PARA ELIMINARLO

                        If Not clsLnDescuento_ref.TienePago(Ref) Then

                            If clsLnDescuento_ref.AnularCuota(Ref) Then
                                MsgBox("Se ha anulado la cuota", MsgBoxStyle.Information, Me.Text)
                                pObjEnc.Referencia.RemoveAt(lIndex) 'Remover de lista de clase
                                GridViewCuota.DeleteSelectedRows() 'Remover de gridview
                                CargarDetalle()
                            End If
                            'anular la cuota

                        Else
                            MsgBox("La cuota tiene pago(s) realizado(s), no se puede anular", MsgBoxStyle.Exclamation)
                        End If

                    End If

                End If

            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

End Class