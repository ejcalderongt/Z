﻿Imports DevExpress.XtraEditors

Public Class frmBeneficio

    Private dBene As New clsLnBeneficio
    Public Bene As New clsBeBeneficio
    Public pIdTipoBeneficioDefault As Integer

    Public Enum TipoTrans
        Nuevo = 1
        Editar = 2
    End Enum

    Private Property Modo As TipoTrans

    Sub New(ByVal pModo As TipoTrans)

        InitializeComponent()
        Modo = pModo

    End Sub

    Private Sub frmBeneficio_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        Try

            If Bene.TipoBeneficio.EsVehiculo Then
                txtModelo.Focus()
            ElseIf PanTelefono.Visible = Bene.TipoBeneficio.EsTelefono Then
                txtNoTelefono.Focus()
            Else
                txtNombre.Focus()
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmBeneficio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Me.Text = "Mantenimiento de " & Bene.TipoBeneficio.Nombre

            Dim dt As DataTable = dBene.LlenaTipoBeneficio()

            If dt.Rows.Count > 0 Then
                cmbTipo.DisplayMember = "Nombre"
                cmbTipo.ValueMember = "IdTipoBeneficio"
                cmbTipo.DataSource = dt
            End If

            If Bene.TipoBeneficio.IdTipoBeneficio <> 0 Then
                cmbTipo.SelectedValue = Bene.TipoBeneficio.IdTipoBeneficio
                cmbTipo.Enabled = False
            End If

            txtNombre.Visible = (Bene.TipoBeneficio.IdTipoBeneficio = 5)
            lblnombre.Visible = (Bene.TipoBeneficio.IdTipoBeneficio = 5)

            Select Case Modo

                Case TipoTrans.Nuevo

                    Bene.IdBeneficio = dBene.Generar_Nuevo_IdBeneficio()
                    Me.txtIdBeneficio.Value = Bene.IdBeneficio
                    Me.txtIdBeneficio.Enabled = False

                    User_agrTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_agrDateEdit.Text = Now.ToShortDateString

                    User_modTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_modDateEdit.Text = Now.ToShortDateString

                    mnuGuardar.Enabled = True
                    mnuActualizar.Enabled = False
                    mnuEliminar.Enabled = False

                    'If pIdTipoBeneficioDefault <> 0 Then
                    '    cmbTipo.SelectedValue = pIdTipoBeneficioDefault
                    'End If

                Case TipoTrans.Editar

                    dBene.Obtener(Bene)

                    txtIdBeneficio.Text = Bene.IdBeneficio
                    cmbTipo.SelectedValue = Bene.TipoBeneficio.IdTipoBeneficio

                    txtModelo.Text = Bene.Modelo
                    txtNoChasis.Text = Bene.NoChasis
                    txtPlaca.Text = Bene.NoPlaca
                    txtMotor.Text = Bene.Motor

                    txtNoTelefono.Text = Bene.NumeroTelefono
                    cmbEmpresaTelco.Text = Bene.EmpresaTelco
                    txtNombre.Text = Bene.Nombre

                    txtFechaAsignado.Text = Bene.Fecha_asignacion
                    txtCodigoFranquiciado.Text = Bene.FranquiciadoAsignado.Codigo
                    txtNombresFranquiciado.Text = Bene.FranquiciadoAsignado.Nombres
                    txtApellidosFranquiciado.Text = Bene.FranquiciadoAsignado.Apellidos
                    txtCodCEF.Text = Bene.FranquiciadoAsignado.CEF.Codigo
                    txtNomCEF.Text = Bene.FranquiciadoAsignado.CEF.Descripcion

                    If txtCodigoFranquiciado.Text.Trim <> "" Then
                        PanDatosBeneficio.Enabled = False
                        PanTelefono.Enabled = False
                        PanVehiculo.Enabled = False
                    End If

                    'Bitácora
                    Dim UserBitacora As New clsBeUsuario
                    UserBitacora.IdUsuario = Bene.User_agr
                    gdUsuario.Obtener(UserBitacora)

                    'Usuario agregó
                    User_agrTextEdit.Text = UserBitacora.Codigo
                    Fec_agrDateEdit.Text = Bene.Fec_agr.ToShortDateString

                    'Usuario modificó
                    UserBitacora.IdUsuario = Bene.User_mod
                    gdUsuario.Obtener(UserBitacora)

                    User_modTextEdit.Text = UserBitacora.Codigo
                    Fec_modDateEdit.Text = Bene.Fec_mod.ToShortDateString
                    'Fin Bitácora

                    mnuGuardar.Enabled = False
                    mnuActualizar.Enabled = True
                    mnuEliminar.Enabled = True

            End Select

            cmbTipo.Focus()

            Application.DoEvents()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function Guardar() As Boolean

        Guardar = False

        Try


            Bene.IdBeneficio = txtIdBeneficio.Text
            Bene.TipoBeneficio.IdTipoBeneficio = cmbTipo.SelectedValue
            Bene.Nombre = IIf(txtNombre.Text.Trim = "", cmbTipo.Text, txtNombre.Text)
            Bene.Modelo = txtModelo.Text
            Bene.NoChasis = txtNoChasis.Text
            Bene.NoPlaca = txtPlaca.Text
            Bene.Motor = txtMotor.Text
            Bene.NumeroTelefono = txtNoTelefono.Text
            Bene.EmpresaTelco = IIf(txtNoTelefono.Text <> "", cmbEmpresaTelco.Text, "")
            Bene.User_agr = gUsuario.IdUsuario.ToString
            Bene.Fec_agr = Now
            Bene.User_mod = gUsuario.IdUsuario.ToString
            Bene.User_agr = gUsuario.IdUsuario.ToString
            Bene.Activo = 1

            Guardar = dBene.Insertar(Bene) > 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Function Actualizar() As Boolean

        Actualizar = False

        Try

            If Datos_Correctos() Then

                Bene.IdBeneficio = Me.txtIdBeneficio.Text
                Bene.TipoBeneficio.IdTipoBeneficio = cmbTipo.SelectedValue
                Bene.Nombre = cmbTipo.Text
                Bene.Modelo = txtModelo.Text
                Bene.NoChasis = txtNoChasis.Text
                Bene.NoPlaca = txtPlaca.Text
                Bene.Motor = txtMotor.Text
                Bene.NumeroTelefono = txtNoTelefono.Text
                Bene.EmpresaTelco = IIf(txtNoTelefono.Text <> "", cmbEmpresaTelco.Text, "")
                Bene.User_mod = gUsuario.IdUsuario.ToString
                Bene.User_agr = gUsuario.IdUsuario.ToString
                Bene.Activo = 1

                Bene.User_mod = gUsuario.IdUsuario.ToString
                Bene.Fec_mod = Now

                Actualizar = dBene.Actualizar(Bene) > 0

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub mnuGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuGuardar.ItemClick
        If Datos_Correctos() Then
            If XtraMessageBox.Show("¿Guardar Beneficio?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If Guardar() Then MsgBox("Se guardó el registro", MsgBoxStyle.Information, Me.Text)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub mnuActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuActualizar.ItemClick
        If Actualizar() Then
            MsgBox("Se actualizó el registro", MsgBoxStyle.Information, Me.Text)
            Me.Close()
        End If
    End Sub

    Private Function Datos_Correctos() As Boolean

        Datos_Correctos = False

        Try

            If cmbTipo.Text.Trim = "" AndAlso (Bene.TipoBeneficio.EsVehiculo = 0) AndAlso (Bene.TipoBeneficio.EsTelefono = 0) Then
                MsgBox("No se ha definido el tipo de beneficio", MsgBoxStyle.Exclamation, Me.Text)
                cmbTipo.Focus()
            ElseIf Bene.TipoBeneficio.EsVehiculo = 1 Then

                If txtModelo.Text.Trim = "" Then
                    MsgBox("No se ha definido el modelo", MsgBoxStyle.Exclamation, Me.Text)
                    txtModelo.Focus()
                ElseIf txtNoChasis.Text.Trim = "" Then
                    MsgBox("No se ha definido el chasis", MsgBoxStyle.Exclamation, Me.Text)
                    txtNoChasis.Focus()
                ElseIf txtPlaca.Text.Trim = "" Then
                    MsgBox("No se ha definido la placa", MsgBoxStyle.Exclamation, Me.Text)
                    txtPlaca.Focus()
                ElseIf txtMotor.Text.Trim = "" Then
                    MsgBox("No se ha definido el motor", MsgBoxStyle.Exclamation, Me.Text)
                    txtMotor.Focus()
                Else
                    Datos_Correctos = True
                End If

            ElseIf Bene.TipoBeneficio.EsTelefono = 1 Then

                If txtNoTelefono.Text.Trim = "" Then
                    MsgBox("No se ha definido el número de teléfono", MsgBoxStyle.Exclamation, Me.Text)
                    txtNoTelefono.Focus()
                ElseIf txtNoTelefono.Text.Length < 8 Then
                    MsgBox("El número ingresado no es válido", MsgBoxStyle.Exclamation, Me.Text)
                    txtNoTelefono.Focus()
                Else
                    Datos_Correctos = True
                End If

            Else
                Datos_Correctos = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub mnuEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuEliminar.ItemClick

        If CBool(MsgBox("¿Eliminar el Beneficio?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes) Then

            Bene.Activo = 0

            If dBene.Desactivar(Bene) > 0 Then
                MsgBox("Se ha eliminado el registro", MsgBoxStyle.Information, Me.Text)
                Me.Close()
            End If

        End If

    End Sub

    Private Sub cmbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged

        Try


            PanTelefono.Visible = Bene.TipoBeneficio.EsTelefono
            PanVehiculo.Visible = Bene.TipoBeneficio.EsVehiculo

            'If Bene.TipoBeneficio.EsVehiculo Then
            '    PanDatosBeneficio.Location = New Point(210, PanDatosBeneficio.Location.Y)
            '    PanVehiculo.Location = New Point(210, PanVehiculo.Location.Y)
            '    txtModelo.Focus()
            'ElseIf PanTelefono.Visible = Bene.TipoBeneficio.EsTelefono Then

            'End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmBeneficio_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Text = "Alto: " & Me.Height & " Ancho: " & Me.Width
    End Sub

End Class