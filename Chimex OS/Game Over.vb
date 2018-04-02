Public Class Game_Over

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Game.Close()
    End Sub

    Private Sub Game_Over_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class