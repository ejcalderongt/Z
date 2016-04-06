<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDescuento
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
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescuento))
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.mnuGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdImprimir = New DevExpress.XtraBars.BarSubItem()
        Me.mnuDetalleCuotas = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.User_agrTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Fec_agrDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.User_modTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Fec_modDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.PanBitacora = New DevExpress.XtraEditors.GroupControl()
        Me.PanDatosUsuario = New DevExpress.XtraEditors.GroupControl()
        Me.chkDescuentosActivos = New System.Windows.Forms.CheckBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lnkFranquiciado = New System.Windows.Forms.LinkLabel()
        Me.txtCodCEF = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoFranquiciado = New DevExpress.XtraEditors.TextEdit()
        Me.txtNomCEF = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombres = New DevExpress.XtraEditors.TextEdit()
        Me.txtApellidos = New DevExpress.XtraEditors.TextEdit()
        Me.Dgrid = New DevExpress.XtraGrid.GridControl()
        Me.GridViewDescuento = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.cmdAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAnularDescuento = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabCuota = New System.Windows.Forms.TabPage()
        Me.GrpTiempoAceptacion = New DevExpress.XtraEditors.GroupControl()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.mnuEliminarCuota = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridCuota = New DevExpress.XtraGrid.GridControl()
        Me.GridViewCuota = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TaDetalle = New System.Windows.Forms.TabPage()
        Me.GrpCliente = New DevExpress.XtraEditors.GroupControl()
        Me.TabDato = New System.Windows.Forms.TabControl()
        User_agrLabel = New System.Windows.Forms.Label()
        Fec_agrLabel = New System.Windows.Forms.Label()
        User_modLabel = New System.Windows.Forms.Label()
        Fec_modLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        lblCEF = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_agrTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fec_agrDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fec_agrDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_modTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fec_modDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fec_modDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanBitacora.SuspendLayout()
        CType(Me.PanDatosUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanDatosUsuario.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtCodCEF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFranquiciado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomCEF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.tabCuota.SuspendLayout()
        CType(Me.GrpTiempoAceptacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpTiempoAceptacion.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.GridCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaDetalle.SuspendLayout()
        CType(Me.GrpCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpCliente.SuspendLayout()
        Me.TabDato.SuspendLayout()
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
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(41, 34)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(62, 13)
        Label3.TabIndex = 5
        Label3.Text = "Descuento:"
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.mnuGuardar, Me.mnuActualizar, Me.mnuEliminar, Me.cmdImprimir, Me.mnuDetalleCuotas})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 5
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
        Me.mnuEliminar.Caption = "Anular"
        Me.mnuEliminar.Glyph = CType(resources.GetObject("mnuEliminar.Glyph"), System.Drawing.Image)
        Me.mnuEliminar.Id = 3
        Me.mnuEliminar.LargeGlyph = CType(resources.GetObject("mnuEliminar.LargeGlyph"), System.Drawing.Image)
        Me.mnuEliminar.Name = "mnuEliminar"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Caption = "Imprimir"
        Me.cmdImprimir.Glyph = CType(resources.GetObject("cmdImprimir.Glyph"), System.Drawing.Image)
        Me.cmdImprimir.Id = 3
        Me.cmdImprimir.LargeGlyph = CType(resources.GetObject("cmdImprimir.LargeGlyph"), System.Drawing.Image)
        Me.cmdImprimir.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mnuDetalleCuotas)})
        Me.cmdImprimir.Name = "cmdImprimir"
        '
        'mnuDetalleCuotas
        '
        Me.mnuDetalleCuotas.Caption = "Detalle de cuotas"
        Me.mnuDetalleCuotas.Id = 4
        Me.mnuDetalleCuotas.Name = "mnuDetalleCuotas"
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
        Me.RibbonPageGroup1.ItemLinks.Add(Me.cmdImprimir)
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
        'PanDatosUsuario
        '
        Me.PanDatosUsuario.Controls.Add(Me.chkDescuentosActivos)
        Me.PanDatosUsuario.Controls.Add(Me.lblCodigo)
        Me.PanDatosUsuario.Controls.Add(Label3)
        Me.PanDatosUsuario.Controls.Add(Me.GroupControl1)
        Me.PanDatosUsuario.Location = New System.Drawing.Point(12, 160)
        Me.PanDatosUsuario.Name = "PanDatosUsuario"
        Me.PanDatosUsuario.Size = New System.Drawing.Size(997, 183)
        Me.PanDatosUsuario.TabIndex = 0
        Me.PanDatosUsuario.Text = "Datos generales del descuento"
        '
        'chkDescuentosActivos
        '
        Me.chkDescuentosActivos.AutoSize = True
        Me.chkDescuentosActivos.Checked = True
        Me.chkDescuentosActivos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDescuentosActivos.Location = New System.Drawing.Point(816, 43)
        Me.chkDescuentosActivos.Name = "chkDescuentosActivos"
        Me.chkDescuentosActivos.Size = New System.Drawing.Size(158, 17)
        Me.chkDescuentosActivos.TabIndex = 7
        Me.chkDescuentosActivos.Text = "Mostrar descuentos activos"
        Me.chkDescuentosActivos.UseVisualStyleBackColor = True
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(154, 34)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(0, 13)
        Me.lblCodigo.TabIndex = 73
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
        Me.GroupControl1.Location = New System.Drawing.Point(16, 66)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(958, 95)
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
        Me.txtNombres.Location = New System.Drawing.Point(141, 52)
        Me.txtNombres.MenuManager = Me.RibbonControl
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Properties.MaxLength = 50
        Me.txtNombres.Size = New System.Drawing.Size(243, 20)
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
        'Dgrid
        '
        Me.Dgrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.Dgrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgrid.Location = New System.Drawing.Point(2, 45)
        Me.Dgrid.MainView = Me.GridViewDescuento
        Me.Dgrid.Name = "Dgrid"
        Me.Dgrid.Size = New System.Drawing.Size(979, 222)
        Me.Dgrid.TabIndex = 27
        Me.Dgrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewDescuento})
        '
        'GridViewDescuento
        '
        Me.GridViewDescuento.GridControl = Me.Dgrid
        Me.GridViewDescuento.Name = "GridViewDescuento"
        Me.GridViewDescuento.OptionsBehavior.Editable = False
        Me.GridViewDescuento.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridViewDescuento.OptionsView.ShowFooter = True
        Me.GridViewDescuento.OptionsView.ShowGroupPanel = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAgregar, Me.mnuAnularDescuento})
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
        Me.cmdAgregar.Size = New System.Drawing.Size(77, 20)
        Me.cmdAgregar.Text = "Agregar"
        '
        'mnuAnularDescuento
        '
        Me.mnuAnularDescuento.Image = Global.zfranqui.My.Resources.Resources._error
        Me.mnuAnularDescuento.Name = "mnuAnularDescuento"
        Me.mnuAnularDescuento.Size = New System.Drawing.Size(78, 20)
        Me.mnuAnularDescuento.Text = "Eliminar"
        '
        'tabCuota
        '
        Me.tabCuota.Controls.Add(Me.GrpTiempoAceptacion)
        Me.tabCuota.Location = New System.Drawing.Point(4, 22)
        Me.tabCuota.Name = "tabCuota"
        Me.tabCuota.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCuota.Size = New System.Drawing.Size(989, 275)
        Me.tabCuota.TabIndex = 1
        Me.tabCuota.Text = "Detalle de Cuotas"
        Me.tabCuota.UseVisualStyleBackColor = True
        '
        'GrpTiempoAceptacion
        '
        Me.GrpTiempoAceptacion.Controls.Add(Me.MenuStrip2)
        Me.GrpTiempoAceptacion.Controls.Add(Me.GridCuota)
        Me.GrpTiempoAceptacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpTiempoAceptacion.Location = New System.Drawing.Point(3, 3)
        Me.GrpTiempoAceptacion.Name = "GrpTiempoAceptacion"
        Me.GrpTiempoAceptacion.Size = New System.Drawing.Size(983, 269)
        Me.GrpTiempoAceptacion.TabIndex = 1
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEliminarCuota})
        Me.MenuStrip2.Location = New System.Drawing.Point(2, 21)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(979, 24)
        Me.MenuStrip2.TabIndex = 29
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'mnuEliminarCuota
        '
        Me.mnuEliminarCuota.Image = Global.zfranqui.My.Resources.Resources._error
        Me.mnuEliminarCuota.Name = "mnuEliminarCuota"
        Me.mnuEliminarCuota.Size = New System.Drawing.Size(70, 20)
        Me.mnuEliminarCuota.Text = "Anular"
        '
        'GridCuota
        '
        Me.GridCuota.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridCuota.Dock = System.Windows.Forms.DockStyle.Bottom
        GridLevelNode2.RelationName = "Level1"
        Me.GridCuota.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.GridCuota.Location = New System.Drawing.Point(2, 49)
        Me.GridCuota.MainView = Me.GridViewCuota
        Me.GridCuota.Name = "GridCuota"
        Me.GridCuota.Size = New System.Drawing.Size(979, 218)
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
        Me.TaDetalle.Size = New System.Drawing.Size(989, 275)
        Me.TaDetalle.TabIndex = 0
        Me.TaDetalle.Text = "Detalle de Descuentos"
        '
        'GrpCliente
        '
        Me.GrpCliente.Controls.Add(Me.Dgrid)
        Me.GrpCliente.Controls.Add(Me.MenuStrip1)
        Me.GrpCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpCliente.Location = New System.Drawing.Point(3, 3)
        Me.GrpCliente.Name = "GrpCliente"
        Me.GrpCliente.Size = New System.Drawing.Size(983, 269)
        Me.GrpCliente.TabIndex = 0
        '
        'TabDato
        '
        Me.TabDato.Controls.Add(Me.TaDetalle)
        Me.TabDato.Controls.Add(Me.tabCuota)
        Me.TabDato.Location = New System.Drawing.Point(12, 349)
        Me.TabDato.Name = "TabDato"
        Me.TabDato.SelectedIndex = 0
        Me.TabDato.Size = New System.Drawing.Size(997, 301)
        Me.TabDato.TabIndex = 5
        '
        'frmDescuento
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1031, 750)
        Me.Controls.Add(Me.TabDato)
        Me.Controls.Add(Me.PanDatosUsuario)
        Me.Controls.Add(Me.PanBitacora)
        Me.Controls.Add(Me.RibbonControl)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDescuento"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento de descuentos a Franquiciados"
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
        CType(Me.PanDatosUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanDatosUsuario.ResumeLayout(False)
        Me.PanDatosUsuario.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtCodCEF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFranquiciado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomCEF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tabCuota.ResumeLayout(False)
        CType(Me.GrpTiempoAceptacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpTiempoAceptacion.ResumeLayout(False)
        Me.GrpTiempoAceptacion.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.GridCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaDetalle.ResumeLayout(False)
        CType(Me.GrpCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpCliente.ResumeLayout(False)
        Me.GrpCliente.PerformLayout()
        Me.TabDato.ResumeLayout(False)
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
    Private WithEvents PanDatosUsuario As DevExpress.XtraEditors.GroupControl
    Private WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCodigoFranquiciado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtApellidos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lnkFranquiciado As System.Windows.Forms.LinkLabel
    Friend WithEvents txtCodCEF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomCEF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents cmdAgregar As ToolStripMenuItem
    Friend WithEvents Dgrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewDescuento As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents tabCuota As System.Windows.Forms.TabPage
    Friend WithEvents GrpTiempoAceptacion As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TaDetalle As System.Windows.Forms.TabPage
    Friend WithEvents GrpCliente As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TabDato As System.Windows.Forms.TabControl
    Friend WithEvents GridCuota As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCuota As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdImprimir As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuDetalleCuotas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuAnularDescuento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkDescuentosActivos As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuEliminarCuota As System.Windows.Forms.ToolStripMenuItem
End Class
