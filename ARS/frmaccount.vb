Imports System.Data.SqlClient
Public Class frmaccount

    Function populateacct() As Boolean
        If frmmain.lblacctType.Caption = "ADMIN" Then
            Dim da = New SqlDataAdapter("select * from tblEmpUsers where AccountType in ('ADMIN','USER') order by EmpID asc", kon)
            Dim dset = New DataSet
            da.Fill(dset, "tblEmpUsers")
            dgaccount.DataSource = dset.Tables("tblEmpUsers").DefaultView
            count.Caption = dset.Tables("tblEmpUsers").Rows.Count & " Record(s) found"
            btnedit.Caption = "Change Name or Password"
            Call formatgridacct()
        ElseIf frmMain.lblacctType.Caption = "USER" Then
            Dim da = New SqlDataAdapter("select UserID,UserName,Fullname,Department,AccountType,Status from tblEmpUsers where Fullname ='" & frmMain.lbluser.Caption & "' and AccountType='" & frmMain.lblacctType.Caption & "'", kon)
            Dim dset = New DataSet
            da.Fill(dset, "tblEmpUsers")
            dgaccount.DataSource = dset.Tables("tblEmpUsers").DefaultView
            count.Caption = dset.Tables("tblEmpUsers").Rows.Count & " Record(s) found"
            btnedit.Caption = "Change Name or Password"
        ElseIf frmMain.lblacctType.Caption = "SUPER ADMIN" Then
            Dim da = New SqlDataAdapter("select * from tblEmpUsers order by UserID asc", kon)
            Dim dset = New DataSet
            da.Fill(dset, "tblEmpUsers")
            dgaccount.DataSource = dset.Tables("tblEmpUsers").DefaultView
            count.Caption = dset.Tables("tblEmpUsers").Rows.Count & " Record(s) found"
            btnedit.Caption = "&EDIT (F2)"
            Call formatgridacct()
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
            frmaddeditaccount.Text = "Add Account"
            frmaddeditaccount.cbacctype.Enabled = True
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
            keyID = account.GetRowCellValue(account.FocusedRowHandle, "UserID").ToString
            Dim da = New SqlDataAdapter("select * from tblusers where UserID = '" & keyID & "'", kon)
            Dim dset = New DataSet
            da.Fill(dset, "tblusers")
            txtselectedcode.Text = dset.Tables("tblusers").Rows(0).Item("UserID")
        Catch eX As Exception
            MessageBox.Show(eX.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Function filltext() As Boolean
        sql = "select a.UserID,a.UserName,convert(varchar(100),DecryptByPassPhrase('LAUMINGZHOU', password)) as xpassword,a.Fullname
                                    ,a.AccountType,a.Department,a.status
                                    from tblusers as a  where a.UserID = '" & keyID & "'"
        Call fill(sql)
        txtselectedcode.Text = dset.Tables(sql).Rows(0).Item("UserID")
        ' frmnameorpassword.txtid.Text = dset.Tables(sql).Rows(0).Item("UserID")
        frmAddEditAccount.txtuser.Text = dset.Tables(sql).Rows(0).Item("UserName")
        frmaddeditaccount.txtpass.Text = dset.Tables(sql).Rows(0).Item("xpassword")

        frmaddeditaccount.txtname.Text = dset.Tables(sql).Rows(0).Item("FullName")
        frmaddeditaccount.cbacctype.Text = dset.Tables(sql).Rows(0).Item("AccountType")
        'frmaddeditaccount.cbdepartment.Text = dset.Tables(sql).Rows(0).Item("Department")
        frmAddEditAccount.cbstatus.Text = dset.Tables(sql).Rows(0).Item("Status")

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
    
    Function formatgridacct() As Boolean
        account.Columns(0).Caption = "ID"
        account.Columns(0).Width = 35
        account.Columns(0).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        account.Columns(1).Caption = "User Name"
        account.Columns(1).Width = 80
        account.Columns(1).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        account.Columns(2).Visible = False
        'account.Columns(2).Width = 80
        'account.Columns(2).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        account.Columns(3).Caption = "Name"
        account.Columns(3).Width = 150
        account.Columns(3).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        account.Columns(4).Caption = "Department"
        account.Columns(4).Width = 150
        account.Columns(4).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        account.Columns(5).Caption = "Type"
        account.Columns(5).Width = 50
        account.Columns(5).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        account.Columns(6).Visible = False
        account.Columns(7).Caption = "Status"
        account.Columns(7).Width = 50
        account.Columns(7).AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Return True
    End Function


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