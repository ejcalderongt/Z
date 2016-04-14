<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCEF
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
        Dim lblIdCEF As System.Windows.Forms.Label
        Dim lblNombreCEF As System.Windows.Forms.Label
        Dim User_agrLabel As System.Windows.Forms.Label
        Dim Fec_agrLabel As System.Windows.Forms.Label
        Dim User_modLabel As System.Windows.Forms.Label
        Dim Fec_modLabel As System.Windows.Forms.Label
        Dim lblSupervisor As System.Windows.Forms.Label
        Dim lblDepartamento As System.Windows.Forms.Label
        Dim lblMunicipio As System.Windows.Forms.Label
        Dim lblRegion As System.Windows.Forms.Label
        Dim lblCodigoCEF As System.Windows.Forms.Label
        Dim lblCelular As System.Windows.Forms.Label
        Dim lblTelefono As System.Windows.Forms.Label
        Dim lblEncargado As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCEF))
        Dim lblInterlocutor As System.Windows.Forms.Label
        Dim lblPuntos As System.Windows.Forms.Label
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.mnuGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.txtIdCEF = New DevExpress.XtraEditors.SpinEdit()
        Me.txtDescripcionCEF = New DevExpress.XtraEditors.TextEdit()
        Me.User_agrTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Fec_agrDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.User_modTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Fec_modDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.PanBitacora = New DevExpress.XtraEditors.GroupControl()
        Me.PanDatosUsuario = New DevExpress.XtraEditors.GroupControl()
        Me.txtCodigoCEF = New DevExpress.XtraEditors.TextEdit()
        Me.txtencargado = New DevExpress.XtraEditors.TextEdit()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.txtCelular = New DevExpress.XtraEditors.TextEdit()
        Me.cmbRegion = New System.Windows.Forms.ComboBox()
        Me.cmbMunicipio = New System.Windows.Forms.ComboBox()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cmbSupervisor = New System.Windows.Forms.ComboBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtInterlocutor = New DevExpress.XtraEditors.TextEdit()
        Me.txtPuntos = New DevExpress.XtraEditors.SpinEdit()
        lblIdCEF = New System.Windows.Forms.Label()
        lblNombreCEF = New System.Windows.Forms.Label()
        User_agrLabel = New System.Windows.Forms.Label()
        Fec_agrLabel = New System.Windows.Forms.Label()
        User_modLabel = New System.Windows.Forms.Label()
        Fec_modLabel = New System.Windows.Forms.Label()
        lblSupervisor = New System.Windows.Forms.Label()
        lblDepartamento = New System.Windows.Forms.Label()
        lblMunicipio = New System.Windows.Forms.Label()
        lblRegion = New System.Windows.Forms.Label()
        lblCodigoCEF = New System.Windows.Forms.Label()
        lblCelular = New System.Windows.Forms.Label()
        lblTelefono = New System.Windows.Forms.Label()
        lblEncargado = New System.Windows.Forms.Label()
        lblInterlocutor = New System.Windows.Forms.Label()
        lblPuntos = New System.Windows.Forms.Label()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdCEF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionCEF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.txtCodigoCEF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtencargado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCelular.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtInterlocutor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPuntos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblIdCEF
        '
        lblIdCEF.AutoSize = True
        lblIdCEF.Location = New System.Drawing.Point(59, 45)
        lblIdCEF.Name = "lblIdCEF"
        lblIdCEF.Size = New System.Drawing.Size(17, 13)
        lblIdCEF.TabIndex = 0
        lblIdCEF.Text = "Id"
        '
        'lblNombreCEF
        '
        lblNombreCEF.AutoSize = True
        lblNombreCEF.Location = New System.Drawing.Point(59, 205)
        lblNombreCEF.Name = "lblNombreCEF"
        lblNombreCEF.Size = New System.Drawing.Size(61, 13)
        lblNombreCEF.TabIndex = 12
        lblNombreCEF.Text = "Descripción"
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
        'lblSupervisor
        '
        lblSupervisor.AutoSize = True
        lblSupervisor.Location = New System.Drawing.Point(59, 71)
        lblSupervisor.Name = "lblSupervisor"
        lblSupervisor.Size = New System.Drawing.Size(58, 13)
        lblSupervisor.TabIndex = 2
        lblSupervisor.Text = "Supervisor"
        '
        'lblDepartamento
        '
        lblDepartamento.AutoSize = True
        lblDepartamento.Location = New System.Drawing.Point(59, 98)
        lblDepartamento.Name = "lblDepartamento"
        lblDepartamento.Size = New System.Drawing.Size(76, 13)
        lblDepartamento.TabIndex = 4
        lblDepartamento.Text = "Departamento"
        '
        'lblMunicipio
        '
        lblMunicipio.AutoSize = True
        lblMunicipio.Location = New System.Drawing.Point(59, 125)
        lblMunicipio.Name = "lblMunicipio"
        lblMunicipio.Size = New System.Drawing.Size(50, 13)
        lblMunicipio.TabIndex = 6
        lblMunicipio.Text = "Municipio"
        '
        'lblRegion
        '
        lblRegion.AutoSize = True
        lblRegion.Location = New System.Drawing.Point(59, 152)
        lblRegion.Name = "lblRegion"
        lblRegion.Size = New System.Drawing.Size(40, 13)
        lblRegion.TabIndex = 8
        lblRegion.Text = "Región"
        '
        'lblCodigoCEF
        '
        lblCodigoCEF.AutoSize = True
        lblCodigoCEF.Location = New System.Drawing.Point(59, 179)
        lblCodigoCEF.Name = "lblCodigoCEF"
        lblCodigoCEF.Size = New System.Drawing.Size(40, 13)
        lblCodigoCEF.TabIndex = 10
        lblCodigoCEF.Text = "Código"
        '
        'lblCelular
        '
        lblCelular.AutoSize = True
        lblCelular.Location = New System.Drawing.Point(59, 231)
        lblCelular.Name = "lblCelular"
        lblCelular.Size = New System.Drawing.Size(40, 13)
        lblCelular.TabIndex = 14
        lblCelular.Text = "Celular"
        '
        'lblTelefono
        '
        lblTelefono.AutoSize = True
        lblTelefono.Location = New System.Drawing.Point(59, 257)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New System.Drawing.Size(49, 13)
        lblTelefono.TabIndex = 16
        lblTelefono.Text = "Teléfono"
        '
        'lblEncargado
        '
        lblEncargado.AutoSize = True
        lblEncargado.Location = New System.Drawing.Point(59, 283)
        lblEncargado.Name = "lblEncargado"
        lblEncargado.Size = New System.Drawing.Size(58, 13)
        lblEncargado.TabIndex = 18
        lblEncargado.Text = "Encargado"
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.mnuGuardar, Me.mnuActualizar, Me.mnuEliminar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(849, 144)
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
        'txtIdCEF
        '
        Me.txtIdCEF.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIdCEF.Enabled = False
        Me.txtIdCEF.Location = New System.Drawing.Point(139, 42)
        Me.txtIdCEF.MenuManager = Me.RibbonControl
        Me.txtIdCEF.Name = "txtIdCEF"
        Me.txtIdCEF.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtIdCEF.Size = New System.Drawing.Size(212, 20)
        Me.txtIdCEF.TabIndex = 1
        '
        'txtDescripcionCEF
        '
        Me.txtDescripcionCEF.Location = New System.Drawing.Point(139, 202)
        Me.txtDescripcionCEF.MenuManager = Me.RibbonControl
        Me.txtDescripcionCEF.Name = "txtDescripcionCEF"
        Me.txtDescripcionCEF.Size = New System.Drawing.Size(212, 20)
        Me.txtDescripcionCEF.TabIndex = 13
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
        Me.PanBitacora.Location = New System.Drawing.Point(0, 570)
        Me.PanBitacora.Name = "PanBitacora"
        Me.PanBitacora.Size = New System.Drawing.Size(849, 94)
        Me.PanBitacora.TabIndex = 1
        Me.PanBitacora.Text = "Bitácora"
        '
        'PanDatosUsuario
        '
        Me.PanDatosUsuario.Controls.Add(lblPuntos)
        Me.PanDatosUsuario.Controls.Add(Me.txtPuntos)
        Me.PanDatosUsuario.Controls.Add(lblInterlocutor)
        Me.PanDatosUsuario.Controls.Add(Me.txtInterlocutor)
        Me.PanDatosUsuario.Controls.Add(Me.txtCodigoCEF)
        Me.PanDatosUsuario.Controls.Add(lblEncargado)
        Me.PanDatosUsuario.Controls.Add(Me.txtencargado)
        Me.PanDatosUsuario.Controls.Add(lblTelefono)
        Me.PanDatosUsuario.Controls.Add(Me.txtTelefono)
        Me.PanDatosUsuario.Controls.Add(lblCelular)
        Me.PanDatosUsuario.Controls.Add(Me.txtCelular)
        Me.PanDatosUsuario.Controls.Add(lblCodigoCEF)
        Me.PanDatosUsuario.Controls.Add(lblRegion)
        Me.PanDatosUsuario.Controls.Add(Me.cmbRegion)
        Me.PanDatosUsuario.Controls.Add(lblMunicipio)
        Me.PanDatosUsuario.Controls.Add(Me.cmbMunicipio)
        Me.PanDatosUsuario.Controls.Add(lblDepartamento)
        Me.PanDatosUsuario.Controls.Add(Me.cmbDepartamento)
        Me.PanDatosUsuario.Controls.Add(lblSupervisor)
        Me.PanDatosUsuario.Controls.Add(Me.cmbSupervisor)
        Me.PanDatosUsuario.Controls.Add(lblIdCEF)
        Me.PanDatosUsuario.Controls.Add(Me.txtIdCEF)
        Me.PanDatosUsuario.Controls.Add(lblNombreCEF)
        Me.PanDatosUsuario.Controls.Add(Me.txtDescripcionCEF)
        Me.PanDatosUsuario.Location = New System.Drawing.Point(112, 169)
        Me.PanDatosUsuario.Name = "PanDatosUsuario"
        Me.PanDatosUsuario.Size = New System.Drawing.Size(407, 371)
        Me.PanDatosUsuario.TabIndex = 0
        Me.PanDatosUsuario.Text = "Datos CEF"
        '
        'txtCodigoCEF
        '
        Me.txtCodigoCEF.Location = New System.Drawing.Point(139, 176)
        Me.txtCodigoCEF.MenuManager = Me.RibbonControl
        Me.txtCodigoCEF.Name = "txtCodigoCEF"
        Me.txtCodigoCEF.Size = New System.Drawing.Size(212, 20)
        Me.txtCodigoCEF.TabIndex = 11
        '
        'txtencargado
        '
        Me.txtencargado.Location = New System.Drawing.Point(139, 280)
        Me.txtencargado.MenuManager = Me.RibbonControl
        Me.txtencargado.Name = "txtencargado"
        Me.txtencargado.Size = New System.Drawing.Size(212, 20)
        Me.txtencargado.TabIndex = 19
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(139, 254)
        Me.txtTelefono.MenuManager = Me.RibbonControl
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(212, 20)
        Me.txtTelefono.TabIndex = 17
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(139, 228)
        Me.txtCelular.MenuManager = Me.RibbonControl
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(212, 20)
        Me.txtCelular.TabIndex = 15
        '
        'cmbRegion
        '
        Me.cmbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRegion.FormattingEnabled = True
        Me.cmbRegion.Location = New System.Drawing.Point(139, 149)
        Me.cmbRegion.Name = "cmbRegion"
        Me.cmbRegion.Size = New System.Drawing.Size(212, 21)
        Me.cmbRegion.TabIndex = 9
        '
        'cmbMunicipio
        '
        Me.cmbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMunicipio.FormattingEnabled = True
        Me.cmbMunicipio.Location = New System.Drawing.Point(139, 122)
        Me.cmbMunicipio.Name = "cmbMunicipio"
        Me.cmbMunicipio.Size = New System.Drawing.Size(212, 21)
        Me.cmbMunicipio.TabIndex = 7
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(139, 95)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(212, 21)
        Me.cmbDepartamento.TabIndex = 5
        '
        'cmbSupervisor
        '
        Me.cmbSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSupervisor.FormattingEnabled = True
        Me.cmbSupervisor.Location = New System.Drawing.Point(139, 68)
        Me.cmbSupervisor.Name = "cmbSupervisor"
        Me.cmbSupervisor.Size = New System.Drawing.Size(212, 21)
        Me.cmbSupervisor.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtObservaciones)
        Me.GroupControl1.Location = New System.Drawing.Point(525, 169)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(211, 330)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtObservaciones.Location = New System.Drawing.Point(2, 149)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtObservaciones.Size = New System.Drawing.Size(207, 179)
        Me.txtObservaciones.TabIndex = 0
        '
        'lblInterlocutor
        '
        lblInterlocutor.AutoSize = True
        lblInterlocutor.Location = New System.Drawing.Point(59, 309)
        lblInterlocutor.Name = "lblInterlocutor"
        lblInterlocutor.Size = New System.Drawing.Size(64, 13)
        lblInterlocutor.TabIndex = 22
        lblInterlocutor.Text = "Interlocutor"
        '
        'txtInterlocutor
        '
        Me.txtInterlocutor.Location = New System.Drawing.Point(139, 306)
        Me.txtInterlocutor.MenuManager = Me.RibbonControl
        Me.txtInterlocutor.Name = "txtInterlocutor"
        Me.txtInterlocutor.Properties.MaxLength = 20
        Me.txtInterlocutor.Size = New System.Drawing.Size(212, 20)
        Me.txtInterlocutor.TabIndex = 23
        '
        'lblPuntos
        '
        lblPuntos.AutoSize = True
        lblPuntos.Location = New System.Drawing.Point(59, 335)
        lblPuntos.Name = "lblPuntos"
        lblPuntos.Size = New System.Drawing.Size(40, 13)
        lblPuntos.TabIndex = 24
        lblPuntos.Text = "Puntos"
        '
        'txtPuntos
        '
        Me.txtPuntos.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPuntos.Enabled = False
        Me.txtPuntos.Location = New System.Drawing.Point(139, 332)
        Me.txtPuntos.MenuManager = Me.RibbonControl
        Me.txtPuntos.Name = "txtPuntos"
        Me.txtPuntos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtPuntos.Size = New System.Drawing.Size(212, 20)
        Me.txtPuntos.TabIndex = 25
        '
        'frmCEF
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(849, 664)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanDatosUsuario)
        Me.Controls.Add(Me.PanBitacora)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frmCEF"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento de CEF"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdCEF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionCEF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.txtCodigoCEF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtencargado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCelular.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtInterlocutor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPuntos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents mnuGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtIdCEF As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtDescripcionCEF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents User_agrTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Fec_agrDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents User_modTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Fec_modDateEdit As DevExpress.XtraEditors.DateEdit
    Private WithEvents PanBitacora As DevExpress.XtraEditors.GroupControl
    Private WithEvents PanDatosUsuario As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbSupervisor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRegion As System.Windows.Forms.ComboBox
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCelular As DevExpress.XtraEditors.TextEdit
    Private WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtencargado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoCEF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPuntos As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtInterlocutor As DevExpress.XtraEditors.TextEdit


End Class
