Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base

Public Class frmPosition
    Private Sub frmPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pos()
    End Sub
    Function pos() As Boolean
        Call konneksyon()
        sql = "select * from tblPosition where ID<>1 order by ID desc"
        Call populate(sql, dgPosition)
        gvPosition.BestFitColumns()
        gvPosition.RowHeight = 20
        Return True
    End Function
    Private Sub gvPosition_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvPosition.FocusedRowChanged
        Try
            keyID = gvPosition.GetRowCellValue(gvPosition.FocusedRowHandle, "ID")
            Dim da = New SqlDataAdapter("select * from tblPosition where ID='" & keyID & "'", kon)
            Dim dset = New DataSet
            da.Fill(dset, "tblPosition")
            If dset.Tables("tblPosition").Rows.Count > 0 Then
                txtselectedcode.Text = dset.Tables("tblPosition").Rows(0).Item("ID")
            Else
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If txtselectedcode.Text <> "" Then
            Call filltext()
            GroupControl1.Text = "Edit"
        End If
    End Sub
    Function filltext() As Boolean
        Call konneksyon()
        sql = "select * from tblPosition where ID='" & keyID & "'"
        Call fill(sql)
        txtposition.Text = dset.Tables("tblPosition").Rows(0).Item("Position")
        Return True
    End Function

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If GroupControl1.Text = "Add" Then

            If txtposition.Text = "" Then
                txtposition.Focus()
            Else
                Call konneksyon()
                If MsgBox("Are you sure you want to save?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                    sql = "insert into tblPosition (Position) values ('" & txtposition.Text & "')"
                    Call save(sql)
                    txtposition.Text = ""
                    Call pos()
                End If
            End If
        Else
            Call konneksyon()
            If MsgBox("Are you sure you want to save?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                sql = "update  tblPosition set Position='" & txtposition.Text & "' where ID='" & keyID & "'"
                Call save(sql)
                txtposition.Text = ""
                Call pos()
            End If
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub txtposition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtposition.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtposition.Text = "" Then
                txtposition.Focus()
            Else
                With btnsave
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub gvPosition_MouseUp(sender As Object, e As MouseEventArgs) Handles gvPosition.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            PopupMenu1.ShowPopup(Control.MousePosition)
        End If
    End Sub
End Class