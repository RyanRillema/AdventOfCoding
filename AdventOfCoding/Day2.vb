Public Class Day2

    Public iValues(1100000) As Integer
    Public iChecksum As Integer = 0
    Public iSize As Integer
        Public bFound As Boolean
        Public iMatch As Integer
    Public index As Integer

    Public iDoubles As Integer
    Public iTriples As Integer

    Public Function ReadFile() As Integer
            Dim iValues(1000) As Integer
            Dim stringReader
        Dim fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\FTPTemp\Frequency2.txt")

        stringReader = fileReader.ReadLine()

            While stringReader <> ""
            ProcLine(stringReader)
            stringReader = fileReader.ReadLine()
        End While

        iChecksum = iTriples * iDoubles

        Return iChecksum

    End Function

    Private Sub ProcLinePart2(sLine As String)

    End Sub

    Private Sub ProcLine(sLine As String)
        Dim sArray(sLine.Length) As String
        Dim bDouble, bTriple As Boolean
        Dim iLoop1, iCount As Integer

        For iLoop1 = 0 To sLine.Length - 1
            sArray(iLoop1) = sLine.Substring(iLoop1, 1)
        Next

        Array.Sort(sArray)

        For iLoop1 = 0 To sLine.Length - 1
            Try
                If sArray(iLoop1) = sArray(iLoop1 + 1) Then
                    If sArray(iLoop1 + 1) = sArray(iLoop1 + 2) Then
                        iCount = sLine.Split(sArray(iLoop1 + 1)).Length - 1
                        If iCount = 3 Then
                            bTriple = True
                        End If
                    End If
                End If
            Catch
            End Try
            If sArray(iLoop1) = sArray(iLoop1 + 1) Then
                iCount = sLine.Split(sArray(iLoop1 + 1)).Length - 1
                If iCount = 2 Then
                    bDouble = True
                End If
            End If
        Next

        If bTriple Then
            iTriples = iTriples + 1
        End If

        If bDouble Then
            iDoubles = iDoubles + 1
        End If

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
