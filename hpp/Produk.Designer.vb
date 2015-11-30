<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produk
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BerandaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProdukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TambahDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KebutuhanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LihatDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TambahDataToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LihatDataToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PanduanPenggunaanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button_Hapus = New System.Windows.Forms.Button
        Me.Button_Ubah = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataProduk = New System.Windows.Forms.DataGridView
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_Produk = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nama_Produk = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.waktu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProdukToolStripMenuItem, Me.KebutuhanToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.PanduanPenggunaanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BerandaToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BerandaToolStripMenuItem
        '
        Me.BerandaToolStripMenuItem.Name = "BerandaToolStripMenuItem"
        Me.BerandaToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.BerandaToolStripMenuItem.Text = "Beranda"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'ProdukToolStripMenuItem
        '
        Me.ProdukToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.TambahDataToolStripMenuItem})
        Me.ProdukToolStripMenuItem.Name = "ProdukToolStripMenuItem"
        Me.ProdukToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ProdukToolStripMenuItem.Text = "Produk"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.DataToolStripMenuItem.Text = "Lihat Data"
        '
        'TambahDataToolStripMenuItem
        '
        Me.TambahDataToolStripMenuItem.Name = "TambahDataToolStripMenuItem"
        Me.TambahDataToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.TambahDataToolStripMenuItem.Text = "Tambah Data"
        '
        'KebutuhanToolStripMenuItem
        '
        Me.KebutuhanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatDataToolStripMenuItem, Me.TambahDataToolStripMenuItem1})
        Me.KebutuhanToolStripMenuItem.Name = "KebutuhanToolStripMenuItem"
        Me.KebutuhanToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.KebutuhanToolStripMenuItem.Text = "Kebutuhan"
        '
        'LihatDataToolStripMenuItem
        '
        Me.LihatDataToolStripMenuItem.Name = "LihatDataToolStripMenuItem"
        Me.LihatDataToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.LihatDataToolStripMenuItem.Text = "Lihat Data"
        '
        'TambahDataToolStripMenuItem1
        '
        Me.TambahDataToolStripMenuItem1.Name = "TambahDataToolStripMenuItem1"
        Me.TambahDataToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.TambahDataToolStripMenuItem1.Text = "Tambah Data"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LihatDataToolStripMenuItem1})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LihatDataToolStripMenuItem1
        '
        Me.LihatDataToolStripMenuItem1.Name = "LihatDataToolStripMenuItem1"
        Me.LihatDataToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.LihatDataToolStripMenuItem1.Text = "Lihat Data"
        '
        'PanduanPenggunaanToolStripMenuItem
        '
        Me.PanduanPenggunaanToolStripMenuItem.Name = "PanduanPenggunaanToolStripMenuItem"
        Me.PanduanPenggunaanToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.PanduanPenggunaanToolStripMenuItem.Text = "Panduan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button_Hapus)
        Me.GroupBox1.Controls.Add(Me.Button_Ubah)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 517)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 48)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operasi"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(538, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(118, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Data Input Produk"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(662, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Data Stasiun Kerja"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button_Hapus
        '
        Me.Button_Hapus.Location = New System.Drawing.Point(194, 19)
        Me.Button_Hapus.Name = "Button_Hapus"
        Me.Button_Hapus.Size = New System.Drawing.Size(75, 23)
        Me.Button_Hapus.TabIndex = 2
        Me.Button_Hapus.Text = "Hapus"
        Me.Button_Hapus.UseVisualStyleBackColor = True
        '
        'Button_Ubah
        '
        Me.Button_Ubah.Location = New System.Drawing.Point(104, 19)
        Me.Button_Ubah.Name = "Button_Ubah"
        Me.Button_Ubah.Size = New System.Drawing.Size(75, 23)
        Me.Button_Ubah.TabIndex = 1
        Me.Button_Ubah.Text = "Ubah"
        Me.Button_Ubah.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Data Produk"
        '
        'DataProduk
        '
        Me.DataProduk.AllowUserToAddRows = False
        Me.DataProduk.AllowUserToDeleteRows = False
        Me.DataProduk.AllowUserToResizeColumns = False
        Me.DataProduk.AllowUserToResizeRows = False
        Me.DataProduk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataProduk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataProduk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomor, Me.Id_Produk, Me.Nama_Produk, Me.waktu})
        Me.DataProduk.Location = New System.Drawing.Point(12, 110)
        Me.DataProduk.Name = "DataProduk"
        Me.DataProduk.ReadOnly = True
        Me.DataProduk.RowHeadersVisible = False
        Me.DataProduk.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataProduk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataProduk.ShowCellToolTips = False
        Me.DataProduk.Size = New System.Drawing.Size(760, 401)
        Me.DataProduk.TabIndex = 5
        '
        'nomor
        '
        Me.nomor.DataPropertyName = "nomor"
        Me.nomor.FillWeight = 22.84264!
        Me.nomor.HeaderText = "No"
        Me.nomor.Name = "nomor"
        Me.nomor.ReadOnly = True
        '
        'Id_Produk
        '
        Me.Id_Produk.DataPropertyName = "id_produk"
        Me.Id_Produk.HeaderText = "ID Produk"
        Me.Id_Produk.Name = "Id_Produk"
        Me.Id_Produk.ReadOnly = True
        Me.Id_Produk.Visible = False
        '
        'Nama_Produk
        '
        Me.Nama_Produk.DataPropertyName = "nama_produk"
        Me.Nama_Produk.FillWeight = 138.5787!
        Me.Nama_Produk.HeaderText = "Produk"
        Me.Nama_Produk.Name = "Nama_Produk"
        Me.Nama_Produk.ReadOnly = True
        '
        'waktu
        '
        Me.waktu.DataPropertyName = "waktu"
        Me.waktu.FillWeight = 138.5787!
        Me.waktu.HeaderText = "Waktu (menit)"
        Me.waktu.Name = "waktu"
        Me.waktu.ReadOnly = True
        '
        'Produk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataProduk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximizeBox = False
        Me.Name = "Produk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Produk"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataProduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BerandaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KebutuhanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LihatDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TambahDataToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LihatDataToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanduanPenggunaanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button_Hapus As System.Windows.Forms.Button
    Friend WithEvents Button_Ubah As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataProduk As System.Windows.Forms.DataGridView
    Friend WithEvents nomor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Produk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama_Produk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents waktu As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
