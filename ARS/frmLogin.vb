Public Class frmLogin
    Function checkLogIn() As Boolean

        If gcLogin.Text = "Login to your Account" Then
            Call konneksyon()
            sql = "select * from tblEmpusers where UserName ='" & txtuser.Text & "' and convert(Varchar,Password)='" & txtpw.Text & "'"
            Call fill(sql)
            If dset.Tables(sql).Rows.Count = 0 Then
                MsgBox("Access Denied! Wrong Username,Password!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            ElseIf dset.Tables(sql).Rows.Count <> 0 And dset.Tables(sql).Rows(0).Item("Status") = "ACTIVE" Then

                frmMain.lbluser.Caption = dset.Tables(sql).Rows(0).Item("name")
                frmMain.lblacctType.Caption = dset.Tables(sql).Rows(0).Item("AccountType")
                frmMain.lblid.Caption = dset.Tables(sql).Rows(0).Item("EmpID")
                SplashScreenManager2.ShowWaitForm()
                Threading.Thread.Sleep(1500)
                SplashScreenManager2.CloseWaitForm()
                lblcount.Text = 1
                frmMain.Show()
                frmMain.RibbonControl.Visible = True
                frmMain.RibbonStatusBar1.Visible = True
                Me.Close()
            End If
        End If
        Return True
    End Function
    Private Sub cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        Call checkLogIn()
    End Sub

    'Private Sub HyperlinkLabelControl3_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl3.Click
    '    frmaddeditaccount.lblaccount.Text = "login"
    '    frmaddeditaccount.txtname.Select()
    '    frmaddeditaccount.cbacctype.Text = "USER"
    '    frmaddeditaccount.cbacctype.Enabled = False
    '    frmaddeditaccount.cbstatus.Enabled = False
    '    frmaddeditaccount.cbstatus.Text = "ACTIVE"
    '    frmaddeditaccount.ShowDialog()
    'End Sub
    Private Sub frmlogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If gcLogin.Text = "Login to your Account" Then
                If Val(lblcount.Text) = 1 Then
                ElseIf Val(lblcount.Text) = 2 Then
                Else
                    If MsgBox("Are you sure you want to close?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Yes Then
                        frmMain.Close()
                        Me.Close()
                    Else
                        e.Cancel = True
                    End If
                End If
                'ElseIf GcLogin.Text = "Log-In" Then
                '    If Val(lblcount.Text) = 1 Then
                '    ElseIf Val(lblcount.Text) = 2 Then
                '        If MsgBox("Are you sure you want to close?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Yes Then
                '            frmMain.Close()
                '            Me.Close()
                '        Else
                '            e.Cancel = True
                '        End If
                '    Else

                '    End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtuser_Enter(sender As Object, e As EventArgs) Handles txtuser.Enter
        If txtuser.Text = "TYPE YOUR USERNAME" Then
            txtuser.Text = ""
            txtuser.ForeColor = Color.Black
        End If
        txtuser.BackColor = Color.LightBlue
    End Sub

    Private Sub txtuser_Leave(sender As Object, e As EventArgs) Handles txtuser.Leave
        If txtuser.Text = "" Then
            txtuser.Text = "TYPE YOUR USERNAME"
            txtuser.ForeColor = Color.Gray
        End If
        txtuser.BackColor = Color.White
    End Sub
    Private Sub txtpw_Enter(sender As Object, e As EventArgs) Handles txtpw.Enter
        If txtpw.Text = "TYPE YOUR PASSWORD" Then
            txtpw.Text = ""
            txtpw.ForeColor = Color.Black
            txtpw.Properties.PasswordChar = "*"
        End If
        txtpw.BackColor = Color.LightBlue
    End Sub

    Private Sub txtpw_Leave(sender As Object, e As EventArgs) Handles txtpw.Leave
        If txtpw.Text = "" Then
            txtpw.Text = "TYPE YOUR PASSWORD"
            txtpw.ForeColor = Color.Gray
            txtpw.Properties.PasswordChar = ""
        End If
        txtpw.BackColor = Color.White
    End Sub
    Private Sub txtuser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtuser.KeyPress
        If Not (Asc(e.KeyChar)) = 8 Then
            Dim allowchar As String = "QWERTYUIOPLKJHGFDSAZXCVBNMqwertyuioplkjhgfdsazxcvbnm1234567890-@. "
            If allowchar.IndexOf(e.KeyChar) = -1 Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = Chr(13) Then
            Call checkLogIn()
        End If
    End Sub

    Private Sub txtpw_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpw.KeyPress

        If Not (Asc(e.KeyChar)) = 8 Then
            Dim allowchar As String = "QWERTYUIOPLKJHGFDSAZXCVBNMqwertyuioplkjhgfdsazxcvbnm1234567890-@. "
            If allowchar.IndexOf(e.KeyChar) = -1 Then
                e.Handled = True
            End If
        End If
        If e.KeyChar = Chr(13) Then
            Call checkLogIn()
        End If
    End Sub

    Private Sub PictureEdit1_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles PictureEdit2.EditValueChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        lblcount.Text = 2
        frmconnection.lblConnection.Text = "login"
        frmconnection.txtserver.Text = My.Settings.Server
        frmconnection.txtUserName.Text = My.Settings.User
        frmconnection.txtPassword.Text = My.Settings.Password
        frmconnection.txtdbase.Text = My.Settings.Dbase
        frmconnection.ShowDialog()
    End Sub

    Private Sub HyperlinkLabelControl3_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl3.Click
        frmAddEditAccount.lblaccount.Text = "login"
        frmAddEditAccount.txtname.Select()
        frmAddEditAccount.cbacctype.Text = "USER"
        frmAddEditAccount.cbacctype.Enabled = False
        frmAddEditAccount.cbstatus.Enabled = False
        frmAddEditAccount.cbstatus.Text = "ACTIVE"
        frmAddEditAccount.ShowDialog()
    End Sub
End Class