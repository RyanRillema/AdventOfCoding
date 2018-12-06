Public Class Day11
    Public iValues(1100000) As Integer
    Public iRunningTotal As Integer = 0
    Public iSize As Integer
    Public bFound As Boolean
    Public iMatch As Integer
    Public index As Integer

    Public Function ReadFile() As Integer
        Dim iValues(1000) As Integer
        Dim stringReader
        Dim fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\FTPTemp\Frequency.txt")

        stringReader = fileReader.ReadLine()

        While stringReader <> ""
            ProcLine(iRunningTotal, stringReader)
            stringReader = fileReader.ReadLine()
        End While

        Return iRunningTotal

    End Function

    Private Sub ProcLine(ByRef iRunningTotal As Integer, sLine As String)
        Dim iValue As Integer

        iValue = CInt(sLine.Substring(1))

        Select Case sLine.Substring(0, 1)
            Case "+"
                iRunningTotal = iRunningTotal + iValue
            Case "-"
                iRunningTotal = iRunningTotal - iValue
        End Select

        CheckDuplicate(iRunningTotal)

        iValues(iSize) = iRunningTotal
        iSize = iSize + 1

    End Sub

    Private Sub CheckDuplicate(iRunningTotal)
        Dim iLoop As Integer

        'If index < 1 Then
        'index = Array.FindIndex(iValues, Function(s) s = iRunningTotal)
        'Else
        'bFound = True
        'End If

        For iLoop = 0 To iSize + 1
            If Not bFound And iValues(iLoop) = iRunningTotal Then
                'If iValues(iLoop) = iRunningTotal Then
                'Match found
                iMatch = iRunningTotal
                    bFound = True
                End If
        Next


    End Sub

End Class
