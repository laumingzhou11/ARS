﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddEditAutoRefuelling
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl()
        Me.lblCapacity = New DevExpress.XtraEditors.LabelControl()
        Me.lblCr = New DevExpress.XtraEditors.LabelControl()
        Me.lblCrNo = New DevExpress.XtraEditors.LabelControl()
        Me.lblMake = New DevExpress.XtraEditors.LabelControl()
        Me.lblModel = New DevExpress.XtraEditors.LabelControl()
        Me.lblCOde = New DevExpress.XtraEditors.LabelControl()
        Me.lblVehicleName = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.VehiclePic = New DevExpress.XtraEditors.PictureEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.DriverPic = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.lblAddress = New DevExpress.XtraEditors.LabelControl()
        Me.lblDriverName = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.VehiclePic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.DriverPic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.TextEdit10)
        Me.GroupControl1.Controls.Add(Me.PictureEdit1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(933, 66)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "QR Code Scanning"
        '
        'TextEdit10
        '
        Me.TextEdit10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextEdit10.Enabled = False
        Me.TextEdit10.Location = New System.Drawing.Point(42, 27)
        Me.TextEdit10.Name = "TextEdit10"
        Me.TextEdit10.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit10.Properties.Appearance.Options.UseFont = True
        Me.TextEdit10.Properties.AutoHeight = False
        Me.TextEdit10.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TextEdit10.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextEdit10.Size = New System.Drawing.Size(889, 37)
        Me.TextEdit10.TabIndex = 37
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureEdit1.EditValue = Global.ARS.My.Resources.Resources.icons8_qr_code_32
        Me.PictureEdit1.Location = New System.Drawing.Point(2, 27)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.ShowMenu = False
        Me.PictureEdit1.Size = New System.Drawing.Size(40, 37)
        Me.PictureEdit1.TabIndex = 36
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.PanelControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 66)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(933, 165)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Vehicle Information"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lblStatus)
        Me.PanelControl1.Controls.Add(Me.lblCapacity)
        Me.PanelControl1.Controls.Add(Me.lblCr)
        Me.PanelControl1.Controls.Add(Me.lblCrNo)
        Me.PanelControl1.Controls.Add(Me.lblMake)
        Me.PanelControl1.Controls.Add(Me.lblModel)
        Me.PanelControl1.Controls.Add(Me.lblCOde)
        Me.PanelControl1.Controls.Add(Me.lblVehicleName)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.VehiclePic)
        Me.PanelControl1.Controls.Add(Me.GroupControl3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(2, 27)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(929, 136)
        Me.PanelControl1.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Appearance.Options.UseFont = True
        Me.lblStatus.Location = New System.Drawing.Point(399, 102)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(29, 14)
        Me.lblStatus.TabIndex = 58
        Me.lblStatus.Text = "SV-1"
        '
        'lblCapacity
        '
        Me.lblCapacity.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCapacity.Appearance.Options.UseFont = True
        Me.lblCapacity.Location = New System.Drawing.Point(399, 74)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(29, 14)
        Me.lblCapacity.TabIndex = 57
        Me.lblCapacity.Text = "SV-1"
        '
        'lblCr
        '
        Me.lblCr.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCr.Appearance.Options.UseFont = True
        Me.lblCr.Location = New System.Drawing.Point(399, 45)
        Me.lblCr.Name = "lblCr"
        Me.lblCr.Size = New System.Drawing.Size(29, 14)
        Me.lblCr.TabIndex = 56
        Me.lblCr.Text = "SV-1"
        '
        'lblCrNo
        '
        Me.lblCrNo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrNo.Appearance.Options.UseFont = True
        Me.lblCrNo.Location = New System.Drawing.Point(399, 18)
        Me.lblCrNo.Name = "lblCrNo"
        Me.lblCrNo.Size = New System.Drawing.Size(29, 14)
        Me.lblCrNo.TabIndex = 55
        Me.lblCrNo.Text = "SV-1"
        '
        'lblMake
        '
        Me.lblMake.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMake.Appearance.Options.UseFont = True
        Me.lblMake.Location = New System.Drawing.Point(171, 102)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(29, 14)
        Me.lblMake.TabIndex = 54
        Me.lblMake.Text = "SV-1"
        '
        'lblModel
        '
        Me.lblModel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Appearance.Options.UseFont = True
        Me.lblModel.Location = New System.Drawing.Point(171, 74)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(49, 14)
        Me.lblModel.TabIndex = 53
        Me.lblModel.Text = "TOYOTA"
        '
        'lblCOde
        '
        Me.lblCOde.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCOde.Appearance.Options.UseFont = True
        Me.lblCOde.Location = New System.Drawing.Point(171, 46)
        Me.lblCOde.Name = "lblCOde"
        Me.lblCOde.Size = New System.Drawing.Size(88, 14)
        Me.lblCOde.TabIndex = 52
        Me.lblCOde.Text = "00000000000"
        '
        'lblVehicleName
        '
        Me.lblVehicleName.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehicleName.Appearance.Options.UseFont = True
        Me.lblVehicleName.Appearance.Options.UseTextOptions = True
        Me.lblVehicleName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblVehicleName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVehicleName.Location = New System.Drawing.Point(171, 12)
        Me.lblVehicleName.Name = "lblVehicleName"
        Me.lblVehicleName.Size = New System.Drawing.Size(170, 30)
        Me.lblVehicleName.TabIndex = 51
        Me.lblVehicleName.Text = "MARK LAURENCE A. CORELLA"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(353, 103)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl8.TabIndex = 48
        Me.LabelControl8.Text = "Status:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(341, 75)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl7.TabIndex = 46
        Me.LabelControl7.Text = "Capacity:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(344, 46)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl6.TabIndex = 44
        Me.LabelControl6.Text = "Plate No:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(361, 19)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl5.TabIndex = 42
        Me.LabelControl5.Text = "Cr No:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(130, 103)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl4.TabIndex = 40
        Me.LabelControl4.Text = "make:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(128, 75)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 38
        Me.LabelControl3.Text = "Model:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(134, 47)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl1.TabIndex = 36
        Me.LabelControl1.Text = "Code:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(130, 13)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl2.TabIndex = 34
        Me.LabelControl2.Text = "Name:"
        '
        'VehiclePic
        '
        Me.VehiclePic.Location = New System.Drawing.Point(3, 12)
        Me.VehiclePic.Name = "VehiclePic"
        Me.VehiclePic.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.VehiclePic.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.VehiclePic.Size = New System.Drawing.Size(117, 112)
        Me.VehiclePic.TabIndex = 0
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.lblAddress)
        Me.GroupControl3.Controls.Add(Me.lblDriverName)
        Me.GroupControl3.Controls.Add(Me.LabelControl10)
        Me.GroupControl3.Controls.Add(Me.DriverPic)
        Me.GroupControl3.Controls.Add(Me.LabelControl9)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl3.Location = New System.Drawing.Point(560, 2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(367, 132)
        Me.GroupControl3.TabIndex = 50
        Me.GroupControl3.Text = "Driver Information"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(111, 77)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl10.TabIndex = 53
        Me.LabelControl10.Text = "Address:"
        '
        'DriverPic
        '
        Me.DriverPic.Location = New System.Drawing.Point(4, 27)
        Me.DriverPic.Name = "DriverPic"
        Me.DriverPic.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.DriverPic.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.DriverPic.Size = New System.Drawing.Size(100, 100)
        Me.DriverPic.TabIndex = 50
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(125, 48)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl9.TabIndex = 51
        Me.LabelControl9.Text = "Name:"
        '
        'lblAddress
        '
        Me.lblAddress.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Appearance.Options.UseFont = True
        Me.lblAddress.Appearance.Options.UseTextOptions = True
        Me.lblAddress.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblAddress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblAddress.Location = New System.Drawing.Point(165, 76)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(187, 30)
        Me.lblAddress.TabIndex = 55
        Me.lblAddress.Text = "CENTRO 12, TUGUEGARAO CITY, CAGAYAN"
        '
        'lblDriverName
        '
        Me.lblDriverName.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriverName.Appearance.Options.UseFont = True
        Me.lblDriverName.Location = New System.Drawing.Point(166, 48)
        Me.lblDriverName.Name = "lblDriverName"
        Me.lblDriverName.Size = New System.Drawing.Size(159, 13)
        Me.lblDriverName.TabIndex = 54
        Me.lblDriverName.Text = "MARK LAURENCE A. CORELLA"
        '
        'frmAddEditAutoRefuelling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 634)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddEditAutoRefuelling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Refuelling - Stock Out"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.VehiclePic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.DriverPic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents VehiclePic As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DriverPic As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCapacity As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCr As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCrNo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMake As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblModel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCOde As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblVehicleName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAddress As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDriverName As DevExpress.XtraEditors.LabelControl
End Class
