<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lecturer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lecturer))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GrpLecturer = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BunifuImageButton5 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtPass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtCid = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUn = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnSave = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.DataGridView1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnDelete = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GrpLecturer.SuspendLayout()
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpLecturer
        '
        Me.GrpLecturer.Controls.Add(Me.Button1)
        Me.GrpLecturer.Controls.Add(Me.BunifuImageButton5)
        Me.GrpLecturer.Controls.Add(Me.BunifuImageButton4)
        Me.GrpLecturer.Controls.Add(Me.BunifuImageButton3)
        Me.GrpLecturer.Controls.Add(Me.BunifuImageButton2)
        Me.GrpLecturer.Controls.Add(Me.BunifuImageButton1)
        Me.GrpLecturer.Controls.Add(Me.txtPass)
        Me.GrpLecturer.Controls.Add(Me.txtCid)
        Me.GrpLecturer.Controls.Add(Me.txtUn)
        Me.GrpLecturer.Controls.Add(Me.txtName)
        Me.GrpLecturer.Controls.Add(Me.txtID)
        Me.GrpLecturer.Controls.Add(Me.btnUpdate)
        Me.GrpLecturer.Controls.Add(Me.btnSave)
        Me.GrpLecturer.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpLecturer.Location = New System.Drawing.Point(12, 12)
        Me.GrpLecturer.Name = "GrpLecturer"
        Me.GrpLecturer.Size = New System.Drawing.Size(405, 394)
        Me.GrpLecturer.TabIndex = 26
        Me.GrpLecturer.TabStop = False
        Me.GrpLecturer.Text = "EDIT LECTURER TABLE"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(286, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Reload"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BunifuImageButton5
        '
        Me.BunifuImageButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton5.Image = CType(resources.GetObject("BunifuImageButton5.Image"), System.Drawing.Image)
        Me.BunifuImageButton5.ImageActive = Nothing
        Me.BunifuImageButton5.Location = New System.Drawing.Point(336, 244)
        Me.BunifuImageButton5.Name = "BunifuImageButton5"
        Me.BunifuImageButton5.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton5.TabIndex = 43
        Me.BunifuImageButton5.TabStop = False
        Me.BunifuImageButton5.Zoom = 10
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton4.Image = CType(resources.GetObject("BunifuImageButton4.Image"), System.Drawing.Image)
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(336, 192)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton4.TabIndex = 42
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 10
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(336, 92)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton3.TabIndex = 41
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(336, 139)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 40
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BunifuImageButton1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(336, 40)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(25, 33)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 39
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.White
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPass.HintText = "Enter Password"
        Me.txtPass.isPassword = False
        Me.txtPass.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtPass.LineIdleColor = System.Drawing.Color.Black
        Me.txtPass.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtPass.LineThickness = 3
        Me.txtPass.Location = New System.Drawing.Point(29, 244)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(332, 33)
        Me.txtPass.TabIndex = 38
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtCid
        '
        Me.txtCid.BackColor = System.Drawing.Color.White
        Me.txtCid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCid.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCid.ForeColor = System.Drawing.Color.Black
        Me.txtCid.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCid.HintText = "Enter Course ID"
        Me.txtCid.isPassword = False
        Me.txtCid.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtCid.LineIdleColor = System.Drawing.Color.Black
        Me.txtCid.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtCid.LineThickness = 3
        Me.txtCid.Location = New System.Drawing.Point(29, 192)
        Me.txtCid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCid.Name = "txtCid"
        Me.txtCid.Size = New System.Drawing.Size(332, 33)
        Me.txtCid.TabIndex = 37
        Me.txtCid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUn
        '
        Me.txtUn.BackColor = System.Drawing.Color.White
        Me.txtUn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUn.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtUn.ForeColor = System.Drawing.Color.Black
        Me.txtUn.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUn.HintText = "Enter Lecturer Username"
        Me.txtUn.isPassword = False
        Me.txtUn.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtUn.LineIdleColor = System.Drawing.Color.Black
        Me.txtUn.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtUn.LineThickness = 3
        Me.txtUn.Location = New System.Drawing.Point(29, 139)
        Me.txtUn.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUn.Name = "txtUn"
        Me.txtUn.Size = New System.Drawing.Size(332, 33)
        Me.txtUn.TabIndex = 36
        Me.txtUn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtName.HintText = "Enter Lecturer Full Name"
        Me.txtName.isPassword = False
        Me.txtName.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtName.LineIdleColor = System.Drawing.Color.Black
        Me.txtName.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtName.LineThickness = 3
        Me.txtName.Location = New System.Drawing.Point(29, 92)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(332, 33)
        Me.txtName.TabIndex = 35
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.White
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtID.ForeColor = System.Drawing.Color.Black
        Me.txtID.HintForeColor = System.Drawing.Color.DimGray
        Me.txtID.HintText = "Enter ID Number here"
        Me.txtID.isPassword = False
        Me.txtID.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtID.LineIdleColor = System.Drawing.Color.Black
        Me.txtID.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtID.LineThickness = 3
        Me.txtID.Location = New System.Drawing.Point(29, 40)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(332, 33)
        Me.txtID.TabIndex = 34
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnUpdate
        '
        Me.btnUpdate.ActiveBorderThickness = 1
        Me.btnUpdate.ActiveCornerRadius = 20
        Me.btnUpdate.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnUpdate.ActiveForecolor = System.Drawing.Color.White
        Me.btnUpdate.ActiveLineColor = System.Drawing.Color.White
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdate.BackgroundImage = CType(resources.GetObject("btnUpdate.BackgroundImage"), System.Drawing.Image)
        Me.btnUpdate.ButtonText = "Update"
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.IdleBorderThickness = 1
        Me.btnUpdate.IdleCornerRadius = 20
        Me.btnUpdate.IdleFillColor = System.Drawing.Color.Black
        Me.btnUpdate.IdleForecolor = System.Drawing.Color.White
        Me.btnUpdate.IdleLineColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(265, 314)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(7)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(96, 39)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.ActiveBorderThickness = 1
        Me.btnSave.ActiveCornerRadius = 20
        Me.btnSave.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSave.ActiveForecolor = System.Drawing.Color.White
        Me.btnSave.ActiveLineColor = System.Drawing.Color.White
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.ButtonText = "Save"
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.IdleBorderThickness = 1
        Me.btnSave.IdleCornerRadius = 20
        Me.btnSave.IdleFillColor = System.Drawing.Color.Black
        Me.btnSave.IdleForecolor = System.Drawing.Color.White
        Me.btnSave.IdleLineColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(29, 314)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 39)
        Me.btnSave.TabIndex = 30
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DoubleBuffered = True
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight
        Me.DataGridView1.HeaderBgColor = System.Drawing.SystemColors.MenuHighlight
        Me.DataGridView1.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(423, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.Size = New System.Drawing.Size(588, 382)
        Me.DataGridView1.TabIndex = 27
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'btnDelete
        '
        Me.btnDelete.ActiveBorderThickness = 1
        Me.btnDelete.ActiveCornerRadius = 20
        Me.btnDelete.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnDelete.ActiveForecolor = System.Drawing.Color.White
        Me.btnDelete.ActiveLineColor = System.Drawing.Color.White
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.ButtonText = "Delete Lecturer Details"
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.IdleBorderThickness = 1
        Me.btnDelete.IdleCornerRadius = 20
        Me.btnDelete.IdleFillColor = System.Drawing.Color.Black
        Me.btnDelete.IdleForecolor = System.Drawing.Color.White
        Me.btnDelete.IdleLineColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(93, 426)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(280, 39)
        Me.btnDelete.TabIndex = 31
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lecturer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1330, 672)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GrpLecturer)
        Me.Controls.Add(Me.btnDelete)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Lecturer"
        Me.Text = "Lecturer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpLecturer.ResumeLayout(False)
        CType(Me.BunifuImageButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpLecturer As GroupBox
    Friend WithEvents DataGridView1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnDelete As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtPass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtCid As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtUn As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton5 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Button1 As Button
End Class
