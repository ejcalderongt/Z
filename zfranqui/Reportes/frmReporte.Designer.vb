<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporte
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.rptView = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DsPeriodoDefinido = New zfranqui.DsetRep()
        Me.DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DsPeriodoDefinido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rptView
        '
        Me.rptView.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataBindingSource
        Me.rptView.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rptView.LocalReport.ReportEmbeddedResource = "zfranqui.Report1.rdlc"
        Me.rptView.Location = New System.Drawing.Point(0, 0)
        Me.rptView.Name = "rptView"
        Me.rptView.Size = New System.Drawing.Size(608, 352)
        Me.rptView.TabIndex = 0
        '
        'DsPeriodoDefinido
        '
        Me.DsPeriodoDefinido.DataSetName = "DsPeriodoDefinido"
        Me.DsPeriodoDefinido.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataBindingSource
        '
        Me.DataBindingSource.DataMember = "Data"
        Me.DataBindingSource.DataSource = Me.DsPeriodoDefinido
        '
        'frmReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 352)
        Me.Controls.Add(Me.rptView)
        Me.Name = "frmReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DsPeriodoDefinido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rptView As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPeriodoDefinido As zfranqui.DsetRep
End Class
