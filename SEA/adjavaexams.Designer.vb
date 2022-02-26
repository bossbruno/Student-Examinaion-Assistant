<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adjavaexams
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adjavaexams))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblQuest = New System.Windows.Forms.Label()
        Me.lblQnu = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lastrecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.firstrecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.previouserecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.nextrecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox1.Location = New System.Drawing.Point(12, 213)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(840, 343)
        Me.TextBox1.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(748, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Label4"
        '
        'lblQuest
        '
        Me.lblQuest.AutoSize = True
        Me.lblQuest.Location = New System.Drawing.Point(48, 13)
        Me.lblQuest.Name = "lblQuest"
        Me.lblQuest.Size = New System.Drawing.Size(39, 13)
        Me.lblQuest.TabIndex = 78
        Me.lblQuest.Text = "Label3"
        '
        'lblQnu
        '
        Me.lblQnu.AutoSize = True
        Me.lblQnu.Location = New System.Drawing.Point(3, 13)
        Me.lblQnu.Name = "lblQnu"
        Me.lblQnu.Size = New System.Drawing.Size(39, 13)
        Me.lblQnu.TabIndex = 77
        Me.lblQnu.Text = "Label2"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.lblQnu)
        Me.Panel1.Controls.Add(Me.lblQuest)
        Me.Panel1.Location = New System.Drawing.Point(12, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(840, 134)
        Me.Panel1.TabIndex = 81
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
        Me.lastrecord.Location = New System.Drawing.Point(635, 564)
        Me.lastrecord.Margin = New System.Windows.Forms.Padding(5)
        Me.lastrecord.Name = "lastrecord"
        Me.lastrecord.Size = New System.Drawing.Size(181, 41)
        Me.lastrecord.TabIndex = 85
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
        Me.firstrecord.Location = New System.Drawing.Point(12, 564)
        Me.firstrecord.Margin = New System.Windows.Forms.Padding(5)
        Me.firstrecord.Name = "firstrecord"
        Me.firstrecord.Size = New System.Drawing.Size(181, 41)
        Me.firstrecord.TabIndex = 84
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
        Me.previouserecord.Location = New System.Drawing.Point(433, 564)
        Me.previouserecord.Margin = New System.Windows.Forms.Padding(5)
        Me.previouserecord.Name = "previouserecord"
        Me.previouserecord.Size = New System.Drawing.Size(181, 41)
        Me.previouserecord.TabIndex = 83
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
        Me.nextrecord.Location = New System.Drawing.Point(217, 564)
        Me.nextrecord.Margin = New System.Windows.Forms.Padding(5)
        Me.nextrecord.Name = "nextrecord"
        Me.nextrecord.Size = New System.Drawing.Size(181, 41)
        Me.nextrecord.TabIndex = 82
        Me.nextrecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuImageButton1)
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.MenuHighlight
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.MenuHighlight
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(-6, -7)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(981, 41)
        Me.BunifuGradientPanel1.TabIndex = 86
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(3, 16)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(242, 19)
        Me.BunifuCustomLabel1.TabIndex = 80
        Me.BunifuCustomLabel1.Text = "ADVANCED JAVA SUBJECTIVES"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(844, 9)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(22, 29)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 79
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
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
        Me.BunifuThinButton21.ButtonText = "Submit"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.Location = New System.Drawing.Point(433, 615)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(181, 41)
        Me.BunifuThinButton21.TabIndex = 132
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Label1"
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
        Me.BunifuThinButton22.ButtonText = "Section A"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.Black
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.Black
        Me.BunifuThinButton22.Location = New System.Drawing.Point(635, 615)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(181, 41)
        Me.BunifuThinButton22.TabIndex = 134
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(498, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Label1"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(214, 41)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(25, 13)
        Me.id.TabIndex = 136
        Me.id.Text = "041"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(653, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "rty"
        '
        'adjavaexams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(861, 658)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.lastrecord)
        Me.Controls.Add(Me.firstrecord)
        Me.Controls.Add(Me.previouserecord)
        Me.Controls.Add(Me.nextrecord)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adjavaexams"
        Me.Text = "adjavaexams"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblQuest As Label
    Friend WithEvents lblQnu As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lastrecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents firstrecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents previouserecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents nextrecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As Label
    Friend WithEvents id As Label
    Friend WithEvents Label3 As Label
End Class
