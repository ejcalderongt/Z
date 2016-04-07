Public Class clsBePago_enc
	Implements ICloneable

	Private mIdPagoEnc As Integer = 0
    Private mIdCEF As Integer = 0
    Private mIdFranquiciado As Integer = 0
    Private mNoDeposito As String = ""
    Private mFechaPago As Date = Date.Now
    Private mFec_agr As Date = Date.Now
    Private mFec_mod As Date = Date.Now
    Private mUser_agr As Integer = 0
    Private mUser_mod As Integer = 0
    Private mAnulado As Boolean = False

    Public Property IdPagoEnc() As Integer
        Get
            Return mIdPagoEnc
        End Get
        Set(ByVal Value As Integer)
            mIdPagoEnc = Value
        End Set
    End Property

    Public Property IdCEF() As Integer
        Get
            Return mIdCEF
        End Get
        Set(ByVal Value As Integer)
            mIdCEF = Value
        End Set
    End Property

    Public Property CEF() As New clsBeCef
    Public Property Franquiciado() As New clsBeFranquiciado

    Public Property IdFranquiciado() As Integer
        Get
            Return mIdFranquiciado
        End Get
        Set(ByVal Value As Integer)
            mIdFranquiciado = Value
        End Set
    End Property

    Public Property NoDeposito() As String
        Get
            Return mNoDeposito
        End Get
        Set(ByVal Value As String)
            mNoDeposito = Value
        End Set
    End Property

    Public Property FechaPago() As Date
        Get
            Return mFechaPago
        End Get
        Set(ByVal Value As Date)
            mFechaPago = Value
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

    Public Property Anulado() As Boolean
        Get
            Return mAnulado
        End Get
        Set(ByVal Value As Boolean)
            mAnulado = Value
        End Set
    End Property

    Sub New()
    End Sub

    Sub New(ByRef IdPagoEnc As Integer, ByVal IdCEF As Integer, ByVal IdFranquiciado As Integer, ByVal NoDeposito As String, ByVal FechaPago As Date, ByVal Fec_agr As Date, ByVal Fec_mod As Date, ByVal User_agr As Integer, ByVal User_mod As Integer, ByVal Anulado As Boolean)
        mIdPagoEnc = IdPagoEnc
        mIdCEF = IdCEF
        mIdFranquiciado = IdFranquiciado
        mNoDeposito = NoDeposito
        mFechaPago = FechaPago
        mFec_agr = Fec_agr
        mFec_mod = Fec_mod
        mUser_agr = User_agr
        mUser_mod = User_mod
        mAnulado = Anulado
    End Sub

	Public Function Clone() As Object Implements System.ICloneable.Clone
		Return MyBase.MemberwiseClone()
	End Function

End Class
