Public Class frmRegion

    Private dRegion As New clsLnCefregion
    Public pRegion As New clsBeCefregion

    Public Enum TipoTrans
        Nuevo = 1
        Editar = 2
    End Enum

    Private Property Modo As TipoTrans

    Sub New(ByVal pModo As TipoTrans)

        InitializeComponent()
        Modo = pModo

    End Sub

    Private Sub frmRegión_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Select Case Modo

                Case TipoTrans.Nuevo

                    pRegion.IdRegion = dRegion.Generar_Nuevo_IdRegion()

                    Me.txtIdRegion.Value = pRegion.IdRegion
                    Me.txtIdRegion.Enabled = False

                    User_agrTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_agrDateEdit.Text = Now.ToShortDateString

                    User_modTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_modDateEdit.Text = Now.ToShortDateString

                    mnuGuardar.Enabled = True
                    mnuActualizar.Enabled = False
                    mnuEliminar.Enabled = False

                Case TipoTrans.Editar

                    dRegion.Obtener(pRegion)

                    txtNomRegion.Text = pRegion.Nombre
                    txtIdRegion.Text = pRegion.IdRegion

                    'Bitácora Franquiciado
                    Dim UserBitacora As New clsBeUsuario
                    UserBitacora.IdUsuario = pRegion.User_agr
                    gdUsuario.Obtener(UserBitacora)

                    'Usuario agregó
                    User_agrTextEdit.Text = UserBitacora.Codigo
                    Fec_agrDateEdit.Text = pRegion.Fec_agr.ToShortDateString

                    'Usuario modificó
                    UserBitacora.IdUsuario = pRegion.User_mod
                    gdUsuario.Obtener(UserBitacora)

                    User_modTextEdit.Text = UserBitacora.Codigo
                    Fec_modDateEdit.Text = pRegion.Fec_mod.ToShortDateString
                    'Fin Bitácora

                    mnuGuardar.Enabled = False
                    mnuActualizar.Enabled = True
                    mnuEliminar.Enabled = True

            End Select

            txtNomRegion.Focus()

            Application.DoEvents()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function Guardar() As Boolean

        Guardar = False

        Try

            pRegion.Nombre = txtNomRegion.Text
            pRegion.IdRegion = Me.txtIdRegion.Text

            pRegion.User_mod = gUsuario.IdUsuario.ToString
            pRegion.User_agr = gUsuario.IdUsuario.ToString

            Guardar = dRegion.Insertar(pRegion) > 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Function Actualizar() As Boolean

        Actualizar = False

        Try

            If Datos_Correctos() Then

                pRegion.Nombre = txtNomRegion.Text
                pRegion.User_mod = gUsuario.IdUsuario.ToString
                pRegion.Fec_mod = Now
                pRegion.IdRegion = txtIdRegion.Text

                Actualizar = dRegion.Actualizar(pRegion) > 0

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub mnuGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuGuardar.ItemClick
        If Datos_Correctos() Then
            If MsgBox("¿Guardar Región?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
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

            If txtNomRegion.Text.Trim = "" Then
                MsgBox("Ingrese nombre", MsgBoxStyle.Exclamation, Me.Text)
                txtNomRegion.Focus()
            Else
                Datos_Correctos = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub mnuEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuEliminar.ItemClick

        If CBool(MsgBox("¿Eliminar Región?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes) Then
            If dRegion.Eliminar(pRegion) > 0 Then
                MsgBox("Se ha eliminado el registro", MsgBoxStyle.Information, Me.Text)
                Me.Close()
            End If
        End If

    End Sub

End Class