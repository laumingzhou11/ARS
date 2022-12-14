Imports System.Data.SqlClient
Imports System.Threading

Public Class frmMain
    Public product As New frmProducts
    Public supplier As New frmSuppliers
    Public tank As New frmTanks
    Public vehicle As New frmVehicles
    Public TankTransaction As New frmTankRefuelling
    Public AutoTransaction As New frmAutoRefuelling
    Public Inventory As New frmInventory
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Server = Nothing Or My.Settings.User = Nothing Or My.Settings.Password = Nothing _
          Or My.Settings.dbase = Nothing Then
            frmconnection.ShowDialog()
        ElseIf My.Settings.Server <> Nothing Or My.Settings.User <> Nothing Or My.Settings.Password <> Nothing _
            Or My.Settings.Dbase <> Nothing Then
            frmLogin.txtuser.Select()
            frmLogin.ShowDialog()
        End If

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



    Private Sub btnAutoTransactions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAutoTransactions.ItemClick
        AutoTransaction = New frmAutoRefuelling
        Try

            If Application.OpenForms.OfType(Of frmAutoRefuelling).Any Then
                Application.OpenForms.Item("frmAutoRefuelling").Activate()
            Else
                AutoTransaction.MdiParent = Me
                AutoTransaction.TopMost = True
                AutoTransaction.WindowState = FormWindowState.Maximized
                AutoTransaction.Show()
                AutoTransaction.txtsearch.Focus()
            End If
        Catch eX As Exception
            MessageBox.Show(eX.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Inventory = New frmInventory
        Try

            If Application.OpenForms.OfType(Of frmInventory).Any Then
                Application.OpenForms.Item("frmInventory").Activate()
            Else
                Inventory.MdiParent = Me
                Inventory.TopMost = True
                Inventory.WindowState = FormWindowState.Maximized
                Inventory.Show()
            End If
        Catch eX As Exception
            MessageBox.Show(eX.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        frmTankReport.cbTank.Text = ""
        frmTankReport.dtpfrom.Text = ""
        frmTankReport.dtpto.Text = ""
        frmTankReport.ShowDialog()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        frmAutoReport.cbAuto.Text = ""
        frmAutoReport.dtpfrom.Text = ""
        frmAutoReport.dtpto.Text = ""
        frmAutoReport.ShowDialog()
    End Sub

    Private Sub btnpositions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnpositions.ItemClick
        frmPosition.txtposition.Select()
        frmPosition.ShowDialog()
    End Sub



    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        frmconnection.lblConnection.Text = "main"
        frmconnection.txtserver.Select()
        frmconnection.txtserver.Text = My.Settings.Server
        frmconnection.txtUserName.Text = My.Settings.User
        frmconnection.txtPassword.Text = My.Settings.Password
        frmconnection.txtdbase.Text = My.Settings.Dbase
        frmconnection.ShowDialog()
    End Sub
End Class