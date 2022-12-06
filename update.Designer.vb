<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PBGambar = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CbBudaya = New System.Windows.Forms.CheckBox()
        Me.CbTeknologi = New System.Windows.Forms.CheckBox()
        Me.CbSosial = New System.Windows.Forms.CheckBox()
        Me.CbSains = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdInggris = New System.Windows.Forms.RadioButton()
        Me.RdIndonesia = New System.Windows.Forms.RadioButton()
        Me.TxtStok = New System.Windows.Forms.TextBox()
        Me.DateMasuk = New System.Windows.Forms.DateTimePicker()
        Me.TxtLokasi = New System.Windows.Forms.TextBox()
        Me.TxtTahun = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPenerbit = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RTBDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.CBJenis = New System.Windows.Forms.ComboBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTambahKol = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PBGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PBGambar
        '
        Me.PBGambar.Location = New System.Drawing.Point(12, 38)
        Me.PBGambar.Name = "PBGambar"
        Me.PBGambar.Size = New System.Drawing.Size(113, 113)
        Me.PBGambar.TabIndex = 47
        Me.PBGambar.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CbBudaya)
        Me.GroupBox2.Controls.Add(Me.CbTeknologi)
        Me.GroupBox2.Controls.Add(Me.CbSosial)
        Me.GroupBox2.Controls.Add(Me.CbSains)
        Me.GroupBox2.Location = New System.Drawing.Point(301, 450)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(126, 128)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bahasa"
        '
        'CbBudaya
        '
        Me.CbBudaya.AutoSize = True
        Me.CbBudaya.Location = New System.Drawing.Point(6, 97)
        Me.CbBudaya.Name = "CbBudaya"
        Me.CbBudaya.Size = New System.Drawing.Size(65, 19)
        Me.CbBudaya.TabIndex = 3
        Me.CbBudaya.Text = "Budaya"
        Me.CbBudaya.UseVisualStyleBackColor = True
        '
        'CbTeknologi
        '
        Me.CbTeknologi.AutoSize = True
        Me.CbTeknologi.Location = New System.Drawing.Point(6, 72)
        Me.CbTeknologi.Name = "CbTeknologi"
        Me.CbTeknologi.Size = New System.Drawing.Size(77, 19)
        Me.CbTeknologi.TabIndex = 2
        Me.CbTeknologi.Text = "Teknologi"
        Me.CbTeknologi.UseVisualStyleBackColor = True
        '
        'CbSosial
        '
        Me.CbSosial.AutoSize = True
        Me.CbSosial.Location = New System.Drawing.Point(6, 47)
        Me.CbSosial.Name = "CbSosial"
        Me.CbSosial.Size = New System.Drawing.Size(56, 19)
        Me.CbSosial.TabIndex = 1
        Me.CbSosial.Text = "Sosial"
        Me.CbSosial.UseVisualStyleBackColor = True
        '
        'CbSains
        '
        Me.CbSains.AutoSize = True
        Me.CbSains.Location = New System.Drawing.Point(6, 22)
        Me.CbSains.Name = "CbSains"
        Me.CbSains.Size = New System.Drawing.Size(53, 19)
        Me.CbSains.TabIndex = 0
        Me.CbSains.Text = "Sains"
        Me.CbSains.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(147, 450)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 15)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Kategori"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdInggris)
        Me.GroupBox1.Controls.Add(Me.RdIndonesia)
        Me.GroupBox1.Location = New System.Drawing.Point(301, 364)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 77)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'RdInggris
        '
        Me.RdInggris.AutoSize = True
        Me.RdInggris.Location = New System.Drawing.Point(6, 47)
        Me.RdInggris.Name = "RdInggris"
        Me.RdInggris.Size = New System.Drawing.Size(101, 19)
        Me.RdInggris.TabIndex = 1
        Me.RdInggris.TabStop = True
        Me.RdInggris.Text = "Bahasa Inggris"
        Me.RdInggris.UseVisualStyleBackColor = True
        '
        'RdIndonesia
        '
        Me.RdIndonesia.AutoSize = True
        Me.RdIndonesia.Location = New System.Drawing.Point(6, 22)
        Me.RdIndonesia.Name = "RdIndonesia"
        Me.RdIndonesia.Size = New System.Drawing.Size(116, 19)
        Me.RdIndonesia.TabIndex = 0
        Me.RdIndonesia.TabStop = True
        Me.RdIndonesia.Text = "Bahasa Indonesia"
        Me.RdIndonesia.UseVisualStyleBackColor = True
        '
        'TxtStok
        '
        Me.TxtStok.Location = New System.Drawing.Point(301, 329)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.Size = New System.Drawing.Size(126, 23)
        Me.TxtStok.TabIndex = 43
        '
        'DateMasuk
        '
        Me.DateMasuk.Location = New System.Drawing.Point(301, 295)
        Me.DateMasuk.Name = "DateMasuk"
        Me.DateMasuk.Size = New System.Drawing.Size(126, 23)
        Me.DateMasuk.TabIndex = 42
        '
        'TxtLokasi
        '
        Me.TxtLokasi.Location = New System.Drawing.Point(301, 263)
        Me.TxtLokasi.Name = "TxtLokasi"
        Me.TxtLokasi.Size = New System.Drawing.Size(126, 23)
        Me.TxtLokasi.TabIndex = 41
        '
        'TxtTahun
        '
        Me.TxtTahun.Location = New System.Drawing.Point(301, 230)
        Me.TxtTahun.Name = "TxtTahun"
        Me.TxtTahun.Size = New System.Drawing.Size(126, 23)
        Me.TxtTahun.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(147, 364)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 15)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Bahasa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(147, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 15)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Stok"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(147, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 15)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Tanggal Masuk Koleksi"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(147, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Lokasi Rak"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(147, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Tahun Terbit"
        '
        'TxtPenerbit
        '
        Me.TxtPenerbit.Location = New System.Drawing.Point(301, 198)
        Me.TxtPenerbit.Name = "TxtPenerbit"
        Me.TxtPenerbit.Size = New System.Drawing.Size(126, 23)
        Me.TxtPenerbit.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(147, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Penerbit"
        '
        'RTBDeskripsi
        '
        Me.RTBDeskripsi.Location = New System.Drawing.Point(301, 97)
        Me.RTBDeskripsi.Name = "RTBDeskripsi"
        Me.RTBDeskripsi.Size = New System.Drawing.Size(126, 96)
        Me.RTBDeskripsi.TabIndex = 32
        Me.RTBDeskripsi.Text = ""
        '
        'CBJenis
        '
        Me.CBJenis.FormattingEnabled = True
        Me.CBJenis.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi Penelitian"})
        Me.CBJenis.Location = New System.Drawing.Point(301, 68)
        Me.CBJenis.Name = "CBJenis"
        Me.CBJenis.Size = New System.Drawing.Size(126, 23)
        Me.CBJenis.TabIndex = 31
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(301, 37)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(126, 23)
        Me.TxtNama.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(147, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Deskripsi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Jenis Koleksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nama Koleksi"
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnTambahGambar.FlatAppearance.BorderSize = 2
        Me.BtnTambahGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambahGambar.Location = New System.Drawing.Point(12, 157)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(113, 26)
        Me.BtnTambahGambar.TabIndex = 26
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Update Koleksi"
        '
        'BtnTambahKol
        '
        Me.BtnTambahKol.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTambahKol.Location = New System.Drawing.Point(301, 593)
        Me.BtnTambahKol.Name = "BtnTambahKol"
        Me.BtnTambahKol.Size = New System.Drawing.Size(126, 23)
        Me.BtnTambahKol.TabIndex = 48
        Me.BtnTambahKol.Text = "Tambah Koleksi"
        Me.BtnTambahKol.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 627)
        Me.Controls.Add(Me.BtnTambahKol)
        Me.Controls.Add(Me.PBGambar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtStok)
        Me.Controls.Add(Me.DateMasuk)
        Me.Controls.Add(Me.TxtLokasi)
        Me.Controls.Add(Me.TxtTahun)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtPenerbit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RTBDeskripsi)
        Me.Controls.Add(Me.CBJenis)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "update"
        Me.Text = "update"
        CType(Me.PBGambar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBGambar As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CbBudaya As CheckBox
    Friend WithEvents CbTeknologi As CheckBox
    Friend WithEvents CbSosial As CheckBox
    Friend WithEvents CbSains As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdInggris As RadioButton
    Friend WithEvents RdIndonesia As RadioButton
    Friend WithEvents TxtStok As TextBox
    Friend WithEvents DateMasuk As DateTimePicker
    Friend WithEvents TxtLokasi As TextBox
    Friend WithEvents TxtTahun As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPenerbit As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RTBDeskripsi As RichTextBox
    Friend WithEvents CBJenis As ComboBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTambahKol As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
