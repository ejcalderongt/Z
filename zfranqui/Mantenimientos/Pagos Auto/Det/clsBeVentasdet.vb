Public Class clsBeVentasdet
	Implements ICloneable

	Private mIdVenta As Integer = 0
	Private mIdFranquiciado As Integer = 0
	Private mDespes As String = ""
	Private mCilindros As Double = 0.0
	Private mRetencionCliente As Integer = 0
	Private mMonto As Double = 0.0
    Private mFecha As Date = Date.Now
	Private mPagado As Double = 0.0
	Private mSaldo As Double = 0.0
	Private mIdPagoEnc As Integer = 0
	Private mIdPagoDet As Integer = 0
    Private mFec_agr As Date = Date.Now
	Private mUser_agr As Integer = 0

	Public Property IdVenta() As Integer
		Get
			Return mIdVenta
		End Get
		Set(ByVal Value As Integer)
			mIdVenta = Value
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

	Public Property Despes() As String
		Get
			Return mDespes
		End Get
		Set(ByVal Value As String)
			mDespes = Value
		End Set
	End Property

	Public Property Cilindros() As Double
		Get
			Return mCilindros
		End Get
		Set(ByVal Value As Double)
			mCilindros = Value
		End Set
	End Property

	Public Property RetencionCliente() As Integer
		Get
			Return mRetencionCliente
		End Get
		Set(ByVal Value As Integer)
			mRetencionCliente = Value
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

    Public Property Fecha() As Date
        Get
            Return mFecha
        End Get
        Set(ByVal Value As Date)
            mFecha = Value
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

	Public Property IdPagoEnc() As Integer
		Get
			Return mIdPagoEnc
		End Get
		Set(ByVal Value As Integer)
			mIdPagoEnc = Value
		End Set
	End Property

	Public Property IdPagoDet() As Integer
		Get
			Return mIdPagoDet
		End Get
		Set(ByVal Value As Integer)
			mIdPagoDet = Value
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

	Sub New(ByRef IdVenta As Integer, ByVal IdFranquiciado As Integer, ByVal Despes As String, ByVal Cilindros As Double, ByVal RetencionCliente As Integer, ByVal Monto As Double, ByVal Fecha As String, ByVal Pagado As Double, ByVal Saldo As Double, ByVal IdPagoEnc As Integer, ByVal IdPagoDet As Integer, ByVal fec_agr As String, ByVal user_agr As Integer)
		mIdVenta = IdVenta
		mIdFranquiciado = IdFranquiciado
		mDespes = Despes
		mCilindros = Cilindros
		mRetencionCliente = RetencionCliente
		mMonto = Monto
		mFecha = Fecha
		mPagado = Pagado
		mSaldo = Saldo
		mIdPagoEnc = IdPagoEnc
		mIdPagoDet = IdPagoDet
		mFec_agr = Fec_agr
		mUser_agr = User_agr
	End Sub

	Public Function Clone() As Object Implements System.ICloneable.Clone
		Return MyBase.MemberwiseClone()
	End Function

End Class
