Public Class Bwire_Media_Player

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBoxAdv1.Items.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim OFD2 As New OpenFileDialog
        OFD2.Multiselect = True
        OFD2.Filter = "Audio (*.mp3)|*.mp3|Audio (*.wav)|*.wav|Audio (*.wma)|*.wma|All Files (*.*)|*.*"
        If OFD2.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each File As String In OFD2.FileNames
                ListBoxAdv1.Items.Add(File)
            Next
        End If
    End Sub

    Private Sub ListBoxAdv1_ItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxAdv1.ItemClick

    End Sub

    Private Sub ListBoxAdv1_ItemDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBoxAdv1.ItemDoubleClick
        AxWindowsMediaPlayer1.URL = ListBoxAdv1.SelectedItem
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar4.Scroll
        If TrackBar4.Value = 10 Then
            AxWindowsMediaPlayer1.settings.rate = 2
        End If
        If TrackBar4.Value = 9 Then
            AxWindowsMediaPlayer1.settings.rate = 1.8
        End If
        If TrackBar4.Value = 8 Then
            AxWindowsMediaPlayer1.settings.rate = 1.6
        End If
        If TrackBar4.Value = 7 Then
            AxWindowsMediaPlayer1.settings.rate = 1.4
        End If
        If TrackBar4.Value = 6 Then
            AxWindowsMediaPlayer1.settings.rate = 1.2
        End If
        If TrackBar4.Value = 5 Then
            AxWindowsMediaPlayer1.settings.rate = 1
        End If
        If TrackBar4.Value = 4 Then
            AxWindowsMediaPlayer1.settings.rate = 0.8
        End If
        If TrackBar4.Value = 3 Then
            AxWindowsMediaPlayer1.settings.rate = 0.6
        End If
        If TrackBar4.Value = 2 Then
            AxWindowsMediaPlayer1.settings.rate = 0.4
        End If
        If TrackBar4.Value = 1 Then
            AxWindowsMediaPlayer1.settings.rate = 0.2
        End If
        If TrackBar4.Value = 0 Then
            AxWindowsMediaPlayer1.settings.rate = 0.1
        End If
    End Sub
End Class