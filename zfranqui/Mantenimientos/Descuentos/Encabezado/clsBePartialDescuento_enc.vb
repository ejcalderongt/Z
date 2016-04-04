Partial Public Class clsBeDescuento_enc

    Public Detalle As New List(Of clsBeDescuento_det)
    Public Referencia As New List(Of clsBeDescuento_ref)

    Public Property Franquiciado As New clsBeFranquiciado

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
