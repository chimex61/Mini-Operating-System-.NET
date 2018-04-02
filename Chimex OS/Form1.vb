Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBarX1.Value += 2
        labelloading.Text = ProgressBarX1.Value & "%"
        If ProgressBarX1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            Desktop.Show()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        Timer1.Start()
    End Sub
End Class
