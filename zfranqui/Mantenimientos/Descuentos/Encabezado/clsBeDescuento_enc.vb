Public Class clsBeDescuento_enc
	Implements ICloneable

	Private mIdDescuentoEnc As Integer = 0
	Private mIdCEF As Integer = 0
    Private mIdTipoDescuento As Integer = 0
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

    Public Property CEF As New clsBeCef

    'Public Property IdCEF() As Integer
    '	Get
    '		Return mIdCEF
    '	End Get
    '	Set(ByVal Value As Integer)
    '		mIdCEF = Value
    '	End Set
    'End Property


	Public Property IdTipoDescuento() As Integer
		Get
			Return mIdTipoDescuento
		End Get
		Set(ByVal Value As Integer)
			mIdTipoDescuento = Value
		End Set
    End Property

    Public Property NomTipoDescuento As String


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

    Public Property NomUsuarioAgrego As String = ""
    Public Property NomUsuarioModifico As String = ""
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

	Sub New(ByRef IdDescuentoEnc As Integer, ByVal IdCEF As Integer, ByVal IdFranquiciado As Integer, ByVal IdTipoDescuento As Integer, ByVal fec_agr As Date, ByVal fec_mod As Date, ByVal user_agr As Integer, ByVal user_mod As Integer)
		mIdDescuentoEnc = IdDescuentoEnc
		mIdCEF = IdCEF		
		mIdTipoDescuento = IdTipoDescuento
		mFec_agr = Fec_agr
		mFec_mod = Fec_mod
		mUser_agr = User_agr
		mUser_mod = User_mod
	End Sub

	Public Function Clone() As Object Implements System.ICloneable.Clone
		Return MyBase.MemberwiseClone()
	End Function

End Class
