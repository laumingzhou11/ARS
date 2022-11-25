Public Class frmAutoRefuelling
    Private Sub btnadd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnadd.ItemClick
        frmAddEditAutoRefuelling.txtcode.Select()
        frmAddEditAutoRefuelling.Text = "Auto Refuelling - Stock Out"
        frmAddEditAutoRefuelling.StartPosition = FormStartPosition.CenterScreen
        frmAddEditAutoRefuelling.Height = 97
        frmAddEditAutoRefuelling.rg()
        frmAddEditAutoRefuelling.xclear()
        frmAddEditAutoRefuelling.ShowDialog()
    End Sub
End Class