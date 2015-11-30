<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detail_kebutuhan
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button_Hapus = New System.Windows.Forms.Button
        Me.Button_Tambah = New System.Windows.Forms.Button
        Me.Data_Kebutuhan_Produk = New System.Windows.Forms.DataGridView
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_Kebutuhan_Produk = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_Produk_header = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_Kebutuhan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nama_Kebutuhan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.satuan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.jenis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.watt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.umur_pemakaian = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_Produk = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.Data_Kebutuhan_Produk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Input Produk"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button_Hapus)
        Me.GroupBox1.Controls.Add(Me.Button_Tambah)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 509)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(779, 52)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operasi"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(698, 18)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Kembali"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button_Hapus
        '
        Me.Button_Hapus.Location = New System.Drawing.Point(90, 23)
        Me.Button_Hapus.Name = "Button_Hapus"
        Me.Button_Hapus.Size = New System.Drawing.Size(75, 23)
        Me.Button_Hapus.TabIndex = 2
        Me.Button_Hapus.Text = "Hapus"
        Me.Button_Hapus.UseVisualStyleBackColor = True
        '
        'Button_Tambah
        '
        Me.Button_Tambah.Location = New System.Drawing.Point(9, 23)
        Me.Button_Tambah.Name = "Button_Tambah"
        Me.Button_Tambah.Size = New System.Drawing.Size(75, 23)
        Me.Button_Tambah.TabIndex = 0
        Me.Button_Tambah.Text = "Tambah"
        Me.Button_Tambah.UseVisualStyleBackColor = True
        '
        'Data_Kebutuhan_Produk
        '
        Me.Data_Kebutuhan_Produk.AllowUserToAddRows = False
        Me.Data_Kebutuhan_Produk.AllowUserToDeleteRows = False
        Me.Data_Kebutuhan_Produk.AllowUserToResizeColumns = False
        Me.Data_Kebutuhan_Produk.AllowUserToResizeRows = False
        Me.Data_Kebutuhan_Produk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Data_Kebutuhan_Produk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Data_Kebutuhan_Produk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_Kebutuhan_Produk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomor, Me.Id_Kebutuhan_Produk, Me.Id_Produk_header, Me.Id_Kebutuhan, Me.Nama_Kebutuhan, Me.satuan, Me.jenis, Me.watt, Me.Jumlah, Me.umur_pemakaian})
        Me.Data_Kebutuhan_Produk.Location = New System.Drawing.Point(12, 119)
        Me.Data_Kebutuhan_Produk.Name = "Data_Kebutuhan_Produk"
        Me.Data_Kebutuhan_Produk.ReadOnly = True
        Me.Data_Kebutuhan_Produk.RowHeadersVisible = False
        Me.Data_Kebutuhan_Produk.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Data_Kebutuhan_Produk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Data_Kebutuhan_Produk.Size = New System.Drawing.Size(760, 384)
        Me.Data_Kebutuhan_Produk.TabIndex = 5
        '
        'nomor
        '
        Me.nomor.DataPropertyName = "nomor"
        Me.nomor.FillWeight = 45.68528!
        Me.nomor.HeaderText = "No"
        Me.nomor.Name = "nomor"
        Me.nomor.ReadOnly = True
        '
        'Id_Kebutuhan_Produk
        '
        Me.Id_Kebutuhan_Produk.DataPropertyName = "id_kebutuhan_produk"
        Me.Id_Kebutuhan_Produk.FillWeight = 110.8629!
        Me.Id_Kebutuhan_Produk.HeaderText = "ID Kebutuhan Produk"
        Me.Id_Kebutuhan_Produk.Name = "Id_Kebutuhan_Produk"
        Me.Id_Kebutuhan_Produk.ReadOnly = True
        Me.Id_Kebutuhan_Produk.Visible = False
        '
        'Id_Produk_header
        '
        Me.Id_Produk_header.DataPropertyName = "id_produk"
        Me.Id_Produk_header.FillWeight = 110.8629!
        Me.Id_Produk_header.HeaderText = "ID Produk"
        Me.Id_Produk_header.Name = "Id_Produk_header"
        Me.Id_Produk_header.ReadOnly = True
        Me.Id_Produk_header.Visible = False
        '
        'Id_Kebutuhan
        '
        Me.Id_Kebutuhan.DataPropertyName = "id_kebutuhan"
        Me.Id_Kebutuhan.FillWeight = 110.8629!
        Me.Id_Kebutuhan.HeaderText = "ID Kebutuhan"
        Me.Id_Kebutuhan.Name = "Id_Kebutuhan"
        Me.Id_Kebutuhan.ReadOnly = True
        Me.Id_Kebutuhan.Visible = False
        '
        'Nama_Kebutuhan
        '
        Me.Nama_Kebutuhan.DataPropertyName = "nama_kebutuhan"
        Me.Nama_Kebutuhan.FillWeight = 110.8629!
        Me.Nama_Kebutuhan.HeaderText = "Input Produk"
        Me.Nama_Kebutuhan.Name = "Nama_Kebutuhan"
        Me.Nama_Kebutuhan.ReadOnly = True
        '
        'satuan
        '
        Me.satuan.DataPropertyName = "satuan"
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
        'watt
        '
        Me.watt.DataPropertyName = "watt"
        Me.watt.HeaderText = "Watt"
        Me.watt.Name = "watt"
        Me.watt.ReadOnly = True
        '
        'Jumlah
        '
        Me.Jumlah.DataPropertyName = "jumlah"
        Me.Jumlah.FillWeight = 110.8629!
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.ReadOnly = True
        '
        'umur_pemakaian
        '
        Me.umur_pemakaian.DataPropertyName = "umur_pemakaian"
        Me.umur_pemakaian.HeaderText = "Umur Pemakaian (bulan)"
        Me.umur_pemakaian.Name = "umur_pemakaian"
        Me.umur_pemakaian.ReadOnly = True
        '
        'Id_Produk
        '
        Me.Id_Produk.AutoSize = True
        Me.Id_Produk.Location = New System.Drawing.Point(13, 76)
        Me.Id_Produk.Name = "Id_Produk"
        Me.Id_Produk.Size = New System.Drawing.Size(0, 13)
        Me.Id_Produk.TabIndex = 6
        Me.Id_Produk.Visible = False
        '
        'Detail_kebutuhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.Id_Produk)
        Me.Controls.Add(Me.Data_Kebutuhan_Produk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Detail_kebutuhan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detail kebutuhan"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Data_Kebutuhan_Produk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_Tambah As System.Windows.Forms.Button
    Friend WithEvents Button_Hapus As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Data_Kebutuhan_Produk As System.Windows.Forms.DataGridView
    Friend WithEvents Id_Produk As System.Windows.Forms.Label
    Friend WithEvents nomor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Kebutuhan_Produk As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Produk_header As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Kebutuhan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama_Kebutuhan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents satuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jenis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents watt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents umur_pemakaian As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
