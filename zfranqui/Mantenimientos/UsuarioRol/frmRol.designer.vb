<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRol
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
        Dim ActivoLabel As System.Windows.Forms.Label
        Dim User_agrLabel As System.Windows.Forms.Label
        Dim Fec_agrLabel As System.Windows.Forms.Label
        Dim User_modLabel As System.Windows.Forms.Label
        Dim Fec_modLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRol))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.mnuGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuEliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.txtIdRol = New DevExpress.XtraEditors.SpinEdit()
        Me.txtNombreRol = New DevExpress.XtraEditors.TextEdit()
        Me.chkActivo = New DevExpress.XtraEditors.CheckEdit()
        Me.User_agrTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Fec_agrDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.User_modTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Fec_modDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.PanBitacora = New DevExpress.XtraEditors.GroupControl()
        Me.PanDatosUsuario = New DevExpress.XtraEditors.GroupControl()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lvMenuRol = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvMenuSistema = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.prg = New System.Windows.Forms.ProgressBar()
        Me.cmdQuitar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        IdUsuarioLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ActivoLabel = New System.Windows.Forms.Label()
        User_agrLabel = New System.Windows.Forms.Label()
        Fec_agrLabel = New System.Windows.Forms.Label()
        User_modLabel = New System.Windows.Forms.Label()
        Fec_modLabel = New System.Windows.Forms.Label()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdRol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreRol.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
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
        NombresLabel.Size = New System.Drawing.Size(48, 13)
        NombresLabel.TabIndex = 2
        NombresLabel.Text = "Nombre:"
        '
        'ActivoLabel
        '
        ActivoLabel.AutoSize = True
        ActivoLabel.Location = New System.Drawing.Point(35, 91)
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
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.mnuGuardar, Me.mnuActualizar, Me.mnuEliminar})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 6
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(761, 144)
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
        'txtIdRol
        '
        Me.txtIdRol.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIdRol.Enabled = False
        Me.txtIdRol.Location = New System.Drawing.Point(139, 36)
        Me.txtIdRol.MenuManager = Me.RibbonControl
        Me.txtIdRol.Name = "txtIdRol"
        Me.txtIdRol.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtIdRol.Size = New System.Drawing.Size(212, 20)
        Me.txtIdRol.TabIndex = 1
        '
        'txtNombreRol
        '
        Me.txtNombreRol.Location = New System.Drawing.Point(139, 62)
        Me.txtNombreRol.MenuManager = Me.RibbonControl
        Me.txtNombreRol.Name = "txtNombreRol"
        Me.txtNombreRol.Size = New System.Drawing.Size(212, 20)
        Me.txtNombreRol.TabIndex = 3
        '
        'chkActivo
        '
        Me.chkActivo.EditValue = True
        Me.chkActivo.Location = New System.Drawing.Point(139, 88)
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
        Me.PanBitacora.Location = New System.Drawing.Point(0, 674)
        Me.PanBitacora.Name = "PanBitacora"
        Me.PanBitacora.Size = New System.Drawing.Size(761, 94)
        Me.PanBitacora.TabIndex = 1
        Me.PanBitacora.Text = "Bitácora"
        '
        'PanDatosUsuario
        '
        Me.PanDatosUsuario.Controls.Add(IdUsuarioLabel)
        Me.PanDatosUsuario.Controls.Add(Me.txtIdRol)
        Me.PanDatosUsuario.Controls.Add(NombresLabel)
        Me.PanDatosUsuario.Controls.Add(ActivoLabel)
        Me.PanDatosUsuario.Controls.Add(Me.txtNombreRol)
        Me.PanDatosUsuario.Controls.Add(Me.chkActivo)
        Me.PanDatosUsuario.Location = New System.Drawing.Point(44, 159)
        Me.PanDatosUsuario.Name = "PanDatosUsuario"
        Me.PanDatosUsuario.Size = New System.Drawing.Size(672, 119)
        Me.PanDatosUsuario.TabIndex = 0
        Me.PanDatosUsuario.Text = "Rol"
        '
        'CheckBox2
        '
        Me.CheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.DimGray
        Me.CheckBox2.Location = New System.Drawing.Point(395, 280)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "Todos"
        '
        'CheckBox1
        '
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.DimGray
        Me.CheckBox1.Location = New System.Drawing.Point(27, 280)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Todos"
        '
        'lvMenuRol
        '
        Me.lvMenuRol.CheckBoxes = True
        Me.lvMenuRol.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvMenuRol.FullRowSelect = True
        Me.lvMenuRol.Location = New System.Drawing.Point(395, 39)
        Me.lvMenuRol.Name = "lvMenuRol"
        Me.lvMenuRol.Size = New System.Drawing.Size(240, 235)
        Me.lvMenuRol.TabIndex = 3
        Me.lvMenuRol.UseCompatibleStateImageBehavior = False
        Me.lvMenuRol.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Menu Rol"
        Me.ColumnHeader3.Width = 234
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "MenuID"
        Me.ColumnHeader4.Width = 0
        '
        'lvMenuSistema
        '
        Me.lvMenuSistema.CheckBoxes = True
        Me.lvMenuSistema.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvMenuSistema.FullRowSelect = True
        Me.lvMenuSistema.Location = New System.Drawing.Point(27, 39)
        Me.lvMenuSistema.Name = "lvMenuSistema"
        Me.lvMenuSistema.Size = New System.Drawing.Size(240, 235)
        Me.lvMenuSistema.TabIndex = 0
        Me.lvMenuSistema.UseCompatibleStateImageBehavior = False
        Me.lvMenuSistema.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Menu Sistema"
        Me.ColumnHeader1.Width = 234
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "MenuID"
        Me.ColumnHeader2.Width = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.prg)
        Me.GroupControl1.Controls.Add(Me.cmdQuitar)
        Me.GroupControl1.Controls.Add(Me.cmdAgregar)
        Me.GroupControl1.Controls.Add(Me.CheckBox2)
        Me.GroupControl1.Controls.Add(Me.lvMenuSistema)
        Me.GroupControl1.Controls.Add(Me.CheckBox1)
        Me.GroupControl1.Controls.Add(Me.lvMenuRol)
        Me.GroupControl1.Location = New System.Drawing.Point(44, 299)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(672, 332)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "Permisos"
        '
        'prg
        '
        Me.prg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.prg.Location = New System.Drawing.Point(2, 307)
        Me.prg.Name = "prg"
        Me.prg.Size = New System.Drawing.Size(668, 23)
        Me.prg.TabIndex = 8
        Me.prg.Visible = False
        '
        'cmdQuitar
        '
        Me.cmdQuitar.Location = New System.Drawing.Point(287, 146)
        Me.cmdQuitar.Name = "cmdQuitar"
        Me.cmdQuitar.Size = New System.Drawing.Size(75, 23)
        Me.cmdQuitar.TabIndex = 9
        Me.cmdQuitar.Text = "<<"
        Me.cmdQuitar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(287, 108)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAgregar.TabIndex = 8
        Me.cmdAgregar.Text = ">>"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'frmRol
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(761, 768)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanDatosUsuario)
        Me.Controls.Add(Me.PanBitacora)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "frmRol"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento de Rol"
        CType(Me.RibbonControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtIdRol.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNombreRol.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.chkActivo.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.User_agrTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Fec_agrDateEdit.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Fec_agrDateEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.User_modTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Fec_modDateEdit.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Fec_modDateEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PanBitacora,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanBitacora.ResumeLayout(false)
        Me.PanBitacora.PerformLayout
        CType(Me.PanDatosUsuario,System.ComponentModel.ISupportInitialize).EndInit
        Me.PanDatosUsuario.ResumeLayout(false)
        Me.PanDatosUsuario.PerformLayout
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents mnuGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnuEliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtIdRol As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtNombreRol As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkActivo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents User_agrTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Fec_agrDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents User_modTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Fec_modDateEdit As DevExpress.XtraEditors.DateEdit
    Private WithEvents PanBitacora As DevExpress.XtraEditors.GroupControl
    Private WithEvents PanDatosUsuario As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents lvMenuRol As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvMenuSistema As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Private WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents cmdQuitar As System.Windows.Forms.Button
    Friend WithEvents prg As System.Windows.Forms.ProgressBar


End Class
