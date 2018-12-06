Public Class Form1
    Private oDay11 As Day11
    Private oDay2 As Day2


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oDay11 = New Day11
        oDay2 = New Day2
    End Sub

    Private Sub cmdDay11_Click(sender As Object, e As EventArgs) Handles cmdDay11.Click

        While oDay11.bFound = False
            lbDay11.Text = oDay11.ReadFile()
        End While

    End Sub

    Private Sub cmdDay2_Click(sender As Object, e As EventArgs) Handles cmdDay2.Click
        lbDay2.Text = oDay2.ReadFile
    End Sub
End Class
