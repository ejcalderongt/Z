Public Class clsBeTipobeneficio
	Implements ICloneable

	Private mIdTipoBeneficio As Integer = 0
	Private mNombre As String = ""
	Private mFecha_agregado As Date = Date.Now
	Private mFecha_modificado As Date = Date.Now
	Private mIdUsuarioAgrego As Integer = 0
	Private mIdUsuarioModifico As Integer = 0
	Private mEsVehiculo As Boolean = False
    Private mEsTelefono As Boolean = False
    Private mEsServicio As Boolean = False

	Public Property IdTipoBeneficio() As Integer
		Get
			Return mIdTipoBeneficio
		End Get
		Set(ByVal Value As Integer)
			mIdTipoBeneficio = Value
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

	Public Property Fecha_agregado() As Date
		Get
			Return mFecha_agregado
		End Get
		Set(ByVal Value As Date)
			mFecha_agregado = Value
		End Set
	End Property

	Public Property Fecha_modificado() As Date
		Get
			Return mFecha_modificado
		End Get
		Set(ByVal Value As Date)
			mFecha_modificado = Value
		End Set
	End Property

	Public Property IdUsuarioAgrego() As Integer
		Get
			Return mIdUsuarioAgrego
		End Get
		Set(ByVal Value As Integer)
			mIdUsuarioAgrego = Value
		End Set
	End Property

	Public Property IdUsuarioModifico() As Integer
		Get
			Return mIdUsuarioModifico
		End Get
		Set(ByVal Value As Integer)
			mIdUsuarioModifico = Value
		End Set
	End Property

	Public Property EsVehiculo() As Boolean
		Get
			Return mEsVehiculo
		End Get
		Set(ByVal Value As Boolean)
			mEsVehiculo = Value
		End Set
	End Property

	Public Property EsTelefono() As Boolean
		Get
			Return mEsTelefono
		End Get
		Set(ByVal Value As Boolean)
			mEsTelefono = Value
		End Set
	End Property

    Public Property EsServicio() As Boolean
        Get
            Return mEsServicio
        End Get
        Set(ByVal Value As Boolean)
            mEsServicio = Value
        End Set
    End Property

	Sub New()
	End Sub

	Sub New(ByRef IdTipoBeneficio As Integer, ByVal Nombre As String, ByVal fecha_agregado As Date, ByVal fecha_modificado As Date, ByVal IdUsuarioAgrego As Integer, ByVal IdUsuarioModifico As Integer, ByVal EsVehiculo As Boolean, ByVal EsTelefono As Boolean)
		mIdTipoBeneficio = IdTipoBeneficio
		mNombre = Nombre
		mFecha_agregado = Fecha_agregado
		mFecha_modificado = Fecha_modificado
		mIdUsuarioAgrego = IdUsuarioAgrego
		mIdUsuarioModifico = IdUsuarioModifico
		mEsVehiculo = EsVehiculo
		mEsTelefono = EsTelefono
	End Sub

	Public Function Clone() As Object Implements System.ICloneable.Clone
		Return MyBase.MemberwiseClone()
	End Function

End Class
