Public Class InfoTambahKoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Proses pengambilan data yang sudah disimpan secara temporary pada variable sebelumnya

        If Not String.IsNullOrEmpty(Perpustakaan.Koleksi.GSGambar) Then
            PBGambarInfo.Load(Perpustakaan.Koleksi.GSGambar)
            PBGambarInfo.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LblNama.Text = Perpustakaan.Koleksi.GSNamaKol
        LblJenis.Text = Perpustakaan.Koleksi.GSjenisKol
        LblDeskripsi.Text = Perpustakaan.Koleksi.GSDeskripsi
        LblPenerbit.Text = Perpustakaan.Koleksi.GSPenerbit
        LblTahun.Text = Perpustakaan.Koleksi.GSThnTerbit
        LblLokasi.Text = Perpustakaan.Koleksi.GSLokasiRak
        LblTanggal.Text = Perpustakaan.Koleksi.GSTglMasuk
        LblStok.Text = Perpustakaan.Koleksi.GSStok
        LblBahasa.Text = Perpustakaan.Koleksi.GSbahasa

        LbKategori.Items.Clear()
        For Each kat In Perpustakaan.Koleksi.GSKategori
            LbKategori.Items.Add(kat)
        Next

    End Sub

    Private Sub BtnTutupInfo_Click(sender As Object, e As EventArgs) Handles BtnTutupInfo.Click
        Me.Close()
    End Sub

End Class