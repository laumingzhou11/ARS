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
        sql = "select A.TankID,a.TankName,A.TankCapacity,b.UomCode,a.Location " _
                & "from tbltank as a inner join tbluomCode as b on a.UomID=b.ID order by TankID desc"
        Call populate(sql, dgTank)
        gvTank.Columns(gvTank.RowCount).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        gvTank.Columns(gvTank.RowCount).SummaryItem.DisplayFormat = "{0:n0}"
        gvTank.BestFitColumns()
        gvTank.RowHeight = 20
        Return True
    End Function
    Function filltext() As Boolean
        Call konneksyon()
        sql = "select A.TankID,a.TankName,A.TankCapacity,b.UomCode,a.Location " _
                & "from tbltank as a inner join tbluomCode as b on a.UomID=b.ID where TankID='" & keyID & "'"
        Call fill(sql)
        frmAddEditTankRefuelling.lbltankID.Text = dset.Tables(sql).Rows(0).Item("TankID")
        frmAddEditTankRefuelling.txtTankName.Text = dset.Tables(sql).Rows(0).Item("TankName")
        frmAddEditTankRefuelling.txtCapacity.Text = dset.Tables(sql).Rows(0).Item("TankCapacity")
        frmAddEditTankRefuelling.cbUomCode.Text = dset.Tables(sql).Rows(0).Item("UomCode")
        frmAddEditTankRefuelling.txtlocation.Text = dset.Tables(sql).Rows(0).Item("Location")
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
                sql = "select A.TankID,a.TankName,A.TankCapacity,b.UomCode,a.Location,a.Added_at,a.Added_by " _
                & "from tbltank as a inner join tbluomCode as b on a.UomID=b.ID where a.TankName like '%" & txtsearch.Text & "%'order by TankID desc"
                Call populate(sql, dgTank)
                gvTank.Columns(gvTank.RowCount).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                gvTank.Columns(gvTank.RowCount).SummaryItem.DisplayFormat = "{0:n0}"
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
            frmAddEditTankRefuelling.ShowDialog()
            txtselectedcode.Text = ""
            txtsearch.Text = ""
            Me.Close()
            frmAddEditTankRefuelling.txtqty.Select()
        Else
            MsgBox("Please select record!", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub
End Class