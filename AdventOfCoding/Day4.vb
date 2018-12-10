Public Class Day4
    Public oGaurdLines(100000) As GaurdLine
    Public oGaurdDetail(1000) As GaurdDetail
    Public iLineCount As Integer
    Public iGaurdCount As Integer
    Public oGaurd As GaurdDetail
    Public iMinutes(59) As String
    'Part 2
    Public iMinute As Integer
    Public iMinuteTotal As Integer
    Public iGaurd As Integer

    Public Function ReadFile() As Integer
        Dim iValues(1000) As Integer
        Dim stringReader
        Dim fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\FTPTemp\Frequency4.txt")

        stringReader = fileReader.ReadLine()

        While stringReader <> ""
            oGaurdLines(iLineCount) = New GaurdLine(stringReader)
            stringReader = fileReader.ReadLine()
            iLineCount = iLineCount + 1
        End While

        'Sort by date
        SortArray()

        'Populate gaurd data
        PopulateGaurdData()

        'Populate totals
        PopulateGaurdTotals()

        'find highest total
        FindHighestTotal()

        'Part 2
        FindBiggestMinute()

        'Find minute
        'FindMinute()

    End Function

    Private Sub SortArray()
        Dim iLoop1, iLoop2 As Integer
        Dim oTempLine As GaurdLine

        For iLoop1 = 0 To iLineCount - 1
            For iLoop2 = 0 To iLineCount - 1
                If oGaurdLines(iLoop2).iDate > oGaurdLines(iLoop1).iDate Then
                    oTempLine = oGaurdLines(iLoop2)
                    oGaurdLines(iLoop2) = oGaurdLines(iLoop1)
                    oGaurdLines(iLoop1) = oTempLine
                End If
            Next
        Next

    End Sub

    Private Sub PopulateGaurdData()
        Dim iLoop As Integer
        Dim iLastId As Integer
        Dim iGaurdPos As Integer

        For iLoop = 0 To iLineCount - 1
            If oGaurdLines(iLoop).iGaurdId <> 0 Then
                iLastId = oGaurdLines(iLoop).iGaurdId
                iGaurdPos = CheckGaurd(oGaurdLines(iLoop).iGaurdId)
            End If

            If iGaurdPos > -1 And oGaurdLines(iLoop).iGaurdId = 0 Then

                If oGaurdLines(iLoop).sState = "falls asleep" Then
                    oGaurdDetail(iGaurdPos).addSleep(oGaurdLines(iLoop).iDate)
                Else
                    oGaurdDetail(iGaurdPos).addWake(oGaurdLines(iLoop).iDate)
                End If

            End If
        Next

    End Sub

    Private Sub PopulateGaurdTotals()
        Dim iLoop As Integer

        For iLoop = 0 To iGaurdCount - 1

            oGaurdDetail(iLoop).getTotals()

        Next

    End Sub

    Private Sub FindHighestTotal()
        Dim iLoop As Integer

        oGaurd = oGaurdDetail(0)

        For iLoop = 0 To iGaurdCount - 1

            If oGaurdDetail(iLoop).iTotalTime > oGaurd.iTotalTime Then
                oGaurd = oGaurdDetail(iLoop)
            End If

        Next

    End Sub

    Private Sub FindMinute()
        Dim iLoop1, iLoop2 As Integer

        For iLoop2 = 0 To 59

            For iLoop1 = 0 To oGaurd.icount


                If oGaurd.sSleep(iLoop1).Minute <= iLoop2 And oGaurd.sWake(iLoop1).Minute > iLoop2 Then
                    iMinutes(iLoop2) = iMinutes(iLoop2) + 1
                End If
            Next

        Next

    End Sub

    Private Function CheckGaurd(Id As Integer) As Integer
        Dim iLoop As Integer
        Dim bFound As Boolean
        Dim iPos As Integer

        Try
            For iLoop = 0 To iGaurdCount
                If oGaurdDetail(iLoop).iGaurdId = Id Then
                    bFound = True
                    iPos = iLoop
                End If
            Next
        Catch
        End Try

        If bFound Then
            'Update existing
        Else
            oGaurdDetail(iGaurdCount) = New GaurdDetail(Id)
            iPos = iGaurdCount
            iGaurdCount = iGaurdCount + 1
        End If

        Return iPos

    End Function

    Private Sub FindBiggestMinute()
        Dim iLoop1, iLoop2, iLoop3, iLoop4 As Integer
        Dim sTempMinutes(59) As String

        For iLoop1 = 0 To iGaurdCount - 1
            For iLoop2 = 0 To oGaurdDetail(iLoop1).icount - 1
                For iLoop3 = 0 To 59
                    If oGaurdDetail(iLoop1).sSleep(iLoop2).Minute <= iLoop3 And oGaurd.sWake(iLoop2).Minute > iLoop2 Then
                        iMinutes(iLoop3) = iMinutes(iLoop3) + 1
                    End If
                Next
            Next

            For iLoop4 = 0 To 59
                If iMinutes(iLoop4) > iMinuteTotal Then
                    iMinuteTotal = iMinutes(iLoop4)
                    iMinute = iLoop4
                    iGaurd = oGaurdDetail(iLoop1).iGaurdId
                End If
            Next

        Next

    End Sub

End Class

