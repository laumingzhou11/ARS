Public Class frmLogin
    Function checkLogIn()

        If GcLogin.Text = "Login to Your Account" Then
            Call konneksyon()
            sql = "select * from tblEmpusers where UserName ='" & txtuser.Text & "' and convert(Varchar,Password)='" & txtpw.Text & "'"
            Call fill(sql)
            If dset.Tables(sql).Rows.Count = 0 Then
                MsgBox("Access Denied! Wrong Username,Password!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            ElseIf dset.Tables(sql).Rows.Count <> 0 And dset.Tables(sql).Rows(0).Item("Status") = "ACTIVE" Then

                frmMain.lbluser.Caption = dset.Tables(sql).Rows(0).Item("name")
                frmMain.lblacctType.Caption = dset.Tables(sql).Rows(0).Item("AccountType")
                frmMain.lblid.Caption = dset.Tables(sql).Rows(0).Item("EmpID")
                'SplashScreenManager1.ShowWaitForm()
                ' Threading.Thread.Sleep(1500)
                'SplashScreenManager1.CloseWaitForm()
                lblcount.text = 1
                frmMain.Show()
                frmMain.RibbonControl.Visible = True
                'frmMain.RibbonStatusBar.Visible = True
                Me.Close()
            End If
        End If
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
            If GcLogin.Text = "Login to Your Account" Then
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
        txtuser.BackColor = Color.LightBlue
    End Sub

    Private Sub txtuser_Leave(sender As Object, e As EventArgs) Handles txtuser.Leave
        txtuser.BackColor = Color.White
    End Sub
    Private Sub txtpw_Enter(sender As Object, e As EventArgs) Handles txtpw.Enter
        txtpw.BackColor = Color.LightBlue
    End Sub

    Private Sub txtpw_Leave(sender As Object, e As EventArgs) Handles txtpw.Leave
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
End Class