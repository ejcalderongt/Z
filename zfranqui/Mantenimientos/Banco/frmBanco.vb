Public Class frmBanco

    Private dBanco As New clsLnBanco
    Public Banco As New clsBeBanco

    Public Enum TipoTrans
        Nuevo = 1
        Editar = 2
    End Enum

    Private Property Modo As TipoTrans

    Sub New(ByVal pModo As TipoTrans)

        InitializeComponent()
        Modo = pModo

    End Sub

    Private Sub frmBanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Select Case Modo

                Case TipoTrans.Nuevo

                    Banco.IdBanco = dBanco.Generar_Nuevo_IdBanco()

                    Me.txtIdBanco.Value = Banco.IdBanco
                    Me.txtIdBanco.Enabled = False

                    User_agrTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_agrDateEdit.Text = Now.ToShortDateString

                    User_modTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_modDateEdit.Text = Now.ToShortDateString

                    mnuGuardar.Enabled = True
                    mnuActualizar.Enabled = False
                    mnuEliminar.Enabled = False

                Case TipoTrans.Editar

                    dBanco.Obtener(Banco)

                    txtNomBanco.Text = Banco.Nombre
                    txtIdBanco.Text = Banco.IdBanco

                    'Bitácora
                    Dim UserBitacora As New clsBeUsuario
                    UserBitacora.IdUsuario = Banco.User_agr
                    gdUsuario.Obtener(UserBitacora)

                    'Usuario agregó
                    User_agrTextEdit.Text = UserBitacora.Codigo
                    Fec_agrDateEdit.Text = Banco.Fec_agr.ToShortDateString

                    'Usuario modificó
                    UserBitacora.IdUsuario = Banco.User_mod
                    gdUsuario.Obtener(UserBitacora)

                    User_modTextEdit.Text = UserBitacora.Codigo
                    Fec_modDateEdit.Text = Banco.Fec_mod.ToShortDateString
                    'Fin Bitácora

                    mnuGuardar.Enabled = False
                    mnuActualizar.Enabled = True
                    mnuEliminar.Enabled = True

            End Select

            txtNomBanco.Focus()

            Application.DoEvents()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function Guardar() As Boolean

        Guardar = False

        Try

            Banco.Nombre = txtNomBanco.Text
            Banco.IdBanco = Me.txtIdBanco.Text

            Banco.User_mod = gUsuario.IdUsuario.ToString
            Banco.User_agr = gUsuario.IdUsuario.ToString

            Guardar = dBanco.Insertar(Banco) > 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Function Actualizar() As Boolean

        Actualizar = False

        Try

            If Datos_Correctos() Then

                Banco.Nombre = txtNomBanco.Text
                Banco.User_mod = gUsuario.IdUsuario.ToString
                Banco.Fec_mod = Now
                Banco.IdBanco = txtIdBanco.Text

                Actualizar = dBanco.Actualizar(Banco) > 0

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub mnuGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuGuardar.ItemClick
        If Datos_Correctos() Then
            If MsgBox("¿Guardar Banco?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
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

            If txtNomBanco.Text.Trim = "" Then
                MsgBox("Ingrese nombre", MsgBoxStyle.Exclamation, Me.Text)
                txtNomBanco.Focus()
            Else
                Datos_Correctos = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub mnuEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuEliminar.ItemClick

        If CBool(MsgBox("¿Eliminar el Banco?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes) Then
            If dBanco.Eliminar(Banco) > 0 Then
                MsgBox("Se ha eliminado el registro", MsgBoxStyle.Information, Me.Text)
                Me.Close()
            End If
        End If

    End Sub

End Class