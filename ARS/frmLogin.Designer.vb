<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.GcLogin2 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gcLogin = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.HyperlinkLabelControl3 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdlogin = New DevExpress.XtraEditors.SimpleButton()
        Me.txtpw = New DevExpress.XtraEditors.TextEdit()
        Me.txtuser = New DevExpress.XtraEditors.TextEdit()
        Me.lblcount = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SplashScreenManager2 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.ARS.waitform), True, True)
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.GcLogin2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GcLogin2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtpw.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtuser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GcLogin2
        '
        Me.GcLogin2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GcLogin2.AppearanceCaption.Options.UseFont = True
        Me.GcLogin2.AppearanceCaption.Options.UseTextOptions = True
        Me.GcLogin2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GcLogin2.Controls.Add(Me.SimpleButton1)
        Me.GcLogin2.Controls.Add(Me.PictureBox1)
        Me.GcLogin2.Controls.Add(Me.gcLogin)
        Me.GcLogin2.Controls.Add(Me.LabelControl2)
        Me.GcLogin2.Controls.Add(Me.LabelControl1)
        Me.GcLogin2.Controls.Add(Me.HyperlinkLabelControl3)
        Me.GcLogin2.Controls.Add(Me.LabelControl5)
        Me.GcLogin2.Controls.Add(Me.cmdlogin)
        Me.GcLogin2.Controls.Add(Me.txtpw)
        Me.GcLogin2.Controls.Add(Me.txtuser)
        Me.GcLogin2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcLogin2.Location = New System.Drawing.Point(2, 2)
        Me.GcLogin2.Name = "GcLogin2"
        Me.GcLogin2.Size = New System.Drawing.Size(364, 430)
        Me.GcLogin2.TabIndex = 5
        Me.GcLogin2.Text = "Login Form"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SimpleButton1.Appearance.BorderColor = System.Drawing.Color.Black
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseBorderColor = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(1, 29)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.SimpleButton1.Size = New System.Drawing.Size(31, 28)
        Me.SimpleButton1.TabIndex = 34
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(121, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'gcLogin
        '
        Me.gcLogin.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcLogin.Appearance.Options.UseFont = True
        Me.gcLogin.Location = New System.Drawing.Point(108, 156)
        Me.gcLogin.Name = "gcLogin"
        Me.gcLogin.Size = New System.Drawing.Size(144, 16)
        Me.gcLogin.TabIndex = 32
        Me.gcLogin.Text = "Login to your Account"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(44, 256)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl2.TabIndex = 31
        Me.LabelControl2.Text = "Password"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(44, 182)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 16)
        Me.LabelControl1.TabIndex = 30
        Me.LabelControl1.Text = "Username"
        '
        'HyperlinkLabelControl3
        '
        Me.HyperlinkLabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HyperlinkLabelControl3.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl3.Location = New System.Drawing.Point(230, 404)
        Me.HyperlinkLabelControl3.Name = "HyperlinkLabelControl3"
        Me.HyperlinkLabelControl3.Size = New System.Drawing.Size(43, 16)
        Me.HyperlinkLabelControl3.TabIndex = 28
        Me.HyperlinkLabelControl3.Text = "Sign up"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(90, 404)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(134, 16)
        Me.LabelControl5.TabIndex = 27
        Me.LabelControl5.Text = "Don't have account?"
        '
        'cmdlogin
        '
        Me.cmdlogin.Appearance.BorderColor = System.Drawing.Color.Black
        Me.cmdlogin.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdlogin.Appearance.Options.UseBorderColor = True
        Me.cmdlogin.Appearance.Options.UseFont = True
        Me.cmdlogin.ImageOptions.SvgImage = CType(resources.GetObject("cmdlogin.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.cmdlogin.Location = New System.Drawing.Point(40, 335)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(284, 40)
        Me.cmdlogin.TabIndex = 25
        Me.cmdlogin.Text = "LOGIN"
        '
        'txtpw
        '
        Me.txtpw.EditValue = "Type your password"
        Me.txtpw.Location = New System.Drawing.Point(40, 278)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpw.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtpw.Properties.Appearance.Options.UseFont = True
        Me.txtpw.Properties.Appearance.Options.UseForeColor = True
        Me.txtpw.Properties.AutoHeight = False
        Me.txtpw.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtpw.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpw.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far
        Me.txtpw.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtpw.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtpw.Size = New System.Drawing.Size(284, 37)
        Me.txtpw.TabIndex = 21
        '
        'txtuser
        '
        Me.txtuser.EditValue = "TYPE YOUR USERNAME"
        Me.txtuser.Location = New System.Drawing.Point(40, 204)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtuser.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtuser.Properties.Appearance.Options.UseFont = True
        Me.txtuser.Properties.Appearance.Options.UseForeColor = True
        Me.txtuser.Properties.AutoHeight = False
        Me.txtuser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtuser.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtuser.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far
        Me.txtuser.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtuser.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtuser.Properties.NullText = "USER NAME"
        Me.txtuser.Size = New System.Drawing.Size(284, 37)
        Me.txtuser.TabIndex = 19
        '
        'lblcount
        '
        Me.lblcount.Location = New System.Drawing.Point(473, 84)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(66, 13)
        Me.lblcount.TabIndex = 6
        Me.lblcount.Text = "LabelControl1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GcLogin2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl1.Location = New System.Drawing.Point(466, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(368, 434)
        Me.PanelControl1.TabIndex = 8
        '
        'SplashScreenManager2
        '
        Me.SplashScreenManager2.ClosingDelay = 500
        '
        'PictureEdit2
        '
        Me.PictureEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureEdit2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit2.EditValue = Global.ARS.My.Resources.Resources._3
        Me.PictureEdit2.Location = New System.Drawing.Point(0, 222)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit2.Size = New System.Drawing.Size(466, 212)
        Me.PictureEdit2.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox2.Image = Global.ARS.My.Resources.Resources.Monster_Email_1_v1
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(466, 222)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 434)
        Me.Controls.Add(Me.PictureEdit2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.lblcount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Refuelling Solutions"
        CType(Me.GcLogin2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GcLogin2.ResumeLayout(False)
        Me.GcLogin2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtpw.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtuser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GcLogin2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents HyperlinkLabelControl3 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdlogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtpw As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtuser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents lblcount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gcLogin As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplashScreenManager2 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
