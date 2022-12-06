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
Public Class frmSelectProduct
    Private Sub frmSelectProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call populateProduct()
    End Sub
    Function populateProduct() As Boolean
        Call konneksyon()
        sql = "select a.ProductID, a.ItemDescription,b.SupplierName,a.Price from tblProducts as a " _
            & "inner join tblsupplier as b on a.SupplierID=b.SupplierID where a.Deleted_at is null order by a.ProductID desc"
        Call populate(sql, dgProduct)
        gvProduct.Columns("ProductID").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        gvProduct.Columns("ProductID").SummaryItem.DisplayFormat = "{0:n0}" & " Record(s) Found"
        gvProduct.BestFitColumns()
        gvProduct.RowHeight = 20
        Return True
    End Function
    Function filltext() As Boolean
        Call konneksyon()
        sql = "select a.TankID,a.ProductID,c.SupplierName as Supplier,b.ItemDescription as Item from tblTankTransaction as a inner join tblProducts as b on a.ProductID=b.ProductID " _
                & "inner join tblsupplier as c on b.SupplierID=c.SupplierID where a.TankID='" & frmAddEditTankRefuelling.lbltankID.Text & "' and a.ProductID ='" & keyID & "'"
        Call fill(sql)
        If dset.Tables(sql).Rows.Count = 0 Then
            MsgBox("Tank already reufelled", MsgBoxStyle.Exclamation, Me.Text)
        Else
            sql = "select a.ProductID, a.ItemDescription,b.SupplierName,a.Price from tblProducts as a  " _
            & "inner join tblsupplier as b on a.SupplierID=b.SupplierID where a.ProductID='" & keyID & "'"
            Call fill(sql)
            frmAddEditTankRefuelling.lblProductID.Text = dset.Tables(sql).Rows(0).Item("ProductID")
            frmAddEditTankRefuelling.txtproduct.Text = dset.Tables(sql).Rows(0).Item("ItemDescription")
            frmAddEditTankRefuelling.txtsupplier.Text = dset.Tables(sql).Rows(0).Item("SupplierName")
            frmAddEditTankRefuelling.txtprice.Text = dset.Tables(sql).Rows(0).Item("Price")
            Me.Close()
        End If
        Return True
    End Function
    Private Sub gvProduct_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvProduct.CustomDrawCell
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
            If txtsearch.Text <> "" Then
                Call konneksyon()
                sql = "select a.ProductID, a.ItemDescription,b.SupplierName,a.Price from tblProducts as a  " _
            & "inner join tblsupplier as b on a.SupplierID=b.SupplierID where a.ItemDescription like '%" & txtsearch.Text & "%' and a.Deleted_at is null order by TankID desc"
                Call populate(sql, dgProduct)
                gvProduct.Columns(gvProduct.RowCount).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                gvProduct.Columns(gvProduct.RowCount).SummaryItem.DisplayFormat = "{0:n0}"
                gvProduct.BestFitColumns()
                gvProduct.RowHeight = 20
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


    Private Sub gvProduct_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvProduct.FocusedRowChanged

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

    Private Sub gvProduct_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles gvProduct.RowCellClick
        Try
            keyID = gvProduct.GetRowCellValue(gvProduct.FocusedRowHandle, "ProductID")
            Dim da = New SqlDataAdapter("select * from tblProducts where ProductID='" & keyID & "'", kon)
            Dim dset = New DataSet
            da.Fill(dset, "tblProducts")
            If dset.Tables("tblProducts").Rows.Count > 0 Then
                txtselectedcode.Text = dset.Tables("tblProducts").Rows(0).Item("ProductID")
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
            Call populateProduct()
        End If
    End Sub
End Class