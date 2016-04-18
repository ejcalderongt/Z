<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentasZ
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.cmdImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuProcesar = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuAplicarPagos = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.lbldesde = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgrid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtFiltro = New DevExpress.XtraEditors.TextEdit()
        Me.prg = New System.Windows.Forms.ProgressBar()
        Me.txt = New System.Windows.Forms.RichTextBox()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFiltro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdImprimir, Me.cmdActualizar, Me.mnuProcesar, Me.mnuAplicarPagos})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 4
        '
        'Bar2
        '
        Me.Bar2.BarName = "Menú principal"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdImprimir), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdActualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuProcesar), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuAplicarPagos)})
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
        'mnuProcesar
        '
        Me.mnuProcesar.Caption = "Importar Ventas"
        Me.mnuProcesar.Id = 2
        Me.mnuProcesar.Name = "mnuProcesar"
        '
        'mnuAplicarPagos
        '
        Me.mnuAplicarPagos.Caption = "Aplicar Pagos"
        Me.mnuAplicarPagos.Id = 3
        Me.mnuAplicarPagos.Name = "mnuAplicarPagos"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1052, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 652)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1052, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 630)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1052, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 630)
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(43, 40)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(106, 20)
        Me.dtpFechaDesde.TabIndex = 5
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(174, 40)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(106, 20)
        Me.dtpFechaHasta.TabIndex = 6
        '
        'lbldesde
        '
        Me.lbldesde.AutoSize = True
        Me.lbldesde.Location = New System.Drawing.Point(40, 24)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(38, 13)
        Me.lbldesde.TabIndex = 7
        Me.lbldesde.Text = "Desde"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(171, 24)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(35, 13)
        Me.lblHasta.TabIndex = 8
        Me.lblHasta.Text = "Hasta"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblHasta)
        Me.GroupBox1.Controls.Add(Me.lbldesde)
        Me.GroupBox1.Controls.Add(Me.dtpFechaHasta)
        Me.GroupBox1.Controls.Add(Me.dtpFechaDesde)
        Me.GroupBox1.Location = New System.Drawing.Point(265, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 87)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de fecha"
        '
        'dgrid
        '
        Me.dgrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgrid.Location = New System.Drawing.Point(0, 273)
        Me.dgrid.MainView = Me.GridView1
        Me.dgrid.MenuManager = Me.BarManager1
        Me.dgrid.Name = "dgrid"
        Me.dgrid.Size = New System.Drawing.Size(1052, 379)
        Me.dgrid.TabIndex = 17
        Me.dgrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgrid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'txtFiltro
        '
        Me.txtFiltro.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtFiltro.EditValue = ""
        Me.txtFiltro.Location = New System.Drawing.Point(0, 251)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtFiltro.Size = New System.Drawing.Size(1052, 22)
        Me.txtFiltro.TabIndex = 18
        Me.txtFiltro.Tag = "Buscar..."
        '
        'prg
        '
        Me.prg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.prg.Location = New System.Drawing.Point(0, 228)
        Me.prg.Name = "prg"
        Me.prg.Size = New System.Drawing.Size(1052, 23)
        Me.prg.TabIndex = 23
        '
        'txt
        '
        Me.txt.BackColor = System.Drawing.Color.White
        Me.txt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txt.ForeColor = System.Drawing.Color.SteelBlue
        Me.txt.Location = New System.Drawing.Point(0, 133)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(1052, 95)
        Me.txt.TabIndex = 34
        Me.txt.Text = ""
        Me.txt.Visible = False
        '
        'frmVentasZ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 652)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.prg)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.dgrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmVentasZ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta y sincronización de ventas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFiltro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents lbldesde As System.Windows.Forms.Label
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFiltro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dgrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents mnuProcesar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents prg As System.Windows.Forms.ProgressBar
    Friend WithEvents txt As System.Windows.Forms.RichTextBox
    Friend WithEvents mnuAplicarPagos As DevExpress.XtraBars.BarButtonItem
End Class
