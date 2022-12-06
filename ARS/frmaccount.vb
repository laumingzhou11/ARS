Imports System.Data.SqlClient
Public Class frmaccount


    Function populateacct() As Boolean
        If frmMain.lblacctType.Caption = "ADMIN" Then
            Dim da = New SqlDataAdapter("select * from tblEmpUsers where AccountType in ('ADMIN','USER') order by EmpID asc", kon)
            Dim dset = New DataSet
            da.Fill(dset, "tblEmpUsers")
            dgaccount.DataSource = dset.Tables("tblEmpUsers").DefaultView
            count.Caption = dset.Tables("tblEmpUsers").Rows.Count & " Record(s) found"
            btnedit.Caption = "Change Name or Password"
            account.BestFitColumns()
            account.RowHeight = 20
        ElseIf frmMain.lblacctType.Caption = "USER" Then
            Dim da = New SqlDataAdapter("select EmpID,UserName,Fullname,PositionID,AccountType,Status from tblEmpUsers where Fullname ='" & frmMain.lbluser.Caption & "' and AccountType='" & frmMain.lblacctType.Caption & "'", kon)
            Dim dset = New DataSet
            da.Fill(dset, "tblEmpUsers")
            dgaccount.DataSource = dset.Tables("tblEmpUsers").DefaultView
            count.Caption = dset.Tables("tblEmpUsers").Rows.Count & " Record(s) found"
            btnedit.Caption = "Change Name or Password"
        ElseIf frmMain.lblacctType.Caption = "SUPER ADMIN" Then
            Dim da = New SqlDataAdapter("select * from tblEmpUsers order by EmpID asc", kon)
            Dim dset = New DataSet
            da.Fill(dset, "tblEmpUsers")
            dgaccount.DataSource = dset.Tables("tblEmpUsers").DefaultView
            count.Caption = dset.Tables("tblEmpUsers").Rows.Count & " Record(s) found"
            btnedit.Caption = "&EDIT (F2)"
            account.BestFitColumns()
            account.RowHeight = 20
        End If
        Return True
    End Function


    Private Sub frmaccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call konneksyon()
        Call populateacct()
    End Sub

   
    Private Sub btnsave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnsave.ItemClick
        If frmmain.lblacctType.Caption = "ADMIN" Then
            MsgBox("You do not have permission to perform this task. Please call the System Super Administrator!", MsgBoxStyle.Critical, Me.Text)
        ElseIf frmmain.lblacctType.Caption = "USER" Then
            MsgBox("You do not have permission to perform this task. Please call the System Super Administrator!", MsgBoxStyle.Critical, Me.Text)

        ElseIf frmmain.lblacctType.Caption = "SUPER ADMIN" Then
            frmaddeditaccount.lblaccount.Text = "account"
            frmAddEditAccount.Text = "Add Account"
            frmAddEditAccount.txtname.Select()
            frmAddEditAccount.cbacctype.Enabled = True
            frmaddeditaccount.cbstatus.Enabled = True
            frmaddeditaccount.xclear()
            frmaddeditaccount.ShowDialog()
            frmaddeditaccount.txtname.Focus()
        End If

        
    End Sub

   

    Private Sub account_MouseUp(sender As Object, e As MouseEventArgs) Handles account.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            PopupMenu1.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Private Sub account_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles account.RowCellClick
        Try
            keyID = account.GetRowCellValue(account.FocusedRowHandle, "EmpID").ToString
            Dim da = New SqlDataAdapter("select * from tblEmpusers where EmpID = '" & keyID & "'", kon)
            Dim dset = New DataSet
            da.Fill(dset, "tblEmpusers")
            txtselectedcode.Text = dset.Tables("tblEmpusers").Rows(0).Item("EmpID")
        Catch eX As Exception
            MessageBox.Show(eX.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Function filltext() As Boolean
        sql = "select a.EmpID,a.Name,b.Position,a.AccountType, a.Username, " _
                & "CONVERT(varchar,a.Password) As xpassword,a.Status from tblempUsers As a " _
                & "inner join tblPosition as b on a.PositionID=b.ID where a.EmpID = '" & keyID & "'"
        Call fill(sql)
        txtselectedcode.Text = dset.Tables(sql).Rows(0).Item("EmpID")
        ' frmnameorpassword.txtid.Text = dset.Tables(sql).Rows(0).Item("UserID")
        frmAddEditAccount.txtuser.Text = dset.Tables(sql).Rows(0).Item("UserName")
        frmaddeditaccount.txtpass.Text = dset.Tables(sql).Rows(0).Item("xpassword")
        frmAddEditAccount.cbPosition.Text = dset.Tables(sql).Rows(0).Item("Position")
        frmAddEditAccount.txtname.Text = dset.Tables(sql).Rows(0).Item("Name")
        frmAddEditAccount.cbacctype.Text = dset.Tables(sql).Rows(0).Item("AccountType")
        frmAddEditAccount.cbstatus.Text = dset.Tables(sql).Rows(0).Item("Status")
        frmAddEditAccount.Position()
        Return True
    End Function

    Private Sub btnedit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnedit.ItemClick
        If frmmain.lblacctType.Caption = "SUPER ADMIN" Then
            If txtselectedcode.Text = "" Then
                MsgBox("Please select account to edit!", MsgBoxStyle.Information, Me.Text)
            Else
                Call filltext()
                frmaddeditaccount.txtname.Focus()
                frmaddeditaccount.Text = "Edit Account"
                frmaddeditaccount.ShowDialog()


                'txtuser.Enabled = True
                'txtpass.Enabled = True
                'cbacctype.Enabled = True
                'btnsave.Enabled = True
            End If
        ElseIf frmmain.lblacctType.Caption = "ADMIN" Then
            If frmmain.lblid.Caption = txtselectedcode.Text Then
                'frmnameorpassword.txtnewpass.Select()
                'frmnameorpassword.ShowDialog()
            Else
                MsgBox("You do not have permission to perform this task. Please call the System Super Administrator!", MsgBoxStyle.Critical, Me.Text)
            End If
        ElseIf frmmain.lblacctType.Caption = "USER" Then
            If frmmain.lblid.Caption = txtselectedcode.Text Then
                'frmnameorpassword.txtnewpass.Select()
                'frmnameorpassword.ShowDialog()
            Else
                MsgBox("You do not have permission to perform this task. Please call the System Super Administrator!", MsgBoxStyle.Critical, Me.Text)
            End If
        End If
    End Sub
    Function delrec()
        If txtselectedcode.Text <> "" Then
            If MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo + MsgBoxStyle.question, "Message!") = MsgBoxResult.Yes Then
                Dim kom = New SqlCommand
                kom.Connection = kon
                kom.CommandText = "delete from tblLogin where ID=('" & txtselectedcode.Text & "')"
                kom.ExecuteNonQuery()
                txtselectedcode.Text = ""
                Call populateacct()
            End If
        End If
        Return True
    End Function

    Private Sub btndelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btndelete.ItemClick
        If frmmain.lblacctType.Caption = "ADMIN" Or frmmain.lblacctType.Caption = "USER" Then
            MsgBox("You do not have permission to perform this task. Please call the System Super Administrator!", MsgBoxStyle.Critical, Me.Text)
        Else
            If txtselectedcode.Text = "" Then
                MsgBox("Please select record to delete!", MsgBoxStyle.Information, "message")
            Else
                Call delrec()
            End If
        End If
    End Sub




    Private Sub cmdadd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdadd.ItemClick
        'If txtselectedcode.Text = "" Then
        '    MsgBox("Please select account!", MsgBoxStyle.Information, "System Message!")
        'Else
        '    Dim da = New SqlDataAdapter("select * from tbllogin where ID='" & keyID & "'", kon)
        '    Dim dset = New DataSet
        '    da.Fill(dset, "tbllogin")

        'End If
    End Sub

    Private Sub btnclear_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnclear.ItemClick

    End Sub
End Class