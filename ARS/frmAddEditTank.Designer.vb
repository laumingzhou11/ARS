<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditTank
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditTank))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtLocation = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbUomCode = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtCapacity = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTankName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTankID = New DevExpress.XtraEditors.TextEdit()
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton()
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbUomCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCapacity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTankName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTankID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtLocation)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.cbUomCode)
        Me.GroupControl1.Controls.Add(Me.txtCapacity)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtTankName)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtTankID)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(387, 152)
        Me.GroupControl1.TabIndex = 23
        Me.GroupControl1.Text = "TANK"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(67, 118)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocation.Properties.Appearance.Options.UseFont = True
        Me.txtLocation.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtLocation.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLocation.Size = New System.Drawing.Size(310, 22)
        Me.txtLocation.TabIndex = 37
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(10, 122)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl5.TabIndex = 36
        Me.LabelControl5.Text = "Location:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(203, 94)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl3.TabIndex = 35
        Me.LabelControl3.Text = "Uom Code:"
        '
        'cbUomCode
        '
        Me.cbUomCode.Location = New System.Drawing.Point(269, 90)
        Me.cbUomCode.Name = "cbUomCode"
        Me.cbUomCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUomCode.Properties.Appearance.Options.UseFont = True
        Me.cbUomCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbUomCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbUomCode.Size = New System.Drawing.Size(108, 22)
        Me.cbUomCode.TabIndex = 34
        '
        'txtCapacity
        '
        Me.txtCapacity.Location = New System.Drawing.Point(67, 90)
        Me.txtCapacity.Name = "txtCapacity"
        Me.txtCapacity.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacity.Properties.Appearance.Options.UseFont = True
        Me.txtCapacity.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtCapacity.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCapacity.Size = New System.Drawing.Size(130, 22)
        Me.txtCapacity.TabIndex = 33
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(9, 93)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "Capacity:"
        '
        'txtTankName
        '
        Me.txtTankName.Location = New System.Drawing.Point(67, 62)
        Me.txtTankName.Name = "txtTankName"
        Me.txtTankName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTankName.Properties.Appearance.Options.UseFont = True
        Me.txtTankName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtTankName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTankName.Size = New System.Drawing.Size(310, 22)
        Me.txtTankName.TabIndex = 31
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(26, 65)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl2.TabIndex = 21
        Me.LabelControl2.Text = "Name:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(45, 38)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "ID:"
        '
        'txtTankID
        '
        Me.txtTankID.Enabled = False
        Me.txtTankID.Location = New System.Drawing.Point(67, 34)
        Me.txtTankID.Name = "txtTankID"
        Me.txtTankID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTankID.Properties.Appearance.Options.UseFont = True
        Me.txtTankID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtTankID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTankID.Size = New System.Drawing.Size(310, 22)
        Me.txtTankID.TabIndex = 18
        '
        'btnsave
        '
        Me.btnsave.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Appearance.Options.UseFont = True
        Me.btnsave.ImageOptions.Image = CType(resources.GetObject("btnsave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(167, 158)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(103, 35)
        Me.btnsave.TabIndex = 25
        Me.btnsave.Text = "&Save"
        '
        'btncancel
        '
        Me.btncancel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Appearance.Options.UseFont = True
        Me.btncancel.ImageOptions.Image = CType(resources.GetObject("btncancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btncancel.Location = New System.Drawing.Point(274, 158)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(103, 35)
        Me.btncancel.TabIndex = 26
        Me.btncancel.Text = "&Cancel"
        '
        'frmAddEditTank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 201)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddEditTank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Tank"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbUomCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCapacity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTankName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTankID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCapacity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTankName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTankID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbUomCode As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtLocation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
End Class
