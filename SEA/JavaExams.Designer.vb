<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JavaExams
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JavaExams))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblQuest = New System.Windows.Forms.Label()
        Me.lblQnu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lastrecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.firstrecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.previouserecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.nextrecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 159)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(910, 270)
        Me.TextBox1.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(758, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Label4"
        '
        'lblQuest
        '
        Me.lblQuest.AutoSize = True
        Me.lblQuest.Location = New System.Drawing.Point(19, 36)
        Me.lblQuest.Name = "lblQuest"
        Me.lblQuest.Size = New System.Drawing.Size(39, 13)
        Me.lblQuest.TabIndex = 52
        Me.lblQuest.Text = "Label3"
        '
        'lblQnu
        '
        Me.lblQnu.AutoSize = True
        Me.lblQnu.Location = New System.Drawing.Point(19, 12)
        Me.lblQnu.Name = "lblQnu"
        Me.lblQnu.Size = New System.Drawing.Size(39, 13)
        Me.lblQnu.TabIndex = 51
        Me.lblQnu.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 46
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
        Me.lastrecord.Location = New System.Drawing.Point(671, 468)
        Me.lastrecord.Margin = New System.Windows.Forms.Padding(5)
        Me.lastrecord.Name = "lastrecord"
        Me.lastrecord.Size = New System.Drawing.Size(181, 41)
        Me.lastrecord.TabIndex = 125
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
        Me.firstrecord.Location = New System.Drawing.Point(12, 468)
        Me.firstrecord.Margin = New System.Windows.Forms.Padding(5)
        Me.firstrecord.Name = "firstrecord"
        Me.firstrecord.Size = New System.Drawing.Size(181, 41)
        Me.firstrecord.TabIndex = 124
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
        Me.previouserecord.Location = New System.Drawing.Point(460, 468)
        Me.previouserecord.Margin = New System.Windows.Forms.Padding(5)
        Me.previouserecord.Name = "previouserecord"
        Me.previouserecord.Size = New System.Drawing.Size(181, 41)
        Me.previouserecord.TabIndex = 123
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
        Me.nextrecord.Location = New System.Drawing.Point(230, 468)
        Me.nextrecord.Margin = New System.Windows.Forms.Padding(5)
        Me.nextrecord.Name = "nextrecord"
        Me.nextrecord.Size = New System.Drawing.Size(181, 41)
        Me.nextrecord.TabIndex = 122
        Me.nextrecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.lblQnu)
        Me.Panel1.Controls.Add(Me.lblQuest)
        Me.Panel1.Location = New System.Drawing.Point(8, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(922, 100)
        Me.Panel1.TabIndex = 126
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuCustomLabel2)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuImageButton2)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.SystemColors.MenuHighlight
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.SystemColors.MenuHighlight
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(934, 24)
        Me.BunifuGradientPanel2.TabIndex = 127
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(3, 5)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(149, 19)
        Me.BunifuCustomLabel2.TabIndex = 108
        Me.BunifuCustomLabel2.Text = "JAVA SUBJECTIVES"
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BunifuImageButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(911, -1)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(22, 24)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 107
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Label2"
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
        Me.BunifuThinButton21.Location = New System.Drawing.Point(460, 526)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(181, 41)
        Me.BunifuThinButton21.TabIndex = 131
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
        Me.BunifuThinButton22.ButtonText = "Section A"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.Black
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.Black
        Me.BunifuThinButton22.Location = New System.Drawing.Point(671, 526)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(181, 41)
        Me.BunifuThinButton22.TabIndex = 132
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(490, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Label1"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(177, 35)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(39, 13)
        Me.id.TabIndex = 134
        Me.id.Text = "Label5"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(668, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "ghu"
        '
        'JavaExams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(934, 577)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lastrecord)
        Me.Controls.Add(Me.firstrecord)
        Me.Controls.Add(Me.previouserecord)
        Me.Controls.Add(Me.nextrecord)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "JavaExams"
        Me.Text = "JavaExams"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblQuest As Label
    Friend WithEvents lblQnu As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lastrecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents firstrecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents previouserecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents nextrecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label3 As Label
    Friend WithEvents id As Label
    Friend WithEvents Label5 As Label
End Class
