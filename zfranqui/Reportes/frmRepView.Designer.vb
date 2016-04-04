<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepView
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
        Me.crview = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptDtoDetREF1 = New zfranqui.rptDtoDetREF()
        Me.SuspendLayout()
        '
        'crview
        '
        Me.crview.ActiveViewIndex = 0
        Me.crview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crview.CachedPageNumberPerDoc = 10
        Me.crview.Cursor = System.Windows.Forms.Cursors.Default
        Me.crview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crview.Location = New System.Drawing.Point(0, 0)
        Me.crview.Name = "crview"
        Me.crview.ReportSource = Me.rptDtoDetREF1
        Me.crview.Size = New System.Drawing.Size(822, 314)
        Me.crview.TabIndex = 0
        '
        'frmRepView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 314)
        Me.Controls.Add(Me.crview)
        Me.Name = "frmRepView"
        Me.Text = "Visor de reporte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crview As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptDtoDetREF1 As zfranqui.rptDtoDetREF
End Class
