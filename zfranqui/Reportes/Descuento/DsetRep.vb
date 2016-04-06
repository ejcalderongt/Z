Partial Class DsetRep
    Partial Class dtDescuentoResRepGridDataTable

        Private Sub dtDescuentoResRepGridDataTable_dtDescuentoResRepGridRowChanging(sender As Object, e As dtDescuentoResRepGridRowChangeEvent) Handles Me.dtDescuentoResRepGridRowChanging

        End Sub

        Private Sub dtDescuentoResRepGridDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.EsServicioColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Class DTDescuentoDataTable

        Private Sub DTDescuentoDataTable_DTDescuentoRowChanging(sender As Object, e As DTDescuentoRowChangeEvent) Handles Me.DTDescuentoRowChanging

        End Sub

    End Class

End Class
