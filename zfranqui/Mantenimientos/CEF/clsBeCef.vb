Public Class clsBeCef
	Implements ICloneable

	Private mIdCef As Integer = 0
	Private mIdSupervisor As Integer = 0
	Private mIdRegion As Integer = 0
	Private mIdMunicipio As Integer = 0
	Private mIdDepartamento As Integer = 0
	Private mEncargado As String = ""
	Private mCodigo As String = ""
	Private mDescripcion As String = ""
	Private mCelular As String = ""
	Private mTelefono As String = ""
	Private mObservaciones As String = ""
	Private mFec_agr As Date = Date.Now
	Private mFec_mod As Date = Date.Now
	Private mUser_agr As Integer = 0
	Private mUser_mod As Integer = 0

	Public Property IdCef() As Integer
		Get
			Return mIdCef
		End Get
		Set(ByVal Value As Integer)
			mIdCef = Value
		End Set
	End Property

    'Public Property IdSupervisor() As Integer
    '	Get
    '		Return mIdSupervisor
    '	End Get
    '	Set(ByVal Value As Integer)
    '		mIdSupervisor = Value
    '	End Set
    'End Property

    'Public Property IdRegion() As Integer
    '	Get
    '		Return mIdRegion
    '	End Get
    '	Set(ByVal Value As Integer)
    '		mIdRegion = Value
    '	End Set
    'End Property

    'Public Property IdMunicipio() As Integer
    '	Get
    '		Return mIdMunicipio
    '	End Get
    '	Set(ByVal Value As Integer)
    '		mIdMunicipio = Value
    '	End Set
    'End Property

    'Public Property IdDepartamento() As Integer
    '	Get
    '		Return mIdDepartamento
    '	End Get
    '	Set(ByVal Value As Integer)
    '		mIdDepartamento = Value
    '	End Set
    'End Property

	Public Property Encargado() As String
		Get
			Return mEncargado
		End Get
		Set(ByVal Value As String)
			mEncargado = Value
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

	Public Property Descripcion() As String
		Get
			Return mDescripcion
		End Get
		Set(ByVal Value As String)
			mDescripcion = Value
		End Set
	End Property

	Public Property Celular() As String
		Get
			Return mCelular
		End Get
		Set(ByVal Value As String)
			mCelular = Value
		End Set
	End Property

	Public Property Telefono() As String
		Get
			Return mTelefono
		End Get
		Set(ByVal Value As String)
			mTelefono = Value
		End Set
	End Property

	Public Property Observaciones() As String
		Get
			Return mObservaciones
		End Get
		Set(ByVal Value As String)
			mObservaciones = Value
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

	Sub New(ByRef IdCef As Integer, ByVal IdSupervisor As Integer, ByVal IdRegion As Integer, ByVal IdMunicipio As Integer, ByVal IdDepartamento As Integer, ByVal Encargado As String, ByVal Codigo As String, ByVal Descripcion As String, ByVal Celular As String, ByVal Telefono As String, ByVal Observaciones As String, ByVal fec_agr As Date, ByVal fec_mod As Date, ByVal user_agr As Integer, ByVal user_mod As Integer)
		mIdCef = IdCef
		mIdSupervisor = IdSupervisor
		mIdRegion = IdRegion
		mIdMunicipio = IdMunicipio
		mIdDepartamento = IdDepartamento
		mEncargado = Encargado
		mCodigo = Codigo
		mDescripcion = Descripcion
		mCelular = Celular
		mTelefono = Telefono
		mObservaciones = Observaciones
		mFec_agr = Fec_agr
		mFec_mod = Fec_mod
		mUser_agr = User_agr
		mUser_mod = User_mod
	End Sub

	Public Function Clone() As Object Implements System.ICloneable.Clone
		Return MyBase.MemberwiseClone()
	End Function

End Class
