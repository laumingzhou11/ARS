Imports System.Data.SqlClient
Imports System.Threading

Public Class frmMain
    Public product As New frmProducts
    Public supplier As New frmSuppliers
    Public tank As New frmTanks
    Public vehicle As New frmVehicles
    Public TankTransaction As New frmTankRefuelling
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If My.Settings.Server = Nothing Or My.Settings.User = Nothing Or My.Settings.Password = Nothing _
        '  Or My.Settings.Dbase1 = Nothing Then
        '    frmconnection.ShowDialog()
        'ElseIf My.Settings.Server <> Nothing Or My.Settings.User <> Nothing Or My.Settings.Password <> Nothing _
        '    Or My.Settings.Dbase1 <> Nothing Then

        'End If
        ' frmLogin.txtuser.Select()
        frmLogin.ShowDialog()
    End Sub



    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        frmaccount.ShowDialog()
    End Sub

    Private Sub btnProducts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProducts.ItemClick
        product = New frmProducts
        Try

            If Application.OpenForms.OfType(Of frmProducts).Any Then
                Application.OpenForms.Item("frmProducts").Activate()
            Else
                product.MdiParent = Me
                product.TopMost = True
                product.WindowState = FormWindowState.Maximized
                product.Show()
                product.txtsearch.Focus()
            End If
        Catch eX As Exception
            MessageBox.Show(eX.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub btnSuppliers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSuppliers.ItemClick
        supplier = New frmSuppliers
        Try

            If Application.OpenForms.OfType(Of frmSuppliers).Any Then
                Application.OpenForms.Item("frmSuppliers").Activate()
            Else
                supplier.MdiParent = Me
                supplier.TopMost = True
                supplier.WindowState = FormWindowState.Maximized
                supplier.Show()
                supplier.txtsearch.Focus()
            End If
        Catch eX As Exception
            MessageBox.Show(eX.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnTanks_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTanks.ItemClick
        tank = New frmTanks
        Try

            If Application.OpenForms.OfType(Of frmTanks).Any Then
                Application.OpenForms.Item("frmTanks").Activate()
            Else
                tank.MdiParent = Me
                tank.TopMost = True
                tank.WindowState = FormWindowState.Maximized
                tank.Show()
                tank.txtsearch.Focus()
            End If
        Catch eX As Exception
            MessageBox.Show(eX.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnVehicles_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVehicles.ItemClick
        vehicle = New frmVehicles
        Try

            If Application.OpenForms.OfType(Of frmVehicles).Any Then
                Application.OpenForms.Item("frmVehicles").Activate()
            Else
                vehicle.MdiParent = Me
                vehicle.TopMost = True
                vehicle.WindowState = FormWindowState.Maximized
                vehicle.Show()
                vehicle.txtsearch.Focus()
            End If
        Catch eX As Exception
            MessageBox.Show(eX.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnTankTransactions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTankTransactions.ItemClick
        TankTransaction = New frmTankRefuelling
        Try

            If Application.OpenForms.OfType(Of frmTankRefuelling).Any Then
                Application.OpenForms.Item("frmTankRefuelling").Activate()
            Else
                TankTransaction.MdiParent = Me
                TankTransaction.TopMost = True
                TankTransaction.WindowState = FormWindowState.Maximized
                TankTransaction.Show()
                TankTransaction.txtsearch.Focus()
            End If
        Catch eX As Exception
            MessageBox.Show(eX.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick

    End Sub
End Class