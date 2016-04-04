Imports System.Collections

Public Class clsInsert

    Private clFList As New ArrayList
    Private clVList As New ArrayList
    Private clTable As String

    Public Sub New()
        clFList.Clear()
        clVList.Clear()
        clTable = ""
    End Sub

    Public Sub Init(ByVal TableName As String)
        clFList.Clear()
        clVList.Clear()
        clTable = TableName
    End Sub

    Public Sub Add(ByVal pField As String, ByVal pValue As Object, ByVal pTipo As String)
        Dim SV As String

        Try

            If (pField = "") Or (pTipo = "") Then Return

            If pTipo = "D" Then SV = FormatoFechas.fFecha(CDate(pValue)) : clFList.Add(pField) : clVList.Add(SV)
            If pTipo = "H" Then SV = FormatoFechas.fFecha(DateTime.Parse(pValue.ToString), True) : clFList.Add(pField) : clVList.Add(SV)
            If pTipo = "S" Then SV = "'" & pValue.ToString & "'" : clFList.Add(pField) : clVList.Add(SV)
            If pTipo = "N" Then SV = Val(pValue).ToString : clFList.Add(pField) : clVList.Add(SV)
            If pTipo = "F" Then SV = pValue.ToString : clFList.Add(pField) : clVList.Add(SV)
            If pTipo = "DT" Then
                If IsDBNull(pValue) Or Trim(pValue.ToString) = "" Then
                    SV = "'01-Jan-1900 00:00:00'"
                Else
                    SV = FormatoFechas.fFechaHora(DateTime.Parse(pValue.ToString)) : clFList.Add(pField) : clVList.Add(SV)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function SQL() As String

        Dim sVal, S, SF, SV As String

        If clTable = "" Then Return ""
        If clFList.Count = 0 Then Return ""

        Try
            SV = "" : SF = ""
            S = "INSERT INTO " + clTable + " ("
            For I = 0 To clFList.Count - 1
                sVal = clFList.Item(I).ToString
                SF = SF + sVal : If I < (clFList.Count - 1) Then SF = SF + ","
                sVal = clVList.Item(I).ToString
                SV = SV + sVal : If I < (clFList.Count - 1) Then SV = SV + ","
            Next

            S = S + SF + ") VALUES (" + SV + ")"
            Return S
        Catch ex As Exception
            Return ""
        End Try
    End Function

End Class
