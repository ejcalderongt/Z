<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeriodo
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim IdEmpresaLabel As System.Windows.Forms.Label
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtRedondear = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtmFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.txtMontoTotal = New System.Windows.Forms.NumericUpDown()
        Me.txtCuota = New System.Windows.Forms.NumericUpDown()
        Me.cmbPeriodo = New System.Windows.Forms.ComboBox()
        Me.txtFiltro = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Dgrid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.cmdNuevoBeneficio = New System.Windows.Forms.Button()
        Me.cmbTipoBeneficio = New System.Windows.Forms.ComboBox()
        Me.lblNoCuota = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        IdEmpresaLabel = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtRedondear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFiltro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.Dgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(12, 63)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(67, 13)
        Label2.TabIndex = 3
        Label2.Text = "Monto Total:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 36)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(48, 13)
        Label1.TabIndex = 0
        Label1.Text = "Período:"
        '
        'IdEmpresaLabel
        '
        IdEmpresaLabel.AutoSize = True
        IdEmpresaLabel.Location = New System.Drawing.Point(12, 30)
        IdEmpresaLabel.Name = "IdEmpresaLabel"
        IdEmpresaLabel.Size = New System.Drawing.Size(78, 13)
        IdEmpresaLabel.TabIndex = 0
        IdEmpresaLabel.Text = "Tipo Beneficio:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lblNoCuota)
        Me.GroupControl1.Controls.Add(Me.txtRedondear)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.dtmFecha)
        Me.GroupControl1.Controls.Add(Me.lblPeriodo)
        Me.GroupControl1.Controls.Add(Me.txtMontoTotal)
        Me.GroupControl1.Controls.Add(Me.txtCuota)
        Me.GroupControl1.Controls.Add(Label2)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(Me.cmbPeriodo)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(708, 171)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Datos"
        '
        'txtRedondear
        '
        Me.txtRedondear.Location = New System.Drawing.Point(139, 141)
        Me.txtRedondear.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.txtRedondear.Minimum = New Decimal(New Integer() {1316134911, 2328, 0, -2147483648})
        Me.txtRedondear.Name = "txtRedondear"
        Me.txtRedondear.Size = New System.Drawing.Size(159, 20)
        Me.txtRedondear.TabIndex = 4
        Me.txtRedondear.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Redondear (Decimales):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "A partir de:"
        '
        'dtmFecha
        '
        Me.dtmFecha.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtmFecha.Checked = False
        Me.dtmFecha.CustomFormat = "dd-MMM-yyyy"
        Me.dtmFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmFecha.Location = New System.Drawing.Point(139, 113)
        Me.dtmFecha.Name = "dtmFecha"
        Me.dtmFecha.Size = New System.Drawing.Size(159, 20)
        Me.dtmFecha.TabIndex = 3
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodo.Location = New System.Drawing.Point(304, 36)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(0, 13)
        Me.lblPeriodo.TabIndex = 2
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.DecimalPlaces = 2
        Me.txtMontoTotal.Location = New System.Drawing.Point(139, 61)
        Me.txtMontoTotal.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.txtMontoTotal.Minimum = New Decimal(New Integer() {1316134911, 2328, 0, -2147483648})
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.Size = New System.Drawing.Size(159, 20)
        Me.txtMontoTotal.TabIndex = 1
        '
        'txtCuota
        '
        Me.txtCuota.Location = New System.Drawing.Point(445, 87)
        Me.txtCuota.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.txtCuota.Minimum = New Decimal(New Integer() {1316134911, 2328, 0, -2147483648})
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.Size = New System.Drawing.Size(159, 20)
        Me.txtCuota.TabIndex = 2
        '
        'cmbPeriodo
        '
        Me.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeriodo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPeriodo.ForeColor = System.Drawing.Color.Navy
        Me.cmbPeriodo.Location = New System.Drawing.Point(139, 33)
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.Size = New System.Drawing.Size(159, 21)
        Me.cmbPeriodo.TabIndex = 0
        '
        'txtFiltro
        '
        Me.txtFiltro.EditValue = ""
        Me.txtFiltro.Location = New System.Drawing.Point(15, 54)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtFiltro.Size = New System.Drawing.Size(681, 22)
        Me.txtFiltro.TabIndex = 2
        Me.txtFiltro.Tag = "Buscar..."
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Dgrid)
        Me.GroupControl2.Location = New System.Drawing.Point(0, 273)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(718, 240)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Lista de Beneficios"
        '
        'Dgrid
        '
        Me.Dgrid.Cursor = System.Windows.Forms.Cursors.Default
        Me.Dgrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgrid.Location = New System.Drawing.Point(2, 21)
        Me.Dgrid.MainView = Me.GridView1
        Me.Dgrid.Name = "Dgrid"
        Me.Dgrid.Size = New System.Drawing.Size(714, 217)
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
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.cmdNuevoBeneficio)
        Me.GroupControl3.Controls.Add(Me.cmbTipoBeneficio)
        Me.GroupControl3.Controls.Add(Me.txtFiltro)
        Me.GroupControl3.Controls.Add(IdEmpresaLabel)
        Me.GroupControl3.Location = New System.Drawing.Point(0, 177)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(718, 90)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Filtro"
        '
        'cmdNuevoBeneficio
        '
        Me.cmdNuevoBeneficio.Location = New System.Drawing.Point(304, 27)
        Me.cmdNuevoBeneficio.Name = "cmdNuevoBeneficio"
        Me.cmdNuevoBeneficio.Size = New System.Drawing.Size(75, 21)
        Me.cmdNuevoBeneficio.TabIndex = 3
        Me.cmdNuevoBeneficio.Text = "Nuevo"
        Me.cmdNuevoBeneficio.UseVisualStyleBackColor = True
        '
        'cmbTipoBeneficio
        '
        Me.cmbTipoBeneficio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoBeneficio.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoBeneficio.ForeColor = System.Drawing.Color.Navy
        Me.cmbTipoBeneficio.Location = New System.Drawing.Point(139, 27)
        Me.cmbTipoBeneficio.Name = "cmbTipoBeneficio"
        Me.cmbTipoBeneficio.Size = New System.Drawing.Size(159, 21)
        Me.cmbTipoBeneficio.TabIndex = 0
        '
        'lblNoCuota
        '
        Me.lblNoCuota.AutoSize = True
        Me.lblNoCuota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoCuota.Location = New System.Drawing.Point(12, 89)
        Me.lblNoCuota.Name = "lblNoCuota"
        Me.lblNoCuota.Size = New System.Drawing.Size(63, 13)
        Me.lblNoCuota.TabIndex = 11
        Me.lblNoCuota.Text = "No. Cuotas:"
        '
        'frmPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 521)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(724, 560)
        Me.MinimumSize = New System.Drawing.Size(724, 560)
        Me.Name = "frmPeriodo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Período Definido"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtRedondear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFiltro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.Dgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents txtFiltro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Dgrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtMontoTotal As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCuota As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbTipoBeneficio As System.Windows.Forms.ComboBox
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents dtmFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRedondear As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdNuevoBeneficio As System.Windows.Forms.Button
    Friend WithEvents lblNoCuota As System.Windows.Forms.Label
End Class
