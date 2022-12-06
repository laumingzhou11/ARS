Imports System.Data.SqlClient
Public Class frmAutoReport
    Function Auto() As Boolean
        Call konneksyon()
        cbAuto.Properties.Items.Clear()
        Dim comm = New SqlCommand("select Name from tblVehicles", kon)
        Dim dset = New DataSet
        dset.Load(comm.ExecuteReader, LoadOption.OverwriteChanges, "Auto")
        For x As Integer = 0 To dset.Tables("Auto").Rows.Count - 1
            cbAuto.Properties.Items.Add(dset.Tables("Auto").Rows(x).ItemArray(0).ToString)
        Next
        Return True
    End Function
    Private Sub btnfilter_Click(sender As Object, e As EventArgs) Handles btnfilter.Click
        If dtpfrom.Text = "" And cbAuto.Text = "" Then
            MsgBox("Please select criteria!", MsgBoxStyle.Information, Me.Text)
        Else
            frmPrint.Text = "Print Auto Transaction Report"
            frmPrint.ShowDialog()
        End If
    End Sub

    Private Sub xrAutoReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Auto()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class