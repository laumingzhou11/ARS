Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography

Module connection
    Private TripleDes As New TripleDESCryptoServiceProvider
    Public comm As New SqlCommand
    Public da As New SqlDataAdapter
    Public dset, dset2 As New DataSet
    Public sqlquery, sql, sql2, selected, keyID, keyID2, keyID3, cnstring, tmpstr As String
    'Dim wrapper As New Simple3Des("LAU")
    'Public server As String = My.Settings.Server
    'Public UserName As String = My.Settings.User
    'Public password As String = My.Settings.Password
    'Public db1 As String = My.Settings.Dbase1
    ''Public konnstr2 As String = "Data Source='" & DecryptData(My.Settings.Server) & "';User='" & DecryptData(My.Settings.User) & "'; " _
    ''                           & "password='" & DecryptData(My.Settings.Password) & "';Initial Catalog='" & DecryptData(My.Settings.dbase1) _
    ''                           & "';Initial Catalog='" & DecryptData(My.Settings.dbase2) & "';Initial Catalog='" & DecryptData(My.Settings.dbase3) & "';"
    Public konnstr As String = "Data Source='124.107.36.218';User='PulsarServer'; " _
                               & "password='@lara19';Initial Catalog='dbfuelling';"
    'Public konnstr2 As String = "Data Source='" & server & "';User='" & UserName & "'; " _
    '                           & "password='" & password & "';Initial Catalog='" & db1 _
    '                           & "';Initial Catalog='" & db2 & "';Initial Catalog='" & db3 & "';"
    'Public konnstr As String = "Data Source='" & server & "';User='" & UserName & "'; " _
    '                           & "password='" & password & "';Initial Catalog='" & db1 & "';"

    Public kon As New SqlConnection(konnstr)
    'Public kon2 As New SqlConnection(konnstr2)

    Public Function konneksyon()
        Try

            If kon.State = ConnectionState.Closed Then
                kon.Open()
            Else

            End If
        Catch eX As Exception
            MessageBox.Show(eX.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return True
    End Function

    Function populate(ByVal sql As String, ByVal dg As DevExpress.XtraGrid.GridControl)
        da = New SqlDataAdapter(sql, kon)
        dset = New DataSet
        da.Fill(dset, sql)
        dg.DataSource = dset.Tables(sql)
        Return True
    End Function
    'Function populate2(ByVal sql As String, ByVal dg As DevExpress.XtraGrid.GridControl)
    '    da = New SqlDataAdapter(sql, kon2)
    '    dset = New DataSet
    '    da.Fill(dset, sql)
    '    dg.DataSource = dset.Tables(sql)
    '    Return True
    'End Function
    Function fill(ByVal sql As String)
        da = New SqlDataAdapter(sql, kon)
        dset = New DataSet
        da.Fill(dset, sql)
        Return True
    End Function
    Function fill2(ByVal sqlQuery As String)
        da = New SqlDataAdapter(sqlQuery, kon)
        dset = New DataSet
        da.Fill(dset, sqlQuery)
        Return True
    End Function
    Function fill3(ByVal sql2 As String)
        da = New SqlDataAdapter(sql2, kon)
        dset = New DataSet
        da.Fill(dset, sql2)
        Return True
    End Function
    Function populate2(query As String) As DataTable
        Dim datatable As New DataTable
        Dim da As New SqlDataAdapter
        da.SelectCommand = New SqlCommand(query, kon)
        da.Fill(datatable)
        Return datatable
    End Function
    Function populateOnGrid(ByVal rec As SqlDataAdapter, ByVal tbl As DataSet, ByVal strsql As String, ByVal strTable As String, ByVal dg As DataGridView)
        rec = New SqlDataAdapter(strsql, kon)
        tbl = New DataSet
        rec.Fill(tbl, strTable)
        dg.DataSource = tbl.Tables(strTable).DefaultView
        Return True
    End Function
    Function save(ByVal saverec As String)
        Dim kom = New SqlCommand
        kom.Connection = kon
        kom.CommandText = saverec
        kom.ExecuteNonQuery()
        Return True
    End Function


    Public Function EncryptData(
    ByVal plaintext As String) As String

        ' Convert the plaintext string to a byte array.
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        ' Create the stream.
        Dim ms As New System.IO.MemoryStream
        ' Create the encoder to write to the stream.
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' Convert the encrypted stream to a printable string.
        Return Convert.ToBase64String(ms.ToArray)
    End Function
    Public Function DecryptData(
    ByVal encryptedtext As String) As String

        ' Convert the encrypted text string to a byte array.
        Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

        ' Create the stream.
        Dim ms As New System.IO.MemoryStream
        ' Create the decoder to write to the stream.
        Dim decStream As New CryptoStream(ms,
            TripleDes.CreateDecryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        ' Convert the plaintext stream to a string.
        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
    End Function
    'Sub New(ByVal key As String)
    '    ' Initialize the crypto provider.
    '    TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
    '    TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
    'End Sub
End Module