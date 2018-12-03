Public Class Day11

    Public Function ReadFile() As Integer
        Dim iRunningTotal As Integer = 0
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

    End Sub


End Class
