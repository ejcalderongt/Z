Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmPago

    Public pObjBeEnc As New clsBePago_enc
    Public pObjBDesceEnc As New clsBeDescuento_enc

    Private ObjLNenc As New clsLnPago_enc
    Private ObjLnF As New clsLnFranquiciado
    Private ObjLnC As New clsLnCef

    Private ListObjDD As List(Of clsBePago_det)
    Private ListObjDR As New List(Of clsBeDescuento_ref)
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

            ListObjDD = New List(Of clsBePago_det)

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
                    cmdImprimir1.Enabled = False

                Case TipoTrans.Editar

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

        Dim ObjLNDet As New clsLnPago_det

        Try

            pObjBeEnc = New clsBePago_enc
            pObjBeEnc.IdPagoEnc = clsLnPago_enc.Generar_Nuevo_IdPago

            pObjBeEnc.CEF.IdCef = txtCodCEF.Text
            pObjBeEnc.Franquiciado.IdFranquiciado = txtCodigoFranquiciado.Tag
            pObjBeEnc.User_agr = gUsuario.IdUsuario
            pObjBeEnc.Fec_agr = Now
            pObjBeEnc.User_mod = gUsuario.IdUsuario
            pObjBeEnc.Fec_mod = Now
            lConnection.Open()

            lTransaction = lConnection.BeginTransaction()

            ObjLNenc.Insertar(pObjBeEnc, lConnection, lTransaction)

            Dim lMaxDet As Integer = clsLnPago_det.MaxID(pObjBeEnc.IdPagoEnc)


            For Each Obj As clsBePago_det In ListObjDD

                lMaxDet += 1
                Obj.IdPagoEnc = pObjBeEnc.IdPagoEnc
                Obj.IdPagoDet = lMaxDet
                Obj.User_agr = gUsuario.IdUsuario
                Obj.User_mod = gUsuario.IdUsuario
                ObjLNDet.Insertar(Obj, lConnection, lTransaction)

            Next

            lTransaction.Commit()

            GuardarDatos = True
            lblCodigo.Text = pObjBeEnc.IdPagoEnc

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

                CargaDescuentos()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try

    End Sub

    Private Sub CargaDescuentos()

        Try

            Dgrid.DataSource = clsLnDescuento_enc.GetAllByCefFranquiciado(CInt(txtCodCEF.Tag), CInt(txtCodigoFranquiciado.Tag))

            GridViewPago.Columns("IdDescuentoEnc").Visible = False
            GridViewPago.Columns("IdDescuentoDet").Visible = False
            GridViewPago.Columns("IdDescuentoRef").Visible = False
            GridViewPago.Columns("IdBeneficio").Visible = False

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
                ObjLnF.Obtener(pObjBeEnc.Franquiciado)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click

        If String.IsNullOrEmpty(txtCodigoFranquiciado.Text) Then
            MsgBox("Seleccione Persona.", MsgBoxStyle.Information, Me.Text)
        Else
            Dim Periodo As New frmPeriodo
            Periodo.pIndex = -1
            Periodo.Cargar = New frmPeriodo.Operar(AddressOf CargarDetalle)
            Periodo.ShowDialog()
        End If

    End Sub

    Private Sub CargarDatos()

        Try

            ObjLNenc.Obtener(pObjBeEnc)

            Me.lblCodigo.Text = pObjBeEnc.IdPagoEnc

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

            ListObjDD = clsLnPago_det.GetAllByPagoEnc(pObjBeEnc.IdPagoEnc)
            CargarDetalle()
            CargarCuota()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargarDetalle()

        Try

            Dim ObjLnB As New clsLnBeneficio
            Dim ObjLnTP As New clsLnTipobeneficio

            Dim DT As New DataTable("Result")
            DT.Columns.Add("IdPagoDet", GetType(Integer))
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

            If ListObjDD IsNot Nothing AndAlso ListObjDD.Count > 0 Then

                Application.DoEvents()

                For Each Obj As clsBePago_det In ListObjDD

                    Dim ObjB As New clsBeBeneficio
                    ObjB.IdBeneficio = Obj.IdBeneficio
                    ObjLnB.Obtener(ObjB)

                    Dim ObjTP As New clsBeTipobeneficio
                    ObjTP.IdTipoBeneficio = ObjB.TipoBeneficio.IdTipoBeneficio
                    ObjLnTP.Obtener(ObjTP)

                    DT.Rows.Add(Obj.IdPagoDet, ObjB.IdBeneficio, ObjB.TipoBeneficio.Nombre, ObjB.Modelo, _
                                ObjB.NoChasis, ObjB.NoPlaca, ObjB.NumeroTelefono, _
                                ObjB.EmpresaTelco, "", _
                                "Obj.MontoTotal", "Obj.Cuotas")

                Next

            End If

            Dgrid.DataSource = DT
            GridViewPago.Columns("IdPagoDet").Visible = False
            GridViewPago.Columns("IdBeneficio").Visible = False
            GridViewPago.Columns("Estado").Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Dgrid_DoubleClick(sender As Object, e As EventArgs) Handles Dgrid.DoubleClick

        Try

            If GridViewPago.RowCount > 0 Then

                Dim Dr As DataRowView = GridViewPago.GetFocusedRow
                Dim lIndex As Integer = ListObjDD.FindIndex(Function(b) b.IdBeneficio = CInt(Dr.Item("IdBeneficio")))

                Dim Periodo As New frmPeriodo
                Periodo.ShowDialog()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try

    End Sub
    Private Sub CargarCuota()

        Try

            ListObjDR = clsLnDescuento_ref.GetAllByEncabezado(pObjBDesceEnc.IdDescuentoEnc)

            If ListObjDR IsNot Nothing AndAlso ListObjDR.Count > 0 Then

                Dim DT As New DataTable("Result")
                DT.Columns.Add("Beneficio", GetType(String))
                DT.Columns.Add("Fecha_Cobro", GetType(DateTime))
                DT.Columns.Add("No_Cuota", GetType(Integer))
                DT.Columns.Add("Monto", GetType(Decimal))
                DT.Columns.Add("Abonado", GetType(Decimal))
                DT.Columns.Add("Pagada", GetType(Boolean))

                For Each Obj As clsBeDescuento_ref In ListObjDR

                    Application.DoEvents()

                    Dim Row As DataRow = DT.NewRow

                    If Obj.EsVehiculo Then
                        Row.Item(0) = String.Format("{0} {1} {2} {3} {4}", Obj.Beneficio.Nombre, Obj.Beneficio.Modelo, Obj.Beneficio.NoPlaca, Obj.Beneficio.Motor, Obj.Beneficio.NoChasis).Trim()
                    ElseIf Obj.EsTelefono Then
                        Row.Item(0) = String.Format("{0} {1} {2}", Obj.Beneficio.Nombre, Obj.Beneficio.NumeroTelefono, Obj.Beneficio.EmpresaTelco).Trim()
                    ElseIf Obj.EsServicio Then
                        Row.Item(0) = String.Format("{0}", Obj.Beneficio.Nombre).Trim()
                    End If

                    Row.Item(1) = Obj.FechaCobro
                    Row.Item(2) = Obj.NoCuota
                    Row.Item(3) = Obj.Monto
                    Row.Item(4) = Obj.Abonado
                    Row.Item(5) = Obj.Pagada
                    DT.Rows.Add(Row)

                Next

                GridCuota.DataSource = DT
                GridViewCuota.Columns(0).GroupIndex = 1
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
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmdImprimir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdImprimir1.ItemClick

        Try

            If GridViewPago.RowCount > 0 Then
                ImprimirReporte()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try

    End Sub

    Private Sub ImprimirReporte()


    End Sub

End Class