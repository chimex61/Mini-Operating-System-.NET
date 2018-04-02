Imports System.Net
Public Class IP_Tracer

    Private Sub IP_Tracer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable Then
        Else
            MsgBox("Connect to the internet", MsgBoxStyle.Exclamation)
            Me.Close()
        End If
        
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        TextBox1.Text = ""
        RichTextBoxEx1.Text = ""
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim hostname As IPHostEntry = Dns.GetHostByName(TextBox1.Text)
        Dim ip As IPAddress() = hostname.AddressList
        RichTextBoxEx1.SelectedText = "Bwire Mini operating System" & vbCrLf
        RichTextBoxEx1.SelectedText = "-----IP Address Tracer-----" & vbCrLf
        RichTextBoxEx1.SelectedText = "-----  Trace succeed  -----" & vbCrLf
        RichTextBoxEx1.SelectedText = "-----  IP Received is -----" & vbCrLf
        RichTextBoxEx1.SelectedText = ip(0).ToString() & vbCrLf
        RichTextBoxEx1.SelectedText = "----- Command complete ----"


    End Sub
End Class