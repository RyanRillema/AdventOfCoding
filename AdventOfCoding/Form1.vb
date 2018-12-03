Public Class Form1
    Private oDay11 As Day11


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oDay11 = New Day11
    End Sub

    Private Sub cmdDay11_Click(sender As Object, e As EventArgs) Handles cmdDay11.Click
        lbDay11.Text = oDay11.ReadFile()
    End Sub

End Class
