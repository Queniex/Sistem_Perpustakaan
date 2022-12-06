<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Perpustakaan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BtnKoleksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnTambahKoleksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.LbPerpus = New System.Windows.Forms.ListBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TsBtnTambah = New System.Windows.Forms.ToolStripButton()
        Me.TsBtnKurang = New System.Windows.Forms.ToolStripButton()
        Me.DataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.BtnUpd = New System.Windows.Forms.Button()
        Me.BtnRem = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnKoleksi})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(744, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BtnKoleksi
        '
        Me.BtnKoleksi.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnKoleksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnTambahKoleksi})
        Me.BtnKoleksi.Name = "BtnKoleksi"
        Me.BtnKoleksi.Size = New System.Drawing.Size(56, 20)
        Me.BtnKoleksi.Text = "Koleksi"
        '
        'BtnTambahKoleksi
        '
        Me.BtnTambahKoleksi.Name = "BtnTambahKoleksi"
        Me.BtnTambahKoleksi.Size = New System.Drawing.Size(156, 22)
        Me.BtnTambahKoleksi.Text = "Tambah Koleksi"
        '
        'LbPerpus
        '
        Me.LbPerpus.FormattingEnabled = True
        Me.LbPerpus.ItemHeight = 15
        Me.LbPerpus.Location = New System.Drawing.Point(8, 58)
        Me.LbPerpus.Name = "LbPerpus"
        Me.LbPerpus.Size = New System.Drawing.Size(237, 214)
        Me.LbPerpus.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsBtnTambah, Me.TsBtnKurang})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(744, 25)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TsBtnTambah
        '
        Me.TsBtnTambah.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsBtnTambah.Image = Global.perpustakaan.My.Resources.Resources.plusButton
        Me.TsBtnTambah.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsBtnTambah.Name = "TsBtnTambah"
        Me.TsBtnTambah.Size = New System.Drawing.Size(23, 22)
        '
        'TsBtnKurang
        '
        Me.TsBtnKurang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsBtnKurang.Image = Global.perpustakaan.My.Resources.Resources.minus_button
        Me.TsBtnKurang.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsBtnKurang.Name = "TsBtnKurang"
        Me.TsBtnKurang.Size = New System.Drawing.Size(23, 22)
        Me.TsBtnKurang.Text = "TsBtnKurang"
        '
        'DataGridKoleksi
        '
        Me.DataGridKoleksi.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksi.Location = New System.Drawing.Point(251, 58)
        Me.DataGridKoleksi.Name = "DataGridKoleksi"
        Me.DataGridKoleksi.RowTemplate.Height = 25
        Me.DataGridKoleksi.Size = New System.Drawing.Size(479, 184)
        Me.DataGridKoleksi.TabIndex = 8
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(574, 249)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(75, 23)
        Me.BtnSelect.TabIndex = 9
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'BtnUpd
        '
        Me.BtnUpd.Location = New System.Drawing.Point(493, 249)
        Me.BtnUpd.Name = "BtnUpd"
        Me.BtnUpd.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpd.TabIndex = 10
        Me.BtnUpd.Text = "Update"
        Me.BtnUpd.UseVisualStyleBackColor = True
        '
        'BtnRem
        '
        Me.BtnRem.Location = New System.Drawing.Point(655, 249)
        Me.BtnRem.Name = "BtnRem"
        Me.BtnRem.Size = New System.Drawing.Size(75, 23)
        Me.BtnRem.TabIndex = 11
        Me.BtnRem.Text = "Remove"
        Me.BtnRem.UseVisualStyleBackColor = True
        '
        'Perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(744, 283)
        Me.Controls.Add(Me.BtnRem)
        Me.Controls.Add(Me.BtnUpd)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.DataGridKoleksi)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.LbPerpus)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Perpustakaan"
        Me.Text = "Perpustakaan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BtnKoleksi As ToolStripMenuItem
    Friend WithEvents BtnTambahKoleksi As ToolStripMenuItem
    Friend WithEvents LbPerpus As ListBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TsBtnTambah As ToolStripButton
    Friend WithEvents TsBtnKurang As ToolStripButton
    Friend WithEvents DataGridKoleksi As DataGridView
    Friend WithEvents BtnSelect As Button
    Friend WithEvents BtnUpd As Button
    Friend WithEvents BtnRem As Button
End Class
