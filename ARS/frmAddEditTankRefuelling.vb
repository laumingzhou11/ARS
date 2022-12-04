Imports System.Data.SqlClient
Public Class frmAddEditTankRefuelling


    Private Sub txtPoNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPoNo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtPoNo.Text = "" Then
                txtPoNo.Focus()
            Else
                With btnSelectProduct
                    .Focus()
                End With
            End If
        End If
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
                With txtreceived
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub txtreceived_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtreceived.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtreceived.Text = "" Then
                txtreceived.Focus()
            Else
                With cbDeliveredby
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub cbDeliveredby_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbDeliveredby.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If cbDeliveredby.Text = "" Then
                cbDeliveredby.Focus()
            Else
                With btnsave
                    .Focus()
                End With
            End If
        End If
    End Sub
    Function xclear() As Boolean
        txtTankName.Text = ""
        lbltankID.Text = ""
        lblTransID.Text = ""
        lblSupplierID.Text = ""
        lblProductID.Text = ""
        lblSupplierID.Text = ""
        txtCapacity.Text = ""
        cbUomCode.Text = ""
        txtlocation.Text = ""
        txtstocks.Text = ""
        dtpDate.Text = ""
        txtPoNo.Text = ""
        txtproduct.Text = ""
        txtsupplier.Text = ""
        txtqty.Text = ""
        cbUom.Text = ""
        txtprice.Text = ""
        txtTotalAmount.Text = ""
        txtreceived.Text = ""
        dgTankTransaction.DataSource = Nothing
        cbDeliveredby.Text = ""
        Return True
    End Function
    Private Sub frmAddEditTankRefuelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Uom()
        Call vehicle()
    End Sub

    Private Sub btnSelectProduct_Click(sender As Object, e As EventArgs) Handles btnSelectProduct.Click
        frmSelectProduct.txtsearch.Select()
        frmSelectProduct.ShowDialog()
    End Sub

    Private Sub btnSelectTank_Click(sender As Object, e As EventArgs) Handles btnSelectTank.Click
        frmSelectTank.lblSelectTank.Text = "Tank"
        frmSelectTank.txtsearch.Select()
        frmSelectTank.ShowDialog()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub txtqty_EditValueChanged(sender As Object, e As EventArgs) Handles txtqty.EditValueChanged
        Dim price As Double = Val(txtprice.Text)
        Dim qty As Double = Val(txtqty.Text)
        Dim totalAmount = qty * price
        txtTotalAmount.Text = FormatNumber(totalAmount, 2)
    End Sub
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
    Function vehicle() As Boolean
        cbDeliveredby.Properties.Items.Clear()
        Dim comm = New SqlCommand("select * from tblVehicles", kon)
        Dim dset = New DataSet
        dset.Load(comm.ExecuteReader, LoadOption.OverwriteChanges, "uom")
        For x As Integer = 0 To dset.Tables("uom").Rows.Count - 1
            cbDeliveredby.Properties.Items.Add(dset.Tables("uom").Rows(x).ItemArray(19).ToString)
        Next
        Return True
    End Function

    Private Sub txtprice_EditValueChanged(sender As Object, e As EventArgs) Handles txtprice.EditValueChanged
        Dim price As Double = Val(txtprice.Text)
        Dim qty As Double = Val(txtqty.Text)
        Dim totalAmount = qty * price
        txtTotalAmount.Text = FormatNumber(totalAmount, 2)
    End Sub
    Function PopulateHistory() As Boolean
        Call konneksyon()
        sql = "select a.TankTransactionID as TransNo,format(a.Added_at,'MM/dd/yyyy hh:mm tt') as Added_at,a.PurchaseOrder as Po#," _
                & "format(a.StockIn,'#,#.##') as Qty, e.UomCode, format(a.Price,'c', 'fil-PH') as Price," _
              & "b.ItemDescription as Product,b1.SupplierName as Supplier,a.Receivedby,d.Name as Deliveredby " _
              & " from tblTankTransaction as a " _
              & "inner join tblProducts as b on a.ProductID=b.ProductID " _
              & "inner join tblsupplier as b1 on b.SupplierID=b1.SupplierID " _
              & "inner join tbltank as c on a.TankID=c.TankID " _
              & "inner join tblvehicles as d on a.VehicleID=d.VehicleID " _
                & "inner join tblUomcode as e on a.UomID=e.ID where a.TankID='" & lbltankID.Text & "' and a.Deleted_at is null order by a.TankTransactionID desc"
        Call populate(sql, dgTankTransaction)
        If dset.Tables(sql).Rows.Count > 0 Then
            gvTankTransaction.BestFitColumns()
            gvTankTransaction.RowHeight = 20

        Else
            gvTankTransaction.Columns("TransNo").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            gvTankTransaction.Columns("TransNo").SummaryItem.DisplayFormat = "{0:n0}" & " Record(s) Found"
        End If

        Return True
    End Function

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If Me.Text = "Tank Refuelling - Stock IN" Then
            Call saverec()
        ElseIf Me.Text = "Tank Refuelling - Edit Stock IN" Then
            Call Updaterec
        End If
    End Sub
    Function saverec() As Boolean
        Call konneksyon()
        If txtPoNo.Text = "" Then
            txtPoNo.Focus()
        ElseIf cbUom.Text = "" Then
            cbUom.Focus()
        ElseIf txtprice.Text = "" Then
            txtprice.Focus()
        ElseIf txtreceived.Text = "" Then
            txtreceived.Focus()
        ElseIf cbDeliveredby.Text = "" Then
            cbDeliveredby.Focus()
        Else
            sql = "select * from tblTankInventory where TankID='" & lbltankID.Text & "'"
            Call fill(sql)
            If dset.Tables(sql).Rows.Count > 0 Then
                If Val(txtstocks.Text) = 0 Then
                    MsgBox("Tank is Full!", MsgBoxStyle.Exclamation, Me.Text)
                Else
                    If txtqty.Text > Val(txtstocks.Text) Then
                        MsgBox("Insufficient Stock!", MsgBoxStyle.Exclamation, Me.Text)
                    Else

                        If MsgBox("Are you sure you want to add Fuel Stocks?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Yes Then
                            sql = "insert into tblTankTransaction (" _
                            & "TankID, StockIn, ProductID, PurchaseOrder, Added_at, " _
                            & "Added_by,Receivedby,VehicleID, UomID, Price) values (" _
                            & "'" & lbltankID.Text & "','" & txtqty.Text & "', '" & lblProductID.Text & "', " _
                            & "'" & txtPoNo.Text & "',getDate(),'" & frmMain.lblid.Caption & "','" & txtreceived.Text & "',(select VehicleID from tblVehicles where Name='" & cbDeliveredby.Text & "'), " _
                            & "(select ID from tblUomCode where UomCode='" & cbUom.Text & "'),'" & txtprice.Text & "')"
                            Call save(sql)

                            sql2 = "insert into tblTankInventory (" _
                                    & "Date, [Transaction], TankID, ProductID, VehicleID, StockIn, StockOut) values (" _
                                    & "GetDate(), 'INCOMING','" & lbltankID.Text & "','" & lblProductID.Text & "'," _
                                    & "(select VehicleID from tblVehicles where Name='" & cbDeliveredby.Text & "'),'" & txtqty.Text & "',0)"
                            Call save(sql2)

                            MsgBox("Added successfully!", MsgBoxStyle.Information, Me.Text)
                            Call xclear()
                            frmMain.TankTransaction.populateTransaction()
                            Me.Close()
                        End If
                    End If
                End If
            Else
                If txtqty.Text > Val(txtstocks.Text) Then
                    MsgBox("Insufficient Stock!", MsgBoxStyle.Exclamation, Me.Text)
                Else
                    If MsgBox("Are you sure you want to add Fuel Stocks?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Yes Then
                        sql = "insert into tblTankTransaction (" _
                                & "TankID, StockIn, ProductID, PurchaseOrder, Added_at, " _
                                & "Added_by,Receivedby,VehicleID, UomID, Price) values (" _
                                & "'" & lbltankID.Text & "','" & txtqty.Text & "', '" & lblProductID.Text & "', " _
                                & "'" & txtPoNo.Text & "',getDate(),'" & frmMain.lblid.Caption & "','" & txtreceived.Text & "',(select VehicleID from tblVehicles where Name='" & cbDeliveredby.Text & "'), " _
                                & "(select ID from tblUomCode where UomCode='" & cbUom.Text & "'),'" & txtprice.Text & "')"
                        Call save(sql)

                        sql2 = "insert into tblTankInventory (" _
                                    & "Date, [Transaction], TankID, ProductID, VehicleID, StockIn, StockOut) values (" _
                                    & "GetDate(), 'INCOMING','" & lbltankID.Text & "','" & lblProductID.Text & "'," _
                                    & "(select VehicleID from tblVehicles where Name='" & cbDeliveredby.Text & "'),'" & txtqty.Text & "',0)"
                        Call save(sql2)

                        MsgBox("Added successfully!", MsgBoxStyle.Information, Me.Text)
                        Call xclear()
                        frmMain.TankTransaction.populateTransaction()
                        Me.Close()
                    End If
                End If
            End If
        End If
            Return True
    End Function
    Function Updaterec() As Boolean
        Call konneksyon()
        If txtPoNo.Text = "" Then
            txtPoNo.Focus()
        ElseIf cbUom.Text = "" Then
            cbUom.Focus()
        ElseIf txtprice.Text = "" Then
            txtprice.Focus()
        ElseIf txtreceived.Text = "" Then
            txtreceived.Focus()
        ElseIf cbDeliveredby.Text = "" Then
            cbDeliveredby.Focus()
        Else
            If MsgBox("Are you sure you want to edit Fuel Stock-in?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Yes Then
                sql = "update tblTankTransaction set " _
            & "PurchaseOrder='" & txtPoNo.Text & "', Updated_at=getDate(), " _
            & "Updated_by='" & frmMain.lblid.Caption & "',Receivedby='" & txtreceived.Text & "', " _
            & "UomID=(select ID from tblUomCode where UomCode='" & cbUom.Text & "'), " _
            & "Price='" & txtprice.Text & "',ProductID='" & lblProductID.Text & "' where TankTransactionID='" & lblTransID.Text & "'"
                Call save(sql)

                sql = "update tblTankInventory set ProductID='" & lblProductID.Text & "'," _
                        & "VehicleID=(select VehicleID from tblVehicles where Name='" & cbDeliveredby.Text & "') where " _
                        & "TankID=(select TankID from tblTankTransaction where TankTransactionID='" & lbltankID.Text & "') and " _
                        & "Date=(select Date from tblTankTransaction where TankTransactionID='" & lbltankID.Text & "') and [Transaction]='INCOMING'"
                Call save(sql)
                MsgBox("Edit successfully!", MsgBoxStyle.Information, Me.Text)
                Call xclear()
                frmMain.TankTransaction.populateTransaction()
                Me.Close()
            End If
        End If
        Return True
    End Function
End Class
