Imports DevExpress.XtraEditors.Repository
Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports DevExpress.XtraEditors.Controls

Public Class frmCargaExcel

    Public Delegate Sub Operar()
    Public Listar As Operar

    Private pListObj As List(Of clsExcel)

    Private Sub ButtonEdit1_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtArchivo.Properties.ButtonClick

        Try

            Dim ObjO As New OpenFileDialog()
            ObjO.Filter = "All Files|*.*|Excel Files(.xls)|*.xls|Excel Files(.xlsx)|*.xlsx|Excel Files(*.xlsm)|*.xlsm"
            If ObjO.ShowDialog() = System.Windows.Forms.DialogResult.OK AndAlso ObjO.FileName.Length <> 0 Then
                txtArchivo.Text = ObjO.FileName
                CargaHojas(ObjO.FileName)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
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

            If pListObj IsNot Nothing Then
                MsgBox("Dependiendo de la cantidad de datos serà el tiempo estimado para cargar el archivo", MsgBoxStyle.Information, Me.Text)
                For Each Obj As clsExcel In pListObj
                    Application.DoEvents()
                    Dim DT As New DataTable("Carga")

                    Try

                        Dim lConn As String = String.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source={0}; Extended Properties=""Excel 12.0;HDR=NO;IMEX= 0""", txtArchivo.Text.Trim)

                        Using lConnection As New OleDbConnection(lConn)
                            Using lDataAdapter As New OleDbDataAdapter(String.Format("SELECT * FROM [{0}$]", Obj.NombreHoja.Trim()), lConnection)
                                lDataAdapter.SelectCommand.CommandType = CommandType.Text
                                lDataAdapter.Fill(DT)
                            End Using
                        End Using

                    Catch ex As Exception

                        Dim cnn As String = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=Yes;IMEX=1""", txtArchivo.Text.Trim)

                        Using lConnection As New OleDbConnection(cnn)
                            Using lDataAdapter As New OleDbDataAdapter(String.Format("SELECT * FROM [{0}$]", Obj.NombreHoja.Trim()), lConnection)
                                lDataAdapter.SelectCommand.CommandType = CommandType.Text
                                lDataAdapter.Fill(DT)
                            End Using
                        End Using

                    End Try

                    If DT.Rows.Count > 0 Then
                        CargarBeneficios(DT)
                        CargaroEncabezado()
                        CargarDetalle()
                    End If
                Next
            End If
           

            'Dim Obj As clsExcel = pListObj.Find(Function(s) s.Checked = True)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try

    End Sub

    Private Sub CargarBeneficios(ByVal pDT As DataTable)

        Try

            Dim lista As New List(Of clsBeBeneficio)

            prg.Visible = True
            prg.Value = 0

            For i As Integer = 0 To pDT.Rows.Count - 1

                Dim Indice As Integer = i
                Application.DoEvents()

                Dim ObjA As New clsBeBeneficio()

                If pDT(i)(0) Is DBNull.Value AndAlso pDT(i)(0) Is Nothing Then
                    Throw New Exception("Falta código del beneficio en la fila " & i + 1)
                End If
                If IsNumeric(pDT(i)(0)) = False Then
                    Throw New Exception("El código del beneficio debe ser númerico entero. Fila " & i + 1)
                Else
                    Dim lIdExiste As Boolean = lista.Exists(Function(e) e.IdBeneficio = CInt(pDT(Indice)(0)))
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

                If pDT(i)(1) Is DBNull.Value AndAlso pDT(i)(1) Is Nothing Then
                    Throw New Exception("Falta nombre del beneficio en la fila " & i + 1)
                End If

                ObjA.TipoBeneficio.IdTipoBeneficio =
                ObjA.Nombre = CStr(pDT(i)(1))
                ObjA.Activo = True
                ObjA.User_agr = AP.UsuarioAp.IdUsuario
                ObjA.Fec_agr = Now
                ObjA.User_mod = AP.UsuarioAp.IdUsuario
                ObjA.Fec_mod = Now

                lista.Add(ObjA)

            Next

        Catch ex As Exception
            Throw ex
        Finally
            prg.Visible = False
        End Try

    End Sub
    Private Sub CargaroEncabezado()
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        End Try
    End Sub
    Private Sub CargarDetalle()
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
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
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
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

End Class