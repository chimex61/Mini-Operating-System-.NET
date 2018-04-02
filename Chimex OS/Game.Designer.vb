<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.bustedlabel = New System.Windows.Forms.Label()
        Me.scoreLabel = New System.Windows.Forms.Label()
        Me.scoreTimer = New System.Windows.Forms.Timer(Me.components)
        Me.enemyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'bustedlabel
        '
        Me.bustedlabel.AutoSize = True
        Me.bustedlabel.BackColor = System.Drawing.Color.Transparent
        Me.bustedlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bustedlabel.ForeColor = System.Drawing.Color.Transparent
        Me.bustedlabel.Location = New System.Drawing.Point(440, 9)
        Me.bustedlabel.Name = "bustedlabel"
        Me.bustedlabel.Size = New System.Drawing.Size(123, 20)
        Me.bustedlabel.TabIndex = 3
        Me.bustedlabel.Text = "Busted aliens:"
        '
        'scoreLabel
        '
        Me.scoreLabel.AutoSize = True
        Me.scoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.scoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreLabel.ForeColor = System.Drawing.Color.Transparent
        Me.scoreLabel.Location = New System.Drawing.Point(22, 9)
        Me.scoreLabel.Name = "scoreLabel"
        Me.scoreLabel.Size = New System.Drawing.Size(111, 20)
        Me.scoreLabel.TabIndex = 2
        Me.scoreLabel.Text = "Total Score: "
        '
        'scoreTimer
        '
        Me.scoreTimer.Interval = 1000
        '
        'enemyTimer
        '
        Me.enemyTimer.Interval = 200
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(655, 602)
        Me.Controls.Add(Me.bustedlabel)
        Me.Controls.Add(Me.scoreLabel)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Game"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bustedlabel As System.Windows.Forms.Label
    Friend WithEvents scoreLabel As System.Windows.Forms.Label
    Friend WithEvents scoreTimer As System.Windows.Forms.Timer
    Friend WithEvents enemyTimer As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
