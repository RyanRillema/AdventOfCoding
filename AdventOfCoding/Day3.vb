Public Class Day3
    Dim sGrid(10000, 10000) As String
    Public sFound As String
    Public iDoubles As Integer

    Public Function ReadFile() As Integer
        Dim iValues(1000) As Integer
        Dim stringReader
        Dim fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\FTPTemp\Frequency3.txt")

        stringReader = fileReader.ReadLine()

        While stringReader <> ""
            ProcLine(stringReader)
            stringReader = fileReader.ReadLine()
        End While

        'CountDoubles()

    End Function

    Public Function ReadFile2() As Integer
        Dim stringReader
        Dim fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\FTPTemp\Frequency3.txt")

        stringReader = fileReader.ReadLine()

        While stringReader <> ""
            If CheckDoubles(stringReader) Then
                sFound = stringReader
            End If
            stringReader = fileReader.ReadLine()
        End While

        'CountDoubles()

    End Function

    Private Sub ProcLine(sLine As String)
        Dim iStartX As Integer
        Dim iStartY As Integer
        Dim iSizeX As Integer
        Dim iSizeY As Integer
        Dim AtPos, ComPos, ColPos, XPos As Integer
        Dim iLoopX, iLoopY As Integer
        Dim iTemp As Integer

        AtPos = sLine.IndexOf("@")
        ComPos = sLine.IndexOf(",")
        ColPos = sLine.IndexOf(":")
        XPos = sLine.IndexOf("x")

        iStartX = sLine.Substring(AtPos + 2, ComPos - AtPos - 1)
        iStartY = sLine.Substring(ComPos + 1, ColPos - ComPos - 1)

        'iTemp = sLine.IndexOf(":") + 1
        'iTemp = sLine.IndexOf("x") - ColPos

        iSizeX = sLine.Substring(ColPos + 1, XPos - ColPos - 1)
        iSizeY = sLine.Substring(XPos + 1)

        For iLoopX = 0 To iSizeX - 1
            For iLoopY = 0 To iSizeY - 1
                sGrid(iStartX + iLoopX, iStartY + iLoopY) = sGrid(iStartX + iLoopX, iStartY + iLoopY) + 1
            Next
        Next

    End Sub

    Private Function CheckDoubles(sLine As String) As Boolean
        Dim iStartX As Integer
        Dim iStartY As Integer
        Dim iSizeX As Integer
        Dim iSizeY As Integer
        Dim AtPos, ComPos, ColPos, XPos As Integer
        Dim iLoopX, iLoopY As Integer
        Dim iTemp As Integer
        Dim bFound As Boolean

        AtPos = sLine.IndexOf("@")
        ComPos = sLine.IndexOf(",")
        ColPos = sLine.IndexOf(":")
        XPos = sLine.IndexOf("x")

        iStartX = sLine.Substring(AtPos + 2, ComPos - AtPos - 1)
        iStartY = sLine.Substring(ComPos + 1, ColPos - ComPos - 1)

        'iTemp = sLine.IndexOf(":") + 1
        'iTemp = sLine.IndexOf("x") - ColPos

        iSizeX = sLine.Substring(ColPos + 1, XPos - ColPos - 1)
        iSizeY = sLine.Substring(XPos + 1)

        bFound = True

        For iLoopX = 0 To iSizeX - 1
            For iLoopY = 0 To iSizeY - 1
                If sGrid(iStartX + iLoopX, iStartY + iLoopY) > 1 Then
                    bFound = False
                End If
            Next
        Next

        Return bFound

    End Function

    Private Sub CountDoubles()
        Dim iLoopX, iLoopY As Integer

        For iLoopX = 0 To 10000
            For iLoopY = 0 To 10000
                If sGrid(iLoopX, iLoopY) > 1 Then
                    iDoubles = iDoubles + 1
                End If
            Next
        Next
    End Sub

End Class

