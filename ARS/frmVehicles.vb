Imports System.Data.SqlClient
Imports DevExpress
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils.Menu
Imports DevExpress.Utils
Imports DevExpress.Utils.Paint
Imports DevExpress.XtraGrid.Columns
Public Class frmVehicles
    Private Sub btnadd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnadd.ItemClick
        frmAddEditVehicles.Text = "Add Vehicle"
        frmAddEditVehicles.txtcarmodel.Select()
        frmAddEditVehicles.xclear()
        frmAddEditVehicles.ShowDialog()
    End Sub
    Function populateVehicle() As Boolean
        Call konneksyon()
        sql = "select a.VehicleID,a.Model,a.make,a.PlateNo, " _
                & "a.CrNo, a.RegisteredOwner,a.OwnerAddress, a.Driver,a.DriverAddress, a.Status, a.TankCapacity, b.UomCode," _
                & "format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at,c.Name as Added_by from tblVehicles As a " _
                & "inner Join tblUomCode as b on a.UomID=b.ID " _
                & "inner Join tblEmpUsers as c on a.Added_by=c.EmpID order by a.VehicleID desc"
        Call populate(sql, dgVehicles)
        lblcount.Caption = gvVehicles.RowCount & " Record(s) Found"
        gvVehicles.BestFitColumns()
        gvVehicles.RowHeight = 20
        Return True
    End Function

    Private Sub frmVehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call populateVehicle()
    End Sub
    Function filltext() As Boolean
        Call konneksyon()
        sql = "select a.VehicleID,a.Model,a.make,a.PlateNo, " _
                & "a.CrNo, a.RegisteredOwner,a.OwnerAddress, a.Driver,a.DriverAddress, a.Status, a.TankCapacity, b.UomCode," _
                & "format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at,c.Name as Added_by,a.VehiclePic,a.DriverPic from tblVehicles As a " _
                & "inner Join tblUomCode as b on a.UomID=b.ID " _
                & "inner Join tblEmpUsers as c on a.Added_by=c.EmpID " _
                & "where a.VehicleID='" & keyID & "'"
        Call fill(sql)
        frmAddEditVehicles.txtvehicleID.Text = dset.Tables(sql).Rows(0).Item("VehicleID")
        frmAddEditVehicles.txtcarmodel.Text = dset.Tables(sql).Rows(0).Item("Model")
        frmAddEditVehicles.txtcarmake.Text = dset.Tables(sql).Rows(0).Item("Make")
        frmAddEditVehicles.txtplateNo.Text = dset.Tables(sql).Rows(0).Item("PlateNo")
        frmAddEditVehicles.txtCrNo.Text = dset.Tables(sql).Rows(0).Item("CrNo")
        frmAddEditVehicles.txtOwner.Text = dset.Tables(sql).Rows(0).Item("RegisteredOwner")
        frmAddEditVehicles.txtOwnerAddress.Text = dset.Tables(sql).Rows(0).Item("OwnerAddress")
        frmAddEditVehicles.txtDriver.Text = dset.Tables(sql).Rows(0).Item("Driver")
        frmAddEditVehicles.txtDriverAddress.Text = dset.Tables(sql).Rows(0).Item("DriverAddress")
        frmAddEditVehicles.cbstatus.Text = dset.Tables(sql).Rows(0).Item("Status")
        frmAddEditVehicles.txtCapacity.Text = dset.Tables(sql).Rows(0).Item("TankCapacity")
        frmAddEditVehicles.cbUomCode.Text = dset.Tables(sql).Rows(0).Item("UomCode")
        If IsDBNull(dset.Tables(sql).Rows(0).Item("VehiclePic")) Then
            frmAddEditVehicles.picImage.Image = Nothing
        Else
            Dim mstream As New System.IO.MemoryStream
            Dim photo As Byte() = dset.Tables(sql).Rows(0).Item("VehiclePic")
            Dim lstr As New System.IO.MemoryStream(photo)
            On Error Resume Next
            frmAddEditVehicles.picImage.Image = Image.FromStream(lstr)
            mstream.Close()
        End If
        If IsDBNull(dset.Tables(sql).Rows(0).Item("DriverPic")) Then
            frmAddEditVehicles.DriverPic.Image = Nothing
        Else
            Dim mstream As New System.IO.MemoryStream
            Dim photo As Byte() = dset.Tables(sql).Rows(0).Item("DriverPic")
            Dim lstr As New System.IO.MemoryStream(photo)
        On Error Resume Next
            frmAddEditVehicles.picImage.Image = Image.FromStream(lstr)
            mstream.Close()
        End If
        Call frmAddEditVehicles.Uom()
        Return True
    End Function
    Function Search() As Boolean
        Try
            If txtsearch.Text = "" Then
                Call konneksyon()
                sql = "select a.VehicleID,a.Model,a.make,a.PlateNo, " _
                & "a.CrNo, a.RegisteredOwner,a.OwnerAddress, a.Driver,a.DriverAddress, a.Status, a.TankCapacity, b.UomCode," _
                & "format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at,c.Name as Added_by from tblVehicles As a " _
                & "inner Join tblUomCode as b on a.UomID=b.ID " _
                & "inner Join tblEmpUsers as c on a.Added_by=c.EmpID  where Model like '%" & txtsearch.Text & "%' order by a.vehicleID desc"
                Call populate(sql, dgVehicles)
                If dset.Tables(sql).Rows.Count > 0 Then
                    lblcount.Caption = gvVehicles.RowCount & " Record(s) Found"
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

    Private Sub btnedit_ItemClick(sender As Object, e As XtraBars.ItemClickEventArgs) Handles btnedit.ItemClick
        If txtselectedcode.Text <> "" Then
            Call filltext()
            frmAddEditVehicles.Text = "Edit Vehicle"
            frmAddEditVehicles.ShowDialog()
        Else
            MsgBox("Select record to edit!", MsgBoxStyle.Information, Me.Text)
        End If
    End Sub
    Private Sub gvVehicles_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvVehicles.FocusedRowChanged
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
End Class