Imports Org.BouncyCastle.Operators

Public Class update

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PBGambar.Load(Perpustakaan.Koleksi.GSGambar)
        PBGambar.SizeMode = PictureBoxSizeMode.StretchImage
        DateMasuk.Format = DateTimePickerFormat.Custom
        TxtNama.Text = Perpustakaan.Koleksi.GSNamaKol
        CBJenis.SelectedItem() = Perpustakaan.Koleksi.GSjenisKol
        RTBDeskripsi.Text = Perpustakaan.Koleksi.GSDeskripsi
        TxtPenerbit.Text = Perpustakaan.Koleksi.GSPenerbit
        TxtTahun.Text = Perpustakaan.Koleksi.GSThnTerbit
        TxtLokasi.Text = Perpustakaan.Koleksi.GSLokasiRak
        DateMasuk.Value = Perpustakaan.Koleksi.GSTglMasuk
        TxtStok.Text = Perpustakaan.Koleksi.GSStok

        If String.Compare(Perpustakaan.Koleksi.GSbahasa, "Bahasa Indonesia") = 0 Then
            RdIndonesia.Checked = True
        ElseIf String.Compare(Perpustakaan.Koleksi.GSbahasa, "Bahasa Inggris") = 0 Then
            RdInggris.Checked = True
        End If

        For Each kategoriItem In Perpustakaan.Koleksi.GSKategori

            If String.Compare(kategoriItem, "Sains") = 0 Then
                CbSains.Checked = True
            ElseIf String.Compare(kategoriItem, "Sosial") = 0 Then
                CbSosial.Checked = True
            ElseIf String.Compare(kategoriItem, "Teknologi") = 0 Then
                CbTeknologi.Checked = True
            ElseIf String.Compare(kategoriItem, "Budaya") = 0 Then
                CbBudaya.Checked = True
            End If

        Next
        Perpustakaan.Koleksi.GSKategori.Clear()
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

    Private Sub BtnTambahKol_Click(sender As Object, e As EventArgs) Handles BtnTambahKol.Click
        Perpustakaan.Koleksi.GSNamaKol = TxtNama.Text.ToString()
        Perpustakaan.Koleksi.GSjenisKol = CBJenis.SelectedItem().ToString()
        Perpustakaan.Koleksi.GSDeskripsi = RTBDeskripsi.Text.ToString()
        Perpustakaan.Koleksi.GSPenerbit = TxtPenerbit.Text.ToString()
        Perpustakaan.Koleksi.GSThnTerbit = Integer.Parse(TxtTahun.Text)
        Perpustakaan.Koleksi.GSLokasiRak = TxtLokasi.Text.ToString()
        Perpustakaan.Koleksi.GSTglMasuk = DateMasuk.Value.ToString("yyyy/MM/dd")
        Perpustakaan.Koleksi.GSStok = Integer.Parse(TxtStok.Text)

        If RdIndonesia.Checked Then
            Perpustakaan.Koleksi.GSbahasa = "Indonesia"
        ElseIf RdInggris.Checked Then
            Perpustakaan.Koleksi.GSbahasa = "Inggris"
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

        'Perpustakaan.Koleksi
        Dim convertedKoleksi = Perpustakaan.Koleksi.ConvertKoleksiToString(Perpustakaan.Koleksi.GSKategori)

        Perpustakaan.Koleksi.UpdateDataKoleksiById(Perpustakaan.selectedTableKoleksi,
                                                   Perpustakaan.Koleksi.GSNamaKol,
                                                   Perpustakaan.Koleksi.GSjenisKol,
                                                   Perpustakaan.Koleksi.GSDeskripsi,
                                                   Perpustakaan.Koleksi.GSPenerbit,
                                                   Perpustakaan.Koleksi.GSThnTerbit,
                                                   Perpustakaan.Koleksi.GSLokasiRak,
                                                   Perpustakaan.Koleksi.GSTglMasuk,
                                                   Perpustakaan.Koleksi.GSStok,
                                                   Perpustakaan.Koleksi.GSbahasa,
                                                   convertedKoleksi,
                                                   Perpustakaan.Koleksi.GSGambar)

        Dim infoTambah = New InfoTambahKoleksi()
        infoTambah.Show()

        Me.Close()
    End Sub
End Class