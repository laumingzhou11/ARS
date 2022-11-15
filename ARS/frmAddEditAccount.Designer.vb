<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditAccount))
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.lblaccount = New DevExpress.XtraEditors.LabelControl()
        Me.ckpasschar = New DevExpress.XtraEditors.CheckEdit()
        Me.txtname = New DevExpress.XtraEditors.TextEdit()
        Me.txtpass = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtuser = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cbstatus = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cbacctype = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton()
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.ckpasschar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtuser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cbstatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbacctype.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.lblaccount)
        Me.GroupControl2.Controls.Add(Me.ckpasschar)
        Me.GroupControl2.Controls.Add(Me.txtname)
        Me.GroupControl2.Controls.Add(Me.txtpass)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.txtuser)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(371, 212)
        Me.GroupControl2.TabIndex = 19
        Me.GroupControl2.Text = "Account"
        '
        'lblaccount
        '
        Me.lblaccount.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaccount.Appearance.Options.UseFont = True
        Me.lblaccount.Location = New System.Drawing.Point(396, 61)
        Me.lblaccount.Name = "lblaccount"
        Me.lblaccount.Size = New System.Drawing.Size(61, 14)
        Me.lblaccount.TabIndex = 17
        Me.lblaccount.Text = "Full Name:"
        '
        'ckpasschar
        '
        Me.ckpasschar.Location = New System.Drawing.Point(85, 113)
        Me.ckpasschar.Name = "ckpasschar"
        Me.ckpasschar.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckpasschar.Properties.Appearance.Options.UseFont = True
        Me.ckpasschar.Properties.Caption = "Show password"
        Me.ckpasschar.Size = New System.Drawing.Size(143, 20)
        Me.ckpasschar.TabIndex = 6
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(82, 27)
        Me.txtname.Name = "txtname"
        Me.txtname.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Properties.Appearance.Options.UseFont = True
        Me.txtname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtname.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtname.Size = New System.Drawing.Size(275, 24)
        Me.txtname.TabIndex = 16
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(82, 87)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Properties.Appearance.Options.UseFont = True
        Me.txtpass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtpass.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(275, 24)
        Me.txtpass.TabIndex = 18
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(13, 91)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Password:"
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(82, 57)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Properties.Appearance.Options.UseFont = True
        Me.txtuser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtuser.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtuser.Properties.MaskSettings.Set("mask", "\d\d\d\d\d")
        Me.txtuser.Size = New System.Drawing.Size(275, 24)
        Me.txtuser.TabIndex = 17
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(15, 31)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(61, 14)
        Me.LabelControl4.TabIndex = 15
        Me.LabelControl4.Text = "Full Name:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(13, 62)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Username:"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cbstatus)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.cbacctype)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 139)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(371, 73)
        Me.PanelControl1.TabIndex = 20
        '
        'cbstatus
        '
        Me.cbstatus.Location = New System.Drawing.Point(84, 38)
        Me.cbstatus.Name = "cbstatus"
        Me.cbstatus.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbstatus.Properties.Appearance.Options.UseFont = True
        Me.cbstatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbstatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbstatus.Properties.Items.AddRange(New Object() {"", "ACTIVE", "BLOCK", "FOR ACTIVATION"})
        Me.cbstatus.Size = New System.Drawing.Size(275, 24)
        Me.cbstatus.TabIndex = 20
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(32, 42)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(45, 14)
        Me.LabelControl6.TabIndex = 19
        Me.LabelControl6.Text = "Status:"
        '
        'cbacctype
        '
        Me.cbacctype.Location = New System.Drawing.Point(84, 8)
        Me.cbacctype.Name = "cbacctype"
        Me.cbacctype.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbacctype.Properties.Appearance.Options.UseFont = True
        Me.cbacctype.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbacctype.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbacctype.Properties.Items.AddRange(New Object() {"", "SUPER ADMIN", "ADMIN", "USER"})
        Me.cbacctype.Size = New System.Drawing.Size(275, 24)
        Me.cbacctype.TabIndex = 16
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(13, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 14)
        Me.LabelControl3.TabIndex = 15
        Me.LabelControl3.Text = "Acct Type:"
        '
        'btnsave
        '
        Me.btnsave.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Appearance.Options.UseFont = True
        Me.btnsave.ImageOptions.Image = CType(resources.GetObject("btnsave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(153, 5)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(103, 35)
        Me.btnsave.TabIndex = 21
        Me.btnsave.Text = "&Save"
        '
        'btncancel
        '
        Me.btncancel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Appearance.Options.UseFont = True
        Me.btncancel.ImageOptions.Image = CType(resources.GetObject("btncancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btncancel.Location = New System.Drawing.Point(260, 5)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(103, 35)
        Me.btncancel.TabIndex = 22
        Me.btncancel.Text = "&Cancel"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnsave)
        Me.PanelControl2.Controls.Add(Me.btncancel)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 212)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(371, 44)
        Me.PanelControl2.TabIndex = 21
        '
        'frmAddEditAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 256)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.PanelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddEditAccount"
        Me.Text = "Add Account"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.ckpasschar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtuser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cbstatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbacctype.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblaccount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ckpasschar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtpass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtuser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cbstatus As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbacctype As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
End Class
