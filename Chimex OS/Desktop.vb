Public Class Desktop

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lclock.Text = My.Computer.Clock.LocalTime
        AnalogClockControl1.Value = My.Computer.Clock.LocalTime

    End Sub

    Private Sub Desktop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        refreshdesktop()
    End Sub

    Private Sub refreshdesktop()
        User.Text = Environment.UserName
        Osystem.Text = My.Computer.Info.OSFullName
        OSversion.Text = My.Computer.Info.OSVersion
        OSplatform.Text = My.Computer.Info.OSPlatform
        
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBarX1.Value = RAMcounter.NextValue
        ProgressBarX2.Value = CPUcounter.NextValue
        ramperf.Text = ProgressBarX1.Value & "%"
        cpuperfor.Text = ProgressBarX2.Value & "%"
    End Sub

    Private Sub bubbleButton7_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleButton7.Click
        Chimex_Browser.Show()
        Chimex_Browser.BringToFront()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If My.Computer.Network.IsAvailable Then
            PictureBox1.Show()
        Else
            PictureBox1.Hide()
        End If
    End Sub

    Private Sub bubbleButton4_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleButton4.Click
        Chimex_Pad.Show()
        Chimex_Pad.BringToFront()
    End Sub

    Private Sub bubbleButton6_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleButton6.Click
        Bwire_Media_Player.Show()
        Bwire_Media_Player.BringToFront()
    End Sub

    Private Sub bubbleButton5_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleButton5.Click
        Calculator.Show()
        Calculator.BringToFront()
    End Sub

    Private Sub bubbleButton10_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleButton10.Click
        Game.Show()
        Game.BringToFront()
    End Sub

    Private Sub bubbleButton8_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleButton8.Click
        Application.Exit()
    End Sub

    Private Sub bubbleButton9_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleButton9.Click
        MsgBox("Chimex Mini Operating System" & vbCrLf & "Programmed By Francis John" & vbCrLf & "2018", MsgBoxStyle.Information)
    End Sub

    Private Sub bubbleButton2_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleButton2.Click
        IP_Tracer.Show()
        IP_Tracer.BringToFront()
    End Sub

    Private Sub bubbleButton1_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles bubbleButton1.Click
        Contacts.Show()
        Contacts.BringToFront()
    End Sub
End Class