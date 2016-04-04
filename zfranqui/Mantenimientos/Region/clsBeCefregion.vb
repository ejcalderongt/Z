Public Class clsBeCefregion

    Implements ICloneable

    Private mIdRegion As Integer = 0
    Private mNombre As String = ""
    Private mFec_agr As Date = Date.Now
    Private mFec_mod As Date = Date.Now
    Private mUser_agr As Integer = 0
    Private mUser_mod As Integer = 0

    Public Property IdRegion() As Integer
        Get
            Return mIdRegion
        End Get
        Set(ByVal Value As Integer)
            mIdRegion = Value
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

    Public Property Fec_agr() As Date
        Get
            Return mFec_agr
        End Get
        Set(ByVal Value As Date)
            mFec_agr = Value
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

    Public Property User_agr() As Integer
        Get
            Return mUser_agr
        End Get
        Set(ByVal Value As Integer)
            mUser_agr = Value
        End Set
    End Property

    Public Property User_mod() As Integer
        Get
            Return mUser_mod
        End Get
        Set(ByVal Value As Integer)
            mUser_mod = Value
        End Set
    End Property

    Sub New()
    End Sub

    Sub New(ByRef IdRegion As Integer, ByVal Nombre As String, ByVal fec_agr As Date, ByVal fec_mod As Date, ByVal user_agr As Integer, ByVal user_mod As Integer)
        mIdRegion = IdRegion
        mNombre = Nombre
        mFec_agr = fec_agr
        mFec_mod = fec_mod
        mUser_agr = user_agr
        mUser_mod = user_mod
    End Sub

    Public Function Clone() As Object Implements System.ICloneable.Clone
        Return MyBase.MemberwiseClone()
    End Function

End Class
