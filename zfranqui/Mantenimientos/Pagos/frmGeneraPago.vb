Imports DevExpress.XtraEditors

Public Class frmGeneraPago

    Public pIndex As Integer
    Public pIdDescuentoEnc As Integer
    Public pIdDescuentoDet As Integer
    Public pListObjEnc As List(Of clsBePago_enc)
    Public pListObjDet As List(Of clsBePago_det)

    Private Sub cmdCancelar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCancelar.ItemClick
        End
    End Sub

    Private Sub CargaBeneficios()

        Try



        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class