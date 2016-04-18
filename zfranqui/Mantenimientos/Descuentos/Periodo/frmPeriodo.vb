Imports DevExpress.XtraEditors

Public Class frmPeriodo

    Public pIndex As Integer
    Public pTipoDescuento As Integer
    Public pListObjDD As List(Of clsBeDescuento_det)
    Public pListObjDR As List(Of clsBeDescuento_ref)

    Public Delegate Sub Operar()
    Public Cargar As Operar

    Private ObjB As New clsLnBeneficio

    Private Sub frmPeriodoDefinido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim dt As DataTable = ObjB.LlenaTipoBeneficio()

            If dt.Rows.Count > 0 Then
                cmbTipoBeneficio.DisplayMember = "Nombre"
                cmbTipoBeneficio.ValueMember = "IdTipoBeneficio"
                cmbTipoBeneficio.DataSource = dt
            End If

            clsLnPeriodo_descuento.LlenaPeriodoDescuento(cmbPeriodo)

            If pIndex >= 0 Then
                CargarDatos()
            End If

            If pTipoDescuento = 1 Then
                Me.Text = "Período Definido"
                ' lblCuota.Text = "Cuotas:"
                'txtCuota.Visible = True
                'dtmFecha.Visible = False
                If pIndex >= 0 Then
                    txtCuota.Value = pListObjDD(pIndex).Cuotas
                Else
                    txtCuota.Value = 0.0
                End If
                SetValue()
                lblNoCuota.Visible = True
                lblNoCuota.Location = New Point(12, 89)
                txtCuota.Visible = True
                txtCuota.Location = New Point(139, 87)
            ElseIf pTipoDescuento = 2 Then
                Me.Text = "Período Indefinido"
                SetValue()
                lblNoCuota.Visible = False
                lblNoCuota.Location = New Point(327, 89)
                txtCuota.Visible = False
                txtCuota.Location = New Point(445, 87)
            Else
                Me.Text = "Período Ünico"
                SetValue()
                lblNoCuota.Visible = True
                lblNoCuota.Location = New Point(12, 89)
                txtCuota.Visible = True
                txtCuota.Location = New Point(139, 87)
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub SetValue()

        Try

            'lblCuota.Text = "A partir de:"
            'txtCuota.Visible = False
            'dtmFecha.Location = New Point(96, 87)
            'dtmFecha.Visible = True
            If pIndex >= 0 Then
                dtmFecha.Value = CDate(pListObjDD(pIndex).FechaAPartirDe)
            Else
                dtmFecha.Value = Now.Date
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub ResizeCampos()

        Try

            ' Original location 12, 89
            lblNoCuota.Visible = False
            lblNoCuota.Location = New Point(327, 89)

            ' Original location 139, 87
            txtCuota.Visible = False
            txtCuota.Location = New Point(445, 87)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub CargarDatos()

        Try

            cmbPeriodo.SelectedValue = pListObjDD(pIndex).PeriodoDescuento.IdPeriodo
            txtMontoTotal.Text = pListObjDD(pIndex).MontoTotal

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargaBeneficios()

        Try

            If cmbTipoBeneficio.SelectedValue Is Nothing Then Exit Sub

            Dim ObjTP As New clsBeTipobeneficio()
            Dim Obj As New clsLnTipobeneficio

            ObjTP.IdTipoBeneficio = cmbTipoBeneficio.SelectedValue
            Obj.Obtener(ObjTP)

            Dgrid.DataSource = ObjB.Listar(cmbTipoBeneficio.SelectedValue, ObjTP.EsServicio, txtFiltro.Text)

            If ObjTP.EsVehiculo Then
                GridView1.Columns("NumeroTelefono").Visible = False
                GridView1.Columns("EmpresaTelco").Visible = False
                GridView1.Columns("Nombre").Visible = False
            ElseIf ObjTP.EsTelefono Then
                GridView1.Columns("NoChasis").Visible = False
                GridView1.Columns("NoPlaca").Visible = False
                GridView1.Columns("Modelo").Visible = False
                GridView1.Columns("Motor").Visible = False
                GridView1.Columns("EmpresaTelco").Visible = True
                GridView1.Columns("NumeroTelefono").Visible = True
                GridView1.Columns("Nombre").Visible = False
            Else
                GridView1.Columns("Nombre").Visible = True
                GridView1.Columns("NoChasis").Visible = False
                GridView1.Columns("NoPlaca").Visible = False
                GridView1.Columns("Modelo").Visible = False
                GridView1.Columns("Motor").Visible = False
                GridView1.Columns("EmpresaTelco").Visible = False
                GridView1.Columns("NumeroTelefono").Visible = False
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub cmbTipoBeneficio_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTipoBeneficio.SelectedValueChanged
        CargaBeneficios()
    End Sub

    Private Sub txtFiltro_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtFiltro.EditValueChanging
        CargaBeneficios()
    End Sub

    Private Sub Dgrid_DoubleClick(sender As Object, e As EventArgs) Handles Dgrid.DoubleClick

        Try

            If String.IsNullOrEmpty(txtMontoTotal.Text.Trim()) Then
                Throw New Exception("Ingrese monto total.")
            ElseIf Not txtMontoTotal.Text > 0 Then
                Throw New Exception("El monto total debe ser mayor a cero.")
            ElseIf pTipoDescuento = 1 AndAlso String.IsNullOrEmpty(txtCuota.Text.Trim()) Then
                Throw New Exception("Ingrese número de cuotas.")
            ElseIf pTipoDescuento = 1 AndAlso txtCuota.Text > 0 = False Then
                Throw New Exception("El número de cuotas debe ser mayor a cero.")
            End If

            If (GridView1.RowCount > 0) Then

                Dim Dr As DataRowView = GridView1.GetFocusedRow

                If pTipoDescuento = 1 Then
                    CrearPeriodoDefinido(Dr)
                ElseIf pTipoDescuento = 2 Then
                    CrearPeriodoInDefinido(Dr)
                ElseIf pTipoDescuento = 3 Then
                    CrearPeriodoUnico(Dr)
                End If

            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

