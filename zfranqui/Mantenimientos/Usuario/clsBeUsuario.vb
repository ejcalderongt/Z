Public Class clsBeUsuario
    Implements ICloneable


    Private mIdUsuario As Integer = 0
    Private mNombre As String = ""
    Private mActivo As Integer = 0
    Private mCodigo As String = ""
    Private mClave As String = ""
    Private mIdRol As Integer = 0
    Private mUser_agr As String = ""
    Private mFec_agr As Date = Date.Now
    Private mUser_mod As String = ""
    Private mFec_mod As Date = Date.Now
    Private mUltimo_login As Date = Date.Now

    Public Property IdUsuario() As Integer
        Get
            Return mIdUsuario
        End Get
        Set(ByVal Value As Integer)
            mIdUsuario = Value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return mNombre
        End Get
        Set(ByVal Value As String)
            mNombre = Value
        End Set
    End Property

    Public Property Activo() As Integer
        Get
            Return mActivo
        End Get
        Set(ByVal Value As Integer)
            mActivo = Value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return mCodigo
        End Get
        Set(ByVal Value As String)
            mCodigo = Value
        End Set
    End Property

    Public Property Clave() As String
        Get
            Return mClave
        End Get
        Set(ByVal Value As String)
            mClave = Value
        End Set
    End Property

    Public Property IdRol() As Integer
        Get
            Return mIdRol
        End Get
        Set(ByVal Value As Integer)
            mIdRol = Value
        End Set
    End Property

    Public Property User_agr() As String
        Get
            Return mUser_agr
        End Get
        Set(ByVal Value As String)
            mUser_agr = Value
        End Set
    End Property

    Public Property Fec_agr() As Date
        Get
            Return mFec_agr
        End Get
        Set(ByVal Value As Date)
            mFec_agr = Value
        End Set
    End Property

    Public Property User_mod() As String
        Get
            Return mUser_mod
        End Get
        Set(ByVal Value As String)
            mUser_mod = Value
        End Set
    End Property

    Public Property Fec_mod() As Date
        Get
            Return mFec_mod
        End Get
        Set(ByVal Value As Date)
            mFec_mod = Value
        End Set
    End Property

    Public Property Ultimo_login() As Date
        Get
            Return mUltimo_login
        End Get
        Set(ByVal Value As Date)
            mUltimo_login = Value
        End Set
    End Property

    Sub New()
    End Sub

    Sub New(ByRef IdUsuario As Integer, ByVal Nombre As String, ByVal Activo As Integer, ByVal Codigo As String, ByVal Clave As String, ByVal IdRol As Integer)
        mIdUsuario = IdUsuario
        mNombre = Nombre
        mActivo = Activo
        mCodigo = Codigo
        mClave = Clave
        mIdRol = IdRol
    End Sub

    Public Function Clone() As Object Implements System.ICloneable.Clone
        Return MyBase.MemberwiseClone()
    End Function


End Class
