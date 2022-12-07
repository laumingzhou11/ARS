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
        ElseIf Me.Text = "Print Auto Transaction Report" Then
            Call vehicle()
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
            If dset.Tables(sql).Rows.Count = 0 Then
                MsgBox("No record to print!", MsgBoxStyle.Exclamation, Me.Text)
            Else
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
            If dset.Tables(sql).Rows.Count = 0 Then
                MsgBox("No record to print!", MsgBoxStyle.Exclamation, Me.Text)
            Else
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
        ElseIf frmTankReport.cbTank.Text <> "" And frmTankReport.dtpfrom.Text <> "" And frmTankReport.dtpto.Text <> "" Then
                sql = "select a.TankTransactionID as TransNo,a.PurchaseOrder as Po#,c.TankName as Tank,format(c.TankCapacity,'#,#.##') as TankCapacity, " _
                & "a.StockIn as Qty, e.UomCode, format(a.Price,'c', 'fil-PH') as Price," _
                & "(select Sum(StockIn*Price) from tblTankTransaction where TankTransactionID=a.TankTransactionID) as TotalAmount," _
                & "b.ItemDescription as Product,b1.SupplierName as Supplier,a.ReceivedBy, " _
                & "d.Name as DeliveredBy, format(a.Added_at,'MM/dd/yyyy') as Added_at,c.Location " _
                & "from tblTankTransaction as a inner join tblProducts as b on a.ProductID=b.ProductID " _
                & "inner join tblsupplier as b1 on b.SupplierID=b1.SupplierID " _
                & "inner join tbltank as c on a.TankID=c.TankID " _
                & "inner join tblvehicles as d on a.VehicleID=d.VehicleID " _
                & "inner join tblUomcode as e on a.UomID=e.ID where a.Deleted_at is null and c.TankName in (" & tankStr & ") and  A.Added_at>='" & frmTankReport.dtpfrom.Text & "' " _
                & "and A.Added_at <='" & frmTankReport.dtpto.Text & "' order by a.TankTransactionID desc"
            Call fill(sql)
            If dset.Tables(sql).Rows.Count = 0 Then
                MsgBox("No record to print!", MsgBoxStyle.Exclamation, Me.Text)
            Else
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
        End If
        Return True
    End Function
    Function vehicle() As Boolean
        Dim b() As String

        Dim Auto As String = frmAutoReport.cbAuto.Properties.GetCheckedItems.ToString
        b = Auto.Split(",")
        Dim AutoStr As String = ""
        For i = 0 To UBound(b)
            If i = 0 Then
                AutoStr = "'" & b(i) & "'"
            Else
                AutoStr = AutoStr & ",'" & LTrim(b(i)) & "'"
            End If
        Next
        Dim report As New xrAutoTransactions
        Call konneksyon()
        If frmAutoReport.cbAuto.Text <> "" And frmAutoReport.dtpfrom.Text = "" And frmAutoReport.dtpto.Text = "" Then
            sql = "select a.AutoTransactionID as TransNo,format(a.Added_at,'MM/dd/yyyy') as Added_at, " _
                    & "a.PoNo,b.Name as Vehicle,c.Tankname as Tank,d1.SupplierName as Supplier,d.ItemDescription as Product,format(a.StockOut,'#,#.##') as Qty,format(a.Price,'c', 'fil-PH') as Price, f.UomCode," _
                    & "format((select SUM(StockOut*Price) from tblAutoTransaction where AutoTransactionID=a.AutoTransactionID),'c', 'fil-PH') as TotalAmount,case SelectStock when 1 then 'Outside Purchase' else 'Tank' end as Source " _
                    & "from tblAutoTransaction as a " _
                    & "inner join tblVehicles as b on a.VehicleID=b.VehicleID " _
                    & "inner join tbltank as c on a.TankID=c.TankID " _
                    & "inner join tblProducts as d on a.ProductID=d.ProductID " _
                    & "inner join tblSupplier as d1 on d.SupplierID=d1.SupplierID " _
                    & "inner join tblEmpUsers as e on a.Added_by=e.EmpID " _
                    & "inner join tblUomCode as f on a.UomID=f.ID where b.Name in (" & AutoStr & ") And a.Deleted_at Is null order by a.AutoTransactionID desc"
            Call fill(sql)
            If dset.Tables(sql).Rows.Count = 0 Then
                MsgBox("No record to print!", MsgBoxStyle.Exclamation, Me.Text)
            Else
                report.xrVehicle.DataBindings.Add("Text", dset, "Vehicle")
                report.xrSource.DataBindings.Add("Text", dset, "Source")
                report.xrTankName.DataBindings.Add("Text", dset, "Tank")
                report.xrSupplier.DataBindings.Add("Text", dset, "Supplier")
                report.xrProduct.DataBindings.Add("Text", dset, "Product")
                report.xrQty.DataBindings.Add("Text", dset, "Qty")
                report.xrUom.DataBindings.Add("Text", dset, "UomCode")
                report.xrPrice.DataBindings.Add("Text", dset, "Price")
                report.xrAmount.DataBindings.Add("Text", dset, "TotalAmount")
                report.xrDate.DataBindings.Add("Text", dset, "Added_at")
                report.xrPoNo.DataBindings.Add("Text", dset, "PoNo")
                report.DataSource = dset
                report.CreateDocument()
                dvstatus.DocumentSource = report
                dvstatus.Refresh()
            End If
        ElseIf frmAutoReport.cbAuto.Text = "" And frmAutoReport.dtpfrom.Text <> "" And frmAutoReport.dtpto.Text <> "" Then
            sql = "select a.AutoTransactionID as TransNo,format(a.Added_at,'MM/dd/yyyy') as Added_at, " _
                    & "a.PoNo,b.Name as Vehicle,c.Tankname as Tank,d1.SupplierName as Supplier,d.ItemDescription as Product,format(a.StockOut,'#,#.##') as Qty,format(a.Price,'c', 'fil-PH') as Price, " _
                    & "format((select SUM(StockOut*Price) from tblAutoTransaction where AutoTransactionID=a.AutoTransactionID),'c', 'fil-PH') as TotalAmount,case SelectStock when 1 then 'Outside Purchase' else 'Tank' end as Source " _
                    & "from tblAutoTransaction as a " _
                    & "inner join tblVehicles as b on a.VehicleID=b.VehicleID " _
                    & "inner join tbltank as c on a.TankID=c.TankID " _
                    & "inner join tblProducts as d on a.ProductID=d.ProductID " _
                    & "inner join tblSupplier as d1 on d.SupplierID=d1.SupplierID " _
                    & "inner join tblEmpUsers as e on a.Added_by=e.EmpID where  A.Added_at>='" & frmAutoReport.dtpfrom.Text & "' " _
                & "and A.Added_at <='" & frmAutoReport.dtpto.Text & "' order by a.TankTransactionID desc"
            Call fill(sql)
            If dset.Tables(sql).Rows.Count = 0 Then
                MsgBox("No record to print!", MsgBoxStyle.Exclamation, Me.Text)
            Else
                report.xrVehicle.DataBindings.Add("Text", dset, "Vehicle")
                report.xrSource.DataBindings.Add("Text", dset, "Source")
                report.xrTankName.DataBindings.Add("Text", dset, "Tank")
                report.xrSupplier.DataBindings.Add("Text", dset, "Supplier")
                report.xrProduct.DataBindings.Add("Text", dset, "Product")
                report.xrQty.DataBindings.Add("Text", dset, "Qty")
                report.xrUom.DataBindings.Add("Text", dset, "UomCode")
                report.xrPrice.DataBindings.Add("Text", dset, "Price")
                report.xrAmount.DataBindings.Add("Text", dset, "TotalAmount")
                report.xrDate.DataBindings.Add("Text", dset, "Added_at")
                report.xrPoNo.DataBindings.Add("Text", dset, "PO#")
                report.DataSource = dset
                report.CreateDocument()
                dvstatus.DocumentSource = report
                dvstatus.Refresh()
            End If
        ElseIf frmAutoReport.cbAuto.Text <> "" And frmAutoReport.dtpfrom.Text <> "" And frmAutoReport.dtpto.Text <> "" Then
            sql = "select a.AutoTransactionID as TransNo,format(a.Added_at,'MM/dd/yyyy') as Added_at, " _
                    & "a.PoNo,b.Name as Vehicle,c.Tankname as Tank,d1.SupplierName as Supplier,d.ItemDescription as Product,format(a.StockOut,'#,#.##') as Qty,format(a.Price,'c', 'fil-PH') as Price, " _
                    & "format((select SUM(StockOut*Price) from tblAutoTransaction where AutoTransactionID=a.AutoTransactionID),'c', 'fil-PH') as TotalAmount,case SelectStock when 1 then 'Outside Purchase' else 'Tank' end as Source " _
                    & "from tblAutoTransaction as a " _
                    & "inner join tblVehicles as b on a.VehicleID=b.VehicleID " _
                    & "inner join tbltank as c on a.TankID=c.TankID " _
                    & "inner join tblProducts as d on a.ProductID=d.ProductID " _
                    & "inner join tblSupplier as d1 on d.SupplierID=d1.SupplierID " _
                    & "inner join tblEmpUsers as e on a.Added_by=e.EmpID where  b.Name in (" & AutoStr & ") and A.Added_at>='" & frmAutoReport.dtpfrom.Text & "' " _
                & "and A.Added_at <='" & frmAutoReport.dtpto.Text & "' order by a.TankTransactionID desc"
            Call fill(sql)
            If dset.Tables(sql).Rows.Count = 0 Then
                MsgBox("No record to print!", MsgBoxStyle.Exclamation, Me.Text)
            Else
                report.xrVehicle.DataBindings.Add("Text", dset, "Vehicle")
                report.xrSource.DataBindings.Add("Text", dset, "Source")
                report.xrTankName.DataBindings.Add("Text", dset, "Tank")
                report.xrSupplier.DataBindings.Add("Text", dset, "Supplier")
                report.xrProduct.DataBindings.Add("Text", dset, "Product")
                report.xrQty.DataBindings.Add("Text", dset, "Qty")
                report.xrUom.DataBindings.Add("Text", dset, "UomCode")
                report.xrPrice.DataBindings.Add("Text", dset, "Price")
                report.xrAmount.DataBindings.Add("Text", dset, "TotalAmount")
                report.xrDate.DataBindings.Add("Text", dset, "Added_at")
                report.xrPoNo.DataBindings.Add("Text", dset, "PO#")
                report.DataSource = dset
                report.CreateDocument()
                dvstatus.DocumentSource = report
                dvstatus.Refresh()
            End If
        End If
        Return True
    End Function
End Class