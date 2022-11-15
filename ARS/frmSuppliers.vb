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
Public Class frmSuppliers
    Private Sub btnadd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnadd.ItemClick
        frmAddEditSuppliers.txtsupplierName.Select()
        frmAddEditSuppliers.Text = "Add Supplier"
        frmAddEditSuppliers.xclear()
        frmAddEditSuppliers.ShowDialog()
    End Sub

    Private Sub frmSuppliers_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call populateSupplier()
    End Sub

    Function populateSupplier() As Boolean
        Call konneksyon()
        sql = "select SupplierID, SupplierName, Address, ContactPerson, ContactNo,Added_at,Added_by from tblSupplier order by SupplierID desc"
        Call populate(sql, dgsupplier)
        lblcount.Caption = gvsupplier.RowCount & " Record(s) Found"
        gvsupplier.BestFitColumns()
        gvsupplier.RowHeight = 20
        Return True
    End Function
    Function filltext() As Boolean
        Call konneksyon()
        sql = "select SupplierID, SupplierName, Address, ContactPerson, ContactNo,Added_at,Added_by from tblSupplier where SupplierID='" & keyID & "'"
        Call fill(sql)
        frmAddEditSuppliers.txtsupplierID.Text = dset.Tables(sql).Rows(0).Item("SupplierID")
        frmAddEditSuppliers.txtsupplierName.Text = dset.Tables(sql).Rows(0).Item("SupplierName")
        frmAddEditSuppliers.txtSupplierAddress.Text = dset.Tables(sql).Rows(0).Item("Address")
        frmAddEditSuppliers.txtContactPerson.Text = dset.Tables(sql).Rows(0).Item("ContactPerson")
        frmAddEditSuppliers.txtCpNo.Text = dset.Tables(sql).Rows(0).Item("ContactNo")

        Return True
    End Function
    Function Search() As Boolean
        Try
            If txtsearch.Text = "" Then
                Call konneksyon()
                sql = "select SupplierID, SupplierName, Address, ContactPerson, " _
                    & "ContactNo,Added_at,Added_by from tblSupplier where SupplierName like '%" & txtsearch.Text & "%' order by SupplierID desc"
                Call populate(sql, dgsupplier)
                If dset.Tables(sql).Rows.Count > 0 Then
                    lblcount.Caption = gvsupplier.RowCount & " Record(s) Found"
                    gvsupplier.BestFitColumns()
                    gvsupplier.RowHeight = 20
                Else
                    MsgBox("No record found!", MsgBoxStyle.Information, Me.Text)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        Return True
    End Function
    Private Sub gvsupplier_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvsupplier.CustomDrawCell
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
            frmAddEditSuppliers.Text = "Edit Supplier"
            frmAddEditSuppliers.ShowDialog()
        Else
            MsgBox("Select record to edit!", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub
    Private Sub gvsupplier_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvsupplier.FocusedRowChanged
        Try
            keyID = gvsupplier.GetRowCellValue(gvsupplier.FocusedRowHandle, "SupplierID")
            Dim da = New SqlDataAdapter("select * from tblsupplier where SupplierID='" & keyID & "'", kon)
            Dim dset = New DataSet
            da.Fill(dset, "tblsupplier")
            If dset.Tables("tblsupplier").Rows.Count > 0 Then
                txtselectedcode.Text = dset.Tables("tblsupplier").Rows(0).Item("SupplierID")
            Else
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class