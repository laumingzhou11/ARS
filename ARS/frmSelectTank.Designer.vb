<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectTank
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectTank))
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.txtHheadID = New System.Windows.Forms.TextBox()
        Me.txtselectedcode = New System.Windows.Forms.TextBox()
        Me.btnsearch = New DevExpress.XtraEditors.SimpleButton()
        Me.txtsearch = New DevExpress.XtraEditors.SearchControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton()
        Me.gvTank = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dgTank = New DevExpress.XtraGrid.GridControl()
        CType(Me.txtsearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.gvTank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Nothing
        Me.barDockControlTop.Size = New System.Drawing.Size(479, 0)
        '
        'txtHheadID
        '
        Me.txtHheadID.Location = New System.Drawing.Point(695, 51)
        Me.txtHheadID.Name = "txtHheadID"
        Me.txtHheadID.Size = New System.Drawing.Size(108, 21)
        Me.txtHheadID.TabIndex = 4
        '
        'txtselectedcode
        '
        Me.txtselectedcode.Location = New System.Drawing.Point(581, 51)
        Me.txtselectedcode.Name = "txtselectedcode"
        Me.txtselectedcode.Size = New System.Drawing.Size(108, 21)
        Me.txtselectedcode.TabIndex = 3
        '
        'btnsearch
        '
        Me.btnsearch.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Appearance.Options.UseFont = True
        Me.btnsearch.ImageOptions.Image = CType(resources.GetObject("btnsearch.ImageOptions.Image"), System.Drawing.Image)
        Me.btnsearch.Location = New System.Drawing.Point(368, 10)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(87, 23)
        Me.btnsearch.TabIndex = 1
        Me.btnsearch.Text = "Search"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(6, 10)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Properties.Appearance.Options.UseFont = True
        Me.txtsearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtsearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.txtsearch.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsearch.Size = New System.Drawing.Size(359, 22)
        Me.txtsearch.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtHheadID)
        Me.PanelControl1.Controls.Add(Me.txtselectedcode)
        Me.PanelControl1.Controls.Add(Me.btnsearch)
        Me.PanelControl1.Controls.Add(Me.txtsearch)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(479, 44)
        Me.PanelControl1.TabIndex = 13
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnsave)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 362)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(479, 47)
        Me.PanelControl2.TabIndex = 16
        '
        'btnsave
        '
        Me.btnsave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Appearance.Options.UseFont = True
        Me.btnsave.ImageOptions.Image = CType(resources.GetObject("btnsave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(381, 8)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(90, 31)
        Me.btnsave.TabIndex = 20
        Me.btnsave.Text = "&Select"
        '
        'gvTank
        '
        Me.gvTank.Appearance.Empty.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.gvTank.Appearance.Empty.Options.UseBackColor = True
        Me.gvTank.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvTank.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvTank.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvTank.Appearance.GroupPanel.Options.UseFont = True
        Me.gvTank.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvTank.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvTank.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvTank.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvTank.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvTank.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvTank.Appearance.Row.Options.UseFont = True
        Me.gvTank.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gvTank.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.gvTank.DetailHeight = 327
        Me.gvTank.GridControl = Me.dgTank
        Me.gvTank.Name = "gvTank"
        Me.gvTank.OptionsBehavior.Editable = False
        Me.gvTank.OptionsSelection.MultiSelect = True
        Me.gvTank.OptionsView.ColumnAutoWidth = False
        Me.gvTank.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvTank.OptionsView.EnableAppearanceEvenRow = True
        Me.gvTank.OptionsView.EnableAppearanceOddRow = True
        Me.gvTank.OptionsView.ShowFooter = True
        Me.gvTank.OptionsView.ShowGroupPanel = False
        '
        'dgTank
        '
        Me.dgTank.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTank.Location = New System.Drawing.Point(0, 44)
        Me.dgTank.MainView = Me.gvTank
        Me.dgTank.Name = "dgTank"
        Me.dgTank.Size = New System.Drawing.Size(479, 318)
        Me.dgTank.TabIndex = 14
        Me.dgTank.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTank})
        '
        'frmSelectTank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 409)
        Me.Controls.Add(Me.dgTank)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.PanelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectTank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Tank"
        CType(Me.txtsearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.gvTank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtHheadID As TextBox
    Friend WithEvents txtselectedcode As TextBox
    Friend WithEvents btnsearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtsearch As DevExpress.XtraEditors.SearchControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gvTank As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgTank As DevExpress.XtraGrid.GridControl
End Class
