<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmconnection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmconnection))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbltimes = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LLhousehold = New System.Windows.Forms.LinkLabel()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.lblConnection = New System.Windows.Forms.Label()
        Me.txtserver = New DevExpress.XtraEditors.TextEdit()
        Me.txtUserName = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdbase1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtDbase3 = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDbase2 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtdbase = New DevExpress.XtraEditors.TextEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtserver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtdbase1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDbase3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDbase2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtdbase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(20, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Primary:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(14, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(10, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Username:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(30, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Server:"
        '
        'btnsave
        '
        Me.btnsave.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Appearance.Options.UseFont = True
        Me.btnsave.ImageOptions.Image = CType(resources.GetObject("btnsave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(120, 8)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(93, 29)
        Me.btnsave.TabIndex = 4
        Me.btnsave.Text = "&Save"
        '
        'lbltimes
        '
        Me.lbltimes.AutoSize = True
        Me.lbltimes.Location = New System.Drawing.Point(388, 113)
        Me.lbltimes.Name = "lbltimes"
        Me.lbltimes.Size = New System.Drawing.Size(13, 13)
        Me.lbltimes.TabIndex = 63
        Me.lbltimes.Text = "1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.Image = CType(resources.GetObject("GroupControl1.Appearance.Image"), System.Drawing.Image)
        Me.GroupControl1.Appearance.Options.UseImage = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.txtdbase)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.LLhousehold)
        Me.GroupControl1.Controls.Add(Me.txtPassword)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.lblConnection)
        Me.GroupControl1.Controls.Add(Me.txtserver)
        Me.GroupControl1.Controls.Add(Me.txtUserName)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(322, 154)
        Me.GroupControl1.TabIndex = 64
        Me.GroupControl1.Text = "Connection"
        '
        'LLhousehold
        '
        Me.LLhousehold.AutoSize = True
        Me.LLhousehold.BackColor = System.Drawing.Color.Transparent
        Me.LLhousehold.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLhousehold.ForeColor = System.Drawing.Color.Transparent
        Me.LLhousehold.LinkColor = System.Drawing.Color.Red
        Me.LLhousehold.Location = New System.Drawing.Point(246, 4)
        Me.LLhousehold.Name = "LLhousehold"
        Me.LLhousehold.Size = New System.Drawing.Size(71, 13)
        Me.LLhousehold.TabIndex = 215
        Me.LLhousehold.TabStop = True
        Me.LLhousehold.Text = "Clear Fields"
        '
        'txtPassword
        '
        Me.txtPassword.EditValue = ""
        Me.txtPassword.Location = New System.Drawing.Point(84, 89)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Properties.Appearance.Options.UseFont = True
        Me.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(227, 22)
        Me.txtPassword.TabIndex = 3
        '
        'lblConnection
        '
        Me.lblConnection.AutoSize = True
        Me.lblConnection.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblConnection.Location = New System.Drawing.Point(466, 64)
        Me.lblConnection.Name = "lblConnection"
        Me.lblConnection.Size = New System.Drawing.Size(12, 13)
        Me.lblConnection.TabIndex = 66
        Me.lblConnection.Text = "-"
        '
        'txtserver
        '
        Me.txtserver.Location = New System.Drawing.Point(84, 33)
        Me.txtserver.Name = "txtserver"
        Me.txtserver.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserver.Properties.Appearance.Options.UseFont = True
        Me.txtserver.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtserver.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtserver.Size = New System.Drawing.Size(227, 22)
        Me.txtserver.TabIndex = 1
        '
        'txtUserName
        '
        Me.txtUserName.EditValue = ""
        Me.txtUserName.Location = New System.Drawing.Point(84, 61)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Properties.Appearance.Options.UseFont = True
        Me.txtUserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtUserName.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUserName.Size = New System.Drawing.Size(227, 22)
        Me.txtUserName.TabIndex = 2
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.Appearance.Options.UseFont = True
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.Label6)
        Me.GroupControl2.Controls.Add(Me.txtdbase1)
        Me.GroupControl2.Controls.Add(Me.txtDbase3)
        Me.GroupControl2.Controls.Add(Me.Label4)
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.txtDbase2)
        Me.GroupControl2.Location = New System.Drawing.Point(366, 190)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(387, 114)
        Me.GroupControl2.TabIndex = 66
        Me.GroupControl2.Text = "Databases"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(20, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Tertiary:"
        '
        'txtdbase1
        '
        Me.txtdbase1.EditValue = ""
        Me.txtdbase1.Location = New System.Drawing.Point(81, 26)
        Me.txtdbase1.Name = "txtdbase1"
        Me.txtdbase1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdbase1.Properties.Appearance.Options.UseFont = True
        Me.txtdbase1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtdbase1.Size = New System.Drawing.Size(224, 22)
        Me.txtdbase1.TabIndex = 5
        '
        'txtDbase3
        '
        Me.txtDbase3.EditValue = ""
        Me.txtDbase3.Location = New System.Drawing.Point(81, 82)
        Me.txtDbase3.Name = "txtDbase3"
        Me.txtDbase3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDbase3.Properties.Appearance.Options.UseFont = True
        Me.txtDbase3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtDbase3.Size = New System.Drawing.Size(224, 22)
        Me.txtDbase3.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(6, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Secondary:"
        '
        'txtDbase2
        '
        Me.txtDbase2.EditValue = ""
        Me.txtDbase2.Location = New System.Drawing.Point(81, 54)
        Me.txtDbase2.Name = "txtDbase2"
        Me.txtDbase2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDbase2.Properties.Appearance.Options.UseFont = True
        Me.txtDbase2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtDbase2.Size = New System.Drawing.Size(224, 22)
        Me.txtDbase2.TabIndex = 62
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(216, 8)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(93, 29)
        Me.SimpleButton2.TabIndex = 65
        Me.SimpleButton2.Text = "&Close"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SimpleButton2)
        Me.PanelControl1.Controls.Add(Me.btnsave)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 154)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(322, 45)
        Me.PanelControl1.TabIndex = 68
        '
        'txtdbase
        '
        Me.txtdbase.EditValue = ""
        Me.txtdbase.Location = New System.Drawing.Point(84, 117)
        Me.txtdbase.Name = "txtdbase"
        Me.txtdbase.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdbase.Properties.Appearance.Options.UseFont = True
        Me.txtdbase.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtdbase.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtdbase.Size = New System.Drawing.Size(227, 22)
        Me.txtdbase.TabIndex = 216
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(14, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 217
        Me.Label7.Text = "Database:"
        '
        'frmconnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 199)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.lbltimes)
        Me.Controls.Add(Me.GroupControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmconnection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Server Configuration Settings"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtserver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtdbase1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDbase3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDbase2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtdbase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbltimes As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtdbase1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtserver As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblConnection As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDbase3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDbase2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LLhousehold As System.Windows.Forms.LinkLabel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtdbase As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As Label
End Class
