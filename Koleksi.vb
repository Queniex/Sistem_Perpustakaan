Imports System.Text
Imports System.Threading
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI.Common

Public Class Koleksi

    Private NamaKol As String
    Private JenisKol As String
    Private Deskripsi As String
    Private Penerbit As String
    Private ThnTerbit As Integer
    Private LokasiRak As String
    Private TglMasuk As String
    Private Stok As Integer
    Private Bahasa As Object
    Private Gambar As String
    Private Kategori As New List(Of String)
    Private HapusItem As Object
    Private KoleksiDataTable As New ArrayList()

    Public Shared DbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    'Private server As String = "localhost"
    'Private username As String = "root"
    'Private password As String = ""
    'Private database As String = "perpustakaan"
    'Private NamaKategori As New List(Of String)

    'sub-> fungsi module dalam class dan tidak memberikan return value
    'function -> fungsi module dalam class yang memberikan return value
    'class constructor -> Selalu dijalankan pertama kali :
    Public Sub New()

    End Sub

    'Fungsi untuk getter dan setter secara tidak langsung
    Public Property GSNamaKol() As String
        Get
            Return NamaKol
        End Get
        Set(ByVal value As String)
            NamaKol = value
        End Set
    End Property

    Public Property GSjenisKol() As String
        Get
            Return JenisKol
        End Get
        Set(ByVal value As String)
            JenisKol = value
        End Set
    End Property

    Public Property GSHapusItem() As Object
        Get
            Return HapusItem
        End Get
        Set(ByVal value As Object)
            HapusItem = value
        End Set
    End Property

    Public Property GSDeskripsi() As String
        Get
            Return Deskripsi
        End Get
        Set(ByVal value As String)
            Deskripsi = value
        End Set
    End Property

    Public Property GSPenerbit() As String
        Get
            Return Penerbit
        End Get
        Set(ByVal value As String)
            Penerbit = value
        End Set
    End Property

    Public Property GSLokasiRak() As String
        Get
            Return LokasiRak
        End Get
        Set(ByVal value As String)
            LokasiRak = value
        End Set
    End Property

    Public Property GSTglMasuk() As String
        Get
            Return TglMasuk
        End Get
        Set(ByVal value As String)
            TglMasuk = value
        End Set
    End Property

    Public Property GSbahasa() As Object
        Get
            Return Bahasa
        End Get
        Set(ByVal value As Object)
            Bahasa = value
        End Set
    End Property

    Public Property GSGambar() As String
        Get
            Return Gambar
        End Get
        Set(ByVal value As String)
            Gambar = value
        End Set
    End Property

    Public Property GSThnTerbit() As Integer
        Get
            Return ThnTerbit
        End Get
        Set(ByVal value As Integer)
            ThnTerbit = value
        End Set
    End Property

    Public Property GSStok() As Integer
        Get
            Return Stok
        End Get
        Set(ByVal value As Integer)
            Stok = value
        End Set
    End Property

    Public Property GSKategori() As List(Of String)
        Get
            Return Kategori
        End Get
        Set(ByVal value As List(Of String))
            Kategori = value
        End Set
    End Property

    'Public Property GSNamaKategori() As List(Of String)
    '    Get
    '        Return NamaKategori
    '    End Get
    '    Set(ByVal value As List(Of String))
    '        NamaKategori = value
    '    End Set
    'End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        'Convert to String
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        'Convert to List.
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function AddKoleksiTable(
                                    NamaKol As String,
                                    JenisKol As String,
                                    Deskripsi As String,
                                    Penerbit As String,
                                    ThnTerbit As Integer,
                                    LokasiRak As String,
                                    TglMasuk As String,
                                    Stok As Integer,
                                    Bahasa As String,
                                    Kategori As String,
                                    Gambar As String
                                    )

        DbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=perpustakaan;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            DbConn.Open()
            sqlQuery = "INSERT INTO koleksi(id_koleksi, nama_koleksi, dir_gambar, deskripsi, penerbit, 
                                        jenis_koleksi, tahun_terbit, lokasi, tgl_masuk,
                                        stock, bahasa, kategori) VALUES ('','" & NamaKol & "','" _
                                        & Gambar & "','" & Deskripsi & "','" _
                                        & Penerbit & "','" & JenisKol & "','" _
                                        & ThnTerbit & "','" & LokasiRak & "','" _
                                        & TglMasuk & "','" & Stok & "','" _
                                        & Bahasa & "','" & Kategori & "')"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader()
                sqlRead.Close()
                MsgBox("Data inserted.")
            Catch ex As Exception
                MsgBox("Failed to insert data: " & ex.Message.ToString())
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Function

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        DbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=perpustakaan;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            DbConn.Open()
            sqlQuery = "SELECT id_koleksi AS 'ID',
                                  nama_koleksi AS 'Nama Koleksi',
                                  jenis_koleksi AS 'Jenis Koleksi',
                                  deskripsi AS 'Deskripsi',
                                  penerbit AS 'Penerbit',
                                  tahun_terbit AS 'Tahun Terbit',
                                  tgl_masuk AS 'Tanggal Masuk',
                                  lokasi AS 'lokasi',
                                  stock AS 'Stock',
                                  bahasa AS 'Bahasa',
                                  kategori AS 'Kategori',
                                  dir_gambar AS 'Gambar'
                                  FROM koleksi"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader
                result.Load(sqlRead)
                Return result
            Catch ex As Exception
                MsgBox("Problem loading data: " & ex.Message.ToString)
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Function

    Public Function GetDataNama()
        Dim result As New List(Of String)

        DbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=perpustakaan;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            DbConn.Open()
            sqlQuery = "SELECT nama_koleksi FROM koleksi"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result.Add(sqlRead.GetString(0))
                End While

                Return result
            Catch ex As Exception
                MsgBox("Problem loading data: " & ex.Message.ToString)
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Function

    Public Function GetDataTableById(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        DbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=perpustakaan;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            DbConn.Open()
            sqlQuery = "SELECT * FROM koleksi WHERE id_koleksi='" & ID & "'"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                    result.Add(sqlRead.GetString(2).ToString())
                    result.Add(sqlRead.GetString(3).ToString())
                    result.Add(sqlRead.GetString(4).ToString())
                    result.Add(sqlRead.GetString(5).ToString())
                    result.Add(sqlRead.GetString(6).ToString())
                    result.Add(sqlRead.GetString(7).ToString())
                    result.Add(sqlRead.GetString(8).ToString())
                    result.Add(sqlRead.GetString(9).ToString())
                    result.Add(sqlRead.GetString(10).ToString())
                    result.Add(sqlRead.GetString(11).ToString())
                End While
                Return result
            Catch ex As Exception
                MsgBox("Problem loading data: " & ex.Message.ToString)
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Function

    Public Function UpdateDataKoleksiById(ID As Integer,
                                        NamaKol As String,
                                        JenisKol As String,
                                        Deskripsi As String,
                                        Penerbit As String,
                                        ThnTerbit As String,
                                        LokasiRak As String,
                                        TglMasuk As String,
                                        Stok As Integer,
                                        Bahasa As String,
                                        Kategori As String,
                                        Gambar As String
                                        )

        DbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=perpustakaan;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            DbConn.Open()
            sqlCommand.Connection = DbConn

            sqlQuery = "UPDATE koleksi SET " _
                        + "nama_koleksi='" & NamaKol & "'," _
                        + "dir_gambar='" & Gambar & "'," _
                        + "deskripsi='" & Deskripsi & "'," _
                        + "penerbit='" & Penerbit & "'," _
                        + "jenis_koleksi='" & JenisKol & "'," _
                        + "tahun_terbit='" & ThnTerbit & "'," _
                        + "lokasi='" & LokasiRak & "'," _
                        + "tgl_masuk='" & TglMasuk & "'," _
                        + "stock='" & Stok & "'," _
                        + "bahasa='" & Bahasa & "'," _
                        + "kategori='" & Kategori & "' WHERE id_koleksi='" & ID & "' "
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader
                DbConn.Close()
                sqlRead.Close()
                MsgBox("Data updated.")
            Catch ex As Exception
                MsgBox("Failed to update data: " & ex.Message.ToString())
            Finally
                DbConn.Dispose()
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Function

    Public Function RemoveKoleksiDataTable(index As Integer)
        KoleksiDataTable.RemoveAt(index)
    End Function

    Public ReadOnly Property getKoleksiDataTable() As ArrayList
        Get
            Return KoleksiDataTable
        End Get
    End Property

    Public Function DeleteDataKoleksiByIdDatabase(ID As Integer)

        DbConn = New MySqlConnection("Data Source=localhost;user id=root;password=;database=perpustakaan;Convert Zero Datetime=True;Allow Zero Datetime=True")
        Try
            DbConn.Open()
            sqlCommand.Connection = DbConn

            sqlQuery = "DELETE FROM koleksi " &
                       "WHERE id_koleksi='" & ID & "'"
            Try
                Debug.WriteLine(sqlQuery)
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader
                DbConn.Close()
                sqlRead.Close()
                MsgBox("Data Deleted.")
            Catch ex As Exception
                MsgBox("Failed to update data: " & ex.Message.ToString())
            Finally
                DbConn.Dispose()
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Function

End Class