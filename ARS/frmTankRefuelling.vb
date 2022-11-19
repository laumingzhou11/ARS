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
        frmAddEditTankRefuelling.btnSelectTank.Select()
        frmAddEditTankRefuelling.Text = "Tank Refuelling - Stock IN"
        frmAddEditTankRefuelling.xclear()
        frmAddEditTankRefuelling.ShowDialog()
    End Sub

    Private Sub frmTankRefuelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call populateTransaction()
    End Sub
    Function populateTransaction() As Boolean
        Call konneksyon()
        sql = "select a.TankTransactionID as TransNo,a.PurchaseOrder as Po#,c.TankName as Tank,a.StockIn, e.UomCode, a.Price," _
                & "b.ItemDescription as Product,b1.SupplierName as Supplier,a.Received_by, " _
                & "d.Name as Deliveredby, format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at " _
                & "from tblTankTransaction as a inner join tblProducts as b on a.ProductID=b.ProductID " _
                & "inner join tblsupplier as b1 on b.SupplierID=b1.SupplierID " _
                & "inner join tbltank as c on a.TankID=c.TankID " _
                & "inner join tblvehicles as d on a.VehicleID=d.VehicleID " _
                & "inner join tblUomcode as e on a.UomID=e.UomCode order by a.TankTransactionID desc"
        Call populate(sql, dgTankRefuelling)
        lblcount.Caption = gvTankRefuelling.RowCount & " Record(s) Found"
        gvTankRefuelling.BestFitColumns()
        gvTankRefuelling.RowHeight = 20
        Return True
    End Function
    Function filltext() As Boolean
        Call konneksyon()
        sql = "select a.a.TankTransactionID as TransNo,a.PurchaseOrder as Po#,c.TankID,c.TankName as Tank,c.capacity,c.Location,a.StockIn, e.UomCode,a.Price," _
                & "b.ProductID,b.ItemDescription as Product,b.SupplierID,b1.SupplierName as Supplier,a.Received_by, " _
                & "d.Name as Deliveredby,Added_at " _
                & "from tblTankTransaction as a inner join tblProducts as b on a.ProductID=b.ProductID " _
                & "inner join tblsupplier as b1 on b.SupplierID=b1.SupplierID " _
                & "inner join tbltank as c on a.TankID=c.TankID " _
                & "inner join tblvehicles as d on a.VehicleID=d.VehicleID " _
                & "inner join tblUomcode as e on a.UomID=e.UomCode where TankTransactionID='" & keyID & "'"
        Call fill(sql)
        frmAddEditTankRefuelling.lblTransID.Text = dset.Tables(sql).Rows(0).Item("TankTransactionID")
        frmAddEditTankRefuelling.txtPoNo.Text = dset.Tables(sql).Rows(0).Item("Po#")
        frmAddEditTankRefuelling.txtTankName.Text = dset.Tables(sql).Rows(0).Item("Tank")
        frmAddEditTankRefuelling.txtqty.Text = dset.Tables(sql).Rows(0).Item("StockIn")
        frmAddEditTankRefuelling.cbUomCode.Text = dset.Tables(sql).Rows(0).Item("UomCode")
        frmAddEditTankRefuelling.cbUom.Text = dset.Tables(sql).Rows(0).Item("UomCode")
        frmAddEditTankRefuelling.txtprice.Text = dset.Tables(sql).Rows(0).Item("Price")
        frmAddEditTankRefuelling.txtlocation.Text = dset.Tables(sql).Rows(0).Item("Location")
        frmAddEditTankRefuelling.txtCapacity.Text = dset.Tables(sql).Rows(0).Item("Capacity")
        frmAddEditTankRefuelling.dtpDate.Text = dset.Tables(sql).Rows(0).Item("Added_at")
        frmAddEditTankRefuelling.txtprice.Text = dset.Tables(sql).Rows(0).Item("Price")
        frmAddEditTankRefuelling.lblSupplierID.Text = dset.Tables(sql).Rows(0).Item("SupplierID")
        frmAddEditTankRefuelling.lblProductID.Text = dset.Tables(sql).Rows(0).Item("ProductID")
        frmAddEditTankRefuelling.txtreceived.Text = dset.Tables(sql).Rows(0).Item("Received_by")
        frmAddEditTankRefuelling.cbDeliveredby.Text = dset.Tables(sql).Rows(0).Item("Deliveredby")
        frmAddEditTankRefuelling.lbltankID.Text = dset.Tables(sql).Rows(0).Item("TankID")
        Call frmAddEditProducts.Supplier()
        Call frmAddEditProducts.Uom()
        Return True
    End Function
    Function Search() As Boolean
        Try
            If txtsearch.Text = "" Then
                Call konneksyon()
                sql = "select a.TankTransactionID as TransNo,a.PurchaseOrder as Po#,c.TankName as Tank,a.StockIn, e.UomCode,a.Price" _
                & "b.ItemDescription as Product,b1.SupplierName as Supplier,a.Received_by, " _
                & "d.Name as Deliveredby, format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at " _
                & "from tblTankTransaction as a inner join tblProducts as b on a.ProductID=b.ProductID " _
                & "inner join tblsupplier as b1 on b.SupplierID=b1.SupplierID " _
                & "inner join tbltank as c on a.TankID=c.TankID " _
                & "inner join tblvehicles as d on a.VehicleID=d.VehicleID " _
                & "inner join tblUomcode as e on a.UomID=e.UomCode where c.TankName like '%" & txtsearch.Text & "%' or " _
                & "Po# like '%" & txtsearch.Text & "%' or b.ItemDescription like '%" & txtsearch.Text & "%' or " _
                & "b1.SupplierName like '%" & txtsearch.Text & "%' or a.Received_by like '%" & txtsearch.Text & "%' or " _
                & "d.Name like '%" & txtsearch.Text & "%' order by a.ProductID desc"
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
            frmAddEditProducts.Text = "Edit Product"
            frmAddEditProducts.ShowDialog()
        Else
            MsgBox("Select record to edit!", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub
    Private Sub gvTankRefuelling_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvTankRefuelling.FocusedRowChanged
        Try
            keyID = gvTankRefuelling.GetRowCellValue(gvTankRefuelling.FocusedRowHandle, "TankTransactionID")
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
End Class