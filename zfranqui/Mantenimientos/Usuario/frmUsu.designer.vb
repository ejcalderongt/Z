<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsu
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
        Dim IdUsuarioLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim ClaveLabel As System.Windows.Forms.Label
        Dim Ultimo_loginLabel As System.Windows.Forms.Label
        Dim ActivoLabel As System.Windows.Forms.Label
        Dim User_agrLabel As System.Windows.Forms.Label
        Dim Fec_agrLabel As System.Windows.Forms.Label
        Dim User_modLabel As System.Windows.Forms.Label
        Dim Fec_modLabel As System.Windows.Forms.Label
        Dim lblConfirmarClave As System.Windows.Forms.Label
        Dim lblRol As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsu))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.mnuGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.IdUsuarioSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.NombresTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CodigoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ClaveTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Ultimo_loginDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.chkActivo = New DevExpress.XtraEditors.CheckEdit()
        Me.User_agrTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Fec_agrDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.User_modTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Fec_modDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.PanBitacora = New DevExpress.XtraEditors.GroupControl()
        Me.PanDatosUsuario = New DevExpress.XtraEditors.GroupControl()
        Me.cmbRol = New System.Windows.Forms.ComboBox()
        Me.ConfirmarClaveTextEdit = New DevExpress.XtraEditors.TextEdit()
        IdUsuarioLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        ClaveLabel = New System.Windows.Forms.Label()
        Ultimo_loginLabel = New System.Windows.Forms.Label()
        ActivoLabel = New System.Windows.Forms.Label()
        User_agrLabel = New System.Windows.Forms.Label()
        Fec_agrLabel = New System.Windows.Forms.Label()
        User_modLabel = New System.Windows.Forms.Label()
        Fec_modLabel = New System.Windows.Forms.Label()
        lblConfirmarClave = New System.Windows.Forms.Label()
        lblRol = New System.Windows.Forms.Label()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdUsuarioSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NombresTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CodigoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClaveTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ultimo_loginDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ultimo_loginDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.ConfirmarClaveTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdUsuarioLabel
        '
        IdUsuarioLabel.AutoSize = True
        IdUsuarioLabel.Location = New System.Drawing.Point(35, 39)
        IdUsuarioLabel.Name = "IdUsuarioLabel"
        IdUsuarioLabel.Size = New System.Drawing.Size(40, 13)
        IdUsuarioLabel.TabIndex = 0
        IdUsuarioLabel.Text = "Código"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(35, 65)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(53, 13)
        NombresLabel.TabIndex = 2
        NombresLabel.Text = "Nombres:"
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(35, 94)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(95, 13)
        CodigoLabel.TabIndex = 14
        CodigoLabel.Text = "Código de acceso:"
        '
        'ClaveLabel
        '
        ClaveLabel.AutoSize = True
        ClaveLabel.Location = New System.Drawing.Point(35, 120)
        ClaveLabel.Name = "ClaveLabel"
        ClaveLabel.Size = New System.Drawing.Size(89, 13)
        ClaveLabel.TabIndex = 16
        ClaveLabel.Text = "Clave de acceso:"
        '
        'Ultimo_loginLabel
        '
        Ultimo_loginLabel.AutoSize = True
        Ultimo_loginLabel.Location = New System.Drawing.Point(35, 172)
        Ultimo_loginLabel.Name = "Ultimo_loginLabel"
        Ultimo_loginLabel.Size = New System.Drawing.Size(78, 13)
        Ultimo_loginLabel.TabIndex = 20
        Ultimo_loginLabel.Text = "Último ingreso:"
        '
        'ActivoLabel
        '
        ActivoLabel.AutoSize = True
        ActivoLabel.Location = New System.Drawing.Point(35, 224)
        ActivoLabel.Name = "ActivoLabel"
        ActivoLabel.Size = New System.Drawing.Size(41, 13)
        ActivoLabel.TabIndex = 22
        ActivoLabel.Text = "Activo:"
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
        'lblConfirmarClave
        '
        lblConfirmarClave.AutoSize = True
        lblConfirmarClave.Location = New System.Drawing.Point(35, 146)
        lblConfirmarClave.Name = "lblConfirmarClave"
        lblConfirmarClave.Size = New System.Drawing.Size(86, 13)
        lblConfirmarClave.TabIndex = 18
        lblConfirmarClave.Text = "Confirmar clave:"
        '
        'lblRol
        '
        lblRol.AutoSize = True
        lblRol.Location = New System.Drawing.Point(35, 198)
        lblRol.Name = "lblRol"
        lblRol.Size = New System.Drawing.Size(26, 13)
        lblRol.TabIndex = 24
        lblRol.Text = "Rol:"
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
        'IdUsuarioSpinEdit
        '
        Me.IdUsuarioSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IdUsuarioSpinEdit.Enabled = False
        Me.IdUsuarioSpinEdit.Location = New System.Drawing.Point(139, 36)
        Me.IdUsuarioSpinEdit.MenuManager = Me.RibbonControl
        Me.IdUsuarioSpinEdit.Name = "IdUsuarioSpinEdit"
        Me.IdUsuarioSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdUsuarioSpinEdit.Size = New System.Drawing.Size(212, 20)
        Me.IdUsuarioSpinEdit.TabIndex = 1
        '
        'NombresTextEdit
        '
        Me.NombresTextEdit.Location = New System.Drawing.Point(139, 62)
        Me.NombresTextEdit.MenuManager = Me.RibbonControl
        Me.NombresTextEdit.Name = "NombresTextEdit"
        Me.NombresTextEdit.Size = New System.Drawing.Size(212, 20)
        Me.NombresTextEdit.TabIndex = 3
        '
        'CodigoTextEdit
        '
        Me.CodigoTextEdit.Location = New System.Drawing.Point(139, 91)
        Me.CodigoTextEdit.MenuManager = Me.RibbonControl
        Me.CodigoTextEdit.Name = "CodigoTextEdit"
        Me.CodigoTextEdit.Size = New System.Drawing.Size(212, 20)
        Me.CodigoTextEdit.TabIndex = 15
        '
        'ClaveTextEdit
        '
        Me.ClaveTextEdit.Location = New System.Drawing.Point(139, 117)
        Me.ClaveTextEdit.MenuManager = Me.RibbonControl
        Me.ClaveTextEdit.Name = "ClaveTextEdit"
        Me.ClaveTextEdit.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.ClaveTextEdit.Size = New System.Drawing.Size(212, 20)
        Me.ClaveTextEdit.TabIndex = 17
        '
        'Ultimo_loginDateEdit
        '
        Me.Ultimo_loginDateEdit.EditValue = Nothing
        Me.Ultimo_loginDateEdit.Enabled = False
        Me.Ultimo_loginDateEdit.Location = New System.Drawing.Point(139, 169)
        Me.Ultimo_loginDateEdit.MenuManager = Me.RibbonControl
        Me.Ultimo_loginDateEdit.Name = "Ultimo_loginDateEdit"
        Me.Ultimo_loginDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ultimo_loginDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Ultimo_loginDateEdit.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.Ultimo_loginDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Ultimo_loginDateEdit.Size = New System.Drawing.Size(212, 20)
        Me.Ultimo_loginDateEdit.TabIndex = 21
        '
        'chkActivo
        '
        Me.chkActivo.EditValue = True
        Me.chkActivo.Location = New System.Drawing.Point(139, 221)
        Me.chkActivo.MenuManager = Me.RibbonControl
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Properties.Caption = ""
        Me.chkActivo.Size = New System.Drawing.Size(100, 19)
        Me.chkActivo.TabIndex = 23
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
        Me.PanDatosUsuario.Controls.Add(Me.cmbRol)
        Me.PanDatosUsuario.Controls.Add(lblRol)
        Me.PanDatosUsuario.Controls.Add(lblConfirmarClave)
        Me.PanDatosUsuario.Controls.Add(Me.ConfirmarClaveTextEdit)
        Me.PanDatosUsuario.Controls.Add(IdUsuarioLabel)
        Me.PanDatosUsuario.Controls.Add(Me.IdUsuarioSpinEdit)
        Me.PanDatosUsuario.Controls.Add(Ultimo_loginLabel)
        Me.PanDatosUsuario.Controls.Add(NombresLabel)
        Me.PanDatosUsuario.Controls.Add(Me.Ultimo_loginDateEdit)
        Me.PanDatosUsuario.Controls.Add(ActivoLabel)
        Me.PanDatosUsuario.Controls.Add(Me.NombresTextEdit)
        Me.PanDatosUsuario.Controls.Add(Me.chkActivo)
        Me.PanDatosUsuario.Controls.Add(CodigoLabel)
        Me.PanDatosUsuario.Controls.Add(Me.CodigoTextEdit)
        Me.PanDatosUsuario.Controls.Add(ClaveLabel)
        Me.PanDatosUsuario.Controls.Add(Me.ClaveTextEdit)
        Me.PanDatosUsuario.Location = New System.Drawing.Point(222, 206)
        Me.PanDatosUsuario.Name = "PanDatosUsuario"
        Me.PanDatosUsuario.Size = New System.Drawing.Size(404, 256)
        Me.PanDatosUsuario.TabIndex = 0
        Me.PanDatosUsuario.Text = "Datos Usuario"
        '
        'cmbRol
        '
        Me.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRol.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRol.ForeColor = System.Drawing.Color.Navy
        Me.cmbRol.Location = New System.Drawing.Point(139, 195)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(212, 21)
        Me.cmbRol.TabIndex = 25
        '
        'ConfirmarClaveTextEdit
        '
        Me.ConfirmarClaveTextEdit.Location = New System.Drawing.Point(139, 143)
        Me.ConfirmarClaveTextEdit.MenuManager = Me.RibbonControl
        Me.ConfirmarClaveTextEdit.Name = "ConfirmarClaveTextEdit"
        Me.ConfirmarClaveTextEdit.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.ConfirmarClaveTextEdit.Size = New System.Drawing.Size(212, 20)
        Me.ConfirmarClaveTextEdit.TabIndex = 19
        '
        'frmUsu
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(849, 664)
        Me.Controls.Add(Me.PanDatosUsuario)
        Me.Controls.Add(Me.PanBitacora)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frmUsu"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Usuario"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdUsuarioSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NombresTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CodigoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClaveTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ultimo_loginDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ultimo_loginDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.ConfirmarClaveTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents mnuGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents IdUsuarioSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents NombresTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CodigoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ClaveTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ultimo_loginDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkActivo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents User_agrTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Fec_agrDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents User_modTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Fec_modDateEdit As DevExpress.XtraEditors.DateEdit
    Private WithEvents PanBitacora As DevExpress.XtraEditors.GroupControl
    Private WithEvents PanDatosUsuario As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ConfirmarClaveTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbRol As System.Windows.Forms.ComboBox


End Class
