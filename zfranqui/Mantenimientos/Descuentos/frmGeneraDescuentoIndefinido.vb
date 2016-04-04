Public Class frmGeneraDescuentoIndefinido

    Private Sub frmGeneraDescuentoIndefinido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try

    End Sub

    Private Sub Genera_Descuentos_REF()

        Dim lConnection As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)
        Dim lTransaction As MySql.Data.MySqlClient.MySqlTransaction = Nothing

        Try

            prg.Visible = True

            txt.AppendText("Iniciando verificación de descuentos indefinidos..." & vbNewLine)

            Dim DT As New DataTable

            vSQL = " SELECT " & _
                    " descuento_det.IdDescuentoEnc, " & _
                    " descuento_det.IdDescuentoDet, " & _
                    " descuento_det.IdBeneficio, " & _
                    " descuento_det.MontoTotal, " & _
                    " descuento_det.FechaAPartirDe, " & _
                    " periodo_descuento.Dias, " & _
                    " descuento_enc.IdCEF, " & _
                    " descuento_enc.IdFranquiciado, " & _
                    " descuento_enc.IdTipoDescuento, " & _
                    " franquiciado.Codigo AS CodigoFrnquiciado, " & _
                    " franquiciado.Nombres AS NomFranquiciado, " & _
                    " franquiciado.Apellidos AS ApeFranquiciado, " & _
                    " cef.Codigo AS CodigoCEF, " & _
                    " cef.Descripcion AS NomCEF, " & _
                    " tipobeneficio.Nombre AS NomTipoBeneficio, " & _
                    " tipodescuento.Nombre AS NomTipoDescuento  " & _
                " FROM " & _
                " 	descuento_enc " & _
                " INNER JOIN cef ON descuento_enc.IdCEF = cef.IdCef " & _
                " INNER JOIN franquiciado ON descuento_enc.IdFranquiciado = franquiciado.IdFranquiciado " & _
                " INNER JOIN tipodescuento ON descuento_enc.IdTipoDescuento = tipodescuento.IdTipoDescuento " & _
                " INNER JOIN descuento_det ON descuento_enc.IdDescuentoEnc = descuento_det.IdDescuentoEnc " & _
                " INNER JOIN beneficio ON descuento_det.IdBeneficio = beneficio.IdBeneficio " & _
                " INNER JOIN tipobeneficio ON beneficio.IdTipoBeneficio = tipobeneficio.IdTipoBeneficio " & _
                " INNER JOIN periodo_descuento ON descuento_det.IdPeriodoDescuento = periodo_descuento.IdPeriodo " & _
                " WHERE descuento_enc.IdTipoDescuento = 2 " & _
                " AND descuento_det.Activo = 1 "

            BD.OpenDT(DT, vSQL)

            prg.Visible = True
            prg.Maximum = DT.Rows.Count

            Dim IdDescuentoEnc As Integer = 0
            Dim IdDescuentoDet As Integer = 0
            Dim IdBeneficio As Integer = 0
            Dim MontoBeneficio As Double = 0
            Dim FechaApartirDe As Date = Now
            Dim DiasPeriodo As Integer = 0
            Dim FechaUltimoDescuento As Date = Now
            Dim FechaProximoDescuento As Date = Now
            Dim DiasTranscurridos As Integer = 0
            Dim CantPeriodosPendientes As Integer = 0
            Dim ContadorRef As Integer = 0
            Dim FechaIni As Date = Now.Date

            Dim ObjRef As New clsBeDescuento_ref
            Dim lref As New List(Of clsBeDescuento_ref)
            Dim UltimaCuota As Integer = 0

            lref.Clear()

            txt.AppendText("Se encontraron: " & DT.Rows.Count & " descuentos para analizar" & vbNewLine)

            Application.DoEvents()

            For I As Integer = 0 To DT.Rows.Count - 1

                IdDescuentoEnc = DT.Rows(I).Item("IdDescuentoEnc")
                IdDescuentoDet = DT.Rows(I).Item("IdDescuentoDet")
                IdBeneficio = DT.Rows(I).Item("IdBeneficio")
                MontoBeneficio = DT.Rows(I).Item("MontoTotal")
                FechaApartirDe = DT.Rows(I).Item("FechaAPartirDe")
                DiasPeriodo = DT.Rows(I).Item("Dias")
                UltimaCuota = clsLnDescuento_ref.MaxCuota(IdDescuentoEnc, IdDescuentoDet)

                txt.AppendText("Verificando información de descuento No.:" & IdDescuentoEnc & vbNewLine & _
                               "Detalle No.: " & IdDescuentoDet & vbNewLine & _
                               "Beneficio No.: " & IdBeneficio & vbNewLine)

                If Tiene_Ultima_REF(IdDescuentoEnc, IdDescuentoDet, IdBeneficio, FechaUltimoDescuento) Then
                    FechaApartirDe = FechaUltimoDescuento
                End If

                FechaProximoDescuento = FechaApartirDe.AddDays(DiasPeriodo - 1)
                FechaIni = FechaApartirDe.AddDays(DiasPeriodo)

                Dim IdRef As Integer = clsLnDescuento_ref.MaxID(IdDescuentoEnc, IdDescuentoDet)

                Application.DoEvents()

                If DateDiff(DateInterval.Day, FechaApartirDe, Now.Date) > DiasPeriodo Then

                    Do


                        ObjRef = New clsBeDescuento_ref
                        ObjRef.Abonado = 0
                        ObjRef.Beneficio = New clsBeBeneficio
                        ObjRef.Beneficio.IdBeneficio = IdBeneficio
                        ObjRef.Fec_agr = Now
                        ObjRef.Fec_mod = Now
                        ObjRef.FechaCobro = FechaProximoDescuento
                        ObjRef.IdDescuentoDet = IdDescuentoDet
                        ObjRef.IdDescuentoEnc = IdDescuentoEnc
                        ObjRef.IdDescuentoRef = IdRef
                        ObjRef.IdBeneficio = IdBeneficio
                        ObjRef.Monto = MontoBeneficio
                        ObjRef.NoCuota = UltimaCuota
                        ObjRef.Pagada = False
                        ObjRef.User_agr = m_Global.gUsuario.IdUsuario
                        ObjRef.User_mod = m_Global.gUsuario.IdUsuario
                        ObjRef.Anulada = False
                        lref.Add(ObjRef)

                        txt.AppendText("Generando cuota.:" & UltimaCuota & vbNewLine & _
                                   "Fecha.: " & FechaProximoDescuento & vbNewLine & _
                                   "Monto.: " & MontoBeneficio & vbNewLine)

                        FechaProximoDescuento = FechaIni.AddDays(DiasPeriodo - 1)
                        FechaIni = FechaIni.AddDays(DiasPeriodo)
                        UltimaCuota += 1
                        IdRef += 1

                        Application.DoEvents()

                    Loop Until FechaProximoDescuento >= Now.Date

                    prg.Value = I

                End If

                If lref.Count > 0 Then

                    txt.AppendText("Iniciando inserción transaccional..." & vbNewLine)

                    lConnection.Open()

                    lTransaction = lConnection.BeginTransaction()

                    Dim ObjLNRef As New clsLnDescuento_ref

                    For Each C As clsBeDescuento_ref In lref
                        ObjLNRef.Insertar(C, lConnection, lTransaction)
                        txt.AppendText("Insertando CuotaREF: " & C.NoCuota & " DescuentoEnc: " & C.IdDescuentoEnc & vbNewLine)
                    Next

                    txt.AppendText("Haciendo commit de las transacciones..." & vbNewLine)

                    lTransaction.Commit()
                    lConnection.Close()

                    txt.AppendText("Se insertaron correctamente " & lref.Count & " Cuotas de descuentos período indefinido en descuento_ref")

                Else
                    txt.AppendText("No hay cuotas nuevas que generar para descuento: " & IdDescuentoEnc)
                End If
                
                

            Next


        Catch ex As Exception
            Try
                lTransaction.Rollback()
            Catch ex1 As Exception
                txt.AppendText("InRollBack: " & ex1.Message)
            End Try
            MsgBox(ex.Message)
            txt.AppendText("ErrGenDescREF: " & ex.Message)
        Finally
            prg.Visible = False
        End Try

    End Sub

    Private Function Tiene_Ultima_REF(ByVal IdDescuentoEnc As Integer, ByVal IdDescuentoDet As Integer, ByVal IdBeneficio As Integer, ByRef Fecha_Ultimo_Descuento_Ref As Date) As Boolean

        Tiene_Ultima_REF = False : Fecha_Ultimo_Descuento_Ref = "01/01/1990"

        Dim DT As New DataTable

        Try
            '

            vSQL = "select fechacobro from descuento_ref where IdDescuentoEnc =" & IdDescuentoDet & _
                " and IdDescuentoDet = " & IdDescuentoDet & _
                " and IdBeneficio = " & IdBeneficio & _
                " order by fechacobro desc "
            BD.OpenDT(DT, vSQL)

            If DT.Rows.Count > 0 Then

                Fecha_Ultimo_Descuento_Ref = IIf(IsDBNull(DT.Rows(0).Item("fechacobro")), "01/01/1990", DT.Rows(0).Item("fechacobro"))
                Tiene_Ultima_REF = True

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            DT.Dispose()
        End Try


    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Genera_Descuentos_REF()
    End Sub

    Private Sub frmGeneraDescuentoIndefinido_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Genera_Descuentos_REF()
    End Sub

End Class