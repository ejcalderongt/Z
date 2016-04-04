Public Class clsBeFranquiciadocef
	Implements ICloneable

	Private mIdAsignacionFranquiciado As Integer = 0
	Private mIdCEF As Integer = 0
	Private mIdFranquiciado As Integer = 0
    Private mFec_agr As DateTime = Date.Now
	Private mFec_mod As Date = Date.Now
	Private mUser_agr As Integer = 0
	Private mUser_mod As Integer = 0
	Private mActivo As Boolean = False

	Public Property IdAsignacionFranquiciado() As Integer
		Get
			Return mIdAsignacionFranquiciado
		End Get
		Set(ByVal Value As Integer)
			mIdAsignacionFranquiciado = Value
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

	Public Property IdFranquiciado() As Integer
		Get
			Return mIdFranquiciado
		End Get
		Set(ByVal Value As Integer)
			mIdFranquiciado = Value
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

	Public Property Activo() As Boolean
		Get
			Return mActivo
		End Get
		Set(ByVal Value As Boolean)
			mActivo = Value
		End Set
	End Property

	Sub New()
	End Sub

	Sub New(ByRef IdAsignacionFranquiciado As Integer, ByVal IdCEF As Integer, ByVal IdFranquiciado As Integer, ByVal fec_agr As Date, ByVal fec_mod As Date, ByVal user_agr As Integer, ByVal user_mod As Integer, ByVal activo As Boolean)
		mIdAsignacionFranquiciado = IdAsignacionFranquiciado
		mIdCEF = IdCEF
		mIdFranquiciado = IdFranquiciado
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
