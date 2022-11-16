<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddEditProducts
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditProducts))
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.cbUom = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrice = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cbSupplier = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescription = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtProductID = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnsave = New DevExpress.XtraEditors.SimpleButton()
        Me.btncancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cbUom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbSupplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(64, 39)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(18, 14)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "ID:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(18, 46)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(0, 14)
        Me.LabelControl1.TabIndex = 19
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.cbUom)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txtPrice)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.cbSupplier)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtDescription)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtProductID)
        Me.GroupControl1.Controls.Add(Me.PanelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(376, 231)
        Me.GroupControl1.TabIndex = 21
        Me.GroupControl1.Text = "PRODUCT"
        '
        'cbUom
        '
        Me.cbUom.Location = New System.Drawing.Point(88, 196)
        Me.cbUom.Name = "cbUom"
        Me.cbUom.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUom.Properties.Appearance.Options.UseFont = True
        Me.cbUom.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbUom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbUom.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbUom.Size = New System.Drawing.Size(275, 22)
        Me.cbUom.TabIndex = 29
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(15, 200)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(66, 14)
        Me.LabelControl6.TabIndex = 28
        Me.LabelControl6.Text = "Uom Code:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(88, 168)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Properties.Appearance.Options.UseFont = True
        Me.txtPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtPrice.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrice.Size = New System.Drawing.Size(275, 22)
        Me.txtPrice.TabIndex = 27
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(48, 171)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(33, 14)
        Me.LabelControl5.TabIndex = 26
        Me.LabelControl5.Text = "Price:"
        '
        'cbSupplier
        '
        Me.cbSupplier.Location = New System.Drawing.Point(88, 140)
        Me.cbSupplier.Name = "cbSupplier"
        Me.cbSupplier.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSupplier.Properties.Appearance.Options.UseFont = True
        Me.cbSupplier.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cbSupplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbSupplier.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbSupplier.Size = New System.Drawing.Size(275, 22)
        Me.cbSupplier.TabIndex = 24
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(28, 143)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(54, 14)
        Me.LabelControl3.TabIndex = 23
        Me.LabelControl3.Text = "Supplier:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(88, 62)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Properties.Appearance.Options.UseFont = True
        Me.txtDescription.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtDescription.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescription.Size = New System.Drawing.Size(275, 64)
        Me.txtDescription.TabIndex = 22
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(9, 63)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(73, 14)
        Me.LabelControl2.TabIndex = 21
        Me.LabelControl2.Text = "Description:"
        '
        'txtProductID
        '
        Me.txtProductID.Enabled = False
        Me.txtProductID.Location = New System.Drawing.Point(88, 34)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductID.Properties.Appearance.Options.UseFont = True
        Me.txtProductID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtProductID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProductID.Size = New System.Drawing.Size(275, 22)
        Me.txtProductID.TabIndex = 18
        '
        'PanelControl1
        '
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(2, 132)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(372, 97)
        Me.PanelControl1.TabIndex = 30
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btnsave
        '
        Me.btnsave.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Appearance.Options.UseFont = True
        Me.btnsave.ImageOptions.Image = CType(resources.GetObject("btnsave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnsave.Location = New System.Drawing.Point(153, 240)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(103, 35)
        Me.btnsave.TabIndex = 23
        Me.btnsave.Text = "&Save"
        '
        'btncancel
        '
        Me.btncancel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Appearance.Options.UseFont = True
        Me.btncancel.ImageOptions.Image = CType(resources.GetObject("btncancel.ImageOptions.Image"), System.Drawing.Image)
        Me.btncancel.Location = New System.Drawing.Point(260, 240)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(103, 35)
        Me.btncancel.TabIndex = 24
        Me.btncancel.Text = "&Cancel"
        '
        'frmAddEditProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 284)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddEditProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Product"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cbUom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbSupplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbSupplier As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescription As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btncancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents cbUom As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
End Class
