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
Public Class frmSelectVehicle
    Private Sub frmSelectVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call populateVehicle()
    End Sub
    Function populateVehicle() As Boolean
        Call konneksyon()
        sql = "select a.VehicleID,a.Code,a.Name,a.Model,a.make,a.PlateNo, " _
                & "a.CrNo, a.RegisteredOwner,a.OwnerAddress, a.Driver,a.DriverAddress, a.Status, concat(format(a.TankCapacity,'#,#.##'),' ',b.UomCode)  as TankCapacity," _
                & "format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at,c.Name as Added_by from tblVehicles As a " _
                & "inner Join tblUomCode as b on a.UomID=b.ID " _
                & "inner Join tblEmpUsers as c on a.Added_by=c.EmpID where a.Deleted_at is null order by a.VehicleID desc"
        Call populate(sql, dgVehicles)
        gvVehicles.BestFitColumns()
        gvVehicles.RowHeight = 20
        gvVehicles.Columns("VehicleID").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        gvVehicles.Columns("VehicleID").SummaryItem.DisplayFormat = "{0:n0}" & " Record(s) Found"
        Return True
    End Function
    Private Sub gvVehicles_CustomDrawCell(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvVehicles.CustomDrawCell
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
    Function filltext() As Boolean
        Call konneksyon()
        sql = "select a.VehicleID,a.Code,a.Name,a.Model,a.make,a.PlateNo, " _
                    & "a.CrNo, a.Driver,a.DriverAddress, a.Status, format(a.TankCapacity,'#,#.##') as TankCapacity, b.UomCode," _
                    & "format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at,c.Name as Added_by,a.VehiclePic,a.DriverPic from tblVehicles As a " _
                    & "inner Join tblUomCode as b on a.UomID=b.ID " _
                    & "inner Join tblEmpUsers as c on a.Added_by=c.EmpID " _
                    & "where a.VehicleID='" & keyID & "'"
        Call fill(sql)
        If dset.Tables(sql).Rows.Count > 0 Then
            frmAddEditAutoRefuelling.lblVehicleID.Text = dset.Tables(sql).Rows(0).Item("VehicleID")
            frmAddEditAutoRefuelling.lblCOde.Text = dset.Tables(sql).Rows(0).Item("Code")
            frmAddEditAutoRefuelling.lblModel.Text = dset.Tables(sql).Rows(0).Item("Model")
            frmAddEditAutoRefuelling.lblMake.Text = dset.Tables(sql).Rows(0).Item("Make")
            frmAddEditAutoRefuelling.lblPlateNo.Text = dset.Tables(sql).Rows(0).Item("PlateNo")
            frmAddEditAutoRefuelling.lblCrNo.Text = dset.Tables(sql).Rows(0).Item("CrNo")
            frmAddEditAutoRefuelling.lblDriverName.Text = dset.Tables(sql).Rows(0).Item("Driver")
            frmAddEditAutoRefuelling.lblAddress.Text = dset.Tables(sql).Rows(0).Item("DriverAddress")
            frmAddEditAutoRefuelling.lblStatus.Text = dset.Tables(sql).Rows(0).Item("Status")
            frmAddEditAutoRefuelling.lblCapacity.Text = dset.Tables(sql).Rows(0).Item("TankCapacity")
            frmAddEditAutoRefuelling.lblVehicleName.Text = dset.Tables(sql).Rows(0).Item("Name")
            If IsDBNull(dset.Tables(sql).Rows(0).Item("VehiclePic")) Then
                frmAddEditAutoRefuelling.VehiclePic.Image = Nothing
            Else
                Dim mstream As New System.IO.MemoryStream
                Dim photo As Byte() = dset.Tables(sql).Rows(0).Item("VehiclePic")
                Dim lstr As New System.IO.MemoryStream(photo)
                On Error Resume Next
                frmAddEditAutoRefuelling.VehiclePic.Image = Image.FromStream(lstr)
                mstream.Close()
            End If
            If IsDBNull(dset.Tables(sql).Rows(0).Item("DriverPic")) Then
                frmAddEditAutoRefuelling.DriverPic.Image = Nothing
            Else
                Dim mstream As New System.IO.MemoryStream
                Dim photo As Byte() = dset.Tables(sql).Rows(0).Item("DriverPic")
                Dim lstr As New System.IO.MemoryStream(photo)
                On Error Resume Next
                frmAddEditAutoRefuelling.DriverPic.Image = Image.FromStream(lstr)
                mstream.Close()
            End If
            frmAddEditAutoRefuelling.PanelVehicle.Visible = True
            If frmAddEditAutoRefuelling.PanelVehicle.Visible = True Then
                frmAddEditAutoRefuelling.GCTransaction.Enabled = True
                frmAddEditAutoRefuelling.RadioGroup1.Enabled = True
                frmAddEditAutoRefuelling.gcHistory.Enabled = True
                frmAddEditAutoRefuelling.btnsave.Enabled = True
                frmAddEditAutoRefuelling.btncancel.Enabled = True
            End If
            Call frmAddEditAutoRefuelling.PopulateHistory()
            frmAddEditAutoRefuelling.txtcode.Text = ""
        Else
            MsgBox("Vehicle not found!", MsgBoxStyle.Exclamation, "Code Scanning")
            frmAddEditAutoRefuelling.txtcode.Text = ""
            frmAddEditAutoRefuelling.txtcode.Focus()

        End If
        Return True
    End Function
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtselectedcode.Text <> "" Then
            Call filltext()
            Me.Close()
            txtselectedcode.Text = ""
            txtsearch.Text = ""

        Else
            MsgBox("Please select record!", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub

    Private Sub gvVehicles_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles gvVehicles.RowCellClick
        Try
            keyID = gvVehicles.GetRowCellValue(gvVehicles.FocusedRowHandle, "VehicleID")
            Dim da = New SqlDataAdapter("select * from tblVehicles where VehicleID='" & keyID & "'", kon)
            Dim dset = New DataSet
            da.Fill(dset, "tblVehicles")
            If dset.Tables("tblVehicles").Rows.Count > 0 Then
                txtselectedcode.Text = dset.Tables("tblVehicles").Rows(0).Item("VehicleID")
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
            Call populateVehicle()
        End If
    End Sub
    Function Search() As Boolean
        Try
            If txtsearch.Text <> "" Then
                Call konneksyon()
                sql = "select a.VehicleID,a.Code,a.Name,a.Model,a.make,a.PlateNo, " _
                & "a.CrNo, a.RegisteredOwner,a.OwnerAddress, a.Driver,a.DriverAddress, a.Status, concat(format(a.TankCapacity,'#,#.##'),' ',b.UomCode)  as TankCapacity," _
                & "format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at,c.Name as Added_by from tblVehicles As a " _
                & "inner Join tblUomCode as b on a.UomID=b.ID " _
                & "inner Join tblEmpUsers as c on a.Added_by=c.EmpID  where a.Name like '%" & txtsearch.Text & "%' and a.Deleted_at is null order by a.vehicleID desc"
                Call populate(sql, dgVehicles)
                If dset.Tables(sql).Rows.Count > 0 Then
                    gvVehicles.Columns("VehicleID").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                    gvVehicles.Columns("VehicleID").SummaryItem.DisplayFormat = "{0:n0}" & " Record(s) Found"
                    gvVehicles.BestFitColumns()
                    gvVehicles.RowHeight = 20
                Else
                    MsgBox("No record found!", MsgBoxStyle.Information, Me.Text)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

        Return True
    End Function
End Class