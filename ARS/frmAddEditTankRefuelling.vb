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
        Return True
    End Function
    Private Sub frmAddEditTankRefuelling_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSelectProduct_Click(sender As Object, e As EventArgs) Handles btnSelectProduct.Click

    End Sub

    Private Sub btnSelectTank_Click(sender As Object, e As EventArgs) Handles btnSelectTank.Click
        frmSelectTank.txtsearch.Select()
        frmSelectTank.ShowDialog()
    End Sub
End Class