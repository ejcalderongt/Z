Public Class frmFranquiciado

    Private dFranqui As New clsLnFranquiciado
    Public Franqui As New clsBeFranquiciado

    Private dBanco As New clsLnBanco

    Public Enum TipoTrans
        Nuevo = 1
        Editar = 2
    End Enum

    Private Property Modo As TipoTrans

    Sub New(ByVal pModo As TipoTrans)

        InitializeComponent()
        Modo = pModo

    End Sub

    Private Sub frmFranquiciado_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtCodigo.Focus() 'If Modo = TipoTrans.Nuevo Then dBanco.Llenar_Combo(cmbBanco)
    End Sub

    Private Sub frmFranquiciado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            dBanco.Llenar_Combo(cmbBanco)

            Select Case Modo

                Case TipoTrans.Nuevo

                    Franqui.IdFranquiciado = dFranqui.Generar_Nuevo_IdFranquiciado()

                    Me.txtIdFranquiciado.Value = Franqui.IdFranquiciado
                    Me.txtIdFranquiciado.Enabled = False

                    User_agrTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_agrDateEdit.Text = Now.ToShortDateString

                    User_modTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_modDateEdit.Text = Now.ToShortDateString

                    mnuGuardar.Enabled = True
                    mnuActualizar.Enabled = False
                    mnuEliminar.Enabled = False

                Case TipoTrans.Editar


                    dFranqui.Obtener(Franqui)

                    cmbBanco.SelectedValue = Franqui.IdBanco
                    txtCodigo.Text = Franqui.Codigo
                    txtNombres.Text = Franqui.Nombres
                    txtApellidos.Text = Franqui.Apellidos
                    txtDPI.Text = Franqui.DPI
                    txtNoCuenta.Text = Franqui.NoCuenta
                    txtdireccion.Text = Franqui.Direccion
                    txtNIT.Text = Franqui.NIT
                    txtIdFranquiciado.Text = Franqui.IdFranquiciado
                    txtInterlocutor.Text = Franqui.Interlocutor
                    Get_Info_CEF(Franqui.CEFAsignado.IdCEF)

                    txtFechaCreacion.Text = Franqui.Fec_agr

                    'Bitácora Franquiciado
                    Dim UserBitacora As New clsBeUsuario
                    UserBitacora.IdUsuario = Franqui.User_agr
                    gdUsuario.Obtener(UserBitacora)

                    'Usuario agregó
                    User_agrTextEdit.Text = UserBitacora.Codigo
                    Fec_agrDateEdit.Text = Franqui.Fec_agr.ToShortDateString

                    'Usuario modificó
                    UserBitacora.IdUsuario = Franqui.User_mod
                    gdUsuario.Obtener(UserBitacora)

                    User_modTextEdit.Text = UserBitacora.Codigo
                    Fec_modDateEdit.Text = Franqui.Fec_mod.ToShortDateString
                    'Fin Bitácora

                    mnuGuardar.Enabled = False
                    mnuActualizar.Enabled = True
                    mnuEliminar.Enabled = True

            End Select

            txtCodigo.Focus()

            Application.DoEvents()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function Guardar() As Boolean

        Guardar = False

        Try

            Franqui.IdBanco = cmbBanco.SelectedValue
            Franqui.Codigo = txtCodigo.Text
            Franqui.Nombres = txtNombres.Text
            Franqui.Apellidos = txtApellidos.Text
            Franqui.DPI = txtDPI.Text
            Franqui.NoCuenta = txtNoCuenta.Text
            Franqui.Direccion = txtdireccion.Text
            Franqui.NIT = txtNIT.Text
            Franqui.IdFranquiciado = txtIdFranquiciado.Text

            Franqui.User_agr = gUsuario.IdUsuario
            Franqui.Fec_agr = Now
            Franqui.User_mod = gUsuario.IdUsuario
            Franqui.Fec_mod = Now

            Franqui.CEFAsignado.User_agr = gUsuario.IdUsuario
            Franqui.CEFAsignado.Fec_agr = Now
            Franqui.CEFAsignado.User_mod = gUsuario.IdUsuario
            Franqui.CEFAsignado.Fec_mod = Now
            Franqui.CEFAsignado.Activo = 1

            Franqui.Interlocutor = txtInterlocutor.Text

            Guardar = dFranqui.Insertar(Franqui, Franqui.CEFAsignado)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Function Actualizar() As Boolean

        Actualizar = False

        Try

            If Datos_Correctos() Then

                Franqui.IdBanco = cmbBanco.SelectedValue
                Franqui.Codigo = txtCodigo.Text
                Franqui.Nombres = txtNombres.Text
                Franqui.Apellidos = txtApellidos.Text
                Franqui.DPI = txtDPI.Text
                Franqui.NoCuenta = txtNoCuenta.Text
                Franqui.Direccion = txtdireccion.Text
                Franqui.NIT = txtNIT.Text
                Franqui.IdFranquiciado = txtIdFranquiciado.Text
                Franqui.User_mod = gUsuario.IdUsuario
                Franqui.Fec_mod = Now
                Franqui.Interlocutor = txtInterlocutor.Text

                Actualizar = dFranqui.Actualizar(Franqui, Franqui.CEFAsignado)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


    Private Sub mnuGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuGuardar.ItemClick
        If Datos_Correctos() Then
            If MsgBox("¿Guardar Franquiciado?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                If Guardar() Then
                    MsgBox("Se guardó el registro", MsgBoxStyle.Information, Me.Text)
                    Me.Close()
                End If                
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

            If txtNombres.Text.Trim = "" Then
                MsgBox("Ingrese nombres", MsgBoxStyle.Exclamation, Me.Text)
                txtNombres.Focus()
            ElseIf txtCodigo.Text.Trim = "" Then
                MsgBox("Ingrese Código", MsgBoxStyle.Exclamation, Me.Text)
                txtCodigo.Focus()
            ElseIf dFranqui.Existe_Codigo(txtCodigo.Text, txtIdFranquiciado.Text) Then
                MsgBox("El código ingresado ya existe", MsgBoxStyle.Exclamation, Me.Text)
                txtCodigo.Focus()
            ElseIf txtNIT.Text.Trim <> "" AndAlso dFranqui.Existe_NIT(txtNIT.Text, txtIdFranquiciado.Text) Then
                MsgBox("El NIT ingresado ya existe", MsgBoxStyle.Exclamation, Me.Text)
                txtNIT.Focus()
            ElseIf txtDPI.Text.Trim <> "" AndAlso dFranqui.Existe_DPI(txtDPI.Text, txtIdFranquiciado.Text) Then
                MsgBox("El DPI ingresado ya existe", MsgBoxStyle.Exclamation, Me.Text)
                txtDPI.Focus()
            Else
                Datos_Correctos = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub mnuEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuEliminar.ItemClick

        If CBool(MsgBox("¿Eliminar el Franquiciado?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes) Then

            Franqui.Activo = 0
            Franqui.User_mod = gUsuario.IdUsuario
            Franqui.Fec_mod = Now

            If dFranqui.Desactivar(Franqui) > 0 Then
                MsgBox("Se ha eliminado el registro", MsgBoxStyle.Information, Me.Text)
                Me.Close()
            End If

        End If

    End Sub

    Private Sub cmbBanco_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbBanco.KeyDown
        If e.KeyCode = Keys.Delete Then cmbBanco.SelectedIndex = -1
    End Sub

    Private Sub txtCodigo_EditValueChanged(sender As Object, e As EventArgs) Handles txtCodigo.EditValueChanged
        EsNumerico(txtCodigo)
    End Sub

    Private Sub txtDPI_EditValueChanged(sender As Object, e As EventArgs) Handles txtDPI.EditValueChanged
        EsNumerico(txtDPI)
    End Sub

    Private Sub lnkCEF_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCEF.LinkClicked

        Try

            Dim ListaCEF As New frmCEFList
            ListaCEF.Modo = frmCEFList.pModo.Seleccion
            ListaCEF.WindowState = FormWindowState.Maximized
            ListaCEF.StartPosition = FormStartPosition.CenterScreen
            ListaCEF.ShowDialog()

            UseWaitCursor = True

            If ListaCEF.CEF.IdCef <> 0 Then

                Get_Info_CEF(ListaCEF.CEF.IdCef)

            End If

            ListaCEF.Close()
            ListaCEF.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            UseWaitCursor = False
        End Try

    End Sub

    Private Sub Get_Info_CEF(ByVal IdCEF As String)

        Try

            If Modo = TipoTrans.Nuevo Then

                Franqui.CEFAsignado.IdAsignacionFranquiciado = Franqui.CEFAsignadoLN.Generar_Nuevo_IdAsignacionFranquiciado()

                Franqui.CEFAsignado.IdCEF = IdCEF 'Asignación al CEF
                Franqui.CEFAsignado.IdFranquiciado = txtIdFranquiciado.Text 'El franquiciado de la asignación
                Franqui.CEFAsignado.Fec_agr = Now
                Franqui.CEFAsignado.Fec_mod = Now
                Franqui.CEFAsignado.User_agr = gUsuario.IdUsuario
                Franqui.CEFAsignado.User_mod = gUsuario.IdUsuario
                Franqui.CEFAsignado.Activo = 1

                Franqui.CEF.IdCef = Franqui.CEFAsignado.IdCEF 'El CEF per se
                Franqui.dCEF.Obtener(Franqui.CEF) 'Buscar datos del CEF

                txtCodCEF.Text = Franqui.CEF.Codigo
                txtNomCEF.Text = Franqui.CEF.Descripcion
                txtCodSupervisorCEF.Text = IIf(Franqui.CEF.Sup.Codigo = "", Franqui.CEF.Sup.IdSupervisor, Franqui.CEF.Sup.Codigo)
                txtNomSupervisor.Text = Franqui.CEF.Sup.Nombre
                txtIdRegion.Text = Franqui.CEF.Reg.IdRegion
                txtNomRegion.Text = Franqui.CEF.Reg.Nombre
                txtidMunicipio.Text = Franqui.CEF.Municipo.IdMunicipio
                txtNomMunicipio.Text = Franqui.CEF.Municipo.Nombre
                txtIdDepartamento.Text = Franqui.CEF.Depto.IdDepartamento
                txtNomDepartamento.Text = Franqui.CEF.Depto.Nombre
                txtEncargado.Text = Franqui.CEF.Encargado

            Else

                If IsNumeric(IdCEF) AndAlso Val(IdCEF) <> Franqui.CEF.IdCef Then
                    Franqui.CEF.IdCef = IdCEF 'El CEF per se
                    Franqui.dCEF.Obtener(Franqui.CEF)
                ElseIf IsNumeric(IdCEF) Then
                    Franqui.CEF.IdCef = IdCEF 'El CEF per se
                    Franqui.dCEF.Obtener(Franqui.CEF)
                ElseIf IdCEF <> Franqui.CEF.Codigo Then
                    Franqui.CEF.Codigo = IdCEF 'El CEF per se
                    Franqui.CEF.IdCef = 0
                    Franqui.dCEF.Obtener(Franqui.CEF)
                End If

                Franqui.CEFAsignado.IdCEF = Franqui.CEF.IdCef
                Franqui.CEFAsignado.IdFranquiciado = txtIdFranquiciado.Text

                txtCodCEF.Text = Franqui.CEF.Codigo
                txtNomCEF.Text = Franqui.CEF.Descripcion
                txtCodSupervisorCEF.Text = IIf(Franqui.CEF.Sup.Codigo = "", Franqui.CEF.Sup.IdSupervisor, Franqui.CEF.Sup.Codigo)
                txtNomSupervisor.Text = Franqui.CEF.Sup.Nombre
                txtIdRegion.Text = Franqui.CEF.Reg.IdRegion
                txtNomRegion.Text = Franqui.CEF.Reg.Nombre
                txtidMunicipio.Text = Franqui.CEF.Municipo.IdMunicipio
                txtNomMunicipio.Text = Franqui.CEF.Municipo.Nombre
                txtIdDepartamento.Text = Franqui.CEF.Depto.IdDepartamento
                txtNomDepartamento.Text = Franqui.CEF.Depto.Nombre
                txtEncargado.Text = Franqui.CEF.Encargado

                'Bitácora Franquiciado
                Dim UserBitacora As New clsBeUsuario
                UserBitacora.IdUsuario = Franqui.CEFAsignado.User_agr
                gdUsuario.Obtener(UserBitacora)

                'Usuario agregó
                txtIdUsuarioAgrAsignacion.Text = UserBitacora.Codigo
                txtFechaAgrAsignacion.Text = Franqui.CEFAsignado.Fec_agr.ToShortDateString

                'Usuario modificó
                UserBitacora.IdUsuario = Franqui.CEFAsignado.User_mod
                gdUsuario.Obtener(UserBitacora)

                txtIdUsuarioModAsignacion.Text = UserBitacora.Codigo
                txtFechaModificoAsignacion.Text = Franqui.CEFAsignado.Fec_mod.ToShortDateString
                'Fin Bitácora

                txtFechaAsignacion.Text = Franqui.CEFAsignado.Fec_agr

                Try

                    Dim Creacion As DateTime = txtFechaCreacion.Text
                    Dim Asignacion As DateTime = txtFechaAsignacion.Text

                    txtTiempoTranscurrido.Text = DateDiff(DateInterval.Day, Asignacion, Creacion)


                Catch ex As Exception

                End Try
                
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtCodCEF_EditValueChanged(sender As Object, e As EventArgs) Handles txtCodCEF.EditValueChanged
        txtNomCEF.Text = ""
        txtCodSupervisorCEF.Text = ""
        txtIdRegion.Text = ""
        txtidMunicipio.Text = ""
        txtIdDepartamento.Text = ""
        txtEncargado.Text = ""
        txtFechaAsignacion.Text = ""
        txtTiempoTranscurrido.Text = "0"
        If txtCodCEF.Text = "" Then Franqui.CEFAsignado.IdCEF = 0
    End Sub

    Private Sub txtCodCEF_LostFocus(sender As Object, e As EventArgs) Handles txtCodCEF.LostFocus

        Try

            If txtCodCEF.Text.Trim <> "" Then

                If Franqui.CEFAsignado.IdCEF = 0 Then 'No se escogió el CEF por el linklabel
                    Get_Info_CEF(txtCodCEF.Text.Trim)
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtCodSupervisorCEF_EditValueChanged(sender As Object, e As EventArgs) Handles txtCodSupervisorCEF.EditValueChanged
        txtNomSupervisor.Text = ""
    End Sub

    Private Sub txtIdRegion_EditValueChanged(sender As Object, e As EventArgs) Handles txtIdRegion.EditValueChanged
        txtNomRegion.Text = ""
    End Sub

    Private Sub txtidMunicipio_EditValueChanged(sender As Object, e As EventArgs) Handles txtidMunicipio.EditValueChanged
        txtNomMunicipio.Text = ""
    End Sub

    Private Sub txtIdDepartamento_EditValueChanged(sender As Object, e As EventArgs) Handles txtIdDepartamento.EditValueChanged
        txtNomDepartamento.Text = ""
    End Sub

End Class