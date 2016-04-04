Public Class clsBeDescuento_ref
	Implements ICloneable

	Private mIdDescuentoEnc As Integer = 0
	Private mIdDescuentoDet As Integer = 0
	Private mIdDescuentoRef As Integer = 0
    Private mIdBeneficio As Integer = 0
	Private mNoCuota As Integer = 0
	Private mMonto As Double = 0.0
	Private mAbonado As Double = 0.0
	Private mFechaCobro As Date = Date.Now
	Private mPagada As Boolean = False
	Private mFec_agr As Date = Date.Now
	Private mFec_mod As Date = Date.Now
	Private mUser_agr As Integer = 0
	Private mUser_mod As Integer = 0

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

    Private mBeneficio As clsBeBeneficio

    Public Property Beneficio As clsBeBeneficio
        Get
            Return mBeneficio
        End Get
        Set(value As clsBeBeneficio)
            mBeneficio = value
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

	Public Property Monto() As Double
		Get
			Return mMonto
		End Get
		Set(ByVal Value As Double)
			mMonto = Value
		End Set
	End Property

	Public Property Abonado() As Double
		Get
			Return mAbonado
		End Get
		Set(ByVal Value As Double)
			mAbonado = Value
		End Set
	End Property

	Public Property FechaCobro() As Date
		Get
			Return mFechaCobro
		End Get
		Set(ByVal Value As Date)
			mFechaCobro = Value
		End Set
	End Property

	Public Property Pagada() As Boolean
		Get
			Return mPagada
		End Get
		Set(ByVal Value As Boolean)
			mPagada = Value
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

    Public Property Anulada As Boolean = False
    Sub New(ByRef IdDescuentoEnc As Integer, ByVal IdDescuentoDet As Integer, ByVal IdDescuentoRef As Integer, ByVal IdBeneficio As Integer, ByVal NoCuota As Integer, ByVal Monto As Double, ByVal Abonado As Double, ByVal FechaCobro As Date, ByVal Pagada As Boolean, ByVal fec_agr As Date, ByVal fec_mod As Date, ByVal user_agr As Integer, ByVal user_mod As Integer)
        mIdDescuentoEnc = IdDescuentoEnc
        mIdDescuentoDet = IdDescuentoDet
        mIdDescuentoRef = IdDescuentoRef
        mIdBeneficio = IdBeneficio
        mNoCuota = NoCuota
        mMonto = Monto
        mAbonado = Abonado
        mFechaCobro = FechaCobro
        mPagada = Pagada
        mFec_agr = fec_agr
        mFec_mod = fec_mod
        mUser_agr = user_agr
        mUser_mod = user_mod
    End Sub

	Public Function Clone() As Object Implements System.ICloneable.Clone
		Return MyBase.MemberwiseClone()
	End Function

End Class
