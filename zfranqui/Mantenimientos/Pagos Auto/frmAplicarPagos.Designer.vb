﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAplicarPagos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.cmdImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdActualizar = New DevExpress.XtraBars.BarButtonItem()
        Me.mnuProcesar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.dtpFechaDesdeVentas = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaHastaVentas = New System.Windows.Forms.DateTimePicker()
        Me.lbldesde = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgridDescuentos = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.prg = New System.Windows.Forms.ProgressBar()
        Me.txt = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaHastaDescuentos = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaDesdeDescuentos = New System.Windows.Forms.DateTimePicker()
        Me.dgridVentas = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgridDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgridVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdImprimir, Me.cmdActualizar, Me.mnuProcesar})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Menú principal"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdImprimir), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdActualizar), New DevExpress.XtraBars.LinkPersistInfo(Me.mnuProcesar)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Menú principal"
        '
        'cmdImprimir
        '
        Me.cmdImprimir.Caption = "Imprimir"
        Me.cmdImprimir.Id = 0
        Me.cmdImprimir.Name = "cmdImprimir"
        '
        'cmdActualizar
        '
        Me.cmdActualizar.Caption = "Actualizar"
        Me.cmdActualizar.Id = 1
        Me.cmdActualizar.Name = "cmdActualizar"
        '
        'mnuProcesar
        '
        Me.mnuProcesar.Caption = "Procesar Pagos"
        Me.mnuProcesar.Id = 2
        Me.mnuProcesar.Name = "mnuProcesar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1052, 22)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 652)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1052, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 630)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1052, 22)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 630)
        '
        'dtpFechaDesdeVentas
        '
        Me.dtpFechaDesdeVentas.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesdeVentas.Location = New System.Drawing.Point(43, 40)
        Me.dtpFechaDesdeVentas.Name = "dtpFechaDesdeVentas"
        Me.dtpFechaDesdeVentas.Size = New System.Drawing.Size(106, 20)
        Me.dtpFechaDesdeVentas.TabIndex = 5
        '
        'dtpFechaHastaVentas
        '
        Me.dtpFechaHastaVentas.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHastaVentas.Location = New System.Drawing.Point(174, 40)
        Me.dtpFechaHastaVentas.Name = "dtpFechaHastaVentas"
        Me.dtpFechaHastaVentas.Size = New System.Drawing.Size(106, 20)
        Me.dtpFechaHastaVentas.TabIndex = 6
        '
        'lbldesde
        '
        Me.lbldesde.AutoSize = True
        Me.lbldesde.Location = New System.Drawing.Point(40, 24)
        Me.lbldesde.Name = "lbldesde"
        Me.lbldesde.Size = New System.Drawing.Size(38, 13)
        Me.lbldesde.TabIndex = 7
        Me.lbldesde.Text = "Desde"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(171, 24)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(35, 13)
        Me.lblHasta.TabIndex = 8
        Me.lblHasta.Text = "Hasta"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblHasta)
        Me.GroupBox1.Controls.Add(Me.lbldesde)
        Me.GroupBox1.Controls.Add(Me.dtpFechaHastaVentas)
        Me.GroupBox1.Controls.Add(Me.dtpFechaDesdeVentas)
        Me.GroupBox1.Location = New System.Drawing.Point(148, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 87)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de fecha de ventas"
        '
        'dgridDescuentos
        '
        Me.dgridDescuentos.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgridDescuentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgridDescuentos.Location = New System.Drawing.Point(474, 3)
        Me.dgridDescuentos.MainView = Me.GridView1
        Me.dgridDescuentos.MenuManager = Me.BarManager1
        Me.dgridDescuentos.Name = "dgridDescuentos"
        Me.dgridDescuentos.Size = New System.Drawing.Size(575, 334)
        Me.dgridDescuentos.TabIndex = 17
        Me.dgridDescuentos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgridDescuentos
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'prg
        '
        Me.prg.Location = New System.Drawing.Point(0, 228)
        Me.prg.Name = "prg"
        Me.prg.Size = New System.Drawing.Size(1052, 23)
        Me.prg.TabIndex = 23
        '
        'txt
        '
        Me.txt.BackColor = System.Drawing.Color.White
        Me.txt.ForeColor = System.Drawing.Color.SteelBlue
        Me.txt.Location = New System.Drawing.Point(0, 133)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(1052, 95)
        Me.txt.TabIndex = 34
        Me.txt.Text = ""
        Me.txt.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.8!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.2!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgridVentas, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgridDescuentos, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 312)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1052, 340)
        Me.TableLayoutPanel1.TabIndex = 39
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.dtpFechaHastaDescuentos)
        Me.GroupBox2.Controls.Add(Me.dtpFechaDesdeDescuentos)
        Me.GroupBox2.Location = New System.Drawing.Point(542, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 87)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rango de fecha de descuentos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Desde"
        '
        'dtpFechaHastaDescuentos
        '
        Me.dtpFechaHastaDescuentos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHastaDescuentos.Location = New System.Drawing.Point(174, 40)
        Me.dtpFechaHastaDescuentos.Name = "dtpFechaHastaDescuentos"
        Me.dtpFechaHastaDescuentos.Size = New System.Drawing.Size(106, 20)
        Me.dtpFechaHastaDescuentos.TabIndex = 6
        '
        'dtpFechaDesdeDescuentos
        '
        Me.dtpFechaDesdeDescuentos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesdeDescuentos.Location = New System.Drawing.Point(43, 40)
        Me.dtpFechaDesdeDescuentos.Name = "dtpFechaDesdeDescuentos"
        Me.dtpFechaDesdeDescuentos.Size = New System.Drawing.Size(106, 20)
        Me.dtpFechaDesdeDescuentos.TabIndex = 5
        '
        'dgridVentas
        '
        Me.dgridVentas.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgridVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgridVentas.Location = New System.Drawing.Point(3, 3)
        Me.dgridVentas.MainView = Me.GridView2
        Me.dgridVentas.MenuManager = Me.BarManager1
        Me.dgridVentas.Name = "dgridVentas"
        Me.dgridVentas.Size = New System.Drawing.Size(465, 334)
        Me.dgridVentas.TabIndex = 18
        Me.dgridVentas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.dgridVentas
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowFooter = True
        '
        'frmAplicarPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 652)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.prg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmAplicarPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos por franquiciado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgridDescuentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgridVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents cmdImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdActualizar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents lbldesde As System.Windows.Forms.Label
    Friend WithEvents dtpFechaHastaVentas As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaDesdeVentas As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgridDescuentos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents mnuProcesar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents prg As System.Windows.Forms.ProgressBar
    Friend WithEvents txt As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaHastaDescuentos As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaDesdeDescuentos As System.Windows.Forms.DateTimePicker
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgridVentas As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
