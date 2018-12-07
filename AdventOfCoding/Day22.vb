Public Class Day22
    Public iCount As Integer
    Public sCollection(1000000) As String
    Public sMatch1, sMatch2 As String

    Public Function ReadFile() As String
        Dim sReturn As String
        Dim stringReader
        Dim fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\FTPTemp\Frequency2.txt")

        stringReader = fileReader.ReadLine()

        While stringReader <> ""
            sCollection(iCount) = stringReader
            iCount = iCount + 1
            stringReader = fileReader.ReadLine()
        End While

        FindNearMatch()

        Return sReturn

    End Function

    Private Sub FindNearMatch()
        Dim iLoop1, iLoop2 As Integer

        For iLoop1 = 0 To iCount - 1

            For iLoop2 = iLoop1 To iCount - 1

                If CheckPatternMatch(sCollection(iLoop1), sCollection(iLoop2)) Then

                    sMatch1 = sCollection(iLoop1)
                    sMatch2 = sCollection(iLoop2)

                End If

            Next

        Next

    End Sub

    Private Function CheckPatternMatch(sLine1 As String, sLine2 As String) As Boolean
        Dim iDifferences As Integer
        Dim iLoop As Integer
        Dim bReturn As Boolean

        For iLoop = 0 To sLine1.Length - 1
            If sLine1.Substring(iLoop, 1) <> sLine2.Substring(iLoop, 1) Then
                iDifferences = iDifferences + 1
            End If
        Next

        If iDifferences = 1 Then
            bReturn = True
        End If

        Return bReturn

    End Function

End Class
