Imports System.Data.SqlClient
Public Class frmAddEditProducts
    Private Sub frmAddEditProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Supplier()
        Call Uom()
    End Sub
    Function Supplier() As Boolean
        cbSupplier.Properties.Items.Clear()
        Dim comm = New SqlCommand("select * from tblSupplier", kon)
        Dim dset = New DataSet
        dset.Load(comm.ExecuteReader, LoadOption.OverwriteChanges, "sup")
        For x As Integer = 0 To dset.Tables("sup").Rows.Count - 1
            cbSupplier.Properties.Items.Add(dset.Tables("sup").Rows(x).ItemArray(1).ToString)
        Next
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
    Function xclear() As Boolean
        txtProductID.Text = ""
        txtDescription.Text = ""
        txtPrice.Text = ""
        cbSupplier.Text = ""
        cbUom.Text = ""
        Return True
    End Function
    Private Sub txtDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescription.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtDescription.Text = "" Then
                txtDescription.Focus()
            Else
                With cbSupplier
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub cbSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbSupplier.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If cbSupplier.Text = "" Then
                cbSupplier.Focus()
            Else
                With cbSupplier
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtPrice.Text = "" Then
                txtPrice.Focus()
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
                With btnsave
                    .Focus()
                End With
            End If
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If Me.Text = "Add Product" Then
            Call saverec()
        ElseIf Me.Text = "Edit Product" Then
            Call updaterec()
        End If
    End Sub
    Function saverec() As Boolean
        Call konneksyon()
        If txtDescription.Text = "" Then
            txtDescription.Focus()
        ElseIf cbSupplier.Text = "" Then
            cbSupplier.Focus()
        ElseIf txtPrice.Text = "" Then
            txtPrice.Focus()
        ElseIf cbUom.Text = "" Then
            cbUom.Focus()
        Else
            If MsgBox("Are you sure you want to add?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Yes Then
                sql = "insert into tblProducts (" _
            & "ItemDescription, SupplierID,Price, Added_at, Added_by, UomID) values ( " _
            & "'" & txtDescription.Text & "', " _
            & "(select ID from tblSupplier where SupplierName='" & cbSupplier.Text & "'),'" & txtPrice.Text & "',GetDate(),'" & frmMain.lblid.Caption & "'," _
            & "(select ID from tblUomCode where UomCode='" & cbUom.Text & "'))"
                Call save(sql)
                Call xclear()
                MsgBox("Added successfully!", MsgBoxStyle.Information, Me.Text)
                frmMain.product.populateProducts()
                Me.Close()
            End If
        End If
        Return True
    End Function
    Function updaterec() As Boolean
        Call konneksyon()
        If txtDescription.Text = "" Then
            txtDescription.Focus()
        ElseIf cbSupplier.Text = "" Then
            cbSupplier.Focus()
        ElseIf txtPrice.Text = "" Then
            txtPrice.Focus()
        ElseIf cbUom.Text = "" Then
            cbUom.Focus()
        Else
            If MsgBox("Are you sure you want to edit?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Yes Then
                sql = "update tblProducts set " _
            & "ItemDescription='" & txtDescription.Text & "',SupplierID=(select SupplierID from tblSupplier where SupplierName='" & cbSupplier.Text & "'), " _
            & "Price='" & txtPrice.Text & "', Updated_at=GetDate(), Updated_by='" & frmMain.lblid.Caption & "', " _
            & "UomID=(select ID from tblUomCode where UomCode='" & cbUom.Text & "') where ProductID='" & txtProductID.Text & "'"
                Call save(sql)
                Call xclear()
                MsgBox("Edit successfully!", MsgBoxStyle.Information, Me.Text)
                frmMain.product.populateProducts()
                Me.Close()
            End If
        End If
        Return True
    End Function

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub
End Class