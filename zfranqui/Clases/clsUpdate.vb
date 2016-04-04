Imports System.Collections

Public Class clsUpdate

    Private clFList As New ArrayList
    Private clTable As String
    Private vWhere$

    Public Sub New()
        clFList.Clear()
        clTable = ""
    End Sub

    Public Sub Init(ByVal TableName As String)
        clFList.Clear()
        clTable = " UPDATE " & TableName & " SET "
    End Sub

    Public Sub Add(ByVal pField As String, ByVal pValue As Object, ByVal pTipo As String)
        Dim SV As String

        Try

            If (pField = "") Or (pTipo = "") Then Return

            If pTipo = "D" Then SV = FormatoFechas.fFecha(CDate(pValue)) : clFList.Add(pField & " = " & SV)
            If pTipo = "H" Then SV = FormatoFechas.fFecha(DateTime.Parse(pValue.ToString), True) : clFList.Add(pField & " = " & SV)
            If pTipo = "S" Then SV = "'" + pValue.ToString + "'" : clFList.Add(pField & " = " & SV)
            If pTipo = "N" Then SV = Val(pValue).ToString : clFList.Add(pField & " = " & SV)
            If pTipo = "F" Then SV = pValue.ToString : clFList.Add(pField & " = " & SV)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Where(ByVal pWhere$)
        vWhere$ = " WHERE " & pWhere$
    End Sub

    Public Function SQL() As String

        Dim vUpDate$

        If clTable = "" Then Return ""
        If clFList.Count = 0 Then Return ""

        Try
            vUpDate$ = clTable
            For I = 0 To clFList.Count - 1
                vUpDate$ = vUpDate$ & IIf(I < (clFList.Count - 1), (clFList(I).ToString & ","), clFList(I)).ToString
            Next
            vUpDate$ = vUpDate$ & vWhere$
            Return vUpDate$

        Catch ex As Exception
            Return ""
        End Try

    End Function

End Class
