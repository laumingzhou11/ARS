Imports System.Data.SqlClient
Public Class frmAddEditAutoRefuelling
    Function populateVehicle() As Boolean
        If txtcode.Text <> "" Then
            Me.Height = 792
            Call konneksyon()
            sql = "select a.VehicleID,a.Code,a.Name,a.Model,a.make,a.PlateNo, " _
                    & "a.CrNo, a.Driver,a.DriverAddress, a.Status, a.TankCapacity, b.UomCode," _
                    & "format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at,c.Name as Added_by,a.VehiclePic,a.DriverPic from tblVehicles As a " _
                    & "inner Join tblUomCode as b on a.UomID=b.ID " _
                    & "inner Join tblEmpUsers as c on a.Added_by=c.EmpID " _
                    & "where a.code='" & txtcode.Text & "'"
            Call fill(sql)
            If dset.Tables(sql).Rows.Count > 0 Then
                lblVehicleID.Text = dset.Tables(sql).Rows(0).Item("VehicleID")
                txtcode.Text = dset.Tables(sql).Rows(0).Item("Code")
                lblModel.Text = dset.Tables(sql).Rows(0).Item("Model")
                lblMake.Text = dset.Tables(sql).Rows(0).Item("Make")
                lblPlateNo.Text = dset.Tables(sql).Rows(0).Item("PlateNo")
                lblCrNo.Text = dset.Tables(sql).Rows(0).Item("CrNo")
                lblDriverName.Text = dset.Tables(sql).Rows(0).Item("Driver")
                lblAddress.Text = dset.Tables(sql).Rows(0).Item("DriverAddress")
                lblStatus.Text = dset.Tables(sql).Rows(0).Item("Status")
                lblCapacity.Text = dset.Tables(sql).Rows(0).Item("TankCapacity")
                lblVehicleName.Text = dset.Tables(sql).Rows(0).Item("Name")
                If IsDBNull(dset.Tables(sql).Rows(0).Item("VehiclePic")) Then
                    VehiclePic.Image = Nothing
                Else
                    Dim mstream As New System.IO.MemoryStream
                    Dim photo As Byte() = dset.Tables(sql).Rows(0).Item("VehiclePic")
                    Dim lstr As New System.IO.MemoryStream(photo)
                    On Error Resume Next
                    VehiclePic.Image = Image.FromStream(lstr)
                    mstream.Close()
                End If
                If IsDBNull(dset.Tables(sql).Rows(0).Item("DriverPic")) Then
                    DriverPic.Image = Nothing
                Else
                    Dim mstream As New System.IO.MemoryStream
                    Dim photo As Byte() = dset.Tables(sql).Rows(0).Item("DriverPic")
                    Dim lstr As New System.IO.MemoryStream(photo)
                    On Error Resume Next
                    DriverPic.Image = Image.FromStream(lstr)
                    mstream.Close()
                End If
            Else
                MsgBox("Vehicle not found!", MsgBoxStyle.Exclamation, "Code Scanning")
                txtcode.Text = ""
                txtcode.Focus()

            End If
        End If
        Return True
    End Function


    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        Call rg()
    End Sub
    Function rg() As Boolean
        If RadioGroup1.SelectedIndex = 1 Then
            gcSelectTank.Enabled = False
            txtTankName.Text = "-"
            txtCapacity.Text = "-"
            cbUomCode.Text = "-"
            txtlocation.Text = "-"
            lblPoNo.Text = "OR No:"
            cbProduct.Enabled = True
            cbSupplier.Enabled = True
            btnSelectTank.Enabled = False
            Call Product()
            Call Supplier()
        ElseIf RadioGroup1.SelectedIndex = 0 Then
            gcSelectTank.Enabled = True
            txtTankName.Text = ""
            txtCapacity.Text = ""
            cbUomCode.Text = ""
            txtlocation.Text = ""
            lblPoNo.Text = "PO No:"
            cbProduct.Enabled = False
            cbSupplier.Enabled = False
            btnSelectTank.Enabled = True
        End If
        Return True
    End Function
    Function Product() As Boolean
        cbProduct.Properties.Items.Clear()
        Dim comm = New SqlCommand("select * from tblProducts", kon)
        Dim dset = New DataSet
        dset.Load(comm.ExecuteReader, LoadOption.OverwriteChanges, "prod")
        For x As Integer = 0 To dset.Tables("prod").Rows.Count - 1
            cbProduct.Properties.Items.Add(dset.Tables("prod").Rows(x).ItemArray(1).ToString)
        Next
        Return True
    End Function
    Function Supplier() As Boolean
        cbSupplier.Properties.Items.Clear()
        Dim comm = New SqlCommand("select * from tblSupplier", kon)
        Dim dset = New DataSet
        dset.Load(comm.ExecuteReader, LoadOption.OverwriteChanges, "Sup")
        For x As Integer = 0 To dset.Tables("Sup").Rows.Count - 1
            cbSupplier.Properties.Items.Add(dset.Tables("Sup").Rows(x).ItemArray(1).ToString)
        Next
        Return True
    End Function
    Function xclear() As Boolean
        RadioGroup1.EditValue = 0
        txtTankName.Text = ""
        txtCapacity.Text = ""
        cbUomCode.Text = ""
        txtlocation.Text = ""
        txtstocks.Text = ""
        txtPoNo.Text = ""
        cbProduct.Text = ""
        cbSupplier.Text = ""
        txtqty.Text = ""
        cbUom.Text = ""
        txtprice.Text = ""
        dgAutoTransaction.DataSource = Nothing
        lblProductID.Text = ""
        lblSupplierID.Text = ""
        txtTotalAmount.Text = ""
        Return True
    End Function
    Function Uom() As Boolean
        cbUom.Properties.Items.Clear()
        Dim comm = New SqlCommand("select * from tblUomCode", kon)
        Dim dset = New DataSet
        dset.Load(comm.ExecuteReader, LoadOption.OverwriteChanges, "uom")
        For x As Integer = 0 To dset.Tables("uom").Rows.Count - 1
            cbUom.Properties.Items.Add(dset.Tables("uom").Rows(x).ItemArray(1).ToString)
        Next
        Return True
    End Function
    Private Sub frmAddEditAutoRefuelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Uom()
    End Sub

    Private Sub txtcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call populateVehicle()
        End If
    End Sub

    Private Sub txtcode_TextChanged(sender As Object, e As EventArgs) Handles txtcode.TextChanged
        If txtcode.Text = "" Then
            Me.Height = 97
        End If
    End Sub
End Class