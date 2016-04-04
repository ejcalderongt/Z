Public Class clsBeBitacora
	Implements ICloneable

	Private mIdBitacora As Integer = 0
	Private mIdUsuario As Integer = 0
    Private mFecha As Date = Now
	Private mModulo As String = ""
	Private mAccion As String = ""
	Private mId1 As Integer = 0
	Private mId2 As Integer = 0
	Private mId3 As Integer = 0
	Private mId4 As Integer = 0
	Private mObservacion As String = ""

	Public Property IdBitacora() As Integer
		Get
			Return mIdBitacora
		End Get
		Set(ByVal Value As Integer)
			mIdBitacora = Value
		End Set
	End Property

	Public Property IdUsuario() As Integer
		Get
			Return mIdUsuario
		End Get
		Set(ByVal Value As Integer)
			mIdUsuario = Value
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

	Public Property Modulo() As String
		Get
			Return mModulo
		End Get
		Set(ByVal Value As String)
			mModulo = Value
		End Set
	End Property

	Public Property Accion() As String
		Get
			Return mAccion
		End Get
		Set(ByVal Value As String)
			mAccion = Value
		End Set
	End Property

	Public Property Id1() As Integer
		Get
			Return mId1
		End Get
		Set(ByVal Value As Integer)
			mId1 = Value
		End Set
	End Property

	Public Property Id2() As Integer
		Get
			Return mId2
		End Get
		Set(ByVal Value As Integer)
			mId2 = Value
		End Set
	End Property

	Public Property Id3() As Integer
		Get
			Return mId3
		End Get
		Set(ByVal Value As Integer)
			mId3 = Value
		End Set
	End Property

	Public Property Id4() As Integer
		Get
			Return mId4
		End Get
		Set(ByVal Value As Integer)
			mId4 = Value
		End Set
	End Property

	Public Property Observacion() As String
		Get
			Return mObservacion
		End Get
		Set(ByVal Value As String)
			mObservacion = Value
		End Set
	End Property

	Sub New()
	End Sub

	Sub New(ByRef IdBitacora As Integer, ByVal IdUsuario As Integer, ByVal fecha As String, ByVal modulo As String, ByVal accion As String, ByVal Id1 As Integer, ByVal Id2 As Integer, ByVal Id3 As Integer, ByVal Id4 As Integer, ByVal observacion As String)
		mIdBitacora = IdBitacora
		mIdUsuario = IdUsuario
		mFecha = Fecha
		mModulo = Modulo
		mAccion = Accion
		mId1 = Id1
		mId2 = Id2
		mId3 = Id3
		mId4 = Id4
		mObservacion = Observacion
	End Sub

	Public Function Clone() As Object Implements System.ICloneable.Clone
		Return MyBase.MemberwiseClone()
	End Function

End Class
