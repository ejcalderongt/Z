Partial Public Class clsBeDescuento_det

    Private mIsNew As Boolean = False

    Public Property IsNew() As Boolean
        Get
            Return mIsNew
        End Get
        Set(ByVal Value As Boolean)
            mIsNew = Value
        End Set
    End Property

End Class
