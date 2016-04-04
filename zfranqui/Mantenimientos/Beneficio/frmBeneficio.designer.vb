<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBeneficio
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
        Dim lblIdBeneficio As System.Windows.Forms.Label
        Dim lblTipo As System.Windows.Forms.Label
        Dim lblEmpresaTelco As System.Windows.Forms.Label
        Dim lblNoTelefono As System.Windows.Forms.Label
        Dim lblNoChasis As System.Windows.Forms.Label
        Dim lblModelo As System.Windows.Forms.Label
        Dim lblPlaca As System.Windows.Forms.Label
        Dim lblMotor As System.Windows.Forms.Label
        Dim User_agrLabel As System.Windows.Forms.Label
        Dim Fec_agrLabel As System.Windows.Forms.Label
        Dim User_modLabel As System.Windows.Forms.Label
        Dim Fec_modLabel As System.Windows.Forms.Label
        Dim lblCodigo As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBeneficio))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.mnuGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.txtIdBeneficio = New DevExpress.XtraEditors.SpinEdit()
        Me.PanDatosBeneficio = New DevExpress.XtraEditors.GroupControl()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.PanTelefono = New DevExpress.XtraEditors.GroupControl()
        Me.txtNoTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.cmbEmpresaTelco = New System.Windows.Forms.ComboBox()
        Me.PanVehiculo = New DevExpress.XtraEditors.GroupControl()
        Me.txtMotor = New DevExpress.XtraEditors.TextEdit()
        Me.txtPlaca = New DevExpress.XtraEditors.TextEdit()
        Me.txtNoChasis = New DevExpress.XtraEditors.TextEdit()
        Me.txtModelo = New DevExpress.XtraEditors.TextEdit()
        Me.PanBitacora = New DevExpress.XtraEditors.GroupControl()
        Me.User_agrTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Fec_agrDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.User_modTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Fec_modDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.PanFranquiciado = New DevExpress.XtraEditors.GroupControl()
        Me.lnkCEF = New System.Windows.Forms.LinkLabel()
        Me.txtCodCEF = New DevExpress.XtraEditors.TextEdit()
        Me.txtNomCEF = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoFranquiciado = New DevExpress.XtraEditors.TextEdit()
        Me.txtApellidosFranquiciado = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombresFranquiciado = New DevExpress.XtraEditors.TextEdit()
        Me.txtFechaAsignado = New DevExpress.XtraEditors.DateEdit()
        lblIdBeneficio = New System.Windows.Forms.Label()
        lblTipo = New System.Windows.Forms.Label()
        lblEmpresaTelco = New System.Windows.Forms.Label()
        lblNoTelefono = New System.Windows.Forms.Label()
        lblNoChasis = New System.Windows.Forms.Label()
        lblModelo = New System.Windows.Forms.Label()
        lblPlaca = New System.Windows.Forms.Label()
        lblMotor = New System.Windows.Forms.Label()
        User_agrLabel = New System.Windows.Forms.Label()
        Fec_agrLabel = New System.Windows.Forms.Label()
        User_modLabel = New System.Windows.Forms.Label()
        Fec_modLabel = New System.Windows.Forms.Label()
        lblCodigo = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdBeneficio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanDatosBeneficio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanDatosBeneficio.SuspendLayout()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanTelefono.SuspendLayout()
        CType(Me.txtNoTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanVehiculo.SuspendLayout()
        CType(Me.txtMotor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPlaca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoChasis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtModelo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanBitacora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanBitacora.SuspendLayout()
        CType(Me.User_agrTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fec_agrDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fec_agrDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_modTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fec_modDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fec_modDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PanFranquiciado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanFranquiciado.SuspendLayout()
        CType(Me.txtCodCEF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomCEF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFranquiciado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidosFranquiciado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombresFranquiciado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaAsignado.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaAsignado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIdBeneficio
        '
        lblIdBeneficio.AutoSize = True
        lblIdBeneficio.Location = New System.Drawing.Point(42, 40)
        lblIdBeneficio.Name = "lblIdBeneficio"
        lblIdBeneficio.Size = New System.Drawing.Size(40, 13)
        lblIdBeneficio.TabIndex = 0
        lblIdBeneficio.Text = "Código"
        '
        'lblTipo
        '
        lblTipo.AutoSize = True
        lblTipo.Location = New System.Drawing.Point(42, 66)
        lblTipo.Name = "lblTipo"
        lblTipo.Size = New System.Drawing.Size(27, 13)
        lblTipo.TabIndex = 5
        lblTipo.Text = "Tipo"
        '
        'lblEmpresaTelco
        '
        lblEmpresaTelco.AutoSize = True
        lblEmpresaTelco.Location = New System.Drawing.Point(33, 68)
        lblEmpresaTelco.Name = "lblEmpresaTelco"
        lblEmpresaTelco.Size = New System.Drawing.Size(54, 13)
        lblEmpresaTelco.TabIndex = 5
        lblEmpresaTelco.Text = "Compañía"
        '
        'lblNoTelefono
        '
        lblNoTelefono.AutoSize = True
        lblNoTelefono.Location = New System.Drawing.Point(33, 42)
        lblNoTelefono.Name = "lblNoTelefono"
        lblNoTelefono.Size = New System.Drawing.Size(49, 13)
        lblNoTelefono.TabIndex = 0
        lblNoTelefono.Text = "Teléfono"
        '
        'lblNoChasis
        '
        lblNoChasis.AutoSize = True
        lblNoChasis.Location = New System.Drawing.Point(33, 68)
        lblNoChasis.Name = "lblNoChasis"
        lblNoChasis.Size = New System.Drawing.Size(38, 13)
        lblNoChasis.TabIndex = 5
        lblNoChasis.Text = "Chasis"
        '
        'lblModelo
        '
        lblModelo.AutoSize = True
        lblModelo.Location = New System.Drawing.Point(33, 42)
        lblModelo.Name = "lblModelo"
        lblModelo.Size = New System.Drawing.Size(41, 13)
        lblModelo.TabIndex = 0
        lblModelo.Text = "Modelo"
        '
        'lblPlaca
        '
        lblPlaca.AutoSize = True
        lblPlaca.Location = New System.Drawing.Point(33, 99)
        lblPlaca.Name = "lblPlaca"
        lblPlaca.Size = New System.Drawing.Size(32, 13)
        lblPlaca.TabIndex = 8
        lblPlaca.Text = "Placa"
        '
        'lblMotor
        '
        lblMotor.AutoSize = True
        lblMotor.Location = New System.Drawing.Point(33, 126)
        lblMotor.Name = "lblMotor"
        lblMotor.Size = New System.Drawing.Size(35, 13)
        lblMotor.TabIndex = 10
        lblMotor.Text = "Motor"
        '
        'User_agrLabel
        '
        User_agrLabel.AutoSize = True
        User_agrLabel.Location = New System.Drawing.Point(110, 37)
        User_agrLabel.Name = "User_agrLabel"
        User_agrLabel.Size = New System.Drawing.Size(51, 13)
        User_agrLabel.TabIndex = 2
        User_agrLabel.Text = "user agr:"
        '
        'Fec_agrLabel
        '
        Fec_agrLabel.AutoSize = True
        Fec_agrLabel.Location = New System.Drawing.Point(110, 63)
        Fec_agrLabel.Name = "Fec_agrLabel"
        Fec_agrLabel.Size = New System.Drawing.Size(45, 13)
        Fec_agrLabel.TabIndex = 6
        Fec_agrLabel.Text = "fec agr:"
        '
        'User_modLabel
        '
        User_modLabel.AutoSize = True
        User_modLabel.Location = New System.Drawing.Point(403, 31)
        User_modLabel.Name = "User_modLabel"
        User_modLabel.Size = New System.Drawing.Size(55, 13)
        User_modLabel.TabIndex = 0
        User_modLabel.Text = "user mod:"
        '
        'Fec_modLabel
        '
        Fec_modLabel.AutoSize = True
        Fec_modLabel.Location = New System.Drawing.Point(403, 57)
        Fec_modLabel.Name = "Fec_modLabel"
        Fec_modLabel.Size = New System.Drawing.Size(49, 13)
        Fec_modLabel.TabIndex = 4
        Fec_modLabel.Text = "fec mod:"
        '
        'lblCodigo
        '
        lblCodigo.AutoSize = True
        lblCodigo.Location = New System.Drawing.Point(11, 40)
        lblCodigo.Name = "lblCodigo"
        lblCodigo.Size = New System.Drawing.Size(40, 13)
        lblCodigo.TabIndex = 2
        lblCodigo.Text = "Código"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(11, 92)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(49, 13)
        Label3.TabIndex = 6
        Label3.Text = "Apellidos"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(11, 66)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(49, 13)
        NombresLabel.TabIndex = 4
        NombresLabel.Text = "Nombres"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(46, 38)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(40, 13)
        Label1.TabIndex = 8
        Label1.Text = "Fecha:"
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.mnuGuardar, Me.mnuActualizar, Me.mnuEliminar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(770, 144)
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
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'txtIdBeneficio
        '
        Me.txtIdBeneficio.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIdBeneficio.Enabled = False
        Me.txtIdBeneficio.Location = New System.Drawing.Point(88, 37)
        Me.txtIdBeneficio.MenuManager = Me.RibbonControl
        Me.txtIdBeneficio.Name = "txtIdBeneficio"
        Me.txtIdBeneficio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtIdBeneficio.Size = New System.Drawing.Size(212, 20)
        Me.txtIdBeneficio.TabIndex = 1
        '
        'PanDatosBeneficio
        '
        Me.PanDatosBeneficio.Controls.Add(Me.lblnombre)
        Me.PanDatosBeneficio.Controls.Add(Me.txtNombre)
        Me.PanDatosBeneficio.Controls.Add(lblTipo)
        Me.PanDatosBeneficio.Controls.Add(Me.cmbTipo)
        Me.PanDatosBeneficio.Controls.Add(lblIdBeneficio)
        Me.PanDatosBeneficio.Controls.Add(Me.txtIdBeneficio)
        Me.PanDatosBeneficio.Location = New System.Drawing.Point(35, 174)
        Me.PanDatosBeneficio.Name = "PanDatosBeneficio"
        Me.PanDatosBeneficio.Size = New System.Drawing.Size(351, 130)
        Me.PanDatosBeneficio.TabIndex = 0
        Me.PanDatosBeneficio.Text = "Datos Beneficio"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(44, 93)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(44, 13)
        Me.lblnombre.TabIndex = 9
        Me.lblnombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(88, 90)
        Me.txtNombre.MenuManager = Me.RibbonControl
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(212, 20)
        Me.txtNombre.TabIndex = 8
        Me.txtNombre.Visible = False
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(88, 63)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(212, 21)
        Me.cmbTipo.TabIndex = 4
        '
        'PanTelefono
        '
        Me.PanTelefono.Controls.Add(Me.txtNoTelefono)
        Me.PanTelefono.Controls.Add(lblEmpresaTelco)
        Me.PanTelefono.Controls.Add(Me.cmbEmpresaTelco)
        Me.PanTelefono.Controls.Add(lblNoTelefono)
        Me.PanTelefono.Location = New System.Drawing.Point(392, 174)
        Me.PanTelefono.Name = "PanTelefono"
        Me.PanTelefono.Size = New System.Drawing.Size(351, 130)
        Me.PanTelefono.TabIndex = 4
        Me.PanTelefono.Text = "Datos Teléfono"
        '
        'txtNoTelefono
        '
        Me.txtNoTelefono.Location = New System.Drawing.Point(88, 39)
        Me.txtNoTelefono.MenuManager = Me.RibbonControl
        Me.txtNoTelefono.Name = "txtNoTelefono"
        Me.txtNoTelefono.Properties.MaxLength = 8
        Me.txtNoTelefono.Size = New System.Drawing.Size(212, 20)
        Me.txtNoTelefono.TabIndex = 6
        '
        'cmbEmpresaTelco
        '
        Me.cmbEmpresaTelco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpresaTelco.FormattingEnabled = True
        Me.cmbEmpresaTelco.Items.AddRange(New Object() {"Movistar", "Claro", "Tigo"})
        Me.cmbEmpresaTelco.Location = New System.Drawing.Point(88, 65)
        Me.cmbEmpresaTelco.Name = "cmbEmpresaTelco"
        Me.cmbEmpresaTelco.Size = New System.Drawing.Size(212, 21)
        Me.cmbEmpresaTelco.TabIndex = 4
        '
        'PanVehiculo
        '
        Me.PanVehiculo.Controls.Add(Me.txtMotor)
        Me.PanVehiculo.Controls.Add(lblMotor)
        Me.PanVehiculo.Controls.Add(Me.txtPlaca)
        Me.PanVehiculo.Controls.Add(lblPlaca)
        Me.PanVehiculo.Controls.Add(Me.txtNoChasis)
        Me.PanVehiculo.Controls.Add(Me.txtModelo)
        Me.PanVehiculo.Controls.Add(lblNoChasis)
        Me.PanVehiculo.Controls.Add(lblModelo)
        Me.PanVehiculo.Location = New System.Drawing.Point(35, 310)
        Me.PanVehiculo.Name = "PanVehiculo"
        Me.PanVehiculo.Size = New System.Drawing.Size(351, 169)
        Me.PanVehiculo.TabIndex = 7
        Me.PanVehiculo.Text = "Datos Vehículo"
        '
        'txtMotor
        '
        Me.txtMotor.Location = New System.Drawing.Point(88, 123)
        Me.txtMotor.MenuManager = Me.RibbonControl
        Me.txtMotor.Name = "txtMotor"
        Me.txtMotor.Size = New System.Drawing.Size(212, 20)
        Me.txtMotor.TabIndex = 11
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(88, 96)
        Me.txtPlaca.MenuManager = Me.RibbonControl
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(212, 20)
        Me.txtPlaca.TabIndex = 9
        '
        'txtNoChasis
        '
        Me.txtNoChasis.Location = New System.Drawing.Point(88, 65)
        Me.txtNoChasis.MenuManager = Me.RibbonControl
        Me.txtNoChasis.Name = "txtNoChasis"
        Me.txtNoChasis.Size = New System.Drawing.Size(212, 20)
        Me.txtNoChasis.TabIndex = 7
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(88, 39)
        Me.txtModelo.MenuManager = Me.RibbonControl
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(212, 20)
        Me.txtModelo.TabIndex = 6
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
        Me.PanBitacora.Location = New System.Drawing.Point(0, 553)
        Me.PanBitacora.Name = "PanBitacora"
        Me.PanBitacora.Size = New System.Drawing.Size(770, 96)
        Me.PanBitacora.TabIndex = 15
        Me.PanBitacora.Text = "Bitácora"
        '
        'User_agrTextEdit
        '
        Me.User_agrTextEdit.Enabled = False
        Me.User_agrTextEdit.Location = New System.Drawing.Point(180, 34)
        Me.User_agrTextEdit.MenuManager = Me.RibbonControl
        Me.User_agrTextEdit.Name = "User_agrTextEdit"
        Me.User_agrTextEdit.Size = New System.Drawing.Size(187, 20)
        Me.User_agrTextEdit.TabIndex = 3
        '
        'Fec_agrDateEdit
        '
        Me.Fec_agrDateEdit.EditValue = Nothing
        Me.Fec_agrDateEdit.Enabled = False
        Me.Fec_agrDateEdit.Location = New System.Drawing.Point(180, 60)
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
        Me.User_modTextEdit.Location = New System.Drawing.Point(473, 28)
        Me.User_modTextEdit.MenuManager = Me.RibbonControl
        Me.User_modTextEdit.Name = "User_modTextEdit"
        Me.User_modTextEdit.Size = New System.Drawing.Size(187, 20)
        Me.User_modTextEdit.TabIndex = 1
        '
        'Fec_modDateEdit
        '
        Me.Fec_modDateEdit.EditValue = Nothing
        Me.Fec_modDateEdit.Enabled = False
        Me.Fec_modDateEdit.Location = New System.Drawing.Point(473, 54)
        Me.Fec_modDateEdit.MenuManager = Me.RibbonControl
        Me.Fec_modDateEdit.Name = "Fec_modDateEdit"
        Me.Fec_modDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fec_modDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Fec_modDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.Fec_modDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Fec_modDateEdit.Size = New System.Drawing.Size(187, 20)
        Me.Fec_modDateEdit.TabIndex = 5
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.PanFranquiciado)
        Me.GroupControl1.Controls.Add(Me.txtFechaAsignado)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Enabled = False
        Me.GroupControl1.Location = New System.Drawing.Point(392, 314)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(351, 233)
        Me.GroupControl1.TabIndex = 17
        Me.GroupControl1.Text = "Datos Asignación"
        '
        'PanFranquiciado
        '
        Me.PanFranquiciado.Controls.Add(Me.lnkCEF)
        Me.PanFranquiciado.Controls.Add(Me.txtCodCEF)
        Me.PanFranquiciado.Controls.Add(Me.txtNomCEF)
        Me.PanFranquiciado.Controls.Add(Me.txtCodigoFranquiciado)
        Me.PanFranquiciado.Controls.Add(lblCodigo)
        Me.PanFranquiciado.Controls.Add(Label3)
        Me.PanFranquiciado.Controls.Add(Me.txtApellidosFranquiciado)
        Me.PanFranquiciado.Controls.Add(NombresLabel)
        Me.PanFranquiciado.Controls.Add(Me.txtNombresFranquiciado)
        Me.PanFranquiciado.Location = New System.Drawing.Point(28, 68)
        Me.PanFranquiciado.Name = "PanFranquiciado"
        Me.PanFranquiciado.Size = New System.Drawing.Size(299, 152)
        Me.PanFranquiciado.TabIndex = 10
        Me.PanFranquiciado.Text = "Datos Franquiciado"
        '
        'lnkCEF
        '
        Me.lnkCEF.AutoSize = True
        Me.lnkCEF.Location = New System.Drawing.Point(11, 118)
        Me.lnkCEF.Name = "lnkCEF"
        Me.lnkCEF.Size = New System.Drawing.Size(26, 13)
        Me.lnkCEF.TabIndex = 13
        Me.lnkCEF.TabStop = True
        Me.lnkCEF.Text = "CEF"
        '
        'txtCodCEF
        '
        Me.txtCodCEF.EditValue = ""
        Me.txtCodCEF.Location = New System.Drawing.Point(71, 115)
        Me.txtCodCEF.MenuManager = Me.RibbonControl
        Me.txtCodCEF.Name = "txtCodCEF"
        Me.txtCodCEF.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodCEF.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodCEF.Properties.MaxLength = 10
        Me.txtCodCEF.Size = New System.Drawing.Size(74, 20)
        Me.txtCodCEF.TabIndex = 11
        '
        'txtNomCEF
        '
        Me.txtNomCEF.Location = New System.Drawing.Point(147, 115)
        Me.txtNomCEF.MenuManager = Me.RibbonControl
        Me.txtNomCEF.Name = "txtNomCEF"
        Me.txtNomCEF.Properties.MaxLength = 50
        Me.txtNomCEF.Size = New System.Drawing.Size(140, 20)
        Me.txtNomCEF.TabIndex = 12
        '
        'txtCodigoFranquiciado
        '
        Me.txtCodigoFranquiciado.EditValue = ""
        Me.txtCodigoFranquiciado.Location = New System.Drawing.Point(71, 37)
        Me.txtCodigoFranquiciado.MenuManager = Me.RibbonControl
        Me.txtCodigoFranquiciado.Name = "txtCodigoFranquiciado"
        Me.txtCodigoFranquiciado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigoFranquiciado.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigoFranquiciado.Properties.MaxLength = 10
        Me.txtCodigoFranquiciado.Size = New System.Drawing.Size(216, 20)
        Me.txtCodigoFranquiciado.TabIndex = 3
        '
        'txtApellidosFranquiciado
        '
        Me.txtApellidosFranquiciado.Location = New System.Drawing.Point(71, 89)
        Me.txtApellidosFranquiciado.MenuManager = Me.RibbonControl
        Me.txtApellidosFranquiciado.Name = "txtApellidosFranquiciado"
        Me.txtApellidosFranquiciado.Properties.MaxLength = 50
        Me.txtApellidosFranquiciado.Size = New System.Drawing.Size(216, 20)
        Me.txtApellidosFranquiciado.TabIndex = 7
        '
        'txtNombresFranquiciado
        '
        Me.txtNombresFranquiciado.Location = New System.Drawing.Point(71, 63)
        Me.txtNombresFranquiciado.MenuManager = Me.RibbonControl
        Me.txtNombresFranquiciado.Name = "txtNombresFranquiciado"
        Me.txtNombresFranquiciado.Properties.MaxLength = 50
        Me.txtNombresFranquiciado.Size = New System.Drawing.Size(216, 20)
        Me.txtNombresFranquiciado.TabIndex = 5
        '
        'txtFechaAsignado
        '
        Me.txtFechaAsignado.EditValue = Nothing
        Me.txtFechaAsignado.Enabled = False
        Me.txtFechaAsignado.Location = New System.Drawing.Point(117, 39)
        Me.txtFechaAsignado.MenuManager = Me.RibbonControl
        Me.txtFechaAsignado.Name = "txtFechaAsignado"
        Me.txtFechaAsignado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaAsignado.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaAsignado.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtFechaAsignado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtFechaAsignado.Size = New System.Drawing.Size(180, 20)
        Me.txtFechaAsignado.TabIndex = 9
        '
        'frmBeneficio
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(770, 649)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanBitacora)
        Me.Controls.Add(Me.PanVehiculo)
        Me.Controls.Add(Me.PanTelefono)
        Me.Controls.Add(Me.PanDatosBeneficio)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frmBeneficio"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento de Beneficio"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdBeneficio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanDatosBeneficio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanDatosBeneficio.ResumeLayout(False)
        Me.PanDatosBeneficio.PerformLayout()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanTelefono.ResumeLayout(False)
        Me.PanTelefono.PerformLayout()
        CType(Me.txtNoTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanVehiculo.ResumeLayout(False)
        Me.PanVehiculo.PerformLayout()
        CType(Me.txtMotor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPlaca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoChasis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtModelo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanBitacora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanBitacora.ResumeLayout(False)
        Me.PanBitacora.PerformLayout()
        CType(Me.User_agrTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fec_agrDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fec_agrDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_modTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fec_modDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fec_modDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PanFranquiciado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanFranquiciado.ResumeLayout(False)
        Me.PanFranquiciado.PerformLayout()
        CType(Me.txtCodCEF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomCEF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFranquiciado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidosFranquiciado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombresFranquiciado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaAsignado.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaAsignado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents mnuGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtIdBeneficio As DevExpress.XtraEditors.SpinEdit
    Private WithEvents PanDatosBeneficio As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Private WithEvents PanTelefono As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNoTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbEmpresaTelco As System.Windows.Forms.ComboBox
    Private WithEvents PanVehiculo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNoChasis As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtModelo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMotor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPlaca As DevExpress.XtraEditors.TextEdit
    Private WithEvents PanBitacora As DevExpress.XtraEditors.GroupControl
    Friend WithEvents User_agrTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Fec_agrDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents User_modTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Fec_modDateEdit As DevExpress.XtraEditors.DateEdit
    Private WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Private WithEvents PanFranquiciado As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lnkCEF As System.Windows.Forms.LinkLabel
    Friend WithEvents txtCodCEF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomCEF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoFranquiciado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtApellidosFranquiciado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombresFranquiciado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaAsignado As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblnombre As System.Windows.Forms.Label


End Class
