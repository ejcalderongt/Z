<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDescuentosAuto
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
        Me.txt = New System.Windows.Forms.RichTextBox()
        Me.prg = New System.Windows.Forms.ProgressBar()
        Me.dgrid = New System.Windows.Forms.DataGridView()
        Me.ButtonProcesar = New System.Windows.Forms.Button()
        CType(Me.dgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt
        '
        Me.txt.BackColor = System.Drawing.Color.DarkGray
        Me.txt.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt.ForeColor = System.Drawing.Color.Lime
        Me.txt.Location = New System.Drawing.Point(0, 0)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(673, 230)
        Me.txt.TabIndex = 2
        Me.txt.Text = ""
        '
        'prg
        '
        Me.prg.Dock = System.Windows.Forms.DockStyle.Top
        Me.prg.Location = New System.Drawing.Point(0, 230)
        Me.prg.Name = "prg"
        Me.prg.Size = New System.Drawing.Size(673, 23)
        Me.prg.TabIndex = 3
        '
        'dgrid
        '
        Me.dgrid.BackgroundColor = System.Drawing.Color.White
        Me.dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgrid.Location = New System.Drawing.Point(0, 253)
        Me.dgrid.Name = "dgrid"
        Me.dgrid.Size = New System.Drawing.Size(673, 216)
        Me.dgrid.TabIndex = 4
        '
        'ButtonProcesar
        '
        Me.ButtonProcesar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonProcesar.Location = New System.Drawing.Point(0, 434)
        Me.ButtonProcesar.Name = "ButtonProcesar"
        Me.ButtonProcesar.Size = New System.Drawing.Size(673, 35)
        Me.ButtonProcesar.TabIndex = 5
        Me.ButtonProcesar.Text = "Procesar"
        Me.ButtonProcesar.UseVisualStyleBackColor = True
        '
        'frmDescuentosAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(673, 469)
        Me.Controls.Add(Me.ButtonProcesar)
        Me.Controls.Add(Me.dgrid)
        Me.Controls.Add(Me.prg)
        Me.Controls.Add(Me.txt)
        Me.Name = "frmDescuentosAuto"
        Me.Text = "frmDescuentosAuto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt As System.Windows.Forms.RichTextBox
    Friend WithEvents prg As System.Windows.Forms.ProgressBar
    Friend WithEvents dgrid As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonProcesar As System.Windows.Forms.Button
End Class
