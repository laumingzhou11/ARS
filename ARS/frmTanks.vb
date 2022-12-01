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
Public Class frmTanks
    Private Sub frmTanks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call populateTank()
    End Sub

    Private Sub btnadd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnadd.ItemClick
        frmAddEditTank.Text = "Add Tank"
        frmAddEditTank.txtTankName.Select()
        frmAddEditTank.ShowDialog()
    End Sub
    Function populateTank() As Boolean
        Call konneksyon()
        sql = "select A.TankID,a.TankName,format(A.TankCapacity,'#,#') as TankCapacity,b.UomCode,a.Location,format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at,c.name as Added_by " _
                & "from tbltank as a inner join tbluomCode as b on a.UomID=b.ID " _
                & "inner join tblEmpUsers as c on a.Added_by=c.EmpID where a.Deleted_at is null order by TankID desc"
        Call populate(sql, dgTank)
        lblcount.Caption = gvTank.RowCount & " Record(s) Found"
        gvTank.BestFitColumns()
        gvTank.RowHeight = 20
        Return True
    End Function
    Function filltext() As Boolean
        Call konneksyon()
        sql = "select A.TankID,a.TankName,A.TankCapacity,b.UomCode,a.Location,a.Added_at,a.Added_by " _
                & "from tbltank as a inner join tbluomCode as b on a.UomID=b.ID where TankID='" & keyID & "'"
        Call fill(sql)
        frmAddEditTank.txtTankID.Text = dset.Tables(sql).Rows(0).Item("TankID")
        frmAddEditTank.txtTankName.Text = dset.Tables(sql).Rows(0).Item("TankName")
        frmAddEditTank.txtCapacity.Text = dset.Tables(sql).Rows(0).Item("TankCapacity")
        frmAddEditTank.cbUomCode.Text = dset.Tables(sql).Rows(0).Item("UomCode")
        frmAddEditTank.txtLocation.Text = dset.Tables(sql).Rows(0).Item("Location")
        Call frmAddEditTank.Uom()
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
                sql = "select A.TankID,a.TankName,format(A.TankCapacity,'#,#') as TankCapacity,b.UomCode,a.Location,format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at,c.name as Added_by " _
                & "from tbltank as a inner join tbluomCode as b on a.UomID=b.ID " _
                & "inner join tblEmpUsers as c on a.Added_by=c.EmpID where a.TankName like '%" & txtsearch.Text & "%' and a.Deleted_at<>null order by TankID desc"
                Call populate(sql, dgTank)
                lblcount.Caption = gvTank.RowCount & " Record(s) Found"
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

    Private Sub btnedit_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles btnedit.ItemClick
        If txtselectedcode.Text <> "" Then
            Call filltext()
            frmAddEditTank.Text = "Edit Tank"
            frmAddEditTank.ShowDialog()
        Else
            MsgBox("Select record to edit!", MsgBoxStyle.Information, Me.Text)
        End If
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
End Class