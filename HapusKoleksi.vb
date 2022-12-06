Public Class HapusKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim text = Perpustakaan.Koleksi.GSNamaKol
        LblHapus.Text = text.ToUpper()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        'Dim nomor As Integer
        'nomor = Perpustakaan.LbPerpus.SelectedIndex
        'Perpustakaan.LbPerpus.Items.RemoveAt(Perpustakaan.LbPerpus.SelectedIndex)
        'Perpustakaan.Koleksi.RemoveKoleksiDataTable(nomor)
        Perpustakaan.Koleksi.DeleteDataKoleksiByIdDatabase(Perpustakaan.selectedTableKoleksi)
        Me.Close()
    End Sub

    Private Sub HapusKoleksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class