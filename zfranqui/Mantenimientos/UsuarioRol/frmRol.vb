Public Class frmRol

    Private dRol As New clsLnRol
    Public Rol As New clsBeRol

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

            Select Case Modo

                Case TipoTrans.Nuevo

                    Rol.IdRol = dRol.Generar_Nuevo_IdRol()

                    Me.txtIdRol.Value = Rol.IdRol
                    Me.txtIdRol.Enabled = False


                    User_agrTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_agrDateEdit.Text = Now.ToShortDateString

                    User_modTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_modDateEdit.Text = Now.ToShortDateString

                    mnuGuardar.Enabled = True
                    mnuActualizar.Enabled = False
                    mnuEliminar.Enabled = False

                    dRol.CargaMenuRol(lvMenuRol, Integer.Parse(txtIdRol.Text.ToString))
                    dRol.CargaMenuSistema(lvMenuSistema)

                Case TipoTrans.Editar

                    dRol.Obtener(Rol)

                    txtNombreRol.Text = Rol.Nombre
                    txtIdRol.Text = Rol.IdRol.ToString

                    dRol.CargaMenuRol(lvMenuRol, Integer.Parse(txtIdRol.Text.ToString))
                    dRol.CargaMenuSistema(lvMenuSistema)

                    chkActivo.Checked = CBool(IIf(Rol.Activo = 1, True, False))

                    User_agrTextEdit.Text = Rol.User_agr.ToString
                    Fec_agrDateEdit.Text = Rol.Fec_agr.ToShortDateString
                    User_modTextEdit.Text = Rol.User_mod.ToString
                    Fec_modDateEdit.Text = Rol.Fec_mod.ToShortDateString

                    mnuGuardar.Enabled = False
                    mnuActualizar.Enabled = True
                    mnuEliminar.Enabled = True


            End Select

            txtNombreRol.Focus()

            Application.DoEvents()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function Guardar() As Boolean

        Guardar = False

        Try


            Rol.Nombre = txtNombreRol.Text
            Rol.Activo = Integer.Parse(IIf(chkActivo.Checked, 1, 0).ToString)
            Rol.IdRol = Integer.Parse(txtIdRol.Text.ToString)

            Rol.User_mod = Integer.Parse(gUsuario.IdRol.ToString)
            Rol.User_agr = Integer.Parse(gUsuario.IdRol.ToString)

            Guardar = dRol.Insertar(Rol) > 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Function Actualizar() As Boolean

        Actualizar = False

        Try

            If Datos_Correctos() Then

                Rol.Nombre = txtNombreRol.Text
                Rol.Activo = Integer.Parse(IIf(chkActivo.Checked, 1, 0).ToString)
                Rol.User_mod = gUsuario.IdUsuario
                Rol.Fec_mod = Now
                Rol.IdRol = Integer.Parse(txtIdRol.Text.ToString)

                Actualizar = dRol.Actualizar(Rol) > 0

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


    Private Sub mnuGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuGuardar.ItemClick
        If Datos_Correctos() Then
            If MsgBox("¿Guardar Rol?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
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

            If txtNombreRol.Text.Trim = "" Then
                MsgBox("Ingrese nombre", MsgBoxStyle.Exclamation, Me.Text)
                txtNombreRol.Focus()          
            Else
                Datos_Correctos = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub mnuEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuEliminar.ItemClick

        If CBool(MsgBox("¿Desactivar el Rol?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes) Then
            If dRol.Eliminar(Rol) > 0 Then
                MsgBox("Se ha eliminado el registro", MsgBoxStyle.Information, Me.Text)
                Me.Close()
            End If
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        Try

            For Each m As ListViewItem In lvMenuSistema.Items
                m.Checked = (CheckBox1.Checked = True)
            Next

            Application.DoEvents()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Try
            For Each m As ListViewItem In lvMenuRol.Items
                m.Checked = (CheckBox2.Checked = True)
            Next
            Application.DoEvents()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click

        Dim I As Integer, vMenuID$

        Try

            prg.Visible = True

            prg.Maximum = lvMenuSistema.Items.Count

            For I = 0 To lvMenuSistema.Items.Count - 1

                If (lvMenuSistema.Items(I).Checked) Then

                    vMenuID$ = lvMenuSistema.Items(I).SubItems(1).Text

                    If Not dRol.ExisteOpcion(vMenuID$, CInt(txtIdRol.Text)) Then
                        dRol.Inserta_MenuRol(vMenuID$, CInt(txtIdRol.Text))
                    Else
                        dRol.Actualiza_MenuRol(vMenuID$, CInt(txtIdRol.Text))
                    End If

                    prg.Value = I

                End If

                Application.DoEvents()

            Next I

            dRol.CargaMenuRol(lvMenuRol, Integer.Parse(txtIdRol.Text.ToString))

            MsgBox("Permisos actualizados", MsgBoxStyle.Information, Me.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            prg.Visible = False
        End Try

    End Sub

    Private Sub cmdQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitar.Click

        Dim I As Integer, vMenuID$

        Try

            prg.Visible = True
            prg.Maximum = lvMenuRol.Items.Count

            For I = 0 To lvMenuRol.Items.Count - 1

                If lvMenuRol.Items(I).Checked = True Then

                    vMenuID$ = lvMenuRol.Items(I).SubItems(1).Text

                    lvMenuRol.Items(I).Checked = (CheckBox2.Checked = True)

                    dRol.Elimina_MenuRol(vMenuID, CInt(txtIdRol.Text.ToString))

                    Application.DoEvents()

                    prg.Value = I

                End If

            Next

            dRol.CargaMenuRol(lvMenuRol, CInt(txtIdRol.Text.ToString))

            MsgBox("Se han desactivado las opciones", MsgBoxStyle.Information, Me.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            prg.Visible = False
        End Try

    End Sub

    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl1.Paint

    End Sub
End Class