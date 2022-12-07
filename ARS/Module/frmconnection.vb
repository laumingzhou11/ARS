Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Data
Imports DevExpress.XtraEditors.Controls
Public Class frmconnection
    Dim objWriter As IO.StreamWriter
    Dim objreader As IO.StreamReader
    Dim kon2 As New SqlConnection
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnsave.Click



        My.Settings.Server = txtserver.Text
        My.Settings.User = txtUserName.Text
        My.Settings.Password = txtPassword.Text
        My.Settings.Dbase = txtdbase.Text

        My.Settings.Save()
        Application.Restart()
    End Sub
    Private Sub frmconnection_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtserver.Select()

    End Sub
   
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If lblConnection.Text = "main" Then
            Me.Close()
        Else
            frmmain.Close()
            Me.Close()
        End If
        
    End Sub

    Private Sub txtserver_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtserver.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtserver.Text = "" Then
                txtserver.Focus()
            Else
                With txtUserName
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub txtUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUserName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtUserName.Text = "" Then
                txtUserName.Focus()
            Else
                With txtPassword
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtPassword.Text = "" Then
                txtPassword.Focus()
            Else
                With txtdbase
                    .SelectionStart = 0
                    .SelectionLength = Len(.Text)
                    .Focus()
                End With
            End If
        End If
    End Sub
    Private Sub txtdbase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdbase.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txtdbase.Text = "" Then
                txtdbase.Focus()
            Else
                With btnsave
                    .Focus()
                End With
            End If
        End If
    End Sub


End Class