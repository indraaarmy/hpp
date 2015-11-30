<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Biaya_Tetap
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataLaporanBiayaTetap = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.nama_sk = New System.Windows.Forms.Label
        Me.nama_produk = New System.Windows.Forms.Label
        Me.id_produk = New System.Windows.Forms.Label
        Me.id_sk_produk = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.total_penyusutan = New System.Windows.Forms.Label
        Me.total_listrik = New System.Windows.Forms.Label
        Me.total_biaya_tetap = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.upah_karyawan = New System.Windows.Forms.Label
        Me.no_sk = New System.Windows.Forms.Label
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nama_kebutuhan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.watt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.penyusutan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.biaya_listrik = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.penyusutan_unit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.biaya_listrik_unit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataLaporanBiayaTetap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 519)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(780, 43)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operasi"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(695, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "kembali"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataLaporanBiayaTetap
        '
        Me.DataLaporanBiayaTetap.AllowUserToAddRows = False
        Me.DataLaporanBiayaTetap.AllowUserToDeleteRows = False
        Me.DataLaporanBiayaTetap.AllowUserToResizeColumns = False
        Me.DataLaporanBiayaTetap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataLaporanBiayaTetap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataLaporanBiayaTetap.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomor, Me.nama_kebutuhan, Me.jumlah, Me.watt, Me.penyusutan, Me.biaya_listrik, Me.penyusutan_unit, Me.biaya_listrik_unit})
        Me.DataLaporanBiayaTetap.Location = New System.Drawing.Point(12, 88)
        Me.DataLaporanBiayaTetap.Name = "DataLaporanBiayaTetap"
        Me.DataLaporanBiayaTetap.ReadOnly = True
        Me.DataLaporanBiayaTetap.RowHeadersVisible = False
        Me.DataLaporanBiayaTetap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataLaporanBiayaTetap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataLaporanBiayaTetap.Size = New System.Drawing.Size(760, 308)
        Me.DataLaporanBiayaTetap.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(242, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Laporan Biaya Tetap"
        '
        'nama_sk
        '
        Me.nama_sk.AutoSize = True
        Me.nama_sk.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.nama_sk.Location = New System.Drawing.Point(216, 41)
        Me.nama_sk.Name = "nama_sk"
        Me.nama_sk.Size = New System.Drawing.Size(125, 29)
        Me.nama_sk.TabIndex = 3
        Me.nama_sk.Text = "nama_sk"
        '
        'nama_produk
        '
        Me.nama_produk.AutoSize = True
        Me.nama_produk.Location = New System.Drawing.Point(27, 25)
        Me.nama_produk.Name = "nama_produk"
        Me.nama_produk.Size = New System.Drawing.Size(72, 13)
        Me.nama_produk.TabIndex = 4
        Me.nama_produk.Text = "nama_produk"
        Me.nama_produk.Visible = False
        '
        'id_produk
        '
        Me.id_produk.AutoSize = True
        Me.id_produk.Location = New System.Drawing.Point(27, 41)
        Me.id_produk.Name = "id_produk"
        Me.id_produk.Size = New System.Drawing.Size(54, 13)
        Me.id_produk.TabIndex = 5
        Me.id_produk.Text = "id_produk"
        Me.id_produk.Visible = False
        '
        'id_sk_produk
        '
        Me.id_sk_produk.AutoSize = True
        Me.id_sk_produk.Location = New System.Drawing.Point(27, 57)
        Me.id_sk_produk.Name = "id_sk_produk"
        Me.id_sk_produk.Size = New System.Drawing.Size(71, 13)
        Me.id_sk_produk.TabIndex = 6
        Me.id_sk_produk.Text = "id_sk_produk"
        Me.id_sk_produk.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(140, 441)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total Biaya Penyusutan Unit (Rp)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(140, 470)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total Biaya Listrik Unit (Rp)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(140, 498)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total Biaya Tetap Unit (Rp)"
        '
        'total_penyusutan
        '
        Me.total_penyusutan.AutoSize = True
        Me.total_penyusutan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.total_penyusutan.Location = New System.Drawing.Point(389, 441)
        Me.total_penyusutan.Name = "total_penyusutan"
        Me.total_penyusutan.Size = New System.Drawing.Size(132, 20)
        Me.total_penyusutan.TabIndex = 10
        Me.total_penyusutan.Text = "total_penyusutan"
        '
        'total_listrik
        '
        Me.total_listrik.AutoSize = True
        Me.total_listrik.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.total_listrik.Location = New System.Drawing.Point(389, 468)
        Me.total_listrik.Name = "total_listrik"
        Me.total_listrik.Size = New System.Drawing.Size(84, 20)
        Me.total_listrik.TabIndex = 11
        Me.total_listrik.Text = "total_listrik"
        '
        'total_biaya_tetap
        '
        Me.total_biaya_tetap.AutoSize = True
        Me.total_biaya_tetap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_biaya_tetap.Location = New System.Drawing.Point(389, 498)
        Me.total_biaya_tetap.Name = "total_biaya_tetap"
        Me.total_biaya_tetap.Size = New System.Drawing.Size(149, 20)
        Me.total_biaya_tetap.TabIndex = 12
        Me.total_biaya_tetap.Text = "total_biaya_tetap"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(140, 409)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Upah Tenaga Kerja (Rp)"
        '
        'upah_karyawan
        '
        Me.upah_karyawan.AutoSize = True
        Me.upah_karyawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.upah_karyawan.Location = New System.Drawing.Point(389, 409)
        Me.upah_karyawan.Name = "upah_karyawan"
        Me.upah_karyawan.Size = New System.Drawing.Size(121, 20)
        Me.upah_karyawan.TabIndex = 14
        Me.upah_karyawan.Text = "upah_karyawan"
        '
        'no_sk
        '
        Me.no_sk.AutoSize = True
        Me.no_sk.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.no_sk.Location = New System.Drawing.Point(161, 41)
        Me.no_sk.Name = "no_sk"
        Me.no_sk.Size = New System.Drawing.Size(62, 29)
        Me.no_sk.TabIndex = 15
        Me.no_sk.Text = "(no)"
        '
        'nomor
        '
        Me.nomor.DataPropertyName = "nomor"
        Me.nomor.FillWeight = 20.0!
        Me.nomor.HeaderText = "No"
        Me.nomor.Name = "nomor"
        Me.nomor.ReadOnly = True
        '
        'nama_kebutuhan
        '
        Me.nama_kebutuhan.DataPropertyName = "nama_kebutuhan"
        Me.nama_kebutuhan.HeaderText = "Nama Kebutuhan"
        Me.nama_kebutuhan.Name = "nama_kebutuhan"
        Me.nama_kebutuhan.ReadOnly = True
        '
        'jumlah
        '
        Me.jumlah.DataPropertyName = "jumlah"
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ReadOnly = True
        '
        'watt
        '
        Me.watt.DataPropertyName = "watt"
        Me.watt.HeaderText = "Watt"
        Me.watt.Name = "watt"
        Me.watt.ReadOnly = True
        '
        'penyusutan
        '
        Me.penyusutan.DataPropertyName = "penyusutan"
        Me.penyusutan.HeaderText = "Biaya Penyusutan (Rp)"
        Me.penyusutan.Name = "penyusutan"
        Me.penyusutan.ReadOnly = True
        '
        'biaya_listrik
        '
        Me.biaya_listrik.DataPropertyName = "biaya_listrik"
        Me.biaya_listrik.HeaderText = "Biaya Listrik (Rp)"
        Me.biaya_listrik.Name = "biaya_listrik"
        Me.biaya_listrik.ReadOnly = True
        '
        'penyusutan_unit
        '
        Me.penyusutan_unit.DataPropertyName = "penyusutan_unit"
        Me.penyusutan_unit.HeaderText = "Biaya Penyusutan Unit (Rp)"
        Me.penyusutan_unit.Name = "penyusutan_unit"
        Me.penyusutan_unit.ReadOnly = True
        '
        'biaya_listrik_unit
        '
        Me.biaya_listrik_unit.DataPropertyName = "biaya_listrik_unit"
        Me.biaya_listrik_unit.HeaderText = "Biaya Listrik Unit (Rp)"
        Me.biaya_listrik_unit.Name = "biaya_listrik_unit"
        Me.biaya_listrik_unit.ReadOnly = True
        '
        'Laporan_Biaya_Tetap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.no_sk)
        Me.Controls.Add(Me.upah_karyawan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.total_biaya_tetap)
        Me.Controls.Add(Me.total_listrik)
        Me.Controls.Add(Me.total_penyusutan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.id_sk_produk)
        Me.Controls.Add(Me.id_produk)
        Me.Controls.Add(Me.nama_produk)
        Me.Controls.Add(Me.nama_sk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataLaporanBiayaTetap)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Laporan_Biaya_Tetap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biaya_Tetap"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataLaporanBiayaTetap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataLaporanBiayaTetap As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nama_sk As System.Windows.Forms.Label
    Friend WithEvents nama_produk As System.Windows.Forms.Label
    Friend WithEvents id_produk As System.Windows.Forms.Label
    Friend WithEvents id_sk_produk As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents total_penyusutan As System.Windows.Forms.Label
    Friend WithEvents total_listrik As System.Windows.Forms.Label
    Friend WithEvents total_biaya_tetap As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents upah_karyawan As System.Windows.Forms.Label
    Friend WithEvents no_sk As System.Windows.Forms.Label
    Friend WithEvents nomor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_kebutuhan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents watt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents penyusutan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents biaya_listrik As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents penyusutan_unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents biaya_listrik_unit As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
