Public Class clsBeCefsupervisor
	Implements ICloneable

	Private mIdSupervisor As Integer = 0
	Private mCodigo As String = ""
	Private mNombre As String = ""
	Private mFec_agr As Date = Date.Now
	Private mFec_mod As Date = Date.Now
	Private mUser_agr As Integer = 0
	Private mUser_mod As Integer = 0

	Public Property IdSupervisor() As Integer
		Get
			Return mIdSupervisor
		End Get
		Set(ByVal Value As Integer)
			mIdSupervisor = Value
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

	Sub New(ByRef IdSupervisor As Integer, ByVal Codigo As String, ByVal Nombre As String, ByVal fec_agr As Date, ByVal fec_mod As Date, ByVal user_agr As Integer, ByVal user_mod As Integer)
		mIdSupervisor = IdSupervisor
		mCodigo = Codigo
		mNombre = Nombre
		mFec_agr = Fec_agr
		mFec_mod = Fec_mod
		mUser_agr = User_agr
		mUser_mod = User_mod
	End Sub

	Public Function Clone() As Object Implements System.ICloneable.Clone
		Return MyBase.MemberwiseClone()
	End Function

End Class
