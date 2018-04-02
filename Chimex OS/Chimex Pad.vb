Imports System.IO
Public Class Chimex_Pad

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim AllText As String = "", LineOfText As String = ""
        OpenFileDialog1.Filter = "Text files (*.txt)|*.txt"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            Try
                FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
                Do Until EOF(1)
                    LineOfText = LineInput(1)

                    AllText = AllText & LineOfText & vbCrLf
                Loop

                TextBox1.Text = AllText
                TextBox1.Enabled = True
       
            Catch
                MsgBox("Error opening file.")
            Finally
                FileClose(1)
            End Try
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            My.Computer.FileSystem.WriteAllText( _
                SaveFileDialog1.FileName, TextBox1.Text, False)
        End If
    End Sub

   


    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not TextBox1.Text = "" Then

            If MessageBox.Show("Save First ?", "Save..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                SaveFileDialog1.Filter = "Text files (*.txt)|*.txt"
                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

                    My.Computer.FileSystem.WriteAllText( _
                        SaveFileDialog1.FileName, TextBox1.Text, False)
                End If
                TextBox1.Clear()
            Else
                TextBox1.Clear()
            End If

        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case MessageBox.Show("Do you want to exit TextEditor", "Exit..", MessageBoxButtons.YesNo)
            Case Windows.Forms.DialogResult.Yes
                MessageBox.Show("Have a nice Day", "Bye")
                End
            Case Windows.Forms.DialogResult.No
                TextBox1.Focus()
        End Select
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            'copy text to disk
            My.Computer.FileSystem.WriteAllText( _
                SaveFileDialog1.FileName, TextBox1.Text, False)
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Dim objtxt As TextBox = Me.ActiveControl
        objtxt.Cut()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        Dim objtxt As TextBox = Me.ActiveControl
        objtxt.Undo()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Dim objtxt As TextBox = Me.ActiveControl
        objtxt.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        Dim objtxt As TextBox = Me.ActiveControl
        objtxt.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        Dim objtxt As TextBox = Me.ActiveControl
        objtxt.SelectAll()
    End Sub

    Private Sub FontToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        Dim objtxt As TextBox = Me.ActiveControl
        FontDialog1.ShowDialog()
        objtxt.Font = FontDialog1.Font
    End Sub


    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(TextBox1.Text, TextBox1.Font, Brushes.Black, 100, 100)
    End Sub

    Private Sub FontColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontColorToolStripMenuItem.Click
        Dim objtxt As TextBox = Me.ActiveControl
        ColorDialog1.ShowDialog()
        objtxt.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim objtxt As TextBox = Me.ActiveControl
        objtxt.Clear()
    End Sub

    Private Sub TimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeToolStripMenuItem.Click
        TextBox1.Text = System.DateTime.Now
    End Sub
    Public Function countC(ByVal text As String) As Integer
        If TextBox1.Text = " " Then Return 0
        Dim intchar = text.Length
        Return intchar
    End Function
    Public Function countW(ByVal text As String) As Integer
        If TextBox1.Text = " " Then Return 0
        Dim chtword() As String = text.Split(" ".ToCharArray)
        Return chtword.Length
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Timer1.Enabled = True

    End Sub
    Private Sub FontWrapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontWrapToolStripMenuItem.Click
        If FontWrapToolStripMenuItem.Checked = False Then
            FontWrapToolStripMenuItem.Checked = True
            TextBox1.WordWrap = True
        ElseIf FontWrapToolStripMenuItem.Checked = True Then
            FontWrapToolStripMenuItem.Checked = False
            TextBox1.WordWrap = False
        End If
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NewToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        If Not TextBox1.Text = "" Then

            If MessageBox.Show("Save First ?", "Save..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                SaveFileDialog1.Filter = "Text files (*.txt)|*.txt"
                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

                    My.Computer.FileSystem.WriteAllText( _
                        SaveFileDialog1.FileName, TextBox1.Text, False)
                End If
                TextBox1.Clear()
            Else
                TextBox1.Clear()
            End If

        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim AllText As String = "", LineOfText As String = ""
        OpenFileDialog1.Filter = "Text files (*.txt)|*.txt"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            Try
                FileOpen(1, OpenFileDialog1.FileName, OpenMode.Input)
                Do Until EOF(1)
                    LineOfText = LineInput(1)

                    AllText = AllText & LineOfText & vbCrLf
                Loop

                TextBox1.Text = AllText
                TextBox1.Enabled = True
         
            Catch
                MsgBox("Error opening file.")
            Finally
                FileClose(1)
            End Try
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            My.Computer.FileSystem.WriteAllText( _
                SaveFileDialog1.FileName, TextBox1.Text, False)
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text files (*.txt)|*.txt"
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            My.Computer.FileSystem.WriteAllText( _
                SaveFileDialog1.FileName, TextBox1.Text, False)
        End If
    End Sub
End Class