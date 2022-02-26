<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class advbexams
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(advbexams))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblQuest = New System.Windows.Forms.Label()
        Me.lblQnu = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.lastrecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.firstrecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.previouserecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.nextrecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 196)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(843, 291)
        Me.TextBox1.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(750, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Label4"
        '
        'lblQuest
        '
        Me.lblQuest.AutoSize = True
        Me.lblQuest.Location = New System.Drawing.Point(50, 19)
        Me.lblQuest.Name = "lblQuest"
        Me.lblQuest.Size = New System.Drawing.Size(39, 13)
        Me.lblQuest.TabIndex = 70
        Me.lblQuest.Text = "Label3"
        '
        'lblQnu
        '
        Me.lblQnu.AutoSize = True
        Me.lblQnu.Location = New System.Drawing.Point(5, 19)
        Me.lblQnu.Name = "lblQnu"
        Me.lblQnu.Size = New System.Drawing.Size(39, 13)
        Me.lblQnu.TabIndex = 69
        Me.lblQnu.Text = "Label2"
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuImageButton1)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.MenuHighlight
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.MenuHighlight
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-2, -2)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(873, 27)
        Me.BunifuGradientPanel1.TabIndex = 73
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(3, 8)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(300, 19)
        Me.BunifuCustomLabel1.TabIndex = 118
        Me.BunifuCustomLabel1.Text = "ADVANCED VISUAL BASIC SUBJECTIVES"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(838, -1)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(22, 36)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 75
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblQnu)
        Me.Panel1.Controls.Add(Me.lblQuest)
        Me.Panel1.Location = New System.Drawing.Point(6, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 120)
        Me.Panel1.TabIndex = 74
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'lastrecord
        '
        Me.lastrecord.ActiveBorderThickness = 1
        Me.lastrecord.ActiveCornerRadius = 20
        Me.lastrecord.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight
        Me.lastrecord.ActiveForecolor = System.Drawing.Color.Black
        Me.lastrecord.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lastrecord.BackColor = System.Drawing.Color.White
        Me.lastrecord.BackgroundImage = CType(resources.GetObject("lastrecord.BackgroundImage"), System.Drawing.Image)
        Me.lastrecord.ButtonText = "Last Question"
        Me.lastrecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lastrecord.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastrecord.ForeColor = System.Drawing.Color.Black
        Me.lastrecord.IdleBorderThickness = 1
        Me.lastrecord.IdleCornerRadius = 20
        Me.lastrecord.IdleFillColor = System.Drawing.Color.White
        Me.lastrecord.IdleForecolor = System.Drawing.Color.Black
        Me.lastrecord.IdleLineColor = System.Drawing.Color.Black
        Me.lastrecord.Location = New System.Drawing.Point(671, 495)
        Me.lastrecord.Margin = New System.Windows.Forms.Padding(5)
        Me.lastrecord.Name = "lastrecord"
        Me.lastrecord.Size = New System.Drawing.Size(181, 41)
        Me.lastrecord.TabIndex = 117
        Me.lastrecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'firstrecord
        '
        Me.firstrecord.ActiveBorderThickness = 1
        Me.firstrecord.ActiveCornerRadius = 20
        Me.firstrecord.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight
        Me.firstrecord.ActiveForecolor = System.Drawing.Color.Black
        Me.firstrecord.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.firstrecord.BackColor = System.Drawing.Color.White
        Me.firstrecord.BackgroundImage = CType(resources.GetObject("firstrecord.BackgroundImage"), System.Drawing.Image)
        Me.firstrecord.ButtonText = "First Question"
        Me.firstrecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.firstrecord.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstrecord.ForeColor = System.Drawing.Color.Black
        Me.firstrecord.IdleBorderThickness = 1
        Me.firstrecord.IdleCornerRadius = 20
        Me.firstrecord.IdleFillColor = System.Drawing.Color.White
        Me.firstrecord.IdleForecolor = System.Drawing.Color.Black
        Me.firstrecord.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.firstrecord.Location = New System.Drawing.Point(48, 495)
        Me.firstrecord.Margin = New System.Windows.Forms.Padding(5)
        Me.firstrecord.Name = "firstrecord"
        Me.firstrecord.Size = New System.Drawing.Size(181, 41)
        Me.firstrecord.TabIndex = 116
        Me.firstrecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'previouserecord
        '
        Me.previouserecord.ActiveBorderThickness = 1
        Me.previouserecord.ActiveCornerRadius = 20
        Me.previouserecord.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight
        Me.previouserecord.ActiveForecolor = System.Drawing.Color.Black
        Me.previouserecord.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.previouserecord.BackColor = System.Drawing.Color.White
        Me.previouserecord.BackgroundImage = CType(resources.GetObject("previouserecord.BackgroundImage"), System.Drawing.Image)
        Me.previouserecord.ButtonText = "Previous Question"
        Me.previouserecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.previouserecord.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previouserecord.ForeColor = System.Drawing.Color.Black
        Me.previouserecord.IdleBorderThickness = 1
        Me.previouserecord.IdleCornerRadius = 20
        Me.previouserecord.IdleFillColor = System.Drawing.Color.White
        Me.previouserecord.IdleForecolor = System.Drawing.Color.Black
        Me.previouserecord.IdleLineColor = System.Drawing.Color.Black
        Me.previouserecord.Location = New System.Drawing.Point(469, 495)
        Me.previouserecord.Margin = New System.Windows.Forms.Padding(5)
        Me.previouserecord.Name = "previouserecord"
        Me.previouserecord.Size = New System.Drawing.Size(181, 41)
        Me.previouserecord.TabIndex = 115
        Me.previouserecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nextrecord
        '
        Me.nextrecord.ActiveBorderThickness = 1
        Me.nextrecord.ActiveCornerRadius = 20
        Me.nextrecord.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight
        Me.nextrecord.ActiveForecolor = System.Drawing.Color.Black
        Me.nextrecord.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nextrecord.BackColor = System.Drawing.Color.White
        Me.nextrecord.BackgroundImage = CType(resources.GetObject("nextrecord.BackgroundImage"), System.Drawing.Image)
        Me.nextrecord.ButtonText = "Next Question"
        Me.nextrecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nextrecord.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextrecord.ForeColor = System.Drawing.Color.Black
        Me.nextrecord.IdleBorderThickness = 1
        Me.nextrecord.IdleCornerRadius = 20
        Me.nextrecord.IdleFillColor = System.Drawing.Color.White
        Me.nextrecord.IdleForecolor = System.Drawing.Color.Black
        Me.nextrecord.IdleLineColor = System.Drawing.Color.Black
        Me.nextrecord.Location = New System.Drawing.Point(253, 495)
        Me.nextrecord.Margin = New System.Windows.Forms.Padding(5)
        Me.nextrecord.Name = "nextrecord"
        Me.nextrecord.Size = New System.Drawing.Size(181, 41)
        Me.nextrecord.TabIndex = 114
        Me.nextrecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Section A"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.Location = New System.Drawing.Point(671, 546)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(181, 41)
        Me.BunifuThinButton21.TabIndex = 130
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Submit"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.Black
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.Black
        Me.BunifuThinButton22.Location = New System.Drawing.Point(469, 547)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(181, 41)
        Me.BunifuThinButton22.TabIndex = 131
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(452, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "Label1"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(223, 40)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(39, 13)
        Me.id.TabIndex = 134
        Me.id.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(688, -49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "gh"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(668, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 141
        Me.Label5.Text = "ghf"
        '
        'advbexams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(870, 602)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.lastrecord)
        Me.Controls.Add(Me.firstrecord)
        Me.Controls.Add(Me.previouserecord)
        Me.Controls.Add(Me.nextrecord)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "advbexams"
        Me.Text = "advbexams"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblQuest As Label
    Friend WithEvents lblQnu As Label
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lastrecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents firstrecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents previouserecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents nextrecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents id As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
End Class
