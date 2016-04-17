<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaExcel
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
        Dim lblBorra As System.Windows.Forms.Label
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GrpBorraTabla = New System.Windows.Forms.GroupBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.chkBorraTabla = New DevExpress.XtraEditors.CheckEdit()
        Me.GrpSeleccion = New DevExpress.XtraEditors.GroupControl()
        Me.Grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSeleccionar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHoja = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.prg = New System.Windows.Forms.ProgressBar()
        Me.txtArchivo = New DevExpress.XtraEditors.ButtonEdit()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdCargar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DsExcel = New zfranqui.DsExcel()
        Me.DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        lblBorra = New System.Windows.Forms.Label()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBorraTabla.SuspendLayout()
        CType(Me.chkBorraTabla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrpSeleccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSeleccion.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArchivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBorra
        '
        lblBorra.AutoSize = True
        lblBorra.Location = New System.Drawing.Point(6, 18)
        lblBorra.Name = "lblBorra"
        lblBorra.Size = New System.Drawing.Size(65, 13)
        lblBorra.TabIndex = 1
        lblBorra.Text = "Borra Tabla:"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GrpBorraTabla
        '
        Me.GrpBorraTabla.Controls.Add(Me.lblTipo)
        Me.GrpBorraTabla.Controls.Add(lblBorra)
        Me.GrpBorraTabla.Controls.Add(Me.chkBorraTabla)
        Me.GrpBorraTabla.Location = New System.Drawing.Point(11, 33)
        Me.GrpBorraTabla.Name = "GrpBorraTabla"
        Me.GrpBorraTabla.Size = New System.Drawing.Size(582, 73)
        Me.GrpBorraTabla.TabIndex = 88
        Me.GrpBorraTabla.TabStop = False
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(6, 45)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(16, 13)
        Me.lblTipo.TabIndex = 67
        Me.lblTipo.Text = "---"
        '
        'chkBorraTabla
        '
        Me.chkBorraTabla.Location = New System.Drawing.Point(87, 15)
        Me.chkBorraTabla.Name = "chkBorraTabla"
        Me.chkBorraTabla.Properties.Caption = ""
        Me.chkBorraTabla.Size = New System.Drawing.Size(75, 19)
        Me.chkBorraTabla.TabIndex = 0
        '
        'GrpSeleccion
        '
        Me.GrpSeleccion.Controls.Add(Me.Grid)
        Me.GrpSeleccion.Location = New System.Drawing.Point(11, 112)
        Me.GrpSeleccion.Name = "GrpSeleccion"
        Me.GrpSeleccion.Size = New System.Drawing.Size(584, 136)
        Me.GrpSeleccion.TabIndex = 87
        Me.GrpSeleccion.Text = "Selección de Hoja"
        '
        'Grid
        '
        Me.Grid.Cursor = System.Windows.Forms.Cursors.Default
        Me.Grid.DataSource = Me.DataBindingSource
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.Location = New System.Drawing.Point(2, 21)
        Me.Grid.MainView = Me.GridView1
        Me.Grid.Name = "Grid"
        Me.Grid.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemTextEdit1})
        Me.Grid.Size = New System.Drawing.Size(580, 113)
        Me.Grid.TabIndex = 1
        Me.Grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSeleccionar, Me.colHoja})
        Me.GridView1.GridControl = Me.Grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colSeleccionar
        '
        Me.colSeleccionar.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colSeleccionar.FieldName = "Seleccionar"
        Me.colSeleccionar.Name = "colSeleccionar"
        Me.colSeleccionar.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
        Me.colSeleccionar.OptionsFilter.ImmediateUpdatePopupDateFilterOnCheck = DevExpress.Utils.DefaultBoolean.[True]
        Me.colSeleccionar.OptionsFilter.ImmediateUpdatePopupDateFilterOnDateChange = DevExpress.Utils.DefaultBoolean.[True]
        Me.colSeleccionar.OptionsFilter.ShowBlanksFilterItems = DevExpress.Utils.DefaultBoolean.[True]
        Me.colSeleccionar.OptionsFilter.ShowEmptyDateFilter = True
        Me.colSeleccionar.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.colSeleccionar.Visible = True
        Me.colSeleccionar.VisibleIndex = 0
        '
        'colHoja
        '
        Me.colHoja.FieldName = "Hoja"
        Me.colHoja.Name = "colHoja"
        Me.colHoja.OptionsColumn.ReadOnly = True
        Me.colHoja.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.colHoja.Visible = True
        Me.colHoja.VisibleIndex = 1
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'prg
        '
        Me.prg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.prg.Location = New System.Drawing.Point(0, 287)
        Me.prg.Name = "prg"
        Me.prg.Size = New System.Drawing.Size(607, 23)
        Me.prg.TabIndex = 86
        Me.prg.Visible = False
        '
        'txtArchivo
        '
        Me.txtArchivo.Location = New System.Drawing.Point(98, 7)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.txtArchivo.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtArchivo.Size = New System.Drawing.Size(497, 20)
        Me.txtArchivo.TabIndex = 82
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(500, 254)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(95, 24)
        Me.cmdSalir.TabIndex = 84
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdCargar
        '
        Me.cmdCargar.Location = New System.Drawing.Point(399, 254)
        Me.cmdCargar.Name = "cmdCargar"
        Me.cmdCargar.Size = New System.Drawing.Size(95, 24)
        Me.cmdCargar.TabIndex = 83
        Me.cmdCargar.Text = "Cargar"
        Me.cmdCargar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Archivo"
        '
        'DsExcel
        '
        Me.DsExcel.DataSetName = "DsExcel"
        Me.DsExcel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataBindingSource
        '
        Me.DataBindingSource.DataMember = "Data"
        Me.DataBindingSource.DataSource = Me.DsExcel
        '
        'frmCargaExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 310)
        Me.Controls.Add(Me.GrpBorraTabla)
        Me.Controls.Add(Me.GrpSeleccion)
        Me.Controls.Add(Me.prg)
        Me.Controls.Add(Me.txtArchivo)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdCargar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCargaExcel"
        Me.Text = "frmCargaExcel"
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBorraTabla.ResumeLayout(False)
        Me.GrpBorraTabla.PerformLayout()
        CType(Me.chkBorraTabla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrpSeleccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSeleccion.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArchivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpBorraTabla As System.Windows.Forms.GroupBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents chkBorraTabla As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GrpSeleccion As DevExpress.XtraEditors.GroupControl
    Private WithEvents Grid As DevExpress.XtraGrid.GridControl
    Private WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colSeleccionar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colHoja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents prg As System.Windows.Forms.ProgressBar
    Friend WithEvents txtArchivo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdCargar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsExcel As zfranqui.DsExcel
End Class
