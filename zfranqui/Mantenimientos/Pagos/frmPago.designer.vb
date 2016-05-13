<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPago
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim User_agrLabel As System.Windows.Forms.Label
        Dim Fec_agrLabel As System.Windows.Forms.Label
        Dim User_modLabel As System.Windows.Forms.Label
        Dim Fec_modLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim lblCEF As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPago))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.mnuGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdImprimir1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.User_agrTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Fec_agrDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.User_modTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Fec_modDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.PanBitacora = New DevExpress.XtraEditors.GroupControl()
        Me.GridDescuento = New DevExpress.XtraGrid.GridControl()
        Me.GridViewDescuento = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabCuota = New System.Windows.Forms.TabPage()
        Me.GrpTiempoAceptacion = New DevExpress.XtraEditors.GroupControl()
        Me.GridCuota = New DevExpress.XtraGrid.GridControl()
        Me.GridViewCuota = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TaDetalle = New System.Windows.Forms.TabPage()
        Me.GrpCliente = New DevExpress.XtraEditors.GroupControl()
        Me.TabDato = New System.Windows.Forms.TabControl()
        Me.TabPagosRealizados = New System.Windows.Forms.TabPage()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridPago = New DevExpress.XtraGrid.GridControl()
        Me.GridViewPago = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lnkFranquiciado = New System.Windows.Forms.LinkLabel()
        Me.txtCodCEF = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoFranquiciado = New DevExpress.XtraEditors.TextEdit()
        Me.txtNomCEF = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombres = New DevExpress.XtraEditors.TextEdit()
        Me.txtApellidos = New DevExpress.XtraEditors.TextEdit()
        User_agrLabel = New System.Windows.Forms.Label()
        Fec_agrLabel = New System.Windows.Forms.Label()
        User_modLabel = New System.Windows.Forms.Label()
        Fec_modLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        lblCEF = New System.Windows.Forms.Label()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_agrTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fec_agrDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fec_agrDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_modTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fec_modDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fec_modDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanBitacora.SuspendLayout()
        CType(Me.GridDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.tabCuota.SuspendLayout()
        CType(Me.GrpTiempoAceptacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpTiempoAceptacion.SuspendLayout()
        CType(Me.GridCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaDetalle.SuspendLayout()
        CType(Me.GrpCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpCliente.SuspendLayout()
        Me.TabDato.SuspendLayout()
        Me.TabPagosRealizados.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtCodCEF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFranquiciado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomCEF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'User_agrLabel
        '
        User_agrLabel.AutoSize = True
        User_agrLabel.Location = New System.Drawing.Point(155, 31)
        User_agrLabel.Name = "User_agrLabel"
        User_agrLabel.Size = New System.Drawing.Size(51, 13)
        User_agrLabel.TabIndex = 2
        User_agrLabel.Text = "user agr:"
        '
        'Fec_agrLabel
        '
        Fec_agrLabel.AutoSize = True
        Fec_agrLabel.Location = New System.Drawing.Point(155, 57)
        Fec_agrLabel.Name = "Fec_agrLabel"
        Fec_agrLabel.Size = New System.Drawing.Size(45, 13)
        Fec_agrLabel.TabIndex = 6
        Fec_agrLabel.Text = "fec agr:"
        '
        'User_modLabel
        '
        User_modLabel.AutoSize = True
        User_modLabel.Location = New System.Drawing.Point(442, 31)
        User_modLabel.Name = "User_modLabel"
        User_modLabel.Size = New System.Drawing.Size(55, 13)
        User_modLabel.TabIndex = 0
        User_modLabel.Text = "user mod:"
        '
        'Fec_modLabel
        '
        Fec_modLabel.AutoSize = True
        Fec_modLabel.Location = New System.Drawing.Point(442, 57)
        Fec_modLabel.Name = "Fec_modLabel"
        Fec_modLabel.Size = New System.Drawing.Size(49, 13)
        Fec_modLabel.TabIndex = 4
        Fec_modLabel.Text = "fec mod:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Enabled = False
        Label1.Location = New System.Drawing.Point(390, 36)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(49, 13)
        Label1.TabIndex = 6
        Label1.Text = "Apellidos"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Enabled = False
        NombresLabel.Location = New System.Drawing.Point(138, 36)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(49, 13)
        NombresLabel.TabIndex = 4
        NombresLabel.Text = "Nombres"
        '
        'lblCEF
        '
        lblCEF.AutoSize = True
        lblCEF.Enabled = False
        lblCEF.Location = New System.Drawing.Point(636, 36)
        lblCEF.Name = "lblCEF"
        lblCEF.Size = New System.Drawing.Size(26, 13)
        lblCEF.TabIndex = 39
        lblCEF.Text = "CEF"
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.mnuGuardar, Me.mnuActualizar, Me.mnuEliminar, Me.cmdImprimir1})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 2
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(1031, 144)
        '
        'mnuGuardar
        '
        Me.mnuGuardar.Caption = "Guardar"
        Me.mnuGuardar.Glyph = CType(resources.GetObject("mnuGuardar.Glyph"), System.Drawing.Image)
        Me.mnuGuardar.Id = 1
        Me.mnuGuardar.LargeGlyph = CType(resources.GetObject("mnuGuardar.LargeGlyph"), System.Drawing.Image)
        Me.mnuGuardar.Name = "mnuGuardar"
        '
        'mnuActualizar
        '
        Me.mnuActualizar.Caption = "Actualizar"
        Me.mnuActualizar.Glyph = CType(resources.GetObject("mnuActualizar.Glyph"), System.Drawing.Image)
        Me.mnuActualizar.Id = 2
        Me.mnuActualizar.LargeGlyph = CType(resources.GetObject("mnuActualizar.LargeGlyph"), System.Drawing.Image)
        Me.mnuActualizar.Name = "mnuActualizar"
        '
        'mnuEliminar
        '
        Me.mnuEliminar.Caption = "Eliminar"
        Me.mnuEliminar.Glyph = CType(resources.GetObject("mnuEliminar.Glyph"), System.Drawing.Image)
        Me.mnuEliminar.Id = 3
        Me.mnuEliminar.LargeGlyph = CType(resources.GetObject("mnuEliminar.LargeGlyph"), System.Drawing.Image)
        Me.mnuEliminar.Name = "mnuEliminar"
        Me.mnuEliminar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'cmdImprimir1
        '
        Me.cmdImprimir1.Caption = "Imprimir"
        Me.cmdImprimir1.Id = 1
        Me.cmdImprimir1.Name = "cmdImprimir1"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Menú"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.mnuGuardar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.mnuActualizar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.mnuEliminar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.cmdImprimir1)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'User_agrTextEdit
        '
        Me.User_agrTextEdit.Enabled = False
        Me.User_agrTextEdit.Location = New System.Drawing.Point(225, 28)
        Me.User_agrTextEdit.MenuManager = Me.RibbonControl
        Me.User_agrTextEdit.Name = "User_agrTextEdit"
        Me.User_agrTextEdit.Size = New System.Drawing.Size(187, 20)
        Me.User_agrTextEdit.TabIndex = 3
        '
        'Fec_agrDateEdit
        '
        Me.Fec_agrDateEdit.EditValue = Nothing
        Me.Fec_agrDateEdit.Enabled = False
        Me.Fec_agrDateEdit.Location = New System.Drawing.Point(225, 54)
        Me.Fec_agrDateEdit.MenuManager = Me.RibbonControl
        Me.Fec_agrDateEdit.Name = "Fec_agrDateEdit"
        Me.Fec_agrDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fec_agrDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fec_agrDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.Fec_agrDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Fec_agrDateEdit.Size = New System.Drawing.Size(187, 20)
        Me.Fec_agrDateEdit.TabIndex = 7
        '
        'User_modTextEdit
        '
        Me.User_modTextEdit.Enabled = False
        Me.User_modTextEdit.Location = New System.Drawing.Point(512, 28)
        Me.User_modTextEdit.MenuManager = Me.RibbonControl
        Me.User_modTextEdit.Name = "User_modTextEdit"
        Me.User_modTextEdit.Size = New System.Drawing.Size(187, 20)
        Me.User_modTextEdit.TabIndex = 1
        '
        'Fec_modDateEdit
        '
        Me.Fec_modDateEdit.EditValue = Nothing
        Me.Fec_modDateEdit.Enabled = False
        Me.Fec_modDateEdit.Location = New System.Drawing.Point(512, 54)
        Me.Fec_modDateEdit.MenuManager = Me.RibbonControl
        Me.Fec_modDateEdit.Name = "Fec_modDateEdit"
        Me.Fec_modDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fec_modDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fec_modDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.Fec_modDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Fec_modDateEdit.Size = New System.Drawing.Size(187, 20)
        Me.Fec_modDateEdit.TabIndex = 5
        '
        'PanBitacora
        '
        Me.PanBitacora.Controls.Add(User_agrLabel)
        Me.PanBitacora.Controls.Add(Me.User_agrTextEdit)
        Me.PanBitacora.Controls.Add(Fec_agrLabel)
        Me.PanBitacora.Controls.Add(Me.Fec_agrDateEdit)
        Me.PanBitacora.Controls.Add(User_modLabel)
        Me.PanBitacora.Controls.Add(Me.User_modTextEdit)
        Me.PanBitacora.Controls.Add(Fec_modLabel)
        Me.PanBitacora.Controls.Add(Me.Fec_modDateEdit)
        Me.PanBitacora.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanBitacora.Location = New System.Drawing.Point(0, 656)
        Me.PanBitacora.Name = "PanBitacora"
        Me.PanBitacora.Size = New System.Drawing.Size(1031, 94)
        Me.PanBitacora.TabIndex = 1
        Me.PanBitacora.Text = "Bitácora"
        '
        'GridDescuento
        '
        Me.GridDescuento.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridDescuento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDescuento.Location = New System.Drawing.Point(2, 45)
        Me.GridDescuento.MainView = Me.GridViewDescuento
        Me.GridDescuento.Name = "GridDescuento"
        Me.GridDescuento.Size = New System.Drawing.Size(979, 266)
        Me.GridDescuento.TabIndex = 27
        Me.GridDescuento.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewDescuento})
        '
        'GridViewDescuento
        '
        Me.GridViewDescuento.GridControl = Me.GridDescuento
        Me.GridViewDescuento.Name = "GridViewDescuento"
        Me.GridViewDescuento.OptionsBehavior.Editable = False
        Me.GridViewDescuento.OptionsView.ShowFooter = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar})
        Me.MenuStrip1.Location = New System.Drawing.Point(2, 21)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(979, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Image = Global.zfranqui.My.Resources.Resources.add
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(65, 20)
        Me.cmdAgregar.Text = "Pagar"
        '
        'tabCuota
        '
        Me.tabCuota.Controls.Add(Me.GrpTiempoAceptacion)
        Me.tabCuota.Location = New System.Drawing.Point(4, 22)
        Me.tabCuota.Name = "tabCuota"
        Me.tabCuota.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCuota.Size = New System.Drawing.Size(989, 319)
        Me.tabCuota.TabIndex = 1
        Me.tabCuota.Text = "Detalle de Cuotas"
        Me.tabCuota.UseVisualStyleBackColor = True
        '
        'GrpTiempoAceptacion
        '
        Me.GrpTiempoAceptacion.Controls.Add(Me.GridCuota)
        Me.GrpTiempoAceptacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpTiempoAceptacion.Location = New System.Drawing.Point(3, 3)
        Me.GrpTiempoAceptacion.Name = "GrpTiempoAceptacion"
        Me.GrpTiempoAceptacion.Size = New System.Drawing.Size(983, 313)
        Me.GrpTiempoAceptacion.TabIndex = 1
        '
        'GridCuota
        '
        Me.GridCuota.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridCuota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCuota.Location = New System.Drawing.Point(2, 21)
        Me.GridCuota.MainView = Me.GridViewCuota
        Me.GridCuota.Name = "GridCuota"
        Me.GridCuota.Size = New System.Drawing.Size(979, 290)
        Me.GridCuota.TabIndex = 28
        Me.GridCuota.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCuota})
        '
        'GridViewCuota
        '
        Me.GridViewCuota.GridControl = Me.GridCuota
        Me.GridViewCuota.Name = "GridViewCuota"
        Me.GridViewCuota.OptionsBehavior.Editable = False
        Me.GridViewCuota.OptionsView.ShowFooter = True
        '
        'GridView3
        '
        Me.GridView3.Name = "GridView3"
        '
        'TaDetalle
        '
        Me.TaDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.TaDetalle.Controls.Add(Me.GrpCliente)
        Me.TaDetalle.Location = New System.Drawing.Point(4, 22)
        Me.TaDetalle.Name = "TaDetalle"
        Me.TaDetalle.Padding = New System.Windows.Forms.Padding(3)
        Me.TaDetalle.Size = New System.Drawing.Size(989, 319)
        Me.TaDetalle.TabIndex = 0
        Me.TaDetalle.Text = "Detalle de Descuentos"
        '
        'GrpCliente
        '
        Me.GrpCliente.Controls.Add(Me.GridDescuento)
        Me.GrpCliente.Controls.Add(Me.MenuStrip1)
        Me.GrpCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpCliente.Location = New System.Drawing.Point(3, 3)
        Me.GrpCliente.Name = "GrpCliente"
        Me.GrpCliente.Size = New System.Drawing.Size(983, 313)
        Me.GrpCliente.TabIndex = 0
        '
        'TabDato
        '
        Me.TabDato.Controls.Add(Me.TaDetalle)
        Me.TabDato.Controls.Add(Me.tabCuota)
        Me.TabDato.Controls.Add(Me.TabPagosRealizados)
        Me.TabDato.Location = New System.Drawing.Point(12, 305)
        Me.TabDato.Name = "TabDato"
        Me.TabDato.SelectedIndex = 0
        Me.TabDato.Size = New System.Drawing.Size(997, 345)
        Me.TabDato.TabIndex = 5
        '
        'TabPagosRealizados
        '
        Me.TabPagosRealizados.Controls.Add(Me.GroupControl2)
        Me.TabPagosRealizados.Location = New System.Drawing.Point(4, 22)
        Me.TabPagosRealizados.Name = "TabPagosRealizados"
        Me.TabPagosRealizados.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagosRealizados.Size = New System.Drawing.Size(989, 319)
        Me.TabPagosRealizados.TabIndex = 2
        Me.TabPagosRealizados.Text = "Detalle de Pagos Realizados"
        Me.TabPagosRealizados.UseVisualStyleBackColor = True
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GridPago)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(983, 313)
        Me.GroupControl2.TabIndex = 2
        '
        'GridPago
        '
        Me.GridPago.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridPago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPago.Location = New System.Drawing.Point(2, 21)
        Me.GridPago.MainView = Me.GridViewPago
        Me.GridPago.Name = "GridPago"
        Me.GridPago.Size = New System.Drawing.Size(979, 290)
        Me.GridPago.TabIndex = 28
        Me.GridPago.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPago})
        '
        'GridViewPago
        '
        Me.GridViewPago.GridControl = Me.GridPago
        Me.GridViewPago.Name = "GridViewPago"
        Me.GridViewPago.OptionsBehavior.Editable = False
        Me.GridViewPago.OptionsView.ShowFooter = True
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lnkFranquiciado)
        Me.GroupControl1.Controls.Add(lblCEF)
        Me.GroupControl1.Controls.Add(Me.txtCodCEF)
        Me.GroupControl1.Controls.Add(Me.txtCodigoFranquiciado)
        Me.GroupControl1.Controls.Add(NombresLabel)
        Me.GroupControl1.Controls.Add(Me.txtNomCEF)
        Me.GroupControl1.Controls.Add(Me.txtNombres)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(Me.txtApellidos)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 178)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(907, 121)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Datos Franquiciado"
        '
        'lnkFranquiciado
        '
        Me.lnkFranquiciado.AutoSize = True
        Me.lnkFranquiciado.Location = New System.Drawing.Point(25, 36)
        Me.lnkFranquiciado.Name = "lnkFranquiciado"
        Me.lnkFranquiciado.Size = New System.Drawing.Size(40, 13)
        Me.lnkFranquiciado.TabIndex = 40
        Me.lnkFranquiciado.TabStop = True
        Me.lnkFranquiciado.Text = "Código"
        '
        'txtCodCEF
        '
        Me.txtCodCEF.EditValue = ""
        Me.txtCodCEF.Enabled = False
        Me.txtCodCEF.Location = New System.Drawing.Point(637, 52)
        Me.txtCodCEF.MenuManager = Me.RibbonControl
        Me.txtCodCEF.Name = "txtCodCEF"
        Me.txtCodCEF.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodCEF.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodCEF.Properties.MaxLength = 10
        Me.txtCodCEF.Size = New System.Drawing.Size(74, 20)
        Me.txtCodCEF.TabIndex = 24
        '
        'txtCodigoFranquiciado
        '
        Me.txtCodigoFranquiciado.EditValue = ""
        Me.txtCodigoFranquiciado.Location = New System.Drawing.Point(28, 52)
        Me.txtCodigoFranquiciado.MenuManager = Me.RibbonControl
        Me.txtCodigoFranquiciado.Name = "txtCodigoFranquiciado"
        Me.txtCodigoFranquiciado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigoFranquiciado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigoFranquiciado.Properties.MaxLength = 10
        Me.txtCodigoFranquiciado.Size = New System.Drawing.Size(103, 20)
        Me.txtCodigoFranquiciado.TabIndex = 3
        '
        'txtNomCEF
        '
        Me.txtNomCEF.Enabled = False
        Me.txtNomCEF.Location = New System.Drawing.Point(714, 52)
        Me.txtNomCEF.MenuManager = Me.RibbonControl
        Me.txtNomCEF.Name = "txtNomCEF"
        Me.txtNomCEF.Properties.MaxLength = 50
        Me.txtNomCEF.Size = New System.Drawing.Size(166, 20)
        Me.txtNomCEF.TabIndex = 25
        '
        'txtNombres
        '
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(137, 52)
        Me.txtNombres.MenuManager = Me.RibbonControl
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Properties.MaxLength = 50
        Me.txtNombres.Size = New System.Drawing.Size(247, 20)
        Me.txtNombres.TabIndex = 5
        '
        'txtApellidos
        '
        Me.txtApellidos.Enabled = False
        Me.txtApellidos.Location = New System.Drawing.Point(390, 52)
        Me.txtApellidos.MenuManager = Me.RibbonControl
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Properties.MaxLength = 50
        Me.txtApellidos.Size = New System.Drawing.Size(243, 20)
        Me.txtApellidos.TabIndex = 7
        '
        'frmPago
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1031, 750)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.TabDato)
        Me.Controls.Add(Me.PanBitacora)
        Me.Controls.Add(Me.RibbonControl)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPago"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pagos de franquiciado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_agrTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fec_agrDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fec_agrDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_modTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fec_modDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fec_modDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanBitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanBitacora.ResumeLayout(False)
        Me.PanBitacora.PerformLayout()
        CType(Me.GridDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tabCuota.ResumeLayout(False)
        CType(Me.GrpTiempoAceptacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpTiempoAceptacion.ResumeLayout(False)
        CType(Me.GridCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaDetalle.ResumeLayout(False)
        CType(Me.GrpCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpCliente.ResumeLayout(False)
        Me.GrpCliente.PerformLayout()
        Me.TabDato.ResumeLayout(False)
        Me.TabPagosRealizados.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtCodCEF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFranquiciado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomCEF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents mnuGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents User_agrTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Fec_agrDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents User_modTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Fec_modDateEdit As DevExpress.XtraEditors.DateEdit
    Private WithEvents PanBitacora As DevExpress.XtraEditors.GroupControl
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents cmdAgregar As ToolStripMenuItem
    Friend WithEvents GridDescuento As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewDescuento As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdImprimir1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tabCuota As System.Windows.Forms.TabPage
    Friend WithEvents GrpTiempoAceptacion As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TaDetalle As System.Windows.Forms.TabPage
    Friend WithEvents GrpCliente As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TabDato As System.Windows.Forms.TabControl
    Friend WithEvents GridCuota As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCuota As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lnkFranquiciado As System.Windows.Forms.LinkLabel
    Friend WithEvents txtCodCEF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoFranquiciado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomCEF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtApellidos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TabPagosRealizados As System.Windows.Forms.TabPage
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridPago As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewPago As DevExpress.XtraGrid.Views.Grid.GridView
End Class
