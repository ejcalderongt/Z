<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneraPago
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lblAbono As System.Windows.Forms.Label
        Dim lblMontoCancelar As System.Windows.Forms.Label
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cmdGuardaPago = New DevExpress.XtraEditors.SimpleButton()
        Me.txtMontoCancelar = New System.Windows.Forms.NumericUpDown()
        Me.lblFechaPago = New System.Windows.Forms.Label()
        Me.dtmFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaCobro = New System.Windows.Forms.Label()
        Me.dtmFechaCobro = New System.Windows.Forms.DateTimePicker()
        Me.lblCuota = New System.Windows.Forms.Label()
        Me.txtAbono = New System.Windows.Forms.NumericUpDown()
        Me.txtCuota = New System.Windows.Forms.NumericUpDown()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Dgrid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.cmdGrabar = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.cmdCancelar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.lblInformacionBeneficio = New System.Windows.Forms.Label()
        Me.lblTipoPeriodo = New System.Windows.Forms.Label()
        lblAbono = New System.Windows.Forms.Label()
        lblMontoCancelar = New System.Windows.Forms.Label()
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl1.SuspendLayout
        CType(Me.txtMontoCancelar,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtAbono,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCuota,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl2.SuspendLayout
        CType(Me.Dgrid,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BarManager,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'lblAbono
        '
        lblAbono.AutoSize = true
        lblAbono.Location = New System.Drawing.Point(12, 135)
        lblAbono.Name = "lblAbono"
        lblAbono.Size = New System.Drawing.Size(41, 13)
        lblAbono.TabIndex = 3
        lblAbono.Text = "Abono:"
        '
        'lblMontoCancelar
        '
        lblMontoCancelar.AutoSize = true
        lblMontoCancelar.Location = New System.Drawing.Point(12, 109)
        lblMontoCancelar.Name = "lblMontoCancelar"
        lblMontoCancelar.Size = New System.Drawing.Size(85, 13)
        lblMontoCancelar.TabIndex = 15
        lblMontoCancelar.Text = "Monto Cancelar:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.cmdGuardaPago)
        Me.GroupControl1.Controls.Add(Me.txtMontoCancelar)
        Me.GroupControl1.Controls.Add(lblMontoCancelar)
        Me.GroupControl1.Controls.Add(Me.lblFechaPago)
        Me.GroupControl1.Controls.Add(Me.dtmFechaPago)
        Me.GroupControl1.Controls.Add(Me.lblFechaCobro)
        Me.GroupControl1.Controls.Add(Me.dtmFechaCobro)
        Me.GroupControl1.Controls.Add(Me.lblCuota)
        Me.GroupControl1.Controls.Add(Me.txtAbono)
        Me.GroupControl1.Controls.Add(Me.txtCuota)
        Me.GroupControl1.Controls.Add(lblAbono)
        Me.GroupControl1.Location = New System.Drawing.Point(2, 79)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(704, 192)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Datos"
        '
        'cmdGuardaPago
        '
        Me.cmdGuardaPago.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmdGuardaPago.Appearance.Options.UseFont = true
        Me.cmdGuardaPago.Location = New System.Drawing.Point(139, 159)
        Me.cmdGuardaPago.Name = "cmdGuardaPago"
        Me.cmdGuardaPago.Size = New System.Drawing.Size(159, 25)
        Me.cmdGuardaPago.TabIndex = 5
        Me.cmdGuardaPago.Text = "Guardar Pago"
        '
        'txtMontoCancelar
        '
        Me.txtMontoCancelar.DecimalPlaces = 2
        Me.txtMontoCancelar.Enabled = false
        Me.txtMontoCancelar.Location = New System.Drawing.Point(139, 107)
        Me.txtMontoCancelar.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.txtMontoCancelar.Minimum = New Decimal(New Integer() {1316134911, 2328, 0, -2147483648})
        Me.txtMontoCancelar.Name = "txtMontoCancelar"
        Me.txtMontoCancelar.Size = New System.Drawing.Size(159, 20)
        Me.txtMontoCancelar.TabIndex = 3
        '
        'lblFechaPago
        '
        Me.lblFechaPago.AutoSize = true
        Me.lblFechaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFechaPago.Location = New System.Drawing.Point(12, 85)
        Me.lblFechaPago.Name = "lblFechaPago"
        Me.lblFechaPago.Size = New System.Drawing.Size(68, 13)
        Me.lblFechaPago.TabIndex = 13
        Me.lblFechaPago.Text = "Fecha Pago:"
        '
        'dtmFechaPago
        '
        Me.dtmFechaPago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dtmFechaPago.Checked = false
        Me.dtmFechaPago.CustomFormat = "dd-MMM-yyyy"
        Me.dtmFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmFechaPago.Location = New System.Drawing.Point(139, 81)
        Me.dtmFechaPago.Name = "dtmFechaPago"
        Me.dtmFechaPago.Size = New System.Drawing.Size(159, 20)
        Me.dtmFechaPago.TabIndex = 2
        '
        'lblFechaCobro
        '
        Me.lblFechaCobro.AutoSize = true
        Me.lblFechaCobro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFechaCobro.Location = New System.Drawing.Point(12, 59)
        Me.lblFechaCobro.Name = "lblFechaCobro"
        Me.lblFechaCobro.Size = New System.Drawing.Size(71, 13)
        Me.lblFechaCobro.TabIndex = 11
        Me.lblFechaCobro.Text = "Fecha Cobro:"
        '
        'dtmFechaCobro
        '
        Me.dtmFechaCobro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dtmFechaCobro.Checked = false
        Me.dtmFechaCobro.CustomFormat = "dd-MMM-yyyy"
        Me.dtmFechaCobro.Enabled = false
        Me.dtmFechaCobro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmFechaCobro.Location = New System.Drawing.Point(139, 55)
        Me.dtmFechaCobro.Name = "dtmFechaCobro"
        Me.dtmFechaCobro.Size = New System.Drawing.Size(159, 20)
        Me.dtmFechaCobro.TabIndex = 1
        '
        'lblCuota
        '
        Me.lblCuota.AutoSize = true
        Me.lblCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblCuota.Location = New System.Drawing.Point(12, 31)
        Me.lblCuota.Name = "lblCuota"
        Me.lblCuota.Size = New System.Drawing.Size(38, 13)
        Me.lblCuota.TabIndex = 9
        Me.lblCuota.Text = "Cuota:"
        '
        'txtAbono
        '
        Me.txtAbono.DecimalPlaces = 2
        Me.txtAbono.Location = New System.Drawing.Point(139, 133)
        Me.txtAbono.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.txtAbono.Minimum = New Decimal(New Integer() {1316134911, 2328, 0, -2147483648})
        Me.txtAbono.Name = "txtAbono"
        Me.txtAbono.Size = New System.Drawing.Size(159, 20)
        Me.txtAbono.TabIndex = 4
        '
        'txtCuota
        '
        Me.txtCuota.Enabled = false
        Me.txtCuota.Location = New System.Drawing.Point(139, 29)
        Me.txtCuota.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.txtCuota.Minimum = New Decimal(New Integer() {1316134911, 2328, 0, -2147483648})
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.Size = New System.Drawing.Size(159, 20)
        Me.txtCuota.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Dgrid)
        Me.GroupControl2.Location = New System.Drawing.Point(2, 277)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(704, 231)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Lista de Cuotas"
        '
        'Dgrid
        '
        Me.Dgrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.Dgrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgrid.Location = New System.Drawing.Point(2, 21)
        Me.Dgrid.MainView = Me.GridView1
        Me.Dgrid.Name = "Dgrid"
        Me.Dgrid.Size = New System.Drawing.Size(700, 208)
        Me.Dgrid.TabIndex = 0
        Me.Dgrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Dgrid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = false
        Me.GridView1.OptionsView.ShowFooter = true
        '
        'BarManager
        '
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdGrabar, Me.cmdCancelar, Me.BarStaticItem1})
        Me.BarManager.MainMenu = Me.Bar2
        Me.BarManager.MaxItemId = 3
        Me.BarManager.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdGrabar)})
        Me.Bar2.OptionsBar.MultiLine = true
        Me.Bar2.OptionsBar.UseWholeRow = true
        Me.Bar2.Text = "Main menu"
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Caption = "Grabar"
        Me.cmdGrabar.Id = 0
        Me.cmdGrabar.Name = "cmdGrabar"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = false
        Me.Bar3.OptionsBar.DrawDragBorder = false
        Me.Bar3.OptionsBar.UseWholeRow = true
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = false
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(708, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = false
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 514)
        Me.barDockControlBottom.Size = New System.Drawing.Size(708, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = false
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 492)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = false
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(708, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 492)
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Caption = "Cancelar"
        Me.cmdCancelar.Id = 1
        Me.cmdCancelar.Name = "cmdCancelar"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "|"
        Me.BarStaticItem1.Id = 2
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'lblInformacionBeneficio
        '
        Me.lblInformacionBeneficio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblInformacionBeneficio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInformacionBeneficio.Location = New System.Drawing.Point(12, 29)
        Me.lblInformacionBeneficio.Name = "lblInformacionBeneficio"
        Me.lblInformacionBeneficio.Size = New System.Drawing.Size(682, 23)
        Me.lblInformacionBeneficio.TabIndex = 231
        Me.lblInformacionBeneficio.Text = "Beneficio"
        Me.lblInformacionBeneficio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTipoPeriodo
        '
        Me.lblTipoPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoPeriodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTipoPeriodo.Location = New System.Drawing.Point(12, 52)
        Me.lblTipoPeriodo.Name = "lblTipoPeriodo"
        Me.lblTipoPeriodo.Size = New System.Drawing.Size(682, 23)
        Me.lblTipoPeriodo.TabIndex = 230
        Me.lblTipoPeriodo.Text = "Tipo Descuento"
        Me.lblTipoPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmGeneraPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 537)
        Me.Controls.Add(Me.lblInformacionBeneficio)
        Me.Controls.Add(Me.lblTipoPeriodo)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmGeneraPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago"
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(false)
        Me.GroupControl1.PerformLayout
        CType(Me.txtMontoCancelar,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtAbono,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCuota,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl2.ResumeLayout(false)
        CType(Me.Dgrid,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BarManager,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Dgrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAbono As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCuota As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCuota As System.Windows.Forms.Label
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdGrabar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents cmdCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblFechaPago As System.Windows.Forms.Label
    Friend WithEvents dtmFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaCobro As System.Windows.Forms.Label
    Friend WithEvents dtmFechaCobro As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMontoCancelar As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblInformacionBeneficio As System.Windows.Forms.Label
    Friend WithEvents lblTipoPeriodo As System.Windows.Forms.Label
    Friend WithEvents cmdGuardaPago As DevExpress.XtraEditors.SimpleButton
End Class
