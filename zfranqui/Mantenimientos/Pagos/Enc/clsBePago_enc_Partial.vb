Partial Public Class clsBePago_enc

    Private _isnew As Boolean

    Public Property IsNew() As Boolean
        Get
            Return _isnew
        End Get
        Set(value As Boolean)
            _isnew = value
        End Set
    End Property

End Class
