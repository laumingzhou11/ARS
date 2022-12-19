<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectVehicle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectVehicle))
        Me.dgVehicles = New DevExpress.XtraGrid.GridControl()
        Me.gvVehicles = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.txtHheadID = New System.Windows.Forms.TextBox()
        Me.txtselectedcode = New System.Windows.Forms.TextBox()
        Me.btnsearch = New DevExpress.XtraEditors.SimpleButton()
        Me.txtsearch = New DevExpress.XtraEditors.SearchControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.dgVehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvVehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgVehicles
        '
        Me.dgVehicles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgVehicles.Location = New System.Drawing.Point(0, 44)
        Me.dgVehicles.MainView = Me.gvVehicles
        Me.dgVehicles.Name = "dgVehicles"
        Me.dgVehicles.Size = New System.Drawing.Size(702, 491)
        Me.dgVehicles.TabIndex = 22
        Me.dgVehicles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvVehicles})
        '
        'gvVehicles
        '
        Me.gvVehicles.Appearance.Empty.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.gvVehicles.Appearance.Empty.Options.UseBackColor = True
        Me.gvVehicles.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvVehicles.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvVehicles.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvVehicles.Appearance.GroupPanel.Options.UseFont = True
        Me.gvVehicles.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvVehicles.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvVehicles.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvVehicles.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvVehicles.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvVehicles.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvVehicles.Appearance.Row.Options.UseFont = True
        Me.gvVehicles.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gvVehicles.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.gvVehicles.DetailHeight = 327
        Me.gvVehicles.GridControl = Me.dgVehicles
        Me.gvVehicles.Name = "gvVehicles"
        Me.gvVehicles.OptionsBehavior.Editable = False
        Me.gvVehicles.OptionsSelection.MultiSelect = True
        Me.gvVehicles.OptionsView.ColumnAutoWidth = False
        Me.gvVehicles.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvVehicles.OptionsView.EnableAppearanceEvenRow = True
        Me.gvVehicles.OptionsView.EnableAppearanceOddRow = True
        Me.gvVehicles.OptionsView.ShowFooter = True
        Me.gvVehicles.OptionsView.ShowGroupPanel = False
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Nothing
        Me.barDockControlTop.Size = New System.Drawing.Size(702, 0)
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
        Me.PanelControl1.Size = New System.Drawing.Size(702, 44)
        Me.PanelControl1.TabIndex = 21
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnsave)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 535)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(702, 47)
        Me.PanelControl2.TabIndex = 24
        '
        'btnsave
        '
        Me.btnsave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Appearance.Options.UseFont = True
        Me.btnsave.ImageOptions.Image = CType(resources.GetObject("btnsave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(606, 7)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(90, 31)
        Me.btnsave.TabIndex = 20
        Me.btnsave.Text = "&Select"
        '
        'frmSelectVehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 582)
        Me.Controls.Add(Me.dgVehicles)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectVehicle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Vehicle"
        CType(Me.dgVehicles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvVehicles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgVehicles As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvVehicles As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtHheadID As TextBox
    Friend WithEvents txtselectedcode As TextBox
    Friend WithEvents btnsearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtsearch As DevExpress.XtraEditors.SearchControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
End Class
