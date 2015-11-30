<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan_Biaya_Variable
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
        Me.DataLaporanBiayaVariable = New System.Windows.Forms.DataGridView
        Me.nomor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nama_kebutuhan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.satuan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.harga_kebutuhan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.nama_sk = New System.Windows.Forms.Label
        Me.id_sk_produk = New System.Windows.Forms.Label
        Me.Id_produk = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.nama_produk = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.total_biaya_variable = New System.Windows.Forms.Label
        Me.no_sk = New System.Windows.Forms.Label
        CType(Me.DataLaporanBiayaVariable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataLaporanBiayaVariable
        '
        Me.DataLaporanBiayaVariable.AllowUserToAddRows = False
        Me.DataLaporanBiayaVariable.AllowUserToDeleteRows = False
        Me.DataLaporanBiayaVariable.AllowUserToResizeColumns = False
        Me.DataLaporanBiayaVariable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataLaporanBiayaVariable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataLaporanBiayaVariable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataLaporanBiayaVariable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomor, Me.nama_kebutuhan, Me.satuan, Me.jumlah, Me.harga_kebutuhan, Me.total})
        Me.DataLaporanBiayaVariable.Location = New System.Drawing.Point(12, 104)
        Me.DataLaporanBiayaVariable.Name = "DataLaporanBiayaVariable"
        Me.DataLaporanBiayaVariable.ReadOnly = True
        Me.DataLaporanBiayaVariable.RowHeadersVisible = False
        Me.DataLaporanBiayaVariable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataLaporanBiayaVariable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataLaporanBiayaVariable.Size = New System.Drawing.Size(766, 332)
        Me.DataLaporanBiayaVariable.TabIndex = 0
        '
        'nomor
        '
        Me.nomor.DataPropertyName = "nomor"
        Me.nomor.HeaderText = "No"
        Me.nomor.Name = "nomor"
        Me.nomor.ReadOnly = True
        '
        'nama_kebutuhan
        '
        Me.nama_kebutuhan.DataPropertyName = "nama_kebutuhan"
        Me.nama_kebutuhan.HeaderText = "Jenis Kebutuhan bahan meterial"
        Me.nama_kebutuhan.Name = "nama_kebutuhan"
        Me.nama_kebutuhan.ReadOnly = True
        '
        'satuan
        '
        Me.satuan.DataPropertyName = "satuan"
        Me.satuan.HeaderText = "Satuan"
        Me.satuan.Name = "satuan"
        Me.satuan.ReadOnly = True
        '
        'jumlah
        '
        Me.jumlah.DataPropertyName = "jumlah"
        Me.jumlah.HeaderText = "Jumlah Kebutuhan"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.ReadOnly = True
        '
        'harga_kebutuhan
        '
        Me.harga_kebutuhan.DataPropertyName = "harga_kebutuhan"
        Me.harga_kebutuhan.HeaderText = "Biaya Kebutuhan (Rp)"
        Me.harga_kebutuhan.Name = "harga_kebutuhan"
        Me.harga_kebutuhan.ReadOnly = True
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        Me.total.HeaderText = "Total Biaya Kebutuhan (Rp)"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(274, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Biaya Variabel"
        '
        'nama_sk
        '
        Me.nama_sk.AutoSize = True
        Me.nama_sk.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.nama_sk.Location = New System.Drawing.Point(228, 49)
        Me.nama_sk.Name = "nama_sk"
        Me.nama_sk.Size = New System.Drawing.Size(125, 29)
        Me.nama_sk.TabIndex = 2
        Me.nama_sk.Text = "nama_sk"
        Me.nama_sk.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'id_sk_produk
        '
        Me.id_sk_produk.AutoSize = True
        Me.id_sk_produk.Location = New System.Drawing.Point(34, 49)
        Me.id_sk_produk.Name = "id_sk_produk"
        Me.id_sk_produk.Size = New System.Drawing.Size(71, 13)
        Me.id_sk_produk.TabIndex = 3
        Me.id_sk_produk.Text = "id_sk_produk"
        Me.id_sk_produk.Visible = False
        '
        'Id_produk
        '
        Me.Id_produk.AutoSize = True
        Me.Id_produk.Location = New System.Drawing.Point(35, 66)
        Me.Id_produk.Name = "Id_produk"
        Me.Id_produk.Size = New System.Drawing.Size(55, 13)
        Me.Id_produk.TabIndex = 4
        Me.Id_produk.Text = "Id_produk"
        Me.Id_produk.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 519)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(772, 42)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opsi"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(691, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "kembali"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nama_produk
        '
        Me.nama_produk.AutoSize = True
        Me.nama_produk.Location = New System.Drawing.Point(37, 24)
        Me.nama_produk.Name = "nama_produk"
        Me.nama_produk.Size = New System.Drawing.Size(72, 13)
        Me.nama_produk.TabIndex = 6
        Me.nama_produk.Text = "nama_produk"
        Me.nama_produk.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(219, 465)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total Biaya Variable (Rp)"
        '
        'total_biaya_variable
        '
        Me.total_biaya_variable.AutoSize = True
        Me.total_biaya_variable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_biaya_variable.Location = New System.Drawing.Point(409, 465)
        Me.total_biaya_variable.Name = "total_biaya_variable"
        Me.total_biaya_variable.Size = New System.Drawing.Size(169, 20)
        Me.total_biaya_variable.TabIndex = 8
        Me.total_biaya_variable.Text = "total_biaya_variable"
        '
        'no_sk
        '
        Me.no_sk.AutoSize = True
        Me.no_sk.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.no_sk.Location = New System.Drawing.Point(173, 49)
        Me.no_sk.Name = "no_sk"
        Me.no_sk.Size = New System.Drawing.Size(62, 29)
        Me.no_sk.TabIndex = 9
        Me.no_sk.Text = "(no)"
        '
        'Laporan_Biaya_Variable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.no_sk)
        Me.Controls.Add(Me.total_biaya_variable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nama_produk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Id_produk)
        Me.Controls.Add(Me.id_sk_produk)
        Me.Controls.Add(Me.nama_sk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataLaporanBiayaVariable)
        Me.MaximizeBox = False
        Me.Name = "Laporan_Biaya_Variable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Biaya Variable"
        CType(Me.DataLaporanBiayaVariable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataLaporanBiayaVariable As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nama_sk As System.Windows.Forms.Label
    Friend WithEvents id_sk_produk As System.Windows.Forms.Label
    Friend WithEvents Id_produk As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents nama_produk As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents total_biaya_variable As System.Windows.Forms.Label
    Friend WithEvents nomor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_kebutuhan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents satuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents harga_kebutuhan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no_sk As System.Windows.Forms.Label
End Class
