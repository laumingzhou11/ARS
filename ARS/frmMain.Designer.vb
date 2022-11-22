<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim SkinPaddingEdges1 As DevExpress.Skins.SkinPaddingEdges = New DevExpress.Skins.SkinPaddingEdges()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnProducts = New DevExpress.XtraBars.BarButtonItem()
        Me.btnpositions = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSuppliers = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTanks = New DevExpress.XtraBars.BarButtonItem()
        Me.btnVehicles = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTankTransactions = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAutoTransactions = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinDropDownButtonItem1 = New DevExpress.XtraBars.SkinDropDownButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.lblid = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem7 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.lblacctType = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem4 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.lbluser = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem5 = New DevExpress.XtraBars.BarStaticItem()
        Me.SkinRibbonGalleryBarItem3 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.BarStaticItem9 = New DevExpress.XtraBars.BarStaticItem()
        Me.lblPosition = New DevExpress.XtraBars.BarStaticItem()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.RibbonControl.SearchEditItem, Me.btnProducts, Me.btnpositions, Me.btnSuppliers, Me.btnTanks, Me.btnVehicles, Me.btnTankTransactions, Me.btnAutoTransactions, Me.BarButtonItem1, Me.BarButtonItem2, Me.SkinDropDownButtonItem1, Me.BarButtonItem3, Me.BarButtonItem4})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 13
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.Size = New System.Drawing.Size(1217, 165)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar1
        Me.RibbonControl.Visible = False
        '
        'btnProducts
        '
        Me.btnProducts.Caption = "Products"
        Me.btnProducts.Id = 1
        Me.btnProducts.ImageOptions.Image = CType(resources.GetObject("btnProducts.ImageOptions.Image"), System.Drawing.Image)
        Me.btnProducts.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducts.ItemAppearance.Normal.Options.UseFont = True
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnpositions
        '
        Me.btnpositions.Caption = "Positions"
        Me.btnpositions.Id = 2
        Me.btnpositions.ImageOptions.Image = Global.ARS.My.Resources.Resources.icons8_user_folder_32
        Me.btnpositions.Name = "btnpositions"
        Me.btnpositions.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnSuppliers
        '
        Me.btnSuppliers.Caption = "Suppliers"
        Me.btnSuppliers.Id = 3
        Me.btnSuppliers.ImageOptions.Image = CType(resources.GetObject("btnSuppliers.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSuppliers.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuppliers.ItemAppearance.Normal.Options.UseFont = True
        Me.btnSuppliers.Name = "btnSuppliers"
        Me.btnSuppliers.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnTanks
        '
        Me.btnTanks.Caption = "Tanks"
        Me.btnTanks.Id = 4
        Me.btnTanks.ImageOptions.Image = CType(resources.GetObject("btnTanks.ImageOptions.Image"), System.Drawing.Image)
        Me.btnTanks.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTanks.ItemAppearance.Normal.Options.UseFont = True
        Me.btnTanks.Name = "btnTanks"
        Me.btnTanks.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnVehicles
        '
        Me.btnVehicles.Caption = "Vehicles"
        Me.btnVehicles.Id = 5
        Me.btnVehicles.ImageOptions.Image = CType(resources.GetObject("btnVehicles.ImageOptions.Image"), System.Drawing.Image)
        Me.btnVehicles.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVehicles.ItemAppearance.Normal.Options.UseFont = True
        Me.btnVehicles.Name = "btnVehicles"
        Me.btnVehicles.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnTankTransactions
        '
        Me.btnTankTransactions.Caption = "Tank Refuelling"
        Me.btnTankTransactions.Id = 6
        Me.btnTankTransactions.ImageOptions.Image = CType(resources.GetObject("btnTankTransactions.ImageOptions.Image"), System.Drawing.Image)
        Me.btnTankTransactions.ItemInMenuAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTankTransactions.ItemInMenuAppearance.Normal.Options.UseFont = True
        Me.btnTankTransactions.Name = "btnTankTransactions"
        Me.btnTankTransactions.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnAutoTransactions
        '
        Me.btnAutoTransactions.Caption = "Vehicles Refuelling"
        Me.btnAutoTransactions.Id = 7
        Me.btnAutoTransactions.ImageOptions.Image = Global.ARS.My.Resources.Resources.icons8_transaction_32
        Me.btnAutoTransactions.ItemInMenuAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutoTransactions.ItemInMenuAppearance.Normal.Options.UseFont = True
        Me.btnAutoTransactions.Name = "btnAutoTransactions"
        Me.btnAutoTransactions.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 8
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Users"
        Me.BarButtonItem2.Id = 9
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarButtonItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'SkinDropDownButtonItem1
        '
        Me.SkinDropDownButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.SkinDropDownButtonItem1.Id = 10
        Me.SkinDropDownButtonItem1.Name = "SkinDropDownButtonItem1"
        Me.SkinDropDownButtonItem1.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Tank Transaction Report"
        Me.BarButtonItem3.Id = 11
        Me.BarButtonItem3.ImageOptions.Image = Global.ARS.My.Resources.Resources.icons8_report_file_32
        Me.BarButtonItem3.ItemInMenuAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarButtonItem3.ItemInMenuAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Vehicle Transaction Report"
        Me.BarButtonItem4.Id = 12
        Me.BarButtonItem4.ImageOptions.Image = Global.ARS.My.Resources.Resources.icons8_report_file_32
        Me.BarButtonItem4.ItemInMenuAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarButtonItem4.ItemInMenuAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibbonPage1.Appearance.Options.UseFont = True
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4, Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.RibbonPage1.ImageOptions.Image = CType(resources.GetObject("RibbonPage1.ImageOptions.Image"), System.Drawing.Image)
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Home"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnpositions)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "USER ACCOUNTS"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnProducts)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnTanks)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSuppliers)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnVehicles)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "DIRECTORIES"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnTankTransactions)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnAutoTransactions)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "TRANSACTIONS"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem4)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "REPORTS"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem2)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.lblid)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem7)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem3)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.lblacctType)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem4)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarButtonItem7)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.lbluser)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem5)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.SkinRibbonGalleryBarItem3)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.BarStaticItem9)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.lblPosition)
        Me.RibbonStatusBar1.ItemLinks.Add(Me.SkinDropDownButtonItem1)
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 569)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1217, 26)
        Me.RibbonStatusBar1.Visible = False
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "UserID:"
        Me.BarStaticItem2.Id = 15
        Me.BarStaticItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BarStaticItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'lblid
        '
        Me.lblid.Id = 26
        Me.lblid.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblid.ItemAppearance.Normal.Options.UseFont = True
        Me.lblid.Name = "lblid"
        '
        'BarStaticItem7
        '
        Me.BarStaticItem7.Caption = "   "
        Me.BarStaticItem7.Id = 84
        Me.BarStaticItem7.Name = "BarStaticItem7"
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "User Type:"
        Me.BarStaticItem3.Id = 18
        Me.BarStaticItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BarStaticItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem3.Name = "BarStaticItem3"
        '
        'lblacctType
        '
        Me.lblacctType.Id = 19
        Me.lblacctType.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblacctType.ItemAppearance.Normal.Options.UseFont = True
        Me.lblacctType.Name = "lblacctType"
        '
        'BarStaticItem4
        '
        Me.BarStaticItem4.Caption = "   "
        Me.BarStaticItem4.Id = 83
        Me.BarStaticItem4.Name = "BarStaticItem4"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Name:"
        Me.BarButtonItem7.Id = 24
        Me.BarButtonItem7.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.BarButtonItem7.ItemAppearance.Normal.Options.UseFont = True
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'lbluser
        '
        Me.lbluser.Id = 16
        Me.lbluser.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lbluser.ItemAppearance.Normal.Options.UseFont = True
        Me.lbluser.Name = "lbluser"
        '
        'BarStaticItem5
        '
        Me.BarStaticItem5.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.BarStaticItem5.Caption = "          "
        Me.BarStaticItem5.Id = 69
        Me.BarStaticItem5.Name = "BarStaticItem5"
        '
        'SkinRibbonGalleryBarItem3
        '
        Me.SkinRibbonGalleryBarItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.SkinRibbonGalleryBarItem3.Caption = "Select Skin"
        '
        '
        '
        Me.SkinRibbonGalleryBarItem3.Gallery.AllowHoverImages = True
        Me.SkinRibbonGalleryBarItem3.Gallery.ColumnCount = 4
        Me.SkinRibbonGalleryBarItem3.Gallery.FixedHoverImageSize = False
        Me.SkinRibbonGalleryBarItem3.Gallery.ImageSize = New System.Drawing.Size(16, 16)
        Me.SkinRibbonGalleryBarItem3.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
        Me.SkinRibbonGalleryBarItem3.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.Squeeze
        Me.SkinRibbonGalleryBarItem3.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Top
        SkinPaddingEdges1.Left = 8
        SkinPaddingEdges1.Right = 8
        Me.SkinRibbonGalleryBarItem3.Gallery.ItemImagePadding = SkinPaddingEdges1
        Me.SkinRibbonGalleryBarItem3.Id = 68
        Me.SkinRibbonGalleryBarItem3.ImageOptions.Image = CType(resources.GetObject("SkinRibbonGalleryBarItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.SkinRibbonGalleryBarItem3.ImageOptions.SvgImage = CType(resources.GetObject("SkinRibbonGalleryBarItem3.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SkinRibbonGalleryBarItem3.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SkinRibbonGalleryBarItem3.ItemAppearance.Normal.Options.UseFont = True
        Me.SkinRibbonGalleryBarItem3.Name = "SkinRibbonGalleryBarItem3"
        '
        'BarStaticItem9
        '
        Me.BarStaticItem9.Caption = "   "
        Me.BarStaticItem9.Id = 139
        Me.BarStaticItem9.Name = "BarStaticItem9"
        '
        'lblPosition
        '
        Me.lblPosition.Id = 141
        Me.lblPosition.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.ItemAppearance.Normal.Options.UseFont = True
        Me.lblPosition.Name = "lblPosition"
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'frmMain
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 595)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar1
        Me.Text = "Automated Refuelling Solutions"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnProducts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnpositions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSuppliers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTanks As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVehicles As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTankTransactions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAutoTransactions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblid As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem7 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblacctType As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem4 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lbluser As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem5 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents SkinRibbonGalleryBarItem3 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents BarStaticItem9 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblPosition As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents SkinDropDownButtonItem1 As DevExpress.XtraBars.SkinDropDownButtonItem
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
End Class
