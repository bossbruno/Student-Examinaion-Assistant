<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetQuestions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetQuestions))
        Me.txtquestion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btndel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnclear = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtNumber = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttime = New System.Windows.Forms.TextBox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtquestion
        '
        Me.txtquestion.Location = New System.Drawing.Point(12, 141)
        Me.txtquestion.Multiline = True
        Me.txtquestion.Name = "txtquestion"
        Me.txtquestion.Size = New System.Drawing.Size(830, 331)
        Me.txtquestion.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Input Question Below"
        '
        'btnSave
        '
        Me.btnSave.ActiveBorderThickness = 1
        Me.btnSave.ActiveCornerRadius = 20
        Me.btnSave.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSave.ActiveForecolor = System.Drawing.Color.Black
        Me.btnSave.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.ButtonText = "SAVE"
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.IdleBorderThickness = 1
        Me.btnSave.IdleCornerRadius = 20
        Me.btnSave.IdleFillColor = System.Drawing.Color.White
        Me.btnSave.IdleForecolor = System.Drawing.Color.Black
        Me.btnSave.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.Location = New System.Drawing.Point(12, 513)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(181, 41)
        Me.btnSave.TabIndex = 84
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btndel
        '
        Me.btndel.ActiveBorderThickness = 1
        Me.btndel.ActiveCornerRadius = 20
        Me.btndel.ActiveFillColor = System.Drawing.Color.Red
        Me.btndel.ActiveForecolor = System.Drawing.Color.Black
        Me.btndel.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndel.BackColor = System.Drawing.Color.White
        Me.btndel.BackgroundImage = CType(resources.GetObject("btndel.BackgroundImage"), System.Drawing.Image)
        Me.btndel.ButtonText = "DELETE"
        Me.btndel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.ForeColor = System.Drawing.Color.Black
        Me.btndel.IdleBorderThickness = 1
        Me.btndel.IdleCornerRadius = 20
        Me.btndel.IdleFillColor = System.Drawing.Color.White
        Me.btndel.IdleForecolor = System.Drawing.Color.Black
        Me.btndel.IdleLineColor = System.Drawing.Color.Black
        Me.btndel.Location = New System.Drawing.Point(227, 513)
        Me.btndel.Margin = New System.Windows.Forms.Padding(5)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(181, 41)
        Me.btndel.TabIndex = 83
        Me.btndel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnclear
        '
        Me.btnclear.ActiveBorderThickness = 1
        Me.btnclear.ActiveCornerRadius = 20
        Me.btnclear.ActiveFillColor = System.Drawing.Color.Turquoise
        Me.btnclear.ActiveForecolor = System.Drawing.Color.Black
        Me.btnclear.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnclear.BackColor = System.Drawing.Color.White
        Me.btnclear.BackgroundImage = CType(resources.GetObject("btnclear.BackgroundImage"), System.Drawing.Image)
        Me.btnclear.ButtonText = "CLEAR"
        Me.btnclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.Black
        Me.btnclear.IdleBorderThickness = 1
        Me.btnclear.IdleCornerRadius = 20
        Me.btnclear.IdleFillColor = System.Drawing.Color.White
        Me.btnclear.IdleForecolor = System.Drawing.Color.Black
        Me.btnclear.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnclear.Location = New System.Drawing.Point(661, 513)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(5)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(181, 41)
        Me.btnclear.TabIndex = 85
        Me.btnclear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"C++", "Java", "Visual Basic", "Advanced Java", "Advanced Visual Basic", "HTML"})
        Me.ComboBox1.Location = New System.Drawing.Point(704, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(166, 31)
        Me.ComboBox1.TabIndex = 95
        Me.ComboBox1.Text = "SELECT COURSE"
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(313, 1)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 98
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'txtNumber
        '
        Me.txtNumber.BackColor = System.Drawing.Color.White
        Me.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNumber.ForeColor = System.Drawing.Color.Black
        Me.txtNumber.HintForeColor = System.Drawing.Color.Black
        Me.txtNumber.HintText = "Enter Question Number"
        Me.txtNumber.isPassword = False
        Me.txtNumber.LineFocusedColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNumber.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtNumber.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtNumber.LineThickness = 3
        Me.txtNumber.Location = New System.Drawing.Point(7, 2)
        Me.txtNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(331, 33)
        Me.txtNumber.TabIndex = 97
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(344, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 19)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Input Time once, in minutes."
        '
        'txttime
        '
        Me.txttime.Location = New System.Drawing.Point(596, 12)
        Me.txttime.Multiline = True
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(102, 23)
        Me.txttime.TabIndex = 103
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.Red
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "UPDATE"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.Black
        Me.BunifuThinButton21.Location = New System.Drawing.Point(433, 513)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(181, 41)
        Me.BunifuThinButton21.TabIndex = 105
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Label2"
        '
        'SetQuestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(878, 587)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttime)
        Me.Controls.Add(Me.BunifuImageButton3)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtquestion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SetQuestions"
        Me.Text = "SetQuestions"
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtquestion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btndel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnclear As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtNumber As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents txttime As TextBox
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label2 As Label
End Class
