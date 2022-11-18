Public Class frmTankRefuelling
    Private Sub btnadd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnadd.ItemClick
        frmAddEditTankRefuelling.btnSelectTank.Select()
        frmAddEditTankRefuelling.Text = "Tank Refuelling - Stock IN"
        frmAddEditTankRefuelling.xclear()
        frmAddEditTankRefuelling.ShowDialog()
    End Sub
End Class