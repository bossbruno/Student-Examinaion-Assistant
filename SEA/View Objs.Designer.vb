<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Objs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(View_Objs))
        Me.rbnA = New System.Windows.Forms.RadioButton()
        Me.rbnB = New System.Windows.Forms.RadioButton()
        Me.rbnC = New System.Windows.Forms.RadioButton()
        Me.rbnD = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtans = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblQnu = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblQuest = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnview = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.nextrecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.previouserecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.firstrecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lastrecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbnA
        '
        Me.rbnA.AutoSize = True
        Me.rbnA.Location = New System.Drawing.Point(81, 342)
        Me.rbnA.Name = "rbnA"
        Me.rbnA.Size = New System.Drawing.Size(32, 17)
        Me.rbnA.TabIndex = 27
        Me.rbnA.TabStop = True
        Me.rbnA.Text = "A"
        Me.rbnA.UseVisualStyleBackColor = True
        '
        'rbnB
        '
        Me.rbnB.AutoSize = True
        Me.rbnB.Location = New System.Drawing.Point(161, 342)
        Me.rbnB.Name = "rbnB"
        Me.rbnB.Size = New System.Drawing.Size(32, 17)
        Me.rbnB.TabIndex = 28
        Me.rbnB.TabStop = True
        Me.rbnB.Text = "B"
        Me.rbnB.UseVisualStyleBackColor = True
        '
        'rbnC
        '
        Me.rbnC.AutoSize = True
        Me.rbnC.Location = New System.Drawing.Point(230, 342)
        Me.rbnC.Name = "rbnC"
        Me.rbnC.Size = New System.Drawing.Size(32, 17)
        Me.rbnC.TabIndex = 29
        Me.rbnC.TabStop = True
        Me.rbnC.Text = "C"
        Me.rbnC.UseVisualStyleBackColor = True
        '
        'rbnD
        '
        Me.rbnD.AutoSize = True
        Me.rbnD.Location = New System.Drawing.Point(297, 342)
        Me.rbnD.Name = "rbnD"
        Me.rbnD.Size = New System.Drawing.Size(33, 17)
        Me.rbnD.TabIndex = 30
        Me.rbnD.TabStop = True
        Me.rbnD.Text = "D"
        Me.rbnD.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(809, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "."
        '
        'txtans
        '
        Me.txtans.Location = New System.Drawing.Point(599, 144)
        Me.txtans.Name = "txtans"
        Me.txtans.Size = New System.Drawing.Size(191, 20)
        Me.txtans.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(551, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Answer"
        '
        'lblQnu
        '
        Me.lblQnu.AutoSize = True
        Me.lblQnu.Location = New System.Drawing.Point(19, 11)
        Me.lblQnu.Name = "lblQnu"
        Me.lblQnu.Size = New System.Drawing.Size(89, 13)
        Me.lblQnu.TabIndex = 40
        Me.lblQnu.Text = "Question Number"
        '
        'lblQuest
        '
        Me.lblQuest.AutoSize = True
        Me.lblQuest.Location = New System.Drawing.Point(110, 11)
        Me.lblQuest.Name = "lblQuest"
        Me.lblQuest.Size = New System.Drawing.Size(49, 13)
        Me.lblQuest.TabIndex = 41
        Me.lblQuest.Text = "Question"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"C++", "Java", "Visual Basic", "Advanced Java", "Advanced Visual Basic", "HTML"})
        Me.ComboBox1.Location = New System.Drawing.Point(39, 25)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(228, 33)
        Me.ComboBox1.TabIndex = 70
        Me.ComboBox1.Text = "Select Course"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.lblQnu)
        Me.Panel1.Controls.Add(Me.lblQuest)
        Me.Panel1.Controls.Add(Me.txtans)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(39, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 183)
        Me.Panel1.TabIndex = 71
        '
        'btnview
        '
        Me.btnview.ActiveBorderThickness = 1
        Me.btnview.ActiveCornerRadius = 20
        Me.btnview.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnview.ActiveForecolor = System.Drawing.Color.Black
        Me.btnview.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnview.BackColor = System.Drawing.Color.White
        Me.btnview.BackgroundImage = CType(resources.GetObject("btnview.BackgroundImage"), System.Drawing.Image)
        Me.btnview.ButtonText = "View Questions"
        Me.btnview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnview.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnview.ForeColor = System.Drawing.Color.Black
        Me.btnview.IdleBorderThickness = 1
        Me.btnview.IdleCornerRadius = 20
        Me.btnview.IdleFillColor = System.Drawing.Color.White
        Me.btnview.IdleForecolor = System.Drawing.Color.Black
        Me.btnview.IdleLineColor = System.Drawing.Color.Black
        Me.btnview.Location = New System.Drawing.Point(275, 25)
        Me.btnview.Margin = New System.Windows.Forms.Padding(5)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(181, 41)
        Me.btnview.TabIndex = 72
        Me.btnview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.nextrecord.Location = New System.Drawing.Point(254, 378)
        Me.nextrecord.Margin = New System.Windows.Forms.Padding(5)
        Me.nextrecord.Name = "nextrecord"
        Me.nextrecord.Size = New System.Drawing.Size(181, 41)
        Me.nextrecord.TabIndex = 73
        Me.nextrecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.previouserecord.Location = New System.Drawing.Point(470, 378)
        Me.previouserecord.Margin = New System.Windows.Forms.Padding(5)
        Me.previouserecord.Name = "previouserecord"
        Me.previouserecord.Size = New System.Drawing.Size(181, 41)
        Me.previouserecord.TabIndex = 74
        Me.previouserecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.firstrecord.Location = New System.Drawing.Point(49, 378)
        Me.firstrecord.Margin = New System.Windows.Forms.Padding(5)
        Me.firstrecord.Name = "firstrecord"
        Me.firstrecord.Size = New System.Drawing.Size(181, 41)
        Me.firstrecord.TabIndex = 75
        Me.firstrecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.lastrecord.Location = New System.Drawing.Point(672, 378)
        Me.lastrecord.Margin = New System.Windows.Forms.Padding(5)
        Me.lastrecord.Name = "lastrecord"
        Me.lastrecord.Size = New System.Drawing.Size(181, 41)
        Me.lastrecord.TabIndex = 76
        Me.lastrecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Objs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 450)
        Me.Controls.Add(Me.lastrecord)
        Me.Controls.Add(Me.firstrecord)
        Me.Controls.Add(Me.previouserecord)
        Me.Controls.Add(Me.nextrecord)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rbnD)
        Me.Controls.Add(Me.rbnC)
        Me.Controls.Add(Me.rbnB)
        Me.Controls.Add(Me.rbnA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "View_Objs"
        Me.Text = "View_Objs"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbnA As RadioButton
    Friend WithEvents rbnB As RadioButton
    Friend WithEvents rbnC As RadioButton
    Friend WithEvents rbnD As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txtans As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblQnu As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblQuest As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnview As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents nextrecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents previouserecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents firstrecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lastrecord As Bunifu.Framework.UI.BunifuThinButton2
End Class
