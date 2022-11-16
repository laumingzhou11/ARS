Imports System.Data.SqlClient
Public Class frmAddEditTank
    Private Sub frmAddEditTank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Uom()
    End Sub
    Function Uom() As Boolean
        cbUomCode.Properties.Items.Clear()
        Dim comm = New SqlCommand("select * from tblUomCode", kon)
        Dim dset = New DataSet
        dset.Load(comm.ExecuteReader, LoadOption.OverwriteChanges, "uom")
        For x As Integer = 0 To dset.Tables("uom").Rows.Count - 1
            cbUomCode.Properties.Items.Add(dset.Tables("uom").Rows(x).ItemArray(1).ToString)
        Next
        Return True
    End Function
    Private Sub txtTankName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTankName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtTankName.Text = "" Then
                txtTankName.Focus()
            Else
                With txtCapacity
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub txtCapacity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCapacity.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtCapacity.Text = "" Then
                txtCapacity.Focus()
            Else
                With cbUomCode
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub cbUomCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbUomCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If cbUomCode.Text = "" Then
                cbUomCode.Focus()
            Else
                With txtLocation
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub txtLocation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLocation.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtLocation.Text = "" Then
                txtLocation.Focus()
            Else
                With btnsave
                    .Focus()
                End With
            End If
        End If
    End Sub
    Function xclear() As Boolean
        txtTankID.Text = ""
        txtTankName.Text = ""
        txtCapacity.Text = ""
        cbUomCode.Text = ""
        txtLocation.Text = ""
        Return True
    End Function
    Function saverec() As Boolean
        Call konneksyon()
        If txtLocation.Text = "" Then
            txtLocation.Focus()
        ElseIf txtCapacity.Text = "" Then
            txtCapacity.Focus()
        ElseIf txtTankName.Text = "" Then
            txtTankName.Focus()
        ElseIf cbUomCode.Text = "" Then
            cbUomCode.Focus()
        Else
            sql = "select * from tbltank where TankName='" & txtTankName.Text & "'"
            Call fill(sql)
            If dset.Tables(sql).Rows.Count > 0 Then
                MsgBox("Tank Name Already Exist!", MsgBoxStyle.Exclamation, "Add Tank")
            Else
                If MsgBox("Are you sure you want to add?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Yes Then
                    sql = "insert into tblTank (" _
                        & "TankName, TankCapacity, UomID, Location, Added_at, Added_by) values (" _
                        & "'" & txtTankName.Text & "','" & txtCapacity.Text & "',(select ID from tblUomCode where UomCode='" & cbUomCode.Text & "'), " _
                        & "'" & txtLocation.Text & "',Getdate(),'" & frmMain.lblid.Caption & "')"
                    Call save(sql)

                    MsgBox("Added Successfully!", MsgBoxStyle.Information, "Add Tank")
                    Call xclear()
                    frmMain.tank.populateTank()
                    Me.Close()
                End If
            End If

        End If
        Return True
    End Function
    Function updaterec() As Boolean
        Call konneksyon()
        If txtLocation.Text = "" Then
            txtLocation.Focus()
        ElseIf txtCapacity.Text = "" Then
            txtCapacity.Focus()
        ElseIf txtTankName.Text = "" Then
            txtTankName.Focus()
        ElseIf cbUomCode.Text = "" Then
            cbUomCode.Focus()
        Else
            If MsgBox("Are you sure you want to edit?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Yes Then
                sql = "update tblTank  set " _
                    & "TankName='" & txtTankName.Text & "', TankCapacity='" & txtCapacity.Text & "', UomID=(select ID from tblUomCode where UomCode='" & cbUomCode.Text & "'), " _
                    & "Location='" & txtLocation.Text & "', Updated_at=Getdate(), Updated_by='" & frmMain.lblid.Caption & "' where TankID='" & txtTankID.Text & "'"
                Call save(sql)

                MsgBox("Edit Successfully!", MsgBoxStyle.Information, "Edit Tank")
                Call xclear()
                frmMain.tank.populateTank()
                Me.Close()
            End If
        End If
        Return True
    End Function

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If Me.Text = "Add Tank" Then
            Call saverec()
        ElseIf Me.Text = "Edit Tank" Then
            Call updaterec()
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub
End Class