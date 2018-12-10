Public Class Form1
    Private oDay11 As Day11
    Private oDay2 As Day2
    Private oDay22 As Day22
    Private oDay31 As Day3
    Private oDay41 As Day4


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oDay11 = New Day11
        oDay2 = New Day2
        oDay22 = New Day22
        oDay31 = New Day3
        oDay41 = New Day4
    End Sub

    Private Sub cmdDay11_Click(sender As Object, e As EventArgs) Handles cmdDay11.Click

        While oDay11.bFound = False
            lbDay11.Text = oDay11.ReadFile()
        End While

    End Sub

    Private Sub cmdDay2_Click(sender As Object, e As EventArgs) Handles cmdDay2.Click
        lbDay2.Text = oDay2.ReadFile
    End Sub

    Private Sub cmdDay22_Click(sender As Object, e As EventArgs) Handles cmdDay22.Click
        oDay22.ReadFile()
        lbDay22.Text = oDay22.sMatch1 & " / " & oDay22.sMatch2
    End Sub

    Private Sub cmdDay31_Click(sender As Object, e As EventArgs) Handles cmdDay31.Click
        oDay31.ReadFile()
        lbDay31.Text = oDay31.iDoubles
    End Sub

    Private Sub cmdDay32_Click(sender As Object, e As EventArgs) Handles cmdDay32.Click
        oDay31.ReadFile()
        oDay31.ReadFile2()
        lbDay31.Text = oDay31.sFound
    End Sub

    Private Sub cmdDay41_Click(sender As Object, e As EventArgs) Handles cmdDay41.Click
        oDay41.ReadFile()
    End Sub
End Class
