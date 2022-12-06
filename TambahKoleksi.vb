Imports System.IO

Public Class TambahKoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'CBJenis.DataSource = Perpustakaan.Koleksi.GSjenisKol
        TxtTahun.MaxLength = 4
        DateMasuk.Format = DateTimePickerFormat.Custom
        DateMasuk.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "Image Files (*.jpeg, *.jpg, *.png, *.bmap)|*.jpeg; *.jpg; *.png; *.bmap|All Files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()

        PBGambar.Load(OpenFileDialog1.FileName)
        PBGambar.SizeMode = PictureBoxSizeMode.StretchImage
        Perpustakaan.Koleksi.GSGambar = OpenFileDialog1.FileName.ToString()
        Perpustakaan.Koleksi.GSGambar = Perpustakaan.Koleksi.GSGambar.Replace("\", "/")
    End Sub

    Private Sub TxtTahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTahun.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukkan Angka saja!")
        End If
    End Sub

    Private Sub RTBDeskripsi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RTBDeskripsi.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Karakter Tidak dikenali!")
        End If
    End Sub

    Private Sub TxtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("karakter tidak dikenali!")
        End If
    End Sub

    Private Sub TxtNama_Leave(sender As Object, e As EventArgs) Handles TxtNama.Leave
        If TxtNama.Text.Length < 1 Then
            TxtNama.Select()
            MessageBox.Show("Nama buku tidak boleh kosong!")
        End If
    End Sub


    Private Sub TxtLokasi_Leave(sender As Object, e As EventArgs) Handles TxtLokasi.Leave
        If TxtLokasi.Text.Length < 1 Then
            TxtLokasi.Select()
            MessageBox.Show("Lokasi buku tidak boleh kosong!")
        End If
    End Sub

    Private Sub TxtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStok.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukkan Angka saja!")
        End If
    End Sub

    Private Sub TxtStok_Leave(sender As Object, e As EventArgs) Handles TxtStok.Leave
        If TxtStok.Text.Length < 1 Then
            TxtStok.Select()
            MessageBox.Show("Stok buku tidak boleh kosong!")
        End If
    End Sub

    Private Sub BtnTambahKol_Click(sender As Object, e As EventArgs) Handles BtnTambahKol.Click
        'Penyimpanan variable
        Perpustakaan.Koleksi.GSNamaKol = TxtNama.Text
        Perpustakaan.Koleksi.GSjenisKol = CBJenis.Text
        Perpustakaan.Koleksi.GSDeskripsi = RTBDeskripsi.Text
        Perpustakaan.Koleksi.GSPenerbit = TxtPenerbit.Text
        Perpustakaan.Koleksi.GSThnTerbit = Integer.Parse(TxtTahun.Text)
        Perpustakaan.Koleksi.GSLokasiRak = TxtLokasi.Text
        Perpustakaan.Koleksi.GSTglMasuk = DateMasuk.Value.ToString("yyyy/MM/dd")
        Perpustakaan.Koleksi.GSStok = TxtStok.Text.ToString()
        'Perpustakaan.Koleksi.GSNamaKategori = TxtNama.Text

        If RdIndonesia.Checked() Then
            Perpustakaan.Koleksi.GSbahasa = RdIndonesia.Text.ToString()
        ElseIf RdInggris.Checked() Then
            Perpustakaan.Koleksi.GSbahasa = RdInggris.Text.ToString()
        End If

        Perpustakaan.Koleksi.GSKategori.Clear()
        If CbSains.Checked() Then
            Perpustakaan.Koleksi.GSKategori.Add("Sains")
        End If

        If CbTeknologi.Checked() Then
            Perpustakaan.Koleksi.GSKategori.Add("Teknologi")
        End If

        If CbSosial.Checked() Then
            Perpustakaan.Koleksi.GSKategori.Add("Sosial")
        End If

        If CbBudaya.Checked() Then
            Perpustakaan.Koleksi.GSKategori.Add("Budaya")
        End If

        'Perpustakaan.Koleksi.GSKategori.Clear()

        Dim ConvertedKoleksi = Perpustakaan.Koleksi.ConvertKoleksiToString(Perpustakaan.Koleksi.GSKategori)
        Perpustakaan.Koleksi.AddKoleksiTable(
                                             Perpustakaan.Koleksi.GSNamaKol,
                                             Perpustakaan.Koleksi.GSjenisKol,
                                             Perpustakaan.Koleksi.GSDeskripsi,
                                             Perpustakaan.Koleksi.GSPenerbit,
                                             Perpustakaan.Koleksi.GSThnTerbit,
                                             Perpustakaan.Koleksi.GSLokasiRak,
                                             Perpustakaan.Koleksi.GSTglMasuk,
                                             Perpustakaan.Koleksi.GSStok,
                                             Perpustakaan.Koleksi.GSbahasa,
                                             ConvertedKoleksi,
                                             Perpustakaan.Koleksi.GSGambar
                                             )

        'Pembukaan form info Tambah Koleksi
        Dim add_item = Perpustakaan.Koleksi.GSNamaKol
        Perpustakaan.LbPerpus.Items.Add(add_item)

        Dim info_koleksi = New InfoTambahKoleksi()
        info_koleksi.Show()
        Me.Close()
    End Sub

End Class