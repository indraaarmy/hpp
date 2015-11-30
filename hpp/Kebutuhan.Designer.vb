<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kebutuhan
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
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
        Me.DataKebutuhan = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.id_kebutuhan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nama_kebutuhan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.harga_kebutuhan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.satuan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.jenis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.listrik = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.watt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.umur_pemakaian = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataKebutuhan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        'DataKebutuhan
        '
        Me.DataKebutuhan.AllowUserToAddRows = False
        Me.DataKebutuhan.AllowUserToDeleteRows = False
        Me.DataKebutuhan.AllowUserToResizeColumns = False
        Me.DataKebutuhan.AllowUserToResizeRows = False
        Me.DataKebutuhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataKebutuhan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataKebutuhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataKebutuhan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_kebutuhan, Me.nomor, Me.nama_kebutuhan, Me.harga_kebutuhan, Me.satuan, Me.jenis, Me.listrik, Me.watt, Me.umur_pemakaian})
        Me.DataKebutuhan.Location = New System.Drawing.Point(12, 99)
        Me.DataKebutuhan.Name = "DataKebutuhan"
        Me.DataKebutuhan.ReadOnly = True
        Me.DataKebutuhan.RowHeadersVisible = False
        Me.DataKebutuhan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataKebutuhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataKebutuhan.ShowCellToolTips = False
        Me.DataKebutuhan.Size = New System.Drawing.Size(760, 410)
        Me.DataKebutuhan.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(286, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Data Kebutuhan"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(87, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Ubah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(168, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 515)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 48)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operasi"
        '
        'id_kebutuhan
        '
        Me.id_kebutuhan.DataPropertyName = "id_kebutuhan"
        Me.id_kebutuhan.HeaderText = "id_kebutuhan"
        Me.id_kebutuhan.Name = "id_kebutuhan"
        Me.id_kebutuhan.ReadOnly = True
        Me.id_kebutuhan.Visible = False
        '
        'nomor
        '
        Me.nomor.DataPropertyName = "nomor"
        Me.nomor.FillWeight = 40.60914!
        Me.nomor.HeaderText = "No"
        Me.nomor.Name = "nomor"
        Me.nomor.ReadOnly = True
        '
        'nama_kebutuhan
        '
        Me.nama_kebutuhan.DataPropertyName = "nama_kebutuhan"
        Me.nama_kebutuhan.FillWeight = 119.797!
        Me.nama_kebutuhan.HeaderText = "Nama Kebutuhan"
        Me.nama_kebutuhan.Name = "nama_kebutuhan"
        Me.nama_kebutuhan.ReadOnly = True
        '
        'harga_kebutuhan
        '
        Me.harga_kebutuhan.DataPropertyName = "harga_kebutuhan"
        Me.harga_kebutuhan.FillWeight = 119.797!
        Me.harga_kebutuhan.HeaderText = "Harga"
        Me.harga_kebutuhan.Name = "harga_kebutuhan"
        Me.harga_kebutuhan.ReadOnly = True
        '
        'satuan
        '
        Me.satuan.DataPropertyName = "satuan"
        Me.satuan.FillWeight = 119.797!
        Me.satuan.HeaderText = "Satuan"
        Me.satuan.Name = "satuan"
        Me.satuan.ReadOnly = True
        '
        'jenis
        '
        Me.jenis.DataPropertyName = "jenis"
        Me.jenis.HeaderText = "Jenis"
        Me.jenis.Name = "jenis"
        Me.jenis.ReadOnly = True
        '
        'listrik
        '
        Me.listrik.DataPropertyName = "listrik"
        Me.listrik.HeaderText = "Elektronik"
        Me.listrik.Name = "listrik"
        Me.listrik.ReadOnly = True
        '
        'watt
        '
        Me.watt.DataPropertyName = "watt"
        Me.watt.HeaderText = "Watt"
        Me.watt.Name = "watt"
        Me.watt.ReadOnly = True
        '
        'umur_pemakaian
        '
        Me.umur_pemakaian.DataPropertyName = "umur_pemakaian"
        Me.umur_pemakaian.HeaderText = "Umur Pemakaian"
        Me.umur_pemakaian.Name = "umur_pemakaian"
        Me.umur_pemakaian.ReadOnly = True
        '
        'Kebutuhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataKebutuhan)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximizeBox = False
        Me.Name = "Kebutuhan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kebutuhan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataKebutuhan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
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
    Friend WithEvents DataKebutuhan As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents id_kebutuhan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_kebutuhan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga_kebutuhan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents satuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents listrik As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents watt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents umur_pemakaian As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
