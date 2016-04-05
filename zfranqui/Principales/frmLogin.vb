Imports DevExpress.XtraEditors

Public Class frmLogin
    Inherits System.Windows.Forms.Form

    Private ModoConfiguracion As New pModoConfiguracion

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdIngresar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdIngresar = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.Navy
        Me.txtUsuario.Location = New System.Drawing.Point(35, 49)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(216, 22)
        Me.txtUsuario.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(35, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(35, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Clave"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtContraseña)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(204, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 159)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.Navy
        Me.txtContraseña.Location = New System.Drawing.Point(35, 93)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(216, 22)
        Me.txtContraseña.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(221, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(251, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "CONTROL DE FRANQUICIAS Z"
        '
        'cmdIngresar
        '
        Me.cmdIngresar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdIngresar.Location = New System.Drawing.Point(0, 282)
        Me.cmdIngresar.LookAndFeel.SkinName = "Summer 2008"
        Me.cmdIngresar.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdIngresar.Name = "cmdIngresar"
        Me.cmdIngresar.Size = New System.Drawing.Size(539, 41)
        Me.cmdIngresar.TabIndex = 2
        Me.cmdIngresar.Text = "Ingresar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.zfranqui.My.Resources.Resources.Logo_Zeta_Nuevo
        Me.PictureBox1.Location = New System.Drawing.Point(32, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 192)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(539, 323)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdIngresar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso Al Sistema"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private lUsuario As New clsLnUsuario
    Private Usuario As New clsBeUsuario

    Private Sub frmLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtUsuario.Focus()
    End Sub

    Private Function InfOK() As Boolean

        InfOK = False

        If Trim(txtUsuario.Text) = "" Then
            MsgBox("Ingrese código de Usuario.", MsgBoxStyle.Exclamation) : txtUsuario.Focus()
        ElseIf Trim(txtContraseña.Text) = "" Then
            MsgBox("Ingrese Contraseña", MsgBoxStyle.Exclamation) : txtContraseña.Focus()
        Else : InfOK = True
        End If

    End Function

    Private Sub txtUsuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.GotFocus
        txtUsuario.SelectAll()
    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress

        If e.KeyChar = Chr(13) Then
            If txtUsuario.Text <> "" Then
                txtContraseña.SelectAll()
                txtContraseña.Focus()
            Else
                MsgBox("Ingrese código de usuario", MsgBoxStyle.Exclamation, Me.Text)
                txtUsuario.SelectAll()
                txtUsuario.Focus()
            End If
        End If

    End Sub

    Private Sub txtContraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContraseña.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtContraseña.Text <> "" Then
                cmdIngresar_Click(Nothing, Nothing)
            Else
                MsgBox("Ingrese clave de usuario", MsgBoxStyle.Exclamation)
                txtContraseña.SelectAll()
                txtContraseña.Focus()
            End If
        End If
    End Sub

    Private Sub cmdIngresar_Click(sender As Object, e As EventArgs) Handles cmdIngresar.Click

        Try

            If InfOK() Then

                Usuario.Codigo = txtUsuario.Text
                Usuario.Clave = txtContraseña.Text

                If lUsuario.Usuario_Valido(Usuario) Then

                    gUsuario = Usuario

                    lUsuario.Actualiza_Ultimo_Ingreso(Usuario)

                    Inserta_Bitacora_Ingreso()

                    Me.Hide()

                    Dim Menu As New frmMenu
                    Menu.lblUser.Caption = Usuario.Nombre
                    Menu.ShowDialog()

                    Usuario = Nothing : lUsuario = Nothing
                    Me.Close()

                Else
                    MsgBox("Usuario o contraseña incorrecta!", MsgBoxStyle.Exclamation, Me.Text) : txtUsuario.SelectAll() : txtUsuario.Focus()
                End If

            End If



        Catch ex As Exception
            Dim ConS As String = BD.CadenaConexion
            ConS = ConS.Remove(38, 20)
            XtraMessageBox.Show("Error en inicio de sesión: " & vbNewLine & ex.Message & vbNewLine & " Parámetros de conexión (pwd less): " & ConS, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Try

            If e.Control = True AndAlso e.KeyCode = Keys.I Then
                If MsgBox("¿Abrir archivo de configuración?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                    Process.Start(CurDir() & "\conn.ini", IO.FileMode.Open)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ModoConfiguracion = pModoConfiguracion.Desarrollo

        Try

            If Not Existe_Ini() Then

                Select Case ModoConfiguracion

                    Case pModoConfiguracion.Desarrollo
                        BD.CadenaConexion = My.Settings.strConLocalDesarrollo

                    Case pModoConfiguracion.ProduccionLocal
                        BD.CadenaConexion = My.Settings.strConLocalProduccion

                    Case pModoConfiguracion.ProduccionRemoto
                        BD.CadenaConexion = My.Settings.strConPublicProduccion

                End Select

            Else
                Leer_Cadena_Conexion()
            End If

            GetIPAddress()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function Existe_Ini() As Boolean

        Return IO.File.Exists(CurDir() & "\conn.ini")

    End Function

    Public Sub Leer_Cadena_Conexion()

        Try

            Dim oRead As System.IO.StreamReader  ' Objeto con métodos para lectura

            oRead = IO.File.OpenText(CurDir() & "\Conn.ini")

            BD.CadenaConexion = oRead.ReadLine

            oRead.Close()



        Catch ex As Exception
            MsgBox("Error al leer archivo de conexión a BD Conn.ini: " & ex.Message & _
                   vbNewLine & " Ruta del archivo: " & CurDir() & "/Conn.ini", MsgBoxStyle.Critical)
        End Try

    End Sub

    Enum pModoConfiguracion
        Desarrollo = 1
        ProduccionRemoto = 2
        ProduccionLocal = 3
    End Enum

    Dim Contador As Integer = 0

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        Contador += 1

        If Contador = 10 Then
            If MsgBox(CurDir() & vbNewLine & "¿Reiniciar contador?", MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                Contador = 0
            End If
        End If

        If Contador = 15 Then
            Process.Start(CurDir)
            Contador = 0
        End If

    End Sub

    Private Sub GetIPAddress()

        Try

            HostName = System.Net.Dns.GetHostName()

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Inserta_Bitacora_Ingreso()

        Try

            Bita = New clsBeBitacora
            Bita.IdUsuario = gUsuario.IdUsuario
            Bita.Modulo = "Login"
            Bita.Accion = "Ingreso"
            Bita.Fecha = Now
            Bita.Observacion = HostName
            nB.Insertar(Bita)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class