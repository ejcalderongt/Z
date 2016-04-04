Partial Public Class clsBeDescuento_ref

    Private _MontoTotal As Decimal
    Private _EsVehiculo As Boolean
    Private _EsTelefono As Boolean
    Private _EsServicio As Boolean
    Private _IsNew As Boolean

    Public Property MontoTotal() As Decimal
        Get
            Return _MontoTotal
        End Get
        Set(ByVal value As Decimal)
            _MontoTotal = value
        End Set
    End Property

    Public Property EsVehiculo() As Boolean
        Get
            Return _EsVehiculo
        End Get
        Set(ByVal value As Boolean)
            _EsVehiculo = value
        End Set
    End Property

    Public Property EsTelefono() As Boolean
        Get
            Return _EsTelefono
        End Get
        Set(ByVal value As Boolean)
            _EsTelefono = value
        End Set
    End Property

    Public Property EsServicio() As Boolean
        Get
            Return _EsServicio
        End Get
        Set(ByVal value As Boolean)
            _EsServicio = value
        End Set
    End Property

    Public Property IsNew() As Boolean
        Get
            Return _IsNew
        End Get
        Set(ByVal value As Boolean)
            _IsNew = value
        End Set
    End Property

    Public Sub New()

        _MontoTotal = Nothing
        _EsVehiculo = False
        _EsTelefono = False
        _EsServicio = False
        _IsNew = True

    End Sub

End Class
