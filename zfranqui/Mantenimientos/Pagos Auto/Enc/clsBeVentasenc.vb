Public Class clsBeVentasenc
	Implements ICloneable

	Private mIdPeriodoVenta As Integer = 0
	Private mIdCEF As Integer = 0
	Private mIdFranquiciado As Integer = 0
    Private mFechaDesde As Date = Now.Date
    Private mFechaHasta As Date = Now.Date
	Private mMonto As Double = 0.0
	Private mPagado As Double = 0.0
	Private mSaldo As Double = 0.0
    Private mFec_agr As Date = Now.Date
	Private mUser_agr As Integer = 0

	Public Property IdPeriodoVenta() As Integer
		Get
			Return mIdPeriodoVenta
		End Get
		Set(ByVal Value As Integer)
			mIdPeriodoVenta = Value
		End Set
	End Property

    Public Property CodigoCEF As String = ""
    Public Property IdCEF() As Integer
        Get
            Return mIdCEF
        End Get
        Set(ByVal Value As Integer)
            mIdCEF = Value
        End Set
    End Property


    Public Property CodigoFranquiciado As String = ""
	Public Property IdFranquiciado() As Integer
		Get
			Return mIdFranquiciado
		End Get
		Set(ByVal Value As Integer)
			mIdFranquiciado = Value
		End Set
	End Property

    Public Property FechaDesde() As Date
        Get
            Return mFechaDesde
        End Get
        Set(ByVal Value As Date)
            mFechaDesde = Value
        End Set
    End Property

    Public Property FechaHasta() As Date
        Get
            Return mFechaHasta
        End Get
        Set(ByVal Value As Date)
            mFechaHasta = Value
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

	Public Property Pagado() As Double
		Get
			Return mPagado
		End Get
		Set(ByVal Value As Double)
			mPagado = Value
		End Set
	End Property

	Public Property Saldo() As Double
		Get
			Return mSaldo
		End Get
		Set(ByVal Value As Double)
			mSaldo = Value
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

	Sub New(ByRef IdPeriodoVenta As Integer, ByVal IdCEF As Integer, ByVal IdFranquiciado As Integer, ByVal FechaDesde As String, ByVal FechaHasta As String, ByVal Monto As Double, ByVal Pagado As Double, ByVal Saldo As Double, ByVal fec_agr As String, ByVal user_agr As Integer)
		mIdPeriodoVenta = IdPeriodoVenta
		mIdCEF = IdCEF
		mIdFranquiciado = IdFranquiciado
		mFechaDesde = FechaDesde
		mFechaHasta = FechaHasta
		mMonto = Monto
		mPagado = Pagado
		mSaldo = Saldo
		mFec_agr = Fec_agr
		mUser_agr = User_agr
	End Sub

	Public Function Clone() As Object Implements System.ICloneable.Clone
		Return MyBase.MemberwiseClone()
	End Function

End Class
