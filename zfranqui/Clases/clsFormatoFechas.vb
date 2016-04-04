Public Class FormatoFechas

    Public Shared Function fFecha(ByVal pFecha As Date, Optional ByVal Con_Hora As Boolean = False) As String
        Try
            fFecha = ""
            If IsDate(pFecha) Then
                If Con_Hora Then
                    Dim Hora As String = CStr(pFecha.Hour) & ":" & Strings.Right("00" & pFecha.Minute, 2) & ":" & Strings.Right("00" & pFecha.Second, 2)
                    fFecha = "'" + CStr(pFecha.Year) & Strings.Right("00" & pFecha.Month, 2) & Strings.Right("00" & pFecha.Day, 2) & " " & Hora & "'"
                Else
                    fFecha = "'" + CStr(pFecha.Year) & Strings.Right("00" & pFecha.Month, 2) & Strings.Right("00" & pFecha.Day, 2) + "'"
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Shared Function tFecha(ByVal pFecha As Date) As String
        tFecha = ""
        Try
            If IsDate(pFecha) Then
                tFecha = CStr(pFecha.Year) & Strings.Right("00" & pFecha.Month, 2) & Strings.Right("00" & pFecha.Day, 2)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Shared Function sFecha(ByVal pFecha As Date) As String
        Try
            sFecha = ""
            If IsDate(pFecha) Then
                sFecha = Strings.Right("00" & pFecha.Day, 2) & "/" & Strings.Right("00" & pFecha.Month, 2) & "/" & CStr(pFecha.Year)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Shared Function sHora(ByVal pFecha As Date) As String
        Try
            sHora = ""
            If IsDate(pFecha) Then
                sHora = Strings.Right("00" & pFecha.Hour, 2) & ":" & Strings.Right("00" & pFecha.Minute, 2) & ":" & CStr(pFecha.Second)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Shared Function fFechaHora(ByVal pFecha As Date) As String
        fFechaHora = "'01-Jan-1900 00:00:00'"
        If IsDate(pFecha) Then
            fFechaHora = "'" + CStr(pFecha.Year) & Strings.Right("00" & pFecha.Month, 2) & Strings.Right("00" & pFecha.Day, 2) + " "
            fFechaHora = fFechaHora + CStr(pFecha.Hour) + ":" + CStr(pFecha.Minute) + ":" + CStr(pFecha.Second) + "'"
        End If
    End Function

End Class
