Partial Public Class clsBePago_det

    Private _isnew As Boolean

    Public Property IsNew() As Boolean
        Get
            Return _isnew
        End Get
        Set(value As Boolean)
            _isnew = value
        End Set
    End Property

    Public Property Beneficio As New clsBeBeneficio

    Public Property DescuentosRef As New clsBeDescuento_ref

    Public Property PagoAutomatico As Integer = 0

    Public Property IdVentaDet As Integer = 0

End Class
