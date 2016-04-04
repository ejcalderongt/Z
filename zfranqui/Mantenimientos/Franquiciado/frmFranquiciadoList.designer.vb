<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFranquiciadoList
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFranquiciadoList))
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.lblReg = New DevExpress.XtraBars.BarStaticItem()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.mnuNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuSvyuslixst = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuSalir = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Dgrid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtFiltro = New DevExpress.XtraEditors.TextEdit()
        Me.lblFiltro = New DevExpress.XtraEditors.LabelControl()
        Me.lblRegs = New DevExpress.XtraBars.BarStaticItem()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFiltro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.lblReg)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 469)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar.Size = New System.Drawing.Size(860, 31)
        '
        'lblReg
        '
        Me.lblReg.Caption = "Registros: 0"
        Me.lblReg.Id = 5
        Me.lblReg.Name = "lblReg"
        Me.lblReg.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.mnuNuevo, Me.mnuSvyuslixst, Me.mnuSalir, Me.mnuImprimir, Me.lblReg})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(860, 144)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar
        '
        'mnuNuevo
        '
        Me.mnuNuevo.Caption = "Nuevo"
        Me.mnuNuevo.Glyph = CType(resources.GetObject("mnuNuevo.Glyph"), System.Drawing.Image)
        Me.mnuNuevo.Id = 1
        Me.mnuNuevo.LargeGlyph = CType(resources.GetObject("mnuNuevo.LargeGlyph"), System.Drawing.Image)
        Me.mnuNuevo.Name = "mnuNuevo"
        '
        'mnuSvyuslixst
        '
        Me.mnuSvyuslixst.Caption = "Actualizar"
        Me.mnuSvyuslixst.Glyph = CType(resources.GetObject("mnuSvyuslixst.Glyph"), System.Drawing.Image)
        Me.mnuSvyuslixst.Id = 2
        Me.mnuSvyuslixst.LargeGlyph = CType(resources.GetObject("mnuSvyuslixst.LargeGlyph"), System.Drawing.Image)
        Me.mnuSvyuslixst.Name = "mnuSvyuslixst"
        '
        'mnuSalir
        '
        Me.mnuSalir.Caption = "Salir"
        Me.mnuSalir.Glyph = CType(resources.GetObject("mnuSalir.Glyph"), System.Drawing.Image)
        Me.mnuSalir.Id = 3
        Me.mnuSalir.LargeGlyph = CType(resources.GetObject("mnuSalir.LargeGlyph"), System.Drawing.Image)
        Me.mnuSalir.Name = "mnuSalir"
        '
        'mnuImprimir
        '
        Me.mnuImprimir.Caption = "Imprimir"
        Me.mnuImprimir.Glyph = CType(resources.GetObject("mnuImprimir.Glyph"), System.Drawing.Image)
        Me.mnuImprimir.Id = 4
        Me.mnuImprimir.LargeGlyph = CType(resources.GetObject("mnuImprimir.LargeGlyph"), System.Drawing.Image)
        Me.mnuImprimir.Name = "mnuImprimir"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Menú"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.mnuNuevo)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.mnuSvyuslixst)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.mnuSalir)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.mnuImprimir)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'Dgrid
        '
        Me.Dgrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.Dgrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Dgrid.Location = New System.Drawing.Point(0, 215)
        Me.Dgrid.MainView = Me.GridView1
        Me.Dgrid.Name = "Dgrid"
        Me.Dgrid.Size = New System.Drawing.Size(860, 254)
        Me.Dgrid.TabIndex = 2
        Me.Dgrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Dgrid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'txtFiltro
        '
        Me.txtFiltro.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtFiltro.EditValue = ""
        Me.txtFiltro.Location = New System.Drawing.Point(0, 193)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtFiltro.Size = New System.Drawing.Size(860, 22)
        Me.txtFiltro.TabIndex = 1
        Me.txtFiltro.Tag = "Buscar..."
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblFiltro.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblFiltro.LineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        Me.lblFiltro.LineVisible = True
        Me.lblFiltro.Location = New System.Drawing.Point(0, 180)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(860, 13)
        Me.lblFiltro.TabIndex = 0
        Me.lblFiltro.Text = "Filtro"
        '
        'lblRegs
        '
        Me.lblRegs.Caption = "Registros: 0"
        Me.lblRegs.Id = 5
        Me.lblRegs.Name = "lblRegs"
        Me.lblRegs.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'frmFranquiciadoList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 500)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.Dgrid)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "frmFranquiciadoList"
        Me.Ribbon = Me.RibbonControl1
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Listado de franquiciados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFiltro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents Dgrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtFiltro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFiltro As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents mnuNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuSvyuslixst As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuSalir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents lblReg As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblRegs As DevExpress.XtraBars.BarStaticItem


End Class
