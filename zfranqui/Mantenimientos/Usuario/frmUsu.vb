Public Class frmUsu

    Private dUsuario As New clsLnUsuario
    Public Usuario As New clsBeUsuario

    Public Enum TipoTrans
        Nuevo = 1
        Editar = 2
    End Enum

    Private Property Modo As TipoTrans

    Sub New(ByVal pModo As TipoTrans)

        InitializeComponent()
        Modo = pModo

    End Sub

    Private Sub frmUsu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            dUsuario.Listar_Roles(cmbRol)

            Select Case Modo

                Case TipoTrans.Nuevo

                    Usuario.IdUsuario = dUsuario.Generar_Nuevo_IdUsuario()

                    Me.IdUsuarioSpinEdit.Value = Usuario.IdUsuario
                    Me.IdUsuarioSpinEdit.Enabled = False

                    User_agrTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_agrDateEdit.Text = Now.ToShortDateString

                    User_modTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_modDateEdit.Text = Now.ToShortDateString

                    mnuGuardar.Enabled = True
                    mnuActualizar.Enabled = False
                    mnuEliminar.Enabled = False

                Case TipoTrans.Editar

                    dUsuario.Obtener(Usuario)

                    NombresTextEdit.Text = Usuario.Nombre
                    CodigoTextEdit.Text = Usuario.Codigo
                    ClaveTextEdit.Text = Usuario.Clave

                    IdUsuarioSpinEdit.Text = Usuario.IdUsuario

                    cmbRol.SelectedValue = Usuario.IdRol

                    Ultimo_loginDateEdit.Text = Usuario.Ultimo_login.ToShortDateString
                    chkActivo.Checked = CBool(IIf(Usuario.Activo = 1, True, False))

                    'Bitácora Franquiciado
                    Dim UserBitacora As New clsBeUsuario
                    UserBitacora.IdUsuario = Usuario.User_agr
                    gdUsuario.Obtener(UserBitacora)

                    'Usuario agregó
                    User_agrTextEdit.Text = UserBitacora.Codigo
                    Fec_agrDateEdit.Text = Usuario.Fec_agr.ToShortDateString

                    'Usuario modificó
                    UserBitacora.IdUsuario = Usuario.User_mod
                    gdUsuario.Obtener(UserBitacora)

                    User_modTextEdit.Text = UserBitacora.Codigo
                    Fec_modDateEdit.Text = Usuario.Fec_mod.ToShortDateString
                    'Fin Bitácora

                    mnuGuardar.Enabled = False
                    mnuActualizar.Enabled = True
                    mnuEliminar.Enabled = True


            End Select

            NombresTextEdit.Focus()

            Application.DoEvents()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function Guardar() As Boolean

        Guardar = False

        Try


            Usuario.Nombre = NombresTextEdit.Text
            Usuario.Codigo = CodigoTextEdit.Text
            Usuario.Clave = ClaveTextEdit.Text
            Usuario.Activo = Integer.Parse(IIf(chkActivo.Checked, 1, 0).ToString)
            Usuario.IdRol = Integer.Parse(cmbRol.SelectedValue.ToString)

            Usuario.User_mod = gUsuario.IdUsuario.ToString
            Usuario.User_agr = gUsuario.IdUsuario.ToString

            Guardar = dUsuario.Insertar(Usuario) > 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Function Actualizar() As Boolean

        Actualizar = False

        Try

            If Datos_Correctos() Then

                Usuario.Nombre = NombresTextEdit.Text
                Usuario.Codigo = CodigoTextEdit.Text
                Usuario.Clave = ClaveTextEdit.Text
                Usuario.Activo = Integer.Parse(IIf(chkActivo.Checked, 1, 0).ToString)
                Usuario.User_mod = gUsuario.IdUsuario.ToString
                Usuario.Fec_mod = Now
                Usuario.IdRol = Integer.Parse(cmbRol.SelectedValue)

                Actualizar = dUsuario.Actualizar(Usuario) > 0

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


    Private Sub mnuGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuGuardar.ItemClick
        If Datos_Correctos() Then
            If MsgBox("¿Guardar usuario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
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

            If NombresTextEdit.Text.Trim = "" Then
                MsgBox("Ingrese nombre", MsgBoxStyle.Exclamation, Me.Text)
                NombresTextEdit.Focus()
            ElseIf CodigoTextEdit.Text.Trim = "" Then
                MsgBox("Ingrese código de acceso del usuario", MsgBoxStyle.Exclamation, Me.Text)
                CodigoTextEdit.Focus()
            ElseIf ClaveTextEdit.Text.Trim = "" Then
                MsgBox("Ingrese clave de usuario", MsgBoxStyle.Exclamation, Me.Text)
                ClaveTextEdit.Focus()
            ElseIf ClaveTextEdit.Text <> ConfirmarClaveTextEdit.Text Then
                MsgBox("Las claves no coinciden", MsgBoxStyle.Exclamation, Me.Text)
                ClaveTextEdit.Focus()
            Else
                Datos_Correctos = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub mnuEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuEliminar.ItemClick

        If CBool(MsgBox("¿Desactivar el usuario?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes) Then
            If dUsuario.Eliminar(Usuario) > 0 Then
                MsgBox("Se ha eliminado el registro", MsgBoxStyle.Information, Me.Text)
                Me.Close()
            End If
        End If

    End Sub

End Class