#Region " Periodos "

    Private Sub CrearPeriodoDefinido(ByVal Dr As DataRowView)

        Try

            If pIndex >= 0 Then

                '' EDITAMOS EL REGISTRO

                pListObjDD(pIndex).Beneficio.IdBeneficio = CInt(Dr.Item("Codigo"))
                pListObjDD(pIndex).PeriodoDescuento.IdPeriodo = cmbPeriodo.SelectedValue
                pListObjDD(pIndex).MontoTotal = CDec(txtMontoTotal.Text)

                Dim lMonto As Decimal = 0.0

                If pTipoDescuento = 1 Then

                    pListObjDD(pIndex).Cuotas = CInt(txtCuota.Text)
                    lMonto = CDec(pListObjDD(pIndex).MontoTotal / txtCuota.Text)
                    lMonto = Math.Round(lMonto, CInt(txtRedondear.Value))
                    If txtCuota.Text < pListObjDR.Count Then
                        pListObjDR.RemoveRange(0, CInt(txtCuota.Text))
                    End If

                    For Each Obj As clsBeDescuento_ref In pListObjDR
                        Obj.Monto = lMonto
                    Next

                End If

                pListObjDD(pIndex).Fec_agr = Now
                pListObjDD(pIndex).User_mod = gUsuario.IdUsuario

            Else

                '' CREAMOS UN NUEVO REGISTRO
                If pListObjDD IsNot Nothing AndAlso pListObjDD.Exists(Function(b) b.Beneficio.IdBeneficio = CInt(Dr.Item("Codigo"))) Then
                    Throw New Exception("El beneficio ya fue agregado.")
                End If

                Dim Obj As New clsBeDescuento_det()
                Obj.Beneficio = New clsBeBeneficio
                Obj.Beneficio.IdBeneficio = CInt(Dr.Item("Codigo"))
                Dim dBene As New clsLnBeneficio
                dBene.Obtener(Obj.Beneficio, True)

                Obj.PeriodoDescuento = New clsBePeriodo_descuento
                Obj.PeriodoDescuento.IdPeriodo = cmbPeriodo.SelectedValue
                Dim dPer As New clsLnPeriodo_descuento
                dPer.Obtener(Obj.PeriodoDescuento)

                Obj.MontoTotal = Math.Round(CDec(txtMontoTotal.Text), CInt(txtRedondear.Value))
                Obj.Cuotas = CInt(txtCuota.Text)
                Obj.User_agr = gUsuario.IdUsuario
                Obj.Fec_agr = Now
                Obj.User_mod = gUsuario.IdUsuario
                Obj.Fec_mod = Now
                Obj.IsNew = True

                pListObjDD.Add(Obj)

                'Dim ObjLn As New clsLnPeriodo_descuento
                'Dim ObjBe As New clsBePeriodo_descuento

                'ObjBe.IdPeriodo = Obj.PeriodoDescuento.IdPeriodo
                'ObjLn.Obtener(ObjBe)

                Dim lMonto As Decimal = CDec(Obj.MontoTotal / txtCuota.Text)
                lMonto = Math.Round(lMonto, CInt(txtRedondear.Value))
                Dim lFechaA As Date = dtmFecha.Value

                For i As Integer = 1 To txtCuota.Text Step 1

                    Dim ObjR As New clsBeDescuento_ref
                    ObjR.IdBeneficio = Obj.Beneficio.IdBeneficio
                    ObjR.NoCuota = i
                    ObjR.Monto = lMonto
                    ObjR.Abonado = 0.0
                    ObjR.Anulada = False

                    If i = 1 Then
                        ObjR.FechaCobro = lFechaA.AddDays(Obj.PeriodoDescuento.Dias)
                    Else
                        ObjR.FechaCobro = pListObjDR.Max(Function(m) m.FechaCobro.AddDays(Obj.PeriodoDescuento.Dias).Date)
                    End If

                    ObjR.Pagada = False
                    ObjR.Fec_agr = Now
                    ObjR.User_agr = gUsuario.IdUsuario
                    ObjR.Fec_mod = Now
                    ObjR.User_mod = gUsuario.IdUsuario
                    ObjR.IsNew = True
                    pListObjDR.Add(ObjR)

                Next

            End If

            Cargar.Invoke()

            txtMontoTotal.Text = String.Empty
            txtCuota.Text = String.Empty

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub CrearPeriodoInDefinido(ByVal Dr As DataRowView)

        Try

            If pIndex >= 0 Then

                '' EDITAMOS EL REGISTRO

                pListObjDD(pIndex).Beneficio.IdBeneficio = CInt(Dr.Item("Codigo"))
                pListObjDD(pIndex).PeriodoDescuento.IdPeriodo = cmbPeriodo.SelectedValue
                pListObjDD(pIndex).MontoTotal = Math.Round(CDec(txtMontoTotal.Text), CInt(txtRedondear.Value))
                pListObjDD(pIndex).Fec_agr = Now
                pListObjDD(pIndex).User_mod = gUsuario.IdUsuario
                pListObjDD(pIndex).FechaAPartirDe = CDate(dtmFecha.Value)

            Else

                '' CREAMOS UN NUEVO REGISTRO
                If pListObjDD IsNot Nothing AndAlso pListObjDD.Exists(Function(b) b.Beneficio.IdBeneficio = CInt(Dr.Item("Codigo"))) Then
                    Throw New Exception("El beneficio ya fue agregado.")
                End If

                Dim Obj As New clsBeDescuento_det()
                Obj.Beneficio = New clsBeBeneficio
                Obj.Beneficio.IdBeneficio = CInt(Dr.Item("Codigo"))
                Dim dBene As New clsLnBeneficio
                dBene.Obtener(Obj.Beneficio, True)

                Obj.PeriodoDescuento = New clsBePeriodo_descuento
                Obj.PeriodoDescuento.IdPeriodo = cmbPeriodo.SelectedValue
                Dim dPer As New clsLnPeriodo_descuento
                dPer.Obtener(Obj.PeriodoDescuento)

                Obj.MontoTotal = Math.Round(CDec(txtMontoTotal.Text), CInt(txtRedondear.Value))
                Obj.User_agr = gUsuario.IdUsuario
                Obj.Fec_agr = Now
                Obj.User_mod = gUsuario.IdUsuario
                Obj.Fec_mod = Now
                Obj.FechaAPartirDe = CDate(dtmFecha.Value)
                Obj.IsNew = True
                pListObjDD.Add(Obj)

            End If

            Cargar.Invoke()

            txtMontoTotal.Text = String.Empty

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub CrearPeriodoUnico(ByVal Dr As DataRowView)

        Try

            If pIndex >= 0 Then

                '' EDITAMOS EL REGISTRO

                pListObjDD(pIndex).Beneficio.IdBeneficio = CInt(Dr.Item("Codigo"))
                pListObjDD(pIndex).PeriodoDescuento.IdPeriodo = cmbPeriodo.SelectedValue
                pListObjDD(pIndex).MontoTotal = Math.Round(CDec(txtMontoTotal.Text), CInt(txtRedondear.Value))
                pListObjDD(pIndex).Fec_agr = Now
                pListObjDD(pIndex).User_mod = gUsuario.IdUsuario
                pListObjDD(pIndex).FechaAPartirDe = CDate(dtmFecha.Value)

            Else

                '' CREAMOS UN NUEVO REGISTRO
                If pListObjDD IsNot Nothing AndAlso pListObjDD.Exists(Function(b) b.Beneficio.IdBeneficio = CInt(Dr.Item("Codigo"))) Then
                    Throw New Exception("El beneficio ya fue agregado.")
                End If

                Dim Obj As New clsBeDescuento_det()
                Obj.Beneficio = New clsBeBeneficio
                Obj.Beneficio.IdBeneficio = CInt(Dr.Item("Codigo"))
                Dim dBene As New clsLnBeneficio
                dBene.Obtener(Obj.Beneficio, True)

                Obj.PeriodoDescuento = New clsBePeriodo_descuento
                Obj.PeriodoDescuento.IdPeriodo = cmbPeriodo.SelectedValue
                Dim dPer As New clsLnPeriodo_descuento
                dPer.Obtener(Obj.PeriodoDescuento)

                Obj.MontoTotal = Math.Round(CDec(txtMontoTotal.Text), CInt(txtRedondear.Value))
                Obj.Cuotas = 1
                Obj.User_agr = gUsuario.IdUsuario
                Obj.Fec_agr = Now
                Obj.User_mod = gUsuario.IdUsuario
                Obj.Fec_mod = Now
                Obj.FechaAPartirDe = CDate(dtmFecha.Value)
                Obj.IsNew = True
                pListObjDD.Add(Obj)

                Dim ObjR As New clsBeDescuento_ref
                ObjR.IdBeneficio = Obj.Beneficio.IdBeneficio
                ObjR.NoCuota = 1
                ObjR.Monto = Obj.MontoTotal
                ObjR.Abonado = 0.0
                ObjR.FechaCobro = Obj.FechaAPartirDe.Date
                ObjR.Pagada = False
                ObjR.Fec_agr = Now
                ObjR.User_agr = gUsuario.IdUsuario
                ObjR.Fec_mod = Now
                ObjR.User_mod = gUsuario.IdUsuario
                Obj.IsNew = True
                pListObjDR.Add(ObjR)

            End If

            Cargar.Invoke()

            txtMontoTotal.Text = String.Empty

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

