Public Class frmSupervisor

    Private dSup As New clsLnCefsupervisor
    Public Sup As New clsBeCefsupervisor

    Public Enum TipoTrans
        Nuevo = 1
        Editar = 2
    End Enum

    Private Property Modo As TipoTrans

    Sub New(ByVal pModo As TipoTrans)

        InitializeComponent()
        Modo = pModo

    End Sub

    Private Sub frmSupervisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Select Case Modo

                Case TipoTrans.Nuevo

                    Sup.IdSupervisor = dSup.Generar_Nuevo_IdSupervisor()

                    Me.txtIdSupervisor.Value = Sup.IdSupervisor
                    Me.txtIdSupervisor.Enabled = False

                    User_agrTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_agrDateEdit.Text = Now.ToShortDateString

                    User_modTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_modDateEdit.Text = Now.ToShortDateString

                    mnuGuardar.Enabled = True
                    mnuActualizar.Enabled = False
                    mnuEliminar.Enabled = False

                Case TipoTrans.Editar

                    dSup.Obtener(Sup)

                    txtNomSupervisor.Text = Sup.Nombre
                    txtIdSupervisor.Text = Sup.IdSupervisor
                    txtCodigo.Text = Sup.Codigo

                    'Bitácora Franquiciado
                    Dim UserBitacora As New clsBeUsuario
                    UserBitacora.IdUsuario = Sup.User_agr
                    gdUsuario.Obtener(UserBitacora)

                    'Usuario agregó
                    User_agrTextEdit.Text = UserBitacora.Codigo
                    Fec_agrDateEdit.Text = Sup.Fec_agr.ToShortDateString

                    'Usuario modificó
                    UserBitacora.IdUsuario = Sup.User_mod
                    gdUsuario.Obtener(UserBitacora)

                    User_modTextEdit.Text = UserBitacora.Codigo
                    Fec_modDateEdit.Text = Sup.Fec_mod.ToShortDateString
                    'Fin Bitácora

                    mnuGuardar.Enabled = False
                    mnuActualizar.Enabled = True
                    mnuEliminar.Enabled = True

            End Select

            txtNomSupervisor.Focus()

            Application.DoEvents()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function Guardar() As Boolean

        Guardar = False

        Try

            Sup.Nombre = txtNomSupervisor.Text
            Sup.Codigo = Me.txtCodigo.Text
            Sup.IdSupervisor = Me.txtIdSupervisor.Text

            Sup.User_mod = gUsuario.IdUsuario.ToString
            Sup.User_agr = gUsuario.IdUsuario.ToString

            Guardar = dSup.Insertar(Sup) > 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Function Actualizar() As Boolean

        Actualizar = False

        Try

            If Datos_Correctos() Then

                Sup.Nombre = txtNomSupervisor.Text
                Sup.User_mod = gUsuario.IdUsuario.ToString
                Sup.Fec_mod = Now
                Sup.Codigo = Me.txtCodigo.Text
                Sup.IdSupervisor = txtIdSupervisor.Text

                Actualizar = dSup.Actualizar(Sup) > 0

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub mnuGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuGuardar.ItemClick
        If Datos_Correctos() Then
            If MsgBox("¿Guardar Supervisor?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
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

            If txtNomSupervisor.Text.Trim = "" Then
                MsgBox("Ingrese nombre", MsgBoxStyle.Exclamation, Me.Text)
                txtNomSupervisor.Focus()
            ElseIf dSup.Existe_Codigo(txtCodigo.Text, txtIdSupervisor.Text) Then
                MsgBox("El código ingresado ya existe", MsgBoxStyle.Exclamation, Me.Text)
                txtCodigo.Focus()
            Else
                Datos_Correctos = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub mnuEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuEliminar.ItemClick

        If CBool(MsgBox("¿Desactivar el usuario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes) Then
            If dSup.Eliminar(Sup) > 0 Then
                MsgBox("Se ha eliminado el registro", MsgBoxStyle.Information, Me.Text)
                Me.Close()
            End If
        End If

    End Sub

End Class