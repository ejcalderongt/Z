Public Class frmPeriodoDescuento

    Private dPerDes As New clsLnPeriodo_descuento
    Public PerDes As New clsBePeriodo_descuento

    Public Enum TipoTrans
        Nuevo = 1
        Editar = 2
    End Enum

    Private Property Modo As TipoTrans

    Sub New(ByVal pModo As TipoTrans)

        InitializeComponent()
        Modo = pModo

    End Sub

    Private Sub frmPeriodoDescuento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Select Case Modo

                Case TipoTrans.Nuevo

                    PerDes.IdPeriodo = dPerDes.Generar_Nuevo_IdPeriodoBeneficio()

                    Me.txtIdPeriodo.Value = PerDes.IdPeriodo
                    Me.txtIdPeriodo.Enabled = False

                    User_agrTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_agrDateEdit.Text = Now.ToShortDateString

                    User_modTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_modDateEdit.Text = Now.ToShortDateString

                    mnuGuardar.Enabled = True
                    mnuActualizar.Enabled = False
                    mnuEliminar.Enabled = False

                Case TipoTrans.Editar

                    dPerDes.Obtener(PerDes)

                    txtNomPeriodo.Text = PerDes.Nombre
                    txtIdPeriodo.Text = PerDes.IdPeriodo
                    txtNoDias.Value = PerDes.Dias

                    'Bitácora
                    Dim UserBitacora As New clsBeUsuario
                    UserBitacora.IdUsuario = PerDes.User_agr
                    gdUsuario.Obtener(UserBitacora)

                    'Usuario agregó
                    User_agrTextEdit.Text = UserBitacora.Codigo
                    Fec_agrDateEdit.Text = PerDes.Fec_agr.ToShortDateString

                    'Usuario modificó
                    UserBitacora.IdUsuario = PerDes.User_mod
                    gdUsuario.Obtener(UserBitacora)

                    User_modTextEdit.Text = UserBitacora.Codigo
                    Fec_modDateEdit.Text = PerDes.Fec_mod.ToShortDateString
                    'Fin Bitácora

                    mnuGuardar.Enabled = False
                    mnuActualizar.Enabled = True
                    mnuEliminar.Enabled = True

            End Select

            txtNomPeriodo.Focus()

            Application.DoEvents()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function Guardar() As Boolean

        Guardar = False

        Try


            PerDes.Nombre = txtNomPeriodo.Text
            PerDes.Dias = txtNoDias.Value
            PerDes.IdPeriodo = Me.txtIdPeriodo.Text

            PerDes.User_mod = gUsuario.IdUsuario.ToString
            PerDes.User_agr = gUsuario.IdUsuario.ToString

            Guardar = dPerDes.Insertar(PerDes) > 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Function Actualizar() As Boolean

        Actualizar = False

        Try

            If Datos_Correctos() Then

                PerDes.Nombre = txtNomPeriodo.Text
                PerDes.Dias = txtNoDias.Value
                PerDes.User_mod = gUsuario.IdUsuario.ToString
                PerDes.Fec_mod = Now
                PerDes.IdPeriodo = txtIdPeriodo.Text

                Actualizar = dPerDes.Actualizar(PerDes) > 0

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


    Private Sub mnuGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuGuardar.ItemClick
        If Datos_Correctos() Then
            If MsgBox("¿Guardar Periodo Descuento?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
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

            If txtNomPeriodo.Text.Trim = "" Then
                MsgBox("Ingrese nombre", MsgBoxStyle.Exclamation, Me.Text)
                txtNomPeriodo.Focus()
            ElseIf txtNoDias.Value = 0 Then
                MsgBox("Ingrese cantidad de días para generación de cobros", MsgBoxStyle.Exclamation, Me.Text)
                txtNoDias.Focus()
            Else
                Datos_Correctos = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub mnuEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuEliminar.ItemClick

        If CBool(MsgBox("¿Eliminar el PeriodoDescuento?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes) Then
            If dPerDes.Eliminar(PerDes) > 0 Then
                MsgBox("Se ha eliminado el registro", MsgBoxStyle.Information, Me.Text)
                Me.Close()
            End If
        End If

    End Sub

End Class