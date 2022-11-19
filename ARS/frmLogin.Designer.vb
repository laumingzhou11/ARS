<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.GcLogin = New DevExpress.XtraEditors.GroupControl()
        Me.HyperlinkLabelControl3 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cmdlogin = New DevExpress.XtraEditors.SimpleButton()
        Me.txtpw = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtuser = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lblcount = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.SplashScreenManager2 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.ARS.waitform), True, True)
        CType(Me.GcLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GcLogin.SuspendLayout()
        CType(Me.txtpw.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtuser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GcLogin
        '
        Me.GcLogin.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GcLogin.AppearanceCaption.Options.UseFont = True
        Me.GcLogin.AppearanceCaption.Options.UseTextOptions = True
        Me.GcLogin.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GcLogin.Controls.Add(Me.HyperlinkLabelControl3)
        Me.GcLogin.Controls.Add(Me.LabelControl5)
        Me.GcLogin.Controls.Add(Me.cmdlogin)
        Me.GcLogin.Controls.Add(Me.txtpw)
        Me.GcLogin.Controls.Add(Me.LabelControl3)
        Me.GcLogin.Controls.Add(Me.txtuser)
        Me.GcLogin.Controls.Add(Me.LabelControl6)
        Me.GcLogin.Controls.Add(Me.LabelControl4)
        Me.GcLogin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GcLogin.Location = New System.Drawing.Point(0, 215)
        Me.GcLogin.Name = "GcLogin"
        Me.GcLogin.Size = New System.Drawing.Size(368, 238)
        Me.GcLogin.TabIndex = 5
        Me.GcLogin.Text = "Login to Your Account"
        '
        'HyperlinkLabelControl3
        '
        Me.HyperlinkLabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HyperlinkLabelControl3.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl3.Location = New System.Drawing.Point(222, 207)
        Me.HyperlinkLabelControl3.Name = "HyperlinkLabelControl3"
        Me.HyperlinkLabelControl3.Size = New System.Drawing.Size(41, 14)
        Me.HyperlinkLabelControl3.TabIndex = 28
        Me.HyperlinkLabelControl3.Text = "Sign up"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(103, 208)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(115, 13)
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
        Me.cmdlogin.Location = New System.Drawing.Point(10, 164)
        Me.cmdlogin.Name = "cmdlogin"
        Me.cmdlogin.Size = New System.Drawing.Size(347, 34)
        Me.cmdlogin.TabIndex = 25
        Me.cmdlogin.Text = "LOGIN"
        '
        'txtpw
        '
        Me.txtpw.EditValue = "PASSWORD"
        Me.txtpw.Location = New System.Drawing.Point(10, 118)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpw.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtpw.Properties.Appearance.Options.UseFont = True
        Me.txtpw.Properties.Appearance.Options.UseForeColor = True
        Me.txtpw.Properties.AutoHeight = False
        Me.txtpw.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtpw.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpw.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far
        Me.txtpw.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtpw.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtpw.Size = New System.Drawing.Size(347, 28)
        Me.txtpw.TabIndex = 21
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(10, 37)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl3.TabIndex = 22
        Me.LabelControl3.Text = "USERNAME"
        '
        'txtuser
        '
        Me.txtuser.EditValue = "USER NAME"
        Me.txtuser.Location = New System.Drawing.Point(10, 56)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txtuser.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.Properties.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.txtuser.Properties.Appearance.Options.UseFont = True
        Me.txtuser.Properties.Appearance.Options.UseForeColor = True
        Me.txtuser.Properties.AutoHeight = False
        Me.txtuser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtuser.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtuser.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far
        Me.txtuser.Properties.ContextImageOptions.Image = CType(resources.GetObject("txtuser.Properties.ContextImageOptions.Image"), System.Drawing.Image)
        Me.txtuser.Properties.NullText = "USER NAME"
        Me.txtuser.Properties.UseMaskAsDisplayFormat = False
        Me.txtuser.Size = New System.Drawing.Size(347, 28)
        Me.txtuser.TabIndex = 19
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(10, 99)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl6.TabIndex = 23
        Me.LabelControl6.Text = "PASSWORD"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(10, 99)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl4.TabIndex = 24
        Me.LabelControl4.Text = "PASSWORD"
        '
        'lblcount
        '
        Me.lblcount.Location = New System.Drawing.Point(387, 84)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(66, 13)
        Me.lblcount.TabIndex = 6
        Me.lblcount.Text = "LabelControl1"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(0, 0)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(368, 215)
        Me.PictureEdit1.TabIndex = 7
        '
        'SplashScreenManager2
        '
        Me.SplashScreenManager2.ClosingDelay = 500
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 453)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.lblcount)
        Me.Controls.Add(Me.GcLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Form"
        CType(Me.GcLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GcLogin.ResumeLayout(False)
        Me.GcLogin.PerformLayout()
        CType(Me.txtpw.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtuser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GcLogin As DevExpress.XtraEditors.GroupControl
    Friend WithEvents HyperlinkLabelControl3 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdlogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtpw As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtuser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents lblcount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents SplashScreenManager2 As DevExpress.XtraSplashScreen.SplashScreenManager
End Class
