Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports zfranqui.frmUsuList.pModo

Public Class frmMenu

    Public Property IpAdress As String = ""

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            GetIPAddress()

            'DesactivarMenu()

            HabilitarMenuRol()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GetIPAddress()

        Try

            HostName = System.Net.Dns.GetHostName()

            IpAdress = HostName

            lblNomPCCliente.Caption = HostName

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuRoles_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuRoles.ItemClick

        Try

            With frmRolList
                .Modo = frmRolList.pModo.Lista
                .MdiParent = Me
                .Show()
                .Focus()
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuUsuarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuUsuarios.ItemClick

        With frmUsuList
            .Modo = frmUsuList.pModo.Lista
            .MdiParent = Me
            .Show()
            .Focus()
        End With

    End Sub

    Private Sub DesactivarMenu()

        Try

            Dim mCurrentItem As BarItem
            Dim mBarSubItem As BarSubItem
            Dim mSubLink As BarItemLink

            For Each currentPage As RibbonPage In Me.rbMain.Pages

                For Each currentGroup As RibbonPageGroup In currentPage.Groups

                    currentGroup.Enabled = False

                    For Each currenLink As BarItemLink In currentGroup.ItemLinks

                        mCurrentItem = currenLink.Item

                        currenLink.Item.Enabled = False

                        Debug.Print(currentPage.Text & " - " & currentGroup.Text & " - " & mCurrentItem.Caption & " - " & mCurrentItem.Name & " - " & mCurrentItem.GetType.FullName)

                        If mCurrentItem.GetType.FullName = "DevExpress.XtraBars.BarSubItem" Then

                            mBarSubItem = mCurrentItem

                            For Each mSubLink In mBarSubItem.ItemLinks

                                mSubLink.Item.Enabled = False

                                Debug.Print(currentPage.Text & " - " & currentGroup.Text & " - " & mSubLink.Item.Caption & " - " & mSubLink.Item.Name & " - " & mSubLink.Item.GetType.FullName)
                            Next

                        End If

                    Next currenLink

                Next currentGroup

            Next currentPage

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub HabilitarMenuRol()

        Dim mCurrentItem As BarItem
        Dim mBarSubItem As BarSubItem
        Dim mSubLink As BarItemLink

        ' Este procedimiento verifica que cada item del menu 
        ' esté disponible para el usuario que se ha logeado
        Dim DT As New DataTable, I As Integer
        Dim vMenu As String
        Dim vHabilitar As Boolean

        Try

            ' Habilita las opciones asignadas al rol
            vSQL$ = "select  a.nombremenu as titulo, b.visible, a.nivel from menu a, menurol b " & _
            " where a.idmenu = b.idmenu " & _
            " and b.idrol = " & gUsuario.IdRol & " and b.visible = 1 order by a.nivel"
            BD.OpenDT(DT, vSQL$)

            ' Nivel 1
            For I = 0 To DT.Rows.Count - 1
                vMenu$ = DT.Rows(I).Item("titulo").ToString
                vHabilitar = (DT.Rows(I).Item("visible").ToString = "1")
                For Each currentPage As RibbonPage In Me.rbMain.Pages
                    If currentPage.Text = vMenu$ Then
                        currentPage.Visible = vHabilitar
                    End If
                Next                
            Next I

            ' Nivel 2
            For I = 0 To DT.Rows.Count - 1

                vMenu$ = DT.Rows(I).Item("titulo").ToString
                vHabilitar = (DT.Rows(I).Item("visible").ToString = "1")

                For Each currentPage As RibbonPage In Me.rbMain.Pages
                    For Each currentGroup As RibbonPageGroup In currentPage.Groups
                        If currentGroup.Text = vMenu$ Then
                            currentGroup.Visible = vHabilitar
                        End If
                    Next                    
                Next

            Next I

            ' Nivel 3
            For I = 0 To DT.Rows.Count - 1

                vMenu$ = DT.Rows(I).Item("titulo").ToString
                vHabilitar = (DT.Rows(I).Item("visible").ToString = "1")

                 For Each currentPage As RibbonPage In Me.rbMain.Pages
                    For Each currentGroup As RibbonPageGroup In currentPage.Groups
                        For Each currenLink As BarItemLink In currentGroup.ItemLinks
                            If currenLink.Item.Caption = vMenu$ Then
                                currenLink.Visible = vHabilitar
                            End If
                        Next
                    Next
                Next

            Next I


            ' Nivel 4
            For I = 0 To DT.Rows.Count - 1

                vMenu$ = DT.Rows(I).Item("titulo").ToString
                vHabilitar = (DT.Rows(I).Item("visible").ToString = "1")

                For Each currentPage As RibbonPage In Me.rbMain.Pages
                    For Each currentGroup As RibbonPageGroup In currentPage.Groups
                        For Each currenLink As BarItemLink In currentGroup.ItemLinks
                            mCurrentItem = currenLink.Item
                            If mCurrentItem.GetType.FullName = "DevExpress.XtraBars.BarSubItem" Then
                                mBarSubItem = mCurrentItem
                                For Each mSubLink In mBarSubItem.ItemLinks
                                    If mSubLink.Item.Caption = vMenu$ Then
                                        mSubLink.Visible = vHabilitar
                                    End If
                                Next
                            End If
                        Next
                    Next
                Next

            Next I

            DT.Dispose()            

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        DesactivarMenu()
    End Sub

    Private Sub mnuDepartamento_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuDepartamento.ItemClick

        Inserta_Bitacora_Acceso_Menu(frmDepartamentoList.Text)

        With frmDepartamentoList
            .Modo = frmDepartamentoList.pModo.Lista
            .MdiParent = Me
            .Show()
            .Focus()
        End With

    End Sub

    Private Sub mnuMunicipio_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuMunicipio.ItemClick

        Inserta_Bitacora_Acceso_Menu(frmMunicipioList.Text)

        With frmMunicipioList
            .Modo = frmMunicipioList.pModo.Lista
            .MdiParent = Me
            .Show()
            .Focus()
        End With

    End Sub

    Private Sub mnuRegion_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuRegion.ItemClick

        Inserta_Bitacora_Acceso_Menu(frmRegionList.Text)

        With frmRegionList
            .Modo = frmRegionList.pModo.Lista
            .MdiParent = Me
            .Show()
            .Focus()
        End With

    End Sub

    Private Sub mnuSupervisor_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuSupervisor.ItemClick

        Inserta_Bitacora_Acceso_Menu(frmSupervisorList.Text)

        With frmSupervisorList
            .Modo = frmSupervisorList.pModo.Lista
            .MdiParent = Me
            .Show()
            .Focus()
        End With

    End Sub

    Private Sub mnuCEF_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuCEF.ItemClick

        Inserta_Bitacora_Acceso_Menu(frmCEFList.Text)

        With frmCEFList
            .Modo = frmCEFList.pModo.Lista
            .MdiParent = Me
            .Show()
            .Focus()
        End With

    End Sub

    Private Sub mnuBancoItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuBanco.ItemClick

        Inserta_Bitacora_Acceso_Menu(frmBancoList.Text)

        With frmBancoList
            .Modo = frmBancoList.pModo.Lista
            .MdiParent = Me
            .Show()
            .Focus()
        End With

    End Sub

    Private Sub mnuFranquiciado_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuFranquiciado.ItemClick

        Inserta_Bitacora_Acceso_Menu(frmFList.Text)

        With frmFList
            .Modo = frmFList.pModo.Lista
            .MdiParent = Me
            .Show()
            .Focus()
        End With

    End Sub

    Private Sub mnuChanganes_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuChanganes.ItemClick


        Dim Chan As New frmBeneficioList

        With Chan
            .Modo = frmBeneficioList.pModo.Lista
            .TipoBene.EsVehiculo = True
            .TipoBene.IdTipoBeneficio = 1 'Changanes
            .TipoBene.Nombre = "Changanes"
            .TipoBene.EsTelefono = False
            .MdiParent = Me
            .Show()
            .Focus()
        End With

        Inserta_Bitacora_Acceso_Menu(Chan.Text)

    End Sub

    Private Sub mnuMotos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuMotos.ItemClick

        Try

            Dim Motos As New frmBeneficioList

            With Motos
                .Modo = frmBeneficioList.pModo.Lista
                .TipoBene.EsVehiculo = True
                .TipoBene.Nombre = "Motocicletas"
                .TipoBene.IdTipoBeneficio = 2 'Motos
                .TipoBene.EsTelefono = False
                .MdiParent = Me
                .Show()
                .Focus()
            End With

            Inserta_Bitacora_Acceso_Menu(Motos.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

    End Sub

    Private Sub mnuTelefonos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuTelefonos.ItemClick

        Try

            Dim Tel As New frmBeneficioList

            With Tel
                .Modo = frmBeneficioList.pModo.Lista
                .TipoBene.Nombre = "Teléfonos"
                .TipoBene.IdTipoBeneficio = 3 'Teléfonos
                .TipoBene.EsVehiculo = False
                .TipoBene.EsTelefono = True
                .MdiParent = Me
                .Show()
                .Focus()
            End With

            Inserta_Bitacora_Acceso_Menu(Tel.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuFranquicias_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuFranquicias.ItemClick

        Try

            Dim Franqui As New frmBeneficioList

            With frmBeneficioList
                .Modo = frmBeneficioList.pModo.Lista
                .TipoBene.Nombre = "Franquicias"
                .TipoBene.IdTipoBeneficio = 4 'Franquicias
                .TipoBene.EsVehiculo = False
                .TipoBene.EsTelefono = False
                .MdiParent = Me
                .Show()
                .Focus()
            End With

            Inserta_Bitacora_Acceso_Menu(Franqui.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuServicios_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuServicios.ItemClick

        Try

            Dim Servicios As New frmBeneficioList

            With Servicios
                .Modo = frmBeneficioList.pModo.Lista
                .TipoBene.Nombre = "Servicios"
                .TipoBene.IdTipoBeneficio = 5 'Servicios
                .TipoBene.EsVehiculo = False
                .TipoBene.EsTelefono = False
                .MdiParent = Me
                .Show()
                .Focus()
            End With

            Inserta_Bitacora_Acceso_Menu(Servicios.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuPeriodoDescuento_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuPeriodoDescuento.ItemClick

        Try

            With frmPeriodo_DescuentoList
                .Modo = frmPeriodo_DescuentoList.pModo.Lista                
                .MdiParent = Me
                .Show()
                .Focus()
            End With

            Inserta_Bitacora_Acceso_Menu(frmPeriodo_DescuentoList.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuPeriodoDefinido_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuPeriodoDefinido.ItemClick

        Try

            Dim descuentopd As New frmDescuentoList

            With descuentopd
                .Modo = frmDescuentoList.pModo.Lista
                .TipoDescuento = frmDescuentoList.pTipoDescuento.definido
                .MdiParent = Me
                .Show()
                .Focus()
            End With

            Inserta_Bitacora_Acceso_Menu(descuentopd.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        

    End Sub

    Private Sub cmdIndefinido_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdIndefinido.ItemClick

        Try

            Dim descuentopi As New frmDescuentoList

            With descuentopi
                .Modo = frmDescuentoList.pModo.Lista
                .TipoDescuento = frmDescuentoList.pTipoDescuento.indefinido
                .MdiParent = Me
                .Show()
                .Focus()
            End With

            Inserta_Bitacora_Acceso_Menu(descuentopi.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuUnico_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuUnico.ItemClick

        Try

            Dim descuentou As New frmDescuentoList

            With descuentou
                .Modo = frmDescuentoList.pModo.Lista
                .TipoDescuento = frmDescuentoList.pTipoDescuento.unico
                .MdiParent = Me
                .Show()
                .Focus()
            End With

            Inserta_Bitacora_Acceso_Menu(descuentou.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuPagoManual_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuPagoManual.ItemClick

        Try

            Dim PagoList As New frmPagoList

            With PagoList
                .Modo = frmDescuentoList.pModo.Lista                
                .MdiParent = Me
                .Show()
                .Focus()
            End With

            Inserta_Bitacora_Acceso_Menu(frmPagoList.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1.ItemClick

        'Dim Rep As New frmReporteGrid
        'Rep.ShowDialog()
        'Rep.Close()

    End Sub
    Private Sub Inserta_Bitacora_Acceso_Menu(ByVal Opcion As String)

        Try

            Bita = New clsBeBitacora
            Bita.IdUsuario = gUsuario.IdUsuario
            Bita.Modulo = Opcion
            Bita.Accion = "Ingreso"
            Bita.Fecha = Now
            Bita.Observacion = HostName
            nB.Insertar(Bita)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Dim ContadorClicks As Integer = 0
    Private Sub lblNomPCCliente_ItemClick(sender As Object, e As ItemClickEventArgs) Handles lblNomPCCliente.ItemClick

        Try

            ContadorClicks += 1

            If ContadorClicks = 10 Then
                MsgBox("Cadena de conexión actual: " & BD.CadenaConexion)
                ContadorClicks = 0
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub mnuRepDtosPorFranqui_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuRepDtosPorFranqui.ItemClick

        Try

            Dim DescuentosRes As New frmRepDescuentoFran()
            DescuentosRes.ShowDialog()
            DescuentosRes.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuEstadoCuentaDetalle_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuEstadoCuentaDetalle.ItemClick

        Try

            Dim DescuentosDet As New frmRepEstadoCuentaDef()
            DescuentosDet.ShowDialog()
            DescuentosDet.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuRepDescuentosTipo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuRepDescuentosTipo.ItemClick

        Try

            Dim DescuentosDetTipo As New frmRepDescuentoTipoDet()
            DescuentosDetTipo.ShowDialog()
            DescuentosDetTipo.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuRepSaldoVehiculos_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuRepSaldoVehiculos.ItemClick


        Try

            Dim SaldosVehi As New frmRepSaldoVehiculos()
            SaldosVehi.ShowDialog()
            SaldosVehi.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    
    Private Sub mnuRepFranquiciadosCEF_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuRepFranquiciadosCEF.ItemClick

        Try

            Dim FranquixCef As New frmRepFranquiciadosCEF()
            FranquixCef.ShowDialog()
            FranquixCef.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuPagoAuto_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mnuPagoAuto.ItemClick

        Try

            Dim PagoAuto As New frmPagosAutoZ()
            PagoAuto.ShowDialog()
            PagoAuto.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub cmdSupervisor_ItemClick(sender As Object, e As ItemClickEventArgs) Handles cmdSupervisor.ItemClick

        Try

            Dim Supervisor As New frmRepDescuentoFranSupervisor()
            Supervisor.ShowDialog()
            Supervisor.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class