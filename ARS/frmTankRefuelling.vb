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
Public Class frmTankRefuelling
    Private Sub btnadd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnadd.ItemClick
        Call xadd()
    End Sub
    Function xadd() As Boolean
        Call konneksyon()
        sql = "select * from tblTankTransaction where Added_by='" & frmMain.lblid.Caption & "' and TankID='0'"
        Call fill(sql)
        If dset.Tables(sql).Rows.Count > 0 Then
            frmAddEditTankRefuelling.lblTransID.Text = dset.Tables(sql).Rows(0).Item("TankTransactionID")
            frmAddEditTankRefuelling.btnSelectTank.Select()
            frmAddEditTankRefuelling.Text = "Tank Refuelling - Stock IN"
            frmAddEditTankRefuelling.btnSelectTank.Enabled = True
            frmAddEditTankRefuelling.txtqty.Enabled = True
            frmAddEditTankRefuelling.GroupControl2.Visible = True
            frmAddEditTankRefuelling.xclear()
            frmAddEditTankRefuelling.ShowDialog()
        Else
            sql = "insert into tblTankTransaction (" _
                            & "TankID, StockIn, ProductID, PurchaseOrder, Added_at, " _
                            & "Added_by,Receivedby,VehicleID, UomID, Price) values (0,0,0,0,null,'" & frmMain.lblid.Caption & "','-',0,0,0)"
            Call save(sql)
            sql = "Select max(TankTransactionID) As TankTransactionID from tblTankTransaction"
            Call fill(sql)
            frmAddEditTankRefuelling.lblTransID.Text = dset.Tables(sql).Rows(0).Item("TankTransactionID")
            frmAddEditTankRefuelling.btnSelectTank.Select()
            frmAddEditTankRefuelling.Text = "Tank Refuelling - Stock IN"
            frmAddEditTankRefuelling.btnSelectTank.Enabled = True
            frmAddEditTankRefuelling.txtqty.Enabled = True
            frmAddEditTankRefuelling.GroupControl2.Visible = True
            frmAddEditTankRefuelling.xclear()
            frmAddEditTankRefuelling.ShowDialog()
        End If
        Return True
    End Function
    Private Sub frmTankRefuelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call populateTransaction()
    End Sub
    Function populateTransaction() As Boolean
        Call konneksyon()
        sql = "Select a.TankTransactionID As TransNo,a.PurchaseOrder As Po#,c.TankName As Tank,format(c.TankCapacity,'#,#.##') as TankCapacity, " _
                & "format(a.StockIn,'#,#.##')as Qty, e.UomCode, format(a.Price,'c', 'fil-PH') as Price," _
                & "format((select Sum(StockIn*Price) from tblTankTransaction where TankTransactionID=a.TankTransactionID),'c', 'fil-PH') as TotalAmount," _
                & "b.ItemDescription as Product,b1.SupplierName as Supplier,a.ReceivedBy, " _
                & "d.Name as DeliveredBy, format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at " _
                & "from tblTankTransaction as a inner join tblProducts as b on a.ProductID=b.ProductID " _
                & "inner join tblsupplier as b1 on b.SupplierID=b1.SupplierID " _
                & "inner join tbltank as c on a.TankID=c.TankID " _
                & "inner join tblvehicles as d on a.VehicleID=d.VehicleID " _
                & "inner join tblUomcode as e on a.UomID=e.ID where a.Deleted_at is null order by a.TankTransactionID desc"
        Call populate(sql, dgTankRefuelling)
        lblcount.Caption = gvTankRefuelling.RowCount & " Record(s) Found"
        gvTankRefuelling.BestFitColumns()
        gvTankRefuelling.RowHeight = 20
        Return True
    End Function
    Function filltext() As Boolean
        Call konneksyon()
        sql = "select a.TankTransactionID as TransNo,a.PurchaseOrder as Po#,c.TankID,c.TankName as Tank, " _
                & "isnull(c.TankCapacity-(Select SUM(StockIn) from tblTankInventory where TankTransactionID=a.TankTransactionID),0) as Available,c.TankCapacity,c.Location,a.StockIn, e.UomCode,a.Price," _
                & "b.ProductID,b.ItemDescription As Product,b.SupplierID,b1.SupplierName As Supplier,a.ReceivedBy, " _
                & "d.Name As DeliveredBy,format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at " _
                & "from tblTankTransaction as a inner join tblProducts as b on a.ProductID=b.ProductID " _
                & "inner join tblsupplier as b1 on b.SupplierID=b1.SupplierID " _
                & "inner join tbltank as c on a.TankID=c.TankID " _
                & "inner join tblvehicles as d on a.VehicleID=d.VehicleID " _
                & "inner join tblUomcode as e on a.UomID=e.ID where TankTransactionID='" & keyID & "'"
        Call fill(sql)
        frmAddEditTankRefuelling.lblTransID.Text = dset.Tables(sql).Rows(0).Item("TransNo")
        frmAddEditTankRefuelling.txtPoNo.Text = dset.Tables(sql).Rows(0).Item("Po#")
        frmAddEditTankRefuelling.txtTankName.Text = dset.Tables(sql).Rows(0).Item("Tank")
        frmAddEditTankRefuelling.txtqty.Text = dset.Tables(sql).Rows(0).Item("StockIn")
        frmAddEditTankRefuelling.cbUomCode.Text = dset.Tables(sql).Rows(0).Item("UomCode")
        frmAddEditTankRefuelling.cbUom.Text = dset.Tables(sql).Rows(0).Item("UomCode")
        frmAddEditTankRefuelling.txtprice.Text = dset.Tables(sql).Rows(0).Item("Price")
        frmAddEditTankRefuelling.txtlocation.Text = dset.Tables(sql).Rows(0).Item("Location")
        frmAddEditTankRefuelling.txtCapacity.Text = dset.Tables(sql).Rows(0).Item("TankCapacity")
        frmAddEditTankRefuelling.dtpDate.Text = dset.Tables(sql).Rows(0).Item("Added_at")
        frmAddEditTankRefuelling.txtprice.Text = dset.Tables(sql).Rows(0).Item("Price")
        frmAddEditTankRefuelling.txtsupplier.Text = dset.Tables(sql).Rows(0).Item("Supplier")
        frmAddEditTankRefuelling.txtproduct.Text = dset.Tables(sql).Rows(0).Item("Product")
        frmAddEditTankRefuelling.txtreceived.Text = dset.Tables(sql).Rows(0).Item("Receivedby")
        frmAddEditTankRefuelling.cbDeliveredby.Text = dset.Tables(sql).Rows(0).Item("Deliveredby")
        frmAddEditTankRefuelling.lbltankID.Text = dset.Tables(sql).Rows(0).Item("TankID")
        frmAddEditTankRefuelling.txtstocks.Text = dset.Tables(sql).Rows(0).Item("Available")
        frmAddEditTankRefuelling.GroupControl2.Visible = False
        Call frmAddEditTankRefuelling.Uom()
        Call frmAddEditTankRefuelling.PopulateHistory()
        Return True
    End Function
    Function Search() As Boolean
        Try
            If txtsearch.Text <> "" Then
                Call konneksyon()
                sql = "select a.TankTransactionID as TransNo,a.PurchaseOrder as Po#,c.TankName as Tank,format(c.TankCapacity,'#,#.##') as TankCapacity, " _
                & "format(a.StockIn,'#,#.##') as Qty, e.UomCode, format(a.Price,'c', 'fil-PH') as Price," _
                & "format((select Sum(StockIn*Price) from tblTankTransaction where TankTransactionID=a.TankTransactionID),'c', 'fil-PH') as TotalAmount," _
                & "b.ItemDescription as Product,b1.SupplierName as Supplier,a.ReceivedBy, " _
                & "d.Name as DeliveredBy, format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at " _
                & "from tblTankTransaction as a inner join tblProducts as b on a.ProductID=b.ProductID " _
                & "inner join tblsupplier as b1 on b.SupplierID=b1.SupplierID " _
                & "inner join tbltank as c on a.TankID=c.TankID " _
                & "inner join tblvehicles as d on a.VehicleID=d.VehicleID " _
                & "inner join tblUomcode as e on a.UomID=e.ID where " _
                & "c.TankName Like '%" & txtsearch.Text & "%' and a.Deleted_at is null or " _
                & "a.PurchaseOrder like '%" & txtsearch.Text & "%' and a.Deleted_at is null or " _
                & "b.ItemDescription Like '%" & txtsearch.Text & "%' and a.Deleted_at is null or " _
                & "b1.SupplierName like '%" & txtsearch.Text & "%' and a.Deleted_at is null or " _
                & "a.Receivedby Like '%" & txtsearch.Text & "%' and a.Deleted_at is null or " _
                & "d.Name like '%" & txtsearch.Text & "%' and a.Deleted_at is null order by a.TankTransactionID desc"
                Call populate(sql, dgTankRefuelling)
                If dset.Tables(sql).Rows.Count > 0 Then
                    lblcount.Caption = gvTankRefuelling.RowCount & " Record(s) Found"
                    gvTankRefuelling.BestFitColumns()
                    gvTankRefuelling.RowHeight = 20
                Else
                    MsgBox("No record found!", MsgBoxStyle.Information, Me.Text)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        Return True
    End Function
    Private Sub gvTankRefuelling_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvTankRefuelling.CustomDrawCell
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
            frmAddEditTankRefuelling.Text = "Tank Refuelling - Edit Stock IN"
            frmAddEditTankRefuelling.btnSelectTank.Enabled = False
            frmAddEditTankRefuelling.txtqty.Enabled = False
            frmAddEditTankRefuelling.txtPoNo.Select()
            frmAddEditTankRefuelling.ShowDialog()
        Else
            MsgBox("Select record to edit!", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub
    Private Sub gvTankRefuelling_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvTankRefuelling.FocusedRowChanged

    End Sub

    Private Sub gvTankRefuelling_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles gvTankRefuelling.RowCellClick
        Try
            keyID = gvTankRefuelling.GetRowCellValue(gvTankRefuelling.FocusedRowHandle, "TransNo")
            Dim da = New SqlDataAdapter("select * from tblTankTransaction where TankTransactionID='" & keyID & "'", kon)
            Dim dset = New DataSet
            da.Fill(dset, "tblTankTransaction")
            If dset.Tables("tblTankTransaction").Rows.Count > 0 Then
                txtselectedcode.Text = dset.Tables("tblTankTransaction").Rows(0).Item("TankTransactionID")
            Else
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Call Search()
    End Sub

    Private Sub btnDelete_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles btnDelete.ItemClick
        If txtselectedcode.Text <> "" Then
            If MsgBox("Are you sure you want delete?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                Call konneksyon()
                sql = "update tblTankTransaction set Deleted_by='" & frmMain.lblid.Caption & "',Deleted_at=GetDate() where TankTransactionID='" & txtselectedcode.Text & "'"
                Call save(sql)
                sql = "delete from tblTankInventory where " _
                        & "TankID=(select TankID from tblTankTransaction where TankTransactionID='" & txtselectedcode.Text & "') and 
                        Date=(select Date from tblTankTransaction where TankTransactionID='" & txtselectedcode.Text & "') and [Transaction]='INCOMING'"
                Call save(sql)
                sql = "delete from tblAutoTransaction where " _
                        & "TankID=(select TankID from tblTankTransaction where TankTransactionID='" & txtselectedcode.Text & "') and 
                        Date=(select Date from tblTankTransaction where TankTransactionID='" & txtselectedcode.Text & "') and [Transaction]='INCOMING'"
                Call save(sql)
                Call populateTransaction()
            End If
        End If
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        If txtsearch.Text = "" Then
            Call populateTransaction()
        End If
    End Sub
End Class