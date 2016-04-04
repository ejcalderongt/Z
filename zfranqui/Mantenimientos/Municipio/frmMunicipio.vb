Public Class frmMunicipio

    Private dMuni As New clsLnMunicipio
    Public Muni As New clsBeMunicipio

    Private Depto As New clsBeDepartamento
    Private dDepto As New clsLnDepartamento

    Public Enum TipoTrans
        Nuevo = 1
        Editar = 2
    End Enum

    Private Property Modo As TipoTrans

    Sub New(ByVal pModo As TipoTrans)

        InitializeComponent()
        Modo = pModo

    End Sub

    Private Sub frmMunicipio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            cmbDepartamento.DataSource = dDepto.Listar()
            cmbDepartamento.DisplayMember = "Nombre"
            cmbDepartamento.ValueMember = "IdDepartamento"

            Select Case Modo

                Case TipoTrans.Nuevo

                    Me.txtIdMunicipio.Value = Muni.IdMunicipio
                    Me.txtIdMunicipio.Enabled = False

                    User_agrTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_agrDateEdit.Text = Now.ToShortDateString

                    User_modTextEdit.Text = gUsuario.Codigo.ToString
                    Fec_modDateEdit.Text = Now.ToShortDateString

                    Try
                        Muni.IdMunicipio = dMuni.Generar_Nuevo_IdMunicipio(cmbDepartamento.SelectedValue)
                        txtIdMunicipio.Text = Muni.IdMunicipio
                    Catch ex As Exception

                    End Try


                    mnuGuardar.Enabled = True
                    mnuActualizar.Enabled = False
                    mnuEliminar.Enabled = False

                Case TipoTrans.Editar

                    dMuni.Obtener(Muni)

                    txtNomMunicipio.Text = Muni.Nombre
                    txtIdMunicipio.Text = Muni.IdMunicipio
                    cmbDepartamento.SelectedValue = Muni.IdDepartamento
                    cmbDepartamento.Enabled = False

                    'Bitácora Franquiciado
                    Dim UserBitacora As New clsBeUsuario
                    UserBitacora.IdUsuario = Muni.User_agr
                    gdUsuario.Obtener(UserBitacora)

                    'Usuario agregó
                    User_agrTextEdit.Text = UserBitacora.Codigo
                    Fec_agrDateEdit.Text = Muni.Fec_agr.ToShortDateString

                    'Usuario modificó
                    UserBitacora.IdUsuario = Muni.User_mod
                    gdUsuario.Obtener(UserBitacora)

                    User_modTextEdit.Text = UserBitacora.Codigo
                    Fec_modDateEdit.Text = Muni.Fec_mod.ToShortDateString
                    'Fin Bitácora

                    mnuGuardar.Enabled = False
                    mnuActualizar.Enabled = True
                    mnuEliminar.Enabled = True

            End Select

            txtNomMunicipio.Focus()

            Application.DoEvents()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function Guardar() As Boolean

        Guardar = False

        Try


            Muni.Nombre = txtNomMunicipio.Text
            Muni.IdMunicipio = Me.txtIdMunicipio.Text
            Muni.IdDepartamento = cmbDepartamento.SelectedValue

            Muni.User_mod = gUsuario.IdUsuario.ToString
            Muni.User_agr = gUsuario.IdUsuario.ToString

            Guardar = dMuni.Insertar(Muni) > 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Function Actualizar() As Boolean

        Actualizar = False

        Try

            If Datos_Correctos() Then

                Muni.Nombre = txtNomMunicipio.Text
                Muni.IdDepartamento = cmbDepartamento.SelectedValue

                Muni.User_mod = gUsuario.IdUsuario.ToString
                Muni.Fec_mod = Now
                Muni.IdMunicipio = txtIdMunicipio.Text

                Actualizar = dMuni.Actualizar(Muni) > 0

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


    Private Sub mnuGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuGuardar.ItemClick
        If Datos_Correctos() Then
            If MsgBox("¿Guardar Municipio?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
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

            If txtNomMunicipio.Text.Trim = "" Then
                MsgBox("Ingrese nombre", MsgBoxStyle.Exclamation, Me.Text)
                txtNomMunicipio.Focus()
            Else
                Datos_Correctos = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub mnuEliminar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuEliminar.ItemClick

        If CBool(MsgBox("¿Eliminar el municipio?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes) Then
            If dMuni.Eliminar(Muni) > 0 Then
                MsgBox("Se ha eliminado el registro", MsgBoxStyle.Information, Me.Text)
                Me.Close()
            End If
        End If

    End Sub

    Private Sub cmbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepartamento.SelectedIndexChanged

        Try

            If Modo = TipoTrans.Nuevo Then
                Muni.IdDepartamento = cmbDepartamento.SelectedValue
                Muni.IdMunicipio = dMuni.Generar_Nuevo_IdMunicipio(Muni.IdDepartamento)
                txtIdMunicipio.Text = Muni.IdMunicipio
            End If

        Catch ex As Exception

        End Try
        

    End Sub

End Class