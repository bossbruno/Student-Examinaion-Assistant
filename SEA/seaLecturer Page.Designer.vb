<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Form))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GrpStudent = New System.Windows.Forms.GroupBox()
        Me.BunifuImageButton9 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtscoreb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnStuDel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuImageButton8 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtScore = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuImageButton7 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtCID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnStupdate = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnStSave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuImageButton6 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton5 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtStun = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtStuPass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtStname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtStid = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtClass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpStudent.SuspendLayout()
        CType(Me.BunifuImageButton9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(381, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(896, 329)
        Me.DataGridView1.TabIndex = 2
        '
        'GrpStudent
        '
        Me.GrpStudent.Controls.Add(Me.BunifuImageButton9)
        Me.GrpStudent.Controls.Add(Me.txtscoreb)
        Me.GrpStudent.Controls.Add(Me.btnStuDel)
        Me.GrpStudent.Controls.Add(Me.BunifuImageButton8)
        Me.GrpStudent.Controls.Add(Me.txtScore)
        Me.GrpStudent.Controls.Add(Me.BunifuImageButton7)
        Me.GrpStudent.Controls.Add(Me.txtCID)
        Me.GrpStudent.Controls.Add(Me.btnStupdate)
        Me.GrpStudent.Controls.Add(Me.btnStSave)
        Me.GrpStudent.Controls.Add(Me.BunifuImageButton6)
        Me.GrpStudent.Controls.Add(Me.BunifuImageButton5)
        Me.GrpStudent.Controls.Add(Me.txtStun)
        Me.GrpStudent.Controls.Add(Me.BunifuImageButton4)
        Me.GrpStudent.Controls.Add(Me.BunifuImageButton1)
        Me.GrpStudent.Controls.Add(Me.BunifuImageButton3)
        Me.GrpStudent.Controls.Add(Me.txtStuPass)
        Me.GrpStudent.Controls.Add(Me.BunifuImageButton2)
        Me.GrpStudent.Controls.Add(Me.txtStname)
        Me.GrpStudent.Controls.Add(Me.txtStid)
        Me.GrpStudent.Controls.Add(Me.txtClass)
        Me.GrpStudent.Font = New System.Drawing.Font("Impact", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpStudent.Location = New System.Drawing.Point(12, 49)
        Me.GrpStudent.Name = "GrpStudent"
        Me.GrpStudent.Size = New System.Drawing.Size(363, 457)
        Me.GrpStudent.TabIndex = 26
        Me.GrpStudent.TabStop = False
        Me.GrpStudent.Text = "EDIT STUDENT TABLE"
        '
        'BunifuImageButton9
        '
        Me.BunifuImageButton9.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton9.Image = CType(resources.GetObject("BunifuImageButton9.Image"), System.Drawing.Image)
        Me.BunifuImageButton9.ImageActive = Nothing
        Me.BunifuImageButton9.Location = New System.Drawing.Point(321, 306)
        Me.BunifuImageButton9.Name = "BunifuImageButton9"
        Me.BunifuImageButton9.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton9.TabIndex = 53
        Me.BunifuImageButton9.TabStop = False
        Me.BunifuImageButton9.Zoom = 10
        '
        'txtscoreb
        '
        Me.txtscoreb.BackColor = System.Drawing.Color.White
        Me.txtscoreb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtscoreb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtscoreb.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtscoreb.ForeColor = System.Drawing.Color.Black
        Me.txtscoreb.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtscoreb.HintText = "Enter Student ScoreB"
        Me.txtscoreb.isPassword = False
        Me.txtscoreb.LineFocusedColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtscoreb.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtscoreb.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtscoreb.LineThickness = 3
        Me.txtscoreb.Location = New System.Drawing.Point(15, 306)
        Me.txtscoreb.Margin = New System.Windows.Forms.Padding(4)
        Me.txtscoreb.Name = "txtscoreb"
        Me.txtscoreb.Size = New System.Drawing.Size(331, 33)
        Me.txtscoreb.TabIndex = 52
        Me.txtscoreb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnStuDel
        '
        Me.btnStuDel.ActiveBorderThickness = 1
        Me.btnStuDel.ActiveCornerRadius = 20
        Me.btnStuDel.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnStuDel.ActiveForecolor = System.Drawing.Color.White
        Me.btnStuDel.ActiveLineColor = System.Drawing.Color.White
        Me.btnStuDel.BackColor = System.Drawing.SystemColors.Control
        Me.btnStuDel.BackgroundImage = CType(resources.GetObject("btnStuDel.BackgroundImage"), System.Drawing.Image)
        Me.btnStuDel.ButtonText = "Delete Student Details"
        Me.btnStuDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStuDel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStuDel.ForeColor = System.Drawing.Color.Black
        Me.btnStuDel.IdleBorderThickness = 1
        Me.btnStuDel.IdleCornerRadius = 20
        Me.btnStuDel.IdleFillColor = System.Drawing.Color.Black
        Me.btnStuDel.IdleForecolor = System.Drawing.Color.White
        Me.btnStuDel.IdleLineColor = System.Drawing.Color.White
        Me.btnStuDel.Location = New System.Drawing.Point(37, 408)
        Me.btnStuDel.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.btnStuDel.Name = "btnStuDel"
        Me.btnStuDel.Size = New System.Drawing.Size(280, 39)
        Me.btnStuDel.TabIndex = 32
        Me.btnStuDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuImageButton8
        '
        Me.BunifuImageButton8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton8.Image = CType(resources.GetObject("BunifuImageButton8.Image"), System.Drawing.Image)
        Me.BunifuImageButton8.ImageActive = Nothing
        Me.BunifuImageButton8.Location = New System.Drawing.Point(321, 266)
        Me.BunifuImageButton8.Name = "BunifuImageButton8"
        Me.BunifuImageButton8.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton8.TabIndex = 51
        Me.BunifuImageButton8.TabStop = False
        Me.BunifuImageButton8.Zoom = 10
        '
        'txtScore
        '
        Me.txtScore.BackColor = System.Drawing.Color.White
        Me.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtScore.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtScore.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtScore.ForeColor = System.Drawing.Color.Black
        Me.txtScore.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtScore.HintText = "Enter Student ScoreA"
        Me.txtScore.isPassword = False
        Me.txtScore.LineFocusedColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtScore.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtScore.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtScore.LineThickness = 3
        Me.txtScore.Location = New System.Drawing.Point(15, 266)
        Me.txtScore.Margin = New System.Windows.Forms.Padding(4)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(331, 33)
        Me.txtScore.TabIndex = 50
        Me.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuImageButton7
        '
        Me.BunifuImageButton7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton7.Image = CType(resources.GetObject("BunifuImageButton7.Image"), System.Drawing.Image)
        Me.BunifuImageButton7.ImageActive = Nothing
        Me.BunifuImageButton7.Location = New System.Drawing.Point(322, 225)
        Me.BunifuImageButton7.Name = "BunifuImageButton7"
        Me.BunifuImageButton7.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton7.TabIndex = 49
        Me.BunifuImageButton7.TabStop = False
        Me.BunifuImageButton7.Zoom = 10
        '
        'txtCID
        '
        Me.txtCID.BackColor = System.Drawing.Color.White
        Me.txtCID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCID.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCID.ForeColor = System.Drawing.Color.Black
        Me.txtCID.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCID.HintText = "Enter StudentCourse ID"
        Me.txtCID.isPassword = False
        Me.txtCID.LineFocusedColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCID.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtCID.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtCID.LineThickness = 3
        Me.txtCID.Location = New System.Drawing.Point(16, 225)
        Me.txtCID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCID.Name = "txtCID"
        Me.txtCID.Size = New System.Drawing.Size(331, 33)
        Me.txtCID.TabIndex = 48
        Me.txtCID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnStupdate
        '
        Me.btnStupdate.ActiveBorderThickness = 1
        Me.btnStupdate.ActiveCornerRadius = 20
        Me.btnStupdate.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnStupdate.ActiveForecolor = System.Drawing.Color.White
        Me.btnStupdate.ActiveLineColor = System.Drawing.Color.White
        Me.btnStupdate.BackColor = System.Drawing.SystemColors.Control
        Me.btnStupdate.BackgroundImage = CType(resources.GetObject("btnStupdate.BackgroundImage"), System.Drawing.Image)
        Me.btnStupdate.ButtonText = "Update"
        Me.btnStupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStupdate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStupdate.ForeColor = System.Drawing.Color.Black
        Me.btnStupdate.IdleBorderThickness = 1
        Me.btnStupdate.IdleCornerRadius = 20
        Me.btnStupdate.IdleFillColor = System.Drawing.Color.Black
        Me.btnStupdate.IdleForecolor = System.Drawing.Color.White
        Me.btnStupdate.IdleLineColor = System.Drawing.Color.White
        Me.btnStupdate.Location = New System.Drawing.Point(245, 354)
        Me.btnStupdate.Margin = New System.Windows.Forms.Padding(7)
        Me.btnStupdate.Name = "btnStupdate"
        Me.btnStupdate.Size = New System.Drawing.Size(96, 39)
        Me.btnStupdate.TabIndex = 46
        Me.btnStupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStSave
        '
        Me.btnStSave.ActiveBorderThickness = 1
        Me.btnStSave.ActiveCornerRadius = 20
        Me.btnStSave.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnStSave.ActiveForecolor = System.Drawing.Color.White
        Me.btnStSave.ActiveLineColor = System.Drawing.Color.White
        Me.btnStSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnStSave.BackgroundImage = CType(resources.GetObject("btnStSave.BackgroundImage"), System.Drawing.Image)
        Me.btnStSave.ButtonText = "Save"
        Me.btnStSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStSave.ForeColor = System.Drawing.Color.Black
        Me.btnStSave.IdleBorderThickness = 1
        Me.btnStSave.IdleCornerRadius = 20
        Me.btnStSave.IdleFillColor = System.Drawing.Color.Black
        Me.btnStSave.IdleForecolor = System.Drawing.Color.White
        Me.btnStSave.IdleLineColor = System.Drawing.Color.White
        Me.btnStSave.Location = New System.Drawing.Point(9, 354)
        Me.btnStSave.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.btnStSave.Name = "btnStSave"
        Me.btnStSave.Size = New System.Drawing.Size(83, 39)
        Me.btnStSave.TabIndex = 47
        Me.btnStSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuImageButton6
        '
        Me.BunifuImageButton6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton6.Image = CType(resources.GetObject("BunifuImageButton6.Image"), System.Drawing.Image)
        Me.BunifuImageButton6.ImageActive = Nothing
        Me.BunifuImageButton6.Location = New System.Drawing.Point(324, 19)
        Me.BunifuImageButton6.Name = "BunifuImageButton6"
        Me.BunifuImageButton6.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton6.TabIndex = 45
        Me.BunifuImageButton6.TabStop = False
        Me.BunifuImageButton6.Zoom = 10
        '
        'BunifuImageButton5
        '
        Me.BunifuImageButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton5.Image = CType(resources.GetObject("BunifuImageButton5.Image"), System.Drawing.Image)
        Me.BunifuImageButton5.ImageActive = Nothing
        Me.BunifuImageButton5.Location = New System.Drawing.Point(324, 184)
        Me.BunifuImageButton5.Name = "BunifuImageButton5"
        Me.BunifuImageButton5.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton5.TabIndex = 44
        Me.BunifuImageButton5.TabStop = False
        Me.BunifuImageButton5.Zoom = 10
        '
        'txtStun
        '
        Me.txtStun.BackColor = System.Drawing.Color.White
        Me.txtStun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStun.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStun.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtStun.ForeColor = System.Drawing.Color.Black
        Me.txtStun.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtStun.HintText = "Enter Username"
        Me.txtStun.isPassword = False
        Me.txtStun.LineFocusedColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtStun.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtStun.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtStun.LineThickness = 3
        Me.txtStun.Location = New System.Drawing.Point(18, 20)
        Me.txtStun.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStun.Name = "txtStun"
        Me.txtStun.Size = New System.Drawing.Size(331, 33)
        Me.txtStun.TabIndex = 34
        Me.txtStun.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton4.Image = CType(resources.GetObject("BunifuImageButton4.Image"), System.Drawing.Image)
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(324, 140)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton4.TabIndex = 43
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(324, 20)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(24, 34)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 40
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(324, 101)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 42
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'txtStuPass
        '
        Me.txtStuPass.BackColor = System.Drawing.Color.White
        Me.txtStuPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStuPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStuPass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtStuPass.ForeColor = System.Drawing.Color.Black
        Me.txtStuPass.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtStuPass.HintText = "Enter Student Password"
        Me.txtStuPass.isPassword = False
        Me.txtStuPass.LineFocusedColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtStuPass.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtStuPass.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtStuPass.LineThickness = 3
        Me.txtStuPass.Location = New System.Drawing.Point(18, 184)
        Me.txtStuPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStuPass.Name = "txtStuPass"
        Me.txtStuPass.Size = New System.Drawing.Size(331, 33)
        Me.txtStuPass.TabIndex = 33
        Me.txtStuPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(324, 60)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 41
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'txtStname
        '
        Me.txtStname.BackColor = System.Drawing.Color.White
        Me.txtStname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtStname.ForeColor = System.Drawing.Color.Black
        Me.txtStname.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtStname.HintText = "Enter Student Full Name"
        Me.txtStname.isPassword = False
        Me.txtStname.LineFocusedColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtStname.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtStname.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtStname.LineThickness = 3
        Me.txtStname.Location = New System.Drawing.Point(18, 61)
        Me.txtStname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStname.Name = "txtStname"
        Me.txtStname.Size = New System.Drawing.Size(331, 33)
        Me.txtStname.TabIndex = 32
        Me.txtStname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtStid
        '
        Me.txtStid.BackColor = System.Drawing.Color.White
        Me.txtStid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStid.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtStid.ForeColor = System.Drawing.Color.Black
        Me.txtStid.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtStid.HintText = "Enter Student ID"
        Me.txtStid.isPassword = False
        Me.txtStid.LineFocusedColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtStid.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtStid.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtStid.LineThickness = 3
        Me.txtStid.Location = New System.Drawing.Point(18, 143)
        Me.txtStid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStid.Name = "txtStid"
        Me.txtStid.Size = New System.Drawing.Size(331, 33)
        Me.txtStid.TabIndex = 30
        Me.txtStid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtClass
        '
        Me.txtClass.BackColor = System.Drawing.Color.White
        Me.txtClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtClass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtClass.ForeColor = System.Drawing.Color.Black
        Me.txtClass.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtClass.HintText = "Enter Student Class"
        Me.txtClass.isPassword = False
        Me.txtClass.LineFocusedColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtClass.LineIdleColor = System.Drawing.Color.DimGray
        Me.txtClass.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtClass.LineThickness = 3
        Me.txtClass.Location = New System.Drawing.Point(18, 102)
        Me.txtClass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtClass.Name = "txtClass"
        Me.txtClass.Size = New System.Drawing.Size(331, 33)
        Me.txtClass.TabIndex = 31
        Me.txtClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(283, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Reload"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(439, 385)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Course"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(634, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Course Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(634, 439)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "IT232"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(439, 437)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Java"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(634, 511)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "IT241"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(439, 512)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "HTML"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(635, 488)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "IT543"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(439, 463)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Visual Basic"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(634, 463)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "IT124"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(439, 488)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Advanced Java"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(634, 413)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "IT321"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(439, 413)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "C++"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(634, 534)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "IT237"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(439, 534)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 13)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "Advanced Visual Basic"
        '
        'Student_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 662)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GrpStudent)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Student_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Students"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpStudent.ResumeLayout(False)
        CType(Me.BunifuImageButton9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GrpStudent As GroupBox
    Friend WithEvents txtStuPass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtStname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtClass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents txtStun As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtStid As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton5 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton6 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnStupdate As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnStSave As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnStuDel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuImageButton8 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtScore As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuImageButton7 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtCID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuImageButton9 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtscoreb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
