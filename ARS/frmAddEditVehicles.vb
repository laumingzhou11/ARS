﻿Imports System.Data.SqlClient
Public Class frmAddEditVehicles
    Private Sub txtcarmodel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcarmodel.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If txtcarmodel.Text = "" Then
                txtcarmodel.Focus()
            Else
                With txtcarmake
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If

    End Sub
    Private Sub txtcarmake_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcarmake.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If txtcarmodel.Text = "" Then
                txtcarmodel.Focus()
            Else
                With txtplateNo
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If

    End Sub
    Private Sub txtplateNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtplateNo.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If txtplateNo.Text = "" Then
                txtplateNo.Focus()
            Else
                With txtCrNo
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If

    End Sub
    Private Sub txtCrNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCrNo.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If txtCrNo.Text = "" Then
                txtCrNo.Focus()
            Else
                With txtOwner
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If

    End Sub
    Private Sub txtOwner_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOwner.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If txtOwner.Text = "" Then
                txtOwner.Focus()
            Else
                With txtDriver
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If

    End Sub
    Private Sub txtDriver_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDriver.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If txtDriver.Text = "" Then
                txtDriver.Focus()
            Else
                With cbstatus
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If

    End Sub
    Private Sub cbstatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbstatus.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If cbstatus.Text = "" Then
                cbstatus.Focus()
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
        If Not (Asc(e.KeyChar)) = 8 Then
            Dim allowchar As String = "1234567890."
            If allowchar.IndexOf(e.KeyChar) = -1 Then
                MsgBox("Number only!", MsgBoxStyle.Critical, "Capacity Input..")
                e.Handled = True
            End If
        End If
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
                With btnsave
                    .Focus()
                End With
            End If
        End If

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If Me.Text = "Add Vehicle" Then
            Call saverec()
        ElseIf Me.Text = "Edit Vehicle" Then
            Call updaterec()
        End If
    End Sub
    Function xclear() As Boolean
        txtcarmodel.Text = ""
        txtcarmake.Text = ""
        txtplateNo.Text = ""
        txtCrNo.Text = ""
        txtOwner.Text = ""
        txtDriver.Text = ""
        cbstatus.Text = ""
        txtCapacity.Text = ""
        cbUomCode.Text = ""
        Return True
    End Function
    Function saverec() As Boolean
        Call konneksyon()
        If txtcarmodel.Text = "" Then
            txtcarmodel.Focus()
        ElseIf txtcarmodel.Text = "" Then
            txtcarmodel.Focus()
        ElseIf txtplateNo.Text = "" Then
            txtplateNo.Focus()
        ElseIf txtCrNo.Text = "" Then
            txtCrNo.Focus()
        ElseIf txtOwner.Text = "" Then
            txtOwner.Focus()
        ElseIf txtDriver.Text = "" Then
            txtDriver.Focus()
        ElseIf cbstatus.Text = "" Then
            cbstatus.Focus()
        ElseIf txtCapacity.Text = "" Then
            txtCapacity.Focus()
        ElseIf cbUomCode.Text = "" Then
            cbUomCode.Focus()
        Else
            sql = "select * from tblvehicles where Model='" & txtcarmodel.Text & "'"
            Call fill(sql)
            If dset.Tables(sql).Rows.Count > 0 Then
                MsgBox("Model Already Exist!", MsgBoxStyle.Exclamation, Me.Text)
            Else
                sql = "insert into tblvehicles (" _
                    & "Model, Make, PlateNo, CrNo, " _
                    & "RegisteredOwner, Driver, Status, " _
                    & "TankCapacity, UomID, Added_at, Added_by) values (" _
                    & "'" & txtcarmodel.Text & "','" & txtcarmake.Text & "','" & txtplateNo.Text & "'," _
                    & "'" & txtCrNo.Text & "','" & txtOwner.Text & "','" & txtDriver.Text & "'," _
                    & "'" & cbstatus.Text & "','" & txtCapacity.Text & "',(select ID from tblUomCode where UomCode='" & cbUomCode.Text & "'), " _
                    & "Getdate(),'" & frmMain.lblid.Caption & "')"
                Call save(sql)
                MsgBox("Added Successfully!", MsgBoxStyle.Information, Me.Text)
                Call xclear()
                frmMain.vehicle.populateVehicle()
                Me.Close()
            End If
        End If
        Return True
    End Function
    Function updaterec() As Boolean
        Call konneksyon()
        If txtcarmodel.Text = "" Then
            txtcarmodel.Focus()
        ElseIf txtcarmodel.Text = "" Then
            txtcarmodel.Focus()
        ElseIf txtplateNo.Text = "" Then
            txtplateNo.Focus()
        ElseIf txtCrNo.Text = "" Then
            txtCrNo.Focus()
        ElseIf txtOwner.Text = "" Then
            txtOwner.Focus()
        ElseIf txtDriver.Text = "" Then
            txtDriver.Focus()
        ElseIf cbstatus.Text = "" Then
            cbstatus.Focus()
        ElseIf txtCapacity.Text = "" Then
            txtCapacity.Focus()
        ElseIf cbUomCode.Text = "" Then
            cbUomCode.Focus()
        Else
            sql = "update tblvehicles set " _
                    & "Model='" & txtcarmodel.Text & "', Make='" & txtcarmake.Text & "', PlateNo='" & txtplateNo.Text & "', " _
                    & "CrNo='" & txtCrNo.Text & "', " _
                    & "RegisteredOwner='" & txtOwner.Text & "', Driver='" & txtDriver.Text & "', Status='" & cbstatus.Text & "', " _
                    & "TankCapacity='" & txtCapacity.Text & "', UomID=(select ID from tblUomCode where UomCode='" & cbUomCode.Text & "'), " _
                    & "Added_at=Getdate(), Added_by'" & frmMain.lblid.Caption & "' where VehicleID='" & txtvehicleID.Text & "'"
            Call save(sql)
            MsgBox("Edit Successfully!", MsgBoxStyle.Information, Me.Text)
            Call xclear()
            frmMain.vehicle.populateVehicle()
            Me.Close()
        End If
        Return True
    End Function
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
    Private Sub frmAddEditVehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Uom()
    End Sub
End Class