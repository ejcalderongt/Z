Module m_Global

    Public vSQL As String = ""
    Public BD As New BaseDatos
    Public Ins As New clsInsert
    Public Upd As New clsUpdate
    Public gUsuario As New clsBeUsuario
    Public gdUsuario As New clsLnUsuario

    Public Bita As New clsBeBitacora
    Public nB As New clsLnBitacora

    Public HostName As String = ""
    Public Sub EsNumerico(ByRef Texto As Object)
        If Texto.Text <> "" And Not IsNumeric(Texto.Text) Then
            Texto.Text = ""
            MsgBox("Ingrese un dato numérico!", MsgBoxStyle.Exclamation)
            Texto.Focus()
        End If
    End Sub

End Module
