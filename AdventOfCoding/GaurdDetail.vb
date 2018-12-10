Public Class GaurdDetail
    Public iGaurdId As Integer
    Public sSleep(1000) As DateTime
    Public sWake(1000) As DateTime
    Public iTime(1000) As TimeSpan
    Public iTotalTime As TimeSpan

    Public icount As Integer

    Public Sub New(iSetId)
        iGaurdId = iSetId
    End Sub

    Public Sub addSleep(sTime As DateTime)
        sSleep(icount) = sTime
    End Sub

    Public Sub addWake(sTime As DateTime)
        sWake(icount) = sTime
        addTime()
        icount = icount + 1
    End Sub

    Private Sub addTime()
        iTime(icount) = sWake(icount) - sSleep(icount)
    End Sub

    Public Sub getTotals()
        Dim iLoop As Integer

        For iLoop = 0 To icount - 1
            iTotalTime = iTotalTime + iTime(iLoop)
        Next

    End Sub

End Class
