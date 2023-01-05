Imports System.Data.SqlClient
Imports DevExpress
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils.Menu
Imports DevExpress.Utils
Imports DevExpress.Utils.Paint
Imports DevExpress.XtraGrid.Columns
Public Class frmAutoRefuelling
    Private Sub btnadd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnadd.ItemClick
        frmAddEditAutoRefuelling.PanelVehicle.Visible = False
        frmAddEditAutoRefuelling.GCTransaction.Enabled = False
        frmAddEditAutoRefuelling.gcHistory.Enabled = False
        frmAddEditAutoRefuelling.btnsave.Enabled = False
        frmAddEditAutoRefuelling.btncancel.Enabled = False
        frmAddEditAutoRefuelling.GCQrCode.Enabled = True
        frmAddEditAutoRefuelling.txtcode.Select()
        frmAddEditAutoRefuelling.Text = "Auto Refuelling - Stock Out"
        frmAddEditAutoRefuelling.xclear()
        frmAddEditAutoRefuelling.ShowDialog()
        frmAddEditAutoRefuelling.GCQrCode.Enabled = True

    End Sub
    Function populateAuto() As Boolean
        Call konneksyon()
        sql = "select a.AutoTransactionID as TransNo,format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at, " _
                & "a.PoNo,b.Name as Vehicle,c.Tankname as Tank,d1.SupplierName as Supplier,d.ItemDescription as Product,format(a.StockOut,'#,#.##') as Qty,format(a.Price,'c', 'fil-PH') as Price, " _
                & "format((select SUM(StockOut*Price) from tblAutoTransaction where AutoTransactionID=a.AutoTransactionID),'c', 'fil-PH') as TotalAmount,A. Refilled_by " _
                & "from tblAutoTransaction as a " _
                & "inner join tblVehicles as b on a.VehicleID=b.VehicleID " _
                & "inner join tbltank as c on a.TankID=c.TankID " _
                & "inner join tblProducts as d on a.ProductID=d.ProductID " _
                & "inner join tblSupplier as d1 on d.SupplierID=d1.SupplierID " _
                & "inner join tblEmpUsers as e on a.Added_by=e.EmpID where a.Deleted_at is null order by a.AutoTransactionID desc"
        Call populate(sql, dgAutoRefuelling)
        lblcount.Caption = gvAutoRefuelling.RowCount & " Record(s) Found"
        gvAutoRefuelling.BestFitColumns()
        gvAutoRefuelling.RowHeight = 20
        Return True
    End Function
    Private Sub frmAutoRefuelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call populateAuto()
    End Sub
    Function Search() As Boolean
        Try
            If txtsearch.Text <> "" Then
                Call konneksyon()
                sql = "select a.AutoTransactionID as TransNo,format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at, " _
                & "a.PoNo,b.Name as Vehicle,c.Tankname as Tank,d1.SupplierName as Supplier,d.ItemDescription as Product,format(a.StockOut,'#,#.##') as Qty,format(a.Price,'c', 'fil-PH') as Price, " _
                & "format((select SUM(StockOut*Price) from tblAutoTransaction where AutoTransactionID=a.AutoTransactionID),'c', 'fil-PH') as TotalAmount,A. Refilled_by " _
                & "from tblAutoTransaction as a " _
                & "inner join tblVehicles as b on a.VehicleID=b.VehicleID " _
                & "inner join tbltank as c on a.TankID=c.TankID " _
                & "inner join tblProducts as d on a.ProductID=d.ProductID " _
                & "inner join tblSupplier as d1 on d.SupplierID=d1.SupplierID " _
                & "inner join tblEmpUsers as e on a.Added_by=e.EmpID where c.TankName like '%" & txtsearch.Text & "%' and a.Deleted_at is null or " _
                & "a.PoNo like '%" & txtsearch.Text & "%' and a.Deleted_at is null or d.ItemDescription like '%" & txtsearch.Text & "%'  and a.Deleted_at is null or " _
                & "d1.SupplierName like '%" & txtsearch.Text & "%' and a.Deleted_at is null or a.Refilled_by like '%" & txtsearch.Text & "%' and a.Deleted_at is null or " _
                & "b.Name like '%" & txtsearch.Text & "%' and a.Deleted_at is null order by a.AutoTransactionID desc"
                Call populate(sql, dgAutoRefuelling)
                If dset.Tables(sql).Rows.Count > 0 Then
                    lblcount.Caption = gvAutoRefuelling.RowCount & " Record(s) Found"
                    gvAutoRefuelling.BestFitColumns()
                    gvAutoRefuelling.RowHeight = 20
                Else
                    MsgBox("No record found!", MsgBoxStyle.Information, Me.Text)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        Return True
    End Function
    Private Sub gvAutoRefuelling_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvAutoRefuelling.CustomDrawCell
        If Not Me.txtsearch.Text <> "" Then Return
        Dim view As GridView = CType(sender, GridView)
        If Not view.IsDataRow(e.RowHandle) Then Return

        Dim FindTextArray As String() = {txtsearch.Text}

        For Each FindText In FindTextArray
            Dim TextIndex As Integer = e.DisplayText.IndexOf(FindText, StringComparison.CurrentCultureIgnoreCase)
            If TextIndex > -1 Then
                XPaint.Graphics.DrawMultiColorString(e.Cache, e.Bounds, e.DisplayText, FindText, e.Appearance, Color.Black, Color.YellowGreen, False, TextIndex)
                e.Handled = True
            End If
        Next
    End Sub
    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        If Not (Asc(e.KeyChar)) = 8 Then
            Dim allowchar As String = "QWERTYUIOPLKJHGFDSAZXCVÑñBNMqwertyuioplkjhgfdsazxcvbnm1234567890-@., "
            If allowchar.IndexOf(e.KeyChar) = -1 Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = Chr(13) Then
            Call Search()
        End If
    End Sub
    Private Sub txtsearch_Enter(sender As Object, e As EventArgs) Handles txtsearch.Enter
        txtsearch.BackColor = Color.LightBlue

    End Sub
    Private Sub txtsearch_Leave(sender As Object, e As EventArgs) Handles txtsearch.Leave
        txtsearch.BackColor = Color.White

    End Sub

    Private Sub btnedit_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles btnedit.ItemClick
        If txtselectedcode.Text <> "" Then
            Call filltext()
            frmAddEditAutoRefuelling.Text = "Auto Refuelling - Edit Stock Out"
            frmAddEditAutoRefuelling.PanelVehicle.Visible = True
            frmAddEditAutoRefuelling.GCTransaction.Enabled = True
            frmAddEditAutoRefuelling.gcHistory.Enabled = True
            frmAddEditAutoRefuelling.btnsave.Enabled = True
            frmAddEditAutoRefuelling.btncancel.Enabled = True
            frmAddEditAutoRefuelling.txtPoNo.Select()
            frmAddEditAutoRefuelling.ShowDialog()
        Else
            MsgBox("Select record to edit!", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub
    Function filltext() As Boolean
        Call konneksyon()
        sql = "select a.AutoTransactionID as TransNo,b.VehicleID,b.code, b.Name,b.Model,b.Make, " _
                    & "b.CrNo,b.PlateNo,b.TankCapacity as CapacityA,b.Status,b.VehiclePic,b.Driver,b.DriverAddress,b.DriverPic, " _
                    & "c.TankName,c.TankID,c.TankCapacity as CapacityB,c.Location,c1.UomCode as uomA,a.PoNo,d.ProductID,d.ItemDescription, " _
                    & "d1.SupplierName,a.StockOut,a.Price,isnull((select TOp 1(select sum(Stockin-Stockout) " _
                    & "from tblTankInventory where ID<=a.ID And TankID=c.TankID) " _
                    & "from tblTankInventory As a where A.TankID=c.TankID order By ID desc),0) as AvailableStocks,a.Refilled_by,e.UomCode as uomB,a.SelectStock " _
                    & "from tblAutoTransaction as a " _
                    & "inner join tblVehicles as b on a.VehicleID=b.VehicleID " _
                    & "inner join tbltank as c on a.TankID=c.TankID " _
                    & "inner join tblUomCode as c1 on c.UomID=c1.ID " _
                    & "inner join tblProducts as d on a.ProductID=d.ProductID " _
                    & "inner join tblSupplier as d1 on d.SupplierID=d1.SupplierID " _
                    & "inner join tblUomCode as e on a.UomID=e.ID where a.AutoTransactionID='" & keyID & "'"
        Call fill(sql)
        frmAddEditAutoRefuelling.lblTransID.Text = dset.Tables(sql).Rows(0).Item("TransNo")
        frmAddEditAutoRefuelling.txtPoNo.Text = dset.Tables(sql).Rows(0).Item("PoNo")
        frmAddEditAutoRefuelling.lblVehicleID.Text = dset.Tables(sql).Rows(0).Item("VehicleID")
        frmAddEditAutoRefuelling.lblCOde.Text = dset.Tables(sql).Rows(0).Item("code")
        frmAddEditAutoRefuelling.lblVehicleName.Text = dset.Tables(sql).Rows(0).Item("Name")
        frmAddEditAutoRefuelling.lblModel.Text = dset.Tables(sql).Rows(0).Item("Model")
        frmAddEditAutoRefuelling.lblMake.Text = dset.Tables(sql).Rows(0).Item("Make")
        frmAddEditAutoRefuelling.lblCrNo.Text = dset.Tables(sql).Rows(0).Item("CrNo")
        frmAddEditAutoRefuelling.lblPlateNo.Text = dset.Tables(sql).Rows(0).Item("PlateNo")
        frmAddEditAutoRefuelling.lblCapacity.Text = dset.Tables(sql).Rows(0).Item("CapacityA")
        frmAddEditAutoRefuelling.lblStatus.Text = dset.Tables(sql).Rows(0).Item("Status")
        frmAddEditAutoRefuelling.lblDriverName.Text = dset.Tables(sql).Rows(0).Item("Driver")
        frmAddEditAutoRefuelling.lblAddress.Text = dset.Tables(sql).Rows(0).Item("DriverAddress")

        frmAddEditAutoRefuelling.txtPoNo.Text = dset.Tables(sql).Rows(0).Item("PoNo")
        frmAddEditAutoRefuelling.lblProductID.Text = dset.Tables(sql).Rows(0).Item("ProductID")
        frmAddEditAutoRefuelling.cbProduct.Text = dset.Tables(sql).Rows(0).Item("ItemDescription")
        frmAddEditAutoRefuelling.cbSupplier.Text = dset.Tables(sql).Rows(0).Item("SupplierName")
        frmAddEditAutoRefuelling.txtqty.Text = dset.Tables(sql).Rows(0).Item("StockOut")
        frmAddEditAutoRefuelling.txtprice.Text = dset.Tables(sql).Rows(0).Item("Price")
        frmAddEditAutoRefuelling.txtstocks.Text = dset.Tables(sql).Rows(0).Item("AvailableStocks")
        frmAddEditAutoRefuelling.txtRefilledby.Text = dset.Tables(sql).Rows(0).Item("Refilled_by")
        frmAddEditAutoRefuelling.cbUomCode.Text = dset.Tables(sql).Rows(0).Item("uomB")
        If IsDBNull(dset.Tables(sql).Rows(0).Item("VehiclePic")) Then
            frmAddEditAutoRefuelling.VehiclePic.Image = Nothing
        Else
            Dim mstream As New System.IO.MemoryStream
            Dim photo As Byte() = dset.Tables(sql).Rows(0).Item("VehiclePic")
            Dim lstr As New System.IO.MemoryStream(photo)
            On Error Resume Next
            frmAddEditAutoRefuelling.VehiclePic.Image = Image.FromStream(lstr)
            mstream.Close()
        End If

        If IsDBNull(dset.Tables(sql).Rows(0).Item("DriverPic")) Then
            frmAddEditAutoRefuelling.DriverPic.Image = Nothing
        Else
            Dim mstream As New System.IO.MemoryStream
            Dim photo As Byte() = dset.Tables(sql).Rows(0).Item("DriverPic")
            Dim lstr As New System.IO.MemoryStream(photo)
            On Error Resume Next
            frmAddEditAutoRefuelling.DriverPic.Image = Image.FromStream(lstr)
            mstream.Close()
        End If
        frmAddEditAutoRefuelling.GCQrCode.Enabled = False
        If dset.Tables(sql).Rows(0).Item("SelectStock") = True Then
            frmAddEditAutoRefuelling.RadioGroup1.SelectedIndex = 1
            frmAddEditAutoRefuelling.cbProduct.Enabled = True
        Else
            frmAddEditAutoRefuelling.RadioGroup1.SelectedIndex = 0
            frmAddEditAutoRefuelling.lblTankID.Text = dset.Tables(sql).Rows(0).Item("TankID")
            frmAddEditAutoRefuelling.txtTankName.Text = dset.Tables(sql).Rows(0).Item("TankName")
            frmAddEditAutoRefuelling.cbUom.Text = dset.Tables(sql).Rows(0).Item("uomA")
            frmAddEditAutoRefuelling.txtCapacity.Text = dset.Tables(sql).Rows(0).Item("CapacityB")
            frmAddEditAutoRefuelling.txtlocation.Text = dset.Tables(sql).Rows(0).Item("Location")
        End If
        frmAddEditAutoRefuelling.RadioGroup1.Enabled = False
        frmAddEditAutoRefuelling.PopulateHistory()
        Return True
    End Function
    Private Sub gvAutoRefuelling_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvAutoRefuelling.FocusedRowChanged
        Try
            keyID = gvAutoRefuelling.GetRowCellValue(gvAutoRefuelling.FocusedRowHandle, "TransNo")
            Dim da = New SqlDataAdapter("select * from tblAutoTransaction where AutoTransactionID='" & keyID & "'", kon)
            Dim dset = New DataSet
            da.Fill(dset, "tblAutoTransaction")
            If dset.Tables("tblAutoTransaction").Rows.Count > 0 Then
                txtselectedcode.Text = dset.Tables("tblAutoTransaction").Rows(0).Item("AutoTransactionID")
            Else
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Call Search()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        If txtsearch.Text = "" Then
            Call populateAuto()
        End If
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        If txtselectedcode.Text <> "" Then
            If MsgBox("Are you sure you want delete?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                Call konneksyon()
                sql = "update tblautoTransaction set Deleted_by='" & frmMain.lblid.Caption & "',Deleted_at=GetDate() where AutoTransactionID='" & txtselectedcode.Text & "'"
                Call save(sql)
                sql = "delete from tblTankInventory where TransactionID='" & txtselectedcode.Text & "' and [Transaction]='INCOMING'"
                Call save(sql)
                Call populateAuto()
            End If
        End If
    End Sub
End Class