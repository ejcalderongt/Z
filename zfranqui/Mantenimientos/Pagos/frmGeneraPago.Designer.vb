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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cmdGuardarPago = New System.Windows.Forms.Button()
        Me.txtMontoCancelar = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtmFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtmFechaCobro = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Label2 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtMontoCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.Dgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(12, 135)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(41, 13)
        Label2.TabIndex = 3
        Label2.Text = "Abono:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(12, 109)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(85, 13)
        Label5.TabIndex = 15
        Label5.Text = "Monto Cancelar:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.cmdGuardarPago)
        Me.GroupControl1.Controls.Add(Me.txtMontoCancelar)
        Me.GroupControl1.Controls.Add(Label5)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.dtmFechaPago)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.dtmFechaCobro)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.txtAbono)
        Me.GroupControl1.Controls.Add(Me.txtCuota)
        Me.GroupControl1.Controls.Add(Label2)
        Me.GroupControl1.Location = New System.Drawing.Point(2, 79)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(704, 192)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Datos"
        '
        'cmdGuardarPago
        '
        Me.cmdGuardarPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdGuardarPago.Location = New System.Drawing.Point(139, 159)
        Me.cmdGuardarPago.Name = "cmdGuardarPago"
        Me.cmdGuardarPago.Size = New System.Drawing.Size(159, 23)
        Me.cmdGuardarPago.TabIndex = 153
        Me.cmdGuardarPago.Text = "Guardar Pago"
        Me.cmdGuardarPago.UseVisualStyleBackColor = True
        '
        'txtMontoCancelar
        '
        Me.txtMontoCancelar.DecimalPlaces = 2
        Me.txtMontoCancelar.Enabled = False
        Me.txtMontoCancelar.Location = New System.Drawing.Point(139, 107)
        Me.txtMontoCancelar.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.txtMontoCancelar.Minimum = New Decimal(New Integer() {1316134911, 2328, 0, -2147483648})
        Me.txtMontoCancelar.Name = "txtMontoCancelar"
        Me.txtMontoCancelar.Size = New System.Drawing.Size(159, 20)
        Me.txtMontoCancelar.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fecha Pago:"
        '
        'dtmFechaPago
        '
        Me.dtmFechaPago.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtmFechaPago.Checked = False
        Me.dtmFechaPago.CustomFormat = "dd-MMM-yyyy"
        Me.dtmFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmFechaPago.Location = New System.Drawing.Point(139, 81)
        Me.dtmFechaPago.Name = "dtmFechaPago"
        Me.dtmFechaPago.Size = New System.Drawing.Size(159, 20)
        Me.dtmFechaPago.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Fecha Cobro:"
        '
        'dtmFechaCobro
        '
        Me.dtmFechaCobro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtmFechaCobro.Checked = False
        Me.dtmFechaCobro.CustomFormat = "dd-MMM-yyyy"
        Me.dtmFechaCobro.Enabled = False
        Me.dtmFechaCobro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmFechaCobro.Location = New System.Drawing.Point(139, 55)
        Me.dtmFechaCobro.Name = "dtmFechaCobro"
        Me.dtmFechaCobro.Size = New System.Drawing.Size(159, 20)
        Me.dtmFechaCobro.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Cuota:"
        '
        'txtAbono
        '
        Me.txtAbono.DecimalPlaces = 2
        Me.txtAbono.Location = New System.Drawing.Point(139, 133)
        Me.txtAbono.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.txtAbono.Minimum = New Decimal(New Integer() {1316134911, 2328, 0, -2147483648})
        Me.txtAbono.Name = "txtAbono"
        Me.txtAbono.Size = New System.Drawing.Size(159, 20)
        Me.txtAbono.TabIndex = 2
        '
        'txtCuota
        '
        Me.txtCuota.Enabled = False
        Me.txtCuota.Location = New System.Drawing.Point(139, 29)
        Me.txtCuota.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.txtCuota.Minimum = New Decimal(New Integer() {1316134911, 2328, 0, -2147483648})
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.Size = New System.Drawing.Size(159, 20)
        Me.txtCuota.TabIndex = 1
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Dgrid)
        Me.GroupControl2.Location = New System.Drawing.Point(2, 277)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(704, 206)
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
        Me.Dgrid.Size = New System.Drawing.Size(700, 183)
        Me.Dgrid.TabIndex = 0
        Me.Dgrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Dgrid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
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
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
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
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(708, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 489)
        Me.barDockControlBottom.Size = New System.Drawing.Size(708, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 467)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(708, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 467)
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
        Me.lblInformacionBeneficio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformacionBeneficio.ForeColor = System.Drawing.SystemColors.InfoText
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
        Me.lblTipoPeriodo.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblTipoPeriodo.Location = New System.Drawing.Point(12, 52)
        Me.lblTipoPeriodo.Name = "lblTipoPeriodo"
        Me.lblTipoPeriodo.Size = New System.Drawing.Size(682, 23)
        Me.lblTipoPeriodo.TabIndex = 230
        Me.lblTipoPeriodo.Text = "Tipo Descuento"
        Me.lblTipoPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmGeneraPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 512)
        Me.Controls.Add(Me.lblInformacionBeneficio)
        Me.Controls.Add(Me.lblTipoPeriodo)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(724, 546)
        Me.MinimumSize = New System.Drawing.Size(724, 546)
        Me.Name = "frmGeneraPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtMontoCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.Dgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Dgrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtAbono As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCuota As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtmFechaPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtmFechaCobro As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMontoCancelar As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdGuardarPago As System.Windows.Forms.Button
    Friend WithEvents lblInformacionBeneficio As System.Windows.Forms.Label
    Friend WithEvents lblTipoPeriodo As System.Windows.Forms.Label
End Class
