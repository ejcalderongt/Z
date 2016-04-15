<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFranquiciado
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
        Dim lblIdFranquiciado As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim User_agrLabel As System.Windows.Forms.Label
        Dim Fec_agrLabel As System.Windows.Forms.Label
        Dim User_modLabel As System.Windows.Forms.Label
        Dim Fec_modLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim lblDPI As System.Windows.Forms.Label
        Dim lblNoCuenta As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim lblNIT As System.Windows.Forms.Label
        Dim lblDireccion As System.Windows.Forms.Label
        Dim lblCodigo As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim lblSupervisorCEF As System.Windows.Forms.Label
        Dim lblRegion As System.Windows.Forms.Label
        Dim lblMunicipio As System.Windows.Forms.Label
        Dim lblDepartamento As System.Windows.Forms.Label
        Dim lblEncargado As System.Windows.Forms.Label
        Dim lblFechaCreacion As System.Windows.Forms.Label
        Dim lblFechaAsignacion As System.Windows.Forms.Label
        Dim lblTiempoTranscurrido As System.Windows.Forms.Label
        Dim lblInterlocutor As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFranquiciado))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.mnuGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuReportesList = New DevExpress.XtraBars.BarSubItem()
        Me.cmdEstadoCuenta = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdDetalleDescuento = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdDetallePago = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdDetalleVenta = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.mnuIndefinido = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuDefinidio = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuUnico = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.txtIdFranquiciado = New DevExpress.XtraEditors.SpinEdit()
        Me.txtNombres = New DevExpress.XtraEditors.TextEdit()
        Me.User_agrTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Fec_agrDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.User_modTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Fec_modDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.PanBitacora = New DevExpress.XtraEditors.GroupControl()
        Me.PanDatosUsuario = New DevExpress.XtraEditors.GroupControl()
        Me.txtInterlocutor = New DevExpress.XtraEditors.TextEdit()
        Me.txtFechaCreacion = New DevExpress.XtraEditors.DateEdit()
        Me.txtDPI = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtNIT = New DevExpress.XtraEditors.TextEdit()
        Me.cmbBanco = New System.Windows.Forms.ComboBox()
        Me.txtNoCuenta = New DevExpress.XtraEditors.TextEdit()
        Me.txtApellidos = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtTiempoTranscurrido = New DevExpress.XtraEditors.TextEdit()
        Me.txtFechaAsignacion = New DevExpress.XtraEditors.DateEdit()
        Me.txtEncargado = New DevExpress.XtraEditors.TextEdit()
        Me.txtIdDepartamento = New DevExpress.XtraEditors.TextEdit()
        Me.txtNomDepartamento = New DevExpress.XtraEditors.TextEdit()
        Me.txtidMunicipio = New DevExpress.XtraEditors.TextEdit()
        Me.txtNomMunicipio = New DevExpress.XtraEditors.TextEdit()
        Me.txtIdRegion = New DevExpress.XtraEditors.TextEdit()
        Me.txtNomRegion = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodSupervisorCEF = New DevExpress.XtraEditors.TextEdit()
        Me.txtNomSupervisor = New DevExpress.XtraEditors.TextEdit()
        Me.lnkCEF = New System.Windows.Forms.LinkLabel()
        Me.txtCodCEF = New DevExpress.XtraEditors.TextEdit()
        Me.txtNomCEF = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtIdUsuarioAgrAsignacion = New DevExpress.XtraEditors.TextEdit()
        Me.txtFechaAgrAsignacion = New DevExpress.XtraEditors.DateEdit()
        Me.txtIdUsuarioModAsignacion = New DevExpress.XtraEditors.TextEdit()
        Me.txtFechaModificoAsignacion = New DevExpress.XtraEditors.DateEdit()
        Me.cmdIndefinido = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuPeriodoDefinido = New DevExpress.XtraBars.BarButtonItem()
        lblIdFranquiciado = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        User_agrLabel = New System.Windows.Forms.Label()
        Fec_agrLabel = New System.Windows.Forms.Label()
        User_modLabel = New System.Windows.Forms.Label()
        Fec_modLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        lblDPI = New System.Windows.Forms.Label()
        lblNoCuenta = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        lblNIT = New System.Windows.Forms.Label()
        lblDireccion = New System.Windows.Forms.Label()
        lblCodigo = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        lblSupervisorCEF = New System.Windows.Forms.Label()
        lblRegion = New System.Windows.Forms.Label()
        lblMunicipio = New System.Windows.Forms.Label()
        lblDepartamento = New System.Windows.Forms.Label()
        lblEncargado = New System.Windows.Forms.Label()
        lblFechaCreacion = New System.Windows.Forms.Label()
        lblFechaAsignacion = New System.Windows.Forms.Label()
        lblTiempoTranscurrido = New System.Windows.Forms.Label()
        lblInterlocutor = New System.Windows.Forms.Label()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdFranquiciado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.txtInterlocutor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaCreacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaCreacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDPI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNIT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtTiempoTranscurrido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaAsignacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaAsignacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEncargado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtidMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdRegion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomRegion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodSupervisorCEF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomSupervisor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodCEF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomCEF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtIdUsuarioAgrAsignacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaAgrAsignacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaAgrAsignacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdUsuarioModAsignacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaModificoAsignacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaModificoAsignacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIdFranquiciado
        '
        lblIdFranquiciado.AutoSize = True
        lblIdFranquiciado.Location = New System.Drawing.Point(30, 38)
        lblIdFranquiciado.Name = "lblIdFranquiciado"
        lblIdFranquiciado.Size = New System.Drawing.Size(17, 13)
        lblIdFranquiciado.TabIndex = 0
        lblIdFranquiciado.Text = "Id"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(30, 90)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(49, 13)
        NombresLabel.TabIndex = 4
        NombresLabel.Text = "Nombres"
        '
        'User_agrLabel
        '
        User_agrLabel.AutoSize = True
        User_agrLabel.Location = New System.Drawing.Point(149, 37)
        User_agrLabel.Name = "User_agrLabel"
        User_agrLabel.Size = New System.Drawing.Size(51, 13)
        User_agrLabel.TabIndex = 2
        User_agrLabel.Text = "user agr:"
        '
        'Fec_agrLabel
        '
        Fec_agrLabel.AutoSize = True
        Fec_agrLabel.Location = New System.Drawing.Point(149, 63)
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
        Label1.Location = New System.Drawing.Point(30, 119)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(49, 13)
        Label1.TabIndex = 6
        Label1.Text = "Apellidos"
        '
        'lblDPI
        '
        lblDPI.AutoSize = True
        lblDPI.Location = New System.Drawing.Point(30, 150)
        lblDPI.Name = "lblDPI"
        lblDPI.Size = New System.Drawing.Size(24, 13)
        lblDPI.TabIndex = 8
        lblDPI.Text = "DPI"
        '
        'lblNoCuenta
        '
        lblNoCuenta.AutoSize = True
        lblNoCuenta.Location = New System.Drawing.Point(30, 203)
        lblNoCuenta.Name = "lblNoCuenta"
        lblNoCuenta.Size = New System.Drawing.Size(53, 13)
        lblNoCuenta.TabIndex = 12
        lblNoCuenta.Text = "Cuenta #"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(30, 176)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(36, 13)
        Label2.TabIndex = 10
        Label2.Text = "Banco"
        '
        'lblNIT
        '
        lblNIT.AutoSize = True
        lblNIT.Location = New System.Drawing.Point(30, 229)
        lblNIT.Name = "lblNIT"
        lblNIT.Size = New System.Drawing.Size(24, 13)
        lblNIT.TabIndex = 14
        lblNIT.Text = "NIT"
        '
        'lblDireccion
        '
        lblDireccion.AutoSize = True
        lblDireccion.Location = New System.Drawing.Point(30, 255)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New System.Drawing.Size(50, 13)
        lblDireccion.TabIndex = 16
        lblDireccion.Text = "Dirección"
        '
        'lblCodigo
        '
        lblCodigo.AutoSize = True
        lblCodigo.Location = New System.Drawing.Point(30, 64)
        lblCodigo.Name = "lblCodigo"
        lblCodigo.Size = New System.Drawing.Size(40, 13)
        lblCodigo.TabIndex = 2
        lblCodigo.Text = "Código"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(100, 38)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(51, 13)
        Label3.TabIndex = 2
        Label3.Text = "user agr:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(100, 64)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(45, 13)
        Label4.TabIndex = 6
        Label4.Text = "fec agr:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(100, 94)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(55, 13)
        Label5.TabIndex = 0
        Label5.Text = "user mod:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(100, 120)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(49, 13)
        Label6.TabIndex = 4
        Label6.Text = "fec mod:"
        '
        'lblSupervisorCEF
        '
        lblSupervisorCEF.AutoSize = True
        lblSupervisorCEF.Enabled = False
        lblSupervisorCEF.Location = New System.Drawing.Point(15, 73)
        lblSupervisorCEF.Name = "lblSupervisorCEF"
        lblSupervisorCEF.Size = New System.Drawing.Size(58, 13)
        lblSupervisorCEF.TabIndex = 16
        lblSupervisorCEF.Text = "Supervisor"
        '
        'lblRegion
        '
        lblRegion.AutoSize = True
        lblRegion.Enabled = False
        lblRegion.Location = New System.Drawing.Point(15, 99)
        lblRegion.Name = "lblRegion"
        lblRegion.Size = New System.Drawing.Size(40, 13)
        lblRegion.TabIndex = 17
        lblRegion.Text = "Región"
        '
        'lblMunicipio
        '
        lblMunicipio.AutoSize = True
        lblMunicipio.Enabled = False
        lblMunicipio.Location = New System.Drawing.Point(15, 125)
        lblMunicipio.Name = "lblMunicipio"
        lblMunicipio.Size = New System.Drawing.Size(50, 13)
        lblMunicipio.TabIndex = 20
        lblMunicipio.Text = "Municipio"
        '
        'lblDepartamento
        '
        lblDepartamento.AutoSize = True
        lblDepartamento.Enabled = False
        lblDepartamento.Location = New System.Drawing.Point(15, 151)
        lblDepartamento.Name = "lblDepartamento"
        lblDepartamento.Size = New System.Drawing.Size(76, 13)
        lblDepartamento.TabIndex = 23
        lblDepartamento.Text = "Departamento"
        '
        'lblEncargado
        '
        lblEncargado.AutoSize = True
        lblEncargado.Enabled = False
        lblEncargado.Location = New System.Drawing.Point(15, 177)
        lblEncargado.Name = "lblEncargado"
        lblEncargado.Size = New System.Drawing.Size(58, 13)
        lblEncargado.TabIndex = 26
        lblEncargado.Text = "Encargado"
        '
        'lblFechaCreacion
        '
        lblFechaCreacion.AutoSize = True
        lblFechaCreacion.Location = New System.Drawing.Point(30, 376)
        lblFechaCreacion.Name = "lblFechaCreacion"
        lblFechaCreacion.Size = New System.Drawing.Size(53, 13)
        lblFechaCreacion.TabIndex = 18
        lblFechaCreacion.Text = "Creación:"
        '
        'lblFechaAsignacion
        '
        lblFechaAsignacion.AutoSize = True
        lblFechaAsignacion.Enabled = False
        lblFechaAsignacion.Location = New System.Drawing.Point(15, 203)
        lblFechaAsignacion.Name = "lblFechaAsignacion"
        lblFechaAsignacion.Size = New System.Drawing.Size(62, 13)
        lblFechaAsignacion.TabIndex = 27
        lblFechaAsignacion.Text = "Asignación:"
        '
        'lblTiempoTranscurrido
        '
        lblTiempoTranscurrido.Enabled = False
        lblTiempoTranscurrido.Location = New System.Drawing.Point(15, 226)
        lblTiempoTranscurrido.Name = "lblTiempoTranscurrido"
        lblTiempoTranscurrido.Size = New System.Drawing.Size(70, 39)
        lblTiempoTranscurrido.TabIndex = 29
        lblTiempoTranscurrido.Text = "Transcurrido (Días):"
        lblTiempoTranscurrido.Visible = False
        '
        'lblInterlocutor
        '
        lblInterlocutor.AutoSize = True
        lblInterlocutor.Location = New System.Drawing.Point(21, 402)
        lblInterlocutor.Name = "lblInterlocutor"
        lblInterlocutor.Size = New System.Drawing.Size(64, 13)
        lblInterlocutor.TabIndex = 20
        lblInterlocutor.Text = "Interlocutor"
        lblInterlocutor.Visible = False
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.mnuGuardar, Me.mnuActualizar, Me.mnuEliminar, Me.mnuReportesList, Me.cmdEstadoCuenta, Me.cmdDetalleDescuento, Me.cmdDetallePago, Me.cmdDetalleVenta, Me.BarSubItem1, Me.mnuIndefinido, Me.mnuDefinidio, Me.mnuUnico})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 17
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(840, 144)
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
        '
        'mnuReportesList
        '
        Me.mnuReportesList.Caption = "Reportes"
        Me.mnuReportesList.Glyph = CType(resources.GetObject("mnuReportesList.Glyph"), System.Drawing.Image)
        Me.mnuReportesList.Id = 7
        Me.mnuReportesList.LargeGlyph = CType(resources.GetObject("mnuReportesList.LargeGlyph"), System.Drawing.Image)
        Me.mnuReportesList.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdEstadoCuenta), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdDetalleDescuento), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdDetallePago), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdDetalleVenta)})
        Me.mnuReportesList.Name = "mnuReportesList"
        '
        'cmdEstadoCuenta
        '
        Me.cmdEstadoCuenta.Caption = "Estado de Cuenta"
        Me.cmdEstadoCuenta.Id = 9
        Me.cmdEstadoCuenta.Name = "cmdEstadoCuenta"
        '
        'cmdDetalleDescuento
        '
        Me.cmdDetalleDescuento.Caption = "Detalle de Descuentos"
        Me.cmdDetalleDescuento.Id = 10
        Me.cmdDetalleDescuento.Name = "cmdDetalleDescuento"
        '
        'cmdDetallePago
        '
        Me.cmdDetallePago.Caption = "Detalle de Pagos"
        Me.cmdDetallePago.Id = 11
        Me.cmdDetallePago.Name = "cmdDetallePago"
        '
        'cmdDetalleVenta
        '
        Me.cmdDetalleVenta.Caption = "Detalle de Ventas"
        Me.cmdDetalleVenta.Id = 12
        Me.cmdDetalleVenta.Name = "cmdDetalleVenta"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Agregar descuento"
        Me.BarSubItem1.Id = 13
        Me.BarSubItem1.LargeGlyph = Global.zfranqui.My.Resources.Resources.emblem_money
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.mnuIndefinido), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuDefinidio), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuUnico)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'mnuIndefinido
        '
        Me.mnuIndefinido.Caption = "Indefinido"
        Me.mnuIndefinido.Id = 14
        Me.mnuIndefinido.Name = "mnuIndefinido"
        '
        'mnuDefinidio
        '
        Me.mnuDefinidio.Caption = "Definido"
        Me.mnuDefinidio.Id = 15
        Me.mnuDefinidio.Name = "mnuDefinidio"
        '
        'mnuUnico
        '
        Me.mnuUnico.Caption = "Único"
        Me.mnuUnico.Id = 16
        Me.mnuUnico.Name = "mnuUnico"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Menú"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.mnuGuardar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.mnuActualizar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.mnuEliminar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.mnuReportesList)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Consultas"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarSubItem1)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Transacciones"
        '
        'txtIdFranquiciado
        '
        Me.txtIdFranquiciado.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIdFranquiciado.Enabled = False
        Me.txtIdFranquiciado.Location = New System.Drawing.Point(90, 35)
        Me.txtIdFranquiciado.MenuManager = Me.RibbonControl
        Me.txtIdFranquiciado.Name = "txtIdFranquiciado"
        Me.txtIdFranquiciado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtIdFranquiciado.Size = New System.Drawing.Size(212, 20)
        Me.txtIdFranquiciado.TabIndex = 1
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(90, 87)
        Me.txtNombres.MenuManager = Me.RibbonControl
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Properties.MaxLength = 50
        Me.txtNombres.Size = New System.Drawing.Size(212, 20)
        Me.txtNombres.TabIndex = 5
        '
        'User_agrTextEdit
        '
        Me.User_agrTextEdit.Enabled = False
        Me.User_agrTextEdit.Location = New System.Drawing.Point(219, 34)
        Me.User_agrTextEdit.MenuManager = Me.RibbonControl
        Me.User_agrTextEdit.Name = "User_agrTextEdit"
        Me.User_agrTextEdit.Size = New System.Drawing.Size(187, 20)
        Me.User_agrTextEdit.TabIndex = 3
        '
        'Fec_agrDateEdit
        '
        Me.Fec_agrDateEdit.EditValue = Nothing
        Me.Fec_agrDateEdit.Enabled = False
        Me.Fec_agrDateEdit.Location = New System.Drawing.Point(219, 60)
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
        Me.PanBitacora.Location = New System.Drawing.Point(0, 655)
        Me.PanBitacora.Name = "PanBitacora"
        Me.PanBitacora.Size = New System.Drawing.Size(840, 94)
        Me.PanBitacora.TabIndex = 1
        Me.PanBitacora.Text = "Bitácora"
        '
        'PanDatosUsuario
        '
        Me.PanDatosUsuario.Controls.Add(lblInterlocutor)
        Me.PanDatosUsuario.Controls.Add(Me.txtInterlocutor)
        Me.PanDatosUsuario.Controls.Add(Me.txtFechaCreacion)
        Me.PanDatosUsuario.Controls.Add(lblFechaCreacion)
        Me.PanDatosUsuario.Controls.Add(Me.txtDPI)
        Me.PanDatosUsuario.Controls.Add(Me.txtCodigo)
        Me.PanDatosUsuario.Controls.Add(lblCodigo)
        Me.PanDatosUsuario.Controls.Add(Me.txtdireccion)
        Me.PanDatosUsuario.Controls.Add(lblDireccion)
        Me.PanDatosUsuario.Controls.Add(lblNIT)
        Me.PanDatosUsuario.Controls.Add(Me.txtNIT)
        Me.PanDatosUsuario.Controls.Add(Label2)
        Me.PanDatosUsuario.Controls.Add(Me.cmbBanco)
        Me.PanDatosUsuario.Controls.Add(lblNoCuenta)
        Me.PanDatosUsuario.Controls.Add(Me.txtNoCuenta)
        Me.PanDatosUsuario.Controls.Add(lblDPI)
        Me.PanDatosUsuario.Controls.Add(Label1)
        Me.PanDatosUsuario.Controls.Add(Me.txtApellidos)
        Me.PanDatosUsuario.Controls.Add(lblIdFranquiciado)
        Me.PanDatosUsuario.Controls.Add(Me.txtIdFranquiciado)
        Me.PanDatosUsuario.Controls.Add(NombresLabel)
        Me.PanDatosUsuario.Controls.Add(Me.txtNombres)
        Me.PanDatosUsuario.Location = New System.Drawing.Point(71, 155)
        Me.PanDatosUsuario.Name = "PanDatosUsuario"
        Me.PanDatosUsuario.Size = New System.Drawing.Size(335, 464)
        Me.PanDatosUsuario.TabIndex = 0
        Me.PanDatosUsuario.Text = "Datos Franquiciado"
        '
        'txtInterlocutor
        '
        Me.txtInterlocutor.Location = New System.Drawing.Point(90, 399)
        Me.txtInterlocutor.MenuManager = Me.RibbonControl
        Me.txtInterlocutor.Name = "txtInterlocutor"
        Me.txtInterlocutor.Properties.MaxLength = 20
        Me.txtInterlocutor.Size = New System.Drawing.Size(212, 20)
        Me.txtInterlocutor.TabIndex = 21
        Me.txtInterlocutor.Visible = False
        '
        'txtFechaCreacion
        '
        Me.txtFechaCreacion.EditValue = New Date(2016, 2, 25, 11, 55, 4, 0)
        Me.txtFechaCreacion.Enabled = False
        Me.txtFechaCreacion.Location = New System.Drawing.Point(90, 373)
        Me.txtFechaCreacion.MenuManager = Me.RibbonControl
        Me.txtFechaCreacion.Name = "txtFechaCreacion"
        Me.txtFechaCreacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaCreacion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaCreacion.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.txtFechaCreacion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtFechaCreacion.Size = New System.Drawing.Size(212, 20)
        Me.txtFechaCreacion.TabIndex = 19
        '
        'txtDPI
        '
        Me.txtDPI.Location = New System.Drawing.Point(90, 147)
        Me.txtDPI.MenuManager = Me.RibbonControl
        Me.txtDPI.Name = "txtDPI"
        Me.txtDPI.Properties.MaxLength = 50
        Me.txtDPI.Size = New System.Drawing.Size(212, 20)
        Me.txtDPI.TabIndex = 9
        '
        'txtCodigo
        '
        Me.txtCodigo.EditValue = ""
        Me.txtCodigo.Location = New System.Drawing.Point(90, 61)
        Me.txtCodigo.MenuManager = Me.RibbonControl
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigo.Properties.MaxLength = 10
        Me.txtCodigo.Size = New System.Drawing.Size(212, 20)
        Me.txtCodigo.TabIndex = 3
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(90, 252)
        Me.txtdireccion.MaxLength = 200
        Me.txtdireccion.Multiline = True
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtdireccion.Size = New System.Drawing.Size(212, 115)
        Me.txtdireccion.TabIndex = 17
        '
        'txtNIT
        '
        Me.txtNIT.Location = New System.Drawing.Point(90, 226)
        Me.txtNIT.MenuManager = Me.RibbonControl
        Me.txtNIT.Name = "txtNIT"
        Me.txtNIT.Properties.MaxLength = 10
        Me.txtNIT.Size = New System.Drawing.Size(212, 20)
        Me.txtNIT.TabIndex = 15
        '
        'cmbBanco
        '
        Me.cmbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBanco.FormattingEnabled = True
        Me.cmbBanco.Location = New System.Drawing.Point(90, 173)
        Me.cmbBanco.Name = "cmbBanco"
        Me.cmbBanco.Size = New System.Drawing.Size(212, 21)
        Me.cmbBanco.TabIndex = 11
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.Location = New System.Drawing.Point(90, 200)
        Me.txtNoCuenta.MenuManager = Me.RibbonControl
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.Properties.MaxLength = 20
        Me.txtNoCuenta.Size = New System.Drawing.Size(212, 20)
        Me.txtNoCuenta.TabIndex = 13
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(90, 116)
        Me.txtApellidos.MenuManager = Me.RibbonControl
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Properties.MaxLength = 50
        Me.txtApellidos.Size = New System.Drawing.Size(212, 20)
        Me.txtApellidos.TabIndex = 7
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtTiempoTranscurrido)
        Me.GroupControl1.Controls.Add(lblTiempoTranscurrido)
        Me.GroupControl1.Controls.Add(Me.txtFechaAsignacion)
        Me.GroupControl1.Controls.Add(lblFechaAsignacion)
        Me.GroupControl1.Controls.Add(lblEncargado)
        Me.GroupControl1.Controls.Add(Me.txtEncargado)
        Me.GroupControl1.Controls.Add(lblDepartamento)
        Me.GroupControl1.Controls.Add(Me.txtIdDepartamento)
        Me.GroupControl1.Controls.Add(Me.txtNomDepartamento)
        Me.GroupControl1.Controls.Add(lblMunicipio)
        Me.GroupControl1.Controls.Add(Me.txtidMunicipio)
        Me.GroupControl1.Controls.Add(Me.txtNomMunicipio)
        Me.GroupControl1.Controls.Add(lblRegion)
        Me.GroupControl1.Controls.Add(lblSupervisorCEF)
        Me.GroupControl1.Controls.Add(Me.txtIdRegion)
        Me.GroupControl1.Controls.Add(Me.txtNomRegion)
        Me.GroupControl1.Controls.Add(Me.txtCodSupervisorCEF)
        Me.GroupControl1.Controls.Add(Me.txtNomSupervisor)
        Me.GroupControl1.Controls.Add(Me.lnkCEF)
        Me.GroupControl1.Controls.Add(Me.txtCodCEF)
        Me.GroupControl1.Controls.Add(Me.txtNomCEF)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(412, 155)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(398, 464)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "Asignación de CEF"
        '
        'txtTiempoTranscurrido
        '
        Me.txtTiempoTranscurrido.Enabled = False
        Me.txtTiempoTranscurrido.Location = New System.Drawing.Point(93, 226)
        Me.txtTiempoTranscurrido.MenuManager = Me.RibbonControl
        Me.txtTiempoTranscurrido.Name = "txtTiempoTranscurrido"
        Me.txtTiempoTranscurrido.Properties.MaxLength = 50
        Me.txtTiempoTranscurrido.Size = New System.Drawing.Size(288, 20)
        Me.txtTiempoTranscurrido.TabIndex = 30
        Me.txtTiempoTranscurrido.Visible = False
        '
        'txtFechaAsignacion
        '
        Me.txtFechaAsignacion.EditValue = New Date(2016, 2, 25, 11, 55, 4, 0)
        Me.txtFechaAsignacion.Enabled = False
        Me.txtFechaAsignacion.Location = New System.Drawing.Point(93, 200)
        Me.txtFechaAsignacion.MenuManager = Me.RibbonControl
        Me.txtFechaAsignacion.Name = "txtFechaAsignacion"
        Me.txtFechaAsignacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaAsignacion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaAsignacion.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
        Me.txtFechaAsignacion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtFechaAsignacion.Size = New System.Drawing.Size(288, 20)
        Me.txtFechaAsignacion.TabIndex = 28
        '
        'txtEncargado
        '
        Me.txtEncargado.Enabled = False
        Me.txtEncargado.Location = New System.Drawing.Point(93, 174)
        Me.txtEncargado.MenuManager = Me.RibbonControl
        Me.txtEncargado.Name = "txtEncargado"
        Me.txtEncargado.Properties.MaxLength = 50
        Me.txtEncargado.Size = New System.Drawing.Size(288, 20)
        Me.txtEncargado.TabIndex = 25
        '
        'txtIdDepartamento
        '
        Me.txtIdDepartamento.EditValue = ""
        Me.txtIdDepartamento.Enabled = False
        Me.txtIdDepartamento.Location = New System.Drawing.Point(93, 148)
        Me.txtIdDepartamento.MenuManager = Me.RibbonControl
        Me.txtIdDepartamento.Name = "txtIdDepartamento"
        Me.txtIdDepartamento.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIdDepartamento.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIdDepartamento.Properties.MaxLength = 10
        Me.txtIdDepartamento.Size = New System.Drawing.Size(74, 20)
        Me.txtIdDepartamento.TabIndex = 21
        '
        'txtNomDepartamento
        '
        Me.txtNomDepartamento.Enabled = False
        Me.txtNomDepartamento.Location = New System.Drawing.Point(169, 148)
        Me.txtNomDepartamento.MenuManager = Me.RibbonControl
        Me.txtNomDepartamento.Name = "txtNomDepartamento"
        Me.txtNomDepartamento.Properties.MaxLength = 50
        Me.txtNomDepartamento.Size = New System.Drawing.Size(212, 20)
        Me.txtNomDepartamento.TabIndex = 22
        '
        'txtidMunicipio
        '
        Me.txtidMunicipio.EditValue = ""
        Me.txtidMunicipio.Enabled = False
        Me.txtidMunicipio.Location = New System.Drawing.Point(93, 122)
        Me.txtidMunicipio.MenuManager = Me.RibbonControl
        Me.txtidMunicipio.Name = "txtidMunicipio"
        Me.txtidMunicipio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtidMunicipio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtidMunicipio.Properties.MaxLength = 10
        Me.txtidMunicipio.Size = New System.Drawing.Size(74, 20)
        Me.txtidMunicipio.TabIndex = 18
        '
        'txtNomMunicipio
        '
        Me.txtNomMunicipio.Enabled = False
        Me.txtNomMunicipio.Location = New System.Drawing.Point(169, 122)
        Me.txtNomMunicipio.MenuManager = Me.RibbonControl
        Me.txtNomMunicipio.Name = "txtNomMunicipio"
        Me.txtNomMunicipio.Properties.MaxLength = 50
        Me.txtNomMunicipio.Size = New System.Drawing.Size(212, 20)
        Me.txtNomMunicipio.TabIndex = 19
        '
        'txtIdRegion
        '
        Me.txtIdRegion.EditValue = ""
        Me.txtIdRegion.Enabled = False
        Me.txtIdRegion.Location = New System.Drawing.Point(93, 96)
        Me.txtIdRegion.MenuManager = Me.RibbonControl
        Me.txtIdRegion.Name = "txtIdRegion"
        Me.txtIdRegion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIdRegion.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtIdRegion.Properties.MaxLength = 10
        Me.txtIdRegion.Size = New System.Drawing.Size(74, 20)
        Me.txtIdRegion.TabIndex = 14
        '
        'txtNomRegion
        '
        Me.txtNomRegion.Enabled = False
        Me.txtNomRegion.Location = New System.Drawing.Point(169, 96)
        Me.txtNomRegion.MenuManager = Me.RibbonControl
        Me.txtNomRegion.Name = "txtNomRegion"
        Me.txtNomRegion.Properties.MaxLength = 50
        Me.txtNomRegion.Size = New System.Drawing.Size(212, 20)
        Me.txtNomRegion.TabIndex = 15
        '
        'txtCodSupervisorCEF
        '
        Me.txtCodSupervisorCEF.EditValue = ""
        Me.txtCodSupervisorCEF.Enabled = False
        Me.txtCodSupervisorCEF.Location = New System.Drawing.Point(93, 70)
        Me.txtCodSupervisorCEF.MenuManager = Me.RibbonControl
        Me.txtCodSupervisorCEF.Name = "txtCodSupervisorCEF"
        Me.txtCodSupervisorCEF.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodSupervisorCEF.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodSupervisorCEF.Properties.MaxLength = 10
        Me.txtCodSupervisorCEF.Size = New System.Drawing.Size(74, 20)
        Me.txtCodSupervisorCEF.TabIndex = 11
        '
        'txtNomSupervisor
        '
        Me.txtNomSupervisor.Enabled = False
        Me.txtNomSupervisor.Location = New System.Drawing.Point(169, 70)
        Me.txtNomSupervisor.MenuManager = Me.RibbonControl
        Me.txtNomSupervisor.Name = "txtNomSupervisor"
        Me.txtNomSupervisor.Properties.MaxLength = 50
        Me.txtNomSupervisor.Size = New System.Drawing.Size(212, 20)
        Me.txtNomSupervisor.TabIndex = 12
        '
        'lnkCEF
        '
        Me.lnkCEF.AutoSize = True
        Me.lnkCEF.Location = New System.Drawing.Point(15, 47)
        Me.lnkCEF.Name = "lnkCEF"
        Me.lnkCEF.Size = New System.Drawing.Size(26, 13)
        Me.lnkCEF.TabIndex = 10
        Me.lnkCEF.TabStop = True
        Me.lnkCEF.Text = "CEF"
        '
        'txtCodCEF
        '
        Me.txtCodCEF.EditValue = ""
        Me.txtCodCEF.Location = New System.Drawing.Point(93, 44)
        Me.txtCodCEF.MenuManager = Me.RibbonControl
        Me.txtCodCEF.Name = "txtCodCEF"
        Me.txtCodCEF.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodCEF.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodCEF.Properties.MaxLength = 10
        Me.txtCodCEF.Size = New System.Drawing.Size(74, 20)
        Me.txtCodCEF.TabIndex = 7
        '
        'txtNomCEF
        '
        Me.txtNomCEF.Location = New System.Drawing.Point(169, 44)
        Me.txtNomCEF.MenuManager = Me.RibbonControl
        Me.txtNomCEF.Name = "txtNomCEF"
        Me.txtNomCEF.Properties.MaxLength = 50
        Me.txtNomCEF.Size = New System.Drawing.Size(212, 20)
        Me.txtNomCEF.TabIndex = 9
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Label3)
        Me.GroupControl2.Controls.Add(Me.txtIdUsuarioAgrAsignacion)
        Me.GroupControl2.Controls.Add(Label4)
        Me.GroupControl2.Controls.Add(Me.txtFechaAgrAsignacion)
        Me.GroupControl2.Controls.Add(Label5)
        Me.GroupControl2.Controls.Add(Me.txtIdUsuarioModAsignacion)
        Me.GroupControl2.Controls.Add(Label6)
        Me.GroupControl2.Controls.Add(Me.txtFechaModificoAsignacion)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl2.Location = New System.Drawing.Point(2, 305)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(394, 157)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Bitácora"
        '
        'txtIdUsuarioAgrAsignacion
        '
        Me.txtIdUsuarioAgrAsignacion.Enabled = False
        Me.txtIdUsuarioAgrAsignacion.Location = New System.Drawing.Point(170, 35)
        Me.txtIdUsuarioAgrAsignacion.MenuManager = Me.RibbonControl
        Me.txtIdUsuarioAgrAsignacion.Name = "txtIdUsuarioAgrAsignacion"
        Me.txtIdUsuarioAgrAsignacion.Size = New System.Drawing.Size(114, 20)
        Me.txtIdUsuarioAgrAsignacion.TabIndex = 3
        '
        'txtFechaAgrAsignacion
        '
        Me.txtFechaAgrAsignacion.EditValue = Nothing
        Me.txtFechaAgrAsignacion.Enabled = False
        Me.txtFechaAgrAsignacion.Location = New System.Drawing.Point(170, 61)
        Me.txtFechaAgrAsignacion.MenuManager = Me.RibbonControl
        Me.txtFechaAgrAsignacion.Name = "txtFechaAgrAsignacion"
        Me.txtFechaAgrAsignacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaAgrAsignacion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaAgrAsignacion.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtFechaAgrAsignacion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtFechaAgrAsignacion.Size = New System.Drawing.Size(114, 20)
        Me.txtFechaAgrAsignacion.TabIndex = 7
        '
        'txtIdUsuarioModAsignacion
        '
        Me.txtIdUsuarioModAsignacion.Enabled = False
        Me.txtIdUsuarioModAsignacion.Location = New System.Drawing.Point(170, 91)
        Me.txtIdUsuarioModAsignacion.MenuManager = Me.RibbonControl
        Me.txtIdUsuarioModAsignacion.Name = "txtIdUsuarioModAsignacion"
        Me.txtIdUsuarioModAsignacion.Size = New System.Drawing.Size(114, 20)
        Me.txtIdUsuarioModAsignacion.TabIndex = 1
        '
        'txtFechaModificoAsignacion
        '
        Me.txtFechaModificoAsignacion.EditValue = Nothing
        Me.txtFechaModificoAsignacion.Enabled = False
        Me.txtFechaModificoAsignacion.Location = New System.Drawing.Point(170, 117)
        Me.txtFechaModificoAsignacion.MenuManager = Me.RibbonControl
        Me.txtFechaModificoAsignacion.Name = "txtFechaModificoAsignacion"
        Me.txtFechaModificoAsignacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaModificoAsignacion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaModificoAsignacion.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtFechaModificoAsignacion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtFechaModificoAsignacion.Size = New System.Drawing.Size(114, 20)
        Me.txtFechaModificoAsignacion.TabIndex = 5
        '
        'cmdIndefinido
        '
        Me.cmdIndefinido.Caption = "Período indefinido"
        Me.cmdIndefinido.Id = 26
        Me.cmdIndefinido.Name = "cmdIndefinido"
        '
        'mnuPeriodoDefinido
        '
        Me.mnuPeriodoDefinido.Caption = "Período definido"
        Me.mnuPeriodoDefinido.Id = 25
        Me.mnuPeriodoDefinido.Name = "mnuPeriodoDefinido"
        '
        'frmFranquiciado
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(840, 749)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanDatosUsuario)
        Me.Controls.Add(Me.PanBitacora)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frmFranquiciado"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento de Franquiciado"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdFranquiciado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.txtInterlocutor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaCreacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaCreacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDPI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNIT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtTiempoTranscurrido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaAsignacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaAsignacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEncargado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtidMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdRegion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomRegion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodSupervisorCEF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomSupervisor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodCEF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomCEF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtIdUsuarioAgrAsignacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaAgrAsignacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaAgrAsignacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdUsuarioModAsignacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaModificoAsignacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaModificoAsignacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents mnuGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtIdFranquiciado As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents User_agrTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Fec_agrDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents User_modTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Fec_modDateEdit As DevExpress.XtraEditors.DateEdit
    Private WithEvents PanBitacora As DevExpress.XtraEditors.GroupControl
    Private WithEvents PanDatosUsuario As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbBanco As System.Windows.Forms.ComboBox
    Friend WithEvents txtNoCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtApellidos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNIT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDPI As DevExpress.XtraEditors.TextEdit
    Private WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Private WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtIdUsuarioAgrAsignacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaAgrAsignacion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtIdUsuarioModAsignacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaModificoAsignacion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtCodCEF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomCEF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lnkCEF As System.Windows.Forms.LinkLabel
    Friend WithEvents txtidMunicipio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomMunicipio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIdRegion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomRegion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodSupervisorCEF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomSupervisor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEncargado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtIdDepartamento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomDepartamento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaCreacion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtTiempoTranscurrido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaAsignacion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtInterlocutor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mnuReportesList As DevExpress.XtraBars.BarSubItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents cmdEstadoCuenta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdDetalleDescuento As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdDetallePago As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdDetalleVenta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnuIndefinido As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuDefinidio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuUnico As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdIndefinido As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuPeriodoDefinido As DevExpress.XtraBars.BarButtonItem


End Class
