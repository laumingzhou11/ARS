﻿Imports System.Data.SqlClient
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
        frmAddEditAutoRefuelling.txtcode.Select()
        frmAddEditAutoRefuelling.Text = "Auto Refuelling - Stock Out"
        frmAddEditAutoRefuelling.StartPosition = FormStartPosition.CenterScreen
        frmAddEditAutoRefuelling.rg()
        frmAddEditAutoRefuelling.xclear()
        frmAddEditAutoRefuelling.ShowDialog()
    End Sub
    Function populateAuto() As Boolean
        Call konneksyon()
        sql = "select a.AutoTransactionID as TransNo,format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at, " _
                & "a.PoNo,b.Name as Vehicle,c.Tankname as Tank,d1.SupplierName as Supplier,d.ItemDescription as Product,format(a.StockOut,'#,#') as Qty,format(a.Price,'c', 'fil-PH') as Price, " _
                & "format((select SUM(StockOut*Price) from tblAutoTransaction where AutoTransactionID=a.AutoTransactionID),'c', 'fil-PH') as TotalAmount,A. Refilled_by " _
                & "from tblAutoTransaction as a " _
                & "inner join tblVehicles as b on a.VehicleID=b.VehicleID " _
                & "inner join tbltank as c on a.TankID=c.TankID " _
                & "inner join tblProducts as d on a.ProductID=d.ProductID " _
                & "inner join tblSupplier as d1 on d.SupplierID=d1.SupplierID " _
                & "inner join tblEmpUsers as e on a.Added_by=e.EmpID order by a.AutoTransactionID desc"
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
            If txtsearch.Text = "" Then
                Call konneksyon()
                sql = "select a.AutoTransactionID as TransNo,format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at, " _
                & "a.PoNo,b.Name as Vehicle,c.Tankname as Tank,d1.SupplierName as Supplier,d.ItemDescription as Product,format(a.StockOut,'#,#') as Qty,format(a.Price,'c', 'fil-PH') as Price, " _
                & "format((select SUM(StockOut*Price) from tblAutoTransaction where AutoTransactionID=a.AutoTransactionID),'c', 'fil-PH') as TotalAmount,A. Refilled_by " _
                & "from tblAutoTransaction as a " _
                & "inner join tblVehicles as b on a.VehicleID=b.VehicleID " _
                & "inner join tbltank as c on a.TankID=c.TankID " _
                & "inner join tblProducts as d on a.ProductID=d.ProductID " _
                & "inner join tblSupplier as d1 on d.SupplierID=d1.SupplierID " _
                & "inner join tblEmpUsers as e on a.Added_by=e.EmpID where c.TankName like '%" & txtsearch.Text & "%' or " _
                & "a.PoNo like '%" & txtsearch.Text & "%' or d.ItemDescription like '%" & txtsearch.Text & "%' or " _
                & "d1.SupplierName like '%" & txtsearch.Text & "%' or a.Refilled_by like '%" & txtsearch.Text & "%' or " _
                & "b.Name like '%" & txtsearch.Text & "%' order by a.AutoTransactionID desc"
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
            ' Call filltext()
            frmAddEditTankRefuelling.Text = "Tank Refuelling - Edit Stock IN"
            frmAddEditTankRefuelling.ShowDialog()
        Else
            MsgBox("Select record to edit!", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub
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
End Class