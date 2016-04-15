Public Class frmCEF

    Private dCEF As New clsLnCef
    Public CEF As New clsBeCef

    Public Enum TipoTrans
        Nuevo = 1
        Editar = 2
    End Enum

    Private Property Modo As TipoTrans

    Sub New(ByVal pModo As TipoTrans)

        InitializeComponent()
        Modo = pModo

    End Sub

    Private Function Guardar() As Boolean

        Guardar = False

        Try

            If Datos_Correctos() Then

                CEF.IdCef = txtIdCEF.Text
                CEF.Sup.IdSupervisor = cmbSupervisor.SelectedValue
                CEF.Reg.IdRegion = cmbRegion.SelectedValue
                CEF.Municipo.IdMunicipio = cmbMunicipio.SelectedValue
                CEF.Depto.IdDepartamento = cmbDepartamento.SelectedValue
                CEF.Encargado = txtencargado.Text
                CEF.Encargado = txtencargado.Text
                CEF.Codigo = txtCodigoCEF.Text
                CEF.Descripcion = txtDescripcionCEF.Text
                CEF.Celular = txtCelular.Text
                CEF.Telefono = txtTelefono.Text
                CEF.Observaciones = txtObservaciones.Text
                CEF.User_agr = gUsuario.IdUsuario.ToString
                CEF.Fec_agr = Now
                CEF.User_mod = gUsuario.IdUsuario.ToString
                CEF.Fec_mod = Now
                CEF.Interlocutor = txtInterlocutor.Text
                CEF.Puntos = txtPuntos.Value

                Guardar = dCEF.Insertar(CEF) > 0

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Function Actualizar() As Boolean

        Actualizar = False

        Try

            If Datos_Correctos() Then

                CEF.IdCef = txtIdCEF.Text
                CEF.Sup.IdSupervisor = cmbSupervisor.SelectedValue
                CEF.Reg.IdRegion = cmbRegion.SelectedValue
                CEF.Municipo.IdMunicipio = cmbMunicipio.SelectedValue
                CEF.Depto.IdDepartamento = cmbDepartamento.SelectedValue
                CEF.Encargado = txtencargado.Text
                CEF.Encargado = txtencargado.Text
                CEF.Codigo = txtCodigoCEF.Text
                CEF.Descripcion = txtDescripcionCEF.Text
                CEF.Celular = txtCelular.Text
                CEF.Telefono = txtTelefono.Text
                CEF.Observaciones = txtObservaciones.Text
                CEF.User_mod = gUsuario.IdUsuario.ToString
                CEF.Fec_mod = Now
                CEF.Interlocutor = txtInterlocutor.Text
                CEF.Puntos = txtPuntos.Value

                Actualizar = dCEF.Actualizar(CEF) > 0

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


    Private Sub mnuGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuGuardar.ItemClick
        If Datos_Correctos() Then
            If MsgBox("¿Guardar CEF?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
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

            If txtCodigoCEF.Text.Trim = "" Then
                MsgBox("Ingrese código de CEF", MsgBoxStyle.Exclamation, Me.Text)
                txtCodigoCEF.Focus()
            ElseIf txtDescripcionCEF.Text.Trim = "" Then
                MsgBox("Ingrese descripción de CEF", MsgBoxStyle.Exclamation, Me.Text)
                txtDescripcionCEF.Focus()
            Else
                Datos_Correctos = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub mnuEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuEliminar.ItemClick

        If CBool(MsgBox("¿Eliminar el CEF?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes) Then
            If dCEF.Eliminar(CEF) > 0 Then
                MsgBox("Se ha eliminado el registro", MsgBoxStyle.Information, Me.Text)
                Me.Close()
            End If
        End If

    End Sub

    Private Sub frmCEF_Load(sender As Object, e As EventArgs) Handles Me.Load

        CEF.dSup.Llenar_Combo(cmbSupervisor)
        CEF.dDepto.Llenar_Combo(cmbDepartamento)
        CEF.dMuni.Llenar_Combo_Por_Departamento(cmbDepartamento.SelectedValue, cmbMunicipio)
        CEF.dReg.Llenar_Combo(cmbRegion)

    End Sub

    Private Sub frmCEF_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        UseWaitCursor = True

        Try

            Select Case Modo

                Case TipoTrans.Nuevo

                    CEF.IdCef = dCEF.Generar_Nuevo_IdCEF()

                    Me.txtIdCEF.Value = CEF.IdCef
                    Me.txtIdCEF.Enabled = False

                    'Bitácora
                    User_agrTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_agrDateEdit.Text = Now.ToShortDateString
                    User_modTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_modDateEdit.Text = Now.ToShortDateString

                    mnuGuardar.Enabled = True
                    mnuActualizar.Enabled = False
                    mnuEliminar.Enabled = False

                Case TipoTrans.Editar

                    dCEF.Obtener(CEF)

                    txtIdCEF.Text = CEF.IdCef
                    cmbSupervisor.SelectedValue = CEF.Sup.IdSupervisor
                    cmbRegion.SelectedValue = CEF.Reg.IdRegion
                    cmbDepartamento.SelectedValue = CEF.Depto.IdDepartamento
                    cmbMunicipio.SelectedValue = CEF.Municipo.IdMunicipio
                    txtencargado.Text = CEF.Encargado
                    txtCodigoCEF.Text = CEF.Codigo
                    txtDescripcionCEF.Text = CEF.Descripcion
                    txtCelular.Text = CEF.Celular
                    txtTelefono.Text = CEF.Telefono
                    txtObservaciones.Text = CEF.Observaciones

                    'Bitácora
                    Dim UserBitacora As New clsBeUsuario
                    UserBitacora.IdUsuario = CEF.User_agr
                    gdUsuario.Obtener(UserBitacora)

                    'Usuario agregó
                    User_agrTextEdit.Text = UserBitacora.Codigo
                    Fec_agrDateEdit.Text = CEF.Fec_agr.ToShortDateString

                    'Usuario modificó
                    UserBitacora.IdUsuario = CEF.User_mod
                    gdUsuario.Obtener(UserBitacora)

                    User_modTextEdit.Text = UserBitacora.Codigo
                    Fec_modDateEdit.Text = CEF.Fec_mod.ToShortDateString
                    'Fin Bitácora

                    mnuGuardar.Enabled = False
                    mnuActualizar.Enabled = True
                    mnuEliminar.Enabled = True

            End Select

            txtCodigoCEF.Focus()

            Application.DoEvents()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            UseWaitCursor = False
        End Try

    End Sub

    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged
        Try
            CEF.dMuni.Llenar_Combo_Por_Departamento(cmbDepartamento.SelectedValue, cmbMunicipio)
        Catch ex As Exception
        End Try
    End Sub

End Class