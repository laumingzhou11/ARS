<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuppliers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuppliers))
        Me.gvsupplier = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dgsupplier = New DevExpress.XtraGrid.GridControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btnadd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnedit = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.lblcount = New DevExpress.XtraBars.BarStaticItem()
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnreload = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintID = New DevExpress.XtraBars.BarButtonItem()
        Me.btnProfile = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnprBarcode = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemPageNumberEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit()
        Me.txtHheadID = New System.Windows.Forms.TextBox()
        Me.txtselectedcode = New System.Windows.Forms.TextBox()
        Me.btnsearch = New DevExpress.XtraEditors.SimpleButton()
        Me.txtsearch = New DevExpress.XtraEditors.SearchControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        CType(Me.gvsupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgsupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPageNumberEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtsearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gvsupplier
        '
        Me.gvsupplier.Appearance.Empty.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.gvsupplier.Appearance.Empty.Options.UseBackColor = True
        Me.gvsupplier.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gvsupplier.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gvsupplier.Appearance.GroupPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvsupplier.Appearance.GroupPanel.Options.UseFont = True
        Me.gvsupplier.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvsupplier.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvsupplier.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvsupplier.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvsupplier.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvsupplier.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvsupplier.Appearance.Row.Options.UseFont = True
        Me.gvsupplier.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gvsupplier.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.gvsupplier.DetailHeight = 327
        Me.gvsupplier.GridControl = Me.dgsupplier
        Me.gvsupplier.Name = "gvsupplier"
        Me.gvsupplier.OptionsBehavior.Editable = False
        Me.gvsupplier.OptionsSelection.MultiSelect = True
        Me.gvsupplier.OptionsView.ColumnAutoWidth = False
        Me.gvsupplier.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvsupplier.OptionsView.EnableAppearanceEvenRow = True
        Me.gvsupplier.OptionsView.EnableAppearanceOddRow = True
        Me.gvsupplier.OptionsView.ShowFooter = True
        '
        'dgsupplier
        '
        Me.dgsupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgsupplier.Location = New System.Drawing.Point(0, 88)
        Me.dgsupplier.MainView = Me.gvsupplier
        Me.dgsupplier.MenuManager = Me.BarManager1
        Me.dgsupplier.Name = "dgsupplier"
        Me.dgsupplier.Size = New System.Drawing.Size(692, 350)
        Me.dgsupplier.TabIndex = 11
        Me.dgsupplier.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvsupplier})
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.BarDockControl1)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarCheckItem1, Me.btnadd, Me.btnedit, Me.BarButtonItem3, Me.BarButtonItem4, Me.lblcount, Me.btnreload, Me.btnPrintID, Me.btnProfile, Me.BarButtonItem1, Me.btnprBarcode})
        Me.BarManager1.MaxItemId = 71
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPageNumberEdit1})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(416, 148)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnadd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnedit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BarButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.Text = "Tools"
        '
        'btnadd
        '
        Me.btnadd.Caption = "ADD"
        Me.btnadd.Id = 1
        Me.btnadd.ImageOptions.Image = CType(resources.GetObject("btnadd.ImageOptions.Image"), System.Drawing.Image)
        Me.btnadd.ImageOptions.LargeImage = CType(resources.GetObject("btnadd.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnadd.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ItemAppearance.Normal.Options.UseFont = True
        Me.btnadd.Name = "btnadd"
        '
        'btnedit
        '
        Me.btnedit.Caption = "EDIT"
        Me.btnedit.Id = 2
        Me.btnedit.ImageOptions.Image = CType(resources.GetObject("btnedit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnedit.ImageOptions.LargeImage = CType(resources.GetObject("btnedit.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnedit.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ItemAppearance.Normal.Options.UseFont = True
        Me.btnedit.Name = "btnedit"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.AllowRightClickInMenu = False
        Me.BarButtonItem3.Caption = "&PRINT"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarButtonItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.lblcount)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'lblcount
        '
        Me.lblcount.Caption = "-"
        Me.lblcount.Id = 5
        Me.lblcount.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcount.ItemAppearance.Normal.Options.UseFont = True
        Me.lblcount.Name = "lblcount"
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Manager = Me.BarManager1
        Me.BarDockControl1.Size = New System.Drawing.Size(692, 44)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 438)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(692, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 44)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 394)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(692, 44)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 394)
        '
        'BarCheckItem1
        '
        Me.BarCheckItem1.Caption = "BarCheckItem1"
        Me.BarCheckItem1.Id = 0
        Me.BarCheckItem1.Name = "BarCheckItem1"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.ActAsDropDown = True
        Me.BarButtonItem4.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.BarButtonItem4.Caption = "&PRINT"
        Me.BarButtonItem4.Id = 4
        Me.BarButtonItem4.ImageOptions.Image = CType(resources.GetObject("BarButtonItem4.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem4.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem4.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarButtonItem4.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'btnreload
        '
        Me.btnreload.Caption = "RELOAD (F5)"
        Me.btnreload.Id = 6
        Me.btnreload.ImageOptions.Image = CType(resources.GetObject("btnreload.ImageOptions.Image"), System.Drawing.Image)
        Me.btnreload.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnreload.ItemAppearance.Normal.Options.UseFont = True
        Me.btnreload.Name = "btnreload"
        '
        'btnPrintID
        '
        Me.btnPrintID.Caption = "PRINT ID"
        Me.btnPrintID.Id = 7
        Me.btnPrintID.ImageOptions.Image = CType(resources.GetObject("btnPrintID.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrintID.ImageOptions.LargeImage = CType(resources.GetObject("btnPrintID.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrintID.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintID.ItemAppearance.Normal.Options.UseFont = True
        Me.btnPrintID.Name = "btnPrintID"
        '
        'btnProfile
        '
        Me.btnProfile.Caption = "PRINT PROFILE"
        Me.btnProfile.Id = 8
        Me.btnProfile.ImageOptions.Image = CType(resources.GetObject("btnProfile.ImageOptions.Image"), System.Drawing.Image)
        Me.btnProfile.ImageOptions.LargeImage = CType(resources.GetObject("btnProfile.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnProfile.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.ItemAppearance.Normal.Options.UseFont = True
        Me.btnProfile.Name = "btnProfile"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 9
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnprBarcode
        '
        Me.btnprBarcode.Caption = "PRINT BARCODE"
        Me.btnprBarcode.Id = 10
        Me.btnprBarcode.ImageOptions.Image = CType(resources.GetObject("btnprBarcode.ImageOptions.Image"), System.Drawing.Image)
        Me.btnprBarcode.ImageOptions.LargeImage = CType(resources.GetObject("btnprBarcode.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnprBarcode.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprBarcode.ItemAppearance.Normal.Options.UseFont = True
        Me.btnprBarcode.Name = "btnprBarcode"
        '
        'RepositoryItemPageNumberEdit1
        '
        Me.RepositoryItemPageNumberEdit1.AutoHeight = False
        Me.RepositoryItemPageNumberEdit1.Mask.EditMask = "########;"
        Me.RepositoryItemPageNumberEdit1.Name = "RepositoryItemPageNumberEdit1"
        Me.RepositoryItemPageNumberEdit1.Orientation = DevExpress.XtraEditors.PagerOrientation.Horizontal
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
        Me.txtsearch.MenuManager = Me.BarManager1
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
        Me.PanelControl1.Location = New System.Drawing.Point(0, 44)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(692, 44)
        Me.PanelControl1.TabIndex = 10
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 44)
        Me.barDockControlTop.Manager = Nothing
        Me.barDockControlTop.Size = New System.Drawing.Size(692, 0)
        '
        'frmSuppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 463)
        Me.Controls.Add(Me.dgsupplier)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.BarDockControl1)
        Me.IconOptions.Image = CType(resources.GetObject("frmSuppliers.IconOptions.Image"), System.Drawing.Image)
        Me.Name = "frmSuppliers"
        Me.Text = "Suppliers"
        CType(Me.gvsupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgsupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPageNumberEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtsearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gvsupplier As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgsupplier As DevExpress.XtraGrid.GridControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnadd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnedit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents lblcount As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtHheadID As TextBox
    Friend WithEvents txtselectedcode As TextBox
    Friend WithEvents btnsearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtsearch As DevExpress.XtraEditors.SearchControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarCheckItem1 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnreload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintID As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnProfile As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnprBarcode As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemPageNumberEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPageNumberEdit
End Class
