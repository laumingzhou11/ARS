<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutoReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutoReport))
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpto = New DevExpress.XtraEditors.DateEdit()
        Me.dtpfrom = New DevExpress.XtraEditors.DateEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cbAuto = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnfilter = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dtpto.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpfrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpfrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cbAuto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.Label5)
        Me.GroupControl2.Controls.Add(Me.Label6)
        Me.GroupControl2.Controls.Add(Me.dtpto)
        Me.GroupControl2.Controls.Add(Me.dtpfrom)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 80)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(356, 80)
        Me.GroupControl2.TabIndex = 30
        Me.GroupControl2.Text = "Date Range"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(187, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "to:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "From:"
        '
        'dtpto
        '
        Me.dtpto.EditValue = Nothing
        Me.dtpto.Location = New System.Drawing.Point(212, 40)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.dtpto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpto.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpto.Size = New System.Drawing.Size(132, 22)
        Me.dtpto.TabIndex = 24
        '
        'dtpfrom
        '
        Me.dtpfrom.EditValue = Nothing
        Me.dtpfrom.Location = New System.Drawing.Point(51, 40)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.dtpfrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpfrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpfrom.Size = New System.Drawing.Size(132, 22)
        Me.dtpfrom.TabIndex = 23
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.cbAuto)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(356, 80)
        Me.GroupControl1.TabIndex = 29
        Me.GroupControl1.Text = "Criteria"
        '
        'cbAuto
        '
        Me.cbAuto.EditValue = ""
        Me.cbAuto.Location = New System.Drawing.Point(64, 42)
        Me.cbAuto.Name = "cbAuto"
        Me.cbAuto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAuto.Properties.Appearance.Options.UseFont = True
        Me.cbAuto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbAuto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAuto.Size = New System.Drawing.Size(280, 22)
        Me.cbAuto.TabIndex = 19
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(12, 45)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(46, 14)
        Me.LabelControl4.TabIndex = 18
        Me.LabelControl4.Text = "Vehicle:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(262, 168)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(87, 28)
        Me.SimpleButton1.TabIndex = 32
        Me.SimpleButton1.Text = "&Close"
        '
        'btnfilter
        '
        Me.btnfilter.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfilter.Appearance.Options.UseFont = True
        Me.btnfilter.ImageOptions.Image = CType(resources.GetObject("btnfilter.ImageOptions.Image"), System.Drawing.Image)
        Me.btnfilter.Location = New System.Drawing.Point(172, 168)
        Me.btnfilter.Name = "btnfilter"
        Me.btnfilter.Size = New System.Drawing.Size(87, 28)
        Me.btnfilter.TabIndex = 31
        Me.btnfilter.Text = "&Print"
        '
        'frmAutoReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 205)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnfilter)
        Me.IconOptions.Image = Global.ARS.My.Resources.Resources.icons8_report_file_32
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAutoReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicle Report"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.dtpto.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpfrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpfrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cbAuto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpto As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpfrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cbAuto As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnfilter As DevExpress.XtraEditors.SimpleButton
End Class
