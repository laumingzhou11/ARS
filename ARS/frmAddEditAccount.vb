Imports System.Data.SqlClient
Public Class frmAddEditAccount
    Private Sub frmAddEditAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Function xclear() As Boolean
        txtuser.Text = ""
        txtpass.Text = ""
        cbacctype.Text = ""
        txtname.Text = ""
        cbstatus.Text = ""
        cbPosition.Text = ""
        Return True
    End Function
    Private Sub ckpasschar_CheckedChanged(sender As Object, e As EventArgs) Handles ckpasschar.CheckedChanged
        If ckpasschar.Checked = True Then
            txtpass.Properties.PasswordChar = ""

        Else
            txtpass.Properties.PasswordChar = "*"

        End If
    End Sub
    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtname.Text = "" Then
                txtname.Focus()
            Else
                With txtuser
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub txtuser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtuser.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtuser.Text = "" Then
                txtuser.Focus()
            Else
                With txtpass
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub txtpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtpass.Text = "" Then
                txtpass.Focus()
            Else
                With cbacctype
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub cbacctype_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbacctype.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If cbacctype.Text = "" Then
                cbacctype.Focus()
            Else
                With cbstatus
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub cbstatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbstatus.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If cbstatus.Text = "" Then
                cbstatus.Focus()
            Else
                With btnsave
                    .Focus()
                End With
            End If
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        If lblaccount.Text = "login" Then
            If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Yes Then
                Me.Close()
                Call xclear()
                frmaccount.Show()
            End If
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

    End Sub
End Class

