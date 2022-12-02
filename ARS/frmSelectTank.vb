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
Public Class frmSelectTank
    Private Sub frmSelectTank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call populateTank()
    End Sub

    Function populateTank() As Boolean
        Call konneksyon()
        sql = "select A.TankID,a.TankName,format(A.TankCapacity,'#,#') as TankCapacity,b.UomCode,a.Location,format(isnull((select TOp 1(select sum(Stockin-Stockout) " _
                & "from tblTankInventory where ID<=a1.ID And TankID=a.TankID) " _
                & "from tblTankInventory As a1 where a1.TankID=a.TankID order By a1.ID desc),0),'#,#') as AvailableStocks " _
                & "from tbltank As a inner join tbluomCode As b On a.UomID=b.ID where A.TankID<>1 and a.Deleted_at is null order by A.TankID desc"
        Call populate(sql, dgTank)
        gvTank.Columns("TankID").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        gvTank.Columns("TankID").SummaryItem.DisplayFormat = "{0:n0}" & " Record(s) found"
        gvTank.BestFitColumns()
        gvTank.RowHeight = 20
        Return True
    End Function
    Function filltext() As Boolean
        Call konneksyon()
        If lblSelectTank.Text = "Tank" Then
            sql = "select A.TankID,a.TankName,A.TankCapacity,b.UomCode,a.Location,A.TankCapacity-(select SUM(StockIn) from tblTankInventory where TankID='" & keyID & "') as Available " _
                & "from tbltank As a inner join tbluomCode As b On a.UomID=b.ID where TankID='" & keyID & "'"
            Call fill(sql)
            frmAddEditTankRefuelling.lbltankID.Text = dset.Tables(sql).Rows(0).Item("TankID")
            frmAddEditTankRefuelling.txtTankName.Text = dset.Tables(sql).Rows(0).Item("TankName")
            frmAddEditTankRefuelling.txtCapacity.Text = dset.Tables(sql).Rows(0).Item("TankCapacity")
            frmAddEditTankRefuelling.cbUomCode.Text = dset.Tables(sql).Rows(0).Item("UomCode")
            frmAddEditTankRefuelling.txtlocation.Text = dset.Tables(sql).Rows(0).Item("Location")
            frmAddEditTankRefuelling.txtstocks.Text = FormatNumber(dset.Tables(sql).Rows(0).Item("Available"), 2)
            Call frmAddEditTankRefuelling.PopulateHistory()
            Me.Close()
        Else
            sql = "select A.TankID,b.TankName,b.TankCapacity,c.UomCode,b.Location, d.ProductID, " _
                    & "d.ItemDescription as Product,d.Price,d1.SupplierID,d1.SupplierName as Supplier, " _
                    & "A.TankCapacity-(select SUM(StockIn) from tblTankInventory where TankID='" & keyID & "') as Available  from tblTankTransaction as a  " _
                    & "inner join tblTank as b on a.TankID=b.TankID " _
                    & "inner join tbluomCode As c On b.UomID=c.ID " _
                    & "inner join tblproducts as d on a.ProductID=d.productID " _
                    & "inner join tblSupplier as d1 on d.SupplierID=d1.SupplierID where a.TankID='" & keyID & "'"
            Call fill(sql)
            If dset.Tables(sql).Rows.Count = 0 Then
                MsgBox("No available stocks!", MsgBoxStyle.Information, Me.Text)
            Else
                frmAddEditAutoRefuelling.lblTankID.Text = dset.Tables(sql).Rows(0).Item("TankID")
                frmAddEditAutoRefuelling.txtTankName.Text = dset.Tables(sql).Rows(0).Item("TankName")
                frmAddEditAutoRefuelling.txtCapacity.Text = dset.Tables(sql).Rows(0).Item("TankCapacity")
                frmAddEditAutoRefuelling.cbUomCode.Text = dset.Tables(sql).Rows(0).Item("UomCode")
                frmAddEditAutoRefuelling.txtlocation.Text = dset.Tables(sql).Rows(0).Item("Location")
                frmAddEditAutoRefuelling.txtstocks.Text = FormatNumber(dset.Tables(sql).Rows(0).Item("Available"), 2)
                frmAddEditAutoRefuelling.cbProduct.Text = dset.Tables(sql).Rows(0).Item("Product")
                frmAddEditAutoRefuelling.cbSupplier.Text = dset.Tables(sql).Rows(0).Item("Supplier")
                frmAddEditAutoRefuelling.lblSupplierID.Text = dset.Tables(sql).Rows(0).Item("SupplierID")
                frmAddEditAutoRefuelling.lblProductID.Text = dset.Tables(sql).Rows(0).Item("ProductID")
                frmAddEditAutoRefuelling.txtprice.Text = dset.Tables(sql).Rows(0).Item("Price")
                Me.Close()
            End If
        End If
        Return True
    End Function
    Private Sub gvTank_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvTank.CustomDrawCell
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
    Function Search() As Boolean
        Try
            If txtsearch.Text = "" Then
                Call konneksyon()
                sql = "select A.TankID,a.TankName,A.format(TankCapacity,'#,#,) as TankCapacity,b.UomCode,a.Location,a.Added_at,a.Added_by " _
                & "from tbltank as a inner join tbluomCode as b on a.UomID=b.ID where a.TankName like '%" & txtsearch.Text & "%' and a.Deleted_at is null order by A.TankID desc"
                Call populate(sql, dgTank)
                gvTank.Columns("TankID").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                gvTank.Columns("TankID").SummaryItem.DisplayFormat = "{0:n0}" & " Record(s) found"
                gvTank.BestFitColumns()
                gvTank.RowHeight = 20
            Else
                MsgBox("No record found!", MsgBoxStyle.Information, Me.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        Return True
    End Function
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


    Private Sub gvTank_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvTank.FocusedRowChanged
        Try
            keyID = gvTank.GetRowCellValue(gvTank.FocusedRowHandle, "TankID")
            Dim da = New SqlDataAdapter("select * from tblTank where TankID='" & keyID & "'", kon)
            Dim dset = New DataSet
            da.Fill(dset, "tblTank")
            If dset.Tables("tblTank").Rows.Count > 0 Then
                txtselectedcode.Text = dset.Tables("tblTank").Rows(0).Item("TankID")
            Else
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtselectedcode.Text <> "" Then
            Call filltext()
            txtselectedcode.Text = ""
            txtsearch.Text = ""
        Else
            MsgBox("Please select record!", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub
End Class