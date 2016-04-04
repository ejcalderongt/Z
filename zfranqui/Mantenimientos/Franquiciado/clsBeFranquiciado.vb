Public Class clsBeFranquiciado
	Implements ICloneable

	Private mIdFranquiciado As Integer = 0
	Private mIdBanco As Integer = 0
	Private mCodigo As Integer = 0
	Private mNombres As String = ""
	Private mApellidos As String = ""
	Private mDPI As String = ""
	Private mNoCuenta As String = ""
	Private mDireccion As String = ""
	Private mNIT As String = ""
    Private mFec_agr As DateTime = Date.Now
	Private mFec_mod As Date = Date.Now
	Private mUser_agr As Integer = 0
	Private mUser_mod As Integer = 0
	Private mActivo As Integer = 0

	Public Property IdFranquiciado() As Integer
		Get
			Return mIdFranquiciado
		End Get
		Set(ByVal Value As Integer)
			mIdFranquiciado = Value
		End Set
	End Property

	Public Property IdBanco() As Integer
		Get
			Return mIdBanco
		End Get
		Set(ByVal Value As Integer)
			mIdBanco = Value
		End Set
	End Property

	Public Property Codigo() As Integer
		Get
			Return mCodigo
		End Get
		Set(ByVal Value As Integer)
			mCodigo = Value
		End Set
	End Property

	Public Property Nombres() As String
		Get
			Return mNombres
		End Get
		Set(ByVal Value As String)
			mNombres = Value
		End Set
	End Property

	Public Property Apellidos() As String
		Get
			Return mApellidos
		End Get
		Set(ByVal Value As String)
			mApellidos = Value
		End Set
	End Property

	Public Property DPI() As String
		Get
			Return mDPI
		End Get
		Set(ByVal Value As String)
			mDPI = Value
		End Set
	End Property

	Public Property NoCuenta() As String
		Get
			Return mNoCuenta
		End Get
		Set(ByVal Value As String)
			mNoCuenta = Value
		End Set
	End Property

	Public Property Direccion() As String
		Get
			Return mDireccion
		End Get
		Set(ByVal Value As String)
			mDireccion = Value
		End Set
	End Property

	Public Property NIT() As String
		Get
			Return mNIT
		End Get
		Set(ByVal Value As String)
			mNIT = Value
		End Set
	End Property

    Public Property Fec_agr() As DateTime
        Get
            Return mFec_agr
        End Get
        Set(ByVal Value As DateTime)
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

	Public Property Activo() As Integer
		Get
			Return mActivo
		End Get
		Set(ByVal Value As Integer)
			mActivo = Value
		End Set
    End Property

    Sub New()
    End Sub

	Sub New(ByRef IdFranquiciado As Integer, ByVal IdBanco As Integer, ByVal Codigo As Integer, ByVal Nombres As String, ByVal Apellidos As String, ByVal DPI As String, ByVal NoCuenta As String, ByVal Direccion As String, ByVal NIT As String, ByVal fec_agr As Date, ByVal fec_mod As Date, ByVal user_agr As Integer, ByVal user_mod As Integer, ByVal Activo As Integer)
		mIdFranquiciado = IdFranquiciado
		mIdBanco = IdBanco
		mCodigo = Codigo
		mNombres = Nombres
		mApellidos = Apellidos
		mDPI = DPI
		mNoCuenta = NoCuenta
		mDireccion = Direccion
		mNIT = NIT
		mFec_agr = Fec_agr
		mFec_mod = Fec_mod
		mUser_agr = User_agr
		mUser_mod = User_mod
		mActivo = Activo
	End Sub

	Public Function Clone() As Object Implements System.ICloneable.Clone
		Return MyBase.MemberwiseClone()
	End Function

End Class
