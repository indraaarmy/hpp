<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_sk
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
        Me.DataLaporanSK = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Id_produk = New System.Windows.Forms.Label
        Me.nama_produk = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.total_waktu = New System.Windows.Forms.Label
        Me.total_biaya_proses = New System.Windows.Forms.Label
        Me.total_biaya_tetap = New System.Windows.Forms.Label
        Me.total_biaya_variable = New System.Windows.Forms.Label
        Me.hpp = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.harga_jual = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id_sk_produk = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nama_sk = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.waktu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.jumlah_pekerja = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.upah = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.upah_karyawan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.biaya_proses = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.biaya_tetap = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.biaya_kebutuhan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.biaya_sk = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataLaporanSK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataLaporanSK
        '
        Me.DataLaporanSK.AllowUserToAddRows = False
        Me.DataLaporanSK.AllowUserToDeleteRows = False
        Me.DataLaporanSK.AllowUserToResizeColumns = False
        Me.DataLaporanSK.AllowUserToResizeRows = False
        Me.DataLaporanSK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataLaporanSK.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataLaporanSK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataLaporanSK.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomor, Me.id_sk_produk, Me.nama_sk, Me.waktu, Me.jumlah_pekerja, Me.upah, Me.upah_karyawan, Me.biaya_proses, Me.biaya_tetap, Me.biaya_kebutuhan, Me.biaya_sk})
        Me.DataLaporanSK.Location = New System.Drawing.Point(10, 70)
        Me.DataLaporanSK.Name = "DataLaporanSK"
        Me.DataLaporanSK.ReadOnly = True
        Me.DataLaporanSK.RowHeadersVisible = False
        Me.DataLaporanSK.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataLaporanSK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataLaporanSK.ShowCellToolTips = False
        Me.DataLaporanSK.Size = New System.Drawing.Size(766, 279)
        Me.DataLaporanSK.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(206, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Laporan Harga Pokok Produksi"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 514)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(762, 44)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operasi"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(672, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "kembali"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(103, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Biaya Variabel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Biaya Tetap"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(185, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total Waktu (menit)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(185, 466)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Harga Pokok Produksi (Rp)"
        '
        'Id_produk
        '
        Me.Id_produk.AutoSize = True
        Me.Id_produk.Location = New System.Drawing.Point(41, 48)
        Me.Id_produk.Name = "Id_produk"
        Me.Id_produk.Size = New System.Drawing.Size(54, 13)
        Me.Id_produk.TabIndex = 9
        Me.Id_produk.Text = "id_produk"
        Me.Id_produk.Visible = False
        '
        'nama_produk
        '
        Me.nama_produk.AutoSize = True
        Me.nama_produk.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.nama_produk.Location = New System.Drawing.Point(306, 38)
        Me.nama_produk.Name = "nama_produk"
        Me.nama_produk.Size = New System.Drawing.Size(183, 29)
        Me.nama_produk.TabIndex = 10
        Me.nama_produk.Text = "nama_produk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(185, 377)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Total Biaya Tetap (Rp/menit.unit)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(185, 406)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(206, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Total Biaya tetap (Rp/menit)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(185, 435)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Total Biaya Variabel (Rp)"
        '
        'total_waktu
        '
        Me.total_waktu.AutoSize = True
        Me.total_waktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.total_waktu.Location = New System.Drawing.Point(424, 351)
        Me.total_waktu.Name = "total_waktu"
        Me.total_waktu.Size = New System.Drawing.Size(57, 20)
        Me.total_waktu.TabIndex = 14
        Me.total_waktu.Text = "Label7"
        '
        'total_biaya_proses
        '
        Me.total_biaya_proses.AutoSize = True
        Me.total_biaya_proses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.total_biaya_proses.Location = New System.Drawing.Point(424, 377)
        Me.total_biaya_proses.Name = "total_biaya_proses"
        Me.total_biaya_proses.Size = New System.Drawing.Size(57, 20)
        Me.total_biaya_proses.TabIndex = 15
        Me.total_biaya_proses.Text = "Label8"
        '
        'total_biaya_tetap
        '
        Me.total_biaya_tetap.AutoSize = True
        Me.total_biaya_tetap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.total_biaya_tetap.Location = New System.Drawing.Point(424, 406)
        Me.total_biaya_tetap.Name = "total_biaya_tetap"
        Me.total_biaya_tetap.Size = New System.Drawing.Size(57, 20)
        Me.total_biaya_tetap.TabIndex = 16
        Me.total_biaya_tetap.Text = "Label9"
        '
        'total_biaya_variable
        '
        Me.total_biaya_variable.AutoSize = True
        Me.total_biaya_variable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.total_biaya_variable.Location = New System.Drawing.Point(424, 435)
        Me.total_biaya_variable.Name = "total_biaya_variable"
        Me.total_biaya_variable.Size = New System.Drawing.Size(66, 20)
        Me.total_biaya_variable.TabIndex = 17
        Me.total_biaya_variable.Text = "Label10"
        '
        'hpp
        '
        Me.hpp.AutoSize = True
        Me.hpp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hpp.Location = New System.Drawing.Point(424, 465)
        Me.hpp.Name = "hpp"
        Me.hpp.Size = New System.Drawing.Size(83, 24)
        Me.hpp.TabIndex = 18
        Me.hpp.Text = "Label11"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(185, 491)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Harga Jual Produk (Rp)"
        '
        'harga_jual
        '
        Me.harga_jual.AutoSize = True
        Me.harga_jual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.harga_jual.Location = New System.Drawing.Point(424, 491)
        Me.harga_jual.Name = "harga_jual"
        Me.harga_jual.Size = New System.Drawing.Size(72, 24)
        Me.harga_jual.TabIndex = 20
        Me.harga_jual.Text = "Label8"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(225, 16)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(134, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Total Harga*Jumlah"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'nomor
        '
        Me.nomor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.nomor.DataPropertyName = "nomor"
        Me.nomor.FillWeight = 90.10152!
        Me.nomor.HeaderText = "No."
        Me.nomor.Name = "nomor"
        Me.nomor.ReadOnly = True
        Me.nomor.Width = 49
        '
        'id_sk_produk
        '
        Me.id_sk_produk.DataPropertyName = "id_sk_produk"
        Me.id_sk_produk.HeaderText = "Id SK Produk"
        Me.id_sk_produk.Name = "id_sk_produk"
        Me.id_sk_produk.ReadOnly = True
        Me.id_sk_produk.Visible = False
        '
        'nama_sk
        '
        Me.nama_sk.DataPropertyName = "nama_sk"
        Me.nama_sk.FillWeight = 149.7623!
        Me.nama_sk.HeaderText = "Stasiun Kerja (SK)"
        Me.nama_sk.Name = "nama_sk"
        Me.nama_sk.ReadOnly = True
        '
        'waktu
        '
        Me.waktu.DataPropertyName = "waktu"
        Me.waktu.FillWeight = 83.24146!
        Me.waktu.HeaderText = "Waktu Proses/Unit (menit)"
        Me.waktu.Name = "waktu"
        Me.waktu.ReadOnly = True
        '
        'jumlah_pekerja
        '
        Me.jumlah_pekerja.DataPropertyName = "jumlah_pekerja"
        Me.jumlah_pekerja.FillWeight = 83.24146!
        Me.jumlah_pekerja.HeaderText = "Jumlah Pekerja (Orang)"
        Me.jumlah_pekerja.Name = "jumlah_pekerja"
        Me.jumlah_pekerja.ReadOnly = True
        '
        'upah
        '
        Me.upah.DataPropertyName = "upah"
        Me.upah.FillWeight = 53.92894!
        Me.upah.HeaderText = "Upah"
        Me.upah.Name = "upah"
        Me.upah.ReadOnly = True
        Me.upah.Visible = False
        '
        'upah_karyawan
        '
        Me.upah_karyawan.DataPropertyName = "upah_karyawan"
        Me.upah_karyawan.HeaderText = "Upah Tenaga Kerja (Rp/Orang)"
        Me.upah_karyawan.Name = "upah_karyawan"
        Me.upah_karyawan.ReadOnly = True
        '
        'biaya_proses
        '
        Me.biaya_proses.DataPropertyName = "biaya_proses"
        Me.biaya_proses.FillWeight = 83.24146!
        Me.biaya_proses.HeaderText = "Biaya Tetap (Rp/menit.unit)"
        Me.biaya_proses.Name = "biaya_proses"
        Me.biaya_proses.ReadOnly = True
        '
        'biaya_tetap
        '
        Me.biaya_tetap.DataPropertyName = "biaya_tetap"
        Me.biaya_tetap.FillWeight = 83.24146!
        Me.biaya_tetap.HeaderText = "Biaya Tetap (Rp/menit)"
        Me.biaya_tetap.Name = "biaya_tetap"
        Me.biaya_tetap.ReadOnly = True
        '
        'biaya_kebutuhan
        '
        Me.biaya_kebutuhan.DataPropertyName = "biaya_kebutuhan"
        Me.biaya_kebutuhan.FillWeight = 83.24146!
        Me.biaya_kebutuhan.HeaderText = "Biaya Variabel (Rp)"
        Me.biaya_kebutuhan.Name = "biaya_kebutuhan"
        Me.biaya_kebutuhan.ReadOnly = True
        '
        'biaya_sk
        '
        Me.biaya_sk.DataPropertyName = "biaya_sk"
        Me.biaya_sk.HeaderText = "Biaya/SK (Rp)"
        Me.biaya_sk.Name = "biaya_sk"
        Me.biaya_sk.ReadOnly = True
        '
        'Laporan_sk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.harga_jual)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.hpp)
        Me.Controls.Add(Me.total_biaya_variable)
        Me.Controls.Add(Me.total_biaya_tetap)
        Me.Controls.Add(Me.total_biaya_proses)
        Me.Controls.Add(Me.total_waktu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nama_produk)
        Me.Controls.Add(Me.Id_produk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataLaporanSK)
        Me.MaximizeBox = False
        Me.Name = "Laporan_sk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Harga Pokok Produksi"
        CType(Me.DataLaporanSK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataLaporanSK As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Id_produk As System.Windows.Forms.Label
    Friend WithEvents nama_produk As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents total_waktu As System.Windows.Forms.Label
    Friend WithEvents total_biaya_proses As System.Windows.Forms.Label
    Friend WithEvents total_biaya_tetap As System.Windows.Forms.Label
    Friend WithEvents total_biaya_variable As System.Windows.Forms.Label
    Friend WithEvents hpp As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents harga_jual As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents nomor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_sk_produk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_sk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents waktu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah_pekerja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents upah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents upah_karyawan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents biaya_proses As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents biaya_tetap As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents biaya_kebutuhan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents biaya_sk As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
