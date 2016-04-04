Public Class clsBeDescuento_det
	Implements ICloneable

	Private mIdDescuentoEnc As Integer = 0
	Private mIdDescuentoDet As Integer = 0
	Private mIdBeneficio As Integer = 0
	Private mIdPeriodoDescuento As Integer = 0
    Private mMontoTotal As Double = 0.0
    Private mCuotas As Integer = 0
	Private mFec_agr As Date = Date.Now
	Private mFec_mod As Date = Date.Now
	Private mUser_agr As Integer = 0
	Private mUser_mod As Integer = 0
    Private mFechaAPartirDe As Date = Now

	Public Property IdDescuentoEnc() As Integer
		Get
			Return mIdDescuentoEnc
		End Get
		Set(ByVal Value As Integer)
			mIdDescuentoEnc = Value
		End Set
	End Property

	Public Property IdDescuentoDet() As Integer
		Get
			Return mIdDescuentoDet
		End Get
		Set(ByVal Value As Integer)
			mIdDescuentoDet = Value
		End Set
	End Property

    Public Property Beneficio As New clsBeBeneficio

    Public Property PeriodoDescuento As New clsBePeriodo_descuento

    Public Property MontoTotal() As Double
        Get
            Return mMontoTotal
        End Get
        Set(ByVal Value As Double)
            mMontoTotal = Value
        End Set
    End Property

    Public Property Cuotas() As Integer
        Get
            Return mCuotas
        End Get
        Set(ByVal Value As Integer)
            mCuotas = Value
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

    Public Property FechaAPartirDe As Date
        Get
            Return mFechaAPartirDe
        End Get
        Set(value As Date)
            mFechaAPartirDe = value
        End Set
    End Property

    Public Property Activo As Boolean = False

	Sub New()
	End Sub

    Sub New(ByRef IdDescuentoEnc As Integer, ByVal IdDescuentoDet As Integer, ByVal IdBeneficio As Integer, ByVal IdPeriodoDescuento As Integer, ByVal MontoTotal As Double, ByVal Cuotas As Integer, ByVal fec_agr As Date, ByVal fec_mod As Date, ByVal user_agr As Integer, ByVal user_mod As Integer)
        mIdDescuentoEnc = IdDescuentoEnc
        mIdDescuentoDet = IdDescuentoDet
        mIdBeneficio = IdBeneficio
        mIdPeriodoDescuento = IdPeriodoDescuento
        mMontoTotal = MontoTotal
        mCuotas = Cuotas
        mFec_agr = fec_agr
        mFec_mod = fec_mod
        mUser_agr = user_agr
        mUser_mod = user_mod
    End Sub

	Public Function Clone() As Object Implements System.ICloneable.Clone
		Return MyBase.MemberwiseClone()
	End Function

End Class
