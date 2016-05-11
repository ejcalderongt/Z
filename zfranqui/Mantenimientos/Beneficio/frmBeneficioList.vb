Public Class frmBeneficioList

    Private Bene As New clsLnBeneficio

    Public Property TipoBene As New clsBeTipobeneficio

    Public Property Modo As pModo

    Enum pModo
        Lista = 1
        Seleccion = 2
    End Enum

    Private Sub Listar_Beneficios()

        Try

            Me.Text = "Listado de " & TipoBene.Nombre

            Dgrid.DataSource = Nothing
            Dgrid.DataSource = Bene.Listar(TipoBene, txtFiltro.Text, chkAct.Checked)

            If TipoBene.EsVehiculo Then
                GridView1.Columns("NumeroTelefono").Visible = False
                GridView1.Columns("EmpresaTelco").Visible = False
                GridView1.Columns("Nombre").Visible = False
            ElseIf TipoBene.EsTelefono Then
                GridView1.Columns("NoChasis").Visible = False
                GridView1.Columns("NoPlaca").Visible = False
                GridView1.Columns("Modelo").Visible = False
                GridView1.Columns("Motor").Visible = False
                GridView1.Columns("EmpresaTelco").Visible = True
                GridView1.Columns("NumeroTelefono").Visible = True
                GridView1.Columns("Nombre").Visible = False
            Else
                GridView1.Columns("Nombre").Visible = True
                GridView1.Columns("NoChasis").Visible = False
                GridView1.Columns("NoPlaca").Visible = False
                GridView1.Columns("Modelo").Visible = False
                GridView1.Columns("Motor").Visible = False
                GridView1.Columns("EmpresaTelco").Visible = False
                GridView1.Columns("NumeroTelefono").Visible = False
            End If


            lblRegs.Caption = String.Format("Registros: {0}", GridView1.RowCount)

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmBeneficioList_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Listar_Beneficios()
    End Sub

    Private Sub frmBeneficioList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Beneficios()
    End Sub

    Private Sub mnuSalir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuSalir.ItemClick
        Me.Close()
    End Sub

    Private Sub Nuevo_Bene()
        Dim Bene As New frmBeneficio(frmBeneficio.TipoTrans.Nuevo)
        Bene.Bene.TipoBeneficio = TipoBene
        Bene.ShowDialog()
        Bene.Dispose()
    End Sub

    Private Sub mnuNuevo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuNuevo.ItemClick
        Nuevo_Bene() : Listar_Beneficios()
    End Sub

    Private Sub Dgrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgrid.DoubleClick

        Try

            If GridView1.RowCount > 0 Then

                Dim Dr As DataRowView = GridView1.GetFocusedRow

                If Modo = pModo.Lista Then

                    Dim Bene As New frmBeneficio(frmBeneficio.TipoTrans.Editar)
                    Bene.Bene.TipoBeneficio = TipoBene
                    Bene.Bene.IdBeneficio = Integer.Parse(Dr.Item("Codigo").ToString)
                    Bene.ShowDialog()
                    Bene.Dispose()
                    Listar_Beneficios()

                ElseIf Modo = pModo.Seleccion Then
                    Me.Hide()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mnuActualizar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuActualizar.ItemClick
        Listar_Beneficios()
    End Sub

    Private Sub txtFiltro_EditValueChanged(sender As Object, e As EventArgs) Handles txtFiltro.EditValueChanged
        Listar_Beneficios()
    End Sub

    Private Sub chkAct_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles chkAct.CheckedChanged
        Listar_Beneficios()
    End Sub
End Class