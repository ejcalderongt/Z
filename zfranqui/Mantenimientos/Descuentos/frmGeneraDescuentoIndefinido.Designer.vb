<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneraDescuentoIndefinido
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
        Me.prg = New System.Windows.Forms.ProgressBar()
        Me.txt = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'prg
        '
        Me.prg.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.prg.Location = New System.Drawing.Point(0, 472)
        Me.prg.Name = "prg"
        Me.prg.Size = New System.Drawing.Size(718, 23)
        Me.prg.TabIndex = 0
        '
        'txt
        '
        Me.txt.BackColor = System.Drawing.Color.Black
        Me.txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt.ForeColor = System.Drawing.Color.Lime
        Me.txt.Location = New System.Drawing.Point(0, 0)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(718, 472)
        Me.txt.TabIndex = 1
        Me.txt.Text = ""
        '
        'frmGeneraDescuentoIndefinido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(718, 495)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.prg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(724, 517)
        Me.MinimumSize = New System.Drawing.Size(724, 517)
        Me.Name = "frmGeneraDescuentoIndefinido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Genera Descuentos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents prg As System.Windows.Forms.ProgressBar
    Friend WithEvents txt As System.Windows.Forms.RichTextBox
End Class