#End Region


    Private Sub txtCuota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCuota.KeyPress
        If Not (Char.IsControl(e.KeyChar) And e.KeyChar <> ".") Then
            e.Handled = True
        End If

        If e.KeyChar = "." Then
            e.Handled = True
        End If

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub cmbPeriodo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPeriodo.SelectedValueChanged
        Try

            If cmbPeriodo.SelectedValue Is Nothing Then Exit Sub

            Dim ObjBe As New clsBePeriodo_descuento
            ObjBe.IdPeriodo = cmbPeriodo.SelectedValue
            Dim ObjLn As New clsLnPeriodo_descuento
            ObjLn.Obtener(ObjBe)
            lblPeriodo.Text = ObjBe.Dias & " Días"

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub txtRedondear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRedondear.KeyPress
        If Not (Char.IsControl(e.KeyChar) And e.KeyChar <> ".") Then
            e.Handled = True
        End If

        If e.KeyChar = "." Then
            e.Handled = True
        End If

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        End If
    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click

        Try

            If XtraMessageBox.Show("¿Desea crear Beneficio?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                If cmbTipoBeneficio.SelectedIndex = -1 Then
                    Throw New Exception("Seleccione Tipo Beneficio.")
                End If

                Dim Obj As New clsBeTipobeneficio()
                Obj.IdTipoBeneficio = cmbTipoBeneficio.SelectedValue

                Dim o As New clsLnTipobeneficio
                o.Obtener(Obj)

                Dim Bene As New frmBeneficio(frmBeneficio.TipoTrans.Nuevo)
                'Bene.pIdTipoBeneficioDefault = CInt(cmbTipoBeneficio.SelectedValue)
                Bene.Bene.TipoBeneficio = Obj
                Bene.ShowDialog()
                Bene.Dispose()
                CargaBeneficios()

            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

End Class