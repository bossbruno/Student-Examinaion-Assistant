<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Section_A
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Section_A))
        Me.txtQuest = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnSave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btndel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuImageButton6 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtA = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton7 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton8 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtB = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtD = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtC = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuImageButton5 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtans = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtNumb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txttime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtQuest
        '
        Me.txtQuest.Location = New System.Drawing.Point(7, 73)
        Me.txtQuest.Multiline = True
        Me.txtQuest.Name = "txtQuest"
        Me.txtQuest.Size = New System.Drawing.Size(840, 233)
        Me.txtQuest.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 19)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Question"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
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
        Me.btnSave.Location = New System.Drawing.Point(41, 526)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(181, 41)
        Me.btnSave.TabIndex = 82
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
        Me.btndel.Location = New System.Drawing.Point(523, 526)
        Me.btndel.Margin = New System.Windows.Forms.Padding(5)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(181, 41)
        Me.btndel.TabIndex = 80
        Me.btndel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuImageButton6
        '
        Me.BunifuImageButton6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton6.Image = CType(resources.GetObject("BunifuImageButton6.Image"), System.Drawing.Image)
        Me.BunifuImageButton6.ImageActive = Nothing
        Me.BunifuImageButton6.Location = New System.Drawing.Point(325, 318)
        Me.BunifuImageButton6.Name = "BunifuImageButton6"
        Me.BunifuImageButton6.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton6.TabIndex = 93
        Me.BunifuImageButton6.TabStop = False
        Me.BunifuImageButton6.Zoom = 10
        '
        'txtA
        '
        Me.txtA.BackColor = System.Drawing.Color.White
        Me.txtA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtA.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtA.ForeColor = System.Drawing.Color.Black
        Me.txtA.HintForeColor = System.Drawing.Color.Black
        Me.txtA.HintText = "Enter Answer A"
        Me.txtA.isPassword = False
        Me.txtA.LineFocusedColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtA.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtA.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtA.LineThickness = 3
        Me.txtA.Location = New System.Drawing.Point(19, 318)
        Me.txtA.Margin = New System.Windows.Forms.Padding(4)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(331, 33)
        Me.txtA.TabIndex = 87
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton4.Image = CType(resources.GetObject("BunifuImageButton4.Image"), System.Drawing.Image)
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(325, 438)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton4.TabIndex = 91
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 10
        '
        'BunifuImageButton7
        '
        Me.BunifuImageButton7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton7.Image = CType(resources.GetObject("BunifuImageButton7.Image"), System.Drawing.Image)
        Me.BunifuImageButton7.ImageActive = Nothing
        Me.BunifuImageButton7.Location = New System.Drawing.Point(325, 399)
        Me.BunifuImageButton7.Name = "BunifuImageButton7"
        Me.BunifuImageButton7.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton7.TabIndex = 90
        Me.BunifuImageButton7.TabStop = False
        Me.BunifuImageButton7.Zoom = 10
        '
        'BunifuImageButton8
        '
        Me.BunifuImageButton8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton8.Image = CType(resources.GetObject("BunifuImageButton8.Image"), System.Drawing.Image)
        Me.BunifuImageButton8.ImageActive = Nothing
        Me.BunifuImageButton8.Location = New System.Drawing.Point(325, 358)
        Me.BunifuImageButton8.Name = "BunifuImageButton8"
        Me.BunifuImageButton8.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton8.TabIndex = 89
        Me.BunifuImageButton8.TabStop = False
        Me.BunifuImageButton8.Zoom = 10
        '
        'txtB
        '
        Me.txtB.BackColor = System.Drawing.Color.White
        Me.txtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtB.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtB.ForeColor = System.Drawing.Color.Black
        Me.txtB.HintForeColor = System.Drawing.Color.Black
        Me.txtB.HintText = "Enter Answer B"
        Me.txtB.isPassword = False
        Me.txtB.LineFocusedColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtB.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtB.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtB.LineThickness = 3
        Me.txtB.Location = New System.Drawing.Point(19, 359)
        Me.txtB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(331, 33)
        Me.txtB.TabIndex = 85
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtD
        '
        Me.txtD.BackColor = System.Drawing.Color.White
        Me.txtD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtD.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtD.ForeColor = System.Drawing.Color.Black
        Me.txtD.HintForeColor = System.Drawing.Color.Black
        Me.txtD.HintText = "Enter Answer D"
        Me.txtD.isPassword = False
        Me.txtD.LineFocusedColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtD.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtD.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtD.LineThickness = 3
        Me.txtD.Location = New System.Drawing.Point(19, 441)
        Me.txtD.Margin = New System.Windows.Forms.Padding(4)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(331, 33)
        Me.txtD.TabIndex = 83
        Me.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtC
        '
        Me.txtC.BackColor = System.Drawing.Color.White
        Me.txtC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtC.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtC.ForeColor = System.Drawing.Color.Black
        Me.txtC.HintForeColor = System.Drawing.Color.Black
        Me.txtC.HintText = "Enter Answer C"
        Me.txtC.isPassword = False
        Me.txtC.LineFocusedColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtC.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtC.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtC.LineThickness = 3
        Me.txtC.Location = New System.Drawing.Point(19, 400)
        Me.txtC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(331, 33)
        Me.txtC.TabIndex = 84
        Me.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuImageButton5
        '
        Me.BunifuImageButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton5.Image = CType(resources.GetObject("BunifuImageButton5.Image"), System.Drawing.Image)
        Me.BunifuImageButton5.ImageActive = Nothing
        Me.BunifuImageButton5.Location = New System.Drawing.Point(741, 391)
        Me.BunifuImageButton5.Name = "BunifuImageButton5"
        Me.BunifuImageButton5.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton5.TabIndex = 92
        Me.BunifuImageButton5.TabStop = False
        Me.BunifuImageButton5.Zoom = 10
        '
        'txtans
        '
        Me.txtans.BackColor = System.Drawing.Color.White
        Me.txtans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtans.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtans.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtans.ForeColor = System.Drawing.Color.Black
        Me.txtans.HintForeColor = System.Drawing.Color.Black
        Me.txtans.HintText = "Enter Right Answer"
        Me.txtans.isPassword = False
        Me.txtans.LineFocusedColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtans.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtans.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtans.LineThickness = 3
        Me.txtans.Location = New System.Drawing.Point(435, 391)
        Me.txtans.Margin = New System.Windows.Forms.Padding(4)
        Me.txtans.Name = "txtans"
        Me.txtans.Size = New System.Drawing.Size(331, 33)
        Me.txtans.TabIndex = 86
        Me.txtans.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"C++", "Java", "Visual Basic", "Advanced Java", "Advanced Visual Basic", "HTML"})
        Me.ComboBox1.Location = New System.Drawing.Point(691, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(166, 31)
        Me.ComboBox1.TabIndex = 94
        Me.ComboBox1.Text = "SELECT COURSE"
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(308, 12)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 96
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'txtNumb
        '
        Me.txtNumb.BackColor = System.Drawing.Color.White
        Me.txtNumb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumb.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNumb.ForeColor = System.Drawing.Color.Black
        Me.txtNumb.HintForeColor = System.Drawing.Color.Black
        Me.txtNumb.HintText = "Enter Question Number"
        Me.txtNumb.isPassword = False
        Me.txtNumb.LineFocusedColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNumb.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtNumb.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtNumb.LineThickness = 3
        Me.txtNumb.Location = New System.Drawing.Point(2, 13)
        Me.txtNumb.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumb.Name = "txtNumb"
        Me.txtNumb.Size = New System.Drawing.Size(331, 33)
        Me.txtNumb.TabIndex = 95
        Me.txtNumb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txttime
        '
        Me.txttime.Location = New System.Drawing.Point(583, 17)
        Me.txttime.Multiline = True
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(102, 23)
        Me.txttime.TabIndex = 101
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(330, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 19)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Input Time once, in minutes."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(340, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Label1"
        '
        'Section_A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(859, 636)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttime)
        Me.Controls.Add(Me.BunifuImageButton3)
        Me.Controls.Add(Me.txtNumb)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BunifuImageButton6)
        Me.Controls.Add(Me.BunifuImageButton5)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.BunifuImageButton4)
        Me.Controls.Add(Me.BunifuImageButton7)
        Me.Controls.Add(Me.txtans)
        Me.Controls.Add(Me.BunifuImageButton8)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQuest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Section_A"
        Me.Text = "Section_A"
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtQuest As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btndel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuImageButton6 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtA As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton7 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton8 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtB As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtD As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtC As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuImageButton5 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtans As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtNumb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txttime As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
