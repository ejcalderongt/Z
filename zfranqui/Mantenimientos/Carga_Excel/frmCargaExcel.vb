Imports DevExpress.XtraEditors.Repository
Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors

Public Class frmCargaExcel

    Public Delegate Sub Operar()
    Public Listar As Operar

    Private pListObj As List(Of clsExcel)
    Private pListObjB As List(Of clsBeBeneficio)
    Private pListObjE As List(Of clsBeDescuento_enc)
    Private pListObjD As List(Of clsBeDescuento_det)
    Private pListObjR As List(Of clsBeDescuento_ref)

    Private Sub ButtonEdit1_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtArchivo.Properties.ButtonClick

        Try

            Dim ObjO As New OpenFileDialog()
            ObjO.Filter = "All Files|*.*|Excel Files(.xls)|*.xls|Excel Files(.xlsx)|*.xlsx|Excel Files(*.xlsm)|*.xlsm"
            If ObjO.ShowDialog() = System.Windows.Forms.DialogResult.OK AndAlso ObjO.FileName.Length <> 0 Then
                txtArchivo.Text = ObjO.FileName
                CargaHojas(ObjO.FileName)
            End If

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub CargaHojas(ByVal pFileName As String)

        DsExcel.Clear()
        Grid.BeginUpdate()
        Dim xlApp As New Excel.Application

        Try

            xlApp.Workbooks.Open(pFileName)
            pListObj = New List(Of clsExcel)

            Dim i As Integer = -1
            For Each sheet As Excel.Worksheet In xlApp.Worksheets
                i += 1
                Dim ObjE As New clsExcel()
                ObjE.Index = i
                ObjE.Checked = False
                ObjE.NombreHoja = sheet.Name
                pListObj.Add(ObjE)
            Next

            If pListObj.Count > 0 Then
                For Each Obj As clsExcel In pListObj
                    Dim lRow As DataRow = DsExcel.Data.NewRow
                    lRow.Item("Hoja") = Obj.NombreHoja
                    lRow.Item("Seleccionar") = False
                    DsExcel.Data.AddDataRow(lRow)
                Next
            End If

            'Dim app As Excel.Application = Nothing
            'app = New Excel.Application()
            'Dim wb As Excel.Workbook = app.Workbooks.Open(ObjO.FileName)

            'For Each sheet As Excel.Worksheet In wb.Worksheets
            '    DT.Rows.Add(False, sheet.Name)
            'Next

            Grid.EndUpdate()
            Grid.ForceInitialize()
            Dim ritem As RepositoryItemCheckEdit = TryCast(GridView1.Columns("Seleccionar").RealColumnEdit, RepositoryItemCheckEdit)
            AddHandler ritem.CheckedChanged, AddressOf ritem_CheckedChanged

        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Information, Me.Text)
        Finally
            If Not xlApp Is Nothing Then xlApp.Quit()
            Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
            xlApp = Nothing
        End Try

    End Sub

    Private Sub ritem_CheckedChanged(sender As Object, e As EventArgs)

        Try

            Dim ritem As DevExpress.XtraEditors.CheckEdit = TryCast(sender, DevExpress.XtraEditors.CheckEdit)
            If ritem IsNot Nothing Then

                Dim Dr As DataRowView = GridView1.GetFocusedRow
                Dim lIndex As Integer = -1
                lIndex = pListObj.FindIndex(Function(b) b.NombreHoja = CStr(Dr.Item("Hoja")))

                If ritem.Checked Then
                    For Each Obj As clsExcel In pListObj
                        If Obj.Index = lIndex Then
                            Obj.Checked = True
                        End If
                    Next
                    If pListObj.Count > 0 Then
                        DsExcel.Clear()
                        Grid.BeginUpdate()
                        For Each Obj As clsExcel In pListObj
                            Dim lRow As DataRow = DsExcel.Data.NewRow
                            lRow.Item("Hoja") = Obj.NombreHoja
                            lRow.Item("Seleccionar") = Obj.Checked
                            DsExcel.Data.AddDataRow(lRow)
                        Next
                        Grid.EndUpdate()
                        Grid.ForceInitialize()
                    End If
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargaArchivo()

        Try

            Dim dtb As New DataTable("Beneficio")
            Dim dte As New DataTable("Encabezado")
            Dim dtd As New DataTable("Detalle")

            If pListObj IsNot Nothing Then
                MsgBox("Dependiendo de la cantidad de datos serà el tiempo estimado para cargar el archivo", MsgBoxStyle.Information, Me.Text)
                For Each Obj As clsExcel In pListObj
                    Application.DoEvents()

                    Try

                        Dim lConn As String = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}; Extended Properties=""Excel 12.0;HDR=NO;IMEX= 0""", txtArchivo.Text.Trim)

                        Using lConnection As New OleDbConnection(lConn)
                            Using lDataAdapter As New OleDbDataAdapter(String.Format("SELECT * FROM [{0}$]", Obj.NombreHoja.Trim()), lConnection)
                                lDataAdapter.SelectCommand.CommandType = CommandType.Text
                                Select Case Obj.Index
                                    Case 0
                                        lDataAdapter.Fill(dtb)
                                        CargarBeneficios(dtb)
                                    Case 1
                                        lDataAdapter.Fill(dte)
                                        CargarEncabezado(dte)
                                    Case 2
                                        lDataAdapter.Fill(dtd)
                                        CargarDetalle(dtd)
                                End Select
                            End Using
                        End Using

                    Catch ex As Exception
                        Throw ex
                    End Try

                Next
                GuardaDatos()
            End If

            'Dim Obj As clsExcel = pListObj.Find(Function(s) s.Checked = True)

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub CargarBeneficios(ByVal pDT As DataTable)

        ' columna 0 es el IdBeneficio y el archivo lo determina
        ' columna 1 es el IdTipoBeneficio y el archivo lo determina
        ' los campos de mas que vienen en el excel ya corresponde a la tabla
        ' Verificar IdtTipoBeneficio que no venga nulo y que no sea nulo.

        Try

            pListObjB = New List(Of clsBeBeneficio)

            Dim i As Integer = 0

            For Each lRow As DataRow In pDT.Rows

                Application.DoEvents()

                Dim ObjA As New clsBeBeneficio()

                If pDT(i)(0) Is DBNull.Value AndAlso pDT(i)(0) Is Nothing Then
                    Throw New Exception("Falta código del beneficio en la fila " & i + 1)
                End If
                If IsNumeric(pDT(i)(0)) = False Then
                    Throw New Exception("El código del beneficio debe ser númerico entero. Fila " & i + 1)
                Else
                    Dim lIdExiste As Boolean = pListObjB.Exists(Function(e) e.IdBeneficio = CInt(pDT(i)(0)))
                    If lIdExiste Then
                        Throw New Exception("El código del beneficio de la fila " & i + 1 & " se encuentra repetido.")
                    Else
                        If Not clsLnBeneficio.Exists(CInt(pDT(i)(0))) Then
                            ObjA.IsNew = True
                        Else
                            ObjA.IsNew = False
                        End If
                        ObjA.IdBeneficio = CInt(pDT(i)(0))
                    End If
                End If

                ' ESTO SE CUMPLE PARA IdTipoBeneficio
                If pDT(i)(1) Is DBNull.Value AndAlso pDT(i)(1) Is Nothing Then
                    Throw New Exception("Falta código del tipo beneficio en la fila " & i + 1)
                End If
                If IsNumeric(pDT(i)(1)) = False Then
                    Throw New Exception("El código del tipo beneficio debe ser númerico entero. Fila " & i + 1)
                Else
                    ObjA.TipoBeneficio = New clsBeTipobeneficio
                    ObjA.TipoBeneficio.IdTipoBeneficio = CInt(pDT(i)(1))
                End If

                If pDT(i)(2) Is DBNull.Value AndAlso pDT(i)(2) Is Nothing Then
                    Throw New Exception("Falta nombre del beneficio en la fila " & i + 1)
                End If

                ObjA.Nombre = CStr(pDT(i)(2))

                If lRow(3) IsNot DBNull.Value AndAlso lRow(3) IsNot Nothing Then
                    ObjA.Modelo = CType(lRow(3), System.String)
                End If

                If lRow(4) IsNot DBNull.Value AndAlso lRow(4) IsNot Nothing Then
                    ObjA.NoChasis = CType(lRow(4), System.String)
                End If

                If lRow(5) IsNot DBNull.Value AndAlso lRow(5) IsNot Nothing Then
                    ObjA.NoPlaca = CType(lRow(5), System.String)
                End If

                If lRow(6) IsNot DBNull.Value AndAlso lRow(6) IsNot Nothing Then
                    ObjA.Motor = CType(lRow(6), System.String)
                End If

                If lRow(7) IsNot DBNull.Value AndAlso lRow(7) IsNot Nothing Then
                    ObjA.NumeroTelefono = CType(lRow(7), System.String)
                End If

                If lRow(8) IsNot DBNull.Value AndAlso lRow(8) IsNot Nothing Then
                    ObjA.EmpresaTelco = CType(lRow(8), System.String)
                End If

                If lRow(9) IsNot DBNull.Value AndAlso lRow(9) IsNot Nothing Then
                    If IsDate(lRow(9)) Then
                        ObjA.Fecha_asignacion = CType(lRow(9), System.DateTime)
                    Else
                        Throw New Exception("La fecha de asignación es errÓnea de la fila " & i + 1)
                    End If
                End If

                ObjA.Activo = 1
                ObjA.User_agr = gUsuario.IdUsuario
                ObjA.Fec_agr = Now
                ObjA.User_mod = gUsuario.IdUsuario
                ObjA.Fec_mod = Now

                pListObjB.Add(ObjA)

                i += 1

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargarEncabezado(ByVal pDT As DataTable)

        Try

            pListObjE = New List(Of clsBeDescuento_enc)

            Dim i As Integer = 0

            For Each lRow As DataRow In pDT.Rows

                Application.DoEvents()

                Dim ObjE As New clsBeDescuento_enc()

                If pDT(i)(0) Is DBNull.Value AndAlso pDT(i)(0) Is Nothing Then
                    Throw New Exception("Falta código del encabezado en la fila " & i + 1)
                End If

                If IsNumeric(pDT(i)(0)) = False Then
                    Throw New Exception("El código del encabezado debe ser númerico entero. Fila " & i + 1)
                Else
                    Dim lIdExiste As Boolean = pListObjE.Exists(Function(e) e.IdDescuentoEnc = CInt(pDT(i)(0)))
                    If lIdExiste Then
                        Throw New Exception("El código del encabezado de la fila " & i + 1 & " se encuentra repetido.")
                    Else
                        If Not clsLnDescuento_enc.Exists(CInt(pDT(i)(0))) Then
                            ObjE.IsNew = True
                        Else
                            ObjE.IsNew = False
                        End If
                        ObjE.IdDescuentoEnc = CInt(pDT(i)(0))
                    End If
                End If

                If pDT(i)(1) Is DBNull.Value AndAlso pDT(i)(1) Is Nothing Then
                    Throw New Exception("Falta código cef en la fila " & i + 1)
                End If

                If IsNumeric(pDT(i)(1)) = False Then
                    Throw New Exception("El código cef debe ser númerico entero. Fila " & i + 1)
                Else
                    If Not clsLnCef.Exists(CInt(pDT(i)(1))) Then
                        Throw New Exception("El código cef " & pDT(i)(1).ToString & " no existe. Fila " & i + 1)
                    End If
                End If

                If pDT(i)(2) Is DBNull.Value AndAlso pDT(i)(2) Is Nothing Then
                    Throw New Exception("Falta código de franquiciado en la fila " & i + 1)
                End If

                If IsNumeric(pDT(i)(2)) = False Then
                    Throw New Exception("El código del franquiciado debe ser númerico entero. Fila " & i + 1)
                Else
                    If Not clsLnFranquiciadocef.Exists(CInt(pDT(i)(2))) Then
                        Throw New Exception("El código franquicado " & pDT(i)(2).ToString & " no existe. Fila " & i + 1)
                    End If
                End If

                If pDT(i)(3) Is DBNull.Value AndAlso pDT(i)(3) Is Nothing Then
                    Throw New Exception("Falta código de tipo descuento en la fila " & i + 1)
                End If

                If IsNumeric(pDT(i)(3)) = False Then
                    Throw New Exception("El código de tipo descuento debe ser númerico entero. Fila " & i + 1)
                Else
                    If Not clsLnDescuento_enc.ExisteTipoDescuento(CInt(pDT(i)(3))) Then
                        Throw New Exception("El código tipo descuento " & pDT(i)(3).ToString & " no existe. Fila " & i + 1)
                    End If
                End If

                ObjE.CEF = New clsBeCef
                ObjE.CEF.IdCef = CInt(pDT(i)(1))

                ObjE.Franquiciado = New clsBeFranquiciado
                ObjE.Franquiciado.IdFranquiciado = CInt(pDT(i)(2))

                ObjE.IdTipoDescuento = CInt(pDT(i)(3))

                ObjE.User_agr = gUsuario.IdUsuario
                ObjE.Fec_agr = Now
                ObjE.User_mod = gUsuario.IdUsuario
                ObjE.Fec_mod = Now
                ObjE.IsNew = True
                pListObjE.Add(ObjE)
                i += 1

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub CargarDetalle(ByVal pDT As DataTable)

        Try

            pListObjD = New List(Of clsBeDescuento_det)

            Dim i As Integer = 0

            For Each lRow As DataRow In pDT.Rows

                Application.DoEvents()

                Dim ObjD As New clsBeDescuento_det()

                If pDT(i)(0) Is DBNull.Value AndAlso pDT(i)(0) Is Nothing Then
                    Throw New Exception("Falta código del encabezado en la fila " & i + 1)
                ElseIf IsNumeric(pDT(i)(0)) = False Then
                    Throw New Exception("El código del encabezado debe ser númerico entero. Fila " & i + 1)
                End If

                If pDT(i)(1) Is DBNull.Value AndAlso pDT(i)(1) Is Nothing Then
                    Throw New Exception("Falta código del detalle en la fila " & i + 1)
                ElseIf IsNumeric(pDT(i)(1)) = False Then
                    Throw New Exception("El código del detalle debe ser númerico entero. Fila " & i + 1)
                End If

                If pDT(i)(2) Is DBNull.Value AndAlso pDT(i)(2) Is Nothing Then
                    Throw New Exception("Falta código del beneficio en la fila " & i + 1)
                ElseIf IsNumeric(pDT(i)(2)) = False Then
                    Throw New Exception("El código del beneficio debe ser númerico entero. Fila " & i + 1)
                End If

                If pDT(i)(3) Is DBNull.Value AndAlso pDT(i)(3) Is Nothing Then
                    Throw New Exception("Falta código del Período Descuento en la fila " & i + 1)
                ElseIf IsNumeric(pDT(i)(3)) = False Then
                    Throw New Exception("El código del Período Descuento debe ser númerico entero. Fila " & i + 1)
                End If

                If pDT(i)(4) Is DBNull.Value AndAlso pDT(i)(4) Is Nothing Then
                    Throw New Exception("Falta el monto total en la fila " & i + 1)
                ElseIf IsNumeric(pDT(i)(4)) = False Then
                    Throw New Exception("El monto total debe ser un valor númerico. Fila " & i + 1)
                End If

                If pDT(i)(5) Is DBNull.Value AndAlso pDT(i)(5) Is Nothing Then
                    Throw New Exception("Falta la cantidad de cuotas en la fila " & i + 1)
                ElseIf IsNumeric(pDT(i)(5)) = False Then
                    Throw New Exception("La cantidad de cuotas debe ser un valor númerico entero. Fila " & i + 1)
                End If

                ObjD.IdDescuentoEnc = CInt(pDT(i)(0))
                ObjD.IdDescuentoDet = CInt(pDT(i)(1))
                ObjD.Beneficio = New clsBeBeneficio
                ObjD.Beneficio.IdBeneficio = CInt(pDT(i)(2))
                ObjD.PeriodoDescuento = New clsBePeriodo_descuento
                ObjD.PeriodoDescuento.IdPeriodo = CInt(pDT(i)(3))
                ObjD.MontoTotal = CDbl(pDT(i)(4))
                ObjD.Cuotas = CInt(pDT(i)(5))

                If lRow(6) IsNot DBNull.Value AndAlso lRow(6) IsNot Nothing Then
                    If IsDate(lRow(6)) Then
                        ObjD.FechaAPartirDe = CType(lRow(6), System.DateTime)
                    Else
                        Throw New Exception("La fecha de a partir de es errÓnea de la fila " & i + 1)
                    End If
                End If

                ObjD.User_agr = gUsuario.IdUsuario
                ObjD.Fec_agr = Now
                ObjD.User_mod = gUsuario.IdUsuario
                ObjD.Fec_mod = Now
                ObjD.IsNew = True
                pListObjD.Add(ObjD)
                i += 1

            Next

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub GuardaDatos()

        Dim lConnection As New MySql.Data.MySqlClient.MySqlConnection(BD.CadenaConexion)
        Dim lTransaction As MySql.Data.MySqlClient.MySqlTransaction = Nothing

        Try

            Dim ObjLnBe As New clsLnBeneficio
            Dim ObjLnEnc As New clsLnDescuento_enc
            Dim ObjLNDet As New clsLnDescuento_det
            Dim ObjLNRef As New clsLnDescuento_ref

            lConnection.Open()
            lTransaction = lConnection.BeginTransaction()

            For Each b As clsBeBeneficio In pListObjB
                If b.IsNew Then
                    ObjLnBe.Insertar(b, lConnection, lTransaction)
                Else
                    ObjLnBe.Actualizar(b, lConnection, lTransaction)
                End If
            Next

            For Each e As clsBeDescuento_enc In pListObjE
                If e.IsNew Then
                    ObjLnEnc.Insertar(e, lConnection, lTransaction)
                Else
                    ObjLnEnc.Actualizar(e, lConnection, lTransaction)
                End If

                For Each d As clsBeDescuento_det In pListObjD.FindAll(Function(enc) enc.IdDescuentoEnc = e.IdDescuentoEnc)

                    Dim lMaxRef As Integer = 1
                    Dim dBene As New clsLnBeneficio
                    dBene.Obtener(d.Beneficio, True)

                    Dim dPer As New clsLnPeriodo_descuento
                    dPer.Obtener(d.PeriodoDescuento)

                    Dim lMonto As Decimal = CDec(d.MontoTotal / d.Cuotas)
                    lMonto = Math.Round(lMonto, 2)
                    Dim lFechaA As Date = d.FechaAPartirDe


                    If e.IdTipoDescuento = 1 Then

                        'Dim lMaxRef As Integer = clsLnDescuento_ref.MaxID(d.IdDescuentoEnc, d.IdDescuentoDet)

                        For i As Integer = 1 To d.Cuotas Step 1

                            Dim ObjR As New clsBeDescuento_ref

                            ObjR.IdDescuentoEnc = d.IdDescuentoEnc
                            ObjR.IdDescuentoDet = d.IdDescuentoDet
                            ObjR.IdDescuentoRef = lMaxRef
                            ObjR.IdBeneficio = d.Beneficio.IdBeneficio
                            ObjR.NoCuota = i
                            ObjR.Monto = lMonto
                            ObjR.Abonado = 0.0
                            ObjR.Anulada = False

                            If i = 1 Then
                                ObjR.FechaCobro = lFechaA.AddDays(d.PeriodoDescuento.Dias)
                            Else
                                ObjR.FechaCobro = pListObjR.Max(Function(m) m.FechaCobro.AddDays(d.PeriodoDescuento.Dias).Date)
                            End If

                            ObjR.Pagada = False
                            ObjR.Fec_agr = Now
                            ObjR.User_agr = gUsuario.IdUsuario
                            ObjR.Fec_mod = Now
                            ObjR.User_mod = gUsuario.IdUsuario
                            'ObjR.IsNew = True
                            ObjLNRef.Insertar(ObjR, lConnection, lTransaction)
                            lMaxRef += 1

                        Next

                    ElseIf e.IdTipoDescuento = 3 Then

                        Dim ObjR As New clsBeDescuento_ref

                        ObjR.IdDescuentoEnc = d.IdDescuentoEnc
                        ObjR.IdDescuentoDet = d.IdDescuentoDet
                        ObjR.IdDescuentoRef = lMaxRef
                        ObjR.IdBeneficio = d.Beneficio.IdBeneficio
                        ObjR.NoCuota = 1
                        ObjR.Monto = d.MontoTotal
                        ObjR.Abonado = 0.0
                        ObjR.Anulada = False

                        ObjR.FechaCobro = d.FechaAPartirDe

                        ObjR.Pagada = False
                        ObjR.Fec_agr = Now
                        ObjR.User_agr = gUsuario.IdUsuario
                        ObjR.Fec_mod = Now
                        ObjR.User_mod = gUsuario.IdUsuario
                        ObjLNRef.Insertar(ObjR, lConnection, lTransaction)
                        lMaxRef += 1

                    End If

                    If d.IsNew Then
                        ObjLNDet.Insertar(d, lConnection, lTransaction)
                    Else
                        ObjLNDet.Actualizar(d, lConnection, lTransaction)
                    End If
                Next

            Next

            lTransaction.Commit()

        Catch ex As Exception
            Try
                lTransaction.Rollback()
            Catch ex1 As Exception
                MsgBox("No se pudo hacer rollback de la transacción: " & ex.Message)
            End Try
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Try
                lConnection.Close()
            Catch ex As Exception
            End Try
        End Try

    End Sub

    Private Sub cmdCargar_Click(sender As Object, e As EventArgs) Handles cmdCargar.Click

        Try

            Validar()
            'If chkBorraTabla.Checked Then
            '    If MessageBox.Show("¿Desea borrar la tabla?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            '        'BorraTabla()
            '    End If
            'End If
            CargaArchivo()

        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub Validar()

        If String.IsNullOrEmpty(txtArchivo.Text.Trim()) Then Throw New Exception("Seleccione archivo.")
        If System.IO.File.Exists(txtArchivo.Text.Trim()) = False Then Throw New Exception("El archivo no existe.")
        'If String.IsNullOrEmpty(txtNombreHoja.Text.Trim()) Then Throw New Exception("Ingrese el nombre de la hoja.")
        If pListObj IsNot Nothing Then
            If pListObj.Count > 0 = False Then
                Throw New Exception("El archivo debe de contener por lo menos alguna hoja.")
            Else
                'If pListObj.Exists(Function(e) e.Checked = False) Then
                '    Throw New Exception("Seleccione una hoja.")
                'End If
                'If pListObj.TrueForAll(Function(c) c.Checked = True) Then
                'End If
                If pListObj.All(Function(b) b.Checked = False) Then
                    Throw New Exception("Seleccione una hoja.")
                End If
            End If
        End If

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
End Class