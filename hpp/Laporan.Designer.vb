<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
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
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataLaporan = New System.Windows.Forms.DataGridView
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id_produk = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nama_produk = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.waktu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProdukToolStripMenuItem, Me.KebutuhanToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.PanduanPenggunaanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 2
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
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 514)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 48)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operasi"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(6, 19)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(110, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Detail Laporan"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(491, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Kebutuhan SK"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(374, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Kebutuhan Pekerja"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(592, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "HPP/Menit"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(673, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "HPP/Waktu SK"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'DataLaporan
        '
        Me.DataLaporan.AllowUserToAddRows = False
        Me.DataLaporan.AllowUserToDeleteRows = False
        Me.DataLaporan.AllowUserToResizeColumns = False
        Me.DataLaporan.AllowUserToResizeRows = False
        Me.DataLaporan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataLaporan.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataLaporan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomor, Me.id_produk, Me.nama_produk, Me.waktu})
        Me.DataLaporan.Location = New System.Drawing.Point(12, 96)
        Me.DataLaporan.Name = "DataLaporan"
        Me.DataLaporan.ReadOnly = True
        Me.DataLaporan.RowHeadersVisible = False
        Me.DataLaporan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataLaporan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataLaporan.ShowCellToolTips = False
        Me.DataLaporan.Size = New System.Drawing.Size(766, 412)
        Me.DataLaporan.TabIndex = 4
        '
        'nomor
        '
        Me.nomor.DataPropertyName = "nomor"
        Me.nomor.FillWeight = 10.0!
        Me.nomor.HeaderText = "No"
        Me.nomor.Name = "nomor"
        Me.nomor.ReadOnly = True
        '
        'id_produk
        '
        Me.id_produk.DataPropertyName = "id_produk"
        Me.id_produk.HeaderText = "ID Produk"
        Me.id_produk.Name = "id_produk"
        Me.id_produk.ReadOnly = True
        Me.id_produk.Visible = False
        '
        'nama_produk
        '
        Me.nama_produk.DataPropertyName = "nama_produk"
        Me.nama_produk.HeaderText = "Nama Produk"
        Me.nama_produk.Name = "nama_produk"
        Me.nama_produk.ReadOnly = True
        '
        'waktu
        '
        Me.waktu.DataPropertyName = "Waktu"
        Me.waktu.HeaderText = "Waktu"
        Me.waktu.Name = "waktu"
        Me.waktu.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(253, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Laporan HPP Produk"
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataLaporan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximizeBox = False
        Me.Name = "Laporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataLaporan, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataLaporan As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents nomor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_produk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_produk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents waktu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
