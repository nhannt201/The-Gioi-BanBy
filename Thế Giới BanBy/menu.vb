Public Class menu2

    Private Sub menu2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wmp.URL = Application.StartupPath & "\sound\menu.wmv"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        v1.Show()
        Me.Hide()
        wmp.URL = ""
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles m2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        m1.Left = m1.Left - 1
        m2.Left = m2.Left + 1
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        m1.Left = 980
        m2.Left = 2
    End Sub
End Class