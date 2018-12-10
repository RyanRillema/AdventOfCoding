Public Class GaurdLine
    Public iDate As DateTime
    Public iGaurdId As Integer
    Public sState As String

    Public Sub New(sLine As String)
        Dim sDate As String

        sDate = sLine.Substring(1, sLine.IndexOf("]") - 1)
        iDate = sDate
        If sLine.IndexOf("#") > 0 Then
            iGaurdId = sLine.Substring(sLine.IndexOf("#") + 1, sLine.IndexOf("b") - sLine.IndexOf("#") - 1)
        ElseIf sLine.Contains("wakes up") <> 0 Then
            sState = "wakes up"
        Else
            sState = "falls asleep"
        End If

    End Sub

End Class
