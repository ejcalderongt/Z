<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepDescuentoDet
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgrid = New DevExpress.XtraGrid.GridControl()
        Me.DsetRep1 = New zfranqui.DsetRep()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModelo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoChasis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoPlaca = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMotor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroTelefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmpresaTelco = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEsVehiculo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEsTelefono = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEsServicio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaCobro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoCuota = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAbonado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colpagada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoDescuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.cmdImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DtDescuentoDetRepGridTableAdapter1 = New zfranqui.DsetRepTableAdapters.dtDescuentoDetRepGridTableAdapter()
        CType(Me.dgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsetRep1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgrid
        '
        Me.dgrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgrid.DataMember = "dtDescuentoDetRepGrid"
        Me.dgrid.DataSource = Me.DsetRep1
        Me.dgrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgrid.Location = New System.Drawing.Point(0, 22)
        Me.dgrid.MainView = Me.GridView1
        Me.dgrid.Name = "dgrid"
        Me.dgrid.Size = New System.Drawing.Size(757, 350)
        Me.dgrid.TabIndex = 0
        Me.dgrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DsetRep1
        '
        Me.DsetRep1.DataSetName = "DsetRep"
        Me.DsetRep1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNombre, Me.colModelo, Me.colNoChasis, Me.colNoPlaca, Me.colMotor, Me.colNumeroTelefono, Me.colEmpresaTelco, Me.colEsVehiculo, Me.colEsTelefono, Me.colEsServicio, Me.colFechaCobro, Me.colNoCuota, Me.colMonto, Me.colAbonado, Me.colpagada, Me.colTipoDescuento})
        Me.GridView1.GridControl = Me.dgrid
        Me.GridView1.GroupCount = 1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Monto", Me.colMonto, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "NoCuota", Me.colNoCuota, "{0:n2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Abonado", Me.colAbonado, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNombre, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 0
        '
        'colModelo
        '
        Me.colModelo.FieldName = "Modelo"
        Me.colModelo.Name = "colModelo"
        Me.colModelo.Visible = True
        Me.colModelo.VisibleIndex = 0
        '
        'colNoChasis
        '
        Me.colNoChasis.FieldName = "NoChasis"
        Me.colNoChasis.Name = "colNoChasis"
        Me.colNoChasis.Visible = True
        Me.colNoChasis.VisibleIndex = 1
        '
        'colNoPlaca
        '
        Me.colNoPlaca.FieldName = "NoPlaca"
        Me.colNoPlaca.Name = "colNoPlaca"
        Me.colNoPlaca.Visible = True
        Me.colNoPlaca.VisibleIndex = 2
        '
        'colMotor
        '
        Me.colMotor.FieldName = "Motor"
        Me.colMotor.Name = "colMotor"
        Me.colMotor.Visible = True
        Me.colMotor.VisibleIndex = 3
        '
        'colNumeroTelefono
        '
        Me.colNumeroTelefono.FieldName = "NumeroTelefono"
        Me.colNumeroTelefono.Name = "colNumeroTelefono"
        Me.colNumeroTelefono.Visible = True
        Me.colNumeroTelefono.VisibleIndex = 4
        '
        'colEmpresaTelco
        '
        Me.colEmpresaTelco.FieldName = "EmpresaTelco"
        Me.colEmpresaTelco.Name = "colEmpresaTelco"
        Me.colEmpresaTelco.Visible = True
        Me.colEmpresaTelco.VisibleIndex = 5
        '
        'colEsVehiculo
        '
        Me.colEsVehiculo.FieldName = "EsVehiculo"
        Me.colEsVehiculo.Name = "colEsVehiculo"
        Me.colEsVehiculo.Visible = True
        Me.colEsVehiculo.VisibleIndex = 6
        '
        'colEsTelefono
        '
        Me.colEsTelefono.FieldName = "EsTelefono"
        Me.colEsTelefono.Name = "colEsTelefono"
        Me.colEsTelefono.Visible = True
        Me.colEsTelefono.VisibleIndex = 7
        '
        'colEsServicio
        '
        Me.colEsServicio.FieldName = "EsServicio"
        Me.colEsServicio.Name = "colEsServicio"
        Me.colEsServicio.Visible = True
        Me.colEsServicio.VisibleIndex = 8
        '
        'colFechaCobro
        '
        Me.colFechaCobro.FieldName = "FechaCobro"
        Me.colFechaCobro.Name = "colFechaCobro"
        Me.colFechaCobro.Visible = True
        Me.colFechaCobro.VisibleIndex = 9
        '
        'colNoCuota
        '
        Me.colNoCuota.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNoCuota.FieldName = "NoCuota"
        Me.colNoCuota.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNoCuota.Name = "colNoCuota"
        Me.colNoCuota.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "NoCuota", "{0:n2}")})
        Me.colNoCuota.Visible = True
        Me.colNoCuota.VisibleIndex = 10
        '
        'colMonto
        '
        Me.colMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto.FieldName = "Monto"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Monto", "{0:n2}")})
        Me.colMonto.Visible = True
        Me.colMonto.VisibleIndex = 11
        '
        'colAbonado
        '
        Me.colAbonado.FieldName = "Abonado"
        Me.colAbonado.Name = "colAbonado"
        Me.colAbonado.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Abonado", "{0:n2}")})
        Me.colAbonado.Visible = True
        Me.colAbonado.VisibleIndex = 12
        '
        'colpagada
        '
        Me.colpagada.FieldName = "pagada"
        Me.colpagada.Name = "colpagada"
        Me.colpagada.Visible = True
        Me.colpagada.VisibleIndex = 13
        '
        'colTipoDescuento
        '
        Me.colTipoDescuento.FieldName = "TipoDescuento"
        Me.colTipoDescuento.Name = "colTipoDescuento"
        Me.colTipoDescuento.Visible = True
        Me.colTipoDescuento.VisibleIndex = 14
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdImprimir, Me.cmdActualizar})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 2
        '
        'Bar2
        '
        Me.Bar2.BarName = "Menú principal"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdImprimir), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdActualizar)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Menú principal"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Caption = "Imprimir"
        Me.cmdImprimir.Id = 0
        Me.cmdImprimir.Name = "cmdImprimir"
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Caption = "Actualizar"
        Me.cmdActualizar.Id = 1
        Me.cmdActualizar.Name = "cmdActualizar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(757, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 372)
        Me.barDockControlBottom.Size = New System.Drawing.Size(757, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 350)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(757, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 350)
        '
        'DtDescuentoDetRepGridTableAdapter1
        '
        Me.DtDescuentoDetRepGridTableAdapter1.ClearBeforeFill = True
        '
        'frmReporteGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 372)
        Me.Controls.Add(Me.dgrid)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmReporteGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsetRep1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DsetRep1 As zfranqui.DsetRep
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModelo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoChasis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoPlaca As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMotor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmpresaTelco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEsVehiculo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEsTelefono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEsServicio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaCobro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoCuota As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAbonado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpagada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DtDescuentoDetRepGridTableAdapter1 As zfranqui.DsetRepTableAdapters.dtDescuentoDetRepGridTableAdapter
End Class
