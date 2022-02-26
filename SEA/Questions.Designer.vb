<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Questions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Questions))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnview = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lastrecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.firstrecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.previouserecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.nextrecord = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(619, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Label4"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"C++", "Java", "Visual Basic", "Advanced Java", "Advanced Visual Basic", "HTML"})
        Me.ComboBox1.Location = New System.Drawing.Point(43, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(228, 33)
        Me.ComboBox1.TabIndex = 71
        Me.ComboBox1.Text = "Select Course"
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
        Me.btnview.Location = New System.Drawing.Point(290, 12)
        Me.btnview.Margin = New System.Windows.Forms.Padding(5)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(181, 41)
        Me.btnview.TabIndex = 73
        Me.btnview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.lastrecord.Location = New System.Drawing.Point(640, 350)
        Me.lastrecord.Margin = New System.Windows.Forms.Padding(5)
        Me.lastrecord.Name = "lastrecord"
        Me.lastrecord.Size = New System.Drawing.Size(181, 41)
        Me.lastrecord.TabIndex = 80
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
        Me.firstrecord.Location = New System.Drawing.Point(17, 350)
        Me.firstrecord.Margin = New System.Windows.Forms.Padding(5)
        Me.firstrecord.Name = "firstrecord"
        Me.firstrecord.Size = New System.Drawing.Size(181, 41)
        Me.firstrecord.TabIndex = 79
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
        Me.previouserecord.Location = New System.Drawing.Point(438, 350)
        Me.previouserecord.Margin = New System.Windows.Forms.Padding(5)
        Me.previouserecord.Name = "previouserecord"
        Me.previouserecord.Size = New System.Drawing.Size(181, 41)
        Me.previouserecord.TabIndex = 78
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
        Me.nextrecord.Location = New System.Drawing.Point(222, 350)
        Me.nextrecord.Margin = New System.Windows.Forms.Padding(5)
        Me.nextrecord.Name = "nextrecord"
        Me.nextrecord.Size = New System.Drawing.Size(181, 41)
        Me.nextrecord.TabIndex = 77
        Me.nextrecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(23, 154)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(769, 170)
        Me.Panel1.TabIndex = 81
        '
        'Questions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(826, 420)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lastrecord)
        Me.Controls.Add(Me.firstrecord)
        Me.Controls.Add(Me.previouserecord)
        Me.Controls.Add(Me.nextrecord)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Questions"
        Me.Text = "Questions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnview As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lastrecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents firstrecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents previouserecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents nextrecord As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel1 As Panel
End Class
