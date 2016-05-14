Partial Public Class clsBEBeneficio

    Public Property FranquiciadoAsignado As clsBeFranquiciado
    Public Property TipoBeneficio As clsBeTipobeneficio

    Private _isnew As Boolean
    Public Property IsNew() As Boolean
        Get
            Return _isnew
        End Get
        Set(value As Boolean)
            _isnew = value
        End Set
    End Property

    Public _asignado As Boolean
    Public Property Asignado As Boolean
        Get
            Return _asignado
        End Get
        Set(value As Boolean)
            _asignado = value
        End Set
    End Property

End Class
