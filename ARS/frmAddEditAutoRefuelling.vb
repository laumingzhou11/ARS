Imports System.Data.SqlClient
Public Class frmAddEditAutoRefuelling
    Function populateVehicle() As Boolean
        If txtcode.Text <> "" Then
            Call konneksyon()
            sql = "select a.VehicleID,a.Code,a.Name,a.Model,a.make,a.PlateNo, " _
                    & "a.CrNo, a.Driver,a.DriverAddress, a.Status, format(a.TankCapacity,'#,#.##') as TankCapacity, b.UomCode," _
                    & "format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at,c.Name as Added_by,a.VehiclePic,a.DriverPic from tblVehicles As a " _
                    & "inner Join tblUomCode as b on a.UomID=b.ID " _
                    & "inner Join tblEmpUsers as c on a.Added_by=c.EmpID " _
                    & "where a.code='" & txtcode.Text & "'"
            Call fill(sql)
            If dset.Tables(sql).Rows.Count > 0 Then
                lblVehicleID.Text = dset.Tables(sql).Rows(0).Item("VehicleID")
                lblCOde.Text = dset.Tables(sql).Rows(0).Item("Code")
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
                PanelVehicle.Visible = True
                If PanelVehicle.Visible = True Then
                    GCTransaction.Enabled = True
                    RadioGroup1.Enabled = True
                    gcHistory.Enabled = True
                    btnsave.Enabled = True
                    btncancel.Enabled = True
                End If

                Call PopulateHistory()
                txtcode.Text = ""
            Else
                MsgBox("Vehicle not found!", MsgBoxStyle.Exclamation, "Code Scanning")
                txtcode.Text = ""
                txtcode.Focus()

            End If
        End If
        Return True
    End Function


    Private Sub RadioGroup1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup1.SelectedIndexChanged
        If RadioGroup1.SelectedIndex = 1 Then
            gcSelectTank.Enabled = False
            lblTankID.Text = 1
            txtTankName.Text = "-"
            txtCapacity.Text = "-"
            cbUomCode.Text = "-"
            txtlocation.Text = "-"
            lblPoNo.Text = "OR No:"
            cbProduct.Enabled = True
            btnSelectTank.Enabled = False
            txtstocks.Text = ""
            Call Product()
            Call Supplier()
        ElseIf RadioGroup1.SelectedIndex = 0 Then
            Call rg()
        End If
    End Sub
    Function rg() As Boolean
        gcSelectTank.Enabled = True
        txtTankName.Text = ""
        txtCapacity.Text = ""
        'cbUomCode.Text = ""
        txtlocation.Text = ""
        lblPoNo.Text = "PO No:"
        cbProduct.Enabled = False
        btnSelectTank.Enabled = True
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
        txtcode.Text = ""
        txtRefilledby.Text = ""
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
    Function AutoHistory() As Boolean
        Call konneksyon()
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

    'Private Sub txtcode_TextChanged(sender As Object, e As EventArgs) Handles txtcode.TextChanged
    '    If txtcode.Text = "" Then
    '        PanelVehicle.Visible = False
    '        GCTransaction.Enabled = False
    '        gcHistory.Enabled = False
    '        btnsave.Enabled = False
    '        btncancel.Enabled = False
    '    End If
    'End Sub

    Private Sub txtPoNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPoNo.KeyPress
        If RadioGroup1.SelectedIndex = 1 Then
            If Asc(e.KeyChar) = 13 Then
                If txtPoNo.Text = "" Then
                    txtPoNo.Focus()
                Else
                    With cbProduct
                        .SelectionStart = 0
                        .SelectionLength = Len(.Text)
                        .Focus()
                    End With
                End If
            End If
        Else
            If Asc(e.KeyChar) = 13 Then
                If txtPoNo.Text = "" Then
                    txtPoNo.Focus()
                Else
                    With txtqty
                        .SelectionStart = 0
                        .SelectionLength = Len(.Text)
                        .Focus()
                    End With
                End If
            End If
        End If
    End Sub
    Private Sub cbProduct_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbProduct.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If cbProduct.Text = "" Then
                cbProduct.Focus()
            Else
                With txtqty
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With


            End If
        End If
        Call konneksyon()
        sql = "select a.productID,ItemDescription,b.SupplierName from tblProducts as a " _
                    & "inner join tblSupplier as b on a.SupplierID=b.SupplierID where a.ItemDescription='" & cbProduct.Text & "'"
        Call fill(sql)
        lblProductID.Text = dset.Tables(sql).Rows(0).Item("productID")
        cbSupplier.Text = dset.Tables(sql).Rows(0).Item("SupplierName")
    End Sub
    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtqty.Text = "" Then
                txtqty.Focus()
            Else
                With cbUom
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub txtcode_Enter(sender As Object, e As EventArgs) Handles txtcode.Enter
        If txtcode.Text = "SCAN YOUR QR CODE HERE" Then
            txtcode.Text = ""
            txtcode.ForeColor = Color.Black
        End If
        txtcode.BackColor = Color.LightBlue
    End Sub
    Private Sub txtcode_Leave(sender As Object, e As EventArgs) Handles txtcode.Leave
        If txtcode.Text = "" Then
            txtcode.Text = "SCAN YOUR QR CODE HERE"
            txtcode.ForeColor = Color.Gray
        End If
        txtcode.BackColor = Color.White
    End Sub
    Private Sub cbUom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbUom.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If cbUom.Text = "" Then
                cbUom.Focus()
            Else
                With txtprice
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub txtprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprice.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtprice.Text = "" Then
                txtprice.Focus()
            Else
                With txtRefilledby
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub txtRefilledby_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRefilledby.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtRefilledby.Text = "" Then
                txtRefilledby.Focus()
            Else
                With btnsave
                    .Focus()
                End With
            End If
        End If
    End Sub


    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, Me.Text) = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub
    Private Sub txtqty_EditValueChanged(sender As Object, e As EventArgs) Handles txtqty.EditValueChanged
        Dim price As Double = Val(txtprice.Text)
        Dim qty As Double = Val(txtqty.Text)
        Dim totalAmount = qty * price
        txtTotalAmount.Text = FormatNumber(totalAmount, 2)
    End Sub
    Private Sub txtprice_EditValueChanged(sender As Object, e As EventArgs) Handles txtprice.EditValueChanged
        Dim price As Double = Val(txtprice.Text)
        Dim qty As Double = Val(txtqty.Text)
        Dim totalAmount = qty * price
        txtTotalAmount.Text = FormatNumber(totalAmount, 2)
    End Sub
    Function PopulateHistory() As Boolean
        Call konneksyon()
        sql = "select a.AutoTransactionID as TransNo,format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at, " _
                & "a.PoNo,b.Name as Vehicle,c.Tankname as Tank,d1.SupplierName as Supplier,d.ItemDescription as Product,format(a.StockOut,'#,#') as Qty,format(a.Price,'c', 'fil-PH') as Price, " _
                & "format((select SUM(StockOut*Price) from tblAutoTransaction where AutoTransactionID=a.AutoTransactionID),'c', 'fil-PH') as TotalAmount,A. Refilled_by " _
                & "from tblAutoTransaction as a " _
                & "inner join tblVehicles as b on a.VehicleID=b.VehicleID " _
                & "inner join tbltank as c on a.TankID=c.TankID " _
                & "inner join tblProducts as d on a.ProductID=d.ProductID " _
                & "inner join tblSupplier as d1 on d.SupplierID=d1.SupplierID " _
                & "inner join tblEmpUsers as e on a.Added_by=e.EmpID where b.VehicleID= '" & lblVehicleID.Text & "' order by a.AutoTransactionID desc"
        Call populate(sql, dgAutoTransaction)
        If dset.Tables(sql).Rows.Count > 0 Then
            gvAutoTransaction.BestFitColumns()
            gvAutoTransaction.RowHeight = 20

        Else
            gvAutoTransaction.Columns("TransNo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            gvAutoTransaction.Columns("TransNo").SummaryItem.DisplayFormat = "{0:n0}" & " Record(s) Found"
        End If

        Return True
    End Function


    Private Sub btnSelectTank_Click(sender As Object, e As EventArgs) Handles btnSelectTank.Click
        frmSelectTank.lblSelectTank.Text = "Auto"
        frmSelectTank.txtsearch.Select()
        frmSelectTank.ShowDialog()
    End Sub
    Function saverec() As Boolean
        Call konneksyon()
        If txtRefilledby.Text = "" Then
            txtRefilledby.Focus()
        ElseIf txtprice.Text = "" Then
            txtprice.Focus()
        ElseIf txtqty.Text = "" Then
            txtqty.Focus()
        ElseIf cbProduct.Text = "" Then
            cbProduct.Focus()
        ElseIf txtPoNo.Text = "" Then
            txtPoNo.Focus()
        ElseIf cbUom.Text = "" Then
            cbUom.Focus()
        Else
            If RadioGroup1.SelectedIndex = 0 Then

                If txtqty.Text > Val(txtstocks.Text) Then
                    MsgBox("Insufficient Stock!", MsgBoxStyle.Exclamation, Me.Text)
                Else
                    If MsgBox("Are you sure you want to continue?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Yes Then
                        sql = "insert into tblAutoTransaction (" _
                    & "[Transaction], VehicleID, TankID, ProductID, " _
                    & "Added_at, Added_by, PoNo, Refilled_by, Price, StockOut, UomID, SelectStock) values (" _
                    & "'OUTGOING', '" & lblVehicleID.Text & "','" & lblTankID.Text & "'," _
                    & "'" & lblProductID.Text & "',GetDate(), '" & frmMain.lblid.Caption & "'," _
                    & "'" & txtPoNo.Text & "','" & txtRefilledby.Text & "', '" & txtprice.Text & "','" & txtqty.Text & "', " _
                    & "(select ID from tblUomCode where UomCode='" & cbUom.Text & "'),'" & RadioGroup1.SelectedIndex & "')"
                        Call save(sql)
                        sql = "insert into tblTankInventory (" _
                 & "Date, [Transaction], TankID, ProductID, VehicleID, StockIn, StockOut) values (" _
                 & "GetDate(), 'OUTGOING','" & lblTankID.Text & "','" & lblProductID.Text & "'," _
                 & "'" & lblVehicleID.Text & "',0,'" & txtqty.Text & "')"
                        Call save(sql)

                        MsgBox("Added successfully!", MsgBoxStyle.Information, Me.Text)
                        Call xclear()
                        frmMain.AutoTransaction.populateAuto()
                        Me.Close()
                    End If
                End If
            Else
                If MsgBox("Are you sure you want to continue?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Yes Then
                    sql = "insert into tblAutoTransaction (" _
                & "[Transaction], VehicleID, TankID, ProductID, " _
                & "Added_at, Added_by, PoNo, Refilled_by, Price, StockOut, UomID, SelectStock) values (" _
                & "'OUTGOING', '" & lblVehicleID.Text & "','" & lblTankID.Text & "'," _
                & "'" & lblProductID.Text & "',GetDate(), '" & frmMain.lblid.Caption & "'," _
                & "'" & txtPoNo.Text & "','" & txtRefilledby.Text & "', '" & txtprice.Text & "','" & txtqty.Text & "', " _
                & "(select ID from tblUomCode where UomCode='" & cbUom.Text & "'),'" & RadioGroup1.SelectedIndex & "')"
                    Call save(sql)
                    sql = "insert into tblTankInventory (" _
             & "Date, [Transaction], TankID, ProductID, VehicleID, StockIn, StockOut) values (" _
             & "GetDate(), 'OUTGOING','" & lblTankID.Text & "','" & lblProductID.Text & "'," _
             & "'" & lblVehicleID.Text & "',0,'" & txtqty.Text & "')"
                    Call save(sql)

                    MsgBox("Added successfully!", MsgBoxStyle.Information, Me.Text)
                    Call xclear()
                    frmMain.AutoTransaction.populateAuto()
                    Me.Close()
                End If
            End If
        End If
            Return True
    End Function

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If Me.Text = "Auto Refuelling - Stock Out" Then
            Call saverec()
        ElseIf Me.Text = "Auto Refuelling - Edit Stock Out" Then

        End If
    End Sub

    Private Sub lblMake_Click(sender As Object, e As EventArgs) Handles lblMake.Click

    End Sub

    Private Sub PictureEdit1_Click(sender As Object, e As EventArgs) Handles PictureEdit1.Click
        frmSelectVehicle.txtsearch.Select()
        frmSelectVehicle.ShowDialog()
    End Sub
End Class