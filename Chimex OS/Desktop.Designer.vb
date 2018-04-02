<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desktop
    Inherits System.Windows.Forms.Form

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
        Dim ClockStyleData2 As DevComponents.DotNetBar.Controls.ClockStyleData = New DevComponents.DotNetBar.Controls.ClockStyleData()
        Dim ColorData9 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ColorData10 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ColorData11 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ClockHandStyleData4 As DevComponents.DotNetBar.Controls.ClockHandStyleData = New DevComponents.DotNetBar.Controls.ClockHandStyleData()
        Dim ColorData12 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ColorData13 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ClockHandStyleData5 As DevComponents.DotNetBar.Controls.ClockHandStyleData = New DevComponents.DotNetBar.Controls.ClockHandStyleData()
        Dim ColorData14 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ClockHandStyleData6 As DevComponents.DotNetBar.Controls.ClockHandStyleData = New DevComponents.DotNetBar.Controls.ClockHandStyleData()
        Dim ColorData15 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim ColorData16 As DevComponents.DotNetBar.Controls.ColorData = New DevComponents.DotNetBar.Controls.ColorData()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Desktop))
        Me.AnalogClockControl1 = New DevComponents.DotNetBar.Controls.AnalogClockControl()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cpuperfor = New System.Windows.Forms.Label()
        Me.ramperf = New System.Windows.Forms.Label()
        Me.ProgressBarX2 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OSplatform = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OSversion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Osystem = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.User = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.lclock = New System.Windows.Forms.Label()
        Me.bubbleBar1 = New DevComponents.DotNetBar.BubbleBar()
        Me.bubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.bubbleButton4 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton1 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton2 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton5 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton6 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton7 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton10 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton8 = New DevComponents.DotNetBar.BubbleButton()
        Me.bubbleButton9 = New DevComponents.DotNetBar.BubbleButton()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RAMcounter = New System.Diagnostics.PerformanceCounter()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.CPUcounter = New System.Diagnostics.PerformanceCounter()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RAMcounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CPUcounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnalogClockControl1
        '
        Me.AnalogClockControl1.BackColor = System.Drawing.Color.Transparent
        Me.AnalogClockControl1.ClockStyle = DevComponents.DotNetBar.Controls.eClockStyles.Custom
        ColorData9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData9.BrushAngle = 90.0!
        ColorData9.BrushSBSScale = 1.0!
        ColorData9.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData9.Color1 = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        ColorData9.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ClockStyleData2.BezelColor = ColorData9
        ColorData10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData10.BorderWidth = 0.01!
        ColorData10.BrushSBSScale = 1.0!
        ColorData10.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ColorData10.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ClockStyleData2.CapColor = ColorData10
        ClockStyleData2.CapSize = 0.1!
        ColorData11.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData11.BrushAngle = 90.0!
        ColorData11.BrushSBSScale = 1.0!
        ColorData11.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData11.Color1 = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        ColorData11.Color2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        ClockStyleData2.FaceColor = ColorData11
        ClockStyleData2.GlassAngle = 0
        ColorData12.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData12.BorderWidth = 0.01!
        ColorData12.BrushAngle = 90.0!
        ColorData12.BrushSBSScale = 1.0!
        ColorData12.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData12.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData12.Color2 = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        ClockHandStyleData4.HandColor = ColorData12
        ClockHandStyleData4.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style3
        ClockHandStyleData4.Length = 0.45!
        ClockHandStyleData4.Width = 0.175!
        ClockStyleData2.HourHandStyle = ClockHandStyleData4
        ColorData13.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData13.BorderWidth = 0.01!
        ColorData13.BrushSBSScale = 1.0!
        ColorData13.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData13.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ClockStyleData2.LargeTickColor = ColorData13
        ClockStyleData2.LargeTickWidth = 0.01!
        ColorData14.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData14.BorderWidth = 0.01!
        ColorData14.BrushAngle = 90.0!
        ColorData14.BrushSBSScale = 1.0!
        ColorData14.BrushType = DevComponents.DotNetBar.Controls.eBrushTypes.Linear
        ColorData14.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData14.Color2 = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        ClockHandStyleData5.HandColor = ColorData14
        ClockHandStyleData5.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style3
        ClockHandStyleData5.Length = 0.75!
        ClockHandStyleData5.Width = 0.175!
        ClockStyleData2.MinuteHandStyle = ClockHandStyleData5
        ClockStyleData2.NumberColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ClockStyleData2.NumberFont = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        ClockHandStyleData6.DrawOverCap = True
        ColorData15.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData15.BorderWidth = 0.01!
        ColorData15.BrushSBSScale = 1.0!
        ColorData15.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData15.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ClockHandStyleData6.HandColor = ColorData15
        ClockHandStyleData6.HandStyle = DevComponents.DotNetBar.Controls.eHandStyles.Style4
        ClockHandStyleData6.Length = 0.9!
        ClockHandStyleData6.Width = 0.01!
        ClockStyleData2.SecondHandStyle = ClockHandStyleData6
        ColorData16.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData16.BorderWidth = 0.01!
        ColorData16.BrushSBSScale = 1.0!
        ColorData16.Color1 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ColorData16.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        ClockStyleData2.SmallTickColor = ColorData16
        ClockStyleData2.SmallTickLength = 0.01!
        ClockStyleData2.SmallTickWidth = 0.01!
        ClockStyleData2.Style = DevComponents.DotNetBar.Controls.eClockStyles.Custom
        Me.AnalogClockControl1.ClockStyleData = ClockStyleData2
        Me.AnalogClockControl1.Location = New System.Drawing.Point(34, 12)
        Me.AnalogClockControl1.Name = "AnalogClockControl1"
        Me.AnalogClockControl1.Size = New System.Drawing.Size(119, 119)
        Me.AnalogClockControl1.TabIndex = 0
        Me.AnalogClockControl1.Text = "AnalogClockControl1"
        Me.AnalogClockControl1.Value = New Date(2016, 1, 29, 13, 8, 39, 257)
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PictureBox1)
        Me.PanelEx1.Controls.Add(Me.cpuperfor)
        Me.PanelEx1.Controls.Add(Me.ramperf)
        Me.PanelEx1.Controls.Add(Me.ProgressBarX2)
        Me.PanelEx1.Controls.Add(Me.Label6)
        Me.PanelEx1.Controls.Add(Me.ProgressBarX1)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.OSplatform)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.OSversion)
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.Osystem)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.User)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Controls.Add(Me.lclock)
        Me.PanelEx1.Controls.Add(Me.AnalogClockControl1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelEx1.Location = New System.Drawing.Point(918, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(200, 613)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(157, 570)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'cpuperfor
        '
        Me.cpuperfor.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cpuperfor.AutoSize = True
        Me.cpuperfor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpuperfor.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cpuperfor.Location = New System.Drawing.Point(136, 508)
        Me.cpuperfor.Name = "cpuperfor"
        Me.cpuperfor.Size = New System.Drawing.Size(17, 19)
        Me.cpuperfor.TabIndex = 17
        Me.cpuperfor.Text = "0"
        '
        'ramperf
        '
        Me.ramperf.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ramperf.AutoSize = True
        Me.ramperf.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ramperf.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ramperf.Location = New System.Drawing.Point(133, 468)
        Me.ramperf.Name = "ramperf"
        Me.ramperf.Size = New System.Drawing.Size(17, 19)
        Me.ramperf.TabIndex = 16
        Me.ramperf.Text = "0"
        '
        'ProgressBarX2
        '
        Me.ProgressBarX2.Anchor = System.Windows.Forms.AnchorStyles.Right
        '
        '
        '
        Me.ProgressBarX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBarX2.Location = New System.Drawing.Point(7, 512)
        Me.ProgressBarX2.Name = "ProgressBarX2"
        Me.ProgressBarX2.Size = New System.Drawing.Size(120, 15)
        Me.ProgressBarX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.ProgressBarX2.TabIndex = 15
        Me.ProgressBarX2.Text = "ProgressBarX2"
        Me.ProgressBarX2.Value = 34
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(3, 490)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "CPU"
        '
        'ProgressBarX1
        '
        Me.ProgressBarX1.Anchor = System.Windows.Forms.AnchorStyles.Right
        '
        '
        '
        Me.ProgressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBarX1.Location = New System.Drawing.Point(7, 472)
        Me.ProgressBarX1.Name = "ProgressBarX1"
        Me.ProgressBarX1.Size = New System.Drawing.Size(120, 15)
        Me.ProgressBarX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.ProgressBarX1.TabIndex = 13
        Me.ProgressBarX1.Text = "ProgressBarX1"
        Me.ProgressBarX1.Value = 34
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(3, 450)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "RAM"
        '
        'OSplatform
        '
        Me.OSplatform.AutoSize = True
        Me.OSplatform.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSplatform.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.OSplatform.Location = New System.Drawing.Point(3, 388)
        Me.OSplatform.Name = "OSplatform"
        Me.OSplatform.Size = New System.Drawing.Size(91, 19)
        Me.OSplatform.TabIndex = 11
        Me.OSplatform.Text = "Current User"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(3, 369)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Operating System Platform"
        '
        'OSversion
        '
        Me.OSversion.AutoSize = True
        Me.OSversion.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OSversion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.OSversion.Location = New System.Drawing.Point(3, 340)
        Me.OSversion.Name = "OSversion"
        Me.OSversion.Size = New System.Drawing.Size(91, 19)
        Me.OSversion.TabIndex = 9
        Me.OSversion.Text = "Current User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(3, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Operating System Version"
        '
        'Osystem
        '
        Me.Osystem.AutoSize = True
        Me.Osystem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Osystem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Osystem.Location = New System.Drawing.Point(3, 291)
        Me.Osystem.Name = "Osystem"
        Me.Osystem.Size = New System.Drawing.Size(91, 19)
        Me.Osystem.TabIndex = 7
        Me.Osystem.Text = "Current User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(3, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Operating System"
        '
        'User
        '
        Me.User.AutoSize = True
        Me.User.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.User.Location = New System.Drawing.Point(3, 239)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(91, 19)
        Me.User.TabIndex = 5
        Me.User.Text = "Current User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(3, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Current User"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(0, 170)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(200, 37)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 3
        Me.PanelEx2.Text = "SYSTEM INFO"
        '
        'lclock
        '
        Me.lclock.AutoSize = True
        Me.lclock.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lclock.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lclock.Location = New System.Drawing.Point(30, 134)
        Me.lclock.Name = "lclock"
        Me.lclock.Size = New System.Drawing.Size(53, 19)
        Me.lclock.TabIndex = 1
        Me.lclock.Text = "Label1"
        '
        'bubbleBar1
        '
        Me.bubbleBar1.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom
        Me.bubbleBar1.AntiAlias = True
        Me.bubbleBar1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.bubbleBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.bubbleBar1.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.bubbleBar1.ButtonBackAreaStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Tile
        Me.bubbleBar1.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bubbleBar1.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.bubbleBar1.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.bubbleBar1.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bubbleBar1.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.bubbleBar1.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bubbleBar1.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.bubbleBar1.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bubbleBar1.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.bubbleBar1.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.bubbleBar1.ButtonBackAreaStyle.PaddingBottom = 3
        Me.bubbleBar1.ButtonBackAreaStyle.PaddingLeft = 3
        Me.bubbleBar1.ButtonBackAreaStyle.PaddingRight = 3
        Me.bubbleBar1.ButtonBackAreaStyle.PaddingTop = 3
        Me.bubbleBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bubbleBar1.ImageSizeLarge = New System.Drawing.Size(64, 64)
        Me.bubbleBar1.ImageSizeNormal = New System.Drawing.Size(32, 32)
        Me.bubbleBar1.Location = New System.Drawing.Point(0, 555)
        Me.bubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.bubbleBar1.Name = "bubbleBar1"
        Me.bubbleBar1.SelectedTab = Me.bubbleBarTab1
        Me.bubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.bubbleBar1.Size = New System.Drawing.Size(918, 58)
        Me.bubbleBar1.TabIndex = 3
        Me.bubbleBar1.Tabs.Add(Me.bubbleBarTab1)
        Me.bubbleBar1.Text = "bubbleBar1"
        Me.bubbleBar1.TooltipFont = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bubbleBarTab1
        '
        Me.bubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.bubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.bubbleBarTab1.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.bubbleButton4, Me.bubbleButton1, Me.bubbleButton2, Me.bubbleButton5, Me.bubbleButton6, Me.bubbleButton7, Me.bubbleButton10, Me.bubbleButton8, Me.bubbleButton9})
        Me.bubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.bubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bubbleBarTab1.Name = "bubbleBarTab1"
        Me.bubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.bubbleBarTab1.Text = "Menu"
        Me.bubbleBarTab1.TextColor = System.Drawing.Color.Black
        '
        'bubbleButton4
        '
        Me.bubbleButton4.Image = CType(resources.GetObject("bubbleButton4.Image"), System.Drawing.Image)
        Me.bubbleButton4.ImageLarge = CType(resources.GetObject("bubbleButton4.ImageLarge"), System.Drawing.Image)
        Me.bubbleButton4.Name = "bubbleButton4"
        Me.bubbleButton4.TooltipText = "Pad"
        '
        'bubbleButton1
        '
        Me.bubbleButton1.Image = CType(resources.GetObject("bubbleButton1.Image"), System.Drawing.Image)
        Me.bubbleButton1.ImageLarge = CType(resources.GetObject("bubbleButton1.ImageLarge"), System.Drawing.Image)
        Me.bubbleButton1.Name = "bubbleButton1"
        Me.bubbleButton1.TooltipText = "Contacts"
        '
        'bubbleButton2
        '
        Me.bubbleButton2.Image = CType(resources.GetObject("bubbleButton2.Image"), System.Drawing.Image)
        Me.bubbleButton2.ImageLarge = CType(resources.GetObject("bubbleButton2.ImageLarge"), System.Drawing.Image)
        Me.bubbleButton2.Name = "bubbleButton2"
        Me.bubbleButton2.TooltipText = "IP Address Tracer"
        '
        'bubbleButton5
        '
        Me.bubbleButton5.Image = CType(resources.GetObject("bubbleButton5.Image"), System.Drawing.Image)
        Me.bubbleButton5.ImageLarge = CType(resources.GetObject("bubbleButton5.ImageLarge"), System.Drawing.Image)
        Me.bubbleButton5.Name = "bubbleButton5"
        Me.bubbleButton5.TooltipText = "Calculator"
        '
        'bubbleButton6
        '
        Me.bubbleButton6.Image = CType(resources.GetObject("bubbleButton6.Image"), System.Drawing.Image)
        Me.bubbleButton6.ImageLarge = CType(resources.GetObject("bubbleButton6.ImageLarge"), System.Drawing.Image)
        Me.bubbleButton6.Name = "bubbleButton6"
        Me.bubbleButton6.TooltipText = "Media"
        '
        'bubbleButton7
        '
        Me.bubbleButton7.Image = CType(resources.GetObject("bubbleButton7.Image"), System.Drawing.Image)
        Me.bubbleButton7.ImageLarge = CType(resources.GetObject("bubbleButton7.ImageLarge"), System.Drawing.Image)
        Me.bubbleButton7.Name = "bubbleButton7"
        Me.bubbleButton7.TooltipText = "Browse"
        '
        'bubbleButton10
        '
        Me.bubbleButton10.Image = CType(resources.GetObject("bubbleButton10.Image"), System.Drawing.Image)
        Me.bubbleButton10.ImageLarge = CType(resources.GetObject("bubbleButton10.ImageLarge"), System.Drawing.Image)
        Me.bubbleButton10.Name = "bubbleButton10"
        Me.bubbleButton10.TooltipText = "Game"
        '
        'bubbleButton8
        '
        Me.bubbleButton8.Image = CType(resources.GetObject("bubbleButton8.Image"), System.Drawing.Image)
        Me.bubbleButton8.ImageLarge = CType(resources.GetObject("bubbleButton8.ImageLarge"), System.Drawing.Image)
        Me.bubbleButton8.Name = "bubbleButton8"
        Me.bubbleButton8.TooltipText = "Shutdown"
        '
        'bubbleButton9
        '
        Me.bubbleButton9.Image = CType(resources.GetObject("bubbleButton9.Image"), System.Drawing.Image)
        Me.bubbleButton9.ImageLarge = CType(resources.GetObject("bubbleButton9.ImageLarge"), System.Drawing.Image)
        Me.bubbleButton9.Name = "bubbleButton9"
        Me.bubbleButton9.TooltipText = "About"
        '
        'PanelEx3
        '
        Me.PanelEx3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx3.Location = New System.Drawing.Point(918, 410)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(200, 37)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 12
        Me.PanelEx3.Text = "PERFORMANCE"
        '
        'Timer1
        '
        '
        'RAMcounter
        '
        Me.RAMcounter.CategoryName = "Memory"
        Me.RAMcounter.CounterName = "% Committed Bytes In Use"
        '
        'Timer2
        '
        '
        'CPUcounter
        '
        Me.CPUcounter.CategoryName = "Processor"
        Me.CPUcounter.CounterName = "% Processor Time"
        Me.CPUcounter.InstanceName = "_Total"
        '
        'Timer3
        '
        '
        'Desktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1118, 613)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx3)
        Me.Controls.Add(Me.bubbleBar1)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Desktop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RAMcounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CPUcounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AnalogClockControl1 As DevComponents.DotNetBar.Controls.AnalogClockControl
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lclock As System.Windows.Forms.Label
    Friend WithEvents bubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents bubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents bubbleButton4 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton1 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton2 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton5 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton6 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton7 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton10 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton8 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bubbleButton9 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents OSplatform As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OSversion As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Osystem As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents User As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ProgressBarX2 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cpuperfor As System.Windows.Forms.Label
    Friend WithEvents ramperf As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RAMcounter As System.Diagnostics.PerformanceCounter
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents CPUcounter As System.Diagnostics.PerformanceCounter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
End Class
