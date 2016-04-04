Public Class frmDepartamento

    Private dDepto As New clsLnDepartamento
    Public Depto As New clsBeDepartamento

    Public Enum TipoTrans
        Nuevo = 1
        Editar = 2
    End Enum

    Private Property Modo As TipoTrans

    Sub New(ByVal pModo As TipoTrans)

        InitializeComponent()
        Modo = pModo

    End Sub

    Private Sub frmDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Select Case Modo

                Case TipoTrans.Nuevo

                    Depto.IdDepartamento = dDepto.Generar_Nuevo_IdDepartamento()

                    Me.txtIdDepartamento.Value = Depto.IdDepartamento
                    Me.txtIdDepartamento.Enabled = False

                    User_agrTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_agrDateEdit.Text = Now.ToShortDateString

                    User_modTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_modDateEdit.Text = Now.ToShortDateString

                    mnuGuardar.Enabled = True
                    mnuActualizar.Enabled = False
                    mnuEliminar.Enabled = False

                Case TipoTrans.Editar

                    dDepto.Obtener(Depto)

                    txtNomDepto.Text = Depto.Nombre
                    txtIdDepartamento.Text = Depto.IdDepartamento

                    'Bitácora
                    Dim UserBitacora As New clsBeUsuario
                    UserBitacora.IdUsuario = Depto.User_agr
                    gdUsuario.Obtener(UserBitacora)

                    'Usuario agregó
                    User_agrTextEdit.Text = UserBitacora.Codigo
                    Fec_agrDateEdit.Text = Depto.Fec_agr.ToShortDateString

                    'Usuario modificó
                    UserBitacora.IdUsuario = Depto.User_mod
                    gdUsuario.Obtener(UserBitacora)

                    User_modTextEdit.Text = UserBitacora.Codigo
                    Fec_modDateEdit.Text = Depto.Fec_mod.ToShortDateString
                    'Fin Bitácora

                    mnuGuardar.Enabled = False
                    mnuActualizar.Enabled = True
                    mnuEliminar.Enabled = True

            End Select

            txtNomDepto.Focus()

            Application.DoEvents()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Function Guardar() As Boolean

        Guardar = False

        Try


            Depto.Nombre = txtNomDepto.Text
            Depto.IdDepartamento = Me.txtIdDepartamento.Text

            Depto.User_mod = gUsuario.IdUsuario.ToString
            Depto.User_agr = gUsuario.IdUsuario.ToString

            Guardar = dDepto.Insertar(Depto) > 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Function Actualizar() As Boolean

        Actualizar = False

        Try

            If Datos_Correctos() Then

                Depto.Nombre = txtNomDepto.Text
                Depto.User_mod = gUsuario.IdUsuario.ToString
                Depto.Fec_mod = Now
                Depto.IdDepartamento = txtIdDepartamento.Text

                Actualizar = dDepto.Actualizar(Depto) > 0

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


    Private Sub mnuGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuGuardar.ItemClick
        If Datos_Correctos() Then
            If MsgBox("¿Guardar departamento?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
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

            If txtNomDepto.Text.Trim = "" Then
                MsgBox("Ingrese nombre", MsgBoxStyle.Exclamation, Me.Text)
                txtNomDepto.Focus()
            Else
                Datos_Correctos = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub mnuEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuEliminar.ItemClick

        If CBool(MsgBox("¿Eliminar el departamento?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes) Then
            If dDepto.Eliminar(Depto) > 0 Then
                MsgBox("Se ha eliminado el registro", MsgBoxStyle.Information, Me.Text)
                Me.Close()
            End If
        End If

    End Sub

End Class