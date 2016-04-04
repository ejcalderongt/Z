Public Class clsBePago_det
	Implements ICloneable

	Private mIdPagoDet As Integer = 0
	Private mIdPagoEnc As Integer = 0
	Private mIdDescuentoEnc As Integer = 0
	Private mIdDescuentoDet As Integer = 0
	Private mIdDescuentoRef As Integer = 0
	Private mIdBeneficio As Integer = 0
	Private mNoCuota As Integer = 0
	Private mMontoCuota As Double = 0.0
	Private mMontoAbono As Double = 0.0
	Private mFec_agr As Date = Date.Now
	Private mFec_mod As Date = Date.Now
	Private mUser_agr As Integer = 0
	Private mUser_mod As Integer = 0

	Public Property IdPagoDet() As Integer
		Get
			Return mIdPagoDet
		End Get
		Set(ByVal Value As Integer)
			mIdPagoDet = Value
		End Set
	End Property

	Public Property IdPagoEnc() As Integer
		Get
			Return mIdPagoEnc
		End Get
		Set(ByVal Value As Integer)
			mIdPagoEnc = Value
		End Set
	End Property

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

	Public Property IdDescuentoRef() As Integer
		Get
			Return mIdDescuentoRef
		End Get
		Set(ByVal Value As Integer)
			mIdDescuentoRef = Value
		End Set
	End Property

	Public Property IdBeneficio() As Integer
		Get
			Return mIdBeneficio
		End Get
		Set(ByVal Value As Integer)
			mIdBeneficio = Value
		End Set
	End Property

	Public Property NoCuota() As Integer
		Get
			Return mNoCuota
		End Get
		Set(ByVal Value As Integer)
			mNoCuota = Value
		End Set
	End Property

	Public Property MontoCuota() As Double
		Get
			Return mMontoCuota
		End Get
		Set(ByVal Value As Double)
			mMontoCuota = Value
		End Set
	End Property

	Public Property MontoAbono() As Double
		Get
			Return mMontoAbono
		End Get
		Set(ByVal Value As Double)
			mMontoAbono = Value
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

	Sub New(ByRef IdPagoDet As Integer, ByVal IdPagoEnc As Integer, ByVal IdDescuentoEnc As Integer, ByVal IdDescuentoDet As Integer, ByVal IdDescuentoRef As Integer, ByVal IdBeneficio As Integer, ByVal NoCuota As Integer, ByVal MontoCuota As Double, ByVal MontoAbono As Double, ByVal fec_agr As Date, ByVal fec_mod As Date, ByVal user_agr As Integer, ByVal user_mod As Integer)
		mIdPagoDet = IdPagoDet
		mIdPagoEnc = IdPagoEnc
		mIdDescuentoEnc = IdDescuentoEnc
		mIdDescuentoDet = IdDescuentoDet
		mIdDescuentoRef = IdDescuentoRef
		mIdBeneficio = IdBeneficio
		mNoCuota = NoCuota
		mMontoCuota = MontoCuota
		mMontoAbono = MontoAbono
		mFec_agr = Fec_agr
		mFec_mod = Fec_mod
		mUser_agr = User_agr
		mUser_mod = User_mod
	End Sub

	Public Function Clone() As Object Implements System.ICloneable.Clone
		Return MyBase.MemberwiseClone()
	End Function

End Class
