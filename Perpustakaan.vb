Imports Google.Protobuf.WellKnownTypes

Public Class Perpustakaan

    Public Shared Koleksi As Koleksi
    Public Shared selectedTableKoleksi
    Dim selectedTableKoleksiNama
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Koleksi = New Koleksi()
        'UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub
    Private Sub BtnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click
        Dim Tambah_koleksi = New TambahKoleksi()
        Tambah_koleksi.Show()
    End Sub

    Private Sub TsBtnTambah_Click(sender As Object, e As EventArgs) Handles TsBtnTambah.Click
        Dim Tambah_koleksi = New TambahKoleksi()
        Tambah_koleksi.Show()
    End Sub

    Private Sub TsBtnKurang_Click(sender As Object, e As EventArgs) Handles TsBtnKurang.Click
        If LbPerpus.SelectedIndex >= 0 Then
            Koleksi.GSHapusItem = LbPerpus.SelectedItem()
            Dim HapusKol = New HapusKoleksi()
            HapusKol.Show()
        Else
            MessageBox.Show("Pilih terlebih dahulu")
        End If
    End Sub
    Private Sub ReloadDataTableDatabase()
        DataGridKoleksi.DataSource = Koleksi.GetDataKoleksiDatabase()
        LbPerpus.DataSource = Koleksi.GetDataNama()
    End Sub

    'Private Sub UpdateDataTableArrayList()
    '    Dim dataSelected As List(Of String) = Koleksi.GetDataNama()
    '    For Each add_item In dataSelected
    '        LbPerpus.Items.Add(add_item)
    '    Next
    'End Sub

    Private Sub Perpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridKoleksi.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click

        Dim dataSelected As List(Of String) = Koleksi.GetDataTableById(selectedTableKoleksi)
        Try
            Koleksi.GSNamaKol = dataSelected(1)
            Koleksi.GSjenisKol = dataSelected(5)
            Koleksi.GSDeskripsi = dataSelected(3)
            Koleksi.GSPenerbit = dataSelected(4)
            Koleksi.GSThnTerbit = dataSelected(6)
            Koleksi.GSTglMasuk = dataSelected(8)
            Koleksi.GSLokasiRak = dataSelected(7)
            Koleksi.GSStok = dataSelected(9)
            Koleksi.GSbahasa = dataSelected(10)
            'Koleksi.GSKategori = dataSelected(9)
            Koleksi.GSGambar = dataSelected(2)

            Dim data_koleksi As List(Of String) = Koleksi.ConvertStringToKoleksi(dataSelected(11))

            Koleksi.GSKategori.Clear()
            For Each info_tambah In data_koleksi
                Koleksi.GSKategori.Add(info_tambah)
            Next
            Dim infoTambah = New InfoTambahKoleksi()
            infoTambah.Show()
        Catch ex As Exception
            MsgBox("You havent choose any row yet!")
        End Try
    End Sub

    Private Sub BtnUpd_Click(sender As Object, e As EventArgs) Handles BtnUpd.Click
        Dim dataSelected As List(Of String) = Koleksi.GetDataTableById(selectedTableKoleksi)
        Try
            Koleksi.GSNamaKol = dataSelected(1)
            Koleksi.GSjenisKol = dataSelected(5)
            Koleksi.GSDeskripsi = dataSelected(3)
            Koleksi.GSPenerbit = dataSelected(4)
            Koleksi.GSThnTerbit = dataSelected(6)
            Koleksi.GSTglMasuk = dataSelected(8)
            Koleksi.GSLokasiRak = dataSelected(7)
            Koleksi.GSStok = dataSelected(9)
            Koleksi.GSbahasa = dataSelected(10)
            'Koleksi.GSKategori = dataSelected(9)
            Koleksi.GSGambar = dataSelected(2)
            Dim data_kategori As List(Of String) = Koleksi.ConvertStringToKoleksi(dataSelected(11))

            For Each info_kategori In data_kategori
                Koleksi.GSKategori.Add(info_kategori)
            Next

            Dim formUpdate = New update()
            formUpdate.Show()
        Catch ex As Exception
            MsgBox("You havent choose any row yet!")
        End Try
    End Sub

    Private Sub BtnRem_Click(sender As Object, e As EventArgs) Handles BtnRem.Click
        Dim dataSelected As List(Of String) = Koleksi.GetDataTableById(selectedTableKoleksi)
        Try
            Koleksi.GSNamaKol = dataSelected(1)
            Dim formHapus = New HapusKoleksi()
            formHapus.Show()
        Catch ex As Exception
            MsgBox("You havent choose any row yet!")
        End Try
    End Sub

End Class
