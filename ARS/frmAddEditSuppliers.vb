Public Class frmAddEditSuppliers
    Private Sub frmAddEditSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtsupplierName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsupplierName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtsupplierName.Text = "" Then
                txtsupplierName.Focus()
            Else
                With txtSupplierAddress
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub txtSupplierAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSupplierAddress.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtSupplierAddress.Text = "" Then
                txtSupplierAddress.Focus()
            Else
                With txtContactPerson
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub txtContactPerson_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactPerson.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtContactPerson.Text = "" Then
                txtContactPerson.Focus()
            Else
                With txtCpNo
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub txtCpNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCpNo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtCpNo.Text = "" Then
                txtCpNo.Focus()
            Else
                With btnsave
                    .Focus()
                End With
            End If
        End If
    End Sub
    Function xclear() As Boolean
        txtsupplierID.Text = ""
        txtsupplierName.Text = ""
        txtSupplierAddress.Text = ""
        txtContactPerson.Text = ""
        txtCpNo.Text = ""
        Return True
    End Function
    Function saverec() As Boolean
        If txtsupplierName.Text = "" Then
            txtsupplierName.Focus()
        ElseIf txtCpNo.Text = "" Then
            txtCpNo.Focus()
        ElseIf txtContactPerson.Text = "" Then
            txtContactPerson.Focus()
        ElseIf txtSupplierAddress.Text = "" Then
            txtSupplierAddress.Focus()
        Else
            If MsgBox("Are you sure you want to add?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Yes Then
                sql = "insert into tblSuppliers (" _
                    & "SupplierName, Address, ContactPerson, CpNo, Added_at, Added_by) values (" _
                    & "'" & txtsupplierName.Text & "','" & txtSupplierAddress.Text & "', " _
                    & "'" & txtContactPerson.Text & "','" & txtCpNo.Text & "',Getdate(),'" & frmMain.lblid.Caption & "')"
                Call save(sql)
                Call xclear()
                MsgBox("Added Successfuly", Me.Text)
                frmMain.supplier.populateSupplier()
                Me.Close()

            End If
        End If
        Return True
    End Function
    Function updaterec() As Boolean
        If txtsupplierName.Text = "" Then
            txtsupplierName.Focus()
        ElseIf txtCpNo.Text = "" Then
            txtCpNo.Focus()
        ElseIf txtContactPerson.Text = "" Then
            txtContactPerson.Focus()
        ElseIf txtSupplierAddress.Text = "" Then
            txtSupplierAddress.Focus()
        Else
            If MsgBox("Are you sure you want to edit?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Yes Then
                sql = "update tblSuppliers set " _
                    & "SupplierName='" & txtsupplierName.Text & "', Address='" & txtSupplierAddress.Text & "', " _
                    & "ContactPerson='" & txtContactPerson.Text & "', CpNo='" & txtCpNo.Text & "', " _
                    & "Updated_by='" & frmMain.lblid.Caption & "', updated_at=Getdate() where SupplierID='" & txtsupplierID.Text & "'"
                Call save(sql)
                Call xclear()
                MsgBox("Edit Successfuly", Me.Text)
                frmMain.supplier.populateSupplier()
                Me.Close()

            End If
        End If
        Return True
    End Function

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If Me.Text = "Add Supplier" Then
            Call saverec()
        ElseIf Me.Text = "Edit Supplier" Then
            Call updaterec()
        End If
    End Sub
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub
End Class