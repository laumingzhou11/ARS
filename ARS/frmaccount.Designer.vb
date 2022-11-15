<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaccount
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmaccount))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnsave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnedit = New DevExpress.XtraBars.BarButtonItem()
        Me.btndelete = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.btnclear = New DevExpress.XtraBars.BarButtonItem()
        Me.lblcount = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.cmdadd = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarListItem1 = New DevExpress.XtraBars.BarListItem()
        Me.BarStaticItem4 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.dgaccount = New DevExpress.XtraGrid.GridControl()
        Me.account = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtselectedcode = New System.Windows.Forms.TextBox()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.BarManager2 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar5 = New DevExpress.XtraBars.Bar()
        Me.count = New DevExpress.XtraBars.BarStaticItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl5 = New DevExpress.XtraBars.BarDockControl()
        Me.btnadd = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem5 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgaccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.account, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnsave, Me.btnedit, Me.btndelete, Me.btnclear, Me.lblcount, Me.BarStaticItem1, Me.cmdadd, Me.BarButtonItem1, Me.BarStaticItem2, Me.BarListItem1, Me.BarStaticItem4, Me.BarButtonItem5})
        Me.BarManager1.MaxItemId = 15
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnsave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnedit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btndelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.Text = "Tools"
        '
        'btnsave
        '
        Me.btnsave.Caption = "&ADD"
        Me.btnsave.Id = 0
        Me.btnsave.ImageOptions.Image = CType(resources.GetObject("btnsave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnsave.ImageOptions.LargeImage = CType(resources.GetObject("btnsave.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnsave.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ItemAppearance.Normal.Options.UseFont = True
        Me.btnsave.Name = "btnsave"
        '
        'btnedit
        '
        Me.btnedit.Caption = "&EDIT"
        Me.btnedit.Id = 1
        Me.btnedit.ImageOptions.Image = CType(resources.GetObject("btnedit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnedit.ImageOptions.LargeImage = CType(resources.GetObject("btnedit.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnedit.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ItemAppearance.Normal.Options.UseFont = True
        Me.btnedit.Name = "btnedit"
        '
        'btndelete
        '
        Me.btndelete.Caption = "&DELETE"
        Me.btndelete.Id = 2
        Me.btndelete.ImageOptions.Image = CType(resources.GetObject("btndelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btndelete.ImageOptions.LargeImage = CType(resources.GetObject("btndelete.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btndelete.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ItemAppearance.Normal.Options.UseFont = True
        Me.btndelete.Name = "btndelete"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(579, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 361)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(579, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 337)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(579, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 337)
        '
        'btnclear
        '
        Me.btnclear.Caption = "&PRINT (F4)"
        Me.btnclear.Id = 3
        Me.btnclear.ImageOptions.Image = CType(resources.GetObject("btnclear.ImageOptions.Image"), System.Drawing.Image)
        Me.btnclear.ImageOptions.LargeImage = CType(resources.GetObject("btnclear.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnclear.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ItemAppearance.Normal.Options.UseFont = True
        Me.btnclear.Name = "btnclear"
        '
        'lblcount
        '
        Me.lblcount.Id = 7
        Me.lblcount.Name = "lblcount"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "-"
        Me.BarStaticItem1.Id = 5
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'cmdadd
        '
        Me.cmdadd.Caption = "RESTRICTIONS"
        Me.cmdadd.Id = 8
        Me.cmdadd.Name = "cmdadd"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 10
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "-"
        Me.BarStaticItem2.Id = 11
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'BarListItem1
        '
        Me.BarListItem1.Caption = "BarListItem1"
        Me.BarListItem1.Id = 12
        Me.BarListItem1.Name = "BarListItem1"
        '
        'BarStaticItem4
        '
        Me.BarStaticItem4.Caption = "BarStaticItem4"
        Me.BarStaticItem4.Id = 13
        Me.BarStaticItem4.Name = "BarStaticItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "BarButtonItem5"
        Me.BarButtonItem5.Id = 14
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.dgaccount)
        Me.PanelControl1.Controls.Add(Me.txtselectedcode)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 24)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(579, 337)
        Me.PanelControl1.TabIndex = 4
        '
        'dgaccount
        '
        Me.dgaccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgaccount.Location = New System.Drawing.Point(2, 2)
        Me.dgaccount.MainView = Me.account
        Me.dgaccount.MenuManager = Me.BarManager1
        Me.dgaccount.Name = "dgaccount"
        Me.dgaccount.Size = New System.Drawing.Size(575, 333)
        Me.dgaccount.TabIndex = 2
        Me.dgaccount.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.account})
        '
        'account
        '
        Me.account.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.account.Appearance.HeaderPanel.Options.UseFont = True
        Me.account.GridControl = Me.dgaccount
        Me.account.Name = "account"
        Me.account.OptionsBehavior.Editable = False
        Me.account.OptionsView.ColumnAutoWidth = False
        Me.account.OptionsView.ShowGroupPanel = False
        '
        'txtselectedcode
        '
        Me.txtselectedcode.Location = New System.Drawing.Point(43, 77)
        Me.txtselectedcode.Name = "txtselectedcode"
        Me.txtselectedcode.Size = New System.Drawing.Size(100, 21)
        Me.txtselectedcode.TabIndex = 1
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdadd)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "-"
        Me.BarStaticItem3.Id = 5
        Me.BarStaticItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarStaticItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem3.Name = "BarStaticItem3"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem4)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarManager2
        '
        Me.BarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar5})
        Me.BarManager2.DockControls.Add(Me.BarDockControl1)
        Me.BarManager2.DockControls.Add(Me.BarDockControl2)
        Me.BarManager2.DockControls.Add(Me.BarDockControl3)
        Me.BarManager2.DockControls.Add(Me.BarDockControl5)
        Me.BarManager2.Form = Me
        Me.BarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.count, Me.btnadd, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarStaticItem5})
        Me.BarManager2.MaxItemId = 1
        Me.BarManager2.StatusBar = Me.Bar5
        '
        'Bar5
        '
        Me.Bar5.BarName = "Custom 4"
        Me.Bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar5.DockCol = 0
        Me.Bar5.DockRow = 0
        Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.count)})
        Me.Bar5.OptionsBar.AllowQuickCustomization = False
        Me.Bar5.OptionsBar.DrawDragBorder = False
        Me.Bar5.OptionsBar.UseWholeRow = True
        Me.Bar5.Text = "Custom 4"
        '
        'count
        '
        Me.count.Caption = "-"
        Me.count.Id = 0
        Me.count.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.count.ItemAppearance.Normal.Options.UseFont = True
        Me.count.Name = "count"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager2
        Me.BarDockControl1.Size = New System.Drawing.Size(579, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 361)
        Me.BarDockControl2.Manager = Me.BarManager2
        Me.BarDockControl2.Size = New System.Drawing.Size(579, 22)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Manager = Me.BarManager2
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 361)
        '
        'BarDockControl5
        '
        Me.BarDockControl5.CausesValidation = False
        Me.BarDockControl5.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl5.Location = New System.Drawing.Point(579, 0)
        Me.BarDockControl5.Manager = Me.BarManager2
        Me.BarDockControl5.Size = New System.Drawing.Size(0, 361)
        '
        'btnadd
        '
        Me.btnadd.Caption = "ADD (F1)"
        Me.btnadd.Id = 1
        Me.btnadd.ImageOptions.Image = CType(resources.GetObject("btnadd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnadd.ImageOptions.LargeImage = CType(resources.GetObject("btnadd.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnadd.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ItemAppearance.Normal.Options.UseFont = True
        Me.btnadd.Name = "btnadd"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "EDIT (F2)"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.AllowRightClickInMenu = False
        Me.BarButtonItem3.Caption = "DELETE (F3)"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "PRINT (F4)"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.ImageOptions.Image = CType(resources.GetObject("BarButtonItem4.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem4.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarStaticItem5
        '
        Me.BarStaticItem5.Caption = "-"
        Me.BarStaticItem5.Id = 5
        Me.BarStaticItem5.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarStaticItem5.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem5.Name = "BarStaticItem5"
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(579, 24)
        Me.BarDockControl4.Manager = Me.BarManager2
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 337)
        '
        'frmaccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 383)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl5)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmaccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Settings"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dgaccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.account, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnsave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnedit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btndelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnclear As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblcount As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txtselectedcode As System.Windows.Forms.TextBox
    Friend WithEvents cmdadd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents dgaccount As DevExpress.XtraGrid.GridControl
    Friend WithEvents account As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarListItem1 As DevExpress.XtraBars.BarListItem
    Friend WithEvents BarStaticItem4 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager2 As DevExpress.XtraBars.BarManager
    Friend WithEvents btnadd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem5 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
    Friend WithEvents count As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl5 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
End Class
