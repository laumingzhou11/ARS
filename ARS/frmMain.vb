Imports System.Data.SqlClient
Public Class frmMain
    Public product As New frmProducts
    Public supplier As New frmSuppliers
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
End Class