Imports DevExpress.XtraGrid.Views.Grid
Public Class frmInventory
    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Call tank()
    End Sub

    Private Sub btnadd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnadd.ItemClick
        frmPrint.Text = "Print Inventory"
        frmPrint.ShowDialog()
    End Sub
    Function tank() As Boolean
        Call konneksyon()
        dgInventory.DataSource = Nothing
        gvInventory.Columns.Clear()
        sql = "select a.TankID,a.TankName,concat(format(a.TankCapacity,'#,#.##'),' ',b.UomCode) as TankCapacity,a.Location, " _
                   & "isnull((Select top 1 c.SupplierName from tblTankInventory As a1 " _
                   & "inner Join tblProducts as b on a1.ProductID=b.ProductID " _
                   & "inner Join tblSupplier as c on b.supplierID=c.SupplierID where a1.TankID=a.TankID),'-') as Supplier, " _
                   & "isnull((select top 1 b.ItemDescription from tblTankInventory as a1 " _
                   & "inner Join tblProducts as b on a1.ProductID=b.ProductID " _
                   & "inner Join tblSupplier as c on b.supplierID=c.SupplierID where a1.TankID=a.TankID),'-') as Product, format(a.ReorderLevel,'#,#.##') as ReorderLevel," _
                & "isnull(format((select Top 1(select sum(stockin-stockout) " _
                & "from tblTankInventory where ID<=a1.ID And TankID=a1.TankID) " _
                & "from tblTankInventory as a1 where a1.TankID=a.TankID order by a1.ID desc),'#,#.##'),0) as AvailableStocks from tbltank as a " _
                & "inner join tblUomCode as b on a.UomID=b.ID where a.TankID <> 1" _
                & "order By a.TankID asc"
        Call populate(sql, dgInventory)
        lblcount.Caption = gvInventory.RowCount & " Record(s) Found"
        gvInventory.BestFitColumns()
        gvInventory.RowHeight = 20
        Return True
    End Function
    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tank()
    End Sub
End Class