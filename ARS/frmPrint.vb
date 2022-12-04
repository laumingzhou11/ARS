Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraPrinting.Preview
Public Class frmPrint
    Private Sub frmPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.Text = "Print QR Code" Then
            Call QRCode()
        ElseIf Me.Text = "Print List" Then
            Call List()
        ElseIf Me.Text = "Print Inventory" Then
            Call Inventory()
        ElseIf Me.Text = "Print Tank Transaction Report" Then
            Call Tank()
        End If
    End Sub
    Function QRCode() As Boolean
        Call konneksyon()
        Dim report As New xrID
        sql = "Select Code, Name, PlateNo, Model from tblvehicles where VehicleID='" & keyID & "'"
        Call fill(sql)
        report.XrBarCode1.DataBindings.Add("Text", dset, "Code")
        report.xrName.DataBindings.Add("Text", dset, "Name")
        report.xrPlateNo.DataBindings.Add("Text", dset, "PlateNo")
        report.xrModel.DataBindings.Add("Text", dset, "Model")
        report.DataSource = dset
        report.CreateDocument()
        dvstatus.DocumentSource = report
        dvstatus.Refresh()
        Return True
    End Function
    Function List() As Boolean
        Call konneksyon()
        Dim report As New xrVehicle
        sql = "Select Name, PlateNo, Model, Make, Status, CrNo, Driver from tblvehicles  order by VehicleID asc"
        Call fill(sql)
        report.xrVehicles.DataBindings.Add("Text", dset, "Name")
        report.xrPlateNo.DataBindings.Add("Text", dset, "PlateNo")
        report.xrModel.DataBindings.Add("Text", dset, "Model")
        report.xrMake.DataBindings.Add("Text", dset, "Make")
        report.xrStatus.DataBindings.Add("Text", dset, "Status")
        report.xrCrNo.DataBindings.Add("Text", dset, "CrNo")
        report.xrDriver.DataBindings.Add("Text", dset, "Driver")
        report.DataSource = dset
        report.CreateDocument()
        dvstatus.DocumentSource = report
        dvstatus.Refresh()
        Return True
    End Function
    Function Inventory() As Boolean
        Call konneksyon()
        Dim report As New xrInventory
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
        Call fill(sql)
        report.xrTank.DataBindings.Add("Text", dset, "TankName")
        report.xrCapacity.DataBindings.Add("Text", dset, "TankCapacity")
        report.xrLocation.DataBindings.Add("Text", dset, "Location")
        report.xrReorderLevel.DataBindings.Add("Text", dset, "ReorderLevel")
        report.xrStocks.DataBindings.Add("Text", dset, "AvailableStocks")
        report.xrSupplier.DataBindings.Add("Text", dset, "Supplier")
        report.xrProduct.DataBindings.Add("Text", dset, "Product")
        report.DataSource = dset
        report.CreateDocument()
        dvstatus.DocumentSource = report
        dvstatus.Refresh()
        Return True
    End Function
    Function Tank() As Boolean
        Dim b() As String

        Dim tanks As String = frmTankReport.cbTank.Properties.GetCheckedItems.ToString
        b = tanks.Split(",")
        Dim tankStr As String = ""
        For i = 0 To UBound(b)
            If i = 0 Then
                tankStr = "'" & b(i) & "'"
            Else
                tankStr = tankStr & ",'" & LTrim(b(i)) & "'"
            End If
        Next
        Dim report As New xrTankTransactions
        Call konneksyon()
        If frmTankReport.cbTank.Text <> "" And frmTankReport.dtpfrom.Text = "" And frmTankReport.dtpto.Text = "" Then
            sql = "select a.TankTransactionID as TransNo,a.PurchaseOrder as Po#,c.TankName as Tank,format(c.TankCapacity,'#,#.##') as TankCapacity, " _
                & "a.StockIn as Qty, e.UomCode, format(a.Price,'c', 'fil-PH') as Price," _
                & "(select Sum(StockIn*Price) from tblTankTransaction where TankTransactionID=a.TankTransactionID) as TotalAmount," _
                & "b.ItemDescription as Product,b1.SupplierName as Supplier,a.ReceivedBy, " _
                & "d.Name as DeliveredBy, format(a.Added_at,'MM/dd/yyyy') as Added_at,c.Location " _
                & "from tblTankTransaction as a inner join tblProducts as b on a.ProductID=b.ProductID " _
                & "inner join tblsupplier as b1 on b.SupplierID=b1.SupplierID " _
                & "inner join tbltank as c on a.TankID=c.TankID " _
                & "inner join tblvehicles as d on a.VehicleID=d.VehicleID " _
                & "inner join tblUomcode as e on a.UomID=e.ID where a.Deleted_at is null and c.TankName in (" & tankStr & ") order by a.TankTransactionID desc"
            Call fill(sql)
            report.xrTank.DataBindings.Add("Text", dset, "Tank")
            report.xrLocation.DataBindings.Add("Text", dset, "Location")
            report.xrSupplier.DataBindings.Add("Text", dset, "Supplier")
            report.xrProduct.DataBindings.Add("Text", dset, "Product")
            report.xrQty.DataBindings.Add("Text", dset, "Qty")
            report.xrUom.DataBindings.Add("Text", dset, "UomCode")
            report.xrReceived.DataBindings.Add("Text", dset, "ReceivedBy")
            report.xrPrice.DataBindings.Add("Text", dset, "Price")
            report.xrAmount.DataBindings.Add("Text", dset, "TotalAmount")
            report.xrDate.DataBindings.Add("Text", dset, "Added_at")
            report.xrPoNo.DataBindings.Add("Text", dset, "PO#")
            report.DataSource = dset
            report.CreateDocument()
            dvstatus.DocumentSource = report
            dvstatus.Refresh()
        ElseIf frmTankReport.cbTank.Text = "" And frmTankReport.dtpfrom.Text <> "" And frmTankReport.dtpto.Text <> "" Then
            sql = "select a.TankTransactionID as TransNo,a.PurchaseOrder as Po#,c.TankName as Tank,format(c.TankCapacity,'#,#.##') as TankCapacity, " _
                & "a.StockIn as Qty, e.UomCode, format(a.Price,'c', 'fil-PH') as Price," _
                & "(select Sum(StockIn*Price) from tblTankTransaction where TankTransactionID=a.TankTransactionID) as TotalAmount," _
                & "b.ItemDescription as Product,b1.SupplierName as Supplier,a.ReceivedBy, " _
                & "d.Name as DeliveredBy, format(a.Added_at,'MM/dd/yyyy') as Added_at,c.Location " _
                & "from tblTankTransaction as a inner join tblProducts as b on a.ProductID=b.ProductID " _
                & "inner join tblsupplier as b1 on b.SupplierID=b1.SupplierID " _
                & "inner join tbltank as c on a.TankID=c.TankID " _
                & "inner join tblvehicles as d on a.VehicleID=d.VehicleID " _
                & "inner join tblUomcode as e on a.UomID=e.ID where a.Deleted_at is null and  A.Added_at>='" & frmTankReport.dtpfrom.Text & "' " _
                & "and A.Added_at <='" & frmTankReport.dtpto.Text & "' order by a.TankTransactionID desc"
            Call fill(sql)
            report.xrTank.DataBindings.Add("Text", dset, "Tank")
            report.xrLocation.DataBindings.Add("Text", dset, "Location")
            report.xrSupplier.DataBindings.Add("Text", dset, "Supplier")
            report.xrProduct.DataBindings.Add("Text", dset, "Product")
            report.xrQty.DataBindings.Add("Text", dset, "Qty")
            report.xrUom.DataBindings.Add("Text", dset, "UomCode")
            report.xrReceived.DataBindings.Add("Text", dset, "ReceivedBy")
            report.xrPrice.DataBindings.Add("Text", dset, "Price")
            report.xrAmount.DataBindings.Add("Text", dset, "TotalAmount")
            report.xrDate.DataBindings.Add("Text", dset, "Added_at")
            report.xrPoNo.DataBindings.Add("Text", dset, "PO#")
            report.DataSource = dset
            report.CreateDocument()
            dvstatus.DocumentSource = report
            dvstatus.Refresh()
        End If
        Return True
    End Function

End Class