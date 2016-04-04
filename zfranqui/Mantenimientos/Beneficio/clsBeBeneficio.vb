Public Class clsBeBeneficio
	Implements ICloneable

	Private mIdBeneficio As Integer = 0
	Private mIdTipoBeneficio As Integer = 0
	Private mNombre As String = ""
	Private mModelo As String = ""
	Private mNoChasis As String = ""
	Private mNoPlaca As String = ""
	Private mMotor As String = ""
	Private mNumeroTelefono As String = ""
	Private mEmpresaTelco As String = ""
	Private mFecha_asignacion As Date = Date.Now
	Private mActivo As Integer = 0
	Private mUser_mod As Integer = 0
	Private mFec_agr As Date = Date.Now
	Private mFec_mod As Date = Date.Now
	Private mUser_agr As Integer = 0

	Public Property IdBeneficio() As Integer
		Get
			Return mIdBeneficio
		End Get
		Set(ByVal Value As Integer)
			mIdBeneficio = Value
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

	Public Property Modelo() As String
		Get
			Return mModelo
		End Get
		Set(ByVal Value As String)
			mModelo = Value
		End Set
	End Property

	Public Property NoChasis() As String
		Get
			Return mNoChasis
		End Get
		Set(ByVal Value As String)
			mNoChasis = Value
		End Set
	End Property

	Public Property NoPlaca() As String
		Get
			Return mNoPlaca
		End Get
		Set(ByVal Value As String)
			mNoPlaca = Value
		End Set
	End Property

	Public Property Motor() As String
		Get
			Return mMotor
		End Get
		Set(ByVal Value As String)
			mMotor = Value
		End Set
	End Property

	Public Property NumeroTelefono() As String
		Get
			Return mNumeroTelefono
		End Get
		Set(ByVal Value As String)
			mNumeroTelefono = Value
		End Set
	End Property

	Public Property EmpresaTelco() As String
		Get
			Return mEmpresaTelco
		End Get
		Set(ByVal Value As String)
			mEmpresaTelco = Value
		End Set
	End Property

	Public Property Fecha_asignacion() As Date
		Get
			Return mFecha_asignacion
		End Get
		Set(ByVal Value As Date)
			mFecha_asignacion = Value
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

	Public Property User_mod() As Integer
		Get
			Return mUser_mod
		End Get
		Set(ByVal Value As Integer)
			mUser_mod = Value
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

	Sub New()
	End Sub

	Sub New(ByRef IdBeneficio As Integer, ByVal IdTipoBeneficio As Integer, ByVal Nombre As String, ByVal Modelo As String, ByVal NoChasis As String, ByVal NoPlaca As String, ByVal Motor As String, ByVal NumeroTelefono As String, ByVal EmpresaTelco As String, ByVal fecha_asignacion As Date, ByVal Activo As Integer, ByVal user_mod As Integer, ByVal fec_agr As Date, ByVal fec_mod As Date, ByVal user_agr As Integer)
		mIdBeneficio = IdBeneficio
		mIdTipoBeneficio = IdTipoBeneficio
		mNombre = Nombre
		mModelo = Modelo
		mNoChasis = NoChasis
		mNoPlaca = NoPlaca
		mMotor = Motor
		mNumeroTelefono = NumeroTelefono
		mEmpresaTelco = EmpresaTelco
		mFecha_asignacion = Fecha_asignacion
		mActivo = Activo
		mUser_mod = User_mod
		mFec_agr = Fec_agr
		mFec_mod = Fec_mod
		mUser_agr = User_agr
	End Sub

	Public Function Clone() As Object Implements System.ICloneable.Clone
		Return MyBase.MemberwiseClone()
	End Function

End Class
