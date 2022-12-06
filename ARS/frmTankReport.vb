Imports System.Data.SqlClient
Public Class frmTankReport
    Private Sub frmTankReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tank()
    End Sub
    Function Tank() As Boolean
        Call konneksyon()
        cbTank.Properties.Items.Clear()
        Dim comm = New SqlCommand("select * from tblTank where TankID<>1", kon)
        Dim dset = New DataSet
        dset.Load(comm.ExecuteReader, LoadOption.OverwriteChanges, "tank")
        For x As Integer = 0 To dset.Tables("tank").Rows.Count - 1
            cbTank.Properties.Items.Add(dset.Tables("tank").Rows(x).ItemArray(1).ToString)
        Next
        Return True
    End Function

    Private Sub btnfilter_Click(sender As Object, e As EventArgs) Handles btnfilter.Click
        If dtpfrom.Text = "" And cbTank.Text = "" Then
            MsgBox("Please select criteria!", MsgBoxStyle.Information, Me.Text)
        Else
            frmPrint.Text = "Print Tank Transaction Report"
            frmPrint.ShowDialog()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub


End Class