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
Public Class frmProducts
    Private Sub btnadd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnadd.ItemClick
        frmAddEditProducts.txtDescription.Select()
        frmAddEditProducts.Text = "Add Product"
        frmAddEditProducts.xclear()
        frmAddEditProducts.ShowDialog()
    End Sub

    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call populateProducts()
    End Sub
    Function populateProducts() As Boolean
        Call konneksyon()
        sql = "select a.ProductID, a.ItemDescription,b.SupplierName,format(a.Price,'c', 'fil-PH') as Price,format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at, c.Name as Added_by from tblProducts as a " _
            & "inner join tblsupplier as b on a.SupplierID=b.SupplierID " _
            & "inner join tblEmpusers as c on a.Added_by=c.EmpID where a.Deleted_at<>null order by a.ProductID desc"
        Call populate(sql, dgProducts)
        lblcount.Caption = gvproducts.RowCount & " Record(s) Found"
        gvproducts.BestFitColumns()
        gvproducts.RowHeight = 20
        Return True
    End Function
    Function filltext() As Boolean
        Call konneksyon()
        sql = "select a.ProductID, a.ItemDescription,b.SupplierName,a.Price,d.UomCode,a.Added_at, c.Name from tblProducts as a " _
            & "inner join tblsupplier as b on a.SupplierID=b.SupplierID " _
            & "inner join tblEmpusers as c on a.Added_by=c.EmpID " _
            & "inner join tblUomCode as d on a.UomID=d.ID where ProductID='" & keyID & "'"
        Call fill(sql)
        frmAddEditProducts.txtProductID.Text = dset.Tables(sql).Rows(0).Item("ProductID")
        frmAddEditProducts.txtDescription.Text = dset.Tables(sql).Rows(0).Item("ItemDescription")
        frmAddEditProducts.cbSupplier.Text = dset.Tables(sql).Rows(0).Item("SupplierName")
        frmAddEditProducts.txtPrice.Text = dset.Tables(sql).Rows(0).Item("Price")
        frmAddEditProducts.cbUom.Text = dset.Tables(sql).Rows(0).Item("UomCode")
        Call frmAddEditProducts.Supplier()
        Call frmAddEditProducts.Uom()
        Return True
    End Function
    Function Search() As Boolean
        Try
            If txtsearch.Text = "" Then
                Call konneksyon()
                sql = "select a.ProductID, a.ItemDescription,b.SupplierName,a.Price,format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at, c.Name from tblProducts as a " _
                    & "inner join tblsupplier as b on a.SupplierID=b.SupplierID " _
                    & "inner join tblEmpusers as c on a.Added_by=c.EmpID where ItemDescription like '%" & txtsearch.Text & "%' and a.Deleted_at<>null order by a.ProductID desc"
                Call populate(sql, dgProducts)
                If dset.Tables(sql).Rows.Count > 0 Then
                    lblcount.Caption = gvproducts.RowCount & " Record(s) Found"
                    gvproducts.BestFitColumns()
                    gvproducts.RowHeight = 20
                Else
                    MsgBox("No record found!", MsgBoxStyle.Information, Me.Text)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        Return True
    End Function
    Private Sub gvproducts_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvproducts.CustomDrawCell
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
    Private Sub gvproducts_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvproducts.FocusedRowChanged
        Try
            keyID = gvproducts.GetRowCellValue(gvproducts.FocusedRowHandle, "ProductID")
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
End Class