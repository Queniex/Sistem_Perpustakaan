Imports System.Security.Cryptography
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class Users

    Private TripleDes As New TripleDESCryptoServiceProvider
    Private UserName As String
    Private Password As String
    'Private AccList As New List(Of Users)
    Private KoleksiDataAcc As New ArrayList()
    Dim ans As Boolean
    Private users As New ArrayList()

    Public Shared DbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    'Public Function AddData(UserName As String,
    '                        Password As String)
    '    koleksiDataAcc.Add({UserName,
    '                        Password})
    'End Function

    'Public ReadOnly Property getKol() As ArrayList
    '    Get
    '        Return koleksiDataAcc
    '    End Get
    'End Property


    Public Property GSUserName() As String
        Get
            Return UserName
        End Get
        Set(ByVal value As String)
            UserName = value
        End Set
    End Property

    Public Property GSUser() As ArrayList
        Get
            Return users
        End Get
        Set(ByVal value As ArrayList)
            users = value
        End Set
    End Property

    Public ReadOnly Property GetKoleksiAcc() As ArrayList
        Get
            Return users
        End Get
    End Property

    Public Property GSPassword() As String
        Get
            Return Password
        End Get
        Set(ByVal value As String)
            Password = value
        End Set
    End Property

    Public Function EncryptData(ByVal plaintext As String)

        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        Dim ms As New System.IO.MemoryStream
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function AddRegist(username As String, ByVal plainPassword As String) As String
        Dim pass = EncryptData(plainPassword)
        users.Add({username, pass})
        Return True
    End Function

    Public ReadOnly Property GetKoleksiDataAcc() As ArrayList
        Get
            Return users
        End Get
    End Property

    Public Function EncryptMD5(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function

    Public Function AddUsers(username As String, pass As String)
        Try
            Dim today = Date.Now()
            DbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=perpustakaan;Convert Zero Datetime=True;Allow Zero Datetime=True")

            DbConn.Open()
            sqlQuery = "INSERT INTO users(id_user, username, password, registered_at) VALUES ('','" & username & "','" _
                                        & EncryptMD5(pass) & "','" & today.ToString("yyyy/MM/dd") & "')"
            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, DbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            DbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            DbConn.Dispose()
        End Try
    End Function

    Public Function CheckAuth(username As String, ByVal plainPassword As String)
        Dim result As New ArrayList

        DbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=perpustakaan;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            DbConn.Open()
            sqlQuery = "SELECT id_user, username FROM users WHERE username = '" & username & "' "
            sqlQuery &= "AND password='" & EncryptMD5(plainPassword) & "'"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result.Add({sqlRead.GetString(0), sqlRead.GetString(1)})
                End While

                Return result
            Catch ex As Exception
                MsgBox("Problem loading data: " & ex.Message.ToString)
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
        'For Each DataUser In users
        '    If String.Compare(username, DataUser(0)) = 0 And String.Compare(EncryptData(plainPassword), DataUser(1)) = 0 Then
        '        ans = True
        '    Else
        '        ans = False
        '    End If
        'Next
        'Return ans
    End Function

End Class

'Error Test

'Dim pass = EncryptData("plainPassword")
'users.Add({"username", pass})
'users.Add({"fildzah", EncryptData("123")})
'users.Add({"admin", EncryptData("456")})
'users.Add({"marissa", EncryptData("789")})
'Dim count As Integer = users.Count

'Dim i As Integer
'For i = 0 To count
'    If String.Compare(username, users.Item(i)(0)) = 0 And String.Compare(EncryptData(plainPassword), users.Item(i)(1)) = 0 Then
'        ans = True
'    Else
'        ans = False
'    End If
'Next

'Return count

'Dim i As Integer
'For i = 0 To users.Count
'    realPassword = EncryptData(users(i)(i))
'    realUsername = users(i + 1)(i + 1)
'    'If String.Compare(username, realUsername) = 0 And String.Compare(EncryptData(plainPassword), realPassword) = 0 Then
'    '    Return True
'    'Else
'    '    Return False
'    'End If
'Next
'For Each rowUser In users
'    realPassword = EncryptData(rowUser(1))
'    realUsername = rowUser(0)
'    If String.Compare(username, realUsername) = 0 And String.Compare(EncryptData(plainPassword), realPassword) = 0 Then
'        Return True
'    Else
'        Return False
'    End If
'Next

'For Each akun In users
'    If String.Compare(username, akun(0)) = 0 And String.Compare(EncryptData(plainPassword), akun(1)) = 0 Then
'        ans = True
'    ElseIf String.Compare(username, akun(0)) <> 0 Then
'        ans = False
'    Else
'        ans = False
'    End If
'Next

'If String.Compare(username, users.Item(0)(0)) = 0 And String.Compare(EncryptData(plainPassword), users.Item(0)(1)) = 0 Then
'    ans = True
'ElseIf String.Compare(username, Users.Item(1)(0)) = 0 And String.Compare(EncryptData(plainPassword), Users.Item(1)(1)) = 0 Then
'    ans = True
'ElseIf String.Compare(username, Users.Item(2)(0)) = 0 And String.Compare(EncryptData(plainPassword), Users.Item(2)(1)) = 0 Then
'    ans = True
'Else
'    ans = False
'End